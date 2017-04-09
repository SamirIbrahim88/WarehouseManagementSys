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
    public partial class EDIT_PRODUCT : Form
    {
        BL.CLS_PRODUCTS prd = new BL.CLS_PRODUCTS();
        int ID;
        public EDIT_PRODUCT()
        {
            InitializeComponent();
            cmbcategories.DataSource = prd.GET_ALL_CATEGORIES();
            cmbcategories.DisplayMember = "DESCRIPTION_CAT";
            cmbcategories.ValueMember = "ID_CAT";
        }

        private void ok_Click(object sender, EventArgs e)
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
                //prd.UPDATE_PRODUCT(Convert.ToInt32(cmbcategories.SelectedValue), txtdes.Text, txtref.Text, Convert.ToInt32(txtqte.Text), txtprice.Text, byteImage, "withoutimage",ID);
                prd.UPDATE_PRODUCT(Convert.ToInt32(cmbcategories.SelectedValue), txtdes.Text, txtref.Text, txtqte.Text, txtprice.Text, byteImage, "withoutimage");

                MessageBox.Show("تم التعديل بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byteImage = ms.ToArray();
                //prd.UPDATE_PRODUCT(Convert.ToInt32(cmbcategories.SelectedValue), txtdes.Text, txtref.Text, Convert.ToInt32(txtqte.Text), txtprice.Text, byteImage, "withimage",ID);
                prd.UPDATE_PRODUCT(Convert.ToInt32(cmbcategories.SelectedValue), txtdes.Text, txtref.Text, txtqte.Text, txtprice.Text, byteImage, "withimage");

                MessageBox.Show("تم التعديل بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            txtref.Clear();
            txtqte.Clear();
            txtdes.Clear();
            txtprice.Clear();

            FRM_PRODUCTS.getmainform.dataGridView1.DataSource = prd.GET_ALL_PRODUCT();
        }

        private void EDIT_PRODUCT_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
