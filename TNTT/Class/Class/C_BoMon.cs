using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TNTT.Class
{
    class C_BoMon
    {
        Database.Database db = new Database.Database();

        public DataTable GetList()
        {
            string sql = @"SELECT idbomon,tenbomon,mabomon,ghichu_bomon,makhoa FROM BOMON BM,KHOA K WHERE BM.khoa_idkhoa = K.idkhoa";
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }

        public void Add(string tenbomon, string mabomon, string ghichu_bomon, string khoa_idkhoa)
        {
            string sql = string.Format(@"   INSERT INTO BOMON VALUES(N'{0}',N'{1}',N'{2}',{3})",
                                            tenbomon,mabomon,ghichu_bomon,khoa_idkhoa);
            db.ExcuteNonQuery(sql);
        }

        public void Add(string idbomon, string tenbomon, string mabomon, string ghichu_bomon, string khoa_idkhoa)
        {
            string sql = string.Format(@"   UPDATE BOMON SET tenbomon = N'{0}',mabomon = N'{1}',ghichu_bomon = N'{2}',khoa_idkhoa = {3}
                                            WHERE idbomon = {4}", tenbomon, mabomon, ghichu_bomon,khoa_idkhoa, idbomon);
            db.ExcuteNonQuery(sql);
        }

        public void Delete(string idbomon)
        {
            string sql = "Delete from BOMON where idbomon = " + idbomon;
            db.ExcuteNonQuery(sql);
        }
    }
}
