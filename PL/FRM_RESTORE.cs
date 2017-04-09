using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WarehouseManagementSystem1.PL
{
    public partial class FRM_RESTORE : Form
    {
        SqlConnection con = new SqlConnection(@"server=.\SQEXPRLESS;DataBase=PRODUCT_DB;integrated security=true");
        SqlCommand cmd;
        public FRM_RESTORE()
        {
            InitializeComponent();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string strquery = "ALTER Database PRODUCT_DB  SET OFFLINE WITH ROLLBACK IMMEDIATE;Restore Database PRODUCT_DB from Disk='" + textBox1.Text + "'";
                cmd = new SqlCommand(strquery, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم استعاده النسخه بنجاح", "استعاده النسخه الاحتياطيه", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
