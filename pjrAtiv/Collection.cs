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
        public Collection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Collection_Load(object sender, EventArgs e)
        {
            //declarando dois vetores

            string[] meuArrayString = new string[3];
            int[] meuArrayIn = { 2, 2, 7, 9, 10 };

            //colocando informações nos arrays

            meuArrayString[0] = "Tobias";
            meuArrayString[1] = "Lucas";
            meuArrayString[2] = "Bea";


            //exibir informações dos arrays

            string mensagemFinal = "";
            for (int contador = 0; contador < meuArrayString.Length; contador = contador + 1)
            {
                mensagemFinal = mensagemFinal + $"{meuArrayString[contador]}\n"; 
             
             
            }

            MessageBox.Show(mensagemFinal);


        }
    }
}
