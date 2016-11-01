namespace Assignment3
{
    partial class frmAssigment4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.chkNew = new System.Windows.Forms.CheckBox();
            this.mskZip = new System.Windows.Forms.MaskedTextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblProgrammer = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpShipping = new System.Windows.Forms.GroupBox();
            this.rdoGround = new System.Windows.Forms.RadioButton();
            this.rdoExpress = new System.Windows.Forms.RadioButton();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.rdoCod = new System.Windows.Forms.RadioButton();
            this.rdoCharge = new System.Windows.Forms.RadioButton();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtShipping = new System.Windows.Forms.TextBox();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.btnSummary = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtfLink = new System.Windows.Forms.RichTextBox();
            this.grpCustomer.SuspendLayout();
            this.grpOrder.SuspendLayout();
            this.grpShipping.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.grpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.txtState);
            this.grpCustomer.Controls.Add(this.chkNew);
            this.grpCustomer.Controls.Add(this.mskZip);
            this.grpCustomer.Controls.Add(this.lblZip);
            this.grpCustomer.Controls.Add(this.lblState);
            this.grpCustomer.Controls.Add(this.txtCity);
            this.grpCustomer.Controls.Add(this.txtStreet);
            this.grpCustomer.Controls.Add(this.txtName);
            this.grpCustomer.Controls.Add(this.lblCity);
            this.grpCustomer.Controls.Add(this.lblStreet);
            this.grpCustomer.Controls.Add(this.lblName);
            this.grpCustomer.Location = new System.Drawing.Point(22, 12);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(622, 161);
            this.grpCustomer.TabIndex = 0;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer";
            // 
            // txtState
            // 
            this.txtState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtState.Location = new System.Drawing.Point(409, 107);
            this.txtState.MaxLength = 2;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(33, 20);
            this.txtState.TabIndex = 7;
            this.txtState.Text = "WA";
            // 
            // chkNew
            // 
            this.chkNew.AutoSize = true;
            this.chkNew.Checked = true;
            this.chkNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNew.Location = new System.Drawing.Point(496, 31);
            this.chkNew.Name = "chkNew";
            this.chkNew.Size = new System.Drawing.Size(95, 17);
            this.chkNew.TabIndex = 6;
            this.chkNew.Text = "New Customer";
            this.chkNew.UseVisualStyleBackColor = true;
            // 
            // mskZip
            // 
            this.mskZip.Location = new System.Drawing.Point(530, 107);
            this.mskZip.Mask = "00000-9999";
            this.mskZip.Name = "mskZip";
            this.mskZip.Size = new System.Drawing.Size(65, 20);
            this.mskZip.TabIndex = 8;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(476, 114);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(53, 13);
            this.lblZip.TabIndex = 8;
            this.lblZip.Text = "&Zip Code:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(367, 115);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "Stat&e:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(82, 108);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(262, 20);
            this.txtCity.TabIndex = 5;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(82, 67);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(379, 20);
            this.txtStreet.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(82, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(379, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(6, 115);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "C&ity:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(6, 74);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 1;
            this.lblStreet.Text = "S&treet:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "&Name:";
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.lblRate);
            this.grpOrder.Controls.Add(this.txtPrice);
            this.grpOrder.Controls.Add(this.txtQuantity);
            this.grpOrder.Controls.Add(this.txtDescription);
            this.grpOrder.Controls.Add(this.lblPrice);
            this.grpOrder.Controls.Add(this.lblQuantity);
            this.grpOrder.Controls.Add(this.lblDescription);
            this.grpOrder.Location = new System.Drawing.Point(22, 185);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(382, 133);
            this.grpOrder.TabIndex = 1;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(164, 70);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(80, 13);
            this.lblRate.TabIndex = 6;
            this.lblRate.Text = "Tax Rate: 8.7%";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(75, 98);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(75, 63);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(48, 20);
            this.txtQuantity.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(75, 26);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(268, 20);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(9, 105);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "P&rice:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(9, 70);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "&Quantity:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 33);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "&Description:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 466);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "&Add Order";
            this.toolTip1.SetToolTip(this.btnAdd, "Add current price to Total due.");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(203, 466);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear All";
            this.toolTip1.SetToolTip(this.btnClear, "Clears form.");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(284, 466);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "Exits form.");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(9, 103);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total Amount";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(155, 100);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(177, 20);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TabStop = false;
            // 
            // lblProgrammer
            // 
            this.lblProgrammer.AutoSize = true;
            this.lblProgrammer.Location = new System.Drawing.Point(433, 476);
            this.lblProgrammer.Name = "lblProgrammer";
            this.lblProgrammer.Size = new System.Drawing.Size(190, 13);
            this.lblProgrammer.TabIndex = 7;
            this.lblProgrammer.Text = "Program by: Vu Le and Gerald Williams";
            // 
            // grpShipping
            // 
            this.grpShipping.Controls.Add(this.rdoGround);
            this.grpShipping.Controls.Add(this.rdoExpress);
            this.grpShipping.Location = new System.Drawing.Point(417, 185);
            this.grpShipping.Name = "grpShipping";
            this.grpShipping.Size = new System.Drawing.Size(108, 133);
            this.grpShipping.TabIndex = 2;
            this.grpShipping.TabStop = false;
            this.grpShipping.Text = "Shipping";
            // 
            // rdoGround
            // 
            this.rdoGround.AutoSize = true;
            this.rdoGround.Location = new System.Drawing.Point(6, 84);
            this.rdoGround.Name = "rdoGround";
            this.rdoGround.Size = new System.Drawing.Size(60, 17);
            this.rdoGround.TabIndex = 1;
            this.rdoGround.Text = "Ground";
            this.rdoGround.UseVisualStyleBackColor = true;
            // 
            // rdoExpress
            // 
            this.rdoExpress.AutoSize = true;
            this.rdoExpress.Checked = true;
            this.rdoExpress.Location = new System.Drawing.Point(6, 33);
            this.rdoExpress.Name = "rdoExpress";
            this.rdoExpress.Size = new System.Drawing.Size(62, 17);
            this.rdoExpress.TabIndex = 0;
            this.rdoExpress.TabStop = true;
            this.rdoExpress.Text = "Express";
            this.rdoExpress.UseVisualStyleBackColor = true;
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.radioButton5);
            this.grpPayment.Controls.Add(this.rdoCod);
            this.grpPayment.Controls.Add(this.rdoCharge);
            this.grpPayment.Location = new System.Drawing.Point(531, 185);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(113, 133);
            this.grpPayment.TabIndex = 3;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Payment Type";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 98);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(86, 17);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.Text = "Money Order";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // rdoCod
            // 
            this.rdoCod.AutoSize = true;
            this.rdoCod.Location = new System.Drawing.Point(7, 63);
            this.rdoCod.Name = "rdoCod";
            this.rdoCod.Size = new System.Drawing.Size(48, 17);
            this.rdoCod.TabIndex = 1;
            this.rdoCod.Text = "COD";
            this.rdoCod.UseVisualStyleBackColor = true;
            // 
            // rdoCharge
            // 
            this.rdoCharge.AutoSize = true;
            this.rdoCharge.Checked = true;
            this.rdoCharge.Location = new System.Drawing.Point(7, 26);
            this.rdoCharge.Name = "rdoCharge";
            this.rdoCharge.Size = new System.Drawing.Size(59, 17);
            this.rdoCharge.TabIndex = 0;
            this.rdoCharge.TabStop = true;
            this.rdoCharge.Text = "Charge";
            this.rdoCharge.UseVisualStyleBackColor = true;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.txtAmount);
            this.grpSummary.Controls.Add(this.txtShipping);
            this.grpSummary.Controls.Add(this.txtSalesTax);
            this.grpSummary.Controls.Add(this.lblAmount);
            this.grpSummary.Controls.Add(this.lblSalesTax);
            this.grpSummary.Controls.Add(this.lblShipping);
            this.grpSummary.Controls.Add(this.lblTotal);
            this.grpSummary.Controls.Add(this.txtTotal);
            this.grpSummary.Location = new System.Drawing.Point(22, 325);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(348, 135);
            this.grpSummary.TabIndex = 10;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Summary";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(155, 21);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(177, 20);
            this.txtAmount.TabIndex = 12;
            this.txtAmount.TabStop = false;
            // 
            // txtShipping
            // 
            this.txtShipping.Location = new System.Drawing.Point(155, 73);
            this.txtShipping.Name = "txtShipping";
            this.txtShipping.ReadOnly = true;
            this.txtShipping.Size = new System.Drawing.Size(177, 20);
            this.txtShipping.TabIndex = 11;
            this.txtShipping.TabStop = false;
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.Location = new System.Drawing.Point(155, 47);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.ReadOnly = true;
            this.txtSalesTax.Size = new System.Drawing.Size(177, 20);
            this.txtSalesTax.TabIndex = 10;
            this.txtSalesTax.TabStop = false;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(9, 26);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(66, 13);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "Amount Due";
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.AutoSize = true;
            this.lblSalesTax.Location = new System.Drawing.Point(9, 50);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(54, 13);
            this.lblSalesTax.TabIndex = 8;
            this.lblSalesTax.Text = "Sales Tax";
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Location = new System.Drawing.Point(9, 76);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(114, 13);
            this.lblShipping.TabIndex = 7;
            this.lblShipping.Text = "Shipping and Handling";
            // 
            // btnSummary
            // 
            this.btnSummary.Enabled = false;
            this.btnSummary.Location = new System.Drawing.Point(114, 466);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(83, 23);
            this.btnSummary.TabIndex = 6;
            this.btnSummary.Text = "Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(404, 372);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(434, 368);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(67, 20);
            this.txtDate.TabIndex = 13;
            this.txtDate.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assignment3.Properties.Resources.seahawk;
            this.pictureBox1.Location = new System.Drawing.Point(518, 329);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // rtfLink
            // 
            this.rtfLink.Location = new System.Drawing.Point(417, 401);
            this.rtfLink.Name = "rtfLink";
            this.rtfLink.Size = new System.Drawing.Size(84, 25);
            this.rtfLink.TabIndex = 4;
            this.rtfLink.Text = "";
            this.rtfLink.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtfLink_LinkClicked);
            // 
            // frmAssigment4
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(655, 504);
            this.Controls.Add(this.rtfLink);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.grpShipping);
            this.Controls.Add(this.lblProgrammer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmAssigment4";
            this.Text = "See Sharp Mail Order";
            this.Load += new System.EventHandler(this.frmAssigment4_Load);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.grpShipping.ResumeLayout(false);
            this.grpShipping.PerformLayout();
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.MaskedTextBox mskZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblProgrammer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkNew;
        private System.Windows.Forms.GroupBox grpShipping;
        private System.Windows.Forms.RadioButton rdoGround;
        private System.Windows.Forms.RadioButton rdoExpress;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton rdoCod;
        private System.Windows.Forms.RadioButton rdoCharge;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtShipping;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox rtfLink;
        private System.Windows.Forms.TextBox txtState;
    }
}

