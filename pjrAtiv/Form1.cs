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
            if (txtLogin.Text == "12345678901")
            {
                lblMensagem.Text = "Usuário autenticado!";
                if (txtSenha.Text== "123456")
                {
                    lblMensagem.Text = " Usuário Auntenticado";
                }

                



            
           }
            else lblMensagem.Text = "Usuário não encontrado";
        }
        private void lblSenha_Click(object sender, EventArgs e)
        {

        }
    }
}