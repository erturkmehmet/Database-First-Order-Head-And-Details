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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void ordersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            FormAddOrder orderAdd = new FormAddOrder();
            orderAdd.Show();
            this.Hide();
        }

        private void orderEditViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrderEditView formOrderEditView = new FormOrderEditView();
            formOrderEditView.Show();
            this.Hide();
            
        }
    }
}
