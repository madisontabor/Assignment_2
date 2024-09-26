using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Assignment_2 : Form
    {
        public enum CarColor
        {
            Black,
            Silver,
            Blue,
            Red
        }

        private CarColor selectedColor;

        public Assignment_2()
        {
            InitializeComponent();
            InitializeListBox();
            selectedColor = CarColor.Black;
            rbtnBlack.Checked = true;
        }

        private void InitializeListBox()
        {
            lstMakeAndModel.Items.Add("Kia Forte");
            lstMakeAndModel.Items.Add("Toyota Rav 4");
            lstMakeAndModel.Items.Add("Chevy Spark");
            lstMakeAndModel.Items.Add("Ford F-150");
        }

        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            lblPurchaseSummary.ForeColor = Color.Black;

            if (lstMakeAndModel.SelectedIndex == -1)
            {
                lblPurchaseSummary.Text = "Please select a make and model.";
                lblPurchaseSummary.ForeColor = Color.Red;
                return;
            }
            if (!int.TryParse(tbxYear.Text, out int year))
            {
                lblPurchaseSummary.Text = "Invalid year. Please enter valid year.";
                lblPurchaseSummary.ForeColor = Color.Red;
                return;
            }

            string colorString = "";
            switch (selectedColor)
            {
                case CarColor.Black:
                    colorString = "Black";
                    break;
                case CarColor.Silver:
                    colorString = "Silver";
                    break;
                case CarColor.Blue:
                    colorString = "Blue";
                    break;
                case CarColor.Red:
                    colorString = "Red";
                    break;
            }

            List<string> features = new List<string>();
            if (chkPowerWindows.Checked) features.Add("Power Windows");
            if (chkAC.Checked) features.Add("AC");
            if (chkSiriusRadio.Checked) features.Add("Sirius Radio");
            if (chkLaneAssistance.Checked) features.Add("Lane Assistance");

            string featureSummary = features.Count > 0 ? string.Join(",", features) : "none";
            lblPurchaseSummary.Text = $"You have purchased a {colorString} {year} {lstMakeAndModel.SelectedItem} with the following features: {featureSummary}.";
        }

        private void RbtnColor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBlack.Checked) selectedColor = CarColor.Black;
            else if (rbtnSilver.Checked) selectedColor = CarColor.Silver;
            else if (rbtnBlue.Checked) selectedColor = CarColor.Blue;
            else if (rbtnRed.Checked) selectedColor = CarColor.Red;

        }

    }
}
