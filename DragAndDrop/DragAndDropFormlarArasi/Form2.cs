using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDropFormlarArasi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void Form2_DragEnter(object sender, DragEventArgs e)
        {//B3
          //  this.AllowDrop = true;
            e.Effect = DragDropEffects.Move;
        }

        private void Form2_DragDrop(object sender, DragEventArgs e)
        {//B4

            object gelenData = null;
            if (e.Data.GetData(typeof(ListBox)) is ListBox)
            {
                gelenData = e.Data.GetData(typeof(ListBox));
            }
            else if (e.Data.GetData(typeof(string)) is string)
            {
                gelenData = e.Data.GetData(typeof(string));
            }

            //gelenData = gelenData ?? e.Data.GetData(typeof(ListBox));
            //gelenData = gelenData ?? e.Data.GetData(typeof(string));
            if (gelenData is ListBox)
            {
                ListBox lst = (ListBox)gelenData;
                lst.Left = 0;
                lst.Top = 0;
                Controls.Add(lst);
            }
        }
    }
}
