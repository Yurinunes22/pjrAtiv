namespace pjrAtiv
{
    partial class TelaLogin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            txtCpf = new TextBox();
            txtSenha = new TextBox();
            btnentrar = new Button();
            btnCriarconta = new Button();
            pictureBox2 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lblJukasbanks = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtCpf
            // 
            txtCpf.BackColor = SystemColors.InactiveCaptionText;
            txtCpf.Location = new Point(530, 93);
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "000.000.000-00";
            txtCpf.Size = new Size(176, 23);
            txtCpf.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.InfoText;
            txtSenha.Location = new Point(530, 164);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "******";
            txtSenha.Size = new Size(176, 23);
            txtSenha.TabIndex = 1;
            // 
            // btnentrar
            // 
            btnentrar.Location = new Point(530, 239);
            btnentrar.Name = "btnentrar";
            btnentrar.Size = new Size(176, 32);
            btnentrar.TabIndex = 2;
            btnentrar.Text = "Entrar";
            btnentrar.UseVisualStyleBackColor = true;
            btnentrar.Click += button1_Click;
            // 
            // btnCriarconta
            // 
            btnCriarconta.Location = new Point(530, 309);
            btnCriarconta.Name = "btnCriarconta";
            btnCriarconta.Size = new Size(176, 32);
            btnCriarconta.TabIndex = 3;
            btnCriarconta.Text = "Criar Conta";
            btnCriarconta.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-37, 50);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(426, 221);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lblJukasbanks
            // 
            lblJukasbanks.AutoSize = true;
            lblJukasbanks.ForeColor = Color.DarkViolet;
            lblJukasbanks.Location = new Point(160, 326);
            lblJukasbanks.Name = "lblJukasbanks";
            lblJukasbanks.Size = new Size(72, 15);
            lblJukasbanks.TabIndex = 6;
            lblJukasbanks.Text = "Juka's Banks";
            lblJukasbanks.Click += label1_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblJukasbanks);
            Controls.Add(pictureBox2);
            Controls.Add(btnCriarconta);
            Controls.Add(btnentrar);
            Controls.Add(txtSenha);
            Controls.Add(txtCpf);
            Name = "TelaLogin";
            Text = "TelaLogin";
            Load += TelaLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCpf;
        private TextBox txtSenha;
        private Button btnentrar;
        private Button btnCriarconta;
        private PictureBox pictureBox2;
        private ContextMenuStrip contextMenuStrip1;
        private Label lblJukasbanks;
    }
}