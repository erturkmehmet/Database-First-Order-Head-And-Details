namespace DBF_OrderHeadAndDetails
{
    partial class FormOrderHeaderDetail
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
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.cmbShipVia = new System.Windows.Forms.ComboBox();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCityCountry = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewOrderDetail = new System.Windows.Forms.DataGridView();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblShipVia = new System.Windows.Forms.Label();
            this.lblFreight = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.btnInsertOrderDetail = new System.Windows.Forms.Button();
            this.btnDeleteOrderDetail = new System.Windows.Forms.Button();
            this.UpdateOrderDetail = new System.Windows.Forms.Button();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.lblRequiredDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(12, 45);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(121, 20);
            this.txtOrderID.TabIndex = 0;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(163, 45);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(121, 21);
            this.cmbCustomer.TabIndex = 1;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(314, 45);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(121, 21);
            this.cmbEmployee.TabIndex = 2;
            // 
            // cmbShipVia
            // 
            this.cmbShipVia.FormattingEnabled = true;
            this.cmbShipVia.Location = new System.Drawing.Point(767, 45);
            this.cmbShipVia.Name = "cmbShipVia";
            this.cmbShipVia.Size = new System.Drawing.Size(121, 21);
            this.cmbShipVia.TabIndex = 5;
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(918, 46);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(121, 20);
            this.txtFreight.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(163, 87);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(121, 80);
            this.txtAddress.TabIndex = 7;
            // 
            // txtCityCountry
            // 
            this.txtCityCountry.Location = new System.Drawing.Point(163, 182);
            this.txtCityCountry.Name = "txtCityCountry";
            this.txtCityCountry.Size = new System.Drawing.Size(121, 20);
            this.txtCityCountry.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1059, 23);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewOrderDetail
            // 
            this.dataGridViewOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetail.Location = new System.Drawing.Point(21, 288);
            this.dataGridViewOrderDetail.Name = "dataGridViewOrderDetail";
            this.dataGridViewOrderDetail.Size = new System.Drawing.Size(736, 216);
            this.dataGridViewOrderDetail.TabIndex = 10;
            this.dataGridViewOrderDetail.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewOrderDetail_CellMouseClick);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(792, 169);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(121, 33);
            this.btnUpdateOrder.TabIndex = 11;
            this.btnUpdateOrder.Text = "Update Order";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(928, 169);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(121, 33);
            this.btnDeleteOrder.TabIndex = 12;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(50, 9);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(44, 13);
            this.lblOrderID.TabIndex = 13;
            this.lblOrderID.Text = "OrderID";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(191, 9);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(51, 13);
            this.lblCustomer.TabIndex = 14;
            this.lblCustomer.Text = "Customer";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(349, 9);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(53, 13);
            this.lblEmployee.TabIndex = 15;
            this.lblEmployee.Text = "Employee";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(492, 9);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(59, 13);
            this.lblOrderDate.TabIndex = 16;
            this.lblOrderDate.Text = "Order Date";
            // 
            // lblShipVia
            // 
            this.lblShipVia.AutoSize = true;
            this.lblShipVia.Location = new System.Drawing.Point(799, 9);
            this.lblShipVia.Name = "lblShipVia";
            this.lblShipVia.Size = new System.Drawing.Size(46, 13);
            this.lblShipVia.TabIndex = 18;
            this.lblShipVia.Text = "Ship Via";
            // 
            // lblFreight
            // 
            this.lblFreight.AutoSize = true;
            this.lblFreight.Location = new System.Drawing.Point(944, 9);
            this.lblFreight.Name = "lblFreight";
            this.lblFreight.Size = new System.Drawing.Size(39, 13);
            this.lblFreight.TabIndex = 19;
            this.lblFreight.Text = "Freight";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(18, 552);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(79, 13);
            this.lblTotalAmount.TabIndex = 20;
            this.lblTotalAmount.Text = "Total Amount : ";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(799, 316);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(55, 13);
            this.lblQuantity.TabIndex = 21;
            this.lblQuantity.Text = "Quantity : ";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(102, 549);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAmount.TabIndex = 22;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(799, 366);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(56, 13);
            this.lblProduct.TabIndex = 23;
            this.lblProduct.Text = "Product :  ";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(874, 313);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(121, 20);
            this.txtQuantity.TabIndex = 24;
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(874, 363);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(121, 21);
            this.cmbProduct.TabIndex = 25;
            // 
            // btnInsertOrderDetail
            // 
            this.btnInsertOrderDetail.Location = new System.Drawing.Point(838, 436);
            this.btnInsertOrderDetail.Name = "btnInsertOrderDetail";
            this.btnInsertOrderDetail.Size = new System.Drawing.Size(141, 36);
            this.btnInsertOrderDetail.TabIndex = 26;
            this.btnInsertOrderDetail.Text = "Insert OrderDetail";
            this.btnInsertOrderDetail.UseVisualStyleBackColor = true;
            this.btnInsertOrderDetail.Click += new System.EventHandler(this.btnInsertOrderDetail_Click);
            // 
            // btnDeleteOrderDetail
            // 
            this.btnDeleteOrderDetail.Location = new System.Drawing.Point(838, 487);
            this.btnDeleteOrderDetail.Name = "btnDeleteOrderDetail";
            this.btnDeleteOrderDetail.Size = new System.Drawing.Size(141, 36);
            this.btnDeleteOrderDetail.TabIndex = 27;
            this.btnDeleteOrderDetail.Text = "Delete OrderDetail";
            this.btnDeleteOrderDetail.UseVisualStyleBackColor = true;
            this.btnDeleteOrderDetail.Click += new System.EventHandler(this.btnDeleteOrderDetail_Click);
            // 
            // UpdateOrderDetail
            // 
            this.UpdateOrderDetail.Location = new System.Drawing.Point(838, 540);
            this.UpdateOrderDetail.Name = "UpdateOrderDetail";
            this.UpdateOrderDetail.Size = new System.Drawing.Size(141, 36);
            this.UpdateOrderDetail.TabIndex = 28;
            this.UpdateOrderDetail.Text = "Update OrderDetail";
            this.UpdateOrderDetail.UseVisualStyleBackColor = true;
            this.UpdateOrderDetail.Click += new System.EventHandler(this.UpdateOrderDetail_Click);
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(466, 45);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(121, 20);
            this.dtpOrderDate.TabIndex = 29;
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRequiredDate.Location = new System.Drawing.Point(615, 46);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(121, 20);
            this.dtpRequiredDate.TabIndex = 30;
            // 
            // lblRequiredDate
            // 
            this.lblRequiredDate.AutoSize = true;
            this.lblRequiredDate.Location = new System.Drawing.Point(639, 9);
            this.lblRequiredDate.Name = "lblRequiredDate";
            this.lblRequiredDate.Size = new System.Drawing.Size(76, 13);
            this.lblRequiredDate.TabIndex = 31;
            this.lblRequiredDate.Text = "Required Date";
            // 
            // FormOrderHeaderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 594);
            this.Controls.Add(this.lblRequiredDate);
            this.Controls.Add(this.dtpRequiredDate);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.UpdateOrderDetail);
            this.Controls.Add(this.btnDeleteOrderDetail);
            this.Controls.Add(this.btnInsertOrderDetail);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblFreight);
            this.Controls.Add(this.lblShipVia);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.dataGridViewOrderDetail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCityCountry);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.cmbShipVia);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.txtOrderID);
            this.Name = "FormOrderHeaderDetail";
            this.Text = "FormOrderDetails";
            this.Load += new System.EventHandler(this.FormOrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.ComboBox cmbShipVia;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCityCountry;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetail;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblShipVia;
        private System.Windows.Forms.Label lblFreight;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Button btnInsertOrderDetail;
        private System.Windows.Forms.Button btnDeleteOrderDetail;
        private System.Windows.Forms.Button UpdateOrderDetail;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.DateTimePicker dtpRequiredDate;
        private System.Windows.Forms.Label lblRequiredDate;
    }
}