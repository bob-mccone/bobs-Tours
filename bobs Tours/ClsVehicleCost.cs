using System;

namespace bobs_Tours
{
    [Serializable]      //Saving
    class ClsVehicleCost : ClsCost      //Inherited from Class Cost
    {
        private static FrmVehicleCost _Form = new FrmVehicleCost();     //Opens vehicle cost form

        public ClsVehicleCost(ClsTour prTour) : base(prTour) { }

        public override bool ViewEdit()     //Opens the correct form depending on the selection
        {
            return _Form.ShowDialog(this);
        }

        protected override string typeOfCost()      //Returns the cost type
        {
            return "Vehicle Cost";
        }

        public override decimal CalculateCost()     //Overrides the CalculateCost abstract method in clsCost and returns the cost of the vehicle per day
        {
            return KMCharge * DistanceTravelled;
        }

        //Variables
        private string _Make;
        private string _Model;
        private decimal _KMCharge;
        private decimal _DistanceTravelled;

        //Encapsulation of the variables
        public string Make
        {
            get { return _Make; }
            set { _Make = value; }
        }

        public string Model
        {
            get { return _Model; }
            set { _Model = value; }
        }

        public decimal KMCharge
        {
            get { return _KMCharge; }
            set { _KMCharge = value; }
        }

        public decimal DistanceTravelled
        {
            get { return _DistanceTravelled; }
            set { _DistanceTravelled = value; }
        }
    }
}
