using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox._LinkedLabel._WF
{
    /*Rivne
Kiev
Odessa
Lviv*/
    public partial class Pictures : Form
    {
        private List<Town> towns;
        public Pictures()
        {
            InitializeComponent();

            // btnUp
            btnUp.FlatAppearance.BorderSize = 0;
            btnUp.FlatStyle = FlatStyle.Flat;

            // btnDown
            btnDown.FlatAppearance.BorderSize = 0;
            btnDown.FlatStyle = FlatStyle.Flat;

            lblShow.Text = "";
            towns = new List<Town>();

            List<string> rivne = new List<string>();
            rivne.Add("../../../Images/rivne.jpg");
            rivne.Add("../../../Images/rivne_1.jpg");
            rivne.Add("../../../Images/rivne_2.jpg");
            towns.Add(new Town("Rivne", "https://uk.wikipedia.org/wiki/%D0%A0%D1%96%D0%B2%D0%BD%D0%B5", rivne));

            List<string> kiev = new List<string>();
            kiev.Add("../../../Images/kiev.jpg");
            kiev.Add("../../../Images/kiev_1.jpg");
            kiev.Add("../../../Images/kiev_2.jpg");
            towns.Add(new Town("Kiev", "https://uk.wikipedia.org/wiki/%D0%9A%D0%B8%D1%97%D0%B2", kiev));

            List<string> odessa = new List<string>();
            odessa.Add("../../../Images/odessa.jpg");
            odessa.Add("../../../Images/odessa_1.jpg");
            odessa.Add("../../../Images/odessa_2.jpg");
            towns.Add(new Town("Odessa", "https://uk.wikipedia.org/wiki/%D0%9E%D0%B4%D0%B5%D1%81%D0%B0", odessa));

            List<string> lviv = new List<string>();
            lviv.Add("../../../Images/lviv.jpg");
            lviv.Add("../../../Images/lviv_1.jpeg");
            lviv.Add("../../../Images/lviv_2.jpg");
            towns.Add(new Town("Lviv", "https://uk.wikipedia.org/wiki/%D0%9B%D1%8C%D0%B2%D1%96%D0%B2", lviv));
        }

        private void cbTowns_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (Town town in towns)
            {
                if (cbTowns.SelectedItem.ToString() == town.Name)
                {
                    pbImage.BackgroundImage = Image.FromFile($"{town.Photo_Paths[town.photo_counter]}");
                    llLink.Text = town.Ethernet_Path;
                    town.views++;
                    lblShow.Text = $"Town : {town.Name}, views : {town.views}";
                }
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            foreach (Town town in towns)
            {
                if (cbTowns.SelectedItem.ToString() == town.Name)
                {
                    if (town.photo_counter != town.Photo_Paths.Count - 1)
                    {
                        town.photo_counter++;
                        pbImage.BackgroundImage = Image.FromFile($"{town.Photo_Paths[town.photo_counter]}");
                    }
                }
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            foreach (Town town in towns)
            {
                if (cbTowns.SelectedItem.ToString() == town.Name)
                {
                    if (town.photo_counter != 0)
                    {
                        town.photo_counter--;
                        pbImage.BackgroundImage = Image.FromFile($"{town.Photo_Paths[town.photo_counter]}");
                    }
                }
            }
        }

        private void llLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Town town in towns)
            {
                if (cbTowns.SelectedItem.ToString() == town.Name)
                {
                    System.Diagnostics.Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", town.Ethernet_Path);
                }
            }
        }
    }
}
