namespace bobs_Tours
{
    partial class FrmStaffCost
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDailyRate = new System.Windows.Forms.Label();
            this.txtDailyRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(73, 72);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // lblDailyRate
            // 
            this.lblDailyRate.AutoSize = true;
            this.lblDailyRate.Location = new System.Drawing.Point(43, 98);
            this.lblDailyRate.Name = "lblDailyRate";
            this.lblDailyRate.Size = new System.Drawing.Size(65, 13);
            this.lblDailyRate.TabIndex = 13;
            this.lblDailyRate.Text = "Daily Rate $";
            // 
            // txtDailyRate
            // 
            this.txtDailyRate.Location = new System.Drawing.Point(114, 95);
            this.txtDailyRate.Name = "txtDailyRate";
            this.txtDailyRate.Size = new System.Drawing.Size(100, 20);
            this.txtDailyRate.TabIndex = 3;
            // 
            // FrmStaffCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(308, 158);
            this.Controls.Add(this.txtDailyRate);
            this.Controls.Add(this.lblDailyRate);
            this.Controls.Add(this.lblName);
            this.Name = "FrmStaffCost";
            this.Text = "Staff Cost";
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.lblDailyRate, 0);
            this.Controls.SetChildIndex(this.txtDailyRate, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDailyRate;
        private System.Windows.Forms.TextBox txtDailyRate;
    }
}
