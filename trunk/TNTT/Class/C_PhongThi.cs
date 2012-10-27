using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using TNTT.Database;

namespace TNTT.Class
{
    class C_PhongThi
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
    }
}
