using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace TNTT.Class
{
    class C_GiangVien
    {
        Database.Database db = new Database.Database();
        public C_GiangVien()
        { 
        }
        public DataTable LayDS()
        {
            string sql = "SELECT * FROM giangvien";
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
            
        }
    }
}
