using System;

namespace bobs_Tours
{
    [Serializable]      //Saving
    class ClsStaffCost : ClsCost       //Inherits from ClsCost
    {
        private static FrmStaffCost _Form = new FrmStaffCost();     //Opens staff cost form

        public ClsStaffCost(ClsTour prTour) : base(prTour) { }

        public override bool ViewEdit()     //Opens the correct form depending on the selection
        {
            return _Form.ShowDialog(this);
        }

        protected override string typeOfCost()      //Returns the cost type
        {
            return "Staff Cost";
        }

        public override decimal CalculateCost()     //Overrides the CalculateCost abstract method in clsCost and returns the cost of the staff member
        {
            return DailyRate * Tour.DaysOfTrip;
        }

        private decimal _DailyRate;     //Daily rate variable

        public decimal DailyRate
        {
            get { return _DailyRate; }
            set { _DailyRate = value; }
        }

        
    }
}
