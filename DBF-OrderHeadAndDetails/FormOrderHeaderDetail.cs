using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBF_OrderHeadAndDetails
{
    public partial class FormOrderHeaderDetail : Form
    {
        private int getOrderID;
        private Order getOrder;
        private Order_Detail selectedOrderDetail;
        private int selectedProductID;
        decimal unitPrice;

        public FormOrderHeaderDetail()
        {
            InitializeComponent();
        }
        public FormOrderHeaderDetail(int selectedOrderID)
        {
            InitializeComponent();
            getOrderID = selectedOrderID;
            getOrder = db.Orders.Find(getOrderID);
        }
        NorthwindEntities db = new NorthwindEntities();
        
        private void FormOrderDetails_Load(object sender, EventArgs e)
        {
            FillOrderHead();
            FillOrderDetail();
            txtOrderID.Enabled = true;
        }
        private void FillOrderHead()
        {
            txtOrderID.Text = getOrderID.ToString();
            txtOrderID.Enabled = false;
            txtAddress.Text = getOrder.Customer.Address;
            txtCityCountry.Text = getOrder.Customer.City + " " + getOrder.Customer.Country;
            dtpOrderDate.Value = getOrder.OrderDate.Value;
            dtpRequiredDate.Value = getOrder.RequiredDate.Value;
            txtFreight.Text = getOrder.Freight.ToString();

            //------------------Customer--------------
            var cust = db.Customers.ToList();
            cmbCustomer.DisplayMember = "CompanyName";
            cmbCustomer.ValueMember = "CustomerID";
            cmbCustomer.DataSource = cust;

            //------------------Employee---------------
            var emp = db.Employees.Select(x=>new
            {

                FullName = x.FirstName + " " + x.LastName,
                x.EmployeeID

            }).ToList();
            cmbEmployee.DisplayMember = "FullName";
            cmbEmployee.ValueMember = "EmployeeID";
            cmbEmployee.DataSource = emp;

            //------------------Ship Via----------------
            var spv = db.Shippers.ToList();
            cmbShipVia.DisplayMember = "CompanyName";
            cmbShipVia.ValueMember = "ShipperID";
            cmbShipVia.DataSource = spv;
        }

        private void FillOrderDetail()
        {
            var od = db.Order_Details.Select(x => new
            {
                x.OrderID,
                x.ProductID,
                x.Product.ProductName,
                x.UnitPrice,
                x.Quantity,
                x.Discount,
                TotalAmount = x.Quantity + x.UnitPrice

            }).Where(x=>x.OrderID == getOrderID).ToList();

            dataGridViewOrderDetail.DataSource = od;
            txtTotalAmount.Text = od.Sum(x => x.TotalAmount).ToString();

            var prod = db.Products.Select(x => new
            {
                x.UnitPrice,
                x.ProductName,
                x.ProductID

            }).ToList();
            foreach (var item in prod)
            {
                unitPrice = Convert.ToDecimal(item.UnitPrice);
            }
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductID";
            cmbProduct.DataSource = prod;

        }
        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                getOrder.CustomerID = cmbCustomer.SelectedValue.ToString();
                getOrder.EmployeeID = Convert.ToInt32(cmbEmployee.SelectedValue);
                getOrder.OrderDate = dtpOrderDate.Value;
                getOrder.RequiredDate = dtpRequiredDate.Value;
                getOrder.ShipVia = Convert.ToInt32(cmbShipVia.SelectedValue);
                getOrder.Freight = Convert.ToInt32(txtFreight.Text);
                db.SaveChanges();
                MessageBox.Show("Update successful");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            try
            {
                db.Orders.Remove(getOrder);
                db.SaveChanges();
                MessageBox.Show("Order Deleted");
            }
            catch
            {

                MessageBox.Show("                                   You cannot delete this order!!!!!. \nIf you want delete this order, firstly you must delete orders in order details");
            }
        }

        private void dataGridViewOrderDetail_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedProductID = Convert.ToInt32(dataGridViewOrderDetail.CurrentRow.Cells[1].Value);
            selectedOrderDetail = db.Order_Details.Find(getOrderID, selectedProductID);
            txtQuantity.Text = selectedOrderDetail.Quantity.ToString();
            cmbProduct.SelectedValue = selectedProductID; 
        }

        private void btnInsertOrderDetail_Click(object sender, EventArgs e)
        {
            try
            {
                Order_Detail od = new Order_Detail();
                od.OrderID = Convert.ToInt32(txtOrderID.Text);
                od.ProductID = (int)cmbProduct.SelectedValue;
                od.Quantity = Convert.ToInt16(txtQuantity.Text);

                Product prod = db.Products.Find(od.ProductID);
                od.UnitPrice = unitPrice;
                od.Discount = 0; //Güncelleme yaptığımızda yeni isimli veya miktarlı ürünün indirimini(discount) 0 yaptık.
                db.Order_Details.Add(od);
                db.SaveChanges();
                FillOrderDetail();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnDeleteOrderDetail_Click(object sender, EventArgs e)
        {
            try
            { 
            db.Order_Details.Remove(selectedOrderDetail);
            db.SaveChanges();
            FillOrderDetail();
            }
            catch (Exception)
            {

                MessageBox.Show("Please make a selections!!!!");
            }
        }
        private void UpdateOrderDetail_Click(object sender, EventArgs e)
        {
            try
            {

                if (db.Orders.Any(x => x.OrderID == getOrderID))
                {
                    db.Order_Details.Remove(selectedOrderDetail); //Önce secilen satırdaki hepsini temizler.

                    Order_Detail od = new Order_Detail();
                    od.OrderID = Convert.ToInt32(txtOrderID.Text);
                    od.ProductID = (int)cmbProduct.SelectedValue;
                    od.Quantity = Convert.ToInt16(txtQuantity.Text);

                    Product p = db.Products.Find(od.ProductID);
                    od.UnitPrice = (decimal)p.UnitPrice;
                    db.Order_Details.Add(od);
                    od.Discount = 0; //Güncelleme yaptığımızda yeni isimli veya miktarlı ürünün indirimini(discount) 0 yaptık.
                    db.SaveChanges();
                    MessageBox.Show("Update successful");
                    FillOrderDetail();
                }
                else
                {
                    MessageBox.Show("This OrderID is not available !");
                }
            }
            
            catch (Exception)
            {

                MessageBox.Show("Please make a selections!!!!");
            }
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customerID = cmbCustomer.SelectedValue.ToString();
            var address = db.Customers.Where(x => x.CustomerID == customerID).Select(x =>
            new {
                CityAndCountry = x.City + " " + x.Country,
                x.Address

            }).ToList();

            foreach (var item in address)
            {
                txtAddress.Text = item.Address;
                txtCityCountry.Text = item.CityAndCountry;
            }
        }
    }
}
