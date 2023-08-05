using pjrAtiv.Classes;
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
    public partial class Collection : Form
    {
        List<Cliente> Clientes = new List<Cliente>();
        public Collection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente(Convert.ToInt32(txtIdCliente.Text), TxtNomeCliente.Text);

                MessageBox.Show($"Cliente adicionado com sucesso\n{cliente.id}:{cliente.Nome}", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clientes.Add(cliente);
            }
            catch (FormatException ex)
            {

                MessageBox.Show("Formato inválido ");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.HelpLink}-{ex.Message}");
            }




            txtIdCliente.Clear();
            TxtNomeCliente.Clear();
            txtIdCliente.Focus();






        }

        private void Collection_Load(object sender, EventArgs e)
        {
            //declarando dois vetores

            string[] meuArrayString = new string[3];
            int[] meuArrayIn = { 2, 2, 7, 9, 10 };

            //colocando informações nos arrays

            /* meuArrayString[0] = "Tobias";
             meuArrayString[1] = "Lucas";
             meuArrayString[2] = "Bea"; */


            //exibir informações dos arrays

            string mensagemFinal = "";
            for (int contador = 0; contador < meuArrayString.Length; contador = contador + 1)
            {
                mensagemFinal = mensagemFinal + $"{meuArrayString[contador]}\n";


            }

            //MessageBox.Show(mensagemFinal);


        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            foreach (var item in Clientes)
            {
                lstClientes.Items.Clear();
                //MessageBox.Show($"{item.id}:{item.Nome}");
                lstClientes.Items.Add($"{item.id}-{item.Nome}");
                 
            }

            //atributos valor a um item da lista 
            Clientes[2].Nome = "Pepito";
            //resgatando valor de um item da lista
            MessageBox.Show(Clientes[2].Nome);





        }
    }
}
