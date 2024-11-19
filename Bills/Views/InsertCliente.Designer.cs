namespace Bills.Views
{
    partial class InsertCliente
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
            btnSalvar = new Button();
            txtCpf = new TextBox();
            txtSobrenome = new TextBox();
            txtNome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(txtCpf);
            groupBox1.Controls.Add(txtSobrenome);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(507, 191);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(426, 162);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(99, 105);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(232, 23);
            txtCpf.TabIndex = 5;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(99, 65);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(232, 23);
            txtSobrenome.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(99, 29);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(232, 23);
            txtNome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 113);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 73);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 1;
            label2.Text = "Sobrenome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 37);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // InsertCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 215);
            Controls.Add(groupBox1);
            Name = "InsertCliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cliente";
            Load += Cliente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSalvar;
        private TextBox txtCpf;
        private TextBox txtSobrenome;
        private TextBox txtNome;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}