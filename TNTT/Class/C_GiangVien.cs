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
        /// <summary>
        /// khai báo database
        /// </summary>
        Database.Database db = new Database.Database();
        /// <summary>
        /// Constructor
        /// </summary>
        public C_GiangVien()
        { 
        }
        /// <summary>
        /// Lấy danh sách giảng viên 
        /// </summary>
        /// <returns></returns>
        public DataTable GetList()
        {
            string sql = @" SELECT idgiangvien,magiangvien,matkhau,tengiangvien,diachi_giangvien,dienthoai_giangvien,email_giangvien,avatar_giangvien
                            ,bomon_idbomon,chucvu,tenbomon
                            FROM GIANGVIEN,BOMON
                            WHERE GIANGVIEN.bomon_idbomon = BOMON.idbomon";
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;      
        }
        public DataTable GetInfomation(string uid, string pwd)
        {
            string sql = string.Format("SELECT * FROM GIANGVIEN WHERE magiangvien='{0}' AND matkhau='{1}'", uid, pwd);
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }

        public DataTable GetListByIdLop(string idlop)
        {
            string sql = string.Format(@"SELECT  idgiangvien,tengiangvien FROM GIANGVIEN where bomon_idbomon in
	                                        (SELECT idbomon FROM BOMON 
		                                        WHERE khoa_idkhoa in 
			                                        (SELECT khoa_idkhoa FROM LOP WHERE idlop = {0}))", idlop);
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }
        public DataTable GetIdByUid(string uid)
        {
            string sql = "SELECT idgiangvien from giangvien where magiangvien='"+uid+"'"; 
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }
        public DataTable GetKhoaById(string idgiangvien)
        {
            string sql = @"Select idkhoa from KHOA 
                            where idkhoa = (select khoa_idkhoa from BOMON where idbomon =
                            (select bomon_idbomon from GIANGVIEN where idgiangvien="+idgiangvien+"))";
            return db.GetData(sql);
        }
        /// <summary>
        /// Thêm mới 1 giảng viên
        /// </summary>
        /// <param name="idgiangvien"></param>
        /// <param name="magiangvien"></param>
        /// <param name="matkhau"></param>
        /// <param name="tengiangvien"></param>
        /// <param name="diachi_giangvien"></param>
        /// <param name="dienthoai_giangvien"></param>
        /// <param name="email_giangvien"></param>
        /// <param name="avatar_giangvien"></param>
        public void Add(string magiangvien,string matkhau,string tengiangvien,string diachi_giangvien,string dienthoai_giangvien,string email_giangvien,string bomon_idbomon,string chucvu)
        {
            string sql = string.Format("INSERT INTO giangvien(magiangvien,matkhau,tengiangvien,diachi_giangvien,dienthoai_giangvien,email_giangvien,bomon_idbomon,chucvu) VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',{6},{7})", magiangvien,matkhau,tengiangvien,diachi_giangvien,dienthoai_giangvien,email_giangvien,bomon_idbomon,chucvu);
            db.ExcuteNonQuery(sql);
        }
        public void Delete(string idgiangvien)
        {
            string sql = string.Format("DELETE FROM giangvien WHERE idgiangvien={0}",idgiangvien);
            db.ExcuteNonQuery(sql);
        }
        public void Edit(string idgiangvien,string magiangvien,string matkhau,string tengiangvien,string diachi_giangvien,string dienthoai_giangvien,string email_giangvien,string bomon_idbomon,string chucvu)
        {
            string sql = string.Format("UPDATE giangvien SET magiangvien = N'{0}',matkhau=N'{1}',tengiangvien=N'{2}',diachi_giangvien=N'{3}', dienthoai_giangvien='{4}',email_giangvien=N'{5}',bomon_idbomon={6},chucvu={7} WHERE idgiangvien={8}",magiangvien,matkhau,tengiangvien,diachi_giangvien,dienthoai_giangvien,email_giangvien,bomon_idbomon,chucvu,idgiangvien);
            db.ExcuteNonQuery(sql);
        }
        public bool Login(string uid,string pwd)
        {
            string sql = string.Format("SELECT * FROM GIANGVIEN WHERE magiangvien='{0}' AND matkhau='{1}'",uid,pwd);
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt.Rows.Count == 1;                
        }
        public void ChangeAvatar(string idgiangvien, byte[] image)
        {
            string sql = "UPDATE giangvien SET avatar_giangvien = "+image+" WHERE idgiangvien="+idgiangvien;
            db.ExcuteNonQuery(sql);
        }

        public DataTable GetListByIdMonHoc(string idmonhoc)
        {
            string sql = string.Format(@"SELECT * FROM GIANGVIEN WHERE bomon_idbomon 
	                                        in (SELECT idbomon FROM BOMON WHERE idbomon
		                                        in (SELECT bomon_idbomon FROM MONHOC WHERE idmonhoc
                                                        = {0}))", idmonhoc);
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }
    }
}
