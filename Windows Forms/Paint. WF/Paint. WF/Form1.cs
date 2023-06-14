using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint._WF
{
    public partial class Paint : Form
    {
        private int size = 10;
        private Color color = Color.Transparent;
        Rectangle rect = Rectangle.Empty;
        private Image img = null;
        Point end_point = new Point();
        private Point point = Point.Empty;
        bool IsMouseDown = false;
        public int NSize
        {
            get => size;
            set => size = value;
        }
        public Paint()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Clear.FlatAppearance.BorderSize = 0;
            Clear.FlatStyle = FlatStyle.Flat;

            btnRectangle.FlatAppearance.BorderSize = 0;
            btnRectangle.FlatStyle = FlatStyle.Flat;

            // Full screen
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Closing form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        private void Red_Click(object sender, EventArgs e)
        {
            color = Red.BackColor;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label lbl = new Label();
                if (color != Color.Transparent)
                {
                    lbl.Size = new Size(NSize, NSize);
                    lbl.BackColor = color;
                    lbl.Location = e.Location;
                    panel2.Controls.Add(lbl);
                }
            }
            if (IsMouseDown)
            {
                end_point = e.Location;
                this.Refresh();
            }
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (rect != Rectangle.Empty)
            {
                IsMouseDown = true;
                point = e.Location;
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (rect != Rectangle.Empty)
            {
                if (IsMouseDown)
                {
                    point = e.Location;
                    IsMouseDown = false;
                }
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Red, 5), Modificate());
        }
        private Rectangle Modificate()
        {
            rect = new Rectangle();
            rect.X = Math.Min(point.X, end_point.X);
            rect.Y = Math.Min(point.Y, end_point.Y);
            rect.Width = Math.Abs(point.X - end_point.X);
            rect.Height = Math.Abs(point.Y - end_point.Y);
            return rect;
        }
        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            if (img != null)
            {
                PictureBox image = new PictureBox();
                color = Color.Transparent;
                rect = Rectangle.Empty;
                image.BackgroundImage = img;
                image.BackColor = Color.Transparent;
                image.BackgroundImageLayout = ImageLayout.Zoom;
                image.Location = e.Location;
                panel2.Controls.Add(image);
            }
        }
        private void Gold_Click(object sender, EventArgs e)
        {
            color = Color.Gold;
            img = null;
            rect = Rectangle.Empty;
        }
        private void Green_Click(object sender, EventArgs e)
        {
            color = Color.Green;
            img = null;
            rect = Rectangle.Empty;
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            color = Color.Blue;
            img = null;
            rect = Rectangle.Empty;
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Graphics g = panel2.CreateGraphics();
            g.Clear(Color.White);
            end_point = Point.Empty;
            point = Point.Empty;
            rect = Rectangle.Empty;
            color = Color.Transparent;
            img = null;
        }
        private void NNSize_TextChanged(object sender, EventArgs e)
        {
            NSize = int.Parse(NNSize.Text); 
        }

        private void pbCastle_Click(object sender, EventArgs e)
        {
            color = Color.Transparent;
            point = Point.Empty;
            end_point = Point.Empty;
            rect = Rectangle.Empty;
            img = Image.FromFile("../../../castle.png");
        }

        private void pbSkyscraper_Click(object sender, EventArgs e)
        {
            rect = Rectangle.Empty;
            point = Point.Empty;
            end_point = Point.Empty;
            color = Color.Transparent;
            img = Image.FromFile("../../../skyscraper.png");
        }

        private void pbFarm_Click(object sender, EventArgs e)
        {
            color = Color.Transparent;
            point = Point.Empty;
            end_point = Point.Empty;
            rect = Rectangle.Empty;
            img = Image.FromFile("../../../farm.png");
        }

        private void pbGoverment_Click(object sender, EventArgs e)
        {
            color = Color.Transparent;
            point = Point.Empty;
            end_point = Point.Empty;
            rect = Rectangle.Empty;
            img = Image.FromFile("../../../goverment.png");
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            color = Color.Transparent;
            img = null;
            rect = new Rectangle(1, 1, 1, 1);
        }
    }
}
