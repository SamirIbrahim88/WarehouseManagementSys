using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;

namespace WarehouseManagementSystem1.PL
{
    public partial class FRM_SHOP : Form
    {
        BL.CLS_SHOP shop = new BL.CLS_SHOP();
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
                double totalamount = amount - (amount * (discount / 100));
                txttotalamount.Text = totalamount.ToString();
            }
            }
            catch
            {

              MessageBox.Show("يرجي التاكد من كتابه ارقام حسابيه ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        void CLEARBOXES()
        {
            txtidproduct.Clear();
            txtnameproduct.Clear();
            txtpriceproduct.Clear();
            txtqtyproduct.Clear();
            txtamount.Clear();
            txtdiscount.Clear();
            txttotalamount.Clear();
            button2.Focus();
        }
        void RESIZEDGV()
        {
            this.dataGridView1.RowHeadersWidth = 64;

        }
        void CLEARDATA()
        {
            txtidshop.Clear();
            txtdes.Clear();
            textBox2.Clear();
            dtshop.ResetText();
            txtcustomerid.Clear();
            txtfirstname.Clear();
            txtlastname.Clear();
            txtemail.Clear();
            txttel.Clear();
            CLEARBOXES();
            dt.Clear();
            dataGridView1.DataSource = null;
            txtsumtotal.Clear();
            txtamount.Clear();
            btnadd.Enabled = false;
            btnnew.Enabled = true;
        }


        public FRM_SHOP()
        {
            InitializeComponent();
            CREATEDAATABLE();
            RESIZEDGV();
            textBox2.Text = Program.SALESMAN;

        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            this.txtidshop.Text = shop.GET_LAST_SHOP_ID().Rows[0][0].ToString();
            btnnew.Enabled = false;
            btnadd.Enabled = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_TRADERS_LIST frm = new FRM_TRADERS_LIST();
            frm.ShowDialog();
            this.txtcustomerid.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.txtfirstname.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.txtlastname.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.txttel.Text = frm.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            this.txtemail.Text = frm.dataGridView1.CurrentRow.Cells[4].Value.ToString();


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

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            txtsumtotal.Text =
       (from DataGridViewRow row in dataGridView1.Rows
        where row.Cells[6].FormattedValue.ToString() != string.Empty
        select Convert.ToDouble(row.Cells[6].FormattedValue)).Sum().ToString();

        }

        private void FRM_SHOP_Load(object sender, EventArgs e)
        {

        }



        private void حذفالمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1_DoubleClick(sender, e);

        }

        private void حذفالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dataGridView1.Refresh();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            FRM_TRADERS_LIST frm = new FRM_TRADERS_LIST();
            frm.ShowDialog();
            if (frm.dataGridView1.CurrentRow.Cells[5].Value is DBNull)
            {
                this.txtcustomerid.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.txtfirstname.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.txtlastname.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.txttel.Text = frm.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                this.txtemail.Text = frm.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                pictureBox1.Image = null;
                return;
            }
            else
            {
                this.txtcustomerid.Text = frm.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.txtfirstname.Text = frm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                this.txtlastname.Text = frm.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                this.txttel.Text = frm.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                this.txtemail.Text = frm.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                byte[] custpicture = (byte[])frm.dataGridView1.CurrentRow.Cells[5].Value;
                MemoryStream ms = new MemoryStream(custpicture);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }



        private void button2_Click_2(object sender, EventArgs e)
        {
            CLEARBOXES();
            FRM_PRODUCT_LIST frm = new FRM_PRODUCT_LIST();
            frm.ShowDialog();
            txtidproduct.Text = frm.datagridview.CurrentRow.Cells[0].Value.ToString();
            txtnameproduct.Text = frm.datagridview.CurrentRow.Cells[1].Value.ToString();

            txtpriceproduct.Focus();
        }




        private void buttonX5_Click(object sender, EventArgs e)
        {
            this.txtidshop.Text = shop.GET_LAST_SHOP_ID().Rows[0][0].ToString();
            btnnew.Enabled = false;
            btnadd.Enabled = true;
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            try
            {

            shop.ADD_SHOP(Convert.ToInt32(txtidshop.Text), dtshop.Value, Convert.ToInt32(txtcustomerid.Text), txtdes.Text, textBox2.Text);
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                shop.ADD_SHOP_DETAILS(dataGridView1.Rows[i].Cells[0].Value.ToString(),
                                        Convert.ToInt32(txtidshop.Text),
                                        Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value),
                                        dataGridView1.Rows[i].Cells[2].Value.ToString()
                                        , dataGridView1.Rows[i].Cells[4].Value.ToString(),
                                        dataGridView1.Rows[i].Cells[6].Value.ToString(),
                                        Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value));
            }

            MessageBox.Show("نمت عمليه الحفظ بنجاح", "عمليه الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CLEARDATA();

          }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            int ID_SHOP = Convert.ToInt32(shop.GET_LAST_SHOP_FOR_PRINT().Rows[0][0]);
            RPT.RPT_SHOP REPORT = new RPT.RPT_SHOP();
            RPT.FRM_RPT_PRODUCT FRM = new RPT.FRM_RPT_PRODUCT();
            REPORT.SetDataSource(shop.GET_SHOP_DETAILS(ID_SHOP));
            FRM.crystalReportViewer1.ReportSource = REPORT;
            FRM.ShowDialog();
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



        private void txtpriceproduct_KeyUp(object sender, KeyEventArgs e)
        {
            CALCULATEAMOUNT();
            CALCULATETOTALAMOUNT();
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

        private void txtpriceproduct_KeyDown(object sender, KeyEventArgs e)
        {
                        if (e.KeyCode == Keys.Enter && txtpriceproduct.Text != string.Empty)
            {
                txtqtyproduct.Focus();
            }
        }

        private void txtqtyproduct_KeyUp(object sender, KeyEventArgs e)
        {
                        CALCULATEAMOUNT();
            CALCULATETOTALAMOUNT();
        }

        private void txtqtyproduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtqtyproduct.Text != string.Empty)
            {
                txtdiscount.Focus();
            }
        }

        private void txtdiscount_KeyUp(object sender, KeyEventArgs e)
        {
            CALCULATETOTALAMOUNT();
        }

        private void txtdiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

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




        }



    }
