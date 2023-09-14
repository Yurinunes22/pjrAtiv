namespace pjrAtiv
{
    partial class TelaDeposito
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
            lblDeposito = new Label();
            lblSaldo = new Label();
            lblValorDeposito = new Label();
            lblinsiraValor = new Label();
            txtValorDeposito = new TextBox();
            txtSenhaDeposito = new TextBox();
            btnConfirmacao = new Button();
            btnVoltarDeposito = new Button();
            SuspendLayout();
            // 
            // lblDeposito
            // 
            lblDeposito.AutoSize = true;
            lblDeposito.Location = new Point(21, 19);
            lblDeposito.Name = "lblDeposito";
            lblDeposito.Size = new Size(54, 15);
            lblDeposito.TabIndex = 6;
            lblDeposito.Text = "Depósito";
            lblDeposito.Click += lblExtrato_Click;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(21, 51);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(69, 15);
            lblSaldo.TabIndex = 5;
            lblSaldo.Text = "Saldo: 50.00";
            lblSaldo.Click += lblSaldo_Click;
            // 
            // lblValorDeposito
            // 
            lblValorDeposito.AutoSize = true;
            lblValorDeposito.Location = new Point(498, 19);
            lblValorDeposito.Name = "lblValorDeposito";
            lblValorDeposito.Size = new Size(89, 15);
            lblValorDeposito.TabIndex = 4;
            lblValorDeposito.Text = "Valor Depósito :";
            lblValorDeposito.Click += lblNomeCliente_Click;
            // 
            // lblinsiraValor
            // 
            lblinsiraValor.AutoSize = true;
            lblinsiraValor.Location = new Point(498, 89);
            lblinsiraValor.Name = "lblinsiraValor";
            lblinsiraValor.Size = new Size(191, 15);
            lblinsiraValor.TabIndex = 7;
            lblinsiraValor.Text = "Insira o valor que deseja depositar :";
            // 
            // txtValorDeposito
            // 
            txtValorDeposito.Location = new Point(498, 144);
            txtValorDeposito.Name = "txtValorDeposito";
            txtValorDeposito.PlaceholderText = "00,00";
            txtValorDeposito.Size = new Size(191, 23);
            txtValorDeposito.TabIndex = 8;
            // 
            // txtSenhaDeposito
            // 
            txtSenhaDeposito.Location = new Point(498, 186);
            txtSenhaDeposito.Name = "txtSenhaDeposito";
            txtSenhaDeposito.PlaceholderText = "Senha:****";
            txtSenhaDeposito.Size = new Size(191, 23);
            txtSenhaDeposito.TabIndex = 9;
            // 
            // btnConfirmacao
            // 
            btnConfirmacao.Location = new Point(498, 236);
            btnConfirmacao.Name = "btnConfirmacao";
            btnConfirmacao.Size = new Size(191, 23);
            btnConfirmacao.TabIndex = 10;
            btnConfirmacao.Text = "Confirmar Depósito ";
            btnConfirmacao.UseVisualStyleBackColor = true;
            btnConfirmacao.Click += button1_Click;
            // 
            // btnVoltarDeposito
            // 
            btnVoltarDeposito.Location = new Point(614, 382);
            btnVoltarDeposito.Name = "btnVoltarDeposito";
            btnVoltarDeposito.Size = new Size(75, 23);
            btnVoltarDeposito.TabIndex = 12;
            btnVoltarDeposito.Text = "Voltar";
            btnVoltarDeposito.UseVisualStyleBackColor = true;
            btnVoltarDeposito.Click += btnVoltarDeposito_Click;
            // 
            // TelaDeposito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltarDeposito);
            Controls.Add(btnConfirmacao);
            Controls.Add(txtSenhaDeposito);
            Controls.Add(txtValorDeposito);
            Controls.Add(lblinsiraValor);
            Controls.Add(lblDeposito);
            Controls.Add(lblSaldo);
            Controls.Add(lblValorDeposito);
            Name = "TelaDeposito";
            Load += TelaDeposito_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDeposito;
        private Label lblSaldo;
        private Label lblValorDeposito;
        private Label lblinsiraValor;
        private TextBox txtValorDeposito;
        private TextBox txtSenhaDeposito;
        private Button btnConfirmacao;
        private Button btnVoltarDeposito;
    }
}