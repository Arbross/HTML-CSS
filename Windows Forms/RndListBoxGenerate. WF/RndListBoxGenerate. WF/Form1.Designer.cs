
namespace RndListBoxGenerate._WF
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
            this.lbNumbers = new System.Windows.Forms.ListBox();
            this.nmMin = new System.Windows.Forms.NumericUpDown();
            this.nmMax = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbTypes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNumbers
            // 
            this.lbNumbers.FormattingEnabled = true;
            this.lbNumbers.ItemHeight = 15;
            this.lbNumbers.Location = new System.Drawing.Point(12, 12);
            this.lbNumbers.Name = "lbNumbers";
            this.lbNumbers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbNumbers.Size = new System.Drawing.Size(181, 424);
            this.lbNumbers.TabIndex = 0;
            this.lbNumbers.SelectedValueChanged += new System.EventHandler(this.lbNumbers_SelectedValueChanged);
            // 
            // nmMin
            // 
            this.nmMin.Location = new System.Drawing.Point(199, 35);
            this.nmMin.Name = "nmMin";
            this.nmMin.Size = new System.Drawing.Size(120, 23);
            this.nmMin.TabIndex = 1;
            // 
            // nmMax
            // 
            this.nmMax.Location = new System.Drawing.Point(200, 97);
            this.nmMax.Name = "nmMax";
            this.nmMax.Size = new System.Drawing.Size(120, 23);
            this.nmMax.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(200, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Min";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(200, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Max";
            // 
            // nmCount
            // 
            this.nmCount.Location = new System.Drawing.Point(199, 159);
            this.nmCount.Name = "nmCount";
            this.nmCount.Size = new System.Drawing.Size(120, 23);
            this.nmCount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(199, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Count";
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(326, 35);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(120, 247);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Result";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(199, 236);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 93);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Random Value";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbTypes
            // 
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Items.AddRange(new object[] {
            "Product",
            "Sum",
            "Average"});
            this.cbTypes.Location = new System.Drawing.Point(200, 197);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(119, 23);
            this.cbTypes.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbTypes);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmMax);
            this.Controls.Add(this.nmMin);
            this.Controls.Add(this.lbNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbNumbers;
        private System.Windows.Forms.NumericUpDown nmMin;
        private System.Windows.Forms.NumericUpDown nmMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbTypes;
    }
}

