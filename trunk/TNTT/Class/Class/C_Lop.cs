using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace TNTT.Class
{
    class C_Lop
    {
        Database.Database db = new Database.Database();

        public DataTable GetList()
        {
            string sql = "SELECT idlop,tenlop,malop,makhoa FROM LOP L, KHOA K WHERE L.khoa_idkhoa = K.idkhoa";
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }

        public void Add(string tenlop, string malop, string khoa_idkhoa)
        {
            string sql = string.Format("INSERT INTO LOP VALUES(N'{0}',N'{1}',{2})", tenlop, malop, khoa_idkhoa);
            db.ExcuteNonQuery(sql);
        }

        public void Edit(string idlop, string tenlop, string malop, string khoa_idkhoa)
        {
            string sql = string.Format(@"   UPDATE LOP SET tenlop = N'{0}',malop = N'{1}',khoa_idkhoa = {2}
                                            WHERE idlop = {3} ", tenlop, malop, khoa_idkhoa, idlop);
            db.ExcuteNonQuery(sql);
        }

        public void Delete(string idlop)
        {
            string sql = "Delete from LOP where idlop = " + idlop;
            db.ExcuteNonQuery(sql);
        }
    }
}
