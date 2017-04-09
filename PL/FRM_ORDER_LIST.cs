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
    public partial class FRM_ORDER_LIST : Form
    {
        BL.CLS_ORDER ORDER = new BL.CLS_ORDER();
        public FRM_ORDER_LIST()
        {
            InitializeComponent();
            this.DGVORDER.DataSource = ORDER.SEARCHORDERS("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_ORDER_LIST_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.DGVORDER.DataSource = ORDER.SEARCHORDERS(textBox1.Text);
            }
            catch
            {
                return;
            }
        }
        private void buttonX3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnprint_Click(object sender, EventArgs e)
        {
            
            int ID_ORDER = Convert.ToInt32(DGVORDER.CurrentRow.Cells[0].Value);
            RPT.RPT_ORDER REPORT = new RPT.RPT_ORDER();
            RPT.FRM_RPT_PRODUCT FRM = new RPT.FRM_RPT_PRODUCT();
            REPORT.SetDataSource(ORDER.GET_ORDER_DETAILS(ID_ORDER));
            FRM.crystalReportViewer1.ReportSource = REPORT;
            FRM.ShowDialog();
            
        }

        private void DGVORDER_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
