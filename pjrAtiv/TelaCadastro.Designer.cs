namespace pjrAtiv
{
    partial class TelaCadastro
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            lblLogin = new Label();
            txtCpf = new TextBox();
            lblMensagem = new Label();
            txtNomeCliente = new TextBox();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            txtConfirmaSenha = new TextBox();
            txtCelular = new TextBox();
            txtDataNasc = new TextBox();
            txtGenero = new TextBox();
            btnVoltar = new Button();
            imageList1 = new ImageList(components);
            btnCriarAcesso = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial Rounded MT Bold", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(14, 22);
            lblLogin.Margin = new Padding(5, 0, 5, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(217, 27);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "Crie Seu Cadastro";
            lblLogin.Click += label1_Click;
            // 
            // txtCpf
            // 
            txtCpf.BackColor = SystemColors.ControlLightLight;
            txtCpf.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpf.Location = new Point(14, 73);
            txtCpf.MaxLength = 11;
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "000.000.000-00";
            txtCpf.Size = new Size(217, 38);
            txtCpf.TabIndex = 0;
            txtCpf.TextChanged += txtLogin_TextChanged;
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new Point(53, 542);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(66, 15);
            lblMensagem.TabIndex = 5;
            lblMensagem.Text = "Mensagem";
            lblMensagem.Click += lblMensagem_Click;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.BackColor = SystemColors.ControlLightLight;
            txtNomeCliente.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeCliente.Location = new Point(14, 138);
            txtNomeCliente.MaxLength = 11;
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.PlaceholderText = "Nome Completo";
            txtNomeCliente.Size = new Size(217, 38);
            txtNomeCliente.TabIndex = 1;
            txtNomeCliente.TextChanged += txtNomeCliente_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLightLight;
            txtEmail.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(14, 208);
            txtEmail.MaxLength = 11;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-mail";
            txtEmail.Size = new Size(217, 38);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.ControlLightLight;
            txtSenha.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(14, 277);
            txtSenha.MaxLength = 6;
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(217, 38);
            txtSenha.TabIndex = 3;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.BackColor = SystemColors.ControlLightLight;
            txtConfirmaSenha.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmaSenha.Location = new Point(14, 340);
            txtConfirmaSenha.MaxLength = 6;
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.PlaceholderText = "Confirma Senha";
            txtConfirmaSenha.Size = new Size(217, 38);
            txtConfirmaSenha.TabIndex = 4;
            txtConfirmaSenha.TextChanged += txtConfirmaSenha_TextChanged;
            // 
            // txtCelular
            // 
            txtCelular.BackColor = SystemColors.ControlLight;
            txtCelular.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtCelular.Location = new Point(519, 73);
            txtCelular.MaxLength = 11;
            txtCelular.Name = "txtCelular";
            txtCelular.PlaceholderText = "Celular";
            txtCelular.Size = new Size(217, 38);
            txtCelular.TabIndex = 5;
            txtCelular.TextChanged += txtCelular_TextChanged;
            // 
            // txtDataNasc
            // 
            txtDataNasc.BackColor = SystemColors.ControlLightLight;
            txtDataNasc.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtDataNasc.Location = new Point(519, 138);
            txtDataNasc.MaxLength = 11;
            txtDataNasc.Name = "txtDataNasc";
            txtDataNasc.PlaceholderText = "Data de Nascimento";
            txtDataNasc.Size = new Size(217, 38);
            txtDataNasc.TabIndex = 6;
            txtDataNasc.TextChanged += txtDataNasc_TextChanged;
            // 
            // txtGenero
            // 
            txtGenero.BackColor = SystemColors.ControlLightLight;
            txtGenero.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtGenero.Location = new Point(519, 208);
            txtGenero.MaxLength = 11;
            txtGenero.Name = "txtGenero";
            txtGenero.PlaceholderText = "Genero";
            txtGenero.Size = new Size(217, 38);
            txtGenero.TabIndex = 7;
            txtGenero.TextChanged += txtGenero_TextChanged;
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Arial Rounded MT Bold", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltar.Location = new Point(519, 480);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(221, 41);
            btnVoltar.TabIndex = 13;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "ju bank.png");
            imageList1.Images.SetKeyName(1, "ju bank.png");
            // 
            // btnCriarAcesso
            // 
            btnCriarAcesso.Location = new Point(40, 484);
            btnCriarAcesso.Name = "btnCriarAcesso";
            btnCriarAcesso.Size = new Size(179, 41);
            btnCriarAcesso.TabIndex = 15;
            btnCriarAcesso.Text = "Criar Acesso";
            btnCriarAcesso.UseVisualStyleBackColor = true;
            btnCriarAcesso.Click += btnCriarAcesso_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(894, 577);
            Controls.Add(btnCriarAcesso);
            Controls.Add(btnVoltar);
            Controls.Add(txtGenero);
            Controls.Add(txtDataNasc);
            Controls.Add(txtCelular);
            Controls.Add(txtConfirmaSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(txtNomeCliente);
            Controls.Add(lblMensagem);
            Controls.Add(txtCpf);
            Controls.Add(lblLogin);
            Name = "Form1";
            Text = "Jukas Bank - Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblLogin;
        private TextBox txtCpf;
        private Label lblMensagem;
        private TextBox txtNomeCliente;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private TextBox txtConfirmaSenha;
        private TextBox txtCelular;
        private TextBox txtDataNasc;
        private TextBox txtGenero;
        private Button btnVoltar;
        private ImageList imageList1;
        private Button btnCriarAcesso;
    }
}