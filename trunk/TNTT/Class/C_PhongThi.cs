using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using TNTT.Database;

namespace TNTT.Class
{
    public class C_PhongThi
    {
        Database.Database db = new Database.Database();
        
        public DataTable GetList()
        {
            string sql = @" SELECT idphongthi,tenphongthi,maphongthi,matkhau,dsmh_idddsmh,dethi_iddethi,ngaythi,thoigianthi,madethi,tinhtrang,idgiangvien,tongthoigianthi
                            FROM PHONGTHI PT,DSMH,DETHI DT
                            WHERE DSMH.idddsmh = PT.dsmh_idddsmh and PT.dethi_iddethi = DT.iddethi";
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }
        public DataTable GetListByDate()
        {
            string sql = @"SET DATEFORMAT DMY 
                    SELECT * FROM Phongthi
                    WHERE ngaythi = '"+DateTime.Now.ToShortDateString()+"'";
            return db.GetData(sql);
        }
        public void Add(string tenphongthi,string maphongthi,string dmsh_idddsmh,string dethi_iddethi,string ngaythi,string thoigianthi,string idgiangvien,string tongthoigianthi)
        {
            string sql = string.Format(@" SET DATEFORMAT DMY INSERT INTO PHONGTHI VALUES(N'{0}','{1}',' ',{2},{3},'{4}','{5}',0,{6},{7})"
                , tenphongthi,maphongthi, dmsh_idddsmh,dethi_iddethi,ngaythi,thoigianthi,idgiangvien,tongthoigianthi);
            db.ExcuteNonQuery(sql);
        }

        public void Delete(string idphonthi)
        {
            string sql = string.Format("DELETE FROM PHONGTHI WHERE idphongthi={0}", idphonthi);
            db.ExcuteNonQuery(sql);
        }

        public void Edit(string idphonthi, string tenphongthi, string maphongthi, string dmsh_idddsmh, string dethi_iddethi, string ngaythi, string thoigianthi,string idgiangvien, string tongthoigianthi)
        {
            string sql = string.Format(@"SET DATEFORMAT DMY UPDATE PHONGTHI set tenphongthi = N'{0}',maphongthi = '{1}', dmsh_idddsmh  = {2},dethi_iddethi = {3},ngaythi = '{4}',thoigianthi = '{5}',idgiangvien = {6},tongthoigianthi = {7}
                WHERE idphongthi = {8}", idphonthi, tenphongthi, maphongthi,  dmsh_idddsmh,dethi_iddethi,ngaythi,thoigianthi,idgiangvien,tongthoigianthi);
            db.ExcuteNonQuery(sql);
        }
        public DataTable GetListByIdGiamThi(string idgiamthi)
        {
            C_Time t = new C_Time();
            string sql = string.Format(@" set dateformat dmy
            select * from phongthi where idgiangvien={0} and ngaythi='{1}'",idgiamthi,t.GetNowTime());
            return db.GetData(sql);
        }
        public DataTable GetInfo(string masv)
        {
            string sql = @"select * from PHONGTHI,DSMH where tinhtrang= 1 and PHONGTHI.dsmh_idddsmh = DSMH.idddsmh
and lop_idlop in (select lop_idlop from SINHVIEN where masinhvien='"+masv+"')";
            return db.GetData(sql);
        }
        public void OpenRoom(string id)
        {
            string sql = "update PHONGTHI set tinhtrang = 1 where idphongthi = "+id;
            db.ExcuteNonQuery(sql);
        }
        public void CloseRoom(string id)
        {
            string sql = "update PHONGTHI set tinhtrang = 0 where idphongthi = " + id;
            db.ExcuteNonQuery(sql);
        }
    }
}
