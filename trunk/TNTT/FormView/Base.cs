using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Docking;
namespace TNTT.FormView
{
    public static class Base
    {
        public static string Encode(string str) 
        {
            str=str.Replace("'","''");
            return str;
        }
        public static string Decode(string str)
        {
            str = str.Replace("''", "'");
            return str;
        }
    }
}
