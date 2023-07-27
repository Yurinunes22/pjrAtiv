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
            btnDepositar.ForeColor = Color.Red;
            btnDepositar.Location = new Point(12, 95);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(491, 126);
            btnDepositar.TabIndex = 1;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += button1_Click;
            // 
            // Extra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 233);
            Controls.Add(btnDepositar);
            Controls.Add(txtValorDeposito);
            Name = "Extra";
            Text = "Extra";
            Load += Extra_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValorDeposito;
        private Button btnDepositar;
    }
}