namespace Sistema_Locadora.Telas
{
    partial class FormularioCliente
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
            this.addCpfTxtmsk = new System.Windows.Forms.MaskedTextBox();
            this.cpfClientelbl = new System.Windows.Forms.Label();
            this.addClientBtn = new System.Windows.Forms.Button();
            this.addClientEmail = new System.Windows.Forms.TextBox();
            this.AddTelmkTxt = new System.Windows.Forms.MaskedTextBox();
            this.addClientName = new System.Windows.Forms.TextBox();
            this.clientEmail = new System.Windows.Forms.Label();
            this.clientTel = new System.Windows.Forms.Label();
            this.clientName = new System.Windows.Forms.Label();
            this.nvClientlbl = new System.Windows.Forms.Label();
            this.formularioGroupBox = new System.Windows.Forms.GroupBox();
            this.formularioGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addCpfTxtmsk
            // 
            this.addCpfTxtmsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCpfTxtmsk.Location = new System.Drawing.Point(90, 161);
            this.addCpfTxtmsk.Mask = "00000000000";
            this.addCpfTxtmsk.Name = "addCpfTxtmsk";
            this.addCpfTxtmsk.Size = new System.Drawing.Size(112, 21);
            this.addCpfTxtmsk.TabIndex = 4;
            // 
            // cpfClientelbl
            // 
            this.cpfClientelbl.AutoSize = true;
            this.cpfClientelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfClientelbl.Location = new System.Drawing.Point(17, 161);
            this.cpfClientelbl.Name = "cpfClientelbl";
            this.cpfClientelbl.Size = new System.Drawing.Size(38, 17);
            this.cpfClientelbl.TabIndex = 22;
            this.cpfClientelbl.Text = "CPF:";
            // 
            // addClientBtn
            // 
            this.addClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientBtn.Location = new System.Drawing.Point(609, 194);
            this.addClientBtn.Name = "addClientBtn";
            this.addClientBtn.Size = new System.Drawing.Size(147, 36);
            this.addClientBtn.TabIndex = 5;
            this.addClientBtn.Text = "Confirmar";
            this.addClientBtn.UseVisualStyleBackColor = true;
            this.addClientBtn.Click += new System.EventHandler(this.addClientBtn_Click);
            // 
            // addClientEmail
            // 
            this.addClientEmail.Location = new System.Drawing.Point(350, 106);
            this.addClientEmail.Name = "addClientEmail";
            this.addClientEmail.Size = new System.Drawing.Size(406, 21);
            this.addClientEmail.TabIndex = 3;
            // 
            // AddTelmkTxt
            // 
            this.AddTelmkTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTelmkTxt.Location = new System.Drawing.Point(90, 104);
            this.AddTelmkTxt.Mask = "(00)00000-0000";
            this.AddTelmkTxt.Name = "AddTelmkTxt";
            this.AddTelmkTxt.Size = new System.Drawing.Size(112, 21);
            this.AddTelmkTxt.TabIndex = 2;
            // 
            // addClientName
            // 
            this.addClientName.Location = new System.Drawing.Point(87, 48);
            this.addClientName.Name = "addClientName";
            this.addClientName.Size = new System.Drawing.Size(574, 21);
            this.addClientName.TabIndex = 1;
            // 
            // clientEmail
            // 
            this.clientEmail.AutoSize = true;
            this.clientEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientEmail.Location = new System.Drawing.Point(275, 108);
            this.clientEmail.Name = "clientEmail";
            this.clientEmail.Size = new System.Drawing.Size(51, 17);
            this.clientEmail.TabIndex = 17;
            this.clientEmail.Text = "E-mail:";
            // 
            // clientTel
            // 
            this.clientTel.AutoSize = true;
            this.clientTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientTel.Location = new System.Drawing.Point(16, 107);
            this.clientTel.Name = "clientTel";
            this.clientTel.Size = new System.Drawing.Size(68, 17);
            this.clientTel.TabIndex = 16;
            this.clientTel.Text = "Telefone:";
            // 
            // clientName
            // 
            this.clientName.AutoSize = true;
            this.clientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientName.Location = new System.Drawing.Point(16, 49);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(49, 17);
            this.clientName.TabIndex = 15;
            this.clientName.Text = "Nome:";
            // 
            // nvClientlbl
            // 
            this.nvClientlbl.AutoSize = true;
            this.nvClientlbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.nvClientlbl.Location = new System.Drawing.Point(12, 28);
            this.nvClientlbl.Name = "nvClientlbl";
            this.nvClientlbl.Size = new System.Drawing.Size(300, 26);
            this.nvClientlbl.TabIndex = 14;
            this.nvClientlbl.Text = "Preencha os campos abaixo:";
            // 
            // formularioGroupBox
            // 
            this.formularioGroupBox.Controls.Add(this.addClientBtn);
            this.formularioGroupBox.Controls.Add(this.addCpfTxtmsk);
            this.formularioGroupBox.Controls.Add(this.addClientName);
            this.formularioGroupBox.Controls.Add(this.cpfClientelbl);
            this.formularioGroupBox.Controls.Add(this.clientName);
            this.formularioGroupBox.Controls.Add(this.clientTel);
            this.formularioGroupBox.Controls.Add(this.addClientEmail);
            this.formularioGroupBox.Controls.Add(this.clientEmail);
            this.formularioGroupBox.Controls.Add(this.AddTelmkTxt);
            this.formularioGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formularioGroupBox.Location = new System.Drawing.Point(32, 85);
            this.formularioGroupBox.Name = "formularioGroupBox";
            this.formularioGroupBox.Size = new System.Drawing.Size(901, 268);
            this.formularioGroupBox.TabIndex = 24;
            this.formularioGroupBox.TabStop = false;
            // 
            // FormularioCliente
            // 
            this.AcceptButton = this.addClientBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 438);
            this.Controls.Add(this.nvClientlbl);
            this.Controls.Add(this.formularioGroupBox);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FormularioCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioCliente";
            this.TopMost = true;
            this.formularioGroupBox.ResumeLayout(false);
            this.formularioGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox addCpfTxtmsk;
        private System.Windows.Forms.Label cpfClientelbl;
        private System.Windows.Forms.Button addClientBtn;
        private System.Windows.Forms.TextBox addClientEmail;
        private System.Windows.Forms.MaskedTextBox AddTelmkTxt;
        private System.Windows.Forms.TextBox addClientName;
        private System.Windows.Forms.Label clientEmail;
        private System.Windows.Forms.Label clientTel;
        private System.Windows.Forms.Label clientName;
        private System.Windows.Forms.Label nvClientlbl;
        private System.Windows.Forms.GroupBox formularioGroupBox;
    }
}