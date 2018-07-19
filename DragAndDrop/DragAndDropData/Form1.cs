using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDropData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            listBoxGonderen.Items.Add(textBoxIsim.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        { //1
            listBoxAlan.AllowDrop = true;
        }

        private void listBoxGonderen_MouseDown(object sender, MouseEventArgs e)
        { //2
            listBoxGonderen.DoDragDrop(listBoxGonderen.SelectedItem, DragDropEffects.Move);
        }

        private void listBoxAlan_DragEnter(object sender, DragEventArgs e)
        {//3
            e.Effect = DragDropEffects.Move;
        }

        private void listBoxAlan_DragDrop(object sender, DragEventArgs e)
        {//4
            listBoxAlan.Items.Add(e.Data.GetData(DataFormats.StringFormat));
            listBoxGonderen.Items.Remove(e.Data.GetData(DataFormats.StringFormat));
           
        }

    }
}
