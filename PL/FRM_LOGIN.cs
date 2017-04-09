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
    public partial class FRM_LOGIN : Form
    {
        BL.CLS_LOGIN log = new BL.CLS_LOGIN();
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void FRM_LOGIN_Load(object sender, EventArgs e)
        {

        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpwd.Focus();
            }
        }

        private void txtpwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonX1.Focus();
            }

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DataTable dt = log.LOGIN(txtid.Text, txtpwd.Text);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][2].ToString() == "مدير")
                {
                    this.Hide();
                    FRM_MAIN frm = new FRM_MAIN();
                    Program.SALESMAN = dt.Rows[0]["FULLNAME"].ToString();
                    Program.PAYMAN = dt.Rows[0]["FULLNAME"].ToString();
                    frm.ShowDialog();
                    this.Hide();
                }
                else if (dt.Rows[0][2].ToString() == "مستخدم")
                {
                    this.Hide();
                    FRM_MAIN frm = new FRM_MAIN();
                    Program.SALESMAN = dt.Rows[0]["FULLNAME"].ToString();
                    Program.PAYMAN = dt.Rows[0]["FULLNAME"].ToString();
                    main.getmainform.المستخدمينToolStripMenuItem1.Visible = false;
                    frm.ShowDialog();
                    this.Hide();

                }
            }

            else
            {
                MessageBox.Show(" برجاء ادخال اسم المستخدم وكلمه المرور", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtid.Focus();
            }
        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reflectionLabel1_Click(object sender, EventArgs e)
        {

        }


    }
}
