using System;

namespace bobs_Tours
{
    public partial class FrmVehicleCost : bobs_Tours.FrmCostType
    {
        public FrmVehicleCost()
        {
            InitializeComponent();
        }

        protected override void updateDisplay()     //Overrides the updateDisplay method
        {
            base.updateDisplay();
            ClsVehicleCost lcTourCost = (ClsVehicleCost)_TourCost;
            txtMake.Text = lcTourCost.Make;
            txtModel.Text = lcTourCost.Model;
            txtKMCharge.Text = Convert.ToString(lcTourCost.KMCharge);
            txtDistanceTravelled.Text = Convert.ToString(lcTourCost.DistanceTravelled);
        }

        protected override void pushData()      //Overrides the updateDisplay method
        {
            base.pushData();
            ClsVehicleCost lcTourCost = (ClsVehicleCost)_TourCost;
            lcTourCost.Make = txtMake.Text;
            lcTourCost.Model = txtModel.Text;
            lcTourCost.KMCharge = Convert.ToDecimal(txtKMCharge.Text);
            lcTourCost.DistanceTravelled = Convert.ToDecimal(txtDistanceTravelled.Text);
        }

        private void txtDistanceTravelled_TextChanged(object sender, EventArgs e)
        {
            
        }

    }
}
