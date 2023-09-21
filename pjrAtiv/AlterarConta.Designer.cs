namespace pjrAtiv
{
    partial class AlterarConta
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
            lblContas = new Label();
            cmbidContas = new ComboBox();
            txtConfirmarSenha = new TextBox();
            lblSenha = new Label();
            btnAlterarConta = new Button();
            SuspendLayout();
            // 
            // lblContas
            // 
            lblContas.AutoSize = true;
            lblContas.Location = new Point(237, 93);
            lblContas.Name = "lblContas";
            lblContas.Size = new Size(44, 15);
            lblContas.TabIndex = 1;
            lblContas.Text = "Contas";
            // 
            // cmbidContas
            // 
            cmbidContas.FormattingEnabled = true;
            cmbidContas.Location = new Point(305, 85);
            cmbidContas.Name = "cmbidContas";
            cmbidContas.Size = new Size(121, 23);
            cmbidContas.TabIndex = 2;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(305, 140);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(100, 23);
            txtConfirmarSenha.TabIndex = 3;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(237, 148);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha";
            // 
            // btnAlterarConta
            // 
            btnAlterarConta.Location = new Point(305, 197);
            btnAlterarConta.Name = "btnAlterarConta";
            btnAlterarConta.Size = new Size(100, 23);
            btnAlterarConta.TabIndex = 5;
            btnAlterarConta.Text = "Alterar Conta";
            btnAlterarConta.UseVisualStyleBackColor = true;
            btnAlterarConta.Click += btnAlterarConta_Click;
            // 
            // AlterarConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAlterarConta);
            Controls.Add(lblSenha);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(cmbidContas);
            Controls.Add(lblContas);
            Name = "AlterarConta";
            Text = "AlterarConta";
            Load += AlterarConta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContas;
        private ComboBox cmbidContas;
        private TextBox txtConfirmarSenha;
        private Label lblSenha;
        private Button btnAlterarConta;
    }
}