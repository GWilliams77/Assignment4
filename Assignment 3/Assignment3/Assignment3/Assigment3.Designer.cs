namespace Assignment3
{
    partial class frmAssigment3
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
            this.mskZip = new System.Windows.Forms.MaskedTextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.mskState = new System.Windows.Forms.MaskedTextBox();
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
            this.grpCustomer.SuspendLayout();
            this.grpOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.mskZip);
            this.grpCustomer.Controls.Add(this.lblZip);
            this.grpCustomer.Controls.Add(this.mskState);
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
            // mskZip
            // 
            this.mskZip.Location = new System.Drawing.Point(530, 107);
            this.mskZip.Mask = "00000-9999";
            this.mskZip.Name = "mskZip";
            this.mskZip.Size = new System.Drawing.Size(65, 20);
            this.mskZip.TabIndex = 9;
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
            // mskState
            // 
            this.mskState.Location = new System.Drawing.Point(412, 108);
            this.mskState.Mask = ">LL";
            this.mskState.Name = "mskState";
            this.mskState.Size = new System.Drawing.Size(25, 20);
            this.mskState.TabIndex = 7;
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
            this.btnAdd.Location = new System.Drawing.Point(434, 255);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(193, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "&Add Order";
            this.toolTip1.SetToolTip(this.btnAdd, "Add current price to Total due.");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(434, 295);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear All";
            this.toolTip1.SetToolTip(this.btnClear, "Clears form.");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(541, 295);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "Exits form.");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(498, 196);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total due:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(475, 212);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(110, 20);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TabStop = false;
            // 
            // lblProgrammer
            // 
            this.lblProgrammer.AutoSize = true;
            this.lblProgrammer.Location = new System.Drawing.Point(434, 325);
            this.lblProgrammer.Name = "lblProgrammer";
            this.lblProgrammer.Size = new System.Drawing.Size(190, 13);
            this.lblProgrammer.TabIndex = 7;
            this.lblProgrammer.Text = "Program by: Vu Le and Gerald Williams";
            // 
            // frmAssigment3
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(662, 350);
            this.Controls.Add(this.lblProgrammer);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.grpCustomer);
            this.Name = "frmAssigment3";
            this.Text = "See Sharp Mail Order";
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox mskState;
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
    }
}

