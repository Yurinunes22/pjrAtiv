using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            if (this.menu.Items[0].Text == "Login")

            {

                TelaLogin JanelaLogin = new TelaLogin();

                JanelaLogin.MdiParent = this;


                JanelaLogin.Show();

            }

            else

            {

                menu.Items[0].Text = "Login";

                menu.Items[1].Visible = false;
                menu.Items[2].Visible = false;
                menu.Items[3].Visible = false;
                UsuarioLogado.Deslogar();

            }
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










        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaCadastro JanelaCadastro = new TelaCadastro();
            JanelaCadastro.MdiParent = this;
            JanelaCadastro.Show();
        }

        private void saqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*TelaSaque JanelaSaque = new TelaSaque();
            JanelaSaque.MdiParent = this;
            JanelaSaque.Show();*/
        }

        private void depositoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*TelaDeposito JanelaDeposito = new TelaDeposito();
            JanelaDeposito.MdiParent = this;
            JanelaDeposito.Show();*/
        }

        private void saqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaSaque JanelaSaque = new TelaSaque();
            JanelaSaque.MdiParent = this;
            JanelaSaque.Show();
        }

        private void depositoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TelaDeposito JanelaDeposito = new TelaDeposito();
            JanelaDeposito.MdiParent = this;
            JanelaDeposito.Show();
        }

        private void cadastroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TelaCadastro JanelaCadastro = new TelaCadastro();
            JanelaCadastro.MdiParent = this;
            JanelaCadastro.Show();
        }
    }
}
