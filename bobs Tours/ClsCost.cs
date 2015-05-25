using System;

namespace bobs_Tours
{
    [Serializable]  //SAving
    public abstract class ClsCost
    {
        private ClsTour _Tour;

        public ClsTour Tour
        {
            get { return _Tour; }
            //set { _Tour = value; }
        }

        public static readonly string[] CostType = { "Staff", "Vehicle", "Other" };     //Fills the combo box and depending on the choice selected opens the right form

        public ClsCost(ClsTour prTour)
        {
            _Tour = prTour;
        }

        public static ClsCost NewTourCost(int prChoice, ClsTour prTour)     //This opens the right form depending on the CostType selection in the combo box
        {
            if (prChoice == 0)
                return new ClsStaffCost(prTour);
            else if (prChoice == 1)
                return new ClsVehicleCost(prTour);
            else
                return new ClsOtherCost(prTour);
        }

        public abstract bool ViewEdit();    //This abstract method is over written in the inherited cost classes and checks if editing was successful or not

        protected abstract string typeOfCost();     //Abstract method that is being over written displaying the cost type

        public abstract decimal CalculateCost();    //Abstract method that is being over written displaying the amount of each cost

        private string _Type;   //Variables in the cost form shared over all three
        private string _NameRegoDescription;

        //encapsulates the variables
        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        public string NameRegoDescription
        {
            get { return _NameRegoDescription; }
            set { _NameRegoDescription = value; }
        }

        public override string ToString()       //Returns the details in the list box
        {
            return _Type + "\t" + _NameRegoDescription + "\t" + typeOfCost() + "\t" + CalculateCost();
        }
    }
}
