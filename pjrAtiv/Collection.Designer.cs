namespace pjrAtiv
{
    partial class Collection
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
            txtIdCliente = new TextBox();
            TxtNomeCliente = new TextBox();
            btnAdicionar = new Button();
            btnListar = new Button();
            lstClientes = new ListBox();
            SuspendLayout();
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(12, 53);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(65, 23);
            txtIdCliente.TabIndex = 0;
            // 
            // TxtNomeCliente
            // 
            TxtNomeCliente.Location = new Point(12, 120);
            TxtNomeCliente.Name = "TxtNomeCliente";
            TxtNomeCliente.Size = new Size(343, 23);
            TxtNomeCliente.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(54, 189);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += button1_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(219, 189);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 3;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.ItemHeight = 15;
            lstClientes.Location = new Point(12, 287);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(341, 184);
            lstClientes.TabIndex = 4;
            // 
            // Collection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 507);
            Controls.Add(lstClientes);
            Controls.Add(btnListar);
            Controls.Add(btnAdicionar);
            Controls.Add(TxtNomeCliente);
            Controls.Add(txtIdCliente);
            Name = "Collection";
            Text = "Collection";
            Load += Collection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdCliente;
        private TextBox TxtNomeCliente;
        private Button btnAdicionar;
        private Button btnListar;
        private ListBox lstClientes;
    }
}