using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TNTT.Class
{
    static class C_Random
    {
        
        public static string GetStringRandom(int n)
        {
            string strRd="";
            Random rd = new Random();
            string str = "abcdefghiklmnopqrstuvwxyzABCDEFGHIKLMNOPQRSTUVXWYZ123456789";

            while (strRd.Length < n)
            { 
                strRd+= str[rd.Next(0,str.Length)];
            }
            return strRd;
        }
    }
}
