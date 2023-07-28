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
            SuspendLayout();
            // 
            // txtValorDeposito
            // 
            txtValorDeposito.Location = new Point(12, 46);
            txtValorDeposito.Name = "txtValorDeposito";
            txtValorDeposito.Size = new Size(491, 23);
            txtValorDeposito.TabIndex = 0;
            // 
            // btnDepositar
            // 
            btnDepositar.Font = new Font("Rockwell Extra Bold", 60F, FontStyle.Regular, GraphicsUnit.Point);
            btnDepositar.ForeColor = Color.SteelBlue;
            btnDepositar.Location = new Point(12, 95);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(491, 126);
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
            lblSaldo.Location = new Point(12, 233);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(141, 54);
            lblSaldo.TabIndex = 2;
            lblSaldo.Text = "Saldo: ";
            // 
            // BtnSaque
            // 
            BtnSaque.Font = new Font("Rockwell Extra Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSaque.ForeColor = Color.SteelBlue;
            BtnSaque.Location = new Point(378, 252);
            BtnSaque.Name = "BtnSaque";
            BtnSaque.Size = new Size(125, 34);
            BtnSaque.TabIndex = 3;
            BtnSaque.Text = "Saque";
            BtnSaque.UseVisualStyleBackColor = true;
            BtnSaque.Click += BtnSaque_Click;
            // 
            // Extra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(513, 307);
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
    }
}