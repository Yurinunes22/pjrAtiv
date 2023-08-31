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
            loginToolStripMenuItem1 = new ToolStripMenuItem();
            cadastroToolStripMenuItem1 = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            saqueToolStripMenuItem = new ToolStripMenuItem();
            depositoToolStripMenuItem1 = new ToolStripMenuItem();
            transferenciaToolStripMenuItem = new ToolStripMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, loginToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(908, 24);
            menu.TabIndex = 0;
            menu.Text = "menu";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem1, cadastroToolStripMenuItem1 });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(48, 20);
            cadastroToolStripMenuItem.Text = "Inicio";
            cadastroToolStripMenuItem.Click += cadastroToolStripMenuItem_Click;
            // 
            // loginToolStripMenuItem1
            // 
            loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            loginToolStripMenuItem1.Size = new Size(180, 22);
            loginToolStripMenuItem1.Text = "Login";
            loginToolStripMenuItem1.Click += loginToolStripMenuItem1_Click;
            // 
            // cadastroToolStripMenuItem1
            // 
            cadastroToolStripMenuItem1.Name = "cadastroToolStripMenuItem1";
            cadastroToolStripMenuItem1.Size = new Size(180, 22);
            cadastroToolStripMenuItem1.Text = "Cadastro";
            cadastroToolStripMenuItem1.Click += cadastroToolStripMenuItem1_Click;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saqueToolStripMenuItem, depositoToolStripMenuItem1, transferenciaToolStripMenuItem });
            loginToolStripMenuItem.Enabled = false;
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(75, 20);
            loginToolStripMenuItem.Text = "Operações";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // saqueToolStripMenuItem
            // 
            saqueToolStripMenuItem.Name = "saqueToolStripMenuItem";
            saqueToolStripMenuItem.Size = new Size(180, 22);
            saqueToolStripMenuItem.Text = "Saque";
            saqueToolStripMenuItem.Click += saqueToolStripMenuItem_Click;
            // 
            // depositoToolStripMenuItem1
            // 
            depositoToolStripMenuItem1.Name = "depositoToolStripMenuItem1";
            depositoToolStripMenuItem1.Size = new Size(180, 22);
            depositoToolStripMenuItem1.Text = "Deposito";
            depositoToolStripMenuItem1.Click += depositoToolStripMenuItem1_Click;
            // 
            // transferenciaToolStripMenuItem
            // 
            transferenciaToolStripMenuItem.Name = "transferenciaToolStripMenuItem";
            transferenciaToolStripMenuItem.Size = new Size(180, 22);
            transferenciaToolStripMenuItem.Text = "Transferencia";
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
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem1;
        private ToolStripMenuItem cadastroToolStripMenuItem1;
        private ToolStripMenuItem saqueToolStripMenuItem;
        private ToolStripMenuItem depositoToolStripMenuItem1;
        private ToolStripMenuItem transferenciaToolStripMenuItem;
    }
}