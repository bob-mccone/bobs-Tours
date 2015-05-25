using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace bobs_Tours
{
    public partial class FrmMain : Form
    {
        private FrmTour _TourForm = new FrmTour();
        private string[] _SortChoice = { "Name", "Start Date" };    //Populates the combo box with options
        
        public FrmMain()
        {
            InitializeComponent();
            cboSortChoice.DataSource = _SortChoice;     //fills up the options in the combo box
            cboSortChoice.SelectedIndex = 0;
            try
            {
                ClsCompany.Retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        class clsStartDateComparer : IComparer<ClsTour>     //Date Sorter
        {
            public int Compare(ClsTour prTourX, ClsTour prTourY)
            {
                return prTourX.StartDate.Date.CompareTo(prTourY.StartDate.Date);
            }
        }

        class clsNameComparer : IComparer<ClsTour>      //Name Sorter
        {
            public int Compare(ClsTour prTourX, ClsTour prTourY)
            {
                return prTourX.Name.CompareTo(prTourY.Name);
            }
        }

        private IComparer<ClsTour>[] _Comparer = { new clsNameComparer(), new clsStartDateComparer() };     //Declaring the sorter

        private void btnClose_Click(object sender, EventArgs e)     //Closes the form
        {
            ClsCompany.Save();
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)       //Adds a tour
        {
            createTour();
        }

        private void createTour()       //Magic that creates the tour
        {
            ClsTour lcTour = new ClsTour();
            if (lcTour != null && _TourForm.ShowDialog(lcTour))
            {
                ClsCompany.TourList.Add(lcTour.ID, lcTour);
                updateDisplay();
            }
            
        }

        private void editTour()     //Method for editting the tour
        {
            ClsTour lcTour = (ClsTour)lstTours.SelectedItem;
            if (lcTour != null && _TourForm.ShowDialog(lcTour))
            {
                updateDisplay();
            }
        }

        private void updateDisplay()        //Populates the list box
        {
            List<ClsTour> lcTourList = ClsCompany.TourList.Values.ToList();
            lcTourList.Sort(_Comparer[cboSortChoice.SelectedIndex]);
            lstTours.DataSource = lcTourList;
        }

        private void btnEdit_Click(object sender, EventArgs e)      //Edits the selected item
        {
            ClsTour lcTour = (ClsTour)lstTours.SelectedItem;
            if (lcTour != null)
            {
                editTour();
            }
            else
            {
                DialogResult noTour = MessageBox.Show("Tour doesn't exist would you like to create one now?", "Error",      //If list is empty
                    MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (noTour == DialogResult.Yes)
                {
                    createTour();
                }
                else
                {
                    return;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)        //Deletes the tour
        {
            ClsTour lcTour = (ClsTour)lstTours.SelectedItem;
            if (lcTour == null)
            {
                DialogResult cantDelete = MessageBox.Show("No tours exist to delete", "Delete Error",       //If list is empty runs error
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (cantDelete == DialogResult.OK)
                {
                    return;
                }
            }
            else
            {
                DialogResult deleteTour = MessageBox.Show("You are about to delete a tour, are you sure?", "Delete Tour",       //If items are in the list it asks first
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (deleteTour == DialogResult.Yes)
                {
                        removeTour();
                }
            }
        }

        private void lstTours_MouseDoubleClick(object sender, MouseEventArgs e)     //If user double clicks on item in list box
        {
            editTour();
        }

        private void removeTour()       //Method that removes the tour
        {
            ClsTour lcTour = (ClsTour)lstTours.SelectedItem;
            {
                ClsCompany.TourList.Remove(lcTour.ID);
                updateDisplay();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)       //Poipulates the list box
        {
            updateDisplay();
        }

        private void cboSortChoice_SelectedIndexChanged(object sender, EventArgs e)     //When selection in sort box is changed it updates the list box
        {
            updateDisplay();
        }

    }
}
