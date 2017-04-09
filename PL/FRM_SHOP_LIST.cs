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
    public partial class FRM_SHOP_LIST : Form
    {
        BL.CLS_SHOP SHOP = new BL.CLS_SHOP();
        public FRM_SHOP_LIST()
        {
            InitializeComponent();
            this.DGVSHOP.DataSource = SHOP.SEARCHSHOP("");
        }

        private void FRM_SHOP_LIST_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.DGVSHOP.DataSource = SHOP.SEARCHSHOP(textBox1.Text);
            }
            catch
            {
                return;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            int ID_SHOP = Convert.ToInt32(DGVSHOP.CurrentRow.Cells[0].Value);
            RPT.RPT_SHOP REPORT = new RPT.RPT_SHOP();
            RPT.FRM_RPT_PRODUCT FRM = new RPT.FRM_RPT_PRODUCT();
            REPORT.SetDataSource(SHOP.GET_SHOP_DETAILS(ID_SHOP));
            FRM.crystalReportViewer1.ReportSource = REPORT;
            FRM.ShowDialog();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
