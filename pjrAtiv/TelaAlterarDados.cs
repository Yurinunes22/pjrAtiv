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
    }
}
