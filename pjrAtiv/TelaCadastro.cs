using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace pjrAtiv
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
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
            tela_inicial janelaInicial = new tela_inicial();
            janelaInicial.MdiParent = this;
            //this.Hide();
            janelaInicial.Show();
        }

        private void lblCpf_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarAcesso_Click(object sender, EventArgs e)
        {

            TelaMenu telaMenu = new TelaMenu();
            this.Hide();
            telaMenu.Show();



            long n;
            bool isNumeric = long.TryParse(txtNome.Text, out n);
            if (!isNumeric || txtNome.TextLength < 11)
            {
                MessageBox.Show("Errado");
            }
            else
            {
                MessageBox.Show("Correto");
            }

        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDataNasc_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtConfirmaSenha_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}