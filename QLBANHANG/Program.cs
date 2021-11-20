using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QLBANHANG
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); //TheAnh up code mới vào đây
                Application.Run(new frm_Main());
        }
    }
}
