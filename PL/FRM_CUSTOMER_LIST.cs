using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WarehouseManagementSystem1.PL
{
    public partial class FRM_CUSTOMER_LIST : Form
    {
        BL.CLS_CUSTOMER cust = new BL.CLS_CUSTOMER();
        public FRM_CUSTOMER_LIST()
        {
            InitializeComponent();
            this.DGVCUSTOMER.DataSource = cust.GET_ALL_CUSTOMER();
            this.DGVCUSTOMER.Columns[0].Visible = false;
            this.DGVCUSTOMER.Columns[5].Visible = false;
        }

        private void FRM_CUSTOMER_LIST_Load(object sender, EventArgs e)
        {

        }

        private void DGVCUSTOMER_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DGVCUSTOMER_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
