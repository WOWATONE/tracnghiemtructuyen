using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace TNTT.Class
{
    public class C_DeThi
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

        public DataTable GetListBybomon(string idbomon)
        {
            string sql = string.Format(@"SELECT iddethi,madethi,monhoc_idmonhoc,ngaytao,giangvien_idgiangvien,tengiangvien
            FROM DETHI,giangvien
            WHERE giangvien.idgiangvien = DETHI.giangvien_idgiangvien and monhoc_idmonhoc in (SELECT idmonhoc FROM MONHOC WHERE bomon_idbomon = {0})", idbomon);
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

        public DataTable GetListmadethi(string madethi)
        {
            string sql = @" select iddethi,madethi,tenmonhoc,listidcauhoi,monhoc_idmonhoc,ngaytao,giangvien_idgiangvien,tengiangvien FROM dethi,giangvien,monhoc 
                            WHERE giangvien.idgiangvien = dethi.giangvien_idgiangvien AND monhoc.idmonhoc = dethi.monhoc_idmonhoc 
                            and madethi = '" + madethi + "'";
            return db.GetData(sql);
        }
        public DataTable GetIDQuestionByIdDeThi(string id)
        {
            string sql = "SELECT * from dethi WHERE iddethi='"+id+"'";
            return db.GetData(sql);
        }
        public DataTable GetListAns(string condition)
        {
            string sql = "SELECT tieude,cautraloi,dapan,troncau,nhch_idnganhangcauhoi from cautraloi,nganhangcauhoi WHERE cautraloi.nhch_idnganhangcauhoi = nganhangcauhoi.idnganhangcauhoi AND nhch_idnganhangcauhoi in " + condition;
            return db.GetData(sql);
        }
    }
}
