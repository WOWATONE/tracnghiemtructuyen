﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TNTT.Class
{
    class C_SinhVien
    {
        Database.Database db = new Database.Database();

        public DataTable GetList()
        {
            string sql = @" SELECT masinhvien,tensinhvien,ngaysinh_sinhvien,diachi_sinhvien,dienthoai_sinhvien,email_sinhvien,
                            avartar_sinhvien,malop,lop_idlop from SINHVIEN SV,LOP L WHERE SV.lop_idlop = L.idlop";
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }

        public DataTable GetListbyIdLop(string idlop)
        {
            string sql = @" SELECT masinhvien,tensinhvien,ngaysinh_sinhvien,diachi_sinhvien,dienthoai_sinhvien,email_sinhvien,
                            avartar_sinhvien,malop,lop_idlop from SINHVIEN SV,LOP L WHERE SV.lop_idlop = L.idlop and SV.lop_idlop = " + idlop;
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }

        public void Add(string masinhvien, string tensinhvien, string ngaysinh_sinhvien, string diachi_sinhvien, string dienthoai_sinhvien, string email_sinhvien, string lop_idlop)
        {
            string sql = string.Format(@"   SET DATEFORMAT MDY
                                            INSERT INTO SINHVIEN(masinhvien,tensinhvien,ngaysinh_sinhvien,diachi_sinhvien,dienthoai_sinhvien,email_sinhvien,lop_idlop)
                                            VALUES(N'{0}',N'{1}','{2}',N'{3}',N'{4}',N'{5}',{6})", masinhvien, tensinhvien, ngaysinh_sinhvien, diachi_sinhvien, dienthoai_sinhvien,email_sinhvien, lop_idlop);
            db.ExcuteNonQuery(sql);
        }

        public void Edit(string masinhvien, string tensinhvien, string ngaysinh_sinhvien, string diachi_sinhvien, string dienthoai_sinhvien, string email_sinhvien, string lop_idlop)
        {
            string sql = string.Format(@"   SET DATEFORMAT MDY
                                            UPDATE SINHVIEN
                                            SET tensinhvien = N'{0}',ngaysinh_sinhvien='{1}',diachi_sinhvien=N'{2}',
                                            dienthoai_sinhvien = N'{3}',email_sinhvien = N'{4}',lop_idlop = {5}
                                            WHERE masinhvien = N'{6}'", tensinhvien, ngaysinh_sinhvien, diachi_sinhvien,
                                            dienthoai_sinhvien, email_sinhvien, lop_idlop, masinhvien);
            db.ExcuteNonQuery(sql);
        }

        public void Delete(string lop_idlop)
        {
            string sql = "Delete from SINHVIEN where MaSinhVien = " + lop_idlop;
            db.ExcuteNonQuery(sql);
        }
    }
}
