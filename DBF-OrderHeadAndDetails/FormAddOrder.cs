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
    public partial class FormAddOrder : Form
    {
        public FormAddOrder()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        private void AddOrder_Load(object sender, EventArgs e)
        {
            FillCustomer();
            FillEmployee();
            FillShipVia();
        }

        private void FillCustomer()
        {
            var cst = db.Customers.ToList();
            cmbCustomer.DisplayMember = "CompanyName";
            cmbCustomer.ValueMember = "CustomerID";
            cmbCustomer.DataSource = cst;
        }

        private void FillEmployee()
        {
            var emp = db.Employees.Select(x =>
            new
            {
                x.EmployeeID,
                FullName = x.FirstName + " " + x.LastName

            }).ToList();

            cmbEmployee.DisplayMember = "FullName";
            cmbEmployee.ValueMember = "EmployeeID";
            cmbEmployee.DataSource = emp;

        }
        
        private void FillShipVia()
        {
            var shipVia = db.Shippers.ToList();
            cmbShipVia.DisplayMember = "CompanyName";
            cmbShipVia.ValueMember = "ShipperID";
            cmbShipVia.DataSource = shipVia;
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
                txtAdress.Text = item.Address;
                txtCityCountry.Text = item.CityAndCountry;
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            Order order1 = new Order();
            order1.CustomerID = cmbCustomer.SelectedValue.ToString();
            order1.EmployeeID = Convert.ToInt32(cmbEmployee.SelectedValue);
            order1.OrderDate = dtpOrderDate.Value;
            order1.RequiredDate = dtpRequiredDate.Value;
            order1.ShipVia = Convert.ToInt32(cmbShipVia.SelectedValue);
            order1.Freight = Convert.ToDecimal(txtFreight.Text);
            db.Orders.Add(order1);
            db.SaveChanges();

            FormOrderHeaderDetail frmOrderDetails = new FormOrderHeaderDetail(order1.OrderID);
            frmOrderDetails.Show();
            this.Hide();
            
        }
    }
}
