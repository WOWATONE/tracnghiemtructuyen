using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TNTT.Class
{
    class C_CauTraLoi
    {
        Database.Database db = new Database.Database();

        public DataTable GetList()
        {
            string sql = @"SELECT idcautraloi,nhch_idnganhangcauhoi,cautraloi,dapan FROM CAUTRALOI";
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }
        public DataTable GetListbyidnganhangcauhoi(string id)
        {
            string sql = @"SELECT idcautraloi,nhch_idnganhangcauhoi,cautraloi,dapan
                           FROM CAUTRALOI WHERE nhch_idnganhangcauhoi = " + id;
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }
        public DataTable GetListToPrint(string condition)
        {
            string sql = @"select tieude,cautraloi from NGANHANGCAUHOI,CAUTRALOI where NGANHANGCAUHOI.idnganhangcauhoi = cautraloi.nhch_idnganhangcauhoi  
"+condition;
            return db.GetData(sql);
        }
        public void Add(string idnganhangcauhoi, string cautraloi, string loaidapan)
        {
            string sql = string.Format(@"INSERT INTO CAUTRALOI VALUES ({0},N'{1}',{2})",idnganhangcauhoi,cautraloi,loaidapan);
            db.ExcuteNonQuery(sql);
        }
        public void Delete(string idcautraloi)
        {
            string sql = "DELETE from CAUTRALOI WHERE idcautraloi = " + idcautraloi;
            db.ExcuteNonQuery(sql);
        }

        public void DeleteByIdnganhangcauhoi(string nhch_idnganhangcauhoi)
        {
            string sql = "DELETE from CAUTRALOI WHERE nhch_idnganhangcauhoi = " + nhch_idnganhangcauhoi;
            db.ExcuteNonQuery(sql);
        }
    }
}
