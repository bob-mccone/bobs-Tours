namespace bobs_Tours
{
    partial class FrmVehicleCost
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
            this.txtDistanceTravelled = new System.Windows.Forms.TextBox();
            this.txtKMCharge = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblRego = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblKMCharge = new System.Windows.Forms.Label();
            this.lblDistanceTravelled = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDistanceTravelled
            // 
            this.txtDistanceTravelled.Location = new System.Drawing.Point(114, 173);
            this.txtDistanceTravelled.Name = "txtDistanceTravelled";
            this.txtDistanceTravelled.Size = new System.Drawing.Size(100, 20);
            this.txtDistanceTravelled.TabIndex = 6;
            // 
            // txtKMCharge
            // 
            this.txtKMCharge.Location = new System.Drawing.Point(114, 147);
            this.txtKMCharge.Name = "txtKMCharge";
            this.txtKMCharge.Size = new System.Drawing.Size(100, 20);
            this.txtKMCharge.TabIndex = 5;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(114, 121);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 4;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(114, 95);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 20);
            this.txtMake.TabIndex = 3;
            // 
            // lblRego
            // 
            this.lblRego.AutoSize = true;
            this.lblRego.Location = new System.Drawing.Point(65, 72);
            this.lblRego.Name = "lblRego";
            this.lblRego.Size = new System.Drawing.Size(43, 13);
            this.lblRego.TabIndex = 16;
            this.lblRego.Text = "Rego #";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(74, 98);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(34, 13);
            this.lblMake.TabIndex = 17;
            this.lblMake.Text = "Make";
            // 
            // lblKMCharge
            // 
            this.lblKMCharge.AutoSize = true;
            this.lblKMCharge.Location = new System.Drawing.Point(48, 150);
            this.lblKMCharge.Name = "lblKMCharge";
            this.lblKMCharge.Size = new System.Drawing.Size(60, 13);
            this.lblKMCharge.TabIndex = 18;
            this.lblKMCharge.Text = "KM-Charge";
            // 
            // lblDistanceTravelled
            // 
            this.lblDistanceTravelled.AutoSize = true;
            this.lblDistanceTravelled.Location = new System.Drawing.Point(12, 176);
            this.lblDistanceTravelled.Name = "lblDistanceTravelled";
            this.lblDistanceTravelled.Size = new System.Drawing.Size(96, 13);
            this.lblDistanceTravelled.TabIndex = 19;
            this.lblDistanceTravelled.Text = "Distance Travelled";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(72, 124);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 20;
            this.lblModel.Text = "Model";
            // 
            // FrmVehicleCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(308, 238);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblDistanceTravelled);
            this.Controls.Add(this.lblKMCharge);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblRego);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtKMCharge);
            this.Controls.Add(this.txtDistanceTravelled);
            this.Name = "FrmVehicleCost";
            this.Text = "Vehicle Cost";
            this.Controls.SetChildIndex(this.txtDistanceTravelled, 0);
            this.Controls.SetChildIndex(this.txtKMCharge, 0);
            this.Controls.SetChildIndex(this.txtModel, 0);
            this.Controls.SetChildIndex(this.txtMake, 0);
            this.Controls.SetChildIndex(this.lblRego, 0);
            this.Controls.SetChildIndex(this.lblMake, 0);
            this.Controls.SetChildIndex(this.lblKMCharge, 0);
            this.Controls.SetChildIndex(this.lblDistanceTravelled, 0);
            this.Controls.SetChildIndex(this.lblModel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDistanceTravelled;
        private System.Windows.Forms.TextBox txtKMCharge;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblRego;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblKMCharge;
        private System.Windows.Forms.Label lblDistanceTravelled;
        private System.Windows.Forms.Label lblModel;
    }
}
