using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace TNTT.Class
{
    public class C_DanhSachDangThi
    {
        Database.Database db = new Database.Database();
        public  DataTable GetList(string idphong,string masv)
        {
            string sql = "select * from danhsachdangthi where idphong="+idphong+" and masinhvien='"+masv+"'";
            return db.GetData(sql);
        }
        public void Add(string idphong,string masv)
        {
            string sql = "insert into danhsachdangthi values('" + masv + "'," + idphong + ")";
            db.ExcuteNonQuery(sql);
        }
        public void Delete(string masv, string idphong)
        {
            string sql = "delete from danhsachdangthi where idphong=" + idphong + " and masinhvien='" + masv + "'";
            db.ExcuteNonQuery(sql);
        }
    }
}
