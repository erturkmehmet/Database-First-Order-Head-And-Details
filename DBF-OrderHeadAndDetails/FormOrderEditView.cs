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
    public partial class FormOrderEditView : Form
    {
        public FormOrderEditView()
        {
            InitializeComponent();
        }

        int selectedOrderID;
        NorthwindEntities db = new NorthwindEntities();
        private void btnOpenOrder_Click(object sender, EventArgs e)
        {
            selectedOrderID = Convert.ToInt32(txtOrderID.Text);
            try
            {
                var conditional = db.Orders.Where(x => x.OrderID == selectedOrderID).ToList();
                if (conditional.Count == 0)
                {
                    MessageBox.Show("This ID is not avaible");
                }
                else
                {
                    FormOrderHeaderDetail formOrderDetails = new FormOrderHeaderDetail(selectedOrderID);
                    formOrderDetails.Show();
                    this.Hide();
                }
            }
            catch
            {

                MessageBox.Show("Incorrect Format");;
            }
        }
    }
}
