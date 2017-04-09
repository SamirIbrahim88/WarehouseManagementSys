using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WarehouseManagementSystem1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static string SALESMAN;
        public static string PAYMAN;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new PL.FRM_BACKUP());
            Application.Run(new PL.FRM_LOGIN());
        }
    }
}
