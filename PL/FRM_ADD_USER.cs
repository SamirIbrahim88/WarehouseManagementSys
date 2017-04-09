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
    public partial class FRM_ADD_USER : Form
    {
        public FRM_ADD_USER()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (TXTUSER.Text == string.Empty || TXTPASS.Text == string.Empty || TXTFULLNAME.Text == string.Empty || TXTCONFIRM.Text == string.Empty)
            {
                MessageBox.Show("برجاء ادخال جميع البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            if (TXTPASS.Text != TXTCONFIRM.Text)
            {
                MessageBox.Show("برجاء ادخال كلمه السر متطابقه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnsave.Text == "حفظ المستخدم")
            {
                BL.CLS_LOGIN USER = new BL.CLS_LOGIN();
                USER.ADD_USER(TXTUSER.Text, TXTFULLNAME.Text, TXTPASS.Text, comboBox1.Text);
                MessageBox.Show("تم انشاء المستخدم بنجاح", "اضافه مستخدم جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(btnsave.Text == "تعديل المستخدم")
            {
                 BL.CLS_LOGIN USER = new BL.CLS_LOGIN();
                USER.EDITUSER(TXTUSER.Text, TXTFULLNAME.Text, TXTPASS.Text, comboBox1.Text);
                MessageBox.Show("تم تعديل المستخدم بنجاح", "  تعديل مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            TXTUSER.Clear();
            TXTFULLNAME.Clear();
            TXTPASS.Clear();
            TXTCONFIRM.Clear();
            TXTUSER.Focus();
 
        }

        private void TXTCONFIRM_Validated(object sender, EventArgs e)
        {
            if (TXTPASS.Text != TXTCONFIRM.Text)
            {
                MessageBox.Show("برجاء ادخال كلمه السر متطابقه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXTCONFIRM.Focus();
                TXTCONFIRM.SelectionStart = 0;
                TXTCONFIRM.SelectionLength = TXTCONFIRM.TextLength;
            }
        }

        private void TXTUSER_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXTFULLNAME.Focus();
            }
        }

        private void TXTFULLNAME_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXTPASS.Focus();
            }
        }

        private void TXTPASS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TXTCONFIRM.Focus();
            }
        }

        private void TXTCONFIRM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox1.Focus();
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsave.Focus();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
              try
            {
              
            if (TXTUSER.Text == string.Empty || TXTPASS.Text == string.Empty || TXTFULLNAME.Text == string.Empty || TXTCONFIRM.Text == string.Empty)
            {
                MessageBox.Show("برجاء ادخال جميع البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TXTPASS.Text != TXTCONFIRM.Text)
            {
                MessageBox.Show("برجاء ادخال كلمه السر متطابقه", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnsave.Text == "حفظ المستخدم")
            {
                BL.CLS_LOGIN USER = new BL.CLS_LOGIN();
                USER.ADD_USER(TXTUSER.Text, TXTFULLNAME.Text, TXTPASS.Text, comboBox1.Text);
                MessageBox.Show("تم انشاء المستخدم بنجاح", "اضافه مستخدم جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (btnsave.Text == "تعديل المستخدم")
            {
                BL.CLS_LOGIN USER = new BL.CLS_LOGIN();
                USER.EDITUSER(TXTUSER.Text, TXTFULLNAME.Text, TXTPASS.Text, comboBox1.Text);
                MessageBox.Show("تم تعديل المستخدم بنجاح", "  تعديل مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            TXTUSER.Clear();
            TXTFULLNAME.Clear();
            TXTPASS.Clear();
            TXTCONFIRM.Clear();
            TXTUSER.Focus();
            }
              catch
              {
                  MessageBox.Show("اسم المستخدم موجود من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  TXTUSER.Focus();
                  TXTUSER.SelectionStart = 0;
                  TXTUSER.SelectionLength = TXTUSER.TextLength;
                  return;


              }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
