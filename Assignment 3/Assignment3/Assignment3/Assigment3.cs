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
        //Global Constant and variable
        const decimal decTAX_RATE = 0.087m;
        private decimal decTOTAL; // 0.0m
        private decimal decTOTAL_DUE; // 0.0m
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
                decimal decQuantity, decPrice;
                //Convert text to decimal
                decQuantity = Convert.ToDecimal(txtQuantity.Text);
                decPrice = Convert.ToDecimal(txtPrice.Text);
                //Calculation (quantity times price)
                decTOTAL = decQuantity * decPrice;                                          
                //Accumulate for total due and add tax
                decTOTAL_DUE += (decTOTAL * decTAX_RATE) + decTOTAL;
                //Convert from decimal back to text to show user the final total due
                txtTotal.Text = decTOTAL_DUE.ToString("c");
                //Clear description, quantity, price then focus back to description
                txtDescription.Clear();
                txtQuantity.Clear();
                txtPrice.Clear();
                txtDescription.Focus();
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
            rdoMoney.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //reset the accumulator back to 0
            decTOTAL = 0.0m;
            decTOTAL_DUE = 0.0m;
            //Clear all data and focus back to Name
            txtName.Clear();
            txtStreet.Clear();
            txtCity.Clear();
            mskState.Clear();
            mskZip.Clear();
            txtDescription.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
            txtTotal.Clear();
            rdoMoney.Enabled = true;
            txtName.Focus();
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
    }
}
