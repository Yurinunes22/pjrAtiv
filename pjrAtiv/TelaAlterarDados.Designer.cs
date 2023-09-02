namespace pjrAtiv
{
    partial class TelaAlterarDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAlterarDados));
            cmbAlterarGenero = new ComboBox();
            dtAlterarDataNasc = new DateTimePicker();
            cmbAlterarEstados = new ComboBox();
            pictureBox2 = new PictureBox();
            txtAlterarCEP = new TextBox();
            btnCriarAcesso = new Button();
            txtAlterarCidade = new TextBox();
            txtAlterarComplemento = new TextBox();
            txtAlterarNumero = new TextBox();
            txtAlterarLogradouro = new TextBox();
            txtAlterarEmail = new TextBox();
            txtAlterarCelular = new TextBox();
            txtAlterarCpf = new TextBox();
            txtAlterarNome = new TextBox();
            lblLogin = new Label();
            btnLimparTxt = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // cmbAlterarGenero
            // 
            cmbAlterarGenero.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cmbAlterarGenero.FormattingEnabled = true;
            cmbAlterarGenero.Items.AddRange(new object[] { "Masculino", "Feminino" });
            cmbAlterarGenero.Location = new Point(540, 197);
            cmbAlterarGenero.Name = "cmbAlterarGenero";
            cmbAlterarGenero.Size = new Size(121, 31);
            cmbAlterarGenero.TabIndex = 44;
            cmbAlterarGenero.Text = "Genero";
            // 
            // dtAlterarDataNasc
            // 
            dtAlterarDataNasc.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dtAlterarDataNasc.Location = new Point(35, 139);
            dtAlterarDataNasc.Name = "dtAlterarDataNasc";
            dtAlterarDataNasc.Size = new Size(200, 31);
            dtAlterarDataNasc.TabIndex = 43;
            // 
            // cmbAlterarEstados
            // 
            cmbAlterarEstados.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cmbAlterarEstados.FormattingEnabled = true;
            cmbAlterarEstados.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SO", "SE", "TO" });
            cmbAlterarEstados.Location = new Point(540, 83);
            cmbAlterarEstados.Name = "cmbAlterarEstados";
            cmbAlterarEstados.Size = new Size(121, 31);
            cmbAlterarEstados.TabIndex = 42;
            cmbAlterarEstados.Text = "UF";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 473);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(107, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // txtAlterarCEP
            // 
            txtAlterarCEP.BackColor = SystemColors.ControlLightLight;
            txtAlterarCEP.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlterarCEP.Location = new Point(540, 139);
            txtAlterarCEP.MaxLength = 8;
            txtAlterarCEP.Name = "txtAlterarCEP";
            txtAlterarCEP.PlaceholderText = "CEP";
            txtAlterarCEP.Size = new Size(242, 31);
            txtAlterarCEP.TabIndex = 38;
            // 
            // btnCriarAcesso
            // 
            btnCriarAcesso.Location = new Point(664, 473);
            btnCriarAcesso.Name = "btnCriarAcesso";
            btnCriarAcesso.Size = new Size(118, 29);
            btnCriarAcesso.TabIndex = 37;
            btnCriarAcesso.Text = "Criar Acesso";
            btnCriarAcesso.UseVisualStyleBackColor = true;
            btnCriarAcesso.Click += btnCriarAcesso_Click;
            // 
            // txtAlterarCidade
            // 
            txtAlterarCidade.BackColor = SystemColors.ControlLightLight;
            txtAlterarCidade.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlterarCidade.Location = new Point(540, 23);
            txtAlterarCidade.MaxLength = 50;
            txtAlterarCidade.Name = "txtAlterarCidade";
            txtAlterarCidade.PlaceholderText = "Cidade";
            txtAlterarCidade.Size = new Size(242, 31);
            txtAlterarCidade.TabIndex = 35;
            // 
            // txtAlterarComplemento
            // 
            txtAlterarComplemento.BackColor = SystemColors.ControlLightLight;
            txtAlterarComplemento.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlterarComplemento.Location = new Point(35, 364);
            txtAlterarComplemento.MaxLength = 6;
            txtAlterarComplemento.Name = "txtAlterarComplemento";
            txtAlterarComplemento.PlaceholderText = "Complemento";
            txtAlterarComplemento.Size = new Size(242, 31);
            txtAlterarComplemento.TabIndex = 34;
            // 
            // txtAlterarNumero
            // 
            txtAlterarNumero.BackColor = SystemColors.ControlLight;
            txtAlterarNumero.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlterarNumero.Location = new Point(35, 309);
            txtAlterarNumero.MaxLength = 10;
            txtAlterarNumero.Name = "txtAlterarNumero";
            txtAlterarNumero.PlaceholderText = "Numero";
            txtAlterarNumero.Size = new Size(242, 31);
            txtAlterarNumero.TabIndex = 33;
            // 
            // txtAlterarLogradouro
            // 
            txtAlterarLogradouro.BackColor = SystemColors.ControlLightLight;
            txtAlterarLogradouro.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlterarLogradouro.Location = new Point(35, 254);
            txtAlterarLogradouro.MaxLength = 100;
            txtAlterarLogradouro.Name = "txtAlterarLogradouro";
            txtAlterarLogradouro.PlaceholderText = "Logradouro";
            txtAlterarLogradouro.Size = new Size(242, 31);
            txtAlterarLogradouro.TabIndex = 31;
            // 
            // txtAlterarEmail
            // 
            txtAlterarEmail.BackColor = SystemColors.ControlLightLight;
            txtAlterarEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlterarEmail.Location = new Point(35, 197);
            txtAlterarEmail.MaxLength = 100;
            txtAlterarEmail.Name = "txtAlterarEmail";
            txtAlterarEmail.PlaceholderText = "E-mail";
            txtAlterarEmail.Size = new Size(242, 31);
            txtAlterarEmail.TabIndex = 29;
            // 
            // txtAlterarCelular
            // 
            txtAlterarCelular.BackColor = SystemColors.ControlLightLight;
            txtAlterarCelular.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlterarCelular.Location = new Point(540, 254);
            txtAlterarCelular.MaxLength = 11;
            txtAlterarCelular.Name = "txtAlterarCelular";
            txtAlterarCelular.PlaceholderText = "Celular";
            txtAlterarCelular.Size = new Size(242, 31);
            txtAlterarCelular.TabIndex = 28;
            // 
            // txtAlterarCpf
            // 
            txtAlterarCpf.BackColor = SystemColors.ControlLightLight;
            txtAlterarCpf.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlterarCpf.Location = new Point(35, 83);
            txtAlterarCpf.MaxLength = 11;
            txtAlterarCpf.Name = "txtAlterarCpf";
            txtAlterarCpf.PlaceholderText = "000.000.000-00";
            txtAlterarCpf.Size = new Size(242, 31);
            txtAlterarCpf.TabIndex = 27;
            // 
            // txtAlterarNome
            // 
            txtAlterarNome.BackColor = SystemColors.ButtonHighlight;
            txtAlterarNome.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtAlterarNome.ForeColor = SystemColors.InactiveCaptionText;
            txtAlterarNome.Location = new Point(33, 23);
            txtAlterarNome.MaxLength = 100;
            txtAlterarNome.Name = "txtAlterarNome";
            txtAlterarNome.PlaceholderText = "Nome Completo";
            txtAlterarNome.Size = new Size(240, 31);
            txtAlterarNome.TabIndex = 26;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial Rounded MT Bold", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.DarkViolet;
            lblLogin.Location = new Point(37, -62);
            lblLogin.Margin = new Padding(5, 0, 5, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(217, 27);
            lblLogin.TabIndex = 30;
            lblLogin.Text = "Crie Seu Cadastro";
            // 
            // btnLimparTxt
            // 
            btnLimparTxt.Location = new Point(540, 473);
            btnLimparTxt.Name = "btnLimparTxt";
            btnLimparTxt.Size = new Size(118, 29);
            btnLimparTxt.TabIndex = 45;
            btnLimparTxt.Text = "Limpar";
            btnLimparTxt.UseVisualStyleBackColor = true;
            btnLimparTxt.Click += btnLimparTxt_Click;
            // 
            // TelaAlterarDados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 550);
            Controls.Add(btnLimparTxt);
            Controls.Add(cmbAlterarGenero);
            Controls.Add(dtAlterarDataNasc);
            Controls.Add(cmbAlterarEstados);
            Controls.Add(pictureBox2);
            Controls.Add(txtAlterarCEP);
            Controls.Add(btnCriarAcesso);
            Controls.Add(txtAlterarCidade);
            Controls.Add(txtAlterarComplemento);
            Controls.Add(txtAlterarNumero);
            Controls.Add(txtAlterarLogradouro);
            Controls.Add(txtAlterarEmail);
            Controls.Add(txtAlterarCelular);
            Controls.Add(txtAlterarCpf);
            Controls.Add(txtAlterarNome);
            Controls.Add(lblLogin);
            Name = "TelaAlterarDados";
            Text = "TelaAlterarDados";
            Load += TelaAlterarDados_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAlterarGenero;
        private DateTimePicker dtAlterarDataNasc;
        private ComboBox cmbAlterarEstados;
        private PictureBox pictureBox2;
        private TextBox txtAlterarCEP;
        private Button btnCriarAcesso;
        private TextBox txtAlterarCidade;
        private TextBox txtAlterarComplemento;
        private TextBox txtAlterarNumero;
        private TextBox txtAlterarLogradouro;
        private TextBox txtAlterarEmail;
        private TextBox txtAlterarCelular;
        private TextBox txtAlterarCpf;
        private TextBox txtAlterarNome;
        private Label lblLogin;
        private Button btnLimparTxt;
    }
}