namespace pjrAtiv
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
            btnLogar = new Button();
            lblLogin = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            lblMensagem = new Label();
            SuspendLayout();
            // 
            // btnLogar
            // 
            btnLogar.Font = new Font("Arial Rounded MT Bold", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogar.Location = new Point(363, 270);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(92, 45);
            btnLogar.TabIndex = 0;
            btnLogar.Text = "Logar";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial Rounded MT Bold", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(221, 77);
            lblLogin.Margin = new Padding(5, 0, 5, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(74, 27);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "Login";
            lblLogin.Click += label1_Click;
            // 
            // txtLogin
            // 
            txtLogin.BackColor = SystemColors.HotTrack;
            txtLogin.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.Location = new Point(363, 77);
            txtLogin.MaxLength = 11;
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(197, 38);
            txtLogin.TabIndex = 3;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.HotTrack;
            txtSenha.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(363, 150);
            txtSenha.MaxLength = 6;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(197, 38);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Arial Rounded MT Bold", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSenha.Location = new Point(221, 150);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(83, 27);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha";
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new Point(363, 363);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(66, 15);
            lblMensagem.TabIndex = 5;
            lblMensagem.Text = "Mensagem";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMensagem);
            Controls.Add(lblSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(lblLogin);
            Controls.Add(btnLogar);
            Name = "Form1";
            Text = "Jukas Bank - Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogar;
        private Label lblLogin;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Label lblSenha;
        private Label lblMensagem;
    }
}