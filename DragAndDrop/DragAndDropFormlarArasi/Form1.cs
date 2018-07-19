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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstBoxGonderen.Items.Add("Şamil");
            lstBoxGonderen.Items.Add("Burcu");
            lstBoxGonderen.Items.Add("Özge");
            lstBoxGonderen.Items.Add("Miktat");
            lstBoxGonderen.Items.Add("Tunç");
            //A1

            lstBoxAlan.AllowDrop = true;
        }
        private void lstBoxGonderen_MouseDown(object sender, MouseEventArgs e)
        {
            { //A2
                lstBoxGonderen.DoDragDrop(lstBoxGonderen.SelectedItem, DragDropEffects.Move);
            }
        }

        private void lstBoxAlan_DragEnter(object sender, DragEventArgs e)
        {
            //A3
            e.Effect = DragDropEffects.Move;
        }

        private void lstBoxAlan_DragDrop(object sender, DragEventArgs e)
        {
            //A4
            lstBoxAlan.Items.Add(e.Data.GetData(DataFormats.StringFormat));
            lstBoxGonderen.Items.Remove(e.Data.GetData(DataFormats.StringFormat));
        }

        private void lstBoxAlan_MouseDown(object sender, MouseEventArgs e)
        {// B2
            lstBoxAlan.DoDragDrop(lstBoxAlan, DragDropEffects.Move);
        }

    }
}
