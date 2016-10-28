//Vu Le and Gerald Williams
//Fall 2016
//Assigment 3
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
        private decimal decTOTAL; // 0.0m
        private decimal decTOTAL_DUE; // 0.0m
        private decimal decTaxAmount;       
        private decimal decShippingCost;
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
                //Local variable
                decimal decPrice; int intQuantity;
                //Convert text to decimal
                intQuantity = Convert.ToInt32(txtQuantity.Text);
                decPrice = Convert.ToDecimal(txtPrice.Text);
                //Calculation (quantity times price)
                if (chkNew.Checked)
                    decTOTAL = (decPrice * intQuantity) * .9m;
                else decTOTAL = decPrice * intQuantity;
                decTOTAL_DUE += decTOTAL;
                intNumberOfItems += intQuantity;
                //Get tax amount 
                if (txtState.Text == "WA")
                    decTaxAmount = (decTOTAL_DUE * decTAX_RATE);
                else decTaxAmount = 0m;
                //Test Quantity Count (debugging) remove when finished
                txtCount.Text = intNumberOfItems.ToString();
                //Clear description, quantity, price then focus back to description
                grpCustomer.Enabled = false;
                txtDescription.Clear();
                txtQuantity.Clear();
                txtPrice.Clear();
                txtDescription.Focus();
                btnSummary.Enabled = true;
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
            txtQuantity.Clear();
            txtPrice.Clear();
            txtTotal.Clear();
            grpCustomer.Enabled = true;
            txtName.Focus();
            txtAmount.Clear();
            txtSalesTax.Clear();
            txtShipping.Clear();
            txtCount.Clear();

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
            switch (intNumberOfItems)
            {
                case 1:
                case 2:
                    decHandlingCost = 1.5m;
                    break;
                case 3:
                case 4:
                    decHandlingCost = 2.75m;
                    break;
                default:
                    decHandlingCost = 5.5m;
                    break;

            }
            if (rdoExpress.Checked)
                decShippingCost = 13.25m;
            else
                decShippingCost = 5.75m;
            decShipNHand = (decHandlingCost + decShippingCost);
            decTotalAmount = (decTOTAL_DUE + decTaxAmount + decHandlingCost + decShippingCost);
            txtShipping.Text = decShipNHand.ToString("c");
            txtTotal.Text = decTotalAmount.ToString("c");
            txtSalesTax.Text = decTaxAmount.ToString("c");
            txtAmount.Text = decTOTAL_DUE.ToString("c");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
