using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WarehouseManagementSystem1.PL
{
    public partial class add_product : Form
    {
        public string state = "add";
        BL.CLS_PRODUCTS prd = new BL.CLS_PRODUCTS();
        public add_product()
        {
            InitializeComponent();
            cmbcategories.DataSource = prd.GET_ALL_CATEGORIES();
            cmbcategories.DisplayMember= "DESCRIPTION_CAT";
            cmbcategories.ValueMember = "ID_CAT";
        }
        private void txtref_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtdes.Focus();
            }
        }
        private void txtdes_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtqte.Focus();
            }
        }
        private void txtqte_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtprice.Focus();
            }
        }
        private void txtprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ok.Focus();
            }
        }
       private void txtref_Validated_1(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable dt = new DataTable();
                dt = prd.VERIFYPRODUCTID(txtref.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("المعرف موجود من قبل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtref.Focus();
                    txtref.SelectionStart = 0;
                    txtref.SelectionLength = txtref.TextLength;
                }
            }
        }
        private void buttonX3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ImageFile|*.JPG; *.PNG; *.GIF; *.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ImageFile|*.JPG; *.PNG; *.GIF; *.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                if (txtref.Text == string.Empty)
                {
                    MessageBox.Show("يرجي التاكد من كتابه اسم الصنف ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtdes.Text == string.Empty)
                {
                    MessageBox.Show("يرجي التاكد من كتابه وصف الصنف ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtqte.Text == string.Empty)
                {
                    MessageBox.Show("يرجي التاكد من كتابه كميه الصنف الموجوده ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtprice.Text == string.Empty)
                {
                    MessageBox.Show("يرجي التاكد من كتابه سعر الصنف الحالي ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                byte[] byteImage;
                if (pictureBox1.Image == null)
                {
                    byteImage = new byte[0];
                    prd.ADD_PRODUCT(
                        Convert.ToInt32(cmbcategories.SelectedValue)
                        , txtdes.Text
                        , txtref.Text
                        , txtqte.Text
                        , txtprice.Text
                        , byteImage
                        , "withoutimage");
                    MessageBox.Show("تمت الاضافه بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byteImage = ms.ToArray();
                    prd.ADD_PRODUCT(
                        Convert.ToInt32(cmbcategories.SelectedValue)
                        , txtdes.Text
                        , txtref.Text
                        , txtqte.Text
                        , txtprice.Text
                        , byteImage
                        , "withimage");
                    MessageBox.Show("تمت الاضافه بنجاح", "عمليه الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                if (txtdes.Text == string.Empty || txtprice.Text == string.Empty || txtqte.Text == string.Empty || txtref.Text == string.Empty)
                {
                    MessageBox.Show("ينبغي تسجيل المعلومات المطلوبه ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                byte[] byteImage;
                if (pictureBox1.Image == null)
                {
                    byteImage = new byte[0];
                    prd.UPDATE_PRODUCT(
                        Convert.ToInt32(cmbcategories.SelectedValue)
                        , txtref.Text
                        , txtdes.Text
                        , txtqte.Text
                        , txtprice.Text
                        , byteImage
                        , "withoutimage");
                    MessageBox.Show("تمت التعديل بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byteImage = ms.ToArray();
                    prd.UPDATE_PRODUCT(
                        Convert.ToInt32(cmbcategories.SelectedValue)
                        , txtref.Text
                        , txtdes.Text
                        , txtqte.Text
                        , txtprice.Text
                        , byteImage
                        , "withimage");
                    MessageBox.Show("تمت التعديل بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            txtref.Clear();
            txtqte.Clear();
            txtdes.Clear();
            txtprice.Clear();
            pictureBox1.Image = null;
            txtref.Focus();

            FRM_PRODUCTS.getmainform.dataGridView1.DataSource = prd.GET_ALL_PRODUCT();

        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 5)
            {
                e.Handled = true;
            }
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtqte_KeyPress(object sender, KeyPressEventArgs e)
        {
          if (!char.IsDigit(e.KeyChar) && e.KeyChar !=5)
             {
                e.Handled = true;
             }
            
        }
    }
}
