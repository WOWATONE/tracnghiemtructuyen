using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TNTT.Class
{
    public class C_Time
    {
        public string GetNowTime()
        {
            return DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
        }
    }
}
