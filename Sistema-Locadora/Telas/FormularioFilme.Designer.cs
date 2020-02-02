namespace Sistema_Locadora.Telas
{
    partial class FormularioFilme
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
            this.addGeneroCmb1 = new System.Windows.Forms.ComboBox();
            this.NovConfirm = new System.Windows.Forms.Button();
            this.anoDeProducaoLabel = new System.Windows.Forms.Label();
            this.addAnoDeProducaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ator_PrincipalLabel = new System.Windows.Forms.Label();
            this.addAtor_PrincipalTextBox = new System.Windows.Forms.TextBox();
            this.classificacaoLabel = new System.Windows.Forms.Label();
            this.addClassificacaoTextBox = new System.Windows.Forms.TextBox();
            this.fornecedorLabel = new System.Windows.Forms.Label();
            this.addFornecedorTextBox = new System.Windows.Forms.TextBox();
            this.generoLabel = new System.Windows.Forms.Label();
            this.idiomaLabel = new System.Windows.Forms.Label();
            this.legendaLabel = new System.Windows.Forms.Label();
            this.addLegendaTextBox = new System.Windows.Forms.TextBox();
            this.localizacaoLabel = new System.Windows.Forms.Label();
            this.addLocalizacaoTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeLabel = new System.Windows.Forms.Label();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.addTituloTextBox = new System.Windows.Forms.TextBox();
            this.titulo_OriginalLabel = new System.Windows.Forms.Label();
            this.addTitulo_OriginalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addIdiomaTextBox = new System.Windows.Forms.TextBox();
            this.nvClientlbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addQuantidade = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.addQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // addGeneroCmb1
            // 
            this.addGeneroCmb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addGeneroCmb1.FormattingEnabled = true;
            this.addGeneroCmb1.Location = new System.Drawing.Point(483, 175);
            this.addGeneroCmb1.Name = "addGeneroCmb1";
            this.addGeneroCmb1.Size = new System.Drawing.Size(200, 21);
            this.addGeneroCmb1.TabIndex = 11;
            // 
            // NovConfirm
            // 
            this.NovConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NovConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovConfirm.Location = new System.Drawing.Point(566, 242);
            this.NovConfirm.Name = "NovConfirm";
            this.NovConfirm.Size = new System.Drawing.Size(117, 34);
            this.NovConfirm.TabIndex = 12;
            this.NovConfirm.Text = "Confirmar";
            this.NovConfirm.UseVisualStyleBackColor = true;
            this.NovConfirm.Click += new System.EventHandler(this.NovConfirm_Click);
            // 
            // anoDeProducaoLabel
            // 
            this.anoDeProducaoLabel.AutoSize = true;
            this.anoDeProducaoLabel.Location = new System.Drawing.Point(382, 74);
            this.anoDeProducaoLabel.Name = "anoDeProducaoLabel";
            this.anoDeProducaoLabel.Size = new System.Drawing.Size(95, 13);
            this.anoDeProducaoLabel.TabIndex = 35;
            this.anoDeProducaoLabel.Text = "Ano De Producao:";
            // 
            // addAnoDeProducaoDateTimePicker
            // 
            this.addAnoDeProducaoDateTimePicker.CustomFormat = "yyyy";
            this.addAnoDeProducaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.addAnoDeProducaoDateTimePicker.Location = new System.Drawing.Point(483, 70);
            this.addAnoDeProducaoDateTimePicker.Name = "addAnoDeProducaoDateTimePicker";
            this.addAnoDeProducaoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.addAnoDeProducaoDateTimePicker.TabIndex = 7;
            // 
            // ator_PrincipalLabel
            // 
            this.ator_PrincipalLabel.AutoSize = true;
            this.ator_PrincipalLabel.Location = new System.Drawing.Point(382, 99);
            this.ator_PrincipalLabel.Name = "ator_PrincipalLabel";
            this.ator_PrincipalLabel.Size = new System.Drawing.Size(76, 13);
            this.ator_PrincipalLabel.TabIndex = 37;
            this.ator_PrincipalLabel.Text = "Ator Principal:*";
            // 
            // addAtor_PrincipalTextBox
            // 
            this.addAtor_PrincipalTextBox.Location = new System.Drawing.Point(483, 96);
            this.addAtor_PrincipalTextBox.Name = "addAtor_PrincipalTextBox";
            this.addAtor_PrincipalTextBox.Size = new System.Drawing.Size(200, 20);
            this.addAtor_PrincipalTextBox.TabIndex = 8;
            // 
            // classificacaoLabel
            // 
            this.classificacaoLabel.AutoSize = true;
            this.classificacaoLabel.Location = new System.Drawing.Point(382, 125);
            this.classificacaoLabel.Name = "classificacaoLabel";
            this.classificacaoLabel.Size = new System.Drawing.Size(72, 13);
            this.classificacaoLabel.TabIndex = 39;
            this.classificacaoLabel.Text = "Classificacao:";
            // 
            // addClassificacaoTextBox
            // 
            this.addClassificacaoTextBox.Location = new System.Drawing.Point(483, 122);
            this.addClassificacaoTextBox.Name = "addClassificacaoTextBox";
            this.addClassificacaoTextBox.Size = new System.Drawing.Size(200, 20);
            this.addClassificacaoTextBox.TabIndex = 9;
            // 
            // fornecedorLabel
            // 
            this.fornecedorLabel.AutoSize = true;
            this.fornecedorLabel.Location = new System.Drawing.Point(382, 152);
            this.fornecedorLabel.Name = "fornecedorLabel";
            this.fornecedorLabel.Size = new System.Drawing.Size(64, 13);
            this.fornecedorLabel.TabIndex = 43;
            this.fornecedorLabel.Text = "Fornecedor:";
            // 
            // addFornecedorTextBox
            // 
            this.addFornecedorTextBox.Location = new System.Drawing.Point(483, 149);
            this.addFornecedorTextBox.Name = "addFornecedorTextBox";
            this.addFornecedorTextBox.Size = new System.Drawing.Size(200, 20);
            this.addFornecedorTextBox.TabIndex = 10;
            // 
            // generoLabel
            // 
            this.generoLabel.AutoSize = true;
            this.generoLabel.Location = new System.Drawing.Point(382, 178);
            this.generoLabel.Name = "generoLabel";
            this.generoLabel.Size = new System.Drawing.Size(45, 13);
            this.generoLabel.TabIndex = 45;
            this.generoLabel.Text = "Genero:";
            // 
            // idiomaLabel
            // 
            this.idiomaLabel.AutoSize = true;
            this.idiomaLabel.Location = new System.Drawing.Point(-47, 256);
            this.idiomaLabel.Name = "idiomaLabel";
            this.idiomaLabel.Size = new System.Drawing.Size(41, 13);
            this.idiomaLabel.TabIndex = 46;
            this.idiomaLabel.Text = "Idioma:";
            // 
            // legendaLabel
            // 
            this.legendaLabel.AutoSize = true;
            this.legendaLabel.Location = new System.Drawing.Point(25, 208);
            this.legendaLabel.Name = "legendaLabel";
            this.legendaLabel.Size = new System.Drawing.Size(52, 13);
            this.legendaLabel.TabIndex = 48;
            this.legendaLabel.Text = "Legenda:";
            // 
            // addLegendaTextBox
            // 
            this.addLegendaTextBox.Location = new System.Drawing.Point(126, 205);
            this.addLegendaTextBox.Name = "addLegendaTextBox";
            this.addLegendaTextBox.Size = new System.Drawing.Size(200, 20);
            this.addLegendaTextBox.TabIndex = 6;
            // 
            // localizacaoLabel
            // 
            this.localizacaoLabel.AutoSize = true;
            this.localizacaoLabel.Location = new System.Drawing.Point(25, 129);
            this.localizacaoLabel.Name = "localizacaoLabel";
            this.localizacaoLabel.Size = new System.Drawing.Size(67, 13);
            this.localizacaoLabel.TabIndex = 50;
            this.localizacaoLabel.Text = "Localizacao:";
            // 
            // addLocalizacaoTextBox
            // 
            this.addLocalizacaoTextBox.Location = new System.Drawing.Point(126, 126);
            this.addLocalizacaoTextBox.Name = "addLocalizacaoTextBox";
            this.addLocalizacaoTextBox.Size = new System.Drawing.Size(200, 20);
            this.addLocalizacaoTextBox.TabIndex = 3;
            // 
            // quantidadeLabel
            // 
            this.quantidadeLabel.AutoSize = true;
            this.quantidadeLabel.Location = new System.Drawing.Point(25, 155);
            this.quantidadeLabel.Name = "quantidadeLabel";
            this.quantidadeLabel.Size = new System.Drawing.Size(69, 13);
            this.quantidadeLabel.TabIndex = 52;
            this.quantidadeLabel.Text = "Quantidade:*";
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Location = new System.Drawing.Point(-50, 148);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(36, 13);
            this.tituloLabel.TabIndex = 54;
            this.tituloLabel.Text = "Titulo:";
            // 
            // addTituloTextBox
            // 
            this.addTituloTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addTituloTextBox.Location = new System.Drawing.Point(126, 71);
            this.addTituloTextBox.Name = "addTituloTextBox";
            this.addTituloTextBox.Size = new System.Drawing.Size(200, 20);
            this.addTituloTextBox.TabIndex = 1;
            // 
            // titulo_OriginalLabel
            // 
            this.titulo_OriginalLabel.AutoSize = true;
            this.titulo_OriginalLabel.Location = new System.Drawing.Point(22, 100);
            this.titulo_OriginalLabel.Name = "titulo_OriginalLabel";
            this.titulo_OriginalLabel.Size = new System.Drawing.Size(74, 13);
            this.titulo_OriginalLabel.TabIndex = 56;
            this.titulo_OriginalLabel.Text = "Titulo Original:";
            // 
            // addTitulo_OriginalTextBox
            // 
            this.addTitulo_OriginalTextBox.Location = new System.Drawing.Point(126, 97);
            this.addTitulo_OriginalTextBox.Name = "addTitulo_OriginalTextBox";
            this.addTitulo_OriginalTextBox.Size = new System.Drawing.Size(200, 20);
            this.addTitulo_OriginalTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-47, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Idioma:";
            // 
            // addIdiomaTextBox
            // 
            this.addIdiomaTextBox.Location = new System.Drawing.Point(126, 179);
            this.addIdiomaTextBox.Name = "addIdiomaTextBox";
            this.addIdiomaTextBox.Size = new System.Drawing.Size(200, 20);
            this.addIdiomaTextBox.TabIndex = 5;
            // 
            // nvClientlbl
            // 
            this.nvClientlbl.AutoSize = true;
            this.nvClientlbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.nvClientlbl.Location = new System.Drawing.Point(20, 18);
            this.nvClientlbl.Name = "nvClientlbl";
            this.nvClientlbl.Size = new System.Drawing.Size(300, 26);
            this.nvClientlbl.TabIndex = 62;
            this.nvClientlbl.Text = "Preencha os campos abaixo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Titulo:*";
            // 
            // addQuantidade
            // 
            this.addQuantidade.Location = new System.Drawing.Point(126, 153);
            this.addQuantidade.Name = "addQuantidade";
            this.addQuantidade.Size = new System.Drawing.Size(200, 20);
            this.addQuantidade.TabIndex = 64;
            // 
            // FormularioFilme
            // 
            this.AcceptButton = this.NovConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 321);
            this.Controls.Add(this.addQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nvClientlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addIdiomaTextBox);
            this.Controls.Add(this.addGeneroCmb1);
            this.Controls.Add(this.NovConfirm);
            this.Controls.Add(this.anoDeProducaoLabel);
            this.Controls.Add(this.addAnoDeProducaoDateTimePicker);
            this.Controls.Add(this.ator_PrincipalLabel);
            this.Controls.Add(this.addAtor_PrincipalTextBox);
            this.Controls.Add(this.classificacaoLabel);
            this.Controls.Add(this.addClassificacaoTextBox);
            this.Controls.Add(this.fornecedorLabel);
            this.Controls.Add(this.addFornecedorTextBox);
            this.Controls.Add(this.generoLabel);
            this.Controls.Add(this.idiomaLabel);
            this.Controls.Add(this.legendaLabel);
            this.Controls.Add(this.addLegendaTextBox);
            this.Controls.Add(this.localizacaoLabel);
            this.Controls.Add(this.addLocalizacaoTextBox);
            this.Controls.Add(this.quantidadeLabel);
            this.Controls.Add(this.tituloLabel);
            this.Controls.Add(this.addTituloTextBox);
            this.Controls.Add(this.titulo_OriginalLabel);
            this.Controls.Add(this.addTitulo_OriginalTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormularioFilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioFilme";
            this.Load += new System.EventHandler(this.FormularioFilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox addGeneroCmb1;
        private System.Windows.Forms.Button NovConfirm;
        private System.Windows.Forms.Label anoDeProducaoLabel;
        private System.Windows.Forms.DateTimePicker addAnoDeProducaoDateTimePicker;
        private System.Windows.Forms.Label ator_PrincipalLabel;
        private System.Windows.Forms.TextBox addAtor_PrincipalTextBox;
        private System.Windows.Forms.Label classificacaoLabel;
        private System.Windows.Forms.TextBox addClassificacaoTextBox;
        private System.Windows.Forms.Label fornecedorLabel;
        private System.Windows.Forms.TextBox addFornecedorTextBox;
        private System.Windows.Forms.Label generoLabel;
        private System.Windows.Forms.Label idiomaLabel;
        private System.Windows.Forms.Label legendaLabel;
        private System.Windows.Forms.TextBox addLegendaTextBox;
        private System.Windows.Forms.Label localizacaoLabel;
        private System.Windows.Forms.TextBox addLocalizacaoTextBox;
        private System.Windows.Forms.Label quantidadeLabel;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.TextBox addTituloTextBox;
        private System.Windows.Forms.Label titulo_OriginalLabel;
        private System.Windows.Forms.TextBox addTitulo_OriginalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addIdiomaTextBox;
        private System.Windows.Forms.Label nvClientlbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown addQuantidade;
    }
}