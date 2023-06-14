
namespace TreeView._WF
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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Victor");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Somebody");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Programists", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Designers");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("DevOPS");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.ilImages = new System.Windows.Forms.ImageList(this.components);
            this.ilPlusMinus = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.ImageIndex = 19;
            this.treeView1.ImageList = this.ilImages;
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(222, 12);
            this.treeView1.Name = "treeView1";
            treeNode6.ImageKey = "student_cap.png";
            treeNode6.Name = "Node3";
            treeNode6.SelectedImageKey = "student_cap.png";
            treeNode6.Text = "Victor";
            treeNode7.Name = "Node4";
            treeNode7.Text = "Somebody";
            treeNode8.Name = "Node0";
            treeNode8.Text = "Programists";
            treeNode9.Name = "Node1";
            treeNode9.Text = "Designers";
            treeNode10.Name = "Node2";
            treeNode10.Text = "DevOPS";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            this.treeView1.SelectedImageIndex = 19;
            this.treeView1.Size = new System.Drawing.Size(624, 413);
            this.treeView1.StateImageList = this.ilPlusMinus;
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // ilImages
            // 
            this.ilImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilImages.ImageStream")));
            this.ilImages.TransparentColor = System.Drawing.Color.Transparent;
            this.ilImages.Images.SetKeyName(0, "add-icon.png");
            this.ilImages.Images.SetKeyName(1, "blue-plus-icon.png");
            this.ilImages.Images.SetKeyName(2, "bread.png");
            this.ilImages.Images.SetKeyName(3, "cheesecake.jpg");
            this.ilImages.Images.SetKeyName(4, "download.jpg");
            this.ilImages.Images.SetKeyName(5, "garlic_bread.jpg");
            this.ilImages.Images.SetKeyName(6, "green.png");
            this.ilImages.Images.SetKeyName(7, "image001.jpg");
            this.ilImages.Images.SetKeyName(8, "like.png");
            this.ilImages.Images.SetKeyName(9, "maffin.jpg");
            this.ilImages.Images.SetKeyName(10, "math-minus-icon.png");
            this.ilImages.Images.SetKeyName(11, "milk.jpg");
            this.ilImages.Images.SetKeyName(12, "orange.png");
            this.ilImages.Images.SetKeyName(13, "photo_2021-05-08_11-34-00.jpg");
            this.ilImages.Images.SetKeyName(14, "Plus-icon.png");
            this.ilImages.Images.SetKeyName(15, "Professor-icon.png");
            this.ilImages.Images.SetKeyName(16, "red.png");
            this.ilImages.Images.SetKeyName(17, "slide-11.jpg");
            this.ilImages.Images.SetKeyName(18, "student_cap.png");
            this.ilImages.Images.SetKeyName(19, "student-icon.png");
            this.ilImages.Images.SetKeyName(20, "Student-id-icon.png");
            this.ilImages.Images.SetKeyName(21, "W1x3B3SCG1e2YF.jpg");
            // 
            // ilPlusMinus
            // 
            this.ilPlusMinus.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilPlusMinus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilPlusMinus.ImageStream")));
            this.ilPlusMinus.TransparentColor = System.Drawing.Color.Transparent;
            this.ilPlusMinus.Images.SetKeyName(0, "add-icon.png");
            this.ilPlusMinus.Images.SetKeyName(1, "blue-plus-icon.png");
            this.ilPlusMinus.Images.SetKeyName(2, "green.png");
            this.ilPlusMinus.Images.SetKeyName(3, "like.png");
            this.ilPlusMinus.Images.SetKeyName(4, "math-minus-icon.png");
            this.ilPlusMinus.Images.SetKeyName(5, "orange.png");
            this.ilPlusMinus.Images.SetKeyName(6, "student_cap.png");
            this.ilPlusMinus.Images.SetKeyName(7, "student-icon.png");
            this.ilPlusMinus.Images.SetKeyName(8, "Student-id-icon.png");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 70);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 744);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1231, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "Check Info";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(64, 17);
            this.toolStripStatusLabel1.Text = "Check Info";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabel2.Text = "Activate Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 766);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList ilImages;
        private System.Windows.Forms.ImageList ilPlusMinus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

