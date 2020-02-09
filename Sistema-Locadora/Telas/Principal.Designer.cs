namespace Sistema_Locadora.Telas
{
    partial class Principal
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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnColab = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnNovClient = new System.Windows.Forms.Button();
            this.btnNovLoc = new System.Windows.Forms.Button();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.UsuarioLbl = new System.Windows.Forms.Label();
            this.UsuarioConectadolbl = new System.Windows.Forms.Label();
            this.ucLocacao1 = new Sistema_Locadora.Telas.UcLocacao();
            this.ucCliente1 = new Sistema_Locadora.Telas.UcCliente();
            this.ucFilme1 = new Sistema_Locadora.Telas.UcFilme();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.centerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.Controls.Add(this.UsuarioConectadolbl);
            this.sidePanel.Controls.Add(this.UsuarioLbl);
            this.sidePanel.Controls.Add(this.pictureBox1);
            this.sidePanel.Controls.Add(this.btnColab);
            this.sidePanel.Controls.Add(this.btnEstoque);
            this.sidePanel.Controls.Add(this.btnNovClient);
            this.sidePanel.Controls.Add(this.btnNovLoc);
            this.sidePanel.Location = new System.Drawing.Point(0, 3);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(219, 640);
            this.sidePanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_Locadora.Properties.Resources.movie;
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnColab
            // 
            this.btnColab.BackColor = System.Drawing.Color.White;
            this.btnColab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColab.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColab.ForeColor = System.Drawing.Color.Black;
            this.btnColab.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnColab.Location = new System.Drawing.Point(2, 269);
            this.btnColab.Name = "btnColab";
            this.btnColab.Size = new System.Drawing.Size(217, 46);
            this.btnColab.TabIndex = 4;
            this.btnColab.Text = "&Usuários";
            this.btnColab.UseVisualStyleBackColor = false;
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.White;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.Black;
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEstoque.Location = new System.Drawing.Point(2, 223);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(217, 46);
            this.btnEstoque.TabIndex = 2;
            this.btnEstoque.Text = "&Filmes";
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnNovClient
            // 
            this.btnNovClient.BackColor = System.Drawing.Color.White;
            this.btnNovClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovClient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovClient.ForeColor = System.Drawing.Color.Black;
            this.btnNovClient.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNovClient.Location = new System.Drawing.Point(2, 177);
            this.btnNovClient.Name = "btnNovClient";
            this.btnNovClient.Size = new System.Drawing.Size(217, 46);
            this.btnNovClient.TabIndex = 1;
            this.btnNovClient.Text = "&Clientes";
            this.btnNovClient.UseVisualStyleBackColor = false;
            this.btnNovClient.Click += new System.EventHandler(this.btnNovClient_Click);
            // 
            // btnNovLoc
            // 
            this.btnNovLoc.BackColor = System.Drawing.Color.White;
            this.btnNovLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovLoc.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovLoc.ForeColor = System.Drawing.Color.Black;
            this.btnNovLoc.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNovLoc.Location = new System.Drawing.Point(2, 131);
            this.btnNovLoc.Name = "btnNovLoc";
            this.btnNovLoc.Size = new System.Drawing.Size(217, 46);
            this.btnNovLoc.TabIndex = 0;
            this.btnNovLoc.Text = "&Locação";
            this.btnNovLoc.UseVisualStyleBackColor = false;
            this.btnNovLoc.Click += new System.EventHandler(this.btnNovLoc_Click);
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.ucLocacao1);
            this.centerPanel.Controls.Add(this.ucCliente1);
            this.centerPanel.Controls.Add(this.ucFilme1);
            this.centerPanel.Location = new System.Drawing.Point(220, 1);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(960, 640);
            this.centerPanel.TabIndex = 1;
            // 
            // UsuarioLbl
            // 
            this.UsuarioLbl.AutoSize = true;
            this.UsuarioLbl.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.UsuarioLbl.Location = new System.Drawing.Point(3, 616);
            this.UsuarioLbl.Name = "UsuarioLbl";
            this.UsuarioLbl.Size = new System.Drawing.Size(57, 17);
            this.UsuarioLbl.TabIndex = 5;
            this.UsuarioLbl.Text = "Usuário:";
            // 
            // UsuarioConectadolbl
            // 
            this.UsuarioConectadolbl.AutoSize = true;
            this.UsuarioConectadolbl.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.UsuarioConectadolbl.Location = new System.Drawing.Point(60, 613);
            this.UsuarioConectadolbl.Name = "UsuarioConectadolbl";
            this.UsuarioConectadolbl.Size = new System.Drawing.Size(41, 20);
            this.UsuarioConectadolbl.TabIndex = 6;
            this.UsuarioConectadolbl.Text = "user";
            // 
            // ucLocacao1
            // 
            this.ucLocacao1.Location = new System.Drawing.Point(0, 0);
            this.ucLocacao1.Name = "ucLocacao1";
            this.ucLocacao1.Size = new System.Drawing.Size(960, 640);
            this.ucLocacao1.TabIndex = 5;
            // 
            // ucCliente1
            // 
            this.ucCliente1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCliente1.Location = new System.Drawing.Point(-1, 0);
            this.ucCliente1.Name = "ucCliente1";
            this.ucCliente1.Size = new System.Drawing.Size(960, 640);
            this.ucCliente1.TabIndex = 4;
            // 
            // ucFilme1
            // 
            this.ucFilme1.Location = new System.Drawing.Point(-1, 1);
            this.ucFilme1.Name = "ucFilme1";
            this.ucFilme1.Size = new System.Drawing.Size(960, 640);
            this.ucFilme1.TabIndex = 3;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 649);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JanelaPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.centerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Button btnNovLoc;
        private System.Windows.Forms.Button btnNovClient;
        private System.Windows.Forms.Button btnColab;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UcFilme ucFilme1;
        private UcCliente ucCliente1;
        private UcLocacao ucLocacao1;
        private System.Windows.Forms.Label UsuarioConectadolbl;
        private System.Windows.Forms.Label UsuarioLbl;
    }
}