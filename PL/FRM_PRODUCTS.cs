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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;

namespace WarehouseManagementSystem1.PL
{
    public partial class FRM_PRODUCTS : Form
    {
        private static FRM_PRODUCTS frm;
        static void frm_fromclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_PRODUCTS getmainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_PRODUCTS();
                    frm.FormClosed += new FormClosedEventHandler(frm_fromclosed);
                }
                return frm;
            }
        }

        BL.CLS_PRODUCTS prd = new BL.CLS_PRODUCTS();
        public FRM_PRODUCTS()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.dataGridView1.DataSource = prd.GET_ALL_PRODUCT();
            dataGridView1.Columns[5].Visible = false;            
        }

        private void FRM_PRODUCTS_Load(object sender, EventArgs e)
        {
        }


        private void btnadd_Click(object sender, EventArgs e)
        {
            add_product frm = new add_product();
            frm.Show();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا الحذف", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                prd.DELETEPRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عمليه الحذف", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = prd.GET_ALL_PRODUCT();
            }
            else
            {
                MessageBox.Show("تم الغاء عمليه الحذف", "الغاء الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            FRM_PRODUCTS.getmainform.dataGridView1.DataSource = prd.GET_ALL_PRODUCT();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            add_product frm = new add_product();

            frm.txtref.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtdes.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtqte.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtprice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.cmbcategories.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.Text = "تجديث المنتج" + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.ok.Text = "تحديث";
            frm.state = "update";
            frm.txtref.ReadOnly = true;
            frm.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_PREVIEW FRM = new FRM_PREVIEW();
                byte[] IMAGE = (byte[])prd.GET_IMAGE_PRODUCTS(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
                MemoryStream ms = new MemoryStream(IMAGE);
                FRM.pictureBox1.Image = Image.FromStream(ms);
                FRM.ShowDialog();
            }
            catch
            {
                return;
            }
        }

        private void printcurrent_Click(object sender, EventArgs e)
        {
            RPT.RPT_PRODUCT_SIGNLE MYREPORT = new RPT.RPT_PRODUCT_SIGNLE();
            MYREPORT.SetParameterValue("@ID", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            RPT.FRM_RPT_PRODUCT myform = new RPT.FRM_RPT_PRODUCT();
            myform.crystalReportViewer1.ReportSource = MYREPORT;
            myform.ShowDialog();
        }

        private void printall_Click(object sender, EventArgs e)
        {
            RPT.rpt_all_product myreport = new RPT.rpt_all_product();
            RPT.FRM_RPT_PRODUCT myform = new RPT.FRM_RPT_PRODUCT();
            myform.crystalReportViewer1.ReportSource = myreport;
            myform.ShowDialog();
        }

        private void exportpdf_Click(object sender, EventArgs e)
        {
            RPT.rpt_all_product myreport = new RPT.rpt_all_product();
            ExportOptions export = new ExportOptions();
            DiskFileDestinationOptions dfoption = new DiskFileDestinationOptions();
            ExcelFormatOptions excelformat = new ExcelFormatOptions();
            dfoption.DiskFileName = @"E:\\" + "list" + ".xml";
            export=myreport.ExportOptions;
                export.ExportDestinationType=ExportDestinationType.DiskFile;
            export.ExportFormatType=ExportFormatType.Excel;
            export.ExportFormatOptions=excelformat;
            export.ExportDestinationOptions = dfoption;
            MessageBox.Show("تمت عمليه التصدير بنجاح ","عمليه التصدير",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            add_product frm = new add_product();
            frm.Show();
        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Cells[5].Value is DBNull)
                {
                    add_product frm = new add_product();
                    frm.txtref.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    frm.txtdes.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    frm.txtqte.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    frm.txtprice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    frm.cmbcategories.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    frm.Text = "تجديث المنتج" +" "+ this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    frm.ok.Text = "تحديث";
                    frm.state = "update";
                    frm.txtref.ReadOnly = true;
                    frm.ShowDialog();
                }
                else
                {
                    add_product frm = new add_product();
                    frm.txtref.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    frm.txtdes.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    frm.txtqte.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    frm.txtprice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    frm.cmbcategories.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    frm.Text = "تجديث المنتج" + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    frm.ok.Text = "تحديث";
                    frm.state = "update";
                    frm.txtref.ReadOnly = true;
                    byte[] image = (byte[])prd.GET_IMAGE_PRODUCTS(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
                    MemoryStream ms = new MemoryStream(image);
                    frm.pictureBox1.Image = Image.FromStream(ms);
                    frm.ShowDialog();
                }
            }
            catch
            {
                return;
            }
  
        }

        private void buttonX1_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد فعلا الحذف", "عمليه الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    prd.DELETEPRODUCT(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("تمت عمليه الحذف", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.dataGridView1.DataSource = prd.GET_ALL_PRODUCT();
                }
                else
                {
                    MessageBox.Show("تم الغاء عمليه الحذف", "الغاء الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                FRM_PRODUCTS.getmainform.dataGridView1.DataSource = prd.GET_ALL_PRODUCT();
            }
            catch
            {
                return;
            }

        }

        private void buttonX1_Click_3(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Cells[5].Value is DBNull)
                {
                    FRM_PREVIEW FRM = new FRM_PREVIEW();
                    FRM.pictureBox1.Image = null;
                    FRM.ShowDialog();
                }
                else
                {
                    FRM_PREVIEW FRM = new FRM_PREVIEW();
                    byte[] IMAGE = (byte[])prd.GET_IMAGE_PRODUCTS(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
                    MemoryStream ms = new MemoryStream(IMAGE);
                    FRM.pictureBox1.Image = Image.FromStream(ms);
                    FRM.ShowDialog();
                }
            }
            catch
            {
                return;
            }
        }

        private void txtsearch_TextChanged_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = prd.SEARCHPRODUCT(txtsearch.Text);
            dataGridView1.DataSource = dt;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            RPT.RPT_PRODUCT_SIGNLE MYREPORT = new RPT.RPT_PRODUCT_SIGNLE();
            MYREPORT.SetParameterValue("@ID", this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            RPT.FRM_RPT_PRODUCT myform = new RPT.FRM_RPT_PRODUCT();
            myform.crystalReportViewer1.ReportSource = MYREPORT;
            myform.ShowDialog();
        }

        private void buttonX2_Click_1(object sender, EventArgs e)
        {
            RPT.rpt_all_product myreport = new RPT.rpt_all_product();
            RPT.FRM_RPT_PRODUCT myform = new RPT.FRM_RPT_PRODUCT();
            myform.crystalReportViewer1.ReportSource = myreport;
            myform.ShowDialog();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonX2_Click_2(object sender, EventArgs e)
        {
            try
            {
                RPT.rpt_all_product myreport = new RPT.rpt_all_product();


                ExportOptions CrExportOptions;



                DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();

                ExcelFormatOptions CrFormatTypeOptions = new ExcelFormatOptions();

                CrDiskFileDestinationOptions.DiskFileName = "D:\\تقرير المنتجات.xls";

                CrExportOptions = myreport.ExportOptions;

                CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;

                CrExportOptions.ExportFormatType = ExportFormatType.Excel;

                CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;

                CrExportOptions.FormatOptions = CrFormatTypeOptions;

                myreport.Export();
                MessageBox.Show("تم تصدير الملف بنجاح ", "تصدير الملف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }
    }
}
