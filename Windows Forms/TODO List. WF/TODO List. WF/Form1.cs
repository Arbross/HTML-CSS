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
using System.Xml.Serialization;

namespace TODO_List._WF
{
    public partial class Form1 : Form
    {
        [XmlArrayItem("TODO")]
        private List<TODO> isTODO;
        public CheckBox priority = new CheckBox();
        private string name;
        private string placeOn;
        private DateTime date;
        public Form1()
        {
            InitializeComponent();
            isTODO = new List<TODO>();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isTODO.Add(new TODO(priority, name, placeOn, date));
            lbTODO.Items.Add(new TODO(priority, name, placeOn, date));
        }
        private void isUpdate()
        {
            foreach (CheckBox check in gbPriority.Controls)
            {
                if (check.Checked)
                {
                    priority = check;
                }
            }
        }
        private void cbHigh_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            if (check.Checked)
            {
                isUpdate();
            }
        }
        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (!(tbName.Text == String.Empty))
            {
                name = tbName.Text;
            }
            else
            {
                name = "Noname";
            }
        }
        private void mcDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (mcDate.SelectionRange.Start > mcDate.TodayDate)
            {
                date = mcDate.SelectionRange.Start;
            }
            else
            {
                MessageBox.Show("You can't plan past. ;D", "Days error exception", MessageBoxButtons.OK);
            }
        }
        private void tbPlaceOn_TextChanged(object sender, EventArgs e)
        {
            if (tbPlaceOn.Text != String.Empty)
            {
                placeOn = tbPlaceOn.Text;
            }
            else
            {
                placeOn = "Noplace";
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lbTODO.Items.Clear();
        }

        private void btnClearSelected_Click(object sender, EventArgs e)
        {
            for (int i = lbTODO.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lbTODO.Items.RemoveAt(lbTODO.SelectedIndices[i]);
            }
        }

        private void btnFindByName_Click(object sender, EventArgs e)
        {
            int counter = 0;
            foreach (TODO item in lbTODO.Items)
            {
                if (item.Name == tbName.Text)
                {
                    lbTODO.SetSelected(counter, true);
                    break;
                }
                ++counter;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbTODO.SelectedIndex == -1)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK);
            }
            else
            {
                lbTODO.Items[lbTODO.SelectedIndex] = new TODO(priority, name, placeOn, date);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<TODO>));
            using (TextWriter tw = new StreamWriter("Result.dat"))
            {
                xs.Serialize(tw, isTODO);
            }
            //using (TextReader tr = new StreamReader("test.dat"))
            //{
            //    TODO result = (TODO)xs.Deserialize(tr);
            //    Console.WriteLine($"Recovered song {result}");
            //}
        }
    }
}
