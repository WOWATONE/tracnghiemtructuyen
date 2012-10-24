using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TNTT.Class
{
    class C_TraLoi
    {
        Database.Database db = new Database.Database();
        /// <summary>
        /// Hàm xóa tất cả các đáp án liên quan đến idnganhangcauhoi
        /// </summary>
        /// <param name="idnganhangcauhoi"></param>
        public void Delete(string idnganhangcauhoi)
        {
            string sql = "DELETE FROM cautraloi WHERE NHCH_idnganhangcauhoi="+idnganhangcauhoi;
            db.ExcuteNonQuery(sql);
        }
        public void Edit(string idnganhangcauhoi, string dapan, string truefalse)
        {
            string sql = "INSERT INTO cautraloi ";
        }
    }
}
