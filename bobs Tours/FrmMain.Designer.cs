namespace bobs_Tours
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboSortChoice = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblPricePerPassenger = new System.Windows.Forms.Label();
            this.lstTours = new System.Windows.Forms.ListBox();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 126);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 155);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 184);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 184);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboSortChoice
            // 
            this.cboSortChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSortChoice.FormattingEnabled = true;
            this.cboSortChoice.Location = new System.Drawing.Point(151, 128);
            this.cboSortChoice.Name = "cboSortChoice";
            this.cboSortChoice.Size = new System.Drawing.Size(121, 21);
            this.cboSortChoice.TabIndex = 4;
            this.cboSortChoice.SelectedIndexChanged += new System.EventHandler(this.cboSortChoice_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(78, 9);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblPricePerPassenger
            // 
            this.lblPricePerPassenger.AutoSize = true;
            this.lblPricePerPassenger.Location = new System.Drawing.Point(169, 9);
            this.lblPricePerPassenger.Name = "lblPricePerPassenger";
            this.lblPricePerPassenger.Size = new System.Drawing.Size(103, 13);
            this.lblPricePerPassenger.TabIndex = 7;
            this.lblPricePerPassenger.Text = "Price Per Passenger";
            // 
            // lstTours
            // 
            this.lstTours.FormattingEnabled = true;
            this.lstTours.Location = new System.Drawing.Point(12, 25);
            this.lstTours.Name = "lstTours";
            this.lstTours.Size = new System.Drawing.Size(260, 95);
            this.lstTours.TabIndex = 8;
            this.lstTours.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstTours_MouseDoubleClick);
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Location = new System.Drawing.Point(104, 131);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(41, 13);
            this.lblSortBy.TabIndex = 9;
            this.lblSortBy.Text = "Sort By";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 216);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.lstTours);
            this.Controls.Add(this.lblPricePerPassenger);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cboSortChoice);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "FrmMain";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboSortChoice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblPricePerPassenger;
        private System.Windows.Forms.ListBox lstTours;
        private System.Windows.Forms.Label lblSortBy;
    }
}

