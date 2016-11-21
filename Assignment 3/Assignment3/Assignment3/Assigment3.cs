//Vu Le and Gerald Williams
//Fall 2016
//Assigment 6
/*C# Mail Order, Create a form to calculate cost of items inputed by user.
 * Calculations based on whether:
 * -Customer is new customer (Discount)
 * -Customer location (Tax for Washington State)
 * -Amount of items purchased (Handling)
 * -Shipping charge
 * Keep running totals for multiple Items.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class frmAssigment4 : Form
    {
        //Global Constant and variables
        const decimal decTAX_RATE = 0.087m;
        const decimal decNEW_DISCOUNT = 0.10m;
        private decimal decTOTAL; // 0.0m
        private decimal decTOTAL_DUE; // 0.0m
        private decimal decHandlingCost;
        private int intNumberOfItems;
        private decimal decTotalAmount;
        private decimal decShipNHand;

        public frmAssigment4()
        {
            InitializeComponent();
            //Current Date
            txtDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Try/Catch for errors in calculations
            try
            {
                decimal decPrice; int intQuantity; //local variable
                //Convert text to decimal
                intQuantity = Convert.ToInt32(numQuantity.Text);
                decPrice = Convert.ToDecimal(txtPrice.Text);
                //Calculation (quantity times price)
                decTOTAL = decPrice * intQuantity;
                decTOTAL_DUE += decTOTAL;
                //Hold count in variable for handling 
                intNumberOfItems += intQuantity;
                //Clear description, quantity, price then focus back to description               
                txtDescription.Clear();
                txtPrice.Clear();
                txtDescription.Focus();
                //reset quantity to 1
                numQuantity.Value = 1;
                //Enable Summary button, disable Customer group box
                btnSummary.Enabled = true;
                grpCustomer.Enabled = false;
            }
            // Catch All, format wrong
            catch (FormatException)
            {
                MessageBox.Show("Non-Numeric", "Bad Input");
            }
            // Catch, data size too large
            catch (OverflowException)
            {
                MessageBox.Show("Huge", "Bad Input");
            }
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            //Disable the customer group box when enter text in description
            grpCustomer.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //reset the accumulator back to 0
            decTOTAL = 0.0m;
            decTOTAL_DUE = 0.0m;
            intNumberOfItems = 0;
            //Clear all data and focus back to Name
            txtName.Clear();
            txtStreet.Clear();
            txtCity.Clear();
            mskZip.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            txtTotal.Clear();
            txtName.Focus();
            txtAmount.Clear();
            txtSalesTax.Clear();
            txtShipping.Clear();
            //reset quantity to 1
            numQuantity.Value = 1;
            //Enable Customer group box
            grpCustomer.Enabled = true;
            //Reset shipping and payment type radio types
            rdoExpress.Checked = true;
            rdoCharge.Checked = true;
            //Reset State text box to WAshington State
            txtState.Text = Convert.ToString("WA");
            //Reset New Customer checkbox back to true
            chkNew.Checked = true;
            //Disable summary button
            btnSummary.Enabled = false;
        }

        private void frmAssigment4_Load(object sender, EventArgs e)
        {
            //Display the link in rich textbox
            rtfLink.Text = "www.ups.com";
        }

        private void rtfLink_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            //Enable you to click on the url and open a browser
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void btnSummary_Click(object sender, EventArgs e)

        {
            //Local variable
            decimal decHandlingCost, decShippingCost, decTaxAmount, decDiscount;
            decHandlingCost = GetHandlingFee();
            decShippingCost = GetShippingCharge();
            decTaxAmount = GetSalesTax();
            decDiscount = GetDiscount();
            // Calculate decimal of shipping and handling together into variable
            decShipNHand = (decHandlingCost + decShippingCost);
            // Calculate amount due
            decTOTAL_DUE = decTOTAL_DUE - decDiscount;
            // Calculate final Total Amount in decimal
            decTotalAmount = (decTOTAL_DUE - decDiscount) + decTaxAmount + decHandlingCost + decShippingCost;
            // Set text output to currency
            txtShipping.Text = decShipNHand.ToString("c");
            txtTotal.Text = decTotalAmount.ToString("c");
            txtSalesTax.Text = decTaxAmount.ToString("c");
            txtAmount.Text = decTOTAL_DUE.ToString("c");
        }
        //Get sales tax method (debugging)
        private decimal GetSalesTax()
        {
            decimal decTaxAmount; //local variable

            if (txtState.Text == "WA")//Test data
            {
                decTaxAmount = (decTOTAL_DUE * decTAX_RATE);//If true multiply by our constant decTAX_RATE
            }
            else//If false value set to 0m
            {
                decTaxAmount = 0m;
            }
            return decTaxAmount;//Return value set by method
        }
        // Get handling fee method 
        private decimal GetHandlingFee()
        {
            switch (intNumberOfItems)//Begin switch for case method
            {
                case 1:
                case 2:     // if value is 2 or less
                    decHandlingCost = 1.5m;
                    break;
                case 3:
                case 4:     // if value is 3 or 4
                    decHandlingCost = 2.75m;
                    break;
                default:    // if value is other (greater then 5)
                    decHandlingCost = 5.5m;
                    break;
            }
            return decHandlingCost;//Return case value of decHandlingCost
        }
        // Get shipping charge method 
        private decimal GetShippingCharge()
        {
            decimal decShippingCost;//Local variable for method

            if (rdoExpress.Checked)//Test data
            {
                decShippingCost = 13.25m;//If true (checked) cost 13.25
            }
            else
            {
                decShippingCost = 5.75m;//If false cost 5.75
            }

            return decShippingCost;//Return value determined in method
        }
        // Get discount for new customer
        private decimal GetDiscount()
        {
            decimal decDiscount;//Local variable for method

            if (chkNew.Checked)//Test data
            {
                decDiscount = decTOTAL_DUE * decNEW_DISCOUNT;//If true (checked) apply constant decNEW_DISCOUNT 
            }
            else
            {
                decDiscount = 0m;//If false, set decDiscount to 0m
            }
            return decDiscount;
        }
        //Validating txtName.Text
        private void txtName_Validating(object sender, CancelEventArgs e)//Validating event created by double clicking n properties
        {
            if (txtName.Text == "")//If null value,
            {
                MessageBox.Show("Name required", "Input required");//then show error message.                
                txtName.Focus();//Return focus to txtName
            }
        }
        //Validating txtStreet
        private void txtStreet_Validating(object sender, CancelEventArgs e)
        {
            if (txtStreet.Text == "")//if null value,
            {
                MessageBox.Show("Street address required", "Input required");//then show error message.
                txtStreet.Focus();//Return focus to txtStreet

            }
        }
        //Validating txtCity
        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            if (txtCity.Text == "")//If null value,
            {
                MessageBox.Show("City required", "Input required");//then show error message.
                txtCity.Focus();//Return focus to txtCity
            }
        }
        //Validating mskZip
        private void mskZip_Validating(object sender, CancelEventArgs e)
        {
            if (mskZip.Text.Trim(' ','-') == "")//If null value,
            {
                MessageBox.Show("Zip code required", "Input required");//then show error message.
                mskZip.Focus();//Set focus to mskZip
                mskZip.SelectAll();
            }
        }
        //Validating txtDescription
        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (txtDescription.Text == "")//If null value,
            {
                MessageBox.Show("Description required", "Input required");//then show error message
                txtDescription.Focus();//Set focus to txtDescription
            }
        }
    }
} 