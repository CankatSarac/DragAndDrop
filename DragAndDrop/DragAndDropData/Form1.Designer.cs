namespace DragAndDropData
{
    partial class Form1
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
            this.listBoxGonderen = new System.Windows.Forms.ListBox();
            this.listBoxAlan = new System.Windows.Forms.ListBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.textBoxIsim = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxGonderen
            // 
            this.listBoxGonderen.FormattingEnabled = true;
            this.listBoxGonderen.ItemHeight = 16;
            this.listBoxGonderen.Location = new System.Drawing.Point(13, 26);
            this.listBoxGonderen.Name = "listBoxGonderen";
            this.listBoxGonderen.Size = new System.Drawing.Size(164, 212);
            this.listBoxGonderen.TabIndex = 0;
            this.listBoxGonderen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxGonderen_MouseDown);
            // 
            // listBoxAlan
            // 
            this.listBoxAlan.FormattingEnabled = true;
            this.listBoxAlan.ItemHeight = 16;
            this.listBoxAlan.Location = new System.Drawing.Point(210, 26);
            this.listBoxAlan.Name = "listBoxAlan";
            this.listBoxAlan.Size = new System.Drawing.Size(160, 212);
            this.listBoxAlan.TabIndex = 1;
            this.listBoxAlan.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxAlan_DragDrop);
            this.listBoxAlan.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxAlan_DragEnter);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(13, 282);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(125, 32);
            this.buttonEkle.TabIndex = 2;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // textBoxIsim
            // 
            this.textBoxIsim.Location = new System.Drawing.Point(13, 344);
            this.textBoxIsim.Name = "textBoxIsim";
            this.textBoxIsim.Size = new System.Drawing.Size(138, 22);
            this.textBoxIsim.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 449);
            this.Controls.Add(this.textBoxIsim);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.listBoxAlan);
            this.Controls.Add(this.listBoxGonderen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGonderen;
        private System.Windows.Forms.ListBox listBoxAlan;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.TextBox textBoxIsim;
    }
}

