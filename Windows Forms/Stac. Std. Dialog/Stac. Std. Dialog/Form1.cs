using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stac.Std.Dialog
{
    public partial class Dialog : Form
    {
        public Dialog()
        {
            InitializeComponent();
        }

        private void Dialog_Load(object sender, EventArgs e)
        {
            btnColor.FlatAppearance.BorderSize = 0;
            btnColor.FlatStyle = FlatStyle.Flat;
            
            btnFont.FlatAppearance.BorderSize = 0;
            btnFont.FlatStyle = FlatStyle.Flat;

            btnOpen.FlatAppearance.BorderSize = 0;
            btnOpen.FlatStyle = FlatStyle.Flat;

            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (cdColor.ShowDialog() == DialogResult.OK)
            {
                rtbText.SelectionColor = cdColor.Color;
            }
            //ColorDialog dlgColor = new ColorDialog();
            //if (dlgColor.ShowDialog() == DialogResult.OK)
            //{

            //}
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbText.SelectionFont = fontDialog1.Font;
                rtbText.SelectionColor = fontDialog1.Color;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Txt files(*.txt)|*.txt|Rich files(*rtf)|*.rtf|All files(*.*)|*.*||";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string pathFile = openFileDialog1.FileName;
                switch (Path.GetExtension(pathFile))
                {
                    case ".txt":
                        rtbText.LoadFile(pathFile, RichTextBoxStreamType.RichText);
                        break;
                    case ".rtf":
                        if (Path.GetExtension(pathFile) == ".rtf")
                        {
                            rtbText.LoadFile(File.ReadAllText(pathFile));
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Txt files(*.txt)|*.txt|Rich files(*rtf)|*.rtf|All files(*.*)|*.*||";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string pathFile = saveFileDialog1.FileName;
                switch (Path.GetExtension(pathFile))
                {
                    case ".txt":
                        File.WriteAllText(pathFile, rtbText.Text);
                        break;
                    case ".rtf":
                        rtbText.SaveFile(pathFile, RichTextBoxStreamType.RichText);
                        break;
                    default:
                        break;
                }
            }
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbText.Clear();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbText.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbText.CanPaste(DataFormats.GetFormat(DataFormats.Rtf)))
            rtbText.Paste();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copyToolStripMenuItem_Click(null, null);
        }

        private void вставкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pasteToolStripMenuItem_Click(null, null);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (rtbText.SelectionFont.Italic)
            {
                rtbText.SelectionFont = new Font(rtbText.SelectionFont, rtbText.SelectionFont.Style & (~FontStyle.Italic));
            }
            else
            {
                rtbText.SelectionFont = new Font(rtbText.SelectionFont, rtbText.SelectionFont.Style | FontStyle.Italic);
            }
        }
    }
}
