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
    public partial class FrmMain : Form
    {
        private FrmTour _TourForm = new FrmTour();
        private string[] _SortChoice = { "Name", "Start Date" };
        
        public FrmMain()
        {
            InitializeComponent();
            cboSortChoice.DataSource = _SortChoice;
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

        class clsStartDateComparer : IComparer<ClsTours>
        {
            public int Compare(ClsTours prTourX, ClsTours prTourY)
            {
                return prTourX.StartDate.Date.CompareTo(prTourY.StartDate.Date);
            }
        }

        class clsNameComparer : IComparer<ClsTours>
        {
            public int Compare(ClsTours prTourX, ClsTours prTourY)
            {
                return prTourX.Name.CompareTo(prTourY.Name);
            }
        }

        private IComparer<ClsTours>[] _Comparer = { new clsNameComparer(), new clsStartDateComparer() };

        private void btnClose_Click(object sender, EventArgs e)
        {
            ClsCompany.Save();
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            createTour();
        }

        private void createTour()
        {
            ClsTours lcTour = new ClsTours();
            if (lcTour != null && _TourForm.ShowDialog(lcTour))
            {
                ClsCompany.TourList.Add(lcTour.ID, lcTour);
                updateDisplay();
            }
            
        }

        private void editTour()
        {
            ClsTours lcTour = (ClsTours)lstTours.SelectedItem;
            if (lcTour != null && _TourForm.ShowDialog(lcTour))
            {
                updateDisplay();
            }
        }

        private void updateDisplay()
        {
            List<ClsTours> lcTourList = ClsCompany.TourList.Values.ToList();
            lcTourList.Sort(_Comparer[cboSortChoice.SelectedIndex]);
            lstTours.DataSource = lcTourList;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ClsTours lcTour = (ClsTours)lstTours.SelectedItem;
            if (lcTour != null)
            {
                editTour();
            }
            else
            {
                DialogResult noTour = MessageBox.Show("Tour doesn't exist would you like to create one now?", "Error",
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClsTours lcTour = (ClsTours)lstTours.SelectedItem;
            if (lcTour == null)
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
                DialogResult deleteTour = MessageBox.Show("You are about to delete a tour, are you sure?", "Delete Tour",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (deleteTour == DialogResult.Yes)
                {
                        removeTour();
                }
            }
        }

        private void lstTours_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editTour();
        }

        private void removeTour()
        {
            ClsTours lcTour = (ClsTours)lstTours.SelectedItem;
            {
                ClsCompany.TourList.Remove(lcTour.ID);
                updateDisplay();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            updateDisplay();
        }

        private void cboSortChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDisplay();
        }

    }
}
