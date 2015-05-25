namespace bobs_Tours_tour_half
{
    partial class FrmTour
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblMaxPassengers = new System.Windows.Forms.Label();
            this.lblTravelDistance = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblMarkUp = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMaxPassengers = new System.Windows.Forms.TextBox();
            this.txtTravelDistance = new System.Windows.Forms.TextBox();
            this.txtMarkUp = new System.Windows.Forms.TextBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.btnCosts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(250, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(250, 36);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(125, 64);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(125, 90);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(101, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(84, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(64, 70);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(67, 96);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblEndDate.TabIndex = 7;
            this.lblEndDate.Text = "End Date";
            // 
            // lblMaxPassengers
            // 
            this.lblMaxPassengers.AutoSize = true;
            this.lblMaxPassengers.Location = new System.Drawing.Point(12, 119);
            this.lblMaxPassengers.Name = "lblMaxPassengers";
            this.lblMaxPassengers.Size = new System.Drawing.Size(107, 13);
            this.lblMaxPassengers.TabIndex = 8;
            this.lblMaxPassengers.Text = "Max # of Passengers";
            // 
            // lblTravelDistance
            // 
            this.lblTravelDistance.AutoSize = true;
            this.lblTravelDistance.Location = new System.Drawing.Point(37, 145);
            this.lblTravelDistance.Name = "lblTravelDistance";
            this.lblTravelDistance.Size = new System.Drawing.Size(82, 13);
            this.lblTravelDistance.TabIndex = 9;
            this.lblTravelDistance.Text = "Travel Distance";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(64, 171);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(55, 13);
            this.lblTotalCost.TabIndex = 10;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // lblMarkUp
            // 
            this.lblMarkUp.AutoSize = true;
            this.lblMarkUp.Location = new System.Drawing.Point(71, 197);
            this.lblMarkUp.Name = "lblMarkUp";
            this.lblMarkUp.Size = new System.Drawing.Size(48, 13);
            this.lblMarkUp.TabIndex = 11;
            this.lblMarkUp.Text = "Mark Up";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(125, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(125, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 13;
            // 
            // txtMaxPassengers
            // 
            this.txtMaxPassengers.Location = new System.Drawing.Point(125, 116);
            this.txtMaxPassengers.Name = "txtMaxPassengers";
            this.txtMaxPassengers.Size = new System.Drawing.Size(100, 20);
            this.txtMaxPassengers.TabIndex = 14;
            // 
            // txtTravelDistance
            // 
            this.txtTravelDistance.Location = new System.Drawing.Point(125, 142);
            this.txtTravelDistance.Name = "txtTravelDistance";
            this.txtTravelDistance.Size = new System.Drawing.Size(100, 20);
            this.txtTravelDistance.TabIndex = 15;
            // 
            // txtMarkUp
            // 
            this.txtMarkUp.Location = new System.Drawing.Point(125, 194);
            this.txtMarkUp.Name = "txtMarkUp";
            this.txtMarkUp.Size = new System.Drawing.Size(100, 20);
            this.txtMarkUp.TabIndex = 16;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(125, 168);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCost.TabIndex = 17;
            // 
            // btnCosts
            // 
            this.btnCosts.Location = new System.Drawing.Point(250, 114);
            this.btnCosts.Name = "btnCosts";
            this.btnCosts.Size = new System.Drawing.Size(75, 23);
            this.btnCosts.TabIndex = 18;
            this.btnCosts.Text = "Costs";
            this.btnCosts.UseVisualStyleBackColor = true;
            // 
            // FrmTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 229);
            this.Controls.Add(this.btnCosts);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.txtMarkUp);
            this.Controls.Add(this.txtTravelDistance);
            this.Controls.Add(this.txtMaxPassengers);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblMarkUp);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblTravelDistance);
            this.Controls.Add(this.lblMaxPassengers);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "FrmTour";
            this.Text = "FrmTour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblMaxPassengers;
        private System.Windows.Forms.Label lblTravelDistance;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblMarkUp;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMaxPassengers;
        private System.Windows.Forms.TextBox txtTravelDistance;
        private System.Windows.Forms.TextBox txtMarkUp;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Button btnCosts;
    }
}