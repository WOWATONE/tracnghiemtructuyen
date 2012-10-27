﻿using System;
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
            string sql = @"select madethi,tenmonhoc,monhoc_idmonhoc,ngaytao,giangvien_idgiangvien,tengiangvien FROM dethi,giangvien,monhoc 
                           WHERE giangvien.idgiangvien = dethi.giangvien_idgiangvien AND monhoc.idmonhoc = dethi.monhoc_idmonhoc "+condition;
            return db.GetData(sql);
        }
        public void Add(string madethi, string listidcauhoi, string monhoc_idmonhoc, string ngaytao, string giangvien_idgiangvien)
        {
            string sql = string.Format(@"SET DATEFORMAT dmy 
                        INSERT INTO DETHI(madethi,listidcauhoi,monhoc_idmonhoc,ngaytao,giangvien_idgiangvien)
                        VALUES('{0}','{1}',{2},'{3}',{4})",madethi,listidcauhoi,monhoc_idmonhoc,ngaytao,giangvien_idgiangvien);
            db.ExcuteNonQuery(sql);
        }
    }
}