using System.Configuration;
using System.Data.SqlClient;
using System.Data;
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
            try
            {
                if (txtSenha.Text == txtConfirmaSenha.Text)
                {
                    //Criando uma conexão
                    SqlConnection conexao =
                           new SqlConnection(ConfigurationManager.ConnectionStrings["pjrAtiv.Properties.Settings.strConexão"].ToString());



                    //Criando um comando
                    SqlCommand cmd = new SqlCommand();



                    //criando texto do comando, tipo e conexão que será usada
                    cmd.CommandText = "pi_Cliente";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;



                    //inserindo parâmetros à procedure
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("dataNascimento", Convert.ToDateTime(dtDataNasc.Text));
                    cmd.Parameters.AddWithValue("logradouro", txtLogradouro.Text);
                    cmd.Parameters.AddWithValue("numero", txtNumero.Text);
                    cmd.Parameters.AddWithValue("complemento", txtComplemento.Text);
                    cmd.Parameters.AddWithValue("cidade", txtCidade.Text);
                    cmd.Parameters.AddWithValue("estado", cmbEstados.Text);
                    cmd.Parameters.AddWithValue("cpfCliente", txtCpf.Text);
                    cmd.Parameters.AddWithValue("senhaLogin", txtSenha.Text);
                    cmd.Parameters.AddWithValue("celular", txtCelular.Text);
                    cmd.Parameters.AddWithValue("genero", cmbGenero.Text);
                    cmd.Parameters.AddWithValue("email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("cep", txtCEP.Text);




                    //abrir a conexão
                    conexao.Open();
                    cmd.ExecuteNonQuery(); //executa o comando no BD
                    conexao.Close();
                    MessageBox.Show("Cliente cadastrado com sucesso!!!", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);



                    UtilUi.Limpaform(this);
                }
                else
                {
                    throw new Exception("Os campos de senha não coincidem!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*TelaMenu telaMenu = new TelaMenu();
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
            }*/

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}