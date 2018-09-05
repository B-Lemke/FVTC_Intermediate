using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJL.LunchOrder.UserInterface
{
    public partial class FrmLunchOrder : Form
    {
        //Global Variables
        decimal addOnPrice = 0.75m;

        public FrmLunchOrder()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoHamburger_CheckedChanged(object sender, EventArgs e)
        {
            //When hamburger is selected: Clear prices, Clear add-ons, Change add on price, change add-ons, clear food image

            //Run clear prices and clear add-ons functions when radio button selected
            clearPrices();
            clearAddOns();

            //Clear all totals and un-check all add-ons
            lblSubTotalDisp.Text = "";
            lblTaxDisp.Text = "";
            lblOrderTotalDisp.Text = "";
            chkFirstAddOn.Checked = false;
            chkSecondAddOn.Checked = false;
            chkThirdAddOn.Checked = false;

            //Change Add-on Labels
            chkFirstAddOn.Text = "Lettuce, tomato, and onions";
            chkSecondAddOn.Text = "Ketchup, mustard, and mayo";
            chkThirdAddOn.Text = "French fries";
           

            //Change Add-on Price and adjust group label
            addOnPrice = 0.75m;
            addOnLabelUpdate();

        }

        private void rdoPizza_CheckedChanged(object sender, EventArgs e)
        {
            //When pizza is selected: Clear prices, Clear add-ons, Change add on price, change add-ons, clear food image

            //Run clear prices and clear add-ons functions when radio button selected
            clearPrices();
            clearAddOns();

            //Change Add-on Labels
            chkFirstAddOn.Text = "Pepperoni";
            chkSecondAddOn.Text = "Sausage";
            chkThirdAddOn.Text = "Olives";

            //Change Add-on Price
            addOnPrice = 0.50m;
            addOnLabelUpdate();

        }

        private void rdoSalad_CheckedChanged(object sender, EventArgs e)
        {
            //When salad is selected: Clear prices, Clear add-ons, Change add on price, change add-ons, clear food image

            //Run clear prices and clear add-ons functions when radio button selected
            clearPrices();
            clearAddOns();

            //Change Add-on Labels
            chkFirstAddOn.Text = "Crutons";
            chkSecondAddOn.Text = "Bacon bits";
            chkThirdAddOn.Text = "Bread sticks";

            //Change Add-on Price
            addOnPrice = 0.25m;
            addOnLabelUpdate();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            //When place order is clicked: Get main course price, add add-ons, calculate subtotal, calculate tax, calculate order total.
            decimal subTotal = 0m;
            decimal tax = 0m;
            decimal orderTotal = 0m;
            decimal mainCoursePrice = 0m;
            const double taxRate = 0.0775;
            int addOnCounter = 0;

            //Check radio buttons and see what the price is for the currently selected main course
            if (rdoHamburger.Checked)
                mainCoursePrice = 6.95m;
            else if (rdoPizza.Checked)
                mainCoursePrice = 5.95m;
            else if (rdoSalad.Checked)
                mainCoursePrice = 4.95m;
            else
            {
                //If for some reason a radio box isn't check, throw an error and break out of this logic.
                MessageBox.Show("Error with radio button selection", "Error");
                return;
            }

            //Zero out the addOnCounter
            addOnCounter = 0;

            //Loop through controls in the groupBox
            foreach (Control c in grpAddOn.Controls)
            {
                //If the control is a checkbox and it is checked, increase counter
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                    addOnCounter++;
            }

            //Calculate SubTotal (main course + add-ons)
            subTotal = mainCoursePrice + (addOnPrice * addOnCounter);

            //Calculate Tax SubTotal * tax rate
            tax = subTotal * (decimal)taxRate;

            //Order total is tax + subTotal
            orderTotal = subTotal + tax;

            //Update Displays with the calculated values
            lblSubTotalDisp.Text = subTotal.ToString("c");
            lblTaxDisp.Text = tax.ToString("c");
            lblOrderTotalDisp.Text = orderTotal.ToString("c");

            //update food picture
            if (rdoSalad.Checked)
                picFood.Image = UserInterface.Properties.Resources.salad;
            else if (rdoHamburger.Checked)
                picFood.Image = UserInterface.Properties.Resources.hamburger;
            else if (rdoPizza.Checked)
                picFood.Image = UserInterface.Properties.Resources.pizza;
        }


        //When Checkboxes are clicked, clear prices: 

        private void chkFirstAddOn_CheckedChanged(object sender, EventArgs e)
        {
            //Run clear prices function when check box selected
            clearPrices();
        }
    
        private void chkSecondAddOn_CheckedChanged(object sender, EventArgs e)
        {
            //Run clear prices function when check box selected
            clearPrices();
        }

        private void chkThirdAddOn_CheckedChanged(object sender, EventArgs e)
        {
            //Run clear prices function when check box selected
            clearPrices();
        }

        private void clearPrices()
        {
            //Clear the prices that have been calculated
            lblOrderTotalDisp.Text = "";
            lblSubTotalDisp.Text = "";
            lblTaxDisp.Text = "";

            //Clear image whenever anything is updated
            picFood.Image = null;
        }

        private void clearAddOns()
        {
            //Clear the add-on check boxes
            chkFirstAddOn.Checked = false;
            chkSecondAddOn.Checked = false;
            chkThirdAddOn.Checked = false;
        }

        private void addOnLabelUpdate()
        {
            //Use the updated global variable to update the label
            grpAddOn.Text = "Add-on items ($" + addOnPrice + "/each)";
        }
    }
}
