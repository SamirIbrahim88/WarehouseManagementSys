using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;


namespace WarehouseManagementSystem1.PL
{
    public partial class FRM_CATEGORIES : Form
    {
        SqlConnection sqlconnection = new SqlConnection(@"server=DESKTOP-SM0L2DR;Initial Catalog=PRODUCT_DB;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        SqlCommandBuilder cmdbd;
        public FRM_CATEGORIES()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select ID_CAT as'المعرف' ,DESCRIPTION_CAT 'الصنف' from CATEGORIES",sqlconnection);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            txtid.DataBindings.Add("text", dt, "المعرف");
            txtdes.DataBindings.Add("text", dt, "الصنف");
            bmb = this.BindingContext[dt];
            label3.Text=(bmb.Position+1)+"/"+ bmb.Count;
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRM_CATEGORIES_Load(object sender, EventArgs e)
        {

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            btnnew.Enabled = false;
            btnadd.Enabled = true;
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
            txtid.Text = id.ToString();
            txtdes.Focus();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtdes.Text == string.Empty || txtid.Text == string.Empty)
            {
                MessageBox.Show("ينبغي تسجيل المعلومات المطلوبه ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bmb.EndCurrentEdit();
            cmdbd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تمت عمليه الاضافه", "اضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnadd.Enabled = false;
            btnnew.Enabled = true;
            label3.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmdbd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تمت عمليه الحذف", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnadd.Enabled = false;
            btnnew.Enabled = true;
            label3.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtdes.Text == string.Empty || txtid.Text == string.Empty)
            {
                MessageBox.Show("ينبغي تسجيل المعلومات المطلوبه ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bmb.EndCurrentEdit();
            cmdbd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تمت عمليه التعديل", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label3.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtdes.Focus();
            }
        }

        private void txtdes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnadd.Focus();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            bmb.Position -= 1;
            label3.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            bmb.Position += 1;
            label3.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
            label3.Text = (bmb.Position + 1) + "/" + bmb.Count;

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count;
            label3.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            btnnew.Enabled = false;
            btnadd.Enabled = true;
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
            txtid.Text = id.ToString();
            txtdes.Focus();
        }

        private void buttonX5_Click_1(object sender, EventArgs e)
        {
            if (txtdes.Text == string.Empty || txtid.Text == string.Empty)
            {
                MessageBox.Show("ينبغي تسجيل المعلومات المطلوبه ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bmb.EndCurrentEdit();
            cmdbd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تمت عمليه التعديل", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            label3.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void buttonX5_Click_2(object sender, EventArgs e)
        {
            if (txtdes.Text == string.Empty || txtid.Text == string.Empty)
            {
                MessageBox.Show("ينبغي تسجيل المعلومات المطلوبه ", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bmb.EndCurrentEdit();
            cmdbd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تمت عمليه الاضافه", "اضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnadd.Enabled = false;
            btnnew.Enabled = true;
            label3.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void buttonX5_Click_3(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmdbd = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("تمت عمليه الحذف", "عمليه الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnadd.Enabled = false;
            btnnew.Enabled = true;
            label3.Text = (bmb.Position + 1) + "/" + bmb.Count;
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btnprintall_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void buttonX5_Click_4(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            RPT.rptAllCategories rpt1 = new RPT.rptAllCategories();
            //RPT.RPT_ALL_CATEGORIES rpt = new RPT.RPT_ALL_CATEGORIES();
            RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
            //rpt.Refresh();
            rpt1.Refresh();
            //frm.crystalReportViewer1.ReportSource = rpt;
            frm.crystalReportViewer1.ReportSource = rpt1;
            frm.ShowDialog();
        }

        private void printcurrent_Click(object sender, EventArgs e)
        {
            RPT.rpt_single_categories rpt = new RPT.rpt_single_categories();
            RPT.FRM_RPT_PRODUCT frm = new RPT.FRM_RPT_PRODUCT();
            rpt.SetParameterValue("@ID", Convert.ToInt32(txtid.Text));
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            try
            {
                RPT.rpt_single_categories myreport = new RPT.rpt_single_categories();
                myreport.SetParameterValue("@ID", Convert.ToInt32(txtid.Text));


                ExportOptions CrExportOptions;



                DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();

                PdfFormatOptions CrFormatTypeOptions = new PdfFormatOptions();

                CrDiskFileDestinationOptions.DiskFileName = "D:\\تقرير الصنف.pdf";

                CrExportOptions = myreport.ExportOptions;

                CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;

                CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;

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

        private void buttonX8_Click(object sender, EventArgs e)
        {
            try
            {
                RPT.RPT_ALL_CATEGORIES myreport = new RPT.RPT_ALL_CATEGORIES();


                ExportOptions CrExportOptions;



                DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();

                PdfFormatOptions CrFormatTypeOptions = new PdfFormatOptions();

                CrDiskFileDestinationOptions.DiskFileName = "D:\\تقرير الاصناف.pdf";

                CrExportOptions = myreport.ExportOptions;

                CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;

                CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;

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
