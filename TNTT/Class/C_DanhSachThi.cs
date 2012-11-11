using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace TNTT.Class
{
   public  class C_DanhSachThi
    {
        DataTable dt = new DataTable();
        Database.Database db = new Database.Database();
        public bool KiemTraDangNhap(string masinhvien, string idphongthi)
        {
            string sql = "select * from danhsachthi where sinhvien_masinhvien ='"+masinhvien+"' and phongthi_idphongthi="+idphongthi;
            dt = db.GetData(sql);
            return dt.Rows.Count == 0;
        }
    }
}
