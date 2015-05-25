using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bobs_Tours_tour_half
{
    [Serializable]
    public class ClsTours
    {
        private static FrmTour _Form = new FrmTour();

        private string _ID;
        private string _Name;
        private DateTime _StartDate = DateTime.Today;
        private DateTime _EndDate = DateTime.Today;
        private float _MaxPassengers;
        private float _TravelDistance;
        private decimal _TotalCost;
        private decimal _MarkUp;

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

        public float MaxPassengers
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

        public override string ToString()
        {
            return _Name + "\t" + _StartDate.ToShortDateString() + "\t" + _TotalCost;
        }
    }
}
