using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace TNTT.Class
{
    public static class C_Valid
    {
        public static bool isEmail(string email)
        {
            //string temp = email.Substring(email.LastIndexOf('@')+1);
            //if (temp != null)
            //{
            //    temp = temp.Substring(temp.LastIndexOf('.')+1);
            //    //MessageBox.Show(temp);
            //    if (temp != null)
            //        return true;
            //    XtraMessageBox.Show("Địa chỉ email không hợp lệ");
            //    return false;
            //}
            //return false;
            return true;
        }
        public static bool isName(string name)
        {
            for (int i = 0; i < name.Length; i++)
                if (name[i] >='0' && name[i] <= '9')
                    return false;
            return true;
        }
        public static bool isPhone(string phone)
        {
            if (phone.Length <= 9 || phone.Length>=12)
            {
                XtraMessageBox.Show("Độ dài không cho phép");
                return false;
            }
            for (int i = 0; i < phone.Length; i++)
                if ((char)phone[i] < '0' || (char)phone[i] > '9')
                {
                    XtraMessageBox.Show("Số điện thoại không được chứa ký tự");
                    return false;
                }
            return true;
        }
    }
}
