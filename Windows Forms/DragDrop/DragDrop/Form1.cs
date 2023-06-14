using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.AllowDrop = true;
            lbCollection.AllowDrop = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.DoDragDrop(pictureBox1.Image, DragDropEffects.Copy);
        }

        private void pictureBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) || e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                pictureBox2.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            }
            else if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                pictureBox2.ImageLocation = (e.Data.GetData(DataFormats.FileDrop) as string[])[lbCollection.SelectedIndex];
            }
        }

        private void tbPath_MouseDown(object sender, MouseEventArgs e)
        {
            tbPath.DoDragDrop(tbPath.Text, DragDropEffects.Copy);
        }

        private void lbCollection_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) || e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void lbCollection_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                lbCollection.Items.Add((string)e.Data.GetData(DataFormats.Text));
            }
            else if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                lbCollection.Items.Add((e.Data.GetData(DataFormats.FileDrop) as string[])[lbCollection.Items.Count - 1]);
            }
        }
    }
}
