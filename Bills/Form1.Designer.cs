namespace Bills
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            btnNovaFatura = new Button();
            groupBox1 = new GroupBox();
            groupBox4 = new GroupBox();
            txtPesquisa = new TextBox();
            label1 = new Label();
            btnRmv = new Button();
            btnEdit = new Button();
            groupBox3 = new GroupBox();
            btToCsv = new Button();
            dbTotalAno = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dbTopFaturas = new RadioButton();
            rbTotalCliente = new RadioButton();
            groupBox2 = new GroupBox();
            btnCadCliente = new Button();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(724, 315);
            dataGridView1.TabIndex = 0;
            // 
            // btnNovaFatura
            // 
            btnNovaFatura.Location = new Point(16, 44);
            btnNovaFatura.Name = "btnNovaFatura";
            btnNovaFatura.Size = new Size(93, 23);
            btnNovaFatura.TabIndex = 1;
            btnNovaFatura.Text = "Fatura";
            btnNovaFatura.UseVisualStyleBackColor = true;
            btnNovaFatura.Click += btnNovaFatura_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(789, 544);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Faturas";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtPesquisa);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(btnRmv);
            groupBox4.Controls.Add(btnEdit);
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(15, 128);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(758, 399);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Resumo das Faturas";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(116, 36);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(227, 23);
            txtPesquisa.TabIndex = 4;
            txtPesquisa.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 39);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 3;
            label1.Text = "Pesquisar fatura:";
            // 
            // btnRmv
            // 
            btnRmv.Location = new Point(665, 35);
            btnRmv.Name = "btnRmv";
            btnRmv.Size = new Size(75, 23);
            btnRmv.TabIndex = 2;
            btnRmv.Text = "Excluir";
            btnRmv.UseVisualStyleBackColor = true;
            btnRmv.Click += btnRmv_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(584, 35);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btToCsv);
            groupBox3.Controls.Add(dbTotalAno);
            groupBox3.Controls.Add(radioButton2);
            groupBox3.Controls.Add(radioButton1);
            groupBox3.Controls.Add(dbTopFaturas);
            groupBox3.Controls.Add(rbTotalCliente);
            groupBox3.Location = new Point(241, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(532, 100);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Gerar Relatórios";
            // 
            // btToCsv
            // 
            btToCsv.Location = new Point(411, 66);
            btToCsv.Name = "btToCsv";
            btToCsv.Size = new Size(106, 23);
            btToCsv.TabIndex = 5;
            btToCsv.Text = "Exportar .csv";
            btToCsv.UseVisualStyleBackColor = true;
            // 
            // dbTotalAno
            // 
            dbTotalAno.AutoSize = true;
            dbTotalAno.Location = new Point(427, 32);
            dbTotalAno.Name = "dbTotalAno";
            dbTotalAno.Size = new Size(87, 19);
            dbTotalAno.TabIndex = 4;
            dbTotalAno.TabStop = true;
            dbTotalAno.Text = "Total p/Ano";
            dbTotalAno.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(327, 32);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(87, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Total p/Mês";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(234, 32);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(87, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Top 10 Itens";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // dbTopFaturas
            // 
            dbTopFaturas.AutoSize = true;
            dbTopFaturas.Location = new Point(127, 32);
            dbTopFaturas.Name = "dbTopFaturas";
            dbTopFaturas.Size = new Size(100, 19);
            dbTopFaturas.TabIndex = 1;
            dbTopFaturas.TabStop = true;
            dbTopFaturas.Text = "Top 10 Faturas";
            dbTopFaturas.UseVisualStyleBackColor = true;
            // 
            // rbTotalCliente
            // 
            rbTotalCliente.AutoSize = true;
            rbTotalCliente.Location = new Point(6, 32);
            rbTotalCliente.Name = "rbTotalCliente";
            rbTotalCliente.Size = new Size(111, 19);
            rbTotalCliente.TabIndex = 0;
            rbTotalCliente.TabStop = true;
            rbTotalCliente.Text = "Total por Cliente";
            rbTotalCliente.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCadCliente);
            groupBox2.Controls.Add(btnNovaFatura);
            groupBox2.Location = new Point(15, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(220, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cadastro";
            // 
            // btnCadCliente
            // 
            btnCadCliente.Location = new Point(115, 44);
            btnCadCliente.Name = "btnCadCliente";
            btnCadCliente.Size = new Size(93, 23);
            btnCadCliente.TabIndex = 2;
            btnCadCliente.Text = "Clientes";
            btnCadCliente.UseVisualStyleBackColor = true;
            btnCadCliente.Click += btnCadCliente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 557);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciador de Faturas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnNovaFatura;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnCadCliente;
        private GroupBox groupBox4;
        private Button btnEdit;
        private GroupBox groupBox3;
        private Button btnRmv;
        private RadioButton dbTotalAno;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton dbTopFaturas;
        private RadioButton rbTotalCliente;
        private Button btToCsv;
        private TextBox txtPesquisa;
        private Label label1;
        private BindingSource bindingSource1;
    }
}
