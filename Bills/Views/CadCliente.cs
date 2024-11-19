using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bills.Data;
using Bills.Models;

namespace Bills.Views
{
    public partial class CadCliente : Form
    {
        private readonly AppDbContext _context;
        public CadCliente(AppDbContext dbContext)
        {
            _context = dbContext;
            InitializeComponent();
        }

        private void CadCliente_Load(object sender, EventArgs e)
        {
            CarregaClientes();
            ConfiguraGrid();
        }

        private void ConfiguraGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.ClearSelection();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.CurrentCell = null;
        }

        private void CarregaClientes()
        {
            var clientes = _context.Clientes
                .Select(c => new
                {
                    c.Id,
                    c.Nome,
                    c.Sobrenome,
                    c.Cpf
                })
                .ToList();
            dataGridView1.DataSource = clientes;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];

            try
            {
                var id = Convert.ToInt32(row.Cells["Id"].Value);
                var nome = row.Cells["Nome"].Value.ToString();
                var sobrenome = row.Cells["Sobrenome"].Value.ToString();
                var cpf = row.Cells["Cpf"].Value.ToString();

                InsertCliente cliente = new InsertCliente(id, nome, sobrenome, cpf, _context);
                if (Application.OpenForms.OfType<InsertCliente>().Count() > 0)
                {
                    cliente.Activate();
                }
                else
                {
                    cliente.ClienteAtualizado += CarregaClientes;
                    if (cliente.ShowDialog() == DialogResult.OK)
                    {
                        var novoCliente = cliente.NovoCliente;
                        row.Cells["Nome"].Value = novoCliente.Nome;
                        row.Cells["Sobrenome"].Value = novoCliente.Sobrenome;
                        row.Cells["Cpf"].Value = novoCliente.Cpf;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione ao menos 1 Cliente para editar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            InsertCliente cliente = new InsertCliente(_context);
            if (Application.OpenForms.OfType<InsertCliente>().Count() > 0)
            {
                cliente.Activate();
            }
            else
            {
                cliente.ClienteAtualizado += CarregaClientes;
                cliente.ShowDialog();
            }
        }

        private void btnRmv_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                var confirmarResult = MessageBox.Show(
                    "Tem certeza que deseja deletar este cliente?",
                    "Confirmação",
                    MessageBoxButtons.YesNo);

                if (confirmarResult == DialogResult.Yes)
                {
                    var item = _context.Clientes.FirstOrDefault(c => c.Id == id);

                    if (item != null)
                    {
                        _context.Clientes.Remove(item);
                        _context.SaveChanges();

                        CarregaClientes();

                        MessageBox.Show("Cliente deletado com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum cliente selecionado!");
            }
        }
    }
}
