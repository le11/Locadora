namespace Sistema_Locadora.Telas
{
    partial class EditLocacao
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
            this.filtroCliente = new System.Windows.Forms.Button();
            this.filtroFilme = new System.Windows.Forms.Button();
            this.searchLocacaoClient = new System.Windows.Forms.TextBox();
            this.clientLblLocacao = new System.Windows.Forms.Label();
            this.searchLocacaoFilme = new System.Windows.Forms.TextBox();
            this.searchLocacaoFilmelbl = new System.Windows.Forms.Label();
            this.searchDataDevolucao = new System.Windows.Forms.TextBox();
            this.locacaoDataDevolucao = new System.Windows.Forms.Label();
            this.searchDataRetirada = new System.Windows.Forms.TextBox();
            this.locacaoDataRetirada = new System.Windows.Forms.Label();
            this.searchLocacaoCod = new System.Windows.Forms.TextBox();
            this.locacaoCod = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.editColaborador = new System.Windows.Forms.Label();
            this.EditConfirm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // filtroCliente
            // 
            this.filtroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.filtroCliente.Location = new System.Drawing.Point(319, 157);
            this.filtroCliente.Name = "filtroCliente";
            this.filtroCliente.Size = new System.Drawing.Size(26, 20);
            this.filtroCliente.TabIndex = 35;
            this.filtroCliente.Text = "...";
            this.filtroCliente.UseVisualStyleBackColor = true;
            // 
            // filtroFilme
            // 
            this.filtroFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.filtroFilme.Location = new System.Drawing.Point(319, 122);
            this.filtroFilme.Name = "filtroFilme";
            this.filtroFilme.Size = new System.Drawing.Size(26, 20);
            this.filtroFilme.TabIndex = 34;
            this.filtroFilme.Text = "...";
            this.filtroFilme.UseVisualStyleBackColor = true;
            // 
            // searchLocacaoClient
            // 
            this.searchLocacaoClient.Location = new System.Drawing.Point(133, 157);
            this.searchLocacaoClient.Name = "searchLocacaoClient";
            this.searchLocacaoClient.Size = new System.Drawing.Size(179, 20);
            this.searchLocacaoClient.TabIndex = 32;
            // 
            // clientLblLocacao
            // 
            this.clientLblLocacao.AutoSize = true;
            this.clientLblLocacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLblLocacao.Location = new System.Drawing.Point(50, 158);
            this.clientLblLocacao.Name = "clientLblLocacao";
            this.clientLblLocacao.Size = new System.Drawing.Size(63, 17);
            this.clientLblLocacao.TabIndex = 33;
            this.clientLblLocacao.Text = "Cliente:";
            // 
            // searchLocacaoFilme
            // 
            this.searchLocacaoFilme.Location = new System.Drawing.Point(133, 121);
            this.searchLocacaoFilme.Name = "searchLocacaoFilme";
            this.searchLocacaoFilme.Size = new System.Drawing.Size(179, 20);
            this.searchLocacaoFilme.TabIndex = 30;
            // 
            // searchLocacaoFilmelbl
            // 
            this.searchLocacaoFilmelbl.AutoSize = true;
            this.searchLocacaoFilmelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLocacaoFilmelbl.Location = new System.Drawing.Point(50, 122);
            this.searchLocacaoFilmelbl.Name = "searchLocacaoFilmelbl";
            this.searchLocacaoFilmelbl.Size = new System.Drawing.Size(51, 17);
            this.searchLocacaoFilmelbl.TabIndex = 31;
            this.searchLocacaoFilmelbl.Text = "Filme:";
            // 
            // searchDataDevolucao
            // 
            this.searchDataDevolucao.Location = new System.Drawing.Point(614, 122);
            this.searchDataDevolucao.Name = "searchDataDevolucao";
            this.searchDataDevolucao.Size = new System.Drawing.Size(179, 20);
            this.searchDataDevolucao.TabIndex = 26;
            // 
            // locacaoDataDevolucao
            // 
            this.locacaoDataDevolucao.AutoSize = true;
            this.locacaoDataDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locacaoDataDevolucao.Location = new System.Drawing.Point(459, 123);
            this.locacaoDataDevolucao.Name = "locacaoDataDevolucao";
            this.locacaoDataDevolucao.Size = new System.Drawing.Size(149, 17);
            this.locacaoDataDevolucao.TabIndex = 29;
            this.locacaoDataDevolucao.Text = "Data de devolução:";
            // 
            // searchDataRetirada
            // 
            this.searchDataRetirada.Location = new System.Drawing.Point(614, 80);
            this.searchDataRetirada.Name = "searchDataRetirada";
            this.searchDataRetirada.Size = new System.Drawing.Size(179, 20);
            this.searchDataRetirada.TabIndex = 25;
            // 
            // locacaoDataRetirada
            // 
            this.locacaoDataRetirada.AutoSize = true;
            this.locacaoDataRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locacaoDataRetirada.Location = new System.Drawing.Point(459, 82);
            this.locacaoDataRetirada.Name = "locacaoDataRetirada";
            this.locacaoDataRetirada.Size = new System.Drawing.Size(132, 17);
            this.locacaoDataRetirada.TabIndex = 28;
            this.locacaoDataRetirada.Text = "Data de retirada:";
            // 
            // searchLocacaoCod
            // 
            this.searchLocacaoCod.Location = new System.Drawing.Point(133, 82);
            this.searchLocacaoCod.Name = "searchLocacaoCod";
            this.searchLocacaoCod.Size = new System.Drawing.Size(179, 20);
            this.searchLocacaoCod.TabIndex = 24;
            // 
            // locacaoCod
            // 
            this.locacaoCod.AutoSize = true;
            this.locacaoCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locacaoCod.Location = new System.Drawing.Point(50, 80);
            this.locacaoCod.Name = "locacaoCod";
            this.locacaoCod.Size = new System.Drawing.Size(63, 17);
            this.locacaoCod.TabIndex = 27;
            this.locacaoCod.Text = "Código:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(614, 160);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 37;
            // 
            // editColaborador
            // 
            this.editColaborador.AutoSize = true;
            this.editColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editColaborador.Location = new System.Drawing.Point(459, 160);
            this.editColaborador.Name = "editColaborador";
            this.editColaborador.Size = new System.Drawing.Size(102, 17);
            this.editColaborador.TabIndex = 36;
            this.editColaborador.Text = "Colaborador:";
            // 
            // EditConfirm
            // 
            this.EditConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditConfirm.Location = new System.Drawing.Point(657, 225);
            this.EditConfirm.Name = "EditConfirm";
            this.EditConfirm.Size = new System.Drawing.Size(136, 34);
            this.EditConfirm.TabIndex = 38;
            this.EditConfirm.Text = "Confirmar";
            this.EditConfirm.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 260);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // EditLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 290);
            this.Controls.Add(this.EditConfirm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.editColaborador);
            this.Controls.Add(this.filtroCliente);
            this.Controls.Add(this.filtroFilme);
            this.Controls.Add(this.searchLocacaoClient);
            this.Controls.Add(this.clientLblLocacao);
            this.Controls.Add(this.searchLocacaoFilme);
            this.Controls.Add(this.searchLocacaoFilmelbl);
            this.Controls.Add(this.searchDataDevolucao);
            this.Controls.Add(this.locacaoDataDevolucao);
            this.Controls.Add(this.searchDataRetirada);
            this.Controls.Add(this.locacaoDataRetirada);
            this.Controls.Add(this.searchLocacaoCod);
            this.Controls.Add(this.locacaoCod);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "EditLocacao";
            this.Text = "EditLocacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button filtroCliente;
        private System.Windows.Forms.Button filtroFilme;
        private System.Windows.Forms.TextBox searchLocacaoClient;
        private System.Windows.Forms.Label clientLblLocacao;
        private System.Windows.Forms.TextBox searchLocacaoFilme;
        private System.Windows.Forms.Label searchLocacaoFilmelbl;
        private System.Windows.Forms.TextBox searchDataDevolucao;
        private System.Windows.Forms.Label locacaoDataDevolucao;
        private System.Windows.Forms.TextBox searchDataRetirada;
        private System.Windows.Forms.Label locacaoDataRetirada;
        private System.Windows.Forms.TextBox searchLocacaoCod;
        private System.Windows.Forms.Label locacaoCod;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label editColaborador;
        private System.Windows.Forms.Button EditConfirm;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}