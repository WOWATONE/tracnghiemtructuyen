using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SINHVIEN.Class;
using System.Diagnostics;
namespace SINHVIEN
{
    public static class C_Base
    {
        public static C_Info obj = new C_Info();
        public static C_ThongTinPhong tt = new C_ThongTinPhong();
        public static bool IsProcessOpen(string name)
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                
                if (clsProcess.ProcessName==name)               
                    return true;
            }
            return false;
        }
    }
}
