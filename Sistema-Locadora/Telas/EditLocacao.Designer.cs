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
            this.editLocGroupBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // editLocGroupBox
            // 
            this.editLocGroupBox.Location = new System.Drawing.Point(38, 25);
            this.editLocGroupBox.Name = "editLocGroupBox";
            this.editLocGroupBox.Size = new System.Drawing.Size(834, 285);
            this.editLocGroupBox.TabIndex = 0;
            this.editLocGroupBox.TabStop = false;
            // 
            // EditLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 338);
            this.Controls.Add(this.editLocGroupBox);
            this.Name = "EditLocacao";
            this.Text = "EditLocacao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox editLocGroupBox;
    }
}