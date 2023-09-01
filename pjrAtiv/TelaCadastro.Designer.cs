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
            txtNome = new TextBox();
            lblMensagem = new Label();
            txtCpf = new TextBox();
            txtCelular = new TextBox();
            txtEmail = new TextBox();
            txtLogradouro = new TextBox();
            txtNumero = new TextBox();
            txtComplemento = new TextBox();
            txtCidade = new TextBox();
            btnVoltar = new Button();
            imageList1 = new ImageList(components);
            btnCriarAcesso = new Button();
            txtEstado = new TextBox();
            txtCEP = new TextBox();
            txtGenero = new TextBox();
            txtDataNasc = new TextBox();
            pictureBox2 = new PictureBox();
            txtSenha = new TextBox();
            txtConfirmaSenha = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial Rounded MT Bold", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.DarkViolet;
            lblLogin.Location = new Point(14, 22);
            lblLogin.Margin = new Padding(5, 0, 5, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(217, 27);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "Crie Seu Cadastro";
            lblLogin.Click += label1_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ButtonHighlight;
            txtNome.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = SystemColors.InactiveCaptionText;
            txtNome.Location = new Point(14, 78);
            txtNome.MaxLength = 11;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome Completo";
            txtNome.Size = new Size(242, 38);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += txtLogin_TextChanged;
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
            // txtCpf
            // 
            txtCpf.BackColor = SystemColors.ControlLightLight;
            txtCpf.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpf.Location = new Point(14, 138);
            txtCpf.MaxLength = 11;
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "000.000.000-00";
            txtCpf.Size = new Size(242, 38);
            txtCpf.TabIndex = 1;
            txtCpf.TextChanged += txtNomeCliente_TextChanged;
            // 
            // txtCelular
            // 
            txtCelular.BackColor = SystemColors.ControlLightLight;
            txtCelular.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtCelular.Location = new Point(14, 194);
            txtCelular.MaxLength = 11;
            txtCelular.Name = "txtCelular";
            txtCelular.PlaceholderText = "Celular";
            txtCelular.Size = new Size(242, 38);
            txtCelular.TabIndex = 2;
            txtCelular.TextChanged += txtEmail_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLightLight;
            txtEmail.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(14, 252);
            txtEmail.MaxLength = 6;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-mail";
            txtEmail.Size = new Size(242, 38);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += txtSenha_TextChanged;
            // 
            // txtLogradouro
            // 
            txtLogradouro.BackColor = SystemColors.ControlLightLight;
            txtLogradouro.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogradouro.Location = new Point(14, 309);
            txtLogradouro.MaxLength = 6;
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.PlaceholderText = "Logradouro";
            txtLogradouro.Size = new Size(242, 38);
            txtLogradouro.TabIndex = 4;
            txtLogradouro.TextChanged += txtConfirmaSenha_TextChanged;
            // 
            // txtNumero
            // 
            txtNumero.BackColor = SystemColors.ControlLight;
            txtNumero.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(14, 364);
            txtNumero.MaxLength = 11;
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Numero";
            txtNumero.Size = new Size(242, 38);
            txtNumero.TabIndex = 5;
            txtNumero.TextChanged += txtCelular_TextChanged;
            // 
            // txtComplemento
            // 
            txtComplemento.BackColor = SystemColors.ControlLightLight;
            txtComplemento.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtComplemento.Location = new Point(14, 419);
            txtComplemento.MaxLength = 11;
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "Complemento";
            txtComplemento.Size = new Size(242, 38);
            txtComplemento.TabIndex = 6;
            txtComplemento.TextChanged += txtDataNasc_TextChanged;
            // 
            // txtCidade
            // 
            txtCidade.BackColor = SystemColors.ControlLightLight;
            txtCidade.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.Location = new Point(519, 78);
            txtCidade.MaxLength = 11;
            txtCidade.Name = "txtCidade";
            txtCidade.PlaceholderText = "Cidade";
            txtCidade.Size = new Size(242, 38);
            txtCidade.TabIndex = 7;
            txtCidade.TextChanged += txtGenero_TextChanged;
            // 
            // btnVoltar
            // 
            btnVoltar.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltar.Location = new Point(519, 528);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(118, 29);
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
            btnCriarAcesso.Location = new Point(643, 528);
            btnCriarAcesso.Name = "btnCriarAcesso";
            btnCriarAcesso.Size = new Size(118, 29);
            btnCriarAcesso.TabIndex = 15;
            btnCriarAcesso.Text = "Criar Acesso";
            btnCriarAcesso.UseVisualStyleBackColor = true;
            btnCriarAcesso.Click += btnCriarAcesso_Click;
            // 
            // txtEstado
            // 
            txtEstado.BackColor = SystemColors.ControlLightLight;
            txtEstado.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtEstado.Location = new Point(519, 138);
            txtEstado.MaxLength = 11;
            txtEstado.Name = "txtEstado";
            txtEstado.PlaceholderText = "Estado";
            txtEstado.Size = new Size(242, 38);
            txtEstado.TabIndex = 16;
            // 
            // txtCEP
            // 
            txtCEP.BackColor = SystemColors.ControlLightLight;
            txtCEP.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtCEP.Location = new Point(519, 194);
            txtCEP.MaxLength = 11;
            txtCEP.Name = "txtCEP";
            txtCEP.PlaceholderText = "CEP";
            txtCEP.Size = new Size(242, 38);
            txtCEP.TabIndex = 17;
            // 
            // txtGenero
            // 
            txtGenero.BackColor = SystemColors.ControlLightLight;
            txtGenero.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtGenero.Location = new Point(519, 252);
            txtGenero.MaxLength = 11;
            txtGenero.Name = "txtGenero";
            txtGenero.PlaceholderText = "Genero";
            txtGenero.Size = new Size(242, 38);
            txtGenero.TabIndex = 18;
            // 
            // txtDataNasc
            // 
            txtDataNasc.BackColor = SystemColors.ControlLightLight;
            txtDataNasc.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtDataNasc.Location = new Point(519, 309);
            txtDataNasc.MaxLength = 11;
            txtDataNasc.Name = "txtDataNasc";
            txtDataNasc.PlaceholderText = "Data de Nascimento";
            txtDataNasc.Size = new Size(242, 38);
            txtDataNasc.TabIndex = 19;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-6, 528);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(107, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = SystemColors.ControlLightLight;
            txtSenha.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(519, 364);
            txtSenha.MaxLength = 11;
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(242, 38);
            txtSenha.TabIndex = 21;
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.BackColor = SystemColors.ControlLightLight;
            txtConfirmaSenha.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmaSenha.Location = new Point(519, 419);
            txtConfirmaSenha.MaxLength = 11;
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.PlaceholderText = "Confirmar Senha";
            txtConfirmaSenha.Size = new Size(242, 38);
            txtConfirmaSenha.TabIndex = 22;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(894, 603);
            Controls.Add(txtConfirmaSenha);
            Controls.Add(txtSenha);
            Controls.Add(pictureBox2);
            Controls.Add(txtDataNasc);
            Controls.Add(txtGenero);
            Controls.Add(txtCEP);
            Controls.Add(txtEstado);
            Controls.Add(btnCriarAcesso);
            Controls.Add(btnVoltar);
            Controls.Add(txtCidade);
            Controls.Add(txtComplemento);
            Controls.Add(txtNumero);
            Controls.Add(txtLogradouro);
            Controls.Add(txtEmail);
            Controls.Add(txtCelular);
            Controls.Add(txtCpf);
            Controls.Add(lblMensagem);
            Controls.Add(txtNome);
            Controls.Add(lblLogin);
            Name = "TelaCadastro";
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblLogin;
        private TextBox txtNome;
        private Label lblMensagem;
        private TextBox txtCpf;
        private TextBox txtCelular;
        private TextBox txtEmail;
        private TextBox txtLogradouro;
        private TextBox txtNumero;
        private TextBox txtComplemento;
        private TextBox txtCidade;
        private Button btnVoltar;
        private ImageList imageList1;
        private Button btnCriarAcesso;
        private TextBox txtEstado;
        private TextBox txtCEP;
        private TextBox txtGenero;
        private TextBox txtDataNasc;
        private PictureBox pictureBox2;
        private TextBox txtSenha;
        private TextBox txtConfirmaSenha;
    }
}