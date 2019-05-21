namespace DBF_OrderHeadAndDetails
{
    partial class FormAddOrder
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
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblRequiredDate = new System.Windows.Forms.Label();
            this.lblShipVia = new System.Windows.Forms.Label();
            this.lblFreight = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.cmbShipVia = new System.Windows.Forms.ComboBox();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtCityCountry = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCityCountry = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(57, 50);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(60, 13);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer : ";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(57, 100);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(62, 13);
            this.lblEmployee.TabIndex = 1;
            this.lblEmployee.Text = "Employee : ";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(49, 150);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(68, 13);
            this.lblOrderDate.TabIndex = 2;
            this.lblOrderDate.Text = "Order Date : ";
            // 
            // lblRequiredDate
            // 
            this.lblRequiredDate.AutoSize = true;
            this.lblRequiredDate.Location = new System.Drawing.Point(32, 200);
            this.lblRequiredDate.Name = "lblRequiredDate";
            this.lblRequiredDate.Size = new System.Drawing.Size(85, 13);
            this.lblRequiredDate.TabIndex = 3;
            this.lblRequiredDate.Text = "Required Date : ";
            // 
            // lblShipVia
            // 
            this.lblShipVia.AutoSize = true;
            this.lblShipVia.Location = new System.Drawing.Point(62, 250);
            this.lblShipVia.Name = "lblShipVia";
            this.lblShipVia.Size = new System.Drawing.Size(55, 13);
            this.lblShipVia.TabIndex = 4;
            this.lblShipVia.Text = "Ship Via : ";
            // 
            // lblFreight
            // 
            this.lblFreight.AutoSize = true;
            this.lblFreight.Location = new System.Drawing.Point(69, 300);
            this.lblFreight.Name = "lblFreight";
            this.lblFreight.Size = new System.Drawing.Size(48, 13);
            this.lblFreight.TabIndex = 5;
            this.lblFreight.Text = "Freight : ";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(140, 47);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(121, 21);
            this.cmbCustomer.TabIndex = 6;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(140, 97);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(121, 21);
            this.cmbEmployee.TabIndex = 7;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(140, 150);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(121, 20);
            this.dtpOrderDate.TabIndex = 8;
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRequiredDate.Location = new System.Drawing.Point(140, 200);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(121, 20);
            this.dtpRequiredDate.TabIndex = 9;
            // 
            // cmbShipVia
            // 
            this.cmbShipVia.FormattingEnabled = true;
            this.cmbShipVia.Location = new System.Drawing.Point(140, 247);
            this.cmbShipVia.Name = "cmbShipVia";
            this.cmbShipVia.Size = new System.Drawing.Size(121, 21);
            this.cmbShipVia.TabIndex = 10;
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(140, 297);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(121, 20);
            this.txtFreight.TabIndex = 11;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(388, 50);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(150, 71);
            this.txtAdress.TabIndex = 12;
            // 
            // txtCityCountry
            // 
            this.txtCityCountry.Location = new System.Drawing.Point(388, 168);
            this.txtCityCountry.Name = "txtCityCountry";
            this.txtCityCountry.Size = new System.Drawing.Size(150, 20);
            this.txtCityCountry.TabIndex = 13;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(319, 53);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(54, 13);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Address : ";
            // 
            // lblCityCountry
            // 
            this.lblCityCountry.AutoSize = true;
            this.lblCityCountry.Location = new System.Drawing.Point(279, 171);
            this.lblCityCountry.Name = "lblCityCountry";
            this.lblCityCountry.Size = new System.Drawing.Size(94, 13);
            this.lblCityCountry.TabIndex = 15;
            this.lblCityCountry.Text = "City And Country : ";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(411, 247);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(104, 41);
            this.btnAddOrder.TabIndex = 16;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 351);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.lblCityCountry);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtCityCountry);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.cmbShipVia);
            this.Controls.Add(this.dtpRequiredDate);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.lblFreight);
            this.Controls.Add(this.lblShipVia);
            this.Controls.Add(this.lblRequiredDate);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblCustomer);
            this.Name = "AddOrder";
            this.Text = "Add Order";
            this.Load += new System.EventHandler(this.AddOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblRequiredDate;
        private System.Windows.Forms.Label lblShipVia;
        private System.Windows.Forms.Label lblFreight;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.DateTimePicker dtpRequiredDate;
        private System.Windows.Forms.ComboBox cmbShipVia;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtCityCountry;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCityCountry;
        private System.Windows.Forms.Button btnAddOrder;
    }
}