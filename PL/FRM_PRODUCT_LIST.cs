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
    public partial class FRM_PRODUCT_LIST : Form
    {
        BL.CLS_PRODUCTS PRD = new BL.CLS_PRODUCTS();
        public FRM_PRODUCT_LIST()
        {
            InitializeComponent();
            this.datagridview.DataSource = PRD.GET_ALL_PRODUCT();
            datagridview.Columns[5].Visible = false; 
        }

        private void FRM_PRODUCT_LIST_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
