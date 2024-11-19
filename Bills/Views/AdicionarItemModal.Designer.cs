namespace Bills.Views
{
    partial class AdicionarItemModal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnAdd = new Button();
            numericQuantidade = new NumericUpDown();
            label1 = new Label();
            txtValorUnitario = new TextBox();
            lblValor = new Label();
            txtDescricao = new TextBox();
            lblDescricao = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(numericQuantidade);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtValorUnitario);
            groupBox1.Controls.Add(lblValor);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(lblDescricao);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(593, 143);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Novo Item";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(512, 114);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Salvar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // numericQuantidade
            // 
            numericQuantidade.Location = new Point(109, 101);
            numericQuantidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericQuantidade.Name = "numericQuantidade";
            numericQuantidade.Size = new Size(52, 23);
            numericQuantidade.TabIndex = 5;
            numericQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 103);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 4;
            label1.Text = "Quantidade:";
            // 
            // txtValorUnitario
            // 
            txtValorUnitario.Location = new Point(109, 64);
            txtValorUnitario.Name = "txtValorUnitario";
            txtValorUnitario.Size = new Size(115, 23);
            txtValorUnitario.TabIndex = 3;
            txtValorUnitario.KeyPress += TxtValorUnitario_KeyPress;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(19, 67);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(81, 15);
            lblValor.TabIndex = 2;
            lblValor.Text = "Valor Unitário:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(109, 23);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(304, 23);
            txtDescricao.TabIndex = 1;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(19, 31);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(61, 15);
            lblDescricao.TabIndex = 0;
            lblDescricao.Text = "Descrição:";
            // 
            // AdicionarItemModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 167);
            Controls.Add(groupBox1);
            Name = "AdicionarItemModal";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Adicionar Item";
            Load += AdicionarItemModal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblDescricao;
        private Button btnAdd;
        private NumericUpDown numericQuantidade;
        private Label label1;
        private TextBox txtValorUnitario;
        private Label lblValor;
        private TextBox txtDescricao;
    }
}