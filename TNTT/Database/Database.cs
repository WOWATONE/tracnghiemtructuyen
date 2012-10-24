using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TNTT.Database
{
    using System.Configuration;
    class Database
    {
       
        SqlConnection sqlcnn;
        public string connstr =  "Data source =.;database=QLCHAMDIEMTRACNGHIEM;Integrated Security = True";//ConfigurationManager.ConnectionStrings["database"].ConnectionString;
        public Database()
        {
            sqlcnn = new SqlConnection(connstr);
        }
        public DataTable GetData(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql,sqlcnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void ExcuteNonQuery(string sql)
        {
            SqlCommand sqlcm = new SqlCommand(sql, sqlcnn);
            sqlcnn.Open();
            sqlcm.ExecuteNonQuery();
            sqlcnn.Close();
        }
        

    }
}
