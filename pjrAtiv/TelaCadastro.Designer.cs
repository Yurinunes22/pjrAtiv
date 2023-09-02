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
            txtCEP = new TextBox();
            pictureBox2 = new PictureBox();
            txtSenha = new TextBox();
            txtConfirmaSenha = new TextBox();
            cmbEstados = new ComboBox();
            dtDataNasc = new DateTimePicker();
            cmbGenero = new ComboBox();
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
            txtNome.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = SystemColors.InactiveCaptionText;
            txtNome.Location = new Point(12, 78);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome Completo";
            txtNome.Size = new Size(240, 31);
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
            txtCpf.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpf.Location = new Point(14, 138);
            txtCpf.MaxLength = 11;
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "000.000.000-00";
            txtCpf.Size = new Size(242, 31);
            txtCpf.TabIndex = 1;
            txtCpf.TextChanged += txtNomeCliente_TextChanged;
            // 
            // txtCelular
            // 
            txtCelular.BackColor = SystemColors.ControlLightLight;
            txtCelular.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtCelular.Location = new Point(519, 309);
            txtCelular.MaxLength = 11;
            txtCelular.Name = "txtCelular";
            txtCelular.PlaceholderText = "Celular";
            txtCelular.Size = new Size(242, 31);
            txtCelular.TabIndex = 2;
            txtCelular.TextChanged += txtEmail_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLightLight;
            txtEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(14, 252);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-mail";
            txtEmail.Size = new Size(242, 31);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += txtSenha_TextChanged;
            // 
            // txtLogradouro
            // 
            txtLogradouro.BackColor = SystemColors.ControlLightLight;
            txtLogradouro.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogradouro.Location = new Point(14, 309);
            txtLogradouro.MaxLength = 100;
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.PlaceholderText = "Logradouro";
            txtLogradouro.Size = new Size(242, 31);
            txtLogradouro.TabIndex = 4;
            txtLogradouro.TextChanged += txtConfirmaSenha_TextChanged;
            // 
            // txtNumero
            // 
            txtNumero.BackColor = SystemColors.ControlLight;
            txtNumero.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(14, 364);
            txtNumero.MaxLength = 10;
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Numero";
            txtNumero.Size = new Size(242, 31);
            txtNumero.TabIndex = 5;
            txtNumero.TextChanged += txtCelular_TextChanged;
            // 
            // txtComplemento
            // 
            txtComplemento.BackColor = SystemColors.ControlLightLight;
            txtComplemento.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtComplemento.Location = new Point(14, 419);
            txtComplemento.MaxLength = 6;
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "Complemento";
            txtComplemento.Size = new Size(242, 31);
            txtComplemento.TabIndex = 6;
            txtComplemento.TextChanged += txtDataNasc_TextChanged;
            // 
            // txtCidade
            // 
            txtCidade.BackColor = SystemColors.ControlLightLight;
            txtCidade.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.Location = new Point(519, 78);
            txtCidade.MaxLength = 50;
            txtCidade.Name = "txtCidade";
            txtCidade.PlaceholderText = "Cidade";
            txtCidade.Size = new Size(242, 31);
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
            // txtCEP
            // 
            txtCEP.BackColor = SystemColors.ControlLightLight;
            txtCEP.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtCEP.Location = new Point(519, 194);
            txtCEP.MaxLength = 8;
            txtCEP.Name = "txtCEP";
            txtCEP.PlaceholderText = "CEP";
            txtCEP.Size = new Size(242, 31);
            txtCEP.TabIndex = 17;
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
            txtSenha.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(519, 364);
            txtSenha.MaxLength = 6;
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(242, 31);
            txtSenha.TabIndex = 21;
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.BackColor = SystemColors.ControlLightLight;
            txtConfirmaSenha.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmaSenha.Location = new Point(519, 419);
            txtConfirmaSenha.MaxLength = 6;
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.PlaceholderText = "Confirmar Senha";
            txtConfirmaSenha.Size = new Size(242, 31);
            txtConfirmaSenha.TabIndex = 22;
            // 
            // cmbEstados
            // 
            cmbEstados.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEstados.FormattingEnabled = true;
            cmbEstados.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SO", "SE", "TO" });
            cmbEstados.Location = new Point(519, 138);
            cmbEstados.Name = "cmbEstados";
            cmbEstados.Size = new Size(121, 31);
            cmbEstados.TabIndex = 23;
            cmbEstados.Text = "UF";
            cmbEstados.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dtDataNasc
            // 
            dtDataNasc.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dtDataNasc.Location = new Point(14, 194);
            dtDataNasc.Name = "dtDataNasc";
            dtDataNasc.Size = new Size(200, 31);
            dtDataNasc.TabIndex = 24;
            // 
            // cmbGenero
            // 
            cmbGenero.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cmbGenero.Location = new Point(519, 252);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(121, 31);
            cmbGenero.TabIndex = 25;
            cmbGenero.Text = "Genero";
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(894, 603);
            Controls.Add(cmbGenero);
            Controls.Add(dtDataNasc);
            Controls.Add(cmbEstados);
            Controls.Add(txtConfirmaSenha);
            Controls.Add(txtSenha);
            Controls.Add(pictureBox2);
            Controls.Add(txtCEP);
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
        private TextBox txtCEP;
        private PictureBox pictureBox2;
        private TextBox txtSenha;
        private TextBox txtConfirmaSenha;
        private ComboBox cmbEstados;
        private DateTimePicker dtDataNasc;
        private ComboBox cmbGenero;
    }
}