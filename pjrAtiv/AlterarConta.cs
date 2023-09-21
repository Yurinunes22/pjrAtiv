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
using DTO;

namespace pjrAtiv
{
    public partial class AlterarConta : Form
    {
        public AlterarConta()
        {
            InitializeComponent();
        }

        private void AlterarConta_Load(object sender, EventArgs e)
        {
            foreach (var item in UsuarioLogado.Contas)
            {
                cmbidContas.Items.Add(item.idConta);
            }
            cmbidContas.Text = cmbidContas.Items[0].ToString();
        }

        private void btnAlterarConta_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexao =

              new SqlConnection(ConfigurationManager.ConnectionStrings["pjrAtiv.Properties.Settings.strConexão"].ToString());

                SqlDataReader leitor; //declarando uma variável do tipo leitor de dados



                //Criando um comando

                SqlCommand cmd = new SqlCommand();



                //criando texto do comando, tipo e conexão que será usada

                cmd.CommandText = "ps_AlterarConta";

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection = conexao;

                //passando parâmetros necessários
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("idConta", cmbidContas.Text);
                cmd.Parameters.AddWithValue("SenhaConta", txtConfirmarSenha.Text);

                conexao.Open(); //abrindo conexão

                leitor = cmd.ExecuteReader();  //igualando o leitor ao resultado de BD

                if (leitor.HasRows)
                {
                    leitor.Read();
                    UsuarioLogado.ContaLogada = Convert.ToInt32(cmbidContas.Text);

                    MessageBox.Show($"Conta Logada {UsuarioLogado.ContaLogada}");
                }
                else
                {
                    throw new Exception("Senha Incorreta!");
                }
                leitor.Close();
                conexao.Close();
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
