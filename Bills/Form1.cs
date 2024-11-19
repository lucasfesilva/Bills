using Bills.Data;
using Bills.Views;

namespace Bills
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _context;
        public Form1(AppDbContext dbContext)
        {
            _context = dbContext;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();

            var faturas = _context.Faturas
                .Select(f => new
                {
                    f.Id,
                    Nome = f.Cliente.Nome + " " + f.Cliente.Sobrenome,
                    f.Cliente.Cpf,
                    f.DataEmissao,
                    f.ValorTotal
                })
                .ToList();

            dataGridView1.DataSource = faturas;
        }

        private void ConfigurarGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.ClearSelection();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.CurrentCell = null;
        }

        private void btnNovaFatura_Click(object sender, EventArgs e)
        {
            CadFatura cadFatura = new CadFatura(_context);
            if (Application.OpenForms.OfType<CadFatura>().Count() > 0)
            {
                cadFatura.Activate();
            }
            else
            {
                cadFatura.ShowDialog();
            }
        }


        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            CadCliente cadCliente = new CadCliente(_context);
            if (Application.OpenForms.OfType<CadCliente>().Count() > 0)
            {
                cadCliente.Activate();
            }
            else
            {
                cadCliente.ShowDialog();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text.ToLower();

            var resultados = _context.Faturas.AsQueryable();

            if (!string.IsNullOrEmpty(pesquisa))
            {
                resultados = resultados.Where(f => f.Cliente.Nome.ToLower().Contains(pesquisa) ||
                                                    f.Id.ToString().Contains(pesquisa));
            }

            dataGridView1.DataSource = resultados.Select(f => new
            {
                f.Id,
                Nome = f.Cliente.Nome,
                f.DataEmissao,
                f.ValorTotal,
            }).ToList();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0];

            try
            {
                var id = Convert.ToInt32(row.Cells["Id"].Value);

                CadFatura cadFatura = new CadFatura(id, _context);
                if (Application.OpenForms.OfType<CadFatura>().Count() > 0)
                {
                    cadFatura.Activate();
                }
                else
                {
                    cadFatura.ShowDialog();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void CarregaFaturas()
        {
            var clientes = _context.Faturas
                .Select(c => new
                {
                    c.Id,
                    c.Cliente.Nome,
                    c.Cliente.Cpf,
                    c.DataEmissao,
                    c.ValorTotal
                })
                .ToList();
            dataGridView1.DataSource = clientes;
        }

        private void btnRmv_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                var confirmarResult = MessageBox.Show(
                    "Tem certeza que deseja deletar essa Fatura?",
                    "Confirmação",
                    MessageBoxButtons.YesNo);

                if (confirmarResult == DialogResult.Yes)
                {
                    var item = _context.Faturas.FirstOrDefault(c => c.Id == id);

                    if (item != null)
                    {
                        _context.Faturas.Remove(item);
                        _context.SaveChanges();

                        CarregaFaturas();

                        MessageBox.Show("Fatura deletada com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Fatura não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma Fatura selecionado!");
            }
        }
    }
}
