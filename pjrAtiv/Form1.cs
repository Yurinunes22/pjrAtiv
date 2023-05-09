using System.Diagnostics.Eventing.Reader;

namespace pjrAtiv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e)
            
        {
            string mensagem;
            if (txtLogin.TextLength < 11 || txtLogin.Text == String.Empty)
            {
                mensagem = "Preencha a caixa login com um valor valido!";
            }
            else if (txtSenha.TextLength < 6 || txtSenha.Text == String.Empty)
            {
                mensagem = "Preencha a caixa senha com um valor valido!";
            }
            else
            {
                if (txtLogin.Text != "12345678901")
                {
                    mensagem = "Login inválido";
                }
                else if (txtSenha.Text != "123456")
                {
                    mensagem = "Senha inválido";
                }
                else
                {
                    mensagem = "Usuario Valido";
                }

            }

            // lblMensagem.Text = mensagem; //mensagem em um label


            MessageBox.Show(mensagem, "Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }
        private void lblSenha_Click(object sender, EventArgs e)
        {

        }
    }
}