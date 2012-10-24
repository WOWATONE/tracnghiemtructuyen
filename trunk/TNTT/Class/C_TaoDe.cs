using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TNTT.Class
{
    class C_TaoDe
    {
        Database.Database db = new Database.Database();

        public DataTable GetList()
        {
            string sql = "SELECT * FROM DETHI";
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }

        public void Add(string madethi, string listidcauhoi, string monhoc_idmonhoc, string ngaytao, string giangvien_idgiangvien)
        {
            string sql = string.Format(@"   SET DATEFORMAT DMY
                                            INSERT INTO DETHI VALUES ('{0}','{1}',{2},'{3}',{4})"
                                            , madethi, listidcauhoi, monhoc_idmonhoc, ngaytao, giangvien_idgiangvien);
            db.ExcuteNonQuery(sql);
        }
    }
}
