using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace TNTT.Class
{
    class C_MonHoc
    {
        Database.Database db = new Database.Database();

        public DataTable GetList()
        {
            string sql = "SELECT idmonhoc,mamonhoc,tenmonhoc,ghichu_monhoc,bomon_idbomon,idbomon,tenbomon from MONHOC mh,BOMON bm where bm.idbomon = mh.bomon_idbomon";
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }
        public DataTable GetListByKhoa(string idkhoa)
        {
            string sql = @"SELECT idnganhangcauhoi,monhoc_idmonhoc,tenmonhoc,tieude,chuong,phan,capdo,ngaytao,tinhtrang,giangvien_idgiangvien,tengiangvien
		                  from giangvien gv, monhoc mh, nganhangcauhoi ch WHERE gv.idgiangvien=ch.giangvien_idgiangvien AND ch.monhoc_idmonhoc=mh.idmonhoc
			              AND mh.bomon_idbomon IN (select idbomon from bomon where khoa_idkhoa =" + idkhoa + ")";
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }
        public DataTable GetListByIdLop(string idlop)
        {
            string sql = string.Format(@" SELECT  * FROM MONHOC where bomon_idbomon in
	                            (SELECT idbomon FROM BOMON 
		                            WHERE khoa_idkhoa in 
			                            (SELECT khoa_idkhoa FROM LOP WHERE idlop = {0}))", idlop);
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }

        public void Add(string mamh, string tenmh, string ghichu_bomon,string idbomon)
        {
            string sql = string.Format("INSERT INTO MONHOC VALUES(N'{0}',N'{1}',N'{2}',{3})", mamh, tenmh, ghichu_bomon,idbomon);
            db.ExcuteNonQuery(sql);
        }

        public void Edit(string idmh,string mamh, string tenmh, string ghichu_bomon, string idbomon)
        {
            string sql = string.Format(@"UPDATE MONHOC SET tenmonhoc = N'{0}',mamonhoc = N'{1}',ghichu_monhoc = N'{2}',bomon_idbomon={3} WHERE idmonhoc = {4} ", tenmh, mamh, ghichu_bomon, idbomon,idmh);
            db.ExcuteNonQuery(sql);
        }

        public void Delete(string idmonhoc)
        {
            string sql = "Delete from MONHOC where idlop = " + idmonhoc;
            db.ExcuteNonQuery(sql);
        }

        public DataTable GetListByIDBoMon(string idbomon)
        {
            string sql = @"SELECT idmonhoc,mamonhoc,tenmonhoc,ghichu_monhoc,bomon_idbomon FROM MONHOC WHERE bomon_idbomon = " + idbomon;
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }
    }
}
