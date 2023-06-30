using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjrAtiv
{
    public partial class tela_inicial : Form
    {
        public tela_inicial()
        {
            InitializeComponent();
        }

        private void tela_inicial_Load(object sender, EventArgs e)
        {

        }

        private void operaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaMenu JanelaMenu = new TelaMenu();
            JanelaMenu.MdiParent = this;
            JanelaMenu.Show();
        }

        private void depositoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaLogin Janelalogin = new TelaLogin();
            Janelalogin.MdiParent = this;
            Janelalogin.Show();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 JanelaCadastro = new Form1();
            JanelaCadastro.MdiParent = this;
            JanelaCadastro.Show();
        }

        private void saqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaSaque JanelaSaque = new TelaSaque();
            JanelaSaque.MdiParent = this;
            JanelaSaque.Show();
        }

        private void depositoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaDeposito JanelaDeposito = new TelaDeposito();
            JanelaDeposito.MdiParent = this;
            JanelaDeposito.Show();
        }
    }
}
