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
            Application.SetCompatibleTextRenderingDefault(false); //ví dụ sửa file main nè
                Application.Run(new frm_Main());
        }
    }
}
