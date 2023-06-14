
namespace PictureBox._LinkedLabel._WF
{
    partial class Pictures
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.llLink = new System.Windows.Forms.LinkLabel();
            this.cbTowns = new System.Windows.Forms.ComboBox();
            this.lblShow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImage.Location = new System.Drawing.Point(175, 57);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(441, 323);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Transparent;
            this.btnUp.BackgroundImage = global::PictureBox._LinkedLabel._WF.Images.Arrows.Arrow;
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUp.ForeColor = System.Drawing.Color.Transparent;
            this.btnUp.Location = new System.Drawing.Point(622, 206);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(109, 57);
            this.btnUp.TabIndex = 1;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.Transparent;
            this.btnDown.BackgroundImage = global::PictureBox._LinkedLabel._WF.Images.Arrows.Arrow_1;
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDown.Location = new System.Drawing.Point(31, 206);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(138, 57);
            this.btnDown.TabIndex = 2;
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // llLink
            // 
            this.llLink.Location = new System.Drawing.Point(175, 383);
            this.llLink.Name = "llLink";
            this.llLink.Size = new System.Drawing.Size(441, 23);
            this.llLink.TabIndex = 3;
            this.llLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llLink_LinkClicked);
            // 
            // cbTowns
            // 
            this.cbTowns.FormattingEnabled = true;
            this.cbTowns.Items.AddRange(new object[] {
            "Rivne",
            "Kiev",
            "Odessa",
            "Lviv"});
            this.cbTowns.Location = new System.Drawing.Point(335, 419);
            this.cbTowns.Name = "cbTowns";
            this.cbTowns.Size = new System.Drawing.Size(121, 23);
            this.cbTowns.TabIndex = 4;
            this.cbTowns.SelectionChangeCommitted += new System.EventHandler(this.cbTowns_SelectionChangeCommitted);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShow.Location = new System.Drawing.Point(299, 9);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(63, 25);
            this.lblShow.TabIndex = 5;
            this.lblShow.Text = "label1";
            // 
            // Pictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.cbTowns);
            this.Controls.Add(this.llLink);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.pbImage);
            this.Name = "Pictures";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.LinkLabel llLink;
        private System.Windows.Forms.ComboBox cbTowns;
        private System.Windows.Forms.Label lblShow;
    }
}

