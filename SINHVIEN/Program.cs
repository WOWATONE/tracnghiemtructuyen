using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
namespace SINHVIEN
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
            Application.SetCompatibleTextRenderingDefault(false);
            Process[] pname = Process.GetProcessesByName("SINHVIEN.EXE");
            if (pname.Length == 0)
                Application.Run(new frm_MDI());
            else
                MessageBox.Show("run");
          
        }
    }
}
