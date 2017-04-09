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
    public partial class FRM_USER_LIST : Form
    {
        BL.CLS_LOGIN login = new BL.CLS_LOGIN();
        public FRM_USER_LIST()
        {
            InitializeComponent();
            this.dgvusers.DataSource = login.SEARCHUSER("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER frm = new FRM_ADD_USER();
            frm.btnsave.Text = "حفظ المستخدم";
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER frm = new FRM_ADD_USER();
            frm.TXTUSER.Text = dgvusers.CurrentRow.Cells[0].Value.ToString();
            frm.TXTFULLNAME.Text = dgvusers.CurrentRow.Cells[1].Value.ToString();
            frm.TXTPASS.Text = dgvusers.CurrentRow.Cells[2].Value.ToString();
            frm.TXTCONFIRM.Text = dgvusers.CurrentRow.Cells[2].Value.ToString();
            frm.comboBox1.Text = dgvusers.CurrentRow.Cells[3].Value.ToString();
            frm.btnsave.Text = "تعديل المستخدم";
            frm.ShowDialog();
            this.dgvusers.DataSource = login.SEARCHUSER("");

        }

        private void FRM_USER_LIST_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.dgvusers.DataSource = login.SEARCHUSER(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
       if (MessageBox.Show("هل تريد فعلا الحذف", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                login.DELETEUSER(dgvusers.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت الحذف بنجاح", "الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.dgvusers.DataSource = login.SEARCHUSER(textBox1.Text);

            }

        }
    }
}
