namespace pjrAtiv
{
    partial class Extra
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
            txtValorDeposito = new TextBox();
            btnDepositar = new Button();
            lblSaldo = new Label();
            BtnSaque = new Button();
            btnVerSaldo = new Button();
            SuspendLayout();
            // 
            // txtValorDeposito
            // 
            txtValorDeposito.Location = new Point(12, 46);
            txtValorDeposito.Name = "txtValorDeposito";
            txtValorDeposito.Size = new Size(491, 23);
            txtValorDeposito.TabIndex = 0;
            txtValorDeposito.TextChanged += txtValorDeposito_TextChanged;
            // 
            // btnDepositar
            // 
            btnDepositar.Font = new Font("Rockwell Extra Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnDepositar.ForeColor = Color.SteelBlue;
            btnDepositar.Location = new Point(351, 202);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(128, 36);
            btnDepositar.TabIndex = 1;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += button1_Click;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldo.ForeColor = SystemColors.ControlLightLight;
            lblSaldo.Location = new Point(12, 106);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(141, 54);
            lblSaldo.TabIndex = 2;
            lblSaldo.Text = "Saldo: ";
            lblSaldo.Click += lblSaldo_Click;
            // 
            // BtnSaque
            // 
            BtnSaque.Font = new Font("Rockwell Extra Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSaque.ForeColor = Color.SteelBlue;
            BtnSaque.Location = new Point(188, 202);
            BtnSaque.Name = "BtnSaque";
            BtnSaque.Size = new Size(128, 36);
            BtnSaque.TabIndex = 3;
            BtnSaque.Text = "Saque";
            BtnSaque.UseVisualStyleBackColor = true;
            BtnSaque.Click += BtnSaque_Click;
            // 
            // btnVerSaldo
            // 
            btnVerSaldo.Font = new Font("Rockwell Extra Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerSaldo.ForeColor = Color.SteelBlue;
            btnVerSaldo.Location = new Point(28, 202);
            btnVerSaldo.Name = "btnVerSaldo";
            btnVerSaldo.Size = new Size(125, 36);
            btnVerSaldo.TabIndex = 4;
            btnVerSaldo.Text = "Ver Saldo";
            btnVerSaldo.UseVisualStyleBackColor = true;
            btnVerSaldo.Click += btnVerSaldo_Click;
            // 
            // Extra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(512, 356);
            Controls.Add(btnVerSaldo);
            Controls.Add(BtnSaque);
            Controls.Add(lblSaldo);
            Controls.Add(btnDepositar);
            Controls.Add(txtValorDeposito);
            Name = "Extra";
            Text = " ";
            Load += Extra_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValorDeposito;
        private Button btnDepositar;
        private Label lblSaldo;
        private Button BtnSaque;
        private Button btnVerSaldo;
    }
}