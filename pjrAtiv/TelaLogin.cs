using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pjrAtiv.Classes;

namespace pjrAtiv
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta minhaConta = new Conta(); //instanciar a classe

            minhaConta.Status = "Ativa";


            

            //Criando uma conexão

            SqlConnection conexao =

            new SqlConnection(ConfigurationManager.ConnectionStrings["pjrAtiv.Properties.Settings.strConexão"].ToString());

            SqlDataReader leitor; //declarando uma variável do tipo leitor de dados



            //Criando um comando

            SqlCommand cmd = new SqlCommand();



            //criando texto do comando, tipo e conexão que será usada

            cmd.CommandText = "psvalidaLogin";

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = conexao;

            //passando parâmetros necessários
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("cpfCliente",txtCpf);
            cmd.Parameters.AddWithValue("SenhaLogin", txtSenha);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCriarconta_Click(object sender, EventArgs e)
        {
            UtilUi.Limpaform(this); 
        }
    }
}
