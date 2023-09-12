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
    public partial class TelaAlterarDados : Form
    {
        public TelaAlterarDados()
        {
            InitializeComponent();
        }

        private void btnCriarAcesso_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConfirmarSenha.Text == UsuarioLogado.SenhaLogin)
                {
                    //Criando uma conexão
                    SqlConnection conexao =
                           new SqlConnection(ConfigurationManager.ConnectionStrings["prjAula1.Properties.Settings.strConexao"].ToString());
                    //Criando um comando
                    SqlCommand cmd = new SqlCommand();





                    //criando texto do comando, tipo e conexão que será usada
                    cmd.CommandText = "pu_AtualiazarCliente2";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;





                    //inserindo parâmetros à procedure
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("idCliente", UsuarioLogado.IdCliente);
                    cmd.Parameters.AddWithValue("nomeCliente", txtAlterarNome.Text);
                    cmd.Parameters.AddWithValue("cpfCliente", txtAlterarCpf.Text);
                    cmd.Parameters.AddWithValue("dataNascimento", Convert.ToDateTime(dtAlterarDataNasc.Text));
                    cmd.Parameters.AddWithValue("Logradouro", txtAlterarLogradouro.Text);
                    cmd.Parameters.AddWithValue("numero", txtAlterarNumero.Text);
                    cmd.Parameters.AddWithValue("complemento", txtAlterarComplemento.Text);
                    cmd.Parameters.AddWithValue("cidade", txtAlterarCidade.Text);
                    cmd.Parameters.AddWithValue("estado", cmbAlterarEstados.Text);
                    cmd.Parameters.AddWithValue("cpf", txtAlterarCpf.Text);








                    //abrir a conexão
                    conexao.Open();
                    cmd.ExecuteNonQuery(); //executa o comando no BD
                    conexao.Close();
                    MessageBox.Show("Cliente Alterado com sucesso!!!", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);



                    UtilUi.Limpaform(this);
                }

                else
                {
                    throw new Exception("Senha incorreta!");
                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TelaAlterarDados_Load(object sender, EventArgs e)
        {
            txtAlterarNome.Text = UsuarioLogado.Nome;
            txtAlterarCpf.Text = UsuarioLogado.CpfCliente;
            dtAlterarDataNasc.Text = Convert.ToString(UsuarioLogado.DataNascimento);
            txtAlterarEmail.Text = UsuarioLogado.Email;
            txtAlterarLogradouro.Text = UsuarioLogado.Logradouro;
            txtAlterarNumero.Text = UsuarioLogado.Numero;
            txtAlterarComplemento.Text = UsuarioLogado.Complemento;
            txtAlterarCidade.Text = UsuarioLogado.Cidade;
            cmbAlterarEstados.Text = UsuarioLogado.Estado;
            txtAlterarCEP.Text = UsuarioLogado.Cep;
            cmbAlterarGenero.Text = UsuarioLogado.Genero;
            txtAlterarCelular.Text = UsuarioLogado.Celular;


        }

        private void btnLimparTxt_Click(object sender, EventArgs e)
        {
            UtilUi.Limpaform(this);
        }

        private void txtAlterarCEP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAlterarLogradouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbAlterarEstados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
