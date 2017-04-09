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
    public partial class FRM_BACKUP : Form
    {
        SqlConnection con = new SqlConnection(@"server=.\SQEXPRLESS;DataBase=PRODUCT_DB;integrated security=true");
        SqlCommand cmd;
        public FRM_BACKUP()
        {
            InitializeComponent();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void FRM_BACKUP_Load(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = textBox1.Text + "\\PRODUCT_DB" + DateTime.Now.ToShortDateString().Replace('/', '_')
                                    + "_" + DateTime.Now.ToLongTimeString().Replace(':', '_');

                string strquery = "Backup Database PRODUCT_DB to Disk='" + filename + ".bak'";
                cmd = new SqlCommand(strquery, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("تم انشاء النسخه بنجاح", "انشاء نسخه احتياطيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
