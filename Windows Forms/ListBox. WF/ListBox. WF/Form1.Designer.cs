
namespace ListBox._WF
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
            this.lbProducts = new System.Windows.Forms.ListBox();
            this.mtbProduct = new System.Windows.Forms.MaskedTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.cbSelMode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbProducts
            // 
            this.lbProducts.FormattingEnabled = true;
            this.lbProducts.ItemHeight = 15;
            this.lbProducts.Items.AddRange(new object[] {
            "bag",
            "book",
            "copybook",
            "notepad",
            "pen",
            "pencil",
            "raser",
            "rubber",
            "schoolbag"});
            this.lbProducts.Location = new System.Drawing.Point(12, 12);
            this.lbProducts.Name = "lbProducts";
            this.lbProducts.Size = new System.Drawing.Size(249, 244);
            this.lbProducts.Sorted = true;
            this.lbProducts.TabIndex = 0;
            this.lbProducts.SelectedIndexChanged += new System.EventHandler(this.lbProducts_SelectedIndexChanged);
            // 
            // mtbProduct
            // 
            this.mtbProduct.Location = new System.Drawing.Point(268, 12);
            this.mtbProduct.Mask = "LL???????????????????????????????????????";
            this.mtbProduct.Name = "mtbProduct";
            this.mtbProduct.PromptChar = ' ';
            this.mtbProduct.Size = new System.Drawing.Size(211, 23);
            this.mtbProduct.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(268, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(211, 104);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(268, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(211, 104);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.Location = new System.Drawing.Point(13, 263);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(248, 89);
            this.lblSelected.TabIndex = 4;
            this.lblSelected.Text = "Selected";
            // 
            // cbSelMode
            // 
            this.cbSelMode.FormattingEnabled = true;
            this.cbSelMode.Location = new System.Drawing.Point(268, 263);
            this.cbSelMode.Name = "cbSelMode";
            this.cbSelMode.Size = new System.Drawing.Size(211, 23);
            this.cbSelMode.TabIndex = 5;
            this.cbSelMode.SelectedIndexChanged += new System.EventHandler(this.cbSelMode_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 379);
            this.Controls.Add(this.cbSelMode);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.mtbProduct);
            this.Controls.Add(this.lbProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProducts;
        private System.Windows.Forms.MaskedTextBox mtbProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.ComboBox cbSelMode;
    }
}

