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






        }
        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click_1(object sender, EventArgs e)
        {

        }

        private void lblMensagem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblCpf_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarAcesso_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCpf.Text, out int res)== false )
            {
                lblMensagem.Text = "Digite Corretamente";
            }
            else if (int.TryParse(txtSenha.Text, out int res1) == false)
            {
                lblMensagem.Text = "Digite Corretamente";
            }
            
            else 
            { lblMensagem.Text = "Digite"; }
            

            
        }
    }
}