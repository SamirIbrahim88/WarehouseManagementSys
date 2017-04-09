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
    public partial class FRM_CONFIG : Form
    {
        public FRM_CONFIG()
        {
            InitializeComponent();
            TXTSERVER.Text = Properties.Settings.Default.Server;
            TXTDATABASE.Text = Properties.Settings.Default.DataBase;
            if(Properties.Settings.Default.Mode=="SQL")
            {
                rbsql.Checked=true;
                txtid.Text = Properties.Settings.Default.Id;
                txtpsw.Text = Properties.Settings.Default.Password;
            }
            else
            {
                RBWINDOWS.Checked=true;
                txtid.Clear();
                txtpsw.Clear();
                txtid.ReadOnly=true;
                txtpsw.ReadOnly=true;
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = TXTSERVER.Text;
            Properties.Settings.Default.DataBase = TXTDATABASE.Text;
            Properties.Settings.Default.Mode = rbsql.Checked == true ? "SQL" : "Windows";
            Properties.Settings.Default.Id = txtid.Text;
            Properties.Settings.Default.Password = txtpsw.Text;
            Properties.Settings.Default.Save(); 




        }

        private void rbsql_CheckedChanged(object sender, EventArgs e)
        {
            txtid.ReadOnly = true;
            txtpsw.ReadOnly = true;
        }
    }
}
