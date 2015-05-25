using System;

namespace bobs_Tours
{
    public partial class FrmStaffCost : bobs_Tours.FrmCostType
    {
        //private ClsTour _Tour;

        public FrmStaffCost()
        {
            InitializeComponent();
        }

        protected override void updateDisplay()     //Overrides the updateDisplay method
        {
            base.updateDisplay();
            ClsStaffCost lcTourCost = (ClsStaffCost)_TourCost;
            txtDailyRate.Text = Convert.ToString(lcTourCost.DailyRate);
        }

        protected override void pushData()      //Overrides the pushData method
        {
            base.pushData();
            ClsStaffCost lcTourCost = (ClsStaffCost)_TourCost;
            lcTourCost.DailyRate = Convert.ToDecimal(txtDailyRate.Text);
        }

        //private void CalcStaffCost()
        //{
        //    ClsStaffCost lcStaffCost = (ClsStaffCost)_TourCost;
        //    lcStaffCost = (txtDailyRate.Text * _Tour.DaysOfTrip).Cost.ToString();
        //}
    }
}
