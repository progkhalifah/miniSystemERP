using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Accounting.PL;

namespace System_Accounting
{
    static class Program
    {

        public static string uname;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static string username;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Login());
        }
    }
}
