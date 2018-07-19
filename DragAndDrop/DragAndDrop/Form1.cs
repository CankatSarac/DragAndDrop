using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {//1
            AllowDrop = true;
        }

        private void pictureBoxKuala_MouseDown(object sender, MouseEventArgs e)
        {//2
            pictureBoxKuala.DoDragDrop(pictureBoxKuala, DragDropEffects.Move);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {//3
            e.Effect = DragDropEffects.Move;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {//4
        //    string gelendata = e.Data.GetData(DataFormats.StringFormat).ToString();
           object  gelendata = e.Data.GetData(typeof(PictureBox));
           // if (gelendata == "kuala")
           
            {
                pictureBoxKuala.Left = e.X - pictureBoxKuala.Width / 2;
                pictureBoxKuala.Top = e.Y - pictureBoxKuala.Height / 2;
            }
        }
    }
}
