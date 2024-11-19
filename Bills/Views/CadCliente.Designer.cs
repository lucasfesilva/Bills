namespace Bills.Views
{
    partial class CadCliente
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            btnRmv = new Button();
            btnEditar = new Button();
            btnCadCliente = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(662, 327);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRmv);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnCadCliente);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(674, 405);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Clientes";
            // 
            // btnRmv
            // 
            btnRmv.Location = new Point(431, 43);
            btnRmv.Name = "btnRmv";
            btnRmv.Size = new Size(75, 23);
            btnRmv.TabIndex = 3;
            btnRmv.Text = "Excluir";
            btnRmv.UseVisualStyleBackColor = true;
            btnRmv.Click += btnRmv_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(512, 43);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCadCliente
            // 
            btnCadCliente.Location = new Point(593, 43);
            btnCadCliente.Name = "btnCadCliente";
            btnCadCliente.Size = new Size(75, 23);
            btnCadCliente.TabIndex = 1;
            btnCadCliente.Text = "Novo";
            btnCadCliente.UseVisualStyleBackColor = true;
            btnCadCliente.Click += btnCadCliente_Click;
            // 
            // CadCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 429);
            Controls.Add(groupBox1);
            Name = "CadCliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Clientes";
            Load += CadCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Button btnRmv;
        private Button btnEditar;
        private Button btnCadCliente;
    }
}