﻿//Vu Le and Gerald Williams
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
                decimal decPrice; int intQuantity;                                          //local variable

                intQuantity = Convert.ToInt32(numQuantity.Text);                            //Convert text from user to decimal
                decPrice = Convert.ToDecimal(txtPrice.Text);                
                if (txtDescription.Text == "")                                              //If null value,
                {
                    MessageBox.Show("Description required", "Input required");              //then show error message
                    txtDescription.Focus();                                                 //Set focus to txtDescription
                }
                else if (txtPrice.Text == "")
                {
                    MessageBox.Show("Price required", "Input required");
                    txtPrice.Focus();
                }
                else
                {
                    decTOTAL = decPrice * intQuantity;                                      //Calculation (quantity times price)
                    decTOTAL_DUE += decTOTAL;                                               //Hold count in variable for handling                  
                    intNumberOfItems += intQuantity;                                        //and Quantity                               
                    txtDescription.Clear();                                                 //Clear description, quantity, price then focus back to description
                    txtPrice.Clear();
                    txtDescription.Focus();
                    numQuantity.Value = 1;                                                  //reset quantity to 1                
                    btnSummary.Enabled = true;                                              //Enable Summary button, disable Customer group box
                    grpCustomer.Enabled = false;
                }
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
            txtName.Clear();                                                            //Clear all data and focus back to Name
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
            numQuantity.Value = 1;                                                      //reset quantity to 1
            grpCustomer.Enabled = true;                                                 //Enable Customer group box
            rdoExpress.Checked = true;                                                  //Reset shipping and payment type radio types
            rdoCharge.Checked = true;
            txtState.Text = Convert.ToString("WA");                                     //Reset State text box to WAshington State
            chkNew.Checked = true;                                                      //Reset New Customer checkbox back to true
            btnSummary.Enabled = false;                                                 //Disable summary button
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
            decShipNHand = (decHandlingCost + decShippingCost);                         //Calculate decimal of shipping and handling together into variable
            decTOTAL_DUE = decTOTAL_DUE - decDiscount;                                  // Calculate amount due
                                                                                        // Calculate final Total Amount in decimal
            decTotalAmount = (decTOTAL_DUE - decDiscount) + decTaxAmount + decHandlingCost + decShippingCost;
            txtShipping.Text = decShipNHand.ToString("c");                              // Set text output to currency
            txtTotal.Text = decTotalAmount.ToString("c");
            txtSalesTax.Text = decTaxAmount.ToString("c");
            txtAmount.Text = decTOTAL_DUE.ToString("c");
        }
        //Get sales tax method (debugging)
        private decimal GetSalesTax()
        {
            decimal decTaxAmount;                                                       //local variable

            if (txtState.Text == "WA")                                                  //Test data
            {
                decTaxAmount = (decTOTAL_DUE * decTAX_RATE);                            //If true multiply by our constant decTAX_RATE
            }
            else                                                                        //If false value set to 0m
            {
                decTaxAmount = 0m;
            }
            return decTaxAmount;                                                        //Return value set by method
        }
        // Get handling fee method 
        private decimal GetHandlingFee()
        {
            switch (intNumberOfItems)                                                   //Begin switch for case method
            {
                case 1:
                case 2:                                                                 //if value is 2 or less
                    decHandlingCost = 1.5m;
                    break;
                case 3:
                case 4:                                                                 //if value is 3 or 4
                    decHandlingCost = 2.75m;
                    break;
                default:                                                                //if value is other (greater then 5)
                    decHandlingCost = 5.5m;
                    break;
            }
            return decHandlingCost;                                                     //Return case value of decHandlingCost
        }
        // Get shipping charge method 
        private decimal GetShippingCharge()
        {
            decimal decShippingCost;                                                    //Local variable for method

            if (rdoExpress.Checked)                                                     //Test data
            {
                decShippingCost = 13.25m;                                               //If true (checked) cost 13.25
            }
            else
            {
                decShippingCost = 5.75m;                                                //If false cost 5.75
            }

            return decShippingCost;                                                     //Return value determined in method
        }
        // Get discount for new customer
        private decimal GetDiscount()
        {
            decimal decDiscount;                                                        //Local variable for method

            if (chkNew.Checked)                                                         //Test data
            {
                decDiscount = decTOTAL_DUE * decNEW_DISCOUNT;                           //If true (checked) apply constant decNEW_DISCOUNT 
            }
            else
            {
                decDiscount = 0m;                                                       //If false, set decDiscount to 0m
            }
            return decDiscount;
        }

        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            if (txtCity.Text == "")                                                     //If null value,
            {
                MessageBox.Show("City required", "Input required");                     //then show error message.
                grpCustomer.Enabled = true;                                             //Enable group box for customer             
                txtName.Focus();                                                        //Set focus to txtName
                e.Cancel = true;
            }
        }

        private void txtStreet_Validating(object sender, CancelEventArgs e)
        {
            if (txtStreet.Text == "")                                                   //If null value,                                          
            {
                MessageBox.Show("Street required", "Input required");                   //Then show error message.
                grpCustomer.Enabled = true;                                             //Enable group box for customer 
                txtStreet.Focus();                                                      //Set focus to txtStreet
                e.Cancel = true;
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text == "")                                                     //If null value,
            {
                MessageBox.Show("Name required", "Input required");                     //then show error message.                
                grpCustomer.Enabled = true;                                             //Enable customer group box
                txtName.Focus();                                                        //Return focus to txtName
                e.Cancel = true;
            }
        }

        private void mskZip_Validating(object sender, CancelEventArgs e)
        {
            if (mskZip.Text.Trim(' ', '-') == "")
            {
                MessageBox.Show("Zip code required", "Input required");                 //then show error message.
                grpCustomer.Enabled = true;                                             //Enable customer group box
                mskZip.Focus();                                                         //Set focus to mskZip
                mskZip.SelectAll();                                                     
                e.Cancel = true;
            }
        }

    }
}