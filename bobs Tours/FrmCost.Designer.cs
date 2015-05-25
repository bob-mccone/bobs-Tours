namespace bobs_Tours
{
    partial class FrmCost
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCostAmount = new System.Windows.Forms.Label();
            this.lstCost = new System.Windows.Forms.ListBox();
            this.cboCostType = new System.Windows.Forms.ComboBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 126);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(11, 155);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(11, 184);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(284, 184);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(156, 9);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type";
            // 
            // lblCostAmount
            // 
            this.lblCostAmount.AutoSize = true;
            this.lblCostAmount.Location = new System.Drawing.Point(292, 9);
            this.lblCostAmount.Name = "lblCostAmount";
            this.lblCostAmount.Size = new System.Drawing.Size(67, 13);
            this.lblCostAmount.TabIndex = 6;
            this.lblCostAmount.Text = "Cost Amount";
            // 
            // lstCost
            // 
            this.lstCost.FormattingEnabled = true;
            this.lstCost.Location = new System.Drawing.Point(12, 25);
            this.lstCost.Name = "lstCost";
            this.lstCost.Size = new System.Drawing.Size(347, 95);
            this.lstCost.TabIndex = 7;
            this.lstCost.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstCost_MouseDoubleClick);
            // 
            // cboCostType
            // 
            this.cboCostType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCostType.FormattingEnabled = true;
            this.cboCostType.Location = new System.Drawing.Point(238, 126);
            this.cboCostType.Name = "cboCostType";
            this.cboCostType.Size = new System.Drawing.Size(121, 21);
            this.cboCostType.TabIndex = 8;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Location = new System.Drawing.Point(92, 126);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(140, 81);
            this.lblTotalCost.TabIndex = 9;
            this.lblTotalCost.Text = "-";
            // 
            // FrmCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 216);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.cboCostType);
            this.Controls.Add(this.lstCost);
            this.Controls.Add(this.lblCostAmount);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "FrmCost";
            this.Text = "Costs";
            this.Load += new System.EventHandler(this.FrmCosts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCostAmount;
        private System.Windows.Forms.ListBox lstCost;
        private System.Windows.Forms.ComboBox cboCostType;
        private System.Windows.Forms.Label lblTotalCost;
    }
}