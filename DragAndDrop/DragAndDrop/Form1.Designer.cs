namespace DragAndDrop
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
            this.pictureBoxKuala = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKuala)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxKuala
            // 
            this.pictureBoxKuala.Image = global::DragAndDrop.Properties.Resources.kuala;
            this.pictureBoxKuala.Location = new System.Drawing.Point(37, 33);
            this.pictureBoxKuala.Name = "pictureBoxKuala";
            this.pictureBoxKuala.Size = new System.Drawing.Size(231, 263);
            this.pictureBoxKuala.TabIndex = 0;
            this.pictureBoxKuala.TabStop = false;
            this.pictureBoxKuala.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxKuala_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 513);
            this.Controls.Add(this.pictureBoxKuala);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKuala)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxKuala;
    }
}

