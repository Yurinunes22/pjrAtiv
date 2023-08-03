using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pjrAtiv.Classes;
namespace pjrAtiv
{
    public partial class Extra : Form
    {
        Conta minhaConta;
        public Extra()
        {
            InitializeComponent();
        }

        private void Extra_Load(object sender, EventArgs e)
        {
            minhaConta = new
                Conta(2, 2,0, "Ativa", DateTime.Now, null);
            //Conta minhaConta = new Conta(); 
            // minhaConta.Saldo = 1000;
            //minhaConta.Status = "Ativa";

            //MessageBox.Show( minhaConta.Saldo.ToString() + " " +
            //minhaConta.Status, "Minha Conta"); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //metodo Concatenando
            /*lblSaldo.Text = "Saldo: R$" + minhaConta.Depositar(Convert.ToDouble(txtValorDeposito.Text)).ToString("n2");
            MessageBox.Show(minhaConta.Saldo.ToString(), "Novo Saldo");
            lblSaldo.Text = "Saldo: " + minhaConta.Saldo;*/
            //Template string
           
            /*Conta Conta1 = new Conta();
            Conta1.Depositar(500);
            Conta Conta2 = new Conta();
            Conta2.Depositar(1500);*/



            //MessageBox.Show(Conta.ContadordeContas.ToString(),"Quantidade de Contas: ");
            if (double.TryParse(txtValorDeposito.Text, out var valorDeposito) == false || txtValorDeposito.Text == string.Empty)
            {

                MessageBox.Show("Digite Corretamente");

            }
            else 
            {
                try
                {
                    lblSaldo.Text = $"Saldo: R$ {minhaConta.Depositar(Convert.ToDouble(txtValorDeposito.Text)).ToString("n2")}";

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message); 
                }

                //lblSaldo.Text = $"Saldo: R$ {minhaConta.Depositar(Convert.ToDouble(txtValorDeposito.Text)).ToString("n2")}";

            }

        }

        private void BtnSaque_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtValorDeposito.Text, out var valorDeposito) == false || txtValorDeposito.Text == string.Empty)
            {

                MessageBox.Show("Digite Corretamente");

            }
            else
            {
                //lblSaldo.Text = $"Saldo: R$ {minhaConta.Saque(Convert.ToDouble(lblSaldo.Text)).ToString("n2")}";
                try
                {
                    lblSaldo.Text = $"Saldo: R$ {minhaConta.Saque(Convert.ToDouble(txtValorDeposito.Text)).ToString("n2")}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    //bloco que será executado SEMPRE
                }

            }




        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }

        private void btnVerSaldo_Click(object sender, EventArgs e)
        {
            lblSaldo.Text = $"Saldo: R${minhaConta.Saldo.ToString("n2")}";
        }
    }
}
