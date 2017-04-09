using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using System.IO;

namespace WarehouseManagementSystem1.PL
{
    public partial class FRM_ORDER : Form
    {
        BL.CLS_ORDER ORDER = new BL.CLS_ORDER();
        DataTable dt = new DataTable();
        void CALCULATEAMOUNT()
        {
            try
            {
                if (txtpriceproduct.Text != string.Empty && txtqtyproduct.Text != string.Empty)
                {
                    double amount = Convert.ToDouble(txtpriceproduct.Text) * (Convert.ToDouble(txtqtyproduct.Text));
                    txtamount.Text = amount.ToString();
                }
            }
            catch
            {
                
                MessageBox.Show("يرجي التاكد من كتابه ارقام حسابيه ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtqtyproduct.Clear();
                txtpriceproduct.Clear();
                return;
            }
        }
        void CALCULATETOTALAMOUNT()
        {
            try
            {
            if (txtdiscount.Text != string.Empty && txtamount.Text != string.Empty)
            {
                double discount = Convert.ToDouble(txtdiscount.Text);
                double amount = Convert.ToDouble(txtamount.Text);
                double totalamount = amount - (amount * (discount/100));
                txttotalamount.Text = totalamount.ToString();
            }
                        }
            catch
            {
                
                MessageBox.Show("يرجي التاكد من كتابه ارقام صحيحه ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiscount.Clear();
                return;
            }
        }
        void CREATEDAATABLE()
        {
            dt.Columns.Add("معرف المنتج");
            dt.Columns.Add("اسم المنتج");
            dt.Columns.Add("ثمن البيع");
            dt.Columns.Add("الكميه");
            dt.Columns.Add("المبلغ");
            dt.Columns.Add("نسبه الخصم");
            dt.Columns.Add("المبلغ الاجمالي");
            dataGridView1.DataSource = dt;
        }
        void RESIZEDGV()
        {
            this.dataGridView1.RowHeadersWidth = 68;

        }

        void CLEARBOXES()
        {
            txtidproduct.Clear();
            txtnameproduct.Clear();
            txtpriceproduct.Clear();
            txtqtyproduct.Clear();
            txtdiscount.Clear();
            txttotalamount.Clear();
            button2.Focus();
        }
        void CLEARDATA()
        {
            txtidorder.Clear();
            txtdes.Clear();
            textBox2.Clear();
            dtorder.ResetText();
            txtcustomerid.Clear();
            txtfirstname.Clear();
            txtlastname.Clear();
            txtemail.Clear();
            txttel.Clear();
            CLEARBOXES();
            dt.Clear();
            dataGridView1.DataSource = null;
            txtsumtotal.Clear();
            btnadd.Enabled = false;
            btnnew.Enabled = true;
        }
        public FRM_ORDER()
        {
            InitializeComponent();
            RESIZEDGV();
            CREATEDAATABLE();
            textBox2.Text = Program.PAYMAN;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.txtidorder.Text = ORDER.GET_LAST_ORDER_ID().Rows[0][0].ToString();
            btnnew.Enabled = false;
            btnadd.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMER_LIST frm = new FRM_CUSTOMER_LIST();
            frm.ShowDialog();
            this.txtcustomerid.Text = frm.DGVCUSTOMER.CurrentRow.Cells[0].Value.ToString();
            this.txtfirstname.Text = frm.DGVCUSTOMER.CurrentRow.Cells[1].Value.ToString();
            this.txtlastname.Text = frm.DGVCUSTOMER.CurrentRow.Cells[2].Value.ToString();
            this.txttel.Text = frm.DGVCUSTOMER.CurrentRow.Cells[3].Value.ToString();
            this.txtemail.Text = frm.DGVCUSTOMER.CurrentRow.Cells[4].Value.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLEARBOXES();
            FRM_PRODUCT_LIST frm = new FRM_PRODUCT_LIST();
            frm.ShowDialog();
            txtidproduct.Text = frm.datagridview.CurrentRow.Cells[0].Value.ToString();
            txtnameproduct.Text = frm.datagridview.CurrentRow.Cells[1].Value.ToString();
            txtpriceproduct.Text = frm.datagridview.CurrentRow.Cells[3].Value.ToString();
            txtqtyproduct.Focus();

        }

        private void txtqtyproduct_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    txtqtyproduct.Focus();
                }
            }
            catch
            {
                return;
            }
        }


        private void txtqtyproduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtqtyproduct.Text != string.Empty)
            {
                txtdiscount.Focus();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtidproduct.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtnameproduct.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtpriceproduct.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtqtyproduct.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtamount.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtdiscount.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txttotalamount.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                txtqtyproduct.Focus();
            }
            catch 
            {
                return;
            }
        }

        private void txtpriceproduct_KeyUp(object sender, KeyEventArgs e)
        {
            CALCULATEAMOUNT();
            CALCULATETOTALAMOUNT();
        }

        private void txtqtyproduct_KeyUp(object sender, KeyEventArgs e)
        {
            CALCULATEAMOUNT();
            CALCULATETOTALAMOUNT();
        }

        private void txtdiscount_KeyUp(object sender, KeyEventArgs e)
        {
            CALCULATETOTALAMOUNT();
        }
        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            try
            {
            txtsumtotal.Text =
                   (from DataGridViewRow row in dataGridView1.Rows
                    where row.Cells[6].FormattedValue.ToString() != string.Empty
                    select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
                       }
            catch
            {
                return;
            }
        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
              try
            {
            dt.Clear();
            dataGridView1.Refresh();
            }
              catch
              {
                  return;
              }
        }

        private void حذفالسطرالمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            catch
            {
                return;
            }
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1_DoubleClick(sender, e);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtidorder.Text == string.Empty || txtcustomerid.Text == string.Empty || dataGridView1.Rows.Count < 1 || txtdes.Text == string.Empty)
            {
                MessageBox.Show("ينبغي تسجيل المعلومات المطلوبه ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ORDER.ADD_ORDER(Convert.ToInt32(txtidorder.Text), dtorder.Value, Convert.ToInt32(txtcustomerid.Text), txtdes.Text, textBox2.Text);

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                ORDER.ADD_ORDER_DETAILS(dataGridView1.Rows[i].Cells[0].Value.ToString(),
                Convert.ToInt32(txtidorder.Text),
                Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value),
                dataGridView1.Rows[i].Cells[2].Value.ToString(),
                Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value),
                dataGridView1.Rows[i].Cells[4].Value.ToString(),
                dataGridView1.Rows[i].Cells[6].Value.ToString());
            }

            MessageBox.Show("نمت عمليه الحفظ بنجاح", "عمليه الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CLEARDATA();

        }

        private void txtdiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ORDER.VERIFYQUANTITY(txtidproduct.Text, Convert.ToDouble(txtqtyproduct.Text)).Rows.Count < 1)
                {
                    MessageBox.Show("الكميه غير متوفره", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txtidproduct.Text)
                    {
                        MessageBox.Show("هذا المنتج تم ادخاله مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                DataRow r = dt.NewRow();
                r[0] = txtidproduct.Text;
                r[1] = txtnameproduct.Text;
                r[2] = txtpriceproduct.Text;
                r[3] = txtqtyproduct.Text;
                r[4] = txtamount.Text;
                r[5] = txtdiscount.Text;
                r[6] = txttotalamount.Text;
                dt.Rows.Add(r);
                dataGridView1.DataSource = dt;
                CLEARBOXES();
                txtsumtotal.Text =
                    (from DataGridViewRow row in dataGridView1.Rows
                     where row.Cells[6].FormattedValue.ToString() != string.Empty
                     select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();
            }
        }
        private void FRM_ORDER_Load(object sender, EventArgs e)
        {

        }



        private void buttonX1_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMER_LIST frm = new FRM_CUSTOMER_LIST();
            frm.ShowDialog();
            if (frm.DGVCUSTOMER.CurrentRow.Cells[5].Value is DBNull)
            {
                this.txtcustomerid.Text = frm.DGVCUSTOMER.CurrentRow.Cells[0].Value.ToString();
                this.txtfirstname.Text = frm.DGVCUSTOMER.CurrentRow.Cells[1].Value.ToString();
                this.txtlastname.Text = frm.DGVCUSTOMER.CurrentRow.Cells[2].Value.ToString();
                this.txttel.Text = frm.DGVCUSTOMER.CurrentRow.Cells[3].Value.ToString();
                this.txtemail.Text = frm.DGVCUSTOMER.CurrentRow.Cells[4].Value.ToString();
                pictureBox1.Image = null;
                return;
            }
            this.txtcustomerid.Text = frm.DGVCUSTOMER.CurrentRow.Cells[0].Value.ToString();
            this.txtfirstname.Text = frm.DGVCUSTOMER.CurrentRow.Cells[1].Value.ToString();
            this.txtlastname.Text = frm.DGVCUSTOMER.CurrentRow.Cells[2].Value.ToString();
            this.txttel.Text = frm.DGVCUSTOMER.CurrentRow.Cells[3].Value.ToString();
            this.txtemail.Text = frm.DGVCUSTOMER.CurrentRow.Cells[4].Value.ToString();
            byte[] custpicture = (byte[])frm.DGVCUSTOMER.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(custpicture);
            pictureBox1.Image = Image.FromStream(ms);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            CLEARBOXES();
            FRM_PRODUCT_LIST frm = new FRM_PRODUCT_LIST();
            frm.ShowDialog();
            txtidproduct.Text = frm.datagridview.CurrentRow.Cells[0].Value.ToString();
            txtnameproduct.Text = frm.datagridview.CurrentRow.Cells[1].Value.ToString();

            txtpriceproduct.Focus();
        }

        private void buttonX2_Click_1(object sender, EventArgs e)
        {
            this.txtidorder.Text = ORDER.GET_LAST_ORDER_ID().Rows[0][0].ToString();
            btnnew.Enabled = false;
            btnadd.Enabled = true;
        }

        private void buttonX2_Click_2(object sender, EventArgs e)
        {
            if (txtidorder.Text == string.Empty || txtcustomerid.Text == string.Empty || dataGridView1.Rows.Count < 1 || txtdes.Text == string.Empty)
            {
                MessageBox.Show("ينبغي تسجيل المعلومات المطلوبه ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                ORDER.ADD_ORDER(Convert.ToInt32(txtidorder.Text), dtorder.Value, Convert.ToInt32(txtcustomerid.Text), txtdes.Text, textBox2.Text);

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    ORDER.ADD_ORDER_DETAILS(dataGridView1.Rows[i].Cells[0].Value.ToString(),
                    Convert.ToInt32(txtidorder.Text),
                    Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value),
                    dataGridView1.Rows[i].Cells[2].Value.ToString(),
                    Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value),
                    dataGridView1.Rows[i].Cells[4].Value.ToString(),
                    dataGridView1.Rows[i].Cells[6].Value.ToString());
                }

                MessageBox.Show("نمت عمليه الحفظ بنجاح", "عمليه الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CLEARDATA();           
        }

        private void btnprint_Click(object sender, EventArgs e)
        {

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnprint_Click_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int ID_ORDER = Convert.ToInt32(ORDER.GET_LAST_ORDER_FOR_PRINT().Rows[0][0]);
            RPT.RPT_ORDER REPORT = new RPT.RPT_ORDER();
            RPT.FRM_RPT_PRODUCT FRM = new RPT.FRM_RPT_PRODUCT();
            REPORT.SetDataSource(ORDER.GET_ORDER_DETAILS(ID_ORDER));
            FRM.crystalReportViewer1.ReportSource = REPORT;
            FRM.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtpriceproduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtpriceproduct.Text != string.Empty)
            {
                txtqtyproduct.Focus();
            }
        }


        private void txtpriceproduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    txtpriceproduct.Focus();
                }
            }catch
            {
                return;
                }
        }

        private void txtpriceproduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtqtyproduct_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
