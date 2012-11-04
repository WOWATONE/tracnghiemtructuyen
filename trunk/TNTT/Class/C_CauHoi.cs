using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TNTT.Class
{
    class C_CauHoi
    {
        Database.Database db = new Database.Database();

        public DataTable GetList(string dk)
        {
            string sql = @"SELECT idnganhangcauhoi,monhoc_idmonhoc,tenmonhoc,tieude,chuong,phan,case capdo when 1 then N'Dễ' when 2 then N'Trung bình' else N'Khó' end as capdo,ngaytao,tinhtrang,giangvien_idgiangvien,tengiangvien,troncau
			from giangvien gv, monhoc mh, nganhangcauhoi ch WHERE gv.idgiangvien=ch.giangvien_idgiangvien AND ch.monhoc_idmonhoc=mh.idmonhoc" + dk;
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }
        public DataTable GetListRandom(string number,string condition)
        {
            string sql = @"SELECT TOP "+number+@" idnganhangcauhoi,monhoc_idmonhoc,tenmonhoc, tieude,chuong,phan,case capdo when 1 then N'Dễ' when 2 then N'Trung bình' else N'Khó' end as capdo,ngaytao,tinhtrang,giangvien_idgiangvien,tengiangvien,troncau
            from giangvien gv, monhoc mh, nganhangcauhoi ch WHERE gv.idgiangvien=ch.giangvien_idgiangvien AND ch.monhoc_idmonhoc=mh.idmonhoc  " + condition+ " ORDER BY NEWID()";
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }
        public DataTable GetListRePort(string condition)
        {
            string sql = "select * from View_Cauhoi"+ condition;
            return db.GetData(sql);

        }
        public DataTable GetMaxId()
        {
            string sql = @"SELECT MAX(idnganhangcauhoi) FROM nganhangcauhoi";
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }
        public DataTable GetInfoById(string id)
        { 
            string sql=@"select tieude,CAUTRALOI  from nganhangcauhoi,CAUTRALOI where CAUTRALOI.nhch_idnganhangcauhoi = NGANHANGCAUHOI.idnganhangcauhoi
                            and idnganhangcauhoi = "+id;
            return db.GetData(sql);
        }
        public void Add(string monhoc_idmonhoc,string tieude,string chuong,string phan,string capdo,string tinhtrang,string troncau,string giangvien_idgiangvien)
        {
            C_Time now = new C_Time();
            string sql = string.Format(@"SET DATEFORMAT dmy   
                                        INSERT INTO nganhangcauhoi(monhoc_idmonhoc,tieude,chuong,phan,capdo,tinhtrang,troncau,giangvien_idgiangvien,ngaytao)
                                        VALUES({0},N'{1}','{2}','{3}','{4}',{5},{6},{7},'{8}')", monhoc_idmonhoc, tieude, chuong, phan, capdo, tinhtrang,troncau,giangvien_idgiangvien,now.GetNowTime());
            db.ExcuteNonQuery(sql);
        }
        public void Delete(string idnganhangcauhoi)
        {
            string sql = "DELETE from CAUTRALOI WHERE NHCH_idnganhangcauhoi=" + idnganhangcauhoi;
            db.ExcuteNonQuery(sql);
            sql = "DELETE  from nganhangcauhoi WHERE idnganhangcauhoi= "+idnganhangcauhoi;
            db.ExcuteNonQuery(sql);
        }
        public DataTable GetListbyidnganhangcauhoi(string dk, string id)
        {
            string sql = @"SELECT idnganhangcauhoi,monhoc_idmonhoc,tenmonhoc,tieude,chuong,phan,capdo,ngaytao,tinhtrang,giangvien_idgiangvien,tengiangvien,troncau
			from giangvien gv, monhoc mh, nganhangcauhoi ch WHERE gv.idgiangvien=ch.giangvien_idgiangvien
            AND ch.monhoc_idmonhoc=mh.idmonhoc AND idnganhangcauhoi = " + id;
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }
        public void update(string idnganhangcauhoi, string monhoc_idmonhoc, string tieude, string chuong, string phan, string capdo, string tinhtrang, string troncau)
        {
            string sql = string.Format(@" SET DATEFORMAT DMY
                              UPDATE NGANHANGCAUHOI set monhoc_idmonhoc = {0},tieude = N'{1}',chuong = {2},phan = {3}
                              ,capdo = {4},tinhtrang = {5},troncau = {6}
                              WHERE idnganhangcauhoi = {7}", monhoc_idmonhoc, tieude, chuong, phan, capdo, tinhtrang, troncau, idnganhangcauhoi);
            db.ExcuteNonQuery(sql);
        }
        public DataTable GetListByIDMonHoc(string idmonhoc)
        {
            string sql = @" SELECT idnganhangcauhoi,monhoc_idmonhoc,left(tieude,100) + ' ...' as tieude,chuong,phan,case capdo when 1 then N'Dễ' when 2 then N'Trung Bình' when 3 then N'Khó' end as capdo,tinhtrang,troncau,giangvien_idgiangvien,ngaytao,magiangvien
                            FROM NGANHANGCAUHOI,GIANGVIEN
                            WHERE tinhtrang = 1 and NGANHANGCAUHOI.giangvien_idgiangvien = GIANGVIEN.idgiangvien and monhoc_idmonhoc = " + idmonhoc;
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }

        public DataTable GetListByidnganhangcauhoi(string idmonhoc)
        {
            string sql = @" SELECT idnganhangcauhoi,monhoc_idmonhoc,left(tieude,100) + ' ...' as tieude,chuong,phan,case capdo when 1 then N'Dễ' when 2 then N'Trung Bình' when 3 then N'Khó' end as capdo,tinhtrang,troncau,giangvien_idgiangvien,ngaytao,magiangvien
                            FROM NGANHANGCAUHOI,GIANGVIEN
                            WHERE tinhtrang = 1 and NGANHANGCAUHOI.giangvien_idgiangvien = GIANGVIEN.idgiangvien and idnganhangcauhoi = " + idmonhoc;
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }
    }
}
