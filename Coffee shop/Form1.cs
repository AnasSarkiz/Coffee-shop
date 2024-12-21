using System;
using System.Windows.Forms;

namespace CoffeeApp
{
    public partial class CoffeeForm : Form
    {
        public CoffeeForm()
        {
            InitializeComponent();
        }

       

       
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdoWhite_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoWholeWheat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoRegular_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoCappuccino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoCafeAuLait_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkCreamCheese_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkButter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBlueberryJam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkRaspberry_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoNone_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Bagel Prices
            double bagelPrice = 0;
            if (rdoWhite.Checked) bagelPrice = 1.25;
            else if (rdoWholeWheat.Checked) bagelPrice = 1.50;

            // Coffee Prices
            double coffeePrice = 0;
            if (rdoRegular.Checked) coffeePrice = 1.25;
            else if (rdoCappuccino.Checked) coffeePrice = 2.00;
            else if (rdoCafeAuLait.Checked) coffeePrice = 1.70;

            // Topping Prices
            double toppingPrice = 0;
            if (chkCreamCheese.Checked) toppingPrice += 0.50;
            if (chkButter.Checked) toppingPrice += 0.25;
            if (chkBlueberryJam.Checked) toppingPrice += 0.75;
            if (chkRaspberry.Checked) toppingPrice += 0.75;
            if (chkPeachJelly.Checked) toppingPrice += 0.75;

            // Calculate Total
            double subtotal = bagelPrice + coffeePrice + toppingPrice;
            double tax = subtotal * 0.07; // Assuming 7% tax
            double total = subtotal + tax;

            // Display Prices in TextBoxes
            txtSubtotal.Text = subtotal.ToString("C"); // Currency format
            txtTax.Text = tax.ToString("C");
            txtTotal.Text = total.ToString("C");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset all controls to their default state
            rdoWhite.Checked = true;
            rdoNone.Checked = true;
            chkCreamCheese.Checked = false;
            chkButter.Checked = false;
            chkBlueberryJam.Checked = false;
            chkRaspberry.Checked = false;
            chkPeachJelly.Checked = false;

            // Clear TextBoxes
            txtSubtotal.Clear();
            txtTax.Clear();
            txtTotal.Clear();
        }
    }
}
