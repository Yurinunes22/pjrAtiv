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
                Conta(2, 2, 1000, "Ativa", DateTime.Now, null);
            //Conta minhaConta = new Conta();
           // minhaConta.Saldo = 1000;
            //minhaConta.Status = "Ativa";

            //MessageBox.Show( minhaConta.Saldo.ToString() + " " +
            //minhaConta.Status, "Minha Conta"); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            minhaConta.Depositar(Convert.ToDouble(txtValorDeposito.Text));
            //MessageBox.Show(minhaConta.Saldo.ToString(), "Novo Saldo");
        }
    } 
}
