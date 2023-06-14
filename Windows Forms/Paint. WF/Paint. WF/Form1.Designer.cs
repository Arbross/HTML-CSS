
namespace Paint._WF
{
    partial class Paint
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Red = new System.Windows.Forms.Label();
            this.Gold = new System.Windows.Forms.Label();
            this.Green = new System.Windows.Forms.Label();
            this.Blue = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.NNSize = new System.Windows.Forms.TextBox();
            this.pbCastle = new System.Windows.Forms.PictureBox();
            this.pbSkyscraper = new System.Windows.Forms.PictureBox();
            this.pbGoverment = new System.Windows.Forms.PictureBox();
            this.pbFarm = new System.Windows.Forms.PictureBox();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCastle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkyscraper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoverment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFarm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(190, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1702, 1017);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1702, 1017);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(165, -54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 1401);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(180, -8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1739, 17);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(180, 1032);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1739, 58);
            this.label3.TabIndex = 3;
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(13, 13);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(50, 50);
            this.Red.TabIndex = 4;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Gold
            // 
            this.Gold.BackColor = System.Drawing.Color.Gold;
            this.Gold.Location = new System.Drawing.Point(90, 13);
            this.Gold.Name = "Gold";
            this.Gold.Size = new System.Drawing.Size(50, 50);
            this.Gold.TabIndex = 5;
            this.Gold.Click += new System.EventHandler(this.Gold_Click);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Green;
            this.Green.Location = new System.Drawing.Point(13, 77);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(50, 50);
            this.Green.TabIndex = 6;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.Location = new System.Drawing.Point(90, 77);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(50, 50);
            this.Blue.TabIndex = 7;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(13, 131);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(127, 64);
            this.Clear.TabIndex = 8;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // NNSize
            // 
            this.NNSize.Location = new System.Drawing.Point(12, 201);
            this.NNSize.Name = "NNSize";
            this.NNSize.Size = new System.Drawing.Size(128, 23);
            this.NNSize.TabIndex = 9;
            this.NNSize.TextChanged += new System.EventHandler(this.NNSize_TextChanged);
            // 
            // pbCastle
            // 
            this.pbCastle.BackColor = System.Drawing.Color.Transparent;
            this.pbCastle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCastle.BackgroundImage")));
            this.pbCastle.Image = ((System.Drawing.Image)(resources.GetObject("pbCastle.Image")));
            this.pbCastle.Location = new System.Drawing.Point(13, 230);
            this.pbCastle.Name = "pbCastle";
            this.pbCastle.Size = new System.Drawing.Size(51, 51);
            this.pbCastle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCastle.TabIndex = 11;
            this.pbCastle.TabStop = false;
            this.pbCastle.Click += new System.EventHandler(this.pbCastle_Click);
            // 
            // pbSkyscraper
            // 
            this.pbSkyscraper.BackColor = System.Drawing.Color.Transparent;
            this.pbSkyscraper.Image = ((System.Drawing.Image)(resources.GetObject("pbSkyscraper.Image")));
            this.pbSkyscraper.Location = new System.Drawing.Point(89, 230);
            this.pbSkyscraper.Name = "pbSkyscraper";
            this.pbSkyscraper.Size = new System.Drawing.Size(51, 51);
            this.pbSkyscraper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSkyscraper.TabIndex = 12;
            this.pbSkyscraper.TabStop = false;
            this.pbSkyscraper.Click += new System.EventHandler(this.pbSkyscraper_Click);
            // 
            // pbGoverment
            // 
            this.pbGoverment.BackColor = System.Drawing.Color.Transparent;
            this.pbGoverment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbGoverment.BackgroundImage")));
            this.pbGoverment.Image = ((System.Drawing.Image)(resources.GetObject("pbGoverment.Image")));
            this.pbGoverment.Location = new System.Drawing.Point(89, 287);
            this.pbGoverment.Name = "pbGoverment";
            this.pbGoverment.Size = new System.Drawing.Size(51, 51);
            this.pbGoverment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGoverment.TabIndex = 16;
            this.pbGoverment.TabStop = false;
            this.pbGoverment.Click += new System.EventHandler(this.pbGoverment_Click);
            // 
            // pbFarm
            // 
            this.pbFarm.BackColor = System.Drawing.Color.Transparent;
            this.pbFarm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbFarm.BackgroundImage")));
            this.pbFarm.Image = ((System.Drawing.Image)(resources.GetObject("pbFarm.Image")));
            this.pbFarm.Location = new System.Drawing.Point(13, 287);
            this.pbFarm.Name = "pbFarm";
            this.pbFarm.Size = new System.Drawing.Size(51, 51);
            this.pbFarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFarm.TabIndex = 17;
            this.pbFarm.TabStop = false;
            this.pbFarm.Click += new System.EventHandler(this.pbFarm_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(12, 345);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(128, 46);
            this.btnRectangle.TabIndex = 18;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.pbFarm);
            this.Controls.Add(this.pbGoverment);
            this.Controls.Add(this.pbSkyscraper);
            this.Controls.Add(this.pbCastle);
            this.Controls.Add(this.NNSize);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Gold);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Paint";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCastle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSkyscraper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGoverment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFarm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Red;
        private System.Windows.Forms.Label Gold;
        private System.Windows.Forms.Label Green;
        private System.Windows.Forms.Label Blue;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.TextBox NNSize;
        private System.Windows.Forms.PictureBox pbCastle;
        private System.Windows.Forms.PictureBox pbSkyscraper;
        private System.Windows.Forms.PictureBox pbGoverment;
        private System.Windows.Forms.PictureBox pbFarm;
        private System.Windows.Forms.Button btnRectangle;
    }
}

