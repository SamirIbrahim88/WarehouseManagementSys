using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WarehouseManagementSystem1.PL
{
    public partial class FRM_CUSTOMERS : Form
    {
        private static FRM_CUSTOMERS frm;
        static void frm_fromclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_CUSTOMERS getmainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_CUSTOMERS();
                    frm.FormClosed += new FormClosedEventHandler(frm_fromclosed);
                }
                return frm;
            }


        }
        BL.CLS_CUSTOMER cust = new BL.CLS_CUSTOMER();
        int id, position;
        public FRM_CUSTOMERS()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMER();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }



        private void FRM_CUSTOMERS_Load(object sender, EventArgs e)
        {

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtfirstname.Clear();
            comboBox1.SelectedIndex = -1;
            txtel.Clear();
            txtemail.Clear();
            txtfirstname.Focus();
        }

        private void txtfirstname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comboBox1.Focus();
            }
        }

        private void txtlastname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtel.Focus();
            }
        }

        private void txtel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtemail.Focus();
            }
        }

        private void txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnadd.Focus();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = null;
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                this.txtfirstname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.txtel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                this.txtemail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                byte[] picture = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(picture);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                 byte[] byteImage;
                 if (pictureBox1.Image == null)
                 {
                     byteImage = new byte[0];
                     cust.EDIT_CUSTOMER(txtfirstname.Text, comboBox1.SelectedItem.ToString(), txtel.Text, txtemail.Text, byteImage, "withoutimage", id);
                     MessageBox.Show("تم التعديل بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMER();
                 }
                 else
                 {
                     MemoryStream ms = new MemoryStream();
                     pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                     byteImage = ms.ToArray();
                     cust.EDIT_CUSTOMER(txtfirstname.Text, comboBox1.SelectedItem.ToString(), txtel.Text, txtemail.Text, byteImage, "withimage", id);
                     MessageBox.Show("تم التعديل بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMER();

                 }
            }
            catch
            {
                return;
            }
            txtfirstname.Clear();
            comboBox1.SelectedIndex = -1;
            txtel.Clear();
            txtemail.Clear();


        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("هل تريد فعلا الحذف", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    cust.DELETE_CUSTOMER(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("تمت عمليه الحذف", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMER();
                }
                else
                {
                    MessageBox.Show("تم الغاء عمليه الحذف", "الغاء الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                return;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            position = cust.GET_ALL_CUSTOMER().Rows.Count - 1;
            navigate(position);
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cust.SEARCH_CUSTOMER(txtsearch.Text);
        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnok_Click(sender, e);
            }
        }

        void navigate(int index)
        {
            try
            {
                pictureBox1.Image = null;
                DataRowCollection DRC = cust.GET_ALL_CUSTOMER().Rows;
                id = Convert.ToInt32(DRC[index][0]);
                txtfirstname.Text = DRC[index][1].ToString();
                comboBox1.Text = DRC[index][2].ToString();
                txtel.Text = DRC[index][3].ToString();
                txtemail.Text = DRC[index][4].ToString();
                byte[] byteImage = (byte[])DRC[index][5];
                MemoryStream ms = new MemoryStream(byteImage);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }

        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            navigate(0);
        }

        private void btlprevious_Click(object sender, EventArgs e)
        {
            if (position == 0)
            {
                MessageBox.Show("هذا العنصر الاول");
            }
            position -= 1;
            navigate(position);
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (position == cust.GET_ALL_CUSTOMER().Rows.Count-1)
            {
                MessageBox.Show("هذا العنصر الاخير");
            }
            position += 1;
            navigate(position);

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            navigate(0);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (position == 0)
            {
                MessageBox.Show("هذا العنصر الاول");
            }
            position -= 1;
            navigate(position);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (position == cust.GET_ALL_CUSTOMER().Rows.Count - 1)
            {
                MessageBox.Show("هذا العنصر الاخير");
            }
            position += 1;
            navigate(position);
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            position = cust.GET_ALL_CUSTOMER().Rows.Count - 1;
            navigate(position);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            txtfirstname.Clear();
            comboBox1.SelectedIndex = -1;
            txtel.Clear();
            txtemail.Clear();
            txtfirstname.Focus();
            pictureBox1.Image = null;
        }

        private void buttonX1_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (txtfirstname.Text == string.Empty || comboBox1.Text == string.Empty || txtel.Text == string.Empty || txtemail.Text == string.Empty)
                {
                    MessageBox.Show("ينبغي تسجيل المعلومات المطلوبه ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                byte[] byteImage;
                if (pictureBox1.Image == null)
                {
                    byteImage = new byte[0];
                    cust.add_customer(txtfirstname.Text, comboBox1.SelectedItem.ToString(), txtel.Text, txtemail.Text, byteImage, "withoutimage");
                    MessageBox.Show("تمت الاضافه بنجاح", "الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byteImage = ms.ToArray();
                    cust.add_customer(txtfirstname.Text, comboBox1.SelectedItem.ToString(), txtel.Text, txtemail.Text, byteImage, "withimage");
                    MessageBox.Show("تمت الاضافه بنجاح", "الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch
            {
                return;
            }
            FRM_CUSTOMERS.getmainform.dataGridView1.DataSource = cust.GET_ALL_CUSTOMER();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
        }

        private void buttonX1_Click_3(object sender, EventArgs e)
        {
            try
            {
                byte[] byteImage;
                if (pictureBox1.Image == null)
                {
                    byteImage = new byte[0];
                    cust.EDIT_CUSTOMER(txtfirstname.Text, comboBox1.SelectedItem.ToString(), txtel.Text, txtemail.Text, byteImage, "withoutimage",id);
                    MessageBox.Show("تم التعديل بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMER();
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byteImage = ms.ToArray();
                    cust.EDIT_CUSTOMER(txtfirstname.Text, comboBox1.SelectedItem.ToString(), txtel.Text, txtemail.Text, byteImage, "withimage",id);
                    MessageBox.Show("تم التعديل بنجاح", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMER();

                }
            }
            catch
            {
                return;
            }
            txtfirstname.Clear();
            comboBox1.SelectedIndex = -1;
            txtel.Clear();
            txtemail.Clear();
        }

        private void buttonX1_Click_4(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("هل تريد فعلا الحذف", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    cust.DELETE_CUSTOMER(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("تمت عمليه الحذف", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = cust.GET_ALL_CUSTOMER();
                }
                else
                {
                    MessageBox.Show("تم الغاء عمليه الحذف", "الغاء الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                return;
            }
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void buttonX1_Click_5(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cust.SEARCH_CUSTOMER(txtsearch.Text);
        }

        private void buttonX1_Click_6(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ImageFile|*.JPG; *.PNG; *.GIF; *.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void buttonX2_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

    }
}