using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WarehouseManagementSystem1.PL
{
    public partial class main : Form
    {
        private static main frm;
        static void frm_fromclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static main getmainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new main();
                    frm.FormClosed += new FormClosedEventHandler(frm_fromclosed);
                }
                return frm;
            }


        }
        public main()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;

            

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void اضافهصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_product Form = new add_product();
            Form.Show();
        }

        private void تعديلصنفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTS childForm = new FRM_PRODUCTS();
            childForm.Show();
        }
        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ادارهالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMERS frm = new FRM_CUSTOMERS();
            frm.Text = " اداره العملاء ";
            frm.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ادارهالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDER_LIST childForm = new FRM_ORDER_LIST();
            childForm.Text = "اداره المبيعات";
            childForm.Show();
        }

        private void اضافهبيعجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDER childForm = new FRM_ORDER();
            childForm.Text = "المبيعات";
            childForm.Show();
        }

        private void عملنسخهاحتياطيهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BACKUP frm = new FRM_BACKUP();
            frm.ShowDialog();
        }

        private void استعادهالنسخهالاحتياطيهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_RESTORE frm = new FRM_RESTORE();
            frm.Show();
        }

        private void اضافهمستخدمToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER childForm = new FRM_ADD_USER();
            childForm.Text = "اضافه مستخدم";
            childForm.Show();
        }

        private void ادارهالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_USER_LIST frm = new FRM_USER_LIST();
            frm.ShowDialog();
        }

        private void تسجيلدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_LOGIN frm = new FRM_LOGIN();
            frm.ShowDialog();
        }

        private void تسجيلخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد عمل نسخه احتياطيه للنظام", " تسجيل الخروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FRM_BACKUP frm = new FRM_BACKUP();
                frm.ShowDialog();
            }
            this.Close();
        }

        private void ادارهالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_TREDERS childForm = new FRM_TREDERS();
            childForm.Text = "  اداره الموردين  ";
            childForm.Show();
        }

        private void اToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_SHOP childForm = new FRM_SHOP();
            childForm.Text = "  فاتوره شراء ";
            childForm.Show();
        }

        private void ادارهالاصنافToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FRM_CATEGORIES childForm = new FRM_CATEGORIES();
            childForm.Text = " اداره الاصناف ";
            childForm.Show();
        }

        private void ادارهالمشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_SHOP_LIST childForm = new FRM_SHOP_LIST();
            childForm.Text = " اداره المشتريات ";
            childForm.Show();
        }



        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_SHOP childForm = new FRM_SHOP();
            childForm.Text = "  فاتوره شراء ";
            childForm.Show();
        }

        private void ribbonBar1_ItemClick(object sender, EventArgs e)
        {

        }

        private void المستخدمينToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void اعدادالاتصالبالسيرفرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CONFIG childForm = new FRM_CONFIG();
            childForm.Show();
        }

    }
}
