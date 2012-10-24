using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace TNTT.Class
{
    class C_BoMon
    {
        Database.Database db = new Database.Database();
        public C_BoMon()
        { 
        }
        public DataTable GetList()
        {
            string sql = "SELECT idbomon,mabomon,tenbomon,ghichu_bomon,tenkhoa,khoa_idkhoa from khoa,bomon WHERE bomon.khoa_idkhoa=khoa.idkhoa";
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }
        public void Add(string tenbomon,string mabomon,string ghichu_bomon,string khoa_idkhoa)
        {
            string sql = string.Format("INSERT INTO bomon(tenbomon,mabomon,ghichu_bomon,khoa_idkhoa) VALUES('N{0}',N'{1}',N'{2}',{3})", tenbomon,mabomon, ghichu_bomon, khoa_idkhoa);
            db.ExcuteNonQuery(sql);
        }
        public void Delete(string idbomon)
        {
            string sql = string.Format("DELETE FROM bomon WHERE idbomon={0}", idbomon);
            db.ExcuteNonQuery(sql);
        }
        public void Edit(string idbomon, string tenbomon, string mabomon, string ghichu_bomon, string khoa_idkhoa)
        {
            string sql = string.Format("UPDATE bomon SET tenbomon=N'{0}',mabomon=N'{1}',ghichu_bomon=N'{2}', khoa_idkhoa={3} WHERE idbomon={4}",tenbomon,mabomon,ghichu_bomon,khoa_idkhoa,idbomon);
            db.ExcuteNonQuery(sql);
        }
    }
}
