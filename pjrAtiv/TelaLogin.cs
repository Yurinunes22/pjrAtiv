﻿using System;
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

                cmd.CommandText = "ps_validaLogin";

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection = conexao;

                //passando parâmetros necessários
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("cpfCliente", txtCpf.Text);
                cmd.Parameters.AddWithValue("SenhaLogin", txtSenha.Text);

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

                    /*if (!leitor.IsDBNull(5))

                    {

                        UsuarioLogado.complemento = leitor.GetString(7);

                    }*/

                    UsuarioLogado.complemento = leitor.GetString(7);

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


                    //verificar se há linhas retornadas do leitor

                    if (leitor.HasRows)

                    {

                        //repete a leitura e enquanto há linhas segue na estrutura

                        //de repetição

                        while (leitor.Read())

                        {

                            //cria uma conta na memória

                            Conta conta = new Conta();

                            //passa os dados do leitor para a conta na memória - objeto conta

                            conta.idConta = leitor.GetInt32(0);

                            conta.idCliente = leitor.GetInt32(1);

                            conta.dataAbertura = leitor.GetDateTime(2);

                            conta.saldo = leitor.GetDecimal(4);

                            conta.tipoConta = leitor.GetString(5);

                            conta.statusConta = leitor.GetString(6);

                            conta.senhaConta = leitor.GetString(7);



                            //adiciona a conta recém criada na memória para a colection de contas

                            UsuarioLogado.Contas.Add(conta);

                        }

                    }

                    leitor.Close(); //fecha leitor

                    conexao.Close(); //fecha conexao com BD

                    Form telainicial = Application.OpenForms["TelaInicial"];
                    //acessando o formulário aberto através da variável janelaPrincipal
                    MenuStrip menuPrincipal = (MenuStrip)telainicial.Controls[0];
                    menuPrincipal.Items[0].Text = "Logout";
                    menuPrincipal.Items[1].Visible = true;
                   /* menuPrincipal.Items[2].Visible = true;
                    menuPrincipal.Items[3].Visible = true;
                    menuPrincipal.Items[4].Visible = true;
                    menuPrincipal.Items[4].Text = UsuarioLogado.nome;
                    menuPrincipal.Items[5].Visible = true;
                    menuPrincipal.Items[6].Visible = true;
                    menuPrincipal.Items[6].Text = UsuarioLogado.Contas[0].idCliente.ToString();*/



                    MessageBox.Show($"Olá,{UsuarioLogado.nome}!\n" +
                        $"Você foi logado na conta {UsuarioLogado.Contas[0].idCliente.ToString()}\n" +
                        $"Para trocar de conta, utilize o menu Conta\\Alternar Conta");
                    //MessageBox.Show($"{CorrentistaLogado.Id.ToString()},{CorrentistaLogado.NomeCorrentista},{CorrentistaLogado.DataNascimento.ToString()},{CorrentistaLogado.Logradouro}," +
                    //    $"{CorrentistaLogado.Numero},{CorrentistaLogado.Complemento},{CorrentistaLogado.Cidade}," +
                    //    $"{CorrentistaLogado.Estado},{CorrentistaLogado.Cpf},{CorrentistaLogado.Senha},{CorrentistaLogado.Celular}");
                    this.Close();
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
