using System;

namespace bobs_Tours
{
    public partial class FrmOtherCost : bobs_Tours.FrmCostType
    {
        public FrmOtherCost()
        {
            InitializeComponent();
        }

        protected override void updateDisplay()     //Overrides the updateDisplay method
        {
            base.updateDisplay();
            ClsOtherCost lcTourCost = (ClsOtherCost)_TourCost;
            txtCost.Text = Convert.ToString(lcTourCost.Cost);
        }

        protected override void pushData()      //Overrides the pushData method
        {
            base.pushData();
            ClsOtherCost lcTourCost = (ClsOtherCost)_TourCost;
            lcTourCost.Cost = Convert.ToDecimal(txtCost.Text);
        }
    }
}
