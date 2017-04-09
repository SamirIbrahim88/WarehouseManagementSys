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
    public partial class FRM_TRADERS_LIST : Form
    {
        BL.CLS_TRADER TRAD = new BL.CLS_TRADER();
        public FRM_TRADERS_LIST()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = TRAD.GET_ALL_TRADERS();
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;

        }

        private void FRM_TRADERS_LIST_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
