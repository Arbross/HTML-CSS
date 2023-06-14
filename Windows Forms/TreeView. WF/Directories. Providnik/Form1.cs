using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Directories._Providnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var drives = DriveInfo.GetDrives();
            foreach (var d in drives)
            {
                tvRoot.Nodes.Add(d.Name);
                foreach (var node in drives)
                {
                    DirectoryInfo directoryInfoDirectories = new DirectoryInfo(d.Name);
                    foreach (var dirs in directoryInfoDirectories.GetDirectories())
                    {
                        tvRoot.Nodes.Add(new TreeNode(dirs.FullName, 0, 0));
                    }
                    DirectoryInfo directoryInfoFiles = new DirectoryInfo(d.Name);
                    foreach (var dirs in directoryInfoFiles.GetFiles())
                    {
                        tvRoot.Nodes.Add(new TreeNode(dirs.Name, 1, 1));
                    }
                }
            }
        }

        private void tvRoot_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lvView.Clear();
            DirectoryInfo dir = new DirectoryInfo(e.Node.FullPath);
            foreach (DirectoryInfo item in dir.GetDirectories())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.FullName;
                listViewItem.ImageIndex = 0;
                lvView.Items.Add(listViewItem);
                
            }
            DirectoryInfo files = new DirectoryInfo(e.Node.FullPath);
            foreach (var dirs in files.GetFiles())
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Name = dirs.FullName;
                listViewItem.ImageIndex = 1;
                lvView.Items.Add(listViewItem);
            }
        }

        private void lvView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < lvView.SelectedIndices[0]; i++)
            {
                // lvView.Items[i].
            }
        }
    }
}
