
namespace Directories._Providnik
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tvRoot = new System.Windows.Forms.TreeView();
            this.ilImages = new System.Windows.Forms.ImageList(this.components);
            this.lvView = new System.Windows.Forms.ListView();
            this.FileName = new System.Windows.Forms.ColumnHeader();
            this.Size = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // tvRoot
            // 
            this.tvRoot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvRoot.ImageIndex = 0;
            this.tvRoot.ImageList = this.ilImages;
            this.tvRoot.Location = new System.Drawing.Point(12, 12);
            this.tvRoot.Name = "tvRoot";
            this.tvRoot.SelectedImageIndex = 0;
            this.tvRoot.Size = new System.Drawing.Size(180, 426);
            this.tvRoot.TabIndex = 0;
            this.tvRoot.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvRoot_AfterSelect);
            // 
            // ilImages
            // 
            this.ilImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilImages.ImageStream")));
            this.ilImages.TransparentColor = System.Drawing.Color.Transparent;
            this.ilImages.Images.SetKeyName(0, "file.jpg");
            this.ilImages.Images.SetKeyName(1, "folder.jpg");
            // 
            // lvView
            // 
            this.lvView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.Size,
            this.Date});
            this.lvView.HideSelection = false;
            this.lvView.LargeImageList = this.ilImages;
            this.lvView.Location = new System.Drawing.Point(199, 13);
            this.lvView.Name = "lvView";
            this.lvView.Size = new System.Drawing.Size(589, 425);
            this.lvView.SmallImageList = this.ilImages;
            this.lvView.StateImageList = this.ilImages;
            this.lvView.TabIndex = 2;
            this.lvView.UseCompatibleStateImageBehavior = false;
            this.lvView.View = System.Windows.Forms.View.List;
            this.lvView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvView_MouseDoubleClick);
            // 
            // FileName
            // 
            this.FileName.Width = 150;
            // 
            // Size
            // 
            this.Size.Width = 150;
            // 
            // Date
            // 
            this.Date.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvView);
            this.Controls.Add(this.tvRoot);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvRoot;
        private System.Windows.Forms.ListView lvView;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ImageList ilImages;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader Date;
    }
}

