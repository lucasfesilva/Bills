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
    public partial class InsertCliente : Form
    {

        public Cliente NovoCliente { get; set; }
        private readonly AppDbContext _context;
        public event Action ClienteAtualizado;
        private int _id;

        public InsertCliente(int id, string? nome, string? sobrenome, string? cpf, AppDbContext dbContext)
        {
            _context = dbContext;
            InitializeComponent();

            _id = id;
            txtNome.Text = nome;
            txtSobrenome.Text = sobrenome;
            txtCpf.Text = cpf;
        }

        public InsertCliente(AppDbContext dbContext)
        {
            _context = dbContext;
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void CriarCliente()
        {
            if (txtNome.Text.Length < 4 || txtCpf.Text.Length < 11)
            {
                MessageBox.Show("Os campos de Nome e CPF são obrigatórios!");
            }
            else
            {
                NovoCliente = new Cliente
                {
                    Nome = txtNome.Text,
                    Sobrenome = txtSobrenome.Text,
                    Cpf = txtCpf.Text,
                };

                _context.Add(NovoCliente);
                _context.SaveChanges();

                MessageBox.Show("Cliente gravado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AtualizarCliente(int clienteId)
        {
            var clienteExiste = _context.Clientes.FirstOrDefault(c => c.Id == clienteId);

            if (clienteExiste != null)
            {
                clienteExiste.Nome = txtNome.Text;
                clienteExiste.Sobrenome = txtSobrenome.Text;
                clienteExiste.Cpf = txtCpf.Text;

                NovoCliente = new Cliente
                {
                    Nome = clienteExiste.Nome,
                    Sobrenome = clienteExiste.Sobrenome,
                    Cpf = clienteExiste.Cpf
                };

                _context.SaveChanges();

                ClienteAtualizado?.Invoke();

                this.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (_id != 0)
            {
                AtualizarCliente(_id);
            }
            else
            {
                CriarCliente();                
            }
        }
    }
}
