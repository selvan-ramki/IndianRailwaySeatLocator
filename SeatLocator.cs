using System;
using System.Windows.Forms;

namespace IndianRailwaySeatLocator
{
    public partial class SeatLocator : Form
    {
        public SeatLocator()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboClassType.Text == null || cboClassType.Text.Trim().Length == 0)
                {
                    ShowErrorMessage("Please select a class");
                    return;
                }

                if (txtNo.Text.Trim().Length == 0)
                {
                    ShowErrorMessage("Please enter a number");
                    return;
                }

                int no = 0;
                if (int.TryParse(txtNo.Text.Trim(), out no) == false)
                {
                    ShowErrorMessage("Please enter a valid number");
                    return;
                }

                if (cboClassType.Text.Trim().ToUpper() == "SLEEPER")
                {
                    sleeperWidget.No = no;
                }
                else if (cboClassType.Text.Trim().ToUpper() == "SECOND SITTING")
                {
                    secondSittingWidget.No = no;
                }
            }
            catch (Exception exp)
            {
                ShowErrorMessage(exp.Message);
            }
        }

        private void cboClassType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Hide all.
                sleeperWidget.Visible = false;
                secondSittingWidget.Visible = false;

                if (cboClassType.Text == null)
                    return;

                if (cboClassType.Text.Trim().ToUpper() == "SLEEPER")
                {
                    sleeperWidget.Visible = true;
                }
                else if (cboClassType.Text.Trim().ToUpper() == "SECOND SITTING")
                {
                    secondSittingWidget.Visible = true;
                }
            }
            catch (Exception exp)
            {
                ShowErrorMessage(exp.Message);
            }
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
