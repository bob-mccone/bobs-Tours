using System;

namespace bobs_Tours
{
    [Serializable]  //Saving
    class ClsOtherCost : ClsCost    //Inherits from ClsCost
    {
        private static FrmOtherCost _Form = new FrmOtherCost();     //Opens other cost form

        public ClsOtherCost(ClsTour prTour) : base(prTour) { }

        public override bool ViewEdit()     //Checks the selection from the combo box and opens the right form
        {
            return _Form.ShowDialog(this);
        }

        protected override string typeOfCost()      //Returns the type of string into the list box e.g. other cost
        {
            return "Other Cost";
        }

        private decimal _Cost;      //Cost variable

        public decimal Cost
        {
            get { return _Cost; }
            set { _Cost = value; }
        }

        public override decimal CalculateCost()     //Overrides the CalculateCost abstract method in clsCost and returns the cost variable
        {
            return Cost;
        }
    }
}
