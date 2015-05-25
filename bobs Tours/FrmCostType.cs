using System;
using System.Windows.Forms;

namespace bobs_Tours
{
    public partial class FrmCostType : Form
    {
        protected ClsCost _TourCost;

        public FrmCostType()
        {
            InitializeComponent();
        }

        public bool ShowDialog(ClsCost prTourCost)
        {
            _TourCost = prTourCost;
            updateDisplay();
            return ShowDialog() == DialogResult.OK;
        }

        protected virtual void updateDisplay()
        {
            txtType.Text = _TourCost.Type;
            txtNameRegoDescription.Text = _TourCost.NameRegoDescription;
            txtType.Enabled = String.IsNullOrEmpty(_TourCost.Type);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            pushData();
            DialogResult = DialogResult.OK;
        }

        protected virtual void pushData()
        {
            _TourCost.Type = txtType.Text;
            _TourCost.NameRegoDescription = txtNameRegoDescription.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
