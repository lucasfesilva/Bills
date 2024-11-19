namespace Bills.Views
{
    partial class CadFatura
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
            lvlTotal = new Label();
            label1 = new Label();
            btnSalvar = new Button();
            groupBox2 = new GroupBox();
            btnEdit = new Button();
            btnRmvItem = new Button();
            btnAddItem = new Button();
            dataGridView1 = new DataGridView();
            cbClientes = new ComboBox();
            lblCliente = new Label();
            lbDataEmissao = new Label();
            dateTime = new DateTimePicker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lvlTotal);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(cbClientes);
            groupBox1.Controls.Add(lblCliente);
            groupBox1.Controls.Add(lbDataEmissao);
            groupBox1.Controls.Add(dateTime);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(746, 529);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fatura";
            // 
            // lvlTotal
            // 
            lvlTotal.AutoSize = true;
            lvlTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lvlTotal.Location = new Point(638, 442);
            lvlTotal.Name = "lvlTotal";
            lvlTotal.Size = new Size(0, 21);
            lvlTotal.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(547, 442);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 6;
            label1.Text = "Valor Total:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(659, 500);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(btnRmvItem);
            groupBox2.Controls.Add(btnAddItem);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(12, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(728, 341);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Itens da Fatura";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(535, 31);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(85, 23);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Editar Item";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRmvItem
            // 
            btnRmvItem.Location = new Point(626, 31);
            btnRmvItem.Name = "btnRmvItem";
            btnRmvItem.Size = new Size(96, 23);
            btnRmvItem.TabIndex = 2;
            btnRmvItem.Text = "Remover Item";
            btnRmvItem.UseVisualStyleBackColor = true;
            btnRmvItem.Click += btnRmvItem_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(424, 31);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(105, 23);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "Adicionar Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(716, 273);
            dataGridView1.TabIndex = 0;
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(65, 32);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(301, 23);
            cbClientes.TabIndex = 3;
            cbClientes.DropDown += cbClientes_DropDown;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(12, 38);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(47, 15);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "Cliente:";
            // 
            // lbDataEmissao
            // 
            lbDataEmissao.AutoSize = true;
            lbDataEmissao.Location = new Point(398, 35);
            lbDataEmissao.Name = "lbDataEmissao";
            lbDataEmissao.Size = new Size(96, 15);
            lbDataEmissao.TabIndex = 1;
            lbDataEmissao.Text = "Data de Emissão:";
            // 
            // dateTime
            // 
            dateTime.Location = new Point(500, 29);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(234, 23);
            dateTime.TabIndex = 0;
            // 
            // CadFatura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 553);
            Controls.Add(groupBox1);
            Name = "CadFatura";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nova Fatura";
            Load += CadFatura_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dateTime;
        private ComboBox cbClientes;
        private Label lblCliente;
        private Label lbDataEmissao;
        private GroupBox groupBox2;
        private Button btnAddItem;
        private DataGridView dataGridView1;
        private Button btnSalvar;
        private Button btnRmvItem;
        private Label label1;
        private Label lvlTotal;
        private Button btnEdit;
    }
}