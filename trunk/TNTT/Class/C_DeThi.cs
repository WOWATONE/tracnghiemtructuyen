using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace TNTT.Class
{
    class C_DeThi
    {
        Database.Database db = new Database.Database();
        public DataTable GetList(string condition)
        {
            string sql = @"select iddethi,madethi,tenmonhoc,monhoc_idmonhoc,ngaytao,giangvien_idgiangvien,tengiangvien FROM dethi,giangvien,monhoc 
                           WHERE giangvien.idgiangvien = dethi.giangvien_idgiangvien AND monhoc.idmonhoc = dethi.monhoc_idmonhoc " + condition;
            return db.GetData(sql);
        }
        public DataTable GetListByIdMon(string idmon)
        {
            string sql = "select iddethi,madethi,monhoc_idmonhoc,ngaytao from dethi where monhoc_idmonhoc = "+idmon;
            return db.GetData(sql);
        }
        public void Add(string madethi, string listidcauhoi, string monhoc_idmonhoc, string ngaytao, string giangvien_idgiangvien)
        {
            string sql = string.Format(@"SET DATEFORMAT dmy 
                        INSERT INTO DETHI(madethi,listidcauhoi,monhoc_idmonhoc,ngaytao,giangvien_idgiangvien)
                        VALUES('{0}','{1}',{2},'{3}',{4})", madethi, listidcauhoi, monhoc_idmonhoc, ngaytao, giangvien_idgiangvien);
            db.ExcuteNonQuery(sql);
        }

        public DataTable GetListiddethi(string iddethi)
        {
            string sql = @" select iddethi,madethi,tenmonhoc,listidcauhoi,monhoc_idmonhoc,ngaytao,giangvien_idgiangvien,tengiangvien FROM dethi,giangvien,monhoc 
                            WHERE giangvien.idgiangvien = dethi.giangvien_idgiangvien AND monhoc.idmonhoc = dethi.monhoc_idmonhoc 
                            and iddethi = " + iddethi;
            return db.GetData(sql);
        }

        public void edit(string idmadethi, string madethi, string listidcauhoi, string monhoc_idmonhoc, string ngaytao, string giangvien_idgiangvien)
        {
            string sql = string.Format(@"SET DATEFORMAT dmy 
                        UPDATE DETHI set madethi = '{0}',listidcauhoi = N'{1}',monhoc_idmonhoc = {2},ngaytao = '{3}' ,giangvien_idgiangvien = {4}
                        WHERE iddethi = {5}", madethi, listidcauhoi, monhoc_idmonhoc, ngaytao, giangvien_idgiangvien, idmadethi);
            db.ExcuteNonQuery(sql);
        }
        public DataTable GetDeThi()
        {
            string sql = @"SELECT TOP 1000 [tieude]
                          ,[cautraloi]
                           FROM [QLCHAMDIEMTRACNGHIEM].[dbo].[View_Cauhoi]";
            return db.GetData(sql);
        }
    }
}
