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
            //Conta minhaConta = new Conta(); //instanciar a classe

            //minhaConta.Status = "Ativa";




            try
            {
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
                cmd.Parameters.AddWithValue("cpfCliente", txtCpf);
                cmd.Parameters.AddWithValue("SenhaLogin", txtSenha);

                conexao.Open(); //abrindo conexão

                leitor = cmd.ExecuteReader();  //igualando o leitor ao resultado de BD

                if (leitor.HasRows) //se o leitor encontrar linhas de dados
                {
                 leitor.Read();
                    //leitor.GetInt32(0);    
                    
                    UsuarioLogado.idCliente = leitor.GetInt32(0);

                    UsuarioLogado.nome = leitor.GetString(1);

                    UsuarioLogado.dataNascimento = leitor.GetDateTime(12);

                    UsuarioLogado.Logradouro = leitor.GetString(5);

                    UsuarioLogado.numero = leitor.GetString(6);

                    if (!leitor.IsDBNull(5))

                    {

                        UsuarioLogado.complemento = leitor.GetString(7);

                    }



                    UsuarioLogado.cidade = leitor.GetString(8);

                    UsuarioLogado.estado = leitor.GetString(9);

                    UsuarioLogado.cpfCliente = leitor.GetString(2);

                    UsuarioLogado.senhaLogin = leitor.GetString(13);

                    UsuarioLogado.celular = leitor.GetString(3);

                    UsuarioLogado.email = leitor.GetString(4);

                    UsuarioLogado.cep = leitor.GetInt32(10);

                    UsuarioLogado.genero = leitor.GetString(11);

                    //fechando leitor

                    leitor.Close();

                    //criando texto do comando, tipo e conexão que será usada
                    cmd.CommandText = "ps_buscaContasPorIdCorrentista";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;



                    //passando os parâmetros necessários
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("id", UsuarioLogado.idCliente);



                    //ler novamente o leitor
                    leitor = cmd.ExecuteReader();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha invalidos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           

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
