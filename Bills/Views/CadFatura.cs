using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bills.Data;
using Bills.Models;

namespace Bills.Views
{
    public partial class CadFatura : Form
    {
        private readonly AppDbContext _context;
        private int _ultimoIdGerado;
        private int idFatura;
        public CadFatura(AppDbContext dbContext)
        {
            _context = dbContext;
            InitializeComponent();
        }

        public CadFatura(int id, AppDbContext dbContext)
        {
            InitializeComponent();
            this.idFatura = id;
            _context = dbContext;            
            CarregaFatura(idFatura);
        }

        private void CadFatura_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();

            _ultimoIdGerado = _context.ItensFatura.Any()
                ? _context.ItensFatura.Max(x => x.Id) + 10
                : 10;
        }

        private void ConfigurarGrid()
        {
            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Descricao", "Descrição");
            dataGridView1.Columns.Add("PrecoUnitario", "Valor");
            dataGridView1.Columns.Add("Quantidade", "Quantidade");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.CurrentCell = null;
        }

        private void CarregaClientes()
        {
            var clientes = _context.Clientes
                .Select(c => new
                {
                    c.Id,
                    Nome = c.Id + " - " + c.Nome + " " + c.Sobrenome + " " + c.Cpf
                }).ToList();
            cbClientes.DataSource = clientes;
            cbClientes.DisplayMember = "Nome";
            cbClientes.ValueMember = "Id";
        }

        private void CarregaFatura(int idFatura)
        {
            var dados = _context.Faturas
                .Include(f => f.Cliente)
                .Include(f => f.Itens)
                .Select(f => new
                {
                    ClienteId = f.Cliente.Id,
                    Nome = f.Cliente.Nome,
                    FaturaId = f.Id,
                    DataEmissao = f.DataEmissao,
                    Itens = f.Itens.Select(i => new
                    {
                        i.Id,
                        i.Descricao,
                        i.PrecoUnitario,
                        i.Quantidade
                    }).ToList(),
                    ValorTotal = f.ValorTotal
                }).ToList();

            if (dados.Any())
            {
                int clienteID = dados.First().ClienteId;
                selecionarCliente(clienteID);
            }

            foreach (var fatura in dados)
            {
                Console.WriteLine($"Cliente: {fatura.Nome}");
                Console.WriteLine($"  Fatura ID: {fatura.FaturaId}, Data: {fatura.DataEmissao}, Valor Total: {fatura.ValorTotal}");

                foreach (var item in fatura.Itens)
                {
                    Console.WriteLine($"    Item: {item.Descricao}, Quantidade: {item.Quantidade}, Preço Unitário: {item.PrecoUnitario}");
                }
            }

        }

        private void selecionarCliente(int idCliente)
        {
            cbClientes.SelectedValue = idCliente;
        }

        private int ObterIdCliente()
        {
            int id;
            try
            {
                var idCliente = cbClientes.SelectedValue;
                id = Convert.ToInt32(idCliente);
            }
            catch (Exception ex)
            {
                return 0;
            }
            return id;
        }

        private void SomarFatura(decimal valor)
        {
            lvlTotal.Text = "R$" + valor.ToString();
        }

        private void AtualizaItens()
        {
            var itens = _context.ItensFatura.ToList();
            dataGridView1.Rows.Add(itens);
        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AdicionarItemModal adicionarItemModal = new AdicionarItemModal();
            if (Application.OpenForms.OfType<AdicionarItemModal>().Count() > 0)
            {
                adicionarItemModal.Activate();
            }
            else
            {
                if (adicionarItemModal.ShowDialog() == DialogResult.OK)
                {
                    var item = adicionarItemModal.NovoItem;
                    item.Id = _ultimoIdGerado;
                    dataGridView1.Rows.Add(item.Id, item.Descricao, item.PrecoUnitario, item.Quantidade);
                    SomarFatura(item.Quantidade * item.PrecoUnitario);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ObterIdCliente() == 0)
            {
                MessageBox.Show("Selecione um cliente antes de salvar a fatura!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("Insira ao menos 1 item na fatura para salvar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var novaFatura = new Fatura
            {
                ClienteId = ObterIdCliente(),
                DataEmissao = dateTime.Value,
                ValorTotal = 0,
                Itens = new List<Item>()
            };

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Descricao"].Value == null) continue;

                var novoItem = new Item
                {
                    Id = _ultimoIdGerado,
                    Descricao = row.Cells["Descricao"].Value.ToString(),
                    PrecoUnitario = Convert.ToDecimal(row.Cells["PrecoUnitario"].Value),
                    Quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value),
                    Fatura = novaFatura
                };
                _ultimoIdGerado += 10;
                novaFatura.Itens.Add(novoItem);
            }

            novaFatura.ValorTotal = novaFatura.Itens.Sum(item => item.Quantidade * item.PrecoUnitario);

            _context.Faturas.Add(novaFatura);
            _context.SaveChanges();
            MessageBox.Show("Fatura salva com sucesso!");

        }

        public List<Item> ObterItensDaFatura(int idFatura)
        {
            var fatura = _context.Faturas
                .Include(f => f.Itens)
                .FirstOrDefault(f => f.Id == idFatura);

            if (fatura != null)
            {
                return fatura.Itens.ToList();
            }
            else
            {
                return new List<Item>();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.Rows[0];

            try
            {
                var id = Convert.ToInt32(row.Cells["Id"].Value);
                var descricao = row.Cells["Descricao"].Value.ToString();
                var precoUnitario = Convert.ToDecimal(row.Cells["PrecoUnitario"].Value);
                var quantidade = Convert.ToInt32(row.Cells["Quantidade"].Value);

                AdicionarItemModal editarItemModal = new AdicionarItemModal(id, descricao, precoUnitario, quantidade);
                if (Application.OpenForms.OfType<AdicionarItemModal>().Count() > 0)
                {
                    editarItemModal.Activate();
                }
                else
                {
                    if (editarItemModal.ShowDialog() == DialogResult.OK)
                    {
                        var item = editarItemModal.NovoItem;
                        item.Id = _ultimoIdGerado;
                        row.Cells["Id"].Value = item.Id;
                        row.Cells["Descricao"].Value = item.Descricao;
                        row.Cells["Quantidade"].Value = item.Quantidade;
                        SomarFatura(item.Quantidade * item.PrecoUnitario);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione ao menos 1 item para editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cbClientes_DropDown(object sender, EventArgs e)
        {
            cbClientes.Items.Clear();
            CarregaClientes();
        }

        private void btnRmvItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                var confirmarResult = MessageBox.Show(
                    "Tem certeza que deseja deletar este item da fatura?",
                    "Confirmação",
                    MessageBoxButtons.YesNo);

                if (confirmarResult == DialogResult.Yes)
                {
                    var item = _context.ItensFatura.FirstOrDefault(x => x.Id == id);

                    if (item != null)
                    {
                        _context.ItensFatura.Remove(item);
                        _context.SaveChanges();

                        AtualizaItens();

                        MessageBox.Show("Item removido com sucesso!");
                    }
                    else
                    {
                        dataGridView1.Rows.Remove(selectedRow);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado!");
            }
        }
    }
}
