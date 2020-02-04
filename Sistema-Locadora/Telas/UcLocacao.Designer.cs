namespace Sistema_Locadora.Telas
{
    partial class UcLocacao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcLocacao));
            this.locacaoDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.searchToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.filtroCliente = new System.Windows.Forms.Button();
            this.filtroFilme = new System.Windows.Forms.Button();
            this.searchLocacaoClient = new System.Windows.Forms.TextBox();
            this.clientLblLocacao = new System.Windows.Forms.Label();
            this.searchLocacaoFilme = new System.Windows.Forms.TextBox();
            this.searchLocacaoFilmelbl = new System.Windows.Forms.Label();
            this.searchDataDevolucao = new System.Windows.Forms.TextBox();
            this.locacaoDataDevolucao = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchDataRetirada = new System.Windows.Forms.TextBox();
            this.locacaoDataRetirada = new System.Windows.Forms.Label();
            this.searchLocacaoCod = new System.Windows.Forms.TextBox();
            this.locacaoCod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // locacaoDataGridView
            // 
            this.locacaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locacaoDataGridView.Location = new System.Drawing.Point(19, 202);
            this.locacaoDataGridView.Name = "locacaoDataGridView";
            this.locacaoDataGridView.Size = new System.Drawing.Size(917, 414);
            this.locacaoDataGridView.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.editToolStripButton,
            this.deleteToolStripButton,
            this.refreshToolStripButton,
            this.toolStripSeparator1,
            this.searchToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(960, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&Novo";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // editToolStripButton
            // 
            this.editToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripButton.Image")));
            this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStripButton.Name = "editToolStripButton";
            this.editToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.editToolStripButton.Text = "&Editar";
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripButton.Image")));
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.deleteToolStripButton.Text = "&Excluir";
            // 
            // refreshToolStripButton
            // 
            this.refreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshToolStripButton.Image")));
            this.refreshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshToolStripButton.Name = "refreshToolStripButton";
            this.refreshToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.refreshToolStripButton.Text = "&Atualizar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // searchToolStripButton
            // 
            this.searchToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripButton.Image")));
            this.searchToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchToolStripButton.Name = "searchToolStripButton";
            this.searchToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.searchToolStripButton.Text = "&Filtro";
            this.searchToolStripButton.Click += new System.EventHandler(this.searchToolStripButton_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPanel.Controls.Add(this.filtroCliente);
            this.searchPanel.Controls.Add(this.filtroFilme);
            this.searchPanel.Controls.Add(this.searchLocacaoClient);
            this.searchPanel.Controls.Add(this.clientLblLocacao);
            this.searchPanel.Controls.Add(this.searchLocacaoFilme);
            this.searchPanel.Controls.Add(this.searchLocacaoFilmelbl);
            this.searchPanel.Controls.Add(this.searchDataDevolucao);
            this.searchPanel.Controls.Add(this.locacaoDataDevolucao);
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Controls.Add(this.searchDataRetirada);
            this.searchPanel.Controls.Add(this.locacaoDataRetirada);
            this.searchPanel.Controls.Add(this.searchLocacaoCod);
            this.searchPanel.Controls.Add(this.locacaoCod);
            this.searchPanel.Enabled = false;
            this.searchPanel.Location = new System.Drawing.Point(25, 50);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(909, 146);
            this.searchPanel.TabIndex = 7;
            // 
            // filtroCliente
            // 
            this.filtroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.filtroCliente.Location = new System.Drawing.Point(309, 91);
            this.filtroCliente.Name = "filtroCliente";
            this.filtroCliente.Size = new System.Drawing.Size(26, 20);
            this.filtroCliente.TabIndex = 23;
            this.filtroCliente.Text = "...";
            this.filtroCliente.UseVisualStyleBackColor = true;
            // 
            // filtroFilme
            // 
            this.filtroFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.filtroFilme.Location = new System.Drawing.Point(309, 56);
            this.filtroFilme.Name = "filtroFilme";
            this.filtroFilme.Size = new System.Drawing.Size(26, 20);
            this.filtroFilme.TabIndex = 22;
            this.filtroFilme.Text = "...";
            this.filtroFilme.UseVisualStyleBackColor = true;
            this.filtroFilme.Click += new System.EventHandler(this.filtroFilme_Click);
            // 
            // searchLocacaoClient
            // 
            this.searchLocacaoClient.Location = new System.Drawing.Point(123, 91);
            this.searchLocacaoClient.Name = "searchLocacaoClient";
            this.searchLocacaoClient.Size = new System.Drawing.Size(179, 20);
            this.searchLocacaoClient.TabIndex = 20;
            // 
            // clientLblLocacao
            // 
            this.clientLblLocacao.AutoSize = true;
            this.clientLblLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLblLocacao.Location = new System.Drawing.Point(40, 92);
            this.clientLblLocacao.Name = "clientLblLocacao";
            this.clientLblLocacao.Size = new System.Drawing.Size(63, 17);
            this.clientLblLocacao.TabIndex = 21;
            this.clientLblLocacao.Text = "Cliente:";
            // 
            // searchLocacaoFilme
            // 
            this.searchLocacaoFilme.Location = new System.Drawing.Point(123, 55);
            this.searchLocacaoFilme.Name = "searchLocacaoFilme";
            this.searchLocacaoFilme.Size = new System.Drawing.Size(179, 20);
            this.searchLocacaoFilme.TabIndex = 18;
            // 
            // searchLocacaoFilmelbl
            // 
            this.searchLocacaoFilmelbl.AutoSize = true;
            this.searchLocacaoFilmelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLocacaoFilmelbl.Location = new System.Drawing.Point(40, 56);
            this.searchLocacaoFilmelbl.Name = "searchLocacaoFilmelbl";
            this.searchLocacaoFilmelbl.Size = new System.Drawing.Size(51, 17);
            this.searchLocacaoFilmelbl.TabIndex = 19;
            this.searchLocacaoFilmelbl.Text = "Filme:";
            // 
            // searchDataDevolucao
            // 
            this.searchDataDevolucao.Location = new System.Drawing.Point(604, 56);
            this.searchDataDevolucao.Name = "searchDataDevolucao";
            this.searchDataDevolucao.Size = new System.Drawing.Size(179, 20);
            this.searchDataDevolucao.TabIndex = 3;
            // 
            // locacaoDataDevolucao
            // 
            this.locacaoDataDevolucao.AutoSize = true;
            this.locacaoDataDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locacaoDataDevolucao.Location = new System.Drawing.Point(449, 57);
            this.locacaoDataDevolucao.Name = "locacaoDataDevolucao";
            this.locacaoDataDevolucao.Size = new System.Drawing.Size(149, 17);
            this.locacaoDataDevolucao.TabIndex = 17;
            this.locacaoDataDevolucao.Text = "Data de devolução:";
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = global::Sistema_Locadora.Properties.Resources.searching;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.Location = new System.Drawing.Point(821, 92);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(40, 35);
            this.searchButton.TabIndex = 4;
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // searchDataRetirada
            // 
            this.searchDataRetirada.Location = new System.Drawing.Point(604, 14);
            this.searchDataRetirada.Name = "searchDataRetirada";
            this.searchDataRetirada.Size = new System.Drawing.Size(179, 20);
            this.searchDataRetirada.TabIndex = 2;
            // 
            // locacaoDataRetirada
            // 
            this.locacaoDataRetirada.AutoSize = true;
            this.locacaoDataRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locacaoDataRetirada.Location = new System.Drawing.Point(449, 16);
            this.locacaoDataRetirada.Name = "locacaoDataRetirada";
            this.locacaoDataRetirada.Size = new System.Drawing.Size(132, 17);
            this.locacaoDataRetirada.TabIndex = 7;
            this.locacaoDataRetirada.Text = "Data de retirada:";
            // 
            // searchLocacaoCod
            // 
            this.searchLocacaoCod.Location = new System.Drawing.Point(123, 16);
            this.searchLocacaoCod.Name = "searchLocacaoCod";
            this.searchLocacaoCod.Size = new System.Drawing.Size(179, 20);
            this.searchLocacaoCod.TabIndex = 1;
            // 
            // locacaoCod
            // 
            this.locacaoCod.AutoSize = true;
            this.locacaoCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locacaoCod.Location = new System.Drawing.Point(40, 14);
            this.locacaoCod.Name = "locacaoCod";
            this.locacaoCod.Size = new System.Drawing.Size(63, 17);
            this.locacaoCod.TabIndex = 5;
            this.locacaoCod.Text = "Código:";
            // 
            // UcLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.locacaoDataGridView);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UcLocacao";
            this.Size = new System.Drawing.Size(960, 640);
            this.Load += new System.EventHandler(this.UcLocacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.locacaoDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView locacaoDataGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton editToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton searchToolStripButton;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox searchDataDevolucao;
        private System.Windows.Forms.Label locacaoDataDevolucao;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchDataRetirada;
        private System.Windows.Forms.Label locacaoDataRetirada;
        private System.Windows.Forms.TextBox searchLocacaoCod;
        private System.Windows.Forms.Label locacaoCod;
        private System.Windows.Forms.TextBox searchLocacaoClient;
        private System.Windows.Forms.Label clientLblLocacao;
        private System.Windows.Forms.TextBox searchLocacaoFilme;
        private System.Windows.Forms.Label searchLocacaoFilmelbl;
        private System.Windows.Forms.Button filtroFilme;
        private System.Windows.Forms.Button filtroCliente;
    }
}

