using System;
using System.Windows.Forms;

namespace bobs_Tours
{
    public partial class FrmTour : Form
    {
        private ClsTour _Tour;  //Making Class tour objects available to form tour objects
        private FrmCost _TourCostForm = new FrmCost();  //declaring the form and Instancing it

        public FrmTour()
        {
            InitializeComponent();
        }

        public bool ShowDialog(ClsTour prTour)  //If editing was successful or not
        {
            _Tour = prTour;
            updateDisplay();
            return ShowDialog() == DialogResult.OK;
        }

        private void updateDisplay()    //assigns the tour objects to the textboxes or values
        {
            txtID.Text = _Tour.ID;
            txtName.Text = _Tour.Name;
            dtpStartDate.Value = _Tour.StartDate;
            dtpEndDate.Value = _Tour.EndDate;
            txtMaxPassengers.Text = Convert.ToString(_Tour.MaxPassengers);
            txtTravelDistance.Text = Convert.ToString(_Tour.TravelDistance);
            lblShowTotalCost.Text = Convert.ToString(_Tour.TotalCost);
            txtMarkUp.Text = Convert.ToString(_Tour.MarkUp);
            txtID.Enabled = String.IsNullOrEmpty(_Tour.ID);
        }

        private void btnOK_Click(object sender, EventArgs e)    //Pushes the data through
        {
            if (txtID.Enabled && ClsCompany.TourList.ContainsKey(txtID.Text))   //Error checking of the ID
                MessageBox.Show("Tour with that ID already exists", "Duplicate ID");
            else
            {
                pushData();
                DialogResult = DialogResult.OK;
            }
        }

        private void pushData()     //assigns the textboxes values to the tour objects i.e. opposite of updateDisplay method
        {
            _Tour.ID = txtID.Text;
            _Tour.Name = txtName.Text;
            _Tour.StartDate = dtpStartDate.Value;
            _Tour.EndDate = dtpEndDate.Value;
            //_Tour.DaysOfTrip = Convert.ToSingle(txtDaysOfTrip.Text);
            //txtDaysOfTrip.Text = Convert.ToString(_Tour.DaysOfTrip);
            _Tour.MaxPassengers = Convert.ToDecimal(txtMaxPassengers.Text);
            _Tour.TravelDistance = Convert.ToSingle(txtTravelDistance.Text);
            _Tour.TotalCost = Convert.ToDecimal(lblShowTotalCost.Text);
            _Tour.MarkUp = Convert.ToDecimal(txtMarkUp.Text);     
        }

        private void btnCancel_Click(object sender, EventArgs e)    //Closes the form
        {
            Close();
        }

        private void btnCosts_Click(object sender, EventArgs e)     //opens the cost form
        {
            _TourCostForm.ShowDialog(_Tour);
            //_Tour.CostTotal();
            pushData();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)    //works out the days of trip when date is chosen
        {
            txtDaysOfTrip.Text = ((dtpEndDate.Value.Date - dtpStartDate.Value.Date).Days +1).ToString();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)     //same as above
        {
            txtDaysOfTrip.Text = ((dtpEndDate.Value.Date - dtpStartDate.Value.Date).Days + 1).ToString();
        }

        private void txtMarkUp_TextChanged(object sender, EventArgs e)  //attempt to do work out the price per passenger but doesn't work
        {
            //showPricePerPassenger(_Tour);
            //pushData();
        }

        //private void showPricePerPassenger(ClsTour prTour)
        //{
        //    decimal lcPassengerPrice = _Tour.PricePerPassenger(prTour);
        //    lblShowTotalCost.Text = string.Format("{0:C}", lcPassengerPrice);
        //}

        //private void TotalOfCost()
        //{
        //    //decimal lcTourCost = _Tour.CostTotal();
        //    //lblShowTotalCost.Text = string.Format("{0:C}", lcTourCost);
        //}

    }
}
