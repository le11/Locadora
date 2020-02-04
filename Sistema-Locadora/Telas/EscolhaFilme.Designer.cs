namespace Sistema_Locadora.Telas
{
    partial class EscolhaFilme
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
            this.label3 = new System.Windows.Forms.Label();
            this.escolhaTituloTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.escolhaFilmeDataGridView = new System.Windows.Forms.DataGridView();
            this.OKbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.escolhaFilmeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Titulo:";
            // 
            // escolhaTituloTextBox
            // 
            this.escolhaTituloTextBox.Location = new System.Drawing.Point(73, 18);
            this.escolhaTituloTextBox.Name = "escolhaTituloTextBox";
            this.escolhaTituloTextBox.Size = new System.Drawing.Size(233, 20);
            this.escolhaTituloTextBox.TabIndex = 88;
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = global::Sistema_Locadora.Properties.Resources.searching;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.Location = new System.Drawing.Point(315, 14);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(23, 26);
            this.searchButton.TabIndex = 90;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // escolhaFilmeDataGridView
            // 
            this.escolhaFilmeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.escolhaFilmeDataGridView.Location = new System.Drawing.Point(12, 55);
            this.escolhaFilmeDataGridView.Name = "escolhaFilmeDataGridView";
            this.escolhaFilmeDataGridView.Size = new System.Drawing.Size(648, 150);
            this.escolhaFilmeDataGridView.TabIndex = 91;
            // 
            // OKbutton
            // 
            this.OKbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKbutton.Location = new System.Drawing.Point(611, 210);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(43, 36);
            this.OKbutton.TabIndex = 92;
            this.OKbutton.Text = "OK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // EscolhaFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 249);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.escolhaFilmeDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.escolhaTituloTextBox);
            this.Name = "EscolhaFilme";
            this.Text = "EscolhaFilme";
            this.Load += new System.EventHandler(this.EscolhaFilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.escolhaFilmeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox escolhaTituloTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView escolhaFilmeDataGridView;
        private System.Windows.Forms.Button OKbutton;
    }
}