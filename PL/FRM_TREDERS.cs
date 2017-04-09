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
    public partial class FRM_TREDERS : Form
    {
        private static FRM_TREDERS frm;
        static void frm_fromclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_TREDERS getmainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_TREDERS();
                    frm.FormClosed += new FormClosedEventHandler(frm_fromclosed);
                }
                return frm;
            }


        }
        BL.CLS_TRADER prd = new BL.CLS_TRADER();
        int ID, position;
        public FRM_TREDERS()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dataGridView1.DataSource = prd.GET_ALL_TRADERS();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            FRM_TREDERS.getmainform.dataGridView1.DataSource = prd.GET_ALL_TRADERS();
        }


        private void txtfirstname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtlastname.Focus();
            }
        }

        private void txtlastname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txttel.Focus();
            }
        }

        private void txttel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtmail.Focus();
            }
        }

        private void txtmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnadd.Focus();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtfirstname.Clear();
            txtlastname.Clear();
            txttel.Clear();
            txtmail.Clear();
            txtfirstname.Focus();

        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = null;
                ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                this.txtfirstname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.txtlastname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.txttel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                this.txtmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                byte[] picture = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(picture);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("المورد المراد حذفه غير موجود");
                return;
            }
            if (MessageBox.Show("هل تريد فعلا الحذف", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                prd.DELETE_TRADERS(ID);
                MessageBox.Show("تم الحذف بنجاح", "الحذق", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                this.dataGridView1.DataSource = prd.GET_ALL_TRADERS();
            }
        }

        void navigate(int index)
        {
            try
            {
                pictureBox1.Image = null;
                DataRowCollection DRC = prd.GET_ALL_TRADERS().Rows;
                ID = Convert.ToInt32(DRC[index][0]);
                txtfirstname.Text = DRC[index][1].ToString();
                txtlastname.Text = DRC[index][2].ToString();
                txttel.Text = DRC[index][3].ToString();
                txtmail.Text = DRC[index][4].ToString();
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
            if (position == prd.GET_ALL_TRADERS().Rows.Count - 1)
            {
                MessageBox.Show("هذا العنصر الاخير");
            }
            position += 1;
            navigate(position);

        }

        private void FRM_TREDERS_Load(object sender, EventArgs e)
        {
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = prd.SEARCH_TRADERS(txtsearch.Text);
        }


        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnok_Click(sender, e);
            }
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            position = prd.GET_ALL_TRADERS().Rows.Count - 1;
            navigate(position);
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ImageFile|*.JPG; *.PNG; *.GIF; *.BMP";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            navigate(0);
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            if (position == 0)
            {
                MessageBox.Show("هذا العنصر الاول");
            }
            position -= 1;
            navigate(position);
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            position = prd.GET_ALL_TRADERS().Rows.Count - 1;
            navigate(position);
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (position == prd.GET_ALL_TRADERS().Rows.Count - 1)
            {
                MessageBox.Show("هذا العنصر الاخير");
            }
            position += 1;
            navigate(position);
        }

        private void buttonX3_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = prd.SEARCH_TRADERS(txtsearch.Text);
        }

        private void buttonX4_Click_1(object sender, EventArgs e)
        {
            txtfirstname.Clear();
            txtlastname.Clear();
            txttel.Clear();
            txtmail.Clear();
            txtfirstname.Focus();
            pictureBox1.Image = null;
        }

        private void buttonX3_Click_2(object sender, EventArgs e)
        {
               try
            {
                if (txtfirstname.Text == string.Empty || txtlastname.Text == string.Empty || txttel.Text == string.Empty || txtmail.Text == string.Empty)
                {
                    MessageBox.Show("ينبغي تسجيل المعلومات المطلوبه ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                byte[] byteImage;
                if (pictureBox1.Image == null)
                {
                    byteImage = new byte[0];
                    prd.ADD_TRADER(txtfirstname.Text, txtlastname.Text, txttel.Text, txtmail.Text, byteImage, "withoutimage");
                    MessageBox.Show("تمت الاضافه بنجاح", "الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byteImage = ms.ToArray();
                    prd.ADD_TRADER(txtfirstname.Text, txtlastname.Text, txttel.Text, txtmail.Text, byteImage, "withimage");
                    MessageBox.Show("تمت الاضافه بنجاح", "الاضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                return;
            }
               txtfirstname.Clear();
               txtlastname.Clear();
               txttel.Clear();
               txtmail.Clear();
               pictureBox1.Image = null;
            FRM_TREDERS.getmainform.dataGridView1.DataSource = prd.GET_ALL_TRADERS();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] byteImage;
                if (pictureBox1.Image == null)
                {
                    byteImage = new byte[0];
                    prd.UPDATE_TRADER(txtfirstname.Text, txtlastname.Text, txttel.Text, txtmail.Text, byteImage, "withoutimage", ID);
                    this.dataGridView1.DataSource = prd.GET_ALL_TRADERS();
                    MessageBox.Show("تم عمليه التعديل", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byteImage = ms.ToArray();
                    prd.UPDATE_TRADER(txtfirstname.Text, txtlastname.Text, txttel.Text, txtmail.Text, byteImage, "withimage", ID);
                    this.dataGridView1.DataSource = prd.GET_ALL_TRADERS();
                    MessageBox.Show("تم عمليه التعديل", "عمليه التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                return;
            }
            txtfirstname.Clear();
            txtlastname.Clear();
            txttel.Clear();
            txtmail.Clear();
            pictureBox1.Image = null;
            FRM_TREDERS.getmainform.dataGridView1.DataSource = prd.GET_ALL_TRADERS();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("المورد المراد حذفه غير موجود");
                return;
            }
            if (MessageBox.Show("هل تريد فعلا الحذف", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                prd.DELETE_TRADERS(ID);
                MessageBox.Show("تم الحذف بنجاح", "الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                this.dataGridView1.DataSource = prd.GET_ALL_TRADERS();
            }
        }

        private void buttonX5_Click_1(object sender, EventArgs e)
        {
            Close();
        }

    }
}