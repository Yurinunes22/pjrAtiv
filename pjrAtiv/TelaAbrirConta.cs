using DTO;
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

namespace pjrAtiv
{
    public partial class TelaAbrirConta : Form
    {
        public TelaAbrirConta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {

            Conta conta = new Conta();

            try
            {
                if (txtCriarSenhaConta.Text == txtConfirmarSenhaConta.Text)
                {
                    
                    //Criando uma conexão
                    SqlConnection conexao =
                           new SqlConnection(ConfigurationManager.ConnectionStrings["pjrAtiv.Properties.Settings.strConexão"].ToString());



                    //Criando um comando
                    SqlCommand cmd = new SqlCommand();



                    //criando texto do comando, tipo e conexão que será usada
                    cmd.CommandText = "pi_Conta_48";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;



                    //inserindo parâmetros à procedure
                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("idCliente", UsuarioLogado.IdCliente);
                    cmd.Parameters.AddWithValue("dataAbertura", DateTime.Now);
                    cmd.Parameters.AddWithValue("saldo", txtSaldo.Text);
                    cmd.Parameters.AddWithValue("tipoConta", cmbTipoConta.Text);
                    cmd.Parameters.AddWithValue("statusConta", "Ativa");
                    cmd.Parameters.AddWithValue("senhaConta", txtCriarSenhaConta.Text);


                    


                    //abrir a conexão
                    conexao.Open();

                    //executa o comando no BD e captura o retorno devolvido pelo procedimento
                    UsuarioLogado.ContaLogada = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd.ExecuteNonQuery(); //executa o comando no BD
                    conexao.Close();
                    MessageBox.Show("Cliente cadastrado com sucesso!!!", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);



                    UtilUi.Limpaform(this);
                }
                else
                {
                    throw new Exception("Conta criada com sucesso!!!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            conta.senhaConta = txtCriarSenhaConta.Text;
        }


        private void txtConfirmarSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
