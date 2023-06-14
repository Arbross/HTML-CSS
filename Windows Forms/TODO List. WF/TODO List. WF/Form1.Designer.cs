
namespace TODO_List._WF
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
            this.lbTODO = new System.Windows.Forms.ListBox();
            this.mcDate = new System.Windows.Forms.MonthCalendar();
            this.cbHigh = new System.Windows.Forms.CheckBox();
            this.cbMiddle = new System.Windows.Forms.CheckBox();
            this.cbLow = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearSelected = new System.Windows.Forms.Button();
            this.btnFindByName = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbPriority = new System.Windows.Forms.GroupBox();
            this.tbPlaceOn = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbPriority.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTODO
            // 
            this.lbTODO.FormattingEnabled = true;
            this.lbTODO.ItemHeight = 15;
            this.lbTODO.Location = new System.Drawing.Point(12, 12);
            this.lbTODO.Name = "lbTODO";
            this.lbTODO.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbTODO.Size = new System.Drawing.Size(483, 424);
            this.lbTODO.TabIndex = 0;
            // 
            // mcDate
            // 
            this.mcDate.Location = new System.Drawing.Point(514, 12);
            this.mcDate.Name = "mcDate";
            this.mcDate.TabIndex = 1;
            this.mcDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcDate_DateChanged);
            // 
            // cbHigh
            // 
            this.cbHigh.AutoSize = true;
            this.cbHigh.Location = new System.Drawing.Point(7, 15);
            this.cbHigh.Name = "cbHigh";
            this.cbHigh.Size = new System.Drawing.Size(52, 19);
            this.cbHigh.TabIndex = 2;
            this.cbHigh.Text = "High";
            this.cbHigh.UseVisualStyleBackColor = true;
            this.cbHigh.CheckedChanged += new System.EventHandler(this.cbHigh_CheckedChanged);
            // 
            // cbMiddle
            // 
            this.cbMiddle.AutoSize = true;
            this.cbMiddle.Location = new System.Drawing.Point(6, 40);
            this.cbMiddle.Name = "cbMiddle";
            this.cbMiddle.Size = new System.Drawing.Size(63, 19);
            this.cbMiddle.TabIndex = 3;
            this.cbMiddle.Text = "Middle";
            this.cbMiddle.UseVisualStyleBackColor = true;
            this.cbMiddle.CheckedChanged += new System.EventHandler(this.cbHigh_CheckedChanged);
            // 
            // cbLow
            // 
            this.cbLow.AutoSize = true;
            this.cbLow.Location = new System.Drawing.Point(7, 65);
            this.cbLow.Name = "cbLow";
            this.cbLow.Size = new System.Drawing.Size(48, 19);
            this.cbLow.TabIndex = 4;
            this.cbLow.Text = "Low";
            this.cbLow.UseVisualStyleBackColor = true;
            this.cbLow.CheckedChanged += new System.EventHandler(this.cbHigh_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(514, 186);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(514, 215);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(164, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearSelected
            // 
            this.btnClearSelected.Location = new System.Drawing.Point(514, 244);
            this.btnClearSelected.Name = "btnClearSelected";
            this.btnClearSelected.Size = new System.Drawing.Size(164, 23);
            this.btnClearSelected.TabIndex = 7;
            this.btnClearSelected.Text = "Clear Selected";
            this.btnClearSelected.UseVisualStyleBackColor = true;
            this.btnClearSelected.Click += new System.EventHandler(this.btnClearSelected_Click);
            // 
            // btnFindByName
            // 
            this.btnFindByName.Location = new System.Drawing.Point(514, 273);
            this.btnFindByName.Name = "btnFindByName";
            this.btnFindByName.Size = new System.Drawing.Size(164, 23);
            this.btnFindByName.TabIndex = 8;
            this.btnFindByName.Text = "FindByName";
            this.btnFindByName.UseVisualStyleBackColor = true;
            this.btnFindByName.Click += new System.EventHandler(this.btnFindByName_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(690, 118);
            this.tbName.Name = "tbName";
            this.tbName.PlaceholderText = "Name";
            this.tbName.Size = new System.Drawing.Size(100, 23);
            this.tbName.TabIndex = 9;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // gbPriority
            // 
            this.gbPriority.Controls.Add(this.cbMiddle);
            this.gbPriority.Controls.Add(this.cbHigh);
            this.gbPriority.Controls.Add(this.cbLow);
            this.gbPriority.Location = new System.Drawing.Point(690, 12);
            this.gbPriority.Name = "gbPriority";
            this.gbPriority.Size = new System.Drawing.Size(131, 100);
            this.gbPriority.TabIndex = 10;
            this.gbPriority.TabStop = false;
            // 
            // tbPlaceOn
            // 
            this.tbPlaceOn.Location = new System.Drawing.Point(690, 147);
            this.tbPlaceOn.Name = "tbPlaceOn";
            this.tbPlaceOn.PlaceholderText = "PlaceOn";
            this.tbPlaceOn.Size = new System.Drawing.Size(100, 23);
            this.tbPlaceOn.TabIndex = 11;
            this.tbPlaceOn.TextChanged += new System.EventHandler(this.tbPlaceOn_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(514, 303);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(164, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(514, 333);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbPlaceOn);
            this.Controls.Add(this.gbPriority);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnFindByName);
            this.Controls.Add(this.btnClearSelected);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.mcDate);
            this.Controls.Add(this.lbTODO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbPriority.ResumeLayout(false);
            this.gbPriority.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTODO;
        private System.Windows.Forms.MonthCalendar mcDate;
        private System.Windows.Forms.CheckBox cbHigh;
        private System.Windows.Forms.CheckBox cbMiddle;
        private System.Windows.Forms.CheckBox cbLow;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearSelected;
        private System.Windows.Forms.Button btnFindByName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.GroupBox gbPriority;
        private System.Windows.Forms.TextBox tbPlaceOn;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
    }
}

