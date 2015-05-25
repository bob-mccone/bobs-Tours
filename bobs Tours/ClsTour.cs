using System;
using System.Collections.Generic;

namespace bobs_Tours
{
    [Serializable]      //Saving
    public class ClsTour
    {
        private static FrmTour _Form = new FrmTour();       //Declares and instantances the variable _Form

        private string _ID;     //Tour Variables
        private string _Name;
        private DateTime _StartDate = DateTime.Today;
        private DateTime _EndDate = DateTime.Today;
        //private float _DaysOfTrip;
        private decimal _MaxPassengers;
        private float _TravelDistance;
        private decimal _TotalCost;
        private decimal _MarkUp;
        private List<ClsCost> _CostList = new List<ClsCost>();

        public List<ClsCost> CostList       //Makes the cost list unique with the tour
        {
            get 
            {
                if (_CostList == null)
                    _CostList = new List<ClsCost>();
                return _CostList;
            }
           // set { _CostList = value; }
        }

        //encapsulation of the variables
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public DateTime StartDate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        public DateTime EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }

        public int DaysOfTrip
        {
            get
            {
                return (_EndDate.Date - _StartDate.Date).Days + 1;      //Formula for working out days of the trip
            }
        }

        public decimal MaxPassengers
        {
            get { return _MaxPassengers; }
            set { _MaxPassengers = value; }
        }

        public float TravelDistance
        {
            get { return _TravelDistance; }
            set { _TravelDistance = value; }
        }

        public decimal TotalCost
        {
            get { return _TotalCost; }
            set { _TotalCost = value; }
        }

        public decimal MarkUp
        {
            get { return _MarkUp; }
            set { _MarkUp = value; }
        }

        //attempt at calculating all the costs
        public decimal CostTotal()
        {
            decimal lcTotal = 0;
            foreach (ClsCost lcCost in _CostList)
                lcTotal += lcCost.CalculateCost();
            return lcTotal;
        }

        //attempt at working out the price per passenger not working
        public decimal PricePerPassenger(ClsTour prTour)
        {
            decimal lcTotal = CostTotal();
            decimal lcMaxPassengers = MaxPassengers;
            decimal lcMarkUp = lcTotal * MarkUp / 100;
            //decimal lcTotalCost = TotalCost;
            decimal lcPricePerPassenger = lcMarkUp + lcTotal;
            return lcPricePerPassenger;
        }
        //TotalCost * Markup / 100 = Markup + TotalCost = PricePerPassenger

        public override string ToString()       //Returns the variables to the listbox
        {
            return _Name + "\t" + _StartDate.ToShortDateString() + "\t" + _TotalCost;
        }
    }
}
