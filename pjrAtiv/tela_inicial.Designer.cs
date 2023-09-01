namespace pjrAtiv
{
    partial class tela_inicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menu = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem2 = new ToolStripMenuItem();
            saqueToolStripMenuItem1 = new ToolStripMenuItem();
            depositoToolStripMenuItem = new ToolStripMenuItem();
            abrirContaToolStripMenuItem = new ToolStripMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, cadastroToolStripMenuItem2, saqueToolStripMenuItem1, depositoToolStripMenuItem, abrirContaToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(908, 24);
            menu.TabIndex = 0;
            menu.Text = "menu";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(49, 20);
            cadastroToolStripMenuItem.Text = "Login";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // cadastroToolStripMenuItem2
            // 
            cadastroToolStripMenuItem2.Name = "cadastroToolStripMenuItem2";
            cadastroToolStripMenuItem2.Size = new Size(66, 20);
            cadastroToolStripMenuItem2.Text = "Cadastro";
            cadastroToolStripMenuItem2.Click += cadastroToolStripMenuItem2_Click;
            // 
            // saqueToolStripMenuItem1
            // 
            saqueToolStripMenuItem1.Name = "saqueToolStripMenuItem1";
            saqueToolStripMenuItem1.Size = new Size(51, 20);
            saqueToolStripMenuItem1.Text = "Saque";
            saqueToolStripMenuItem1.Visible = false;
            saqueToolStripMenuItem1.Click += saqueToolStripMenuItem1_Click;
            // 
            // depositoToolStripMenuItem
            // 
            depositoToolStripMenuItem.Name = "depositoToolStripMenuItem";
            depositoToolStripMenuItem.Size = new Size(66, 20);
            depositoToolStripMenuItem.Text = "Deposito";
            depositoToolStripMenuItem.Visible = false;
            depositoToolStripMenuItem.Click += depositoToolStripMenuItem_Click_1;
            // 
            // abrirContaToolStripMenuItem
            // 
            abrirContaToolStripMenuItem.Name = "abrirContaToolStripMenuItem";
            abrirContaToolStripMenuItem.Size = new Size(80, 20);
            abrirContaToolStripMenuItem.Text = "Abrir Conta";
            abrirContaToolStripMenuItem.Visible = false;
            // 
            // tela_inicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(908, 540);
            ControlBox = false;
            Controls.Add(menu);
            IsMdiContainer = true;
            MainMenuStrip = menu;
            MaximumSize = new Size(1000, 1000);
            MinimizeBox = false;
            Name = "tela_inicial";
            Text = "tela_inicial";
            Load += tela_inicial_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem saqueToolStripMenuItem1;
        private ToolStripMenuItem depositoToolStripMenuItem;
        private ToolStripMenuItem abrirContaToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem2;
    }
}