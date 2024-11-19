using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bills.Models;

namespace Bills.Views
{
    public partial class AdicionarItemModal : Form
    {
        public Item NovoItem { get; set; }
        public AdicionarItemModal()
        {
            InitializeComponent();
        }

        public AdicionarItemModal(int id, string? descricao, decimal precoUnitario, int quantidade)
        {
            InitializeComponent();

            txtDescricao.Text = descricao;
            txtValorUnitario.Text = precoUnitario.ToString();
            numericQuantidade.Value = quantidade;
        }

        private void AdicionarItemModal_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int valorUnitario = Convert.ToInt32(txtValorUnitario.Text);

            if (txtDescricao.Text == null || txtDescricao.Text == "")
            {
                MessageBox.Show("A descrição do item é obrigatória", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (valorUnitario > 999)
            {
                DialogResult result = MessageBox.Show(
                    "Valor unitário excede o valor de R$1000,00. Deseja inserir o item mesmo assim?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                    return;
            }

            CriarNovoItem();
            FecharDialog();
        }

        private void CriarNovoItem()
        {
            NovoItem = new Item
            {
                Descricao = txtDescricao.Text,
                PrecoUnitario = Convert.ToDecimal(txtValorUnitario.Text),
                Quantidade = Convert.ToInt32(numericQuantidade.Value)
            };
        }

        private void FecharDialog()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void TxtValorUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') && (txtValorUnitario.Text.Contains(".") || txtValorUnitario.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }
    }
}
