namespace DragAndDropFormlarArasi
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
            this.lstBoxGonderen = new System.Windows.Forms.ListBox();
            this.lstBoxAlan = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstBoxGonderen
            // 
            this.lstBoxGonderen.FormattingEnabled = true;
            this.lstBoxGonderen.ItemHeight = 16;
            this.lstBoxGonderen.Location = new System.Drawing.Point(23, 26);
            this.lstBoxGonderen.Name = "lstBoxGonderen";
            this.lstBoxGonderen.Size = new System.Drawing.Size(170, 228);
            this.lstBoxGonderen.TabIndex = 0;
            this.lstBoxGonderen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstBoxGonderen_MouseDown);
            // 
            // lstBoxAlan
            // 
            this.lstBoxAlan.FormattingEnabled = true;
            this.lstBoxAlan.ItemHeight = 16;
            this.lstBoxAlan.Location = new System.Drawing.Point(229, 26);
            this.lstBoxAlan.Name = "lstBoxAlan";
            this.lstBoxAlan.Size = new System.Drawing.Size(170, 228);
            this.lstBoxAlan.TabIndex = 1;
            this.lstBoxAlan.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstBoxAlan_DragDrop);
            this.lstBoxAlan.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstBoxAlan_DragEnter);
            this.lstBoxAlan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstBoxAlan_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 432);
            this.Controls.Add(this.lstBoxAlan);
            this.Controls.Add(this.lstBoxGonderen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxGonderen;
        private System.Windows.Forms.ListBox lstBoxAlan;
    }
}

