namespace Sistema_Locadora.Telas
{
    partial class FormularioLocacao
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
            this.addDataRetiradalbl = new System.Windows.Forms.Label();
            this.addDataDevolucaolbl = new System.Windows.Forms.Label();
            this.addClientlbl = new System.Windows.Forms.Label();
            this.addColablbl = new System.Windows.Forms.Label();
            this.addFilmelbl = new System.Windows.Forms.Label();
            this.addColabTxt = new System.Windows.Forms.TextBox();
            this.addFilmeTxt = new System.Windows.Forms.TextBox();
            this.NovLocConfirm = new System.Windows.Forms.Button();
            this.RetiradadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DevolucaodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addClientTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filtroFilme = new System.Windows.Forms.Button();
            this.filtroCliente = new System.Windows.Forms.Button();
            this.statusLbl = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addDataRetiradalbl
            // 
            this.addDataRetiradalbl.AutoSize = true;
            this.addDataRetiradalbl.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDataRetiradalbl.Location = new System.Drawing.Point(28, 63);
            this.addDataRetiradalbl.Name = "addDataRetiradalbl";
            this.addDataRetiradalbl.Size = new System.Drawing.Size(118, 17);
            this.addDataRetiradalbl.TabIndex = 0;
            this.addDataRetiradalbl.Text = "Data de retirada:";
            // 
            // addDataDevolucaolbl
            // 
            this.addDataDevolucaolbl.AutoSize = true;
            this.addDataDevolucaolbl.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDataDevolucaolbl.Location = new System.Drawing.Point(28, 105);
            this.addDataDevolucaolbl.Name = "addDataDevolucaolbl";
            this.addDataDevolucaolbl.Size = new System.Drawing.Size(133, 17);
            this.addDataDevolucaolbl.TabIndex = 1;
            this.addDataDevolucaolbl.Text = "Data de devolução:";
            // 
            // addClientlbl
            // 
            this.addClientlbl.AutoSize = true;
            this.addClientlbl.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientlbl.Location = new System.Drawing.Point(28, 150);
            this.addClientlbl.Name = "addClientlbl";
            this.addClientlbl.Size = new System.Drawing.Size(61, 17);
            this.addClientlbl.TabIndex = 2;
            this.addClientlbl.Text = "Cliente:";
            // 
            // addColablbl
            // 
            this.addColablbl.AutoSize = true;
            this.addColablbl.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addColablbl.Location = new System.Drawing.Point(28, 190);
            this.addColablbl.Name = "addColablbl";
            this.addColablbl.Size = new System.Drawing.Size(94, 17);
            this.addColablbl.TabIndex = 3;
            this.addColablbl.Text = "Colaborador:";
            // 
            // addFilmelbl
            // 
            this.addFilmelbl.AutoSize = true;
            this.addFilmelbl.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFilmelbl.Location = new System.Drawing.Point(28, 231);
            this.addFilmelbl.Name = "addFilmelbl";
            this.addFilmelbl.Size = new System.Drawing.Size(50, 17);
            this.addFilmelbl.TabIndex = 4;
            this.addFilmelbl.Text = "Filme:";
            // 
            // addColabTxt
            // 
            this.addColabTxt.Location = new System.Drawing.Point(169, 190);
            this.addColabTxt.Name = "addColabTxt";
            this.addColabTxt.ReadOnly = true;
            this.addColabTxt.Size = new System.Drawing.Size(276, 20);
            this.addColabTxt.TabIndex = 6;
            // 
            // addFilmeTxt
            // 
            this.addFilmeTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addFilmeTxt.Location = new System.Drawing.Point(169, 231);
            this.addFilmeTxt.Name = "addFilmeTxt";
            this.addFilmeTxt.ReadOnly = true;
            this.addFilmeTxt.Size = new System.Drawing.Size(276, 20);
            this.addFilmeTxt.TabIndex = 7;
            // 
            // NovLocConfirm
            // 
            this.NovLocConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NovLocConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NovLocConfirm.Location = new System.Drawing.Point(503, 266);
            this.NovLocConfirm.Name = "NovLocConfirm";
            this.NovLocConfirm.Size = new System.Drawing.Size(117, 34);
            this.NovLocConfirm.TabIndex = 13;
            this.NovLocConfirm.Text = "Confirmar";
            this.NovLocConfirm.UseVisualStyleBackColor = true;
            this.NovLocConfirm.Click += new System.EventHandler(this.NovLocConfirm_Click);
            // 
            // RetiradadateTimePicker
            // 
            this.RetiradadateTimePicker.Location = new System.Drawing.Point(169, 63);
            this.RetiradadateTimePicker.Name = "RetiradadateTimePicker";
            this.RetiradadateTimePicker.Size = new System.Drawing.Size(276, 20);
            this.RetiradadateTimePicker.TabIndex = 15;
            // 
            // DevolucaodateTimePicker
            // 
            this.DevolucaodateTimePicker.Location = new System.Drawing.Point(169, 102);
            this.DevolucaodateTimePicker.Name = "DevolucaodateTimePicker";
            this.DevolucaodateTimePicker.Size = new System.Drawing.Size(276, 20);
            this.DevolucaodateTimePicker.TabIndex = 17;
            // 
            // addClientTxt
            // 
            this.addClientTxt.Location = new System.Drawing.Point(169, 147);
            this.addClientTxt.Name = "addClientTxt";
            this.addClientTxt.ReadOnly = true;
            this.addClientTxt.Size = new System.Drawing.Size(276, 20);
            this.addClientTxt.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Preencha os campos abaixo:";
            // 
            // filtroFilme
            // 
            this.filtroFilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.filtroFilme.Location = new System.Drawing.Point(452, 231);
            this.filtroFilme.Name = "filtroFilme";
            this.filtroFilme.Size = new System.Drawing.Size(26, 20);
            this.filtroFilme.TabIndex = 23;
            this.filtroFilme.Text = "...";
            this.filtroFilme.UseVisualStyleBackColor = true;
            this.filtroFilme.Click += new System.EventHandler(this.filtroFilme_Click);
            // 
            // filtroCliente
            // 
            this.filtroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.filtroCliente.Location = new System.Drawing.Point(451, 148);
            this.filtroCliente.Name = "filtroCliente";
            this.filtroCliente.Size = new System.Drawing.Size(26, 20);
            this.filtroCliente.TabIndex = 24;
            this.filtroCliente.Text = "...";
            this.filtroCliente.UseVisualStyleBackColor = true;
            this.filtroCliente.Click += new System.EventHandler(this.filtroCliente_Click);
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.Location = new System.Drawing.Point(28, 266);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(53, 17);
            this.statusLbl.TabIndex = 25;
            this.statusLbl.Text = "Status:";
            // 
            // statusComboBox
            // 
            this.statusComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusComboBox.Location = new System.Drawing.Point(169, 266);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.ReadOnly = true;
            this.statusComboBox.Size = new System.Drawing.Size(276, 20);
            this.statusComboBox.TabIndex = 26;
            this.statusComboBox.Text = "Locado";
            // 
            // FormularioLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 321);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.filtroCliente);
            this.Controls.Add(this.filtroFilme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addClientTxt);
            this.Controls.Add(this.DevolucaodateTimePicker);
            this.Controls.Add(this.RetiradadateTimePicker);
            this.Controls.Add(this.NovLocConfirm);
            this.Controls.Add(this.addFilmeTxt);
            this.Controls.Add(this.addColabTxt);
            this.Controls.Add(this.addFilmelbl);
            this.Controls.Add(this.addColablbl);
            this.Controls.Add(this.addClientlbl);
            this.Controls.Add(this.addDataDevolucaolbl);
            this.Controls.Add(this.addDataRetiradalbl);
            this.MaximizeBox = false;
            this.Name = "FormularioLocacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormularioLocacao";
            this.Load += new System.EventHandler(this.FormularioLocacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addDataRetiradalbl;
        private System.Windows.Forms.Label addDataDevolucaolbl;
        private System.Windows.Forms.Label addClientlbl;
        private System.Windows.Forms.Label addColablbl;
        private System.Windows.Forms.Label addFilmelbl;
        private System.Windows.Forms.TextBox addColabTxt;
        private System.Windows.Forms.TextBox addFilmeTxt;
        private System.Windows.Forms.Button NovLocConfirm;
        private System.Windows.Forms.DateTimePicker RetiradadateTimePicker;
        private System.Windows.Forms.DateTimePicker DevolucaodateTimePicker;
        private System.Windows.Forms.TextBox addClientTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button filtroFilme;
        private System.Windows.Forms.Button filtroCliente;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.TextBox statusComboBox;
    }
}