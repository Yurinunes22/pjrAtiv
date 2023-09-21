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
    public partial class TelaSaque : Form
    {
        public TelaSaque()
        {
            InitializeComponent();
        }

        private void btnVoltarSaque_Click(object sender, EventArgs e)
        {
            TelaMenu telaMenu = new TelaMenu();
            this.Close();
            telaMenu.Show();
        }

        private void btnConfirmacao_Click(object sender, EventArgs e)
        {
            try
            {
                Conta conta = new Conta();
                //conta.statusConta = "Ativa";

                foreach (var item in UsuarioLogado.Contas)
                {
                    if (item.idConta == UsuarioLogado.ContaLogada)
                    {
                        conta = item;
                    }
                }

                if (Convert.ToDecimal(txtValorSaque.Text) <=  conta.saldo && txtSenhaSaque.Text == conta.senhaConta)
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


                 conta.saldo = conta.saldo - Convert.ToDecimal(txtValorSaque.Text);



                  //inserindo parâmetros à procedure
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("idConta", UsuarioLogado.ContaLogada);
                    cmd.Parameters.AddWithValue("dataAbertura", conta.dataAbertura);
                    cmd.Parameters.AddWithValue("saldo", conta.saldo);
                    cmd.Parameters.AddWithValue("tipoConta", conta.tipoConta);
                    cmd.Parameters.AddWithValue("statusConta", conta.statusConta);
                    cmd.Parameters.AddWithValue("senhaConta", conta.senhaConta);


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
                    MessageBox.Show("Saque Feito com sucesso!", "Info",
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
    }
}
