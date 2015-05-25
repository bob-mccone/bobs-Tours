using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bobs_Tours_tour_half
{
    public partial class FrmTour : Form
    {
        private ClsTours _Tour;

        public FrmTour()
        {
            InitializeComponent();
        }

        public bool ShowDialog(ClsTours prTour)
        {
            _Tour = prTour;
            updateDisplay();
            return ShowDialog() == DialogResult.OK;
        }

        private void updateDisplay()
        {
            txtID.Text = _Tour.ID;
            txtName.Text = _Tour.Name;
            dtpStartDate.Value = _Tour.StartDate;
            dtpEndDate.Value = _Tour.EndDate;
            txtMaxPassengers.Text = Convert.ToString(_Tour.MaxPassengers);
            txtTravelDistance.Text = Convert.ToString(_Tour.TravelDistance);
            txtTotalCost.Text = Convert.ToString(_Tour.TotalCost);
            txtMarkUp.Text = Convert.ToString(_Tour.MarkUp);
            txtID.Enabled = String.IsNullOrEmpty(_Tour.ID);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtID.Enabled && ClsCompany.TourList.ContainsKey(txtID.Text))
                MessageBox.Show("Tour with that ID already exists", "Duplicate ID");
            else
            {
                pushData();
                DialogResult = DialogResult.OK;
            }
        }

        private void pushData()
        {
            _Tour.ID = txtID.Text;
            _Tour.Name = txtName.Text;
            _Tour.StartDate = dtpStartDate.Value;
            _Tour.EndDate = dtpEndDate.Value;
            _Tour.MaxPassengers = Convert.ToSingle(txtMaxPassengers.Text);
            _Tour.TravelDistance = Convert.ToSingle(txtTravelDistance.Text);
            _Tour.TotalCost = Convert.ToDecimal(txtTotalCost.Text);
            _Tour.MarkUp = Convert.ToDecimal(txtMarkUp.Text);     
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
