namespace pjrAtiv
{
    partial class TelaAbrirConta
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
            txtSaldo = new TextBox();
            lblSaldo = new Label();
            txtCriarSenhaConta = new TextBox();
            txtConfirmarSenhaConta = new TextBox();
            lblCriarSenhaConta = new Label();
            lblConfirmarSenhaConta = new Label();
            btnCriarConta = new Button();
            cmbTipoConta = new ComboBox();
            lblTipoConta = new Label();
            SuspendLayout();
            // 
            // txtSaldo
            // 
            txtSaldo.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtSaldo.Location = new Point(54, 71);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(171, 31);
            txtSaldo.TabIndex = 0;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(51, 53);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(65, 15);
            lblSaldo.TabIndex = 1;
            lblSaldo.Text = "Valor Saldo";
            lblSaldo.Click += label1_Click;
            // 
            // txtCriarSenhaConta
            // 
            txtCriarSenhaConta.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtCriarSenhaConta.Location = new Point(54, 186);
            txtCriarSenhaConta.Name = "txtCriarSenhaConta";
            txtCriarSenhaConta.Size = new Size(171, 31);
            txtCriarSenhaConta.TabIndex = 2;
            // 
            // txtConfirmarSenhaConta
            // 
            txtConfirmarSenhaConta.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmarSenhaConta.Location = new Point(51, 238);
            txtConfirmarSenhaConta.Name = "txtConfirmarSenhaConta";
            txtConfirmarSenhaConta.Size = new Size(171, 31);
            txtConfirmarSenhaConta.TabIndex = 3;
            txtConfirmarSenhaConta.TextChanged += txtConfirmarSenha_TextChanged;
            // 
            // lblCriarSenhaConta
            // 
            lblCriarSenhaConta.AutoSize = true;
            lblCriarSenhaConta.Location = new Point(51, 168);
            lblCriarSenhaConta.Name = "lblCriarSenhaConta";
            lblCriarSenhaConta.Size = new Size(67, 15);
            lblCriarSenhaConta.TabIndex = 4;
            lblCriarSenhaConta.Text = "Criar Senha";
            // 
            // lblConfirmarSenhaConta
            // 
            lblConfirmarSenhaConta.AutoSize = true;
            lblConfirmarSenhaConta.Location = new Point(54, 220);
            lblConfirmarSenhaConta.Name = "lblConfirmarSenhaConta";
            lblConfirmarSenhaConta.Size = new Size(96, 15);
            lblConfirmarSenhaConta.TabIndex = 5;
            lblConfirmarSenhaConta.Text = "Confirmar Senha";
            // 
            // btnCriarConta
            // 
            btnCriarConta.Location = new Point(51, 295);
            btnCriarConta.Name = "btnCriarConta";
            btnCriarConta.Size = new Size(75, 23);
            btnCriarConta.TabIndex = 6;
            btnCriarConta.Text = "Criar Conta";
            btnCriarConta.UseVisualStyleBackColor = true;
            btnCriarConta.Click += btnCriarConta_Click;
            // 
            // cmbTipoConta
            // 
            cmbTipoConta.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoConta.FormattingEnabled = true;
            cmbTipoConta.Items.AddRange(new object[] { "Poupança", "Corrente" });
            cmbTipoConta.Location = new Point(54, 134);
            cmbTipoConta.Name = "cmbTipoConta";
            cmbTipoConta.Size = new Size(121, 31);
            cmbTipoConta.TabIndex = 7;
            // 
            // lblTipoConta
            // 
            lblTipoConta.AutoSize = true;
            lblTipoConta.Location = new Point(51, 116);
            lblTipoConta.Name = "lblTipoConta";
            lblTipoConta.Size = new Size(62, 15);
            lblTipoConta.TabIndex = 8;
            lblTipoConta.Text = "TipoConta";
            // 
            // TelaAbrirConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 476);
            Controls.Add(lblTipoConta);
            Controls.Add(cmbTipoConta);
            Controls.Add(btnCriarConta);
            Controls.Add(lblConfirmarSenhaConta);
            Controls.Add(lblCriarSenhaConta);
            Controls.Add(txtConfirmarSenhaConta);
            Controls.Add(txtCriarSenhaConta);
            Controls.Add(lblSaldo);
            Controls.Add(txtSaldo);
            Name = "TelaAbrirConta";
            Text = "TelaAbrirConta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSaldo;
        private Label lblSaldo;
        private TextBox txtCriarSenhaConta;
        private TextBox txtConfirmarSenhaConta;
        private Label lblCriarSenhaConta;
        private Label lblConfirmarSenhaConta;
        private Button btnCriarConta;
        private ComboBox cmbTipoConta;
        private Label lblTipoConta;
    }
}