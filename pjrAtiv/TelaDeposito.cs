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
    public partial class TelaDeposito : Form
    {
        public TelaDeposito()
        {
            InitializeComponent();
        }

        private void TelaDeposito_Load(object sender, EventArgs e)
        {

        }

        private void lblValorDeposito_Click(object sender, EventArgs e)
        {
        }

        private void lblInsiraValor_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaMenu telaMenu = new TelaMenu();
            telaMenu.Show(this);
        }

        private void lblNomeCliente_Click(object sender, EventArgs e)
        {

        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {
        }

        private void lblExtrato_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conta conta = new Conta();

                foreach (var item in UsuarioLogado.Contas)
                {
                    if (item.idConta == UsuarioLogado.ContaLogada)
                    {
                        conta = item;
                    }
                }

                if (Convert.ToDecimal(txtValorDeposito.Text) > 0 && txtSenhaDeposito.Text == conta.senhaConta)
                {
                    //Criando uma conexão
                    SqlConnection conexao =
                           new SqlConnection(ConfigurationManager.ConnectionStrings["pjrAtiv.Properties.Settings.strConexão"].ToString());
                    //Criando um comando
                    SqlCommand cmd = new SqlCommand();


                    //criando texto do comando, tipo e conexão que será usada
                    cmd.CommandText = "pu_AtualizarConta";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;

                   



                    //inserindo parâmetros à procedure
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("idConta",UsuarioLogado.ContaLogada);
                    cmd.Parameters.AddWithValue("dataAbertura",conta.dataAbertura);
                    cmd.Parameters.AddWithValue("dataEncerramento",conta.dataEncerramento);
                    cmd.Parameters.AddWithValue("saldo",Convert.ToDecimal(txtValorDeposito.Text)+conta.saldo);
                    cmd.Parameters.AddWithValue("tipoConta",conta.tipoConta); 
                    cmd.Parameters.AddWithValue("statusConta",conta.senhaConta); 
                    cmd.Parameters.AddWithValue("senhaConta",conta.senhaConta);


                    /*cmd.Parameters.AddWithValue("idCliente", UsuarioLogado.IdCliente);
                    cmd.Parameters.AddWithValue("nome", txtAlterarNome.Text);
                    cmd.Parameters.AddWithValue("cpfCliente", txtAlterarCpf.Text);
                    cmd.Parameters.AddWithValue("dataNascimento", Convert.ToDateTime(dtAlterarDataNasc.Text));
                    cmd.Parameters.AddWithValue("Logradouro", txtAlterarLogradouro.Text);
                    cmd.Parameters.AddWithValue("numero", txtAlterarNumero.Text);
                    cmd.Parameters.AddWithValue("complemento", txtAlterarComplemento.Text);
                    cmd.Parameters.AddWithValue("cidade", txtAlterarCidade.Text);
                    cmd.Parameters.AddWithValue("estado", cmbAlterarEstados.Text);
                    cmd.Parameters.AddWithValue("genero", cmbAlterarGenero.Text);
                    cmd.Parameters.AddWithValue("celular", txtAlterarCelular.Text);
                    cmd.Parameters.AddWithValue("email", txtAlterarEmail.Text);
                    cmd.Parameters.AddWithValue("cep", txtAlterarCEP.Text);
                    cmd.Parameters.AddWithValue("senhaLogin", UsuarioLogado.SenhaLogin);*/













                    //abrir a conexão
                    conexao.Open();
                    cmd.ExecuteNonQuery(); //executa o comando no BD
                    conexao.Close();
                    MessageBox.Show("Deposito Feito com sucesso!", "Info",
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

        private void btnVoltarDeposito_Click(object sender, EventArgs e)
        {
            TelaMenu telaMenu = new TelaMenu();
            this.Close();
            telaMenu.Show();
        }
    }
}
