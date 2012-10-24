using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace TNTT.Class
{
    class C_Khoa
    {
        Database.Database db = new Database.Database();
        public DataTable GetList()
        {
            string sql = "SELECT idkhoa,tenkhoa,makhoa,ghichu_khoa FROM KHOA";
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }

        public void Add(string tenkhoa, string makhoa, string ghichu_khoa)
        {
            string sql = string.Format(@"INSERT INTO KHOA VALUES (N'{0}',N'{1}',N'{2}')", tenkhoa, makhoa, ghichu_khoa);
            db.ExcuteNonQuery(sql);
        }

        public void Edit(string idkhoa,string tenkhoa, string makhoa, string ghichu_khoa)
        {
            string sql = string.Format(@"UPDATE KHOA SET tenkhoa = N'{0}',makhoa = N'{1}',ghichu_khoa = N'{2}' WHERE idkhoa = {3} "
                                            ,tenkhoa, makhoa, ghichu_khoa,idkhoa);
            db.ExcuteNonQuery(sql);
        }

        public void Delete(string idkhoa)
        {
            string sql = "Delete from KHOA where idkhoa = " + idkhoa;
            db.ExcuteNonQuery(sql);
        }
    }
}
