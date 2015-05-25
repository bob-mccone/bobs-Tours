using System;
using System.Windows.Forms;

namespace bobs_Tours
{
    public partial class FrmCost : Form
    {
        private ClsTour _Tour;

        public FrmCost()
        {
            InitializeComponent();
            cboCostType.DataSource = ClsCost.CostType;      //Selects the cost type form to open
            cboCostType.SelectedIndex = 0;
        }

        public bool ShowDialog(ClsTour prTour)
        {
            _Tour = prTour;
            Text = "Costs for " + _Tour.Name + " " + _Tour.DaysOfTrip + " Days";    //Displays the costs of the tour and how many days
            updateDisplay();
            return ShowDialog() == DialogResult.OK;
        }

        private void updateDisplay()
        {
            lstCost.DataSource = null;
            lstCost.DataSource = _Tour.CostList;
        }

        private void btnAdd_Click(object sender, EventArgs e)       //Adds cost to the list box
        {
            createCost();
        }

        private void createCost()   //this is the magic that does the adding
        {
            ClsCost lcCost = ClsCost.NewTourCost(cboCostType.SelectedIndex, _Tour);
            if (lcCost != null && lcCost.ViewEdit())
            {
                _Tour.CostList.Add(lcCost);
                updateDisplay();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)     //Closing of the form
        {
            Close();
        }

        private void editCost()     //Edits the cost
        {
            ClsCost lcCost = (ClsCost)lstCost.SelectedItem;
            if (lcCost != null && lcCost.ViewEdit())
            {
                updateDisplay();
            }
        }

        private void lstCost_MouseDoubleClick(object sender, MouseEventArgs e)      //If user double clicks the edit method is run
        {
            editCost();
        }

        private void btnDelete_Click(object sender, EventArgs e)    //Deletes the Cost
        {
            ClsCost lcCost = (ClsCost)lstCost.SelectedItem;
            if (lcCost == null)     //Runs if the list box is empty
            {
                DialogResult cantDelete = MessageBox.Show("No tours exist to delete", "Delete Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (cantDelete == DialogResult.OK)
                {
                    return;
                }
            }
            else
            {
                DialogResult deleteCost = MessageBox.Show("You are about to delete a tour cost, are you sure?", "Delete Tour Cost",     //Deletes the Cost but asks first
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (deleteCost == DialogResult.Yes)
                {
                    removeCost();
                }
            }
        }

        private void removeCost()       //Magic that removes the cost from the list
        {
            ClsCost lcCost = (ClsCost)lstCost.SelectedItem;
            {
                _Tour.CostList.Remove(lcCost);
                updateDisplay();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ClsCost lcCost = (ClsCost)lstCost.SelectedItem;
            if (lcCost != null)     //If there are items in the list box it will edit it
            {
                editCost();
            }
            else
            {
                DialogResult noCost = MessageBox.Show("Cost doesn't exist would you like to create one now?", "Error",      //If list box is empty it will run an error and ask if they want to create one first
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (noCost == DialogResult.Yes)
                {
                    createCost();
                }
                else
                {
                    return;
                }
            }
        }

        private void FrmCosts_Load(object sender, EventArgs e)      //Populates the list box
        {
            updateDisplay();
        }
    }
}
