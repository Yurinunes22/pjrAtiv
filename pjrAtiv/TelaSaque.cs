﻿using System;
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
    }
}
