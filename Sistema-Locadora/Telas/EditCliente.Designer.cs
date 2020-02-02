namespace Sistema_Locadora.Telas
{
    partial class EditCliente
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
            this.editGroupBox = new System.Windows.Forms.GroupBox();
            this.editClientBtn = new System.Windows.Forms.Button();
            this.editCpfTxtmsk = new System.Windows.Forms.MaskedTextBox();
            this.editClientName = new System.Windows.Forms.TextBox();
            this.cpfClientelbl = new System.Windows.Forms.Label();
            this.clientName = new System.Windows.Forms.Label();
            this.clientTel = new System.Windows.Forms.Label();
            this.editClientEmail = new System.Windows.Forms.TextBox();
            this.clientEmail = new System.Windows.Forms.Label();
            this.editTelmkTxt = new System.Windows.Forms.MaskedTextBox();
            this.editGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // editGroupBox
            // 
            this.editGroupBox.Controls.Add(this.editClientBtn);
            this.editGroupBox.Controls.Add(this.editCpfTxtmsk);
            this.editGroupBox.Controls.Add(this.editClientName);
            this.editGroupBox.Controls.Add(this.cpfClientelbl);
            this.editGroupBox.Controls.Add(this.clientName);
            this.editGroupBox.Controls.Add(this.clientTel);
            this.editGroupBox.Controls.Add(this.editClientEmail);
            this.editGroupBox.Controls.Add(this.clientEmail);
            this.editGroupBox.Controls.Add(this.editTelmkTxt);
            this.editGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editGroupBox.Location = new System.Drawing.Point(31, 36);
            this.editGroupBox.Name = "editGroupBox";
            this.editGroupBox.Size = new System.Drawing.Size(853, 265);
            this.editGroupBox.TabIndex = 25;
            this.editGroupBox.TabStop = false;
            // 
            // editClientBtn
            // 
            this.editClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editClientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editClientBtn.Location = new System.Drawing.Point(609, 194);
            this.editClientBtn.Name = "editClientBtn";
            this.editClientBtn.Size = new System.Drawing.Size(147, 36);
            this.editClientBtn.TabIndex = 5;
            this.editClientBtn.Text = "Confirmar";
            this.editClientBtn.UseVisualStyleBackColor = true;
            this.editClientBtn.Click += new System.EventHandler(this.editClientBtn_Click);
            // 
            // editCpfTxtmsk
            // 
            this.editCpfTxtmsk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCpfTxtmsk.Location = new System.Drawing.Point(90, 161);
            this.editCpfTxtmsk.Mask = "00000000000";
            this.editCpfTxtmsk.Name = "editCpfTxtmsk";
            this.editCpfTxtmsk.Size = new System.Drawing.Size(112, 21);
            this.editCpfTxtmsk.TabIndex = 4;
            // 
            // editClientName
            // 
            this.editClientName.Location = new System.Drawing.Point(87, 48);
            this.editClientName.Name = "editClientName";
            this.editClientName.Size = new System.Drawing.Size(574, 20);
            this.editClientName.TabIndex = 1;
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
            // editClientEmail
            // 
            this.editClientEmail.Location = new System.Drawing.Point(350, 106);
            this.editClientEmail.Name = "editClientEmail";
            this.editClientEmail.Size = new System.Drawing.Size(406, 20);
            this.editClientEmail.TabIndex = 3;
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
            // editTelmkTxt
            // 
            this.editTelmkTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTelmkTxt.Location = new System.Drawing.Point(90, 104);
            this.editTelmkTxt.Mask = "(00)00000-0000";
            this.editTelmkTxt.Name = "editTelmkTxt";
            this.editTelmkTxt.Size = new System.Drawing.Size(112, 21);
            this.editTelmkTxt.TabIndex = 2;
            // 
            // EditCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 338);
            this.Controls.Add(this.editGroupBox);
            this.MaximizeBox = false;
            this.Name = "EditCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCliente";
            this.Load += new System.EventHandler(this.EditCliente_Load);
            this.editGroupBox.ResumeLayout(false);
            this.editGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox editGroupBox;
        private System.Windows.Forms.Button editClientBtn;
        private System.Windows.Forms.MaskedTextBox editCpfTxtmsk;
        private System.Windows.Forms.TextBox editClientName;
        private System.Windows.Forms.Label cpfClientelbl;
        private System.Windows.Forms.Label clientName;
        private System.Windows.Forms.Label clientTel;
        private System.Windows.Forms.TextBox editClientEmail;
        private System.Windows.Forms.Label clientEmail;
        private System.Windows.Forms.MaskedTextBox editTelmkTxt;
    }
}