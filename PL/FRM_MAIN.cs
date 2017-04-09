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
    public partial class FRM_MAIN : Form
    {
        private static FRM_MAIN frm;
        static void frm_fromclosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_MAIN getmainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_MAIN();
                    frm.FormClosed += new FormClosedEventHandler(frm_fromclosed);
                }
                return frm;
            }
        }

        public FRM_MAIN()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
          
        }

        //Exit Button method 
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من اغلاق البرنامج", "::خروج::", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //call to additonal applications from windows
        private void نوتبادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void حاسبهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void ووردبادToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Wordpad.exe");
        }

        private void وورداوفيسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Winword.exe");

        }

        //display dateTime to our application
        private void timer1_Tick(object sender, EventArgs e)
        {
            T1.Text = "الوقت الان هو: " + DateTime.Now.ToString("hh:mm:ss tt");
            T2.Text = "التاريخ الان هو: " + DateTime.Now.ToString("yyyy/MM/dd");
            T3.Text = "اليوم الان هو: " + new System.Globalization.CultureInfo("AR-EG").DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
        }

        //
        private void FRM_MAIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            timer2.Enabled = false;

        }

        // Adding a new user
        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER frm = new FRM_ADD_USER();
            frm.Show();
        }

        // display categories form
        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FRM_CATEGORIES FRM = new FRM_CATEGORIES();
            FRM.ShowDialog();

        }
        private void registrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER frm = new FRM_ADD_USER();
            frm.Show();
        }
        //display product form
        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTS frm = new FRM_PRODUCTS();
            frm.Show();
        }
        //display backup form
        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BACKUP FRM = new FRM_BACKUP();
            FRM.ShowDialog();
        }
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            FRM_CATEGORIES FRM = new FRM_CATEGORIES();
            FRM.ShowDialog();
        }
        //display addProduct form
        private void buttonItem3_Click(object sender, EventArgs e)
        {
            add_product FRM = new add_product();
            FRM.ShowDialog();
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTS FRM = new FRM_PRODUCTS();
            FRM.ShowDialog();
        }

        private void profileEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMERS FRM = new FRM_CUSTOMERS();
            FRM.ShowDialog();
        }

        private void loginDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_USER_LIST FRM = new FRM_USER_LIST();
            FRM.ShowDialog();
        }

        private void المشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_SHOP_LIST FRM = new FRM_SHOP_LIST();
            FRM.ShowDialog();
        }

        private void شراءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_SHOP FRM = new FRM_SHOP();
            FRM.ShowDialog();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMERS FRM = new FRM_CUSTOMERS();
            FRM.ShowDialog();
        }


        private void buttonItem6_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMERS FRM = new FRM_CUSTOMERS();
            FRM.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CUSTOMERS FRM = new FRM_CUSTOMERS();
            FRM.ShowDialog();
        }

        private void profileEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_TREDERS FRM = new FRM_TREDERS();
            FRM.ShowDialog();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDER_LIST FRM = new FRM_ORDER_LIST();
            FRM.ShowDialog();
        }

        private void stockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTS FRM = new FRM_PRODUCTS();
            FRM.ShowDialog();
        }

        private void stockToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTS FRM = new FRM_PRODUCTS();
            FRM.ShowDialog();
        }

        private void productsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTS FRM = new FRM_PRODUCTS();
            FRM.ShowDialog();
        }

        private void salesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_ORDER_LIST FRM = new FRM_ORDER_LIST();
            FRM.ShowDialog();
        }

        private void suppliersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_TREDERS FRM = new FRM_TREDERS();
            FRM.ShowDialog();
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            FRM_ORDER FRM = new FRM_ORDER();
            FRM.ShowDialog();
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            FRM_ORDER_LIST FRM = new FRM_ORDER_LIST();
            FRM.ShowDialog();
        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {
            FRM_TREDERS FRM = new FRM_TREDERS();
            FRM.ShowDialog();
        }

        private void buttonItem11_Click(object sender, EventArgs e)
        {
            FRM_SHOP FRM = new FRM_SHOP();
            FRM.ShowDialog();
        }

        private void buttonItem12_Click(object sender, EventArgs e)
        {
            FRM_SHOP_LIST FRM = new FRM_SHOP_LIST();
            FRM.ShowDialog();
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_RESTORE FRM = new FRM_RESTORE();
            FRM.ShowDialog();

        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_TREDERS FRM = new FRM_TREDERS();
            FRM.ShowDialog();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTS FRM = new FRM_PRODUCTS();
            FRM.ShowDialog();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CATEGORIES FRM = new FRM_CATEGORIES();
            FRM.ShowDialog();
        }

        private void بيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDER FRM = new FRM_ORDER();
            FRM.ShowDialog();
        }

        private void WELCOME1_Click(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        } 
    }
}
