using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace TNTT.Class
{
    class C_DSMH
    {
        Database.Database db = new Database.Database();
        public DataTable GetList()
        {
            string sql = @" SELECT idddsmh,lop_idlop,monhoc_idmonhoc,giangvien_idgiangvien,ngayhoc,malop,mamonhoc,tengiangvien
                            FROM DSMH DS,LOP L,MONHOC MH,GIANGVIEN GV
                            WHERE DS.lop_idlop = L.idlop and DS.monhoc_idmonhoc = MH.idmonhoc and DS.giangvien_idgiangvien = GV.idgiangvien";
            DataTable dt = new DataTable();
            dt = db.GetData(sql);
            return dt;
        }

        public void Add(string lop_idlop, string monhoc_idmonhoc, string giangvien_idgiangvien, string ngayhoc)
        {
            string sql = string.Format(@"   SET DATEFORMAT DMY
                                            INSERT INTO DSMH VALUES ({0},{1},{2},'{3}')"
                                            , lop_idlop, monhoc_idmonhoc,giangvien_idgiangvien, ngayhoc);
            db.ExcuteNonQuery(sql);
        }

        public void Edit(string idddsmh, string lop_idlop, string monhoc_idmonhoc, string giangvien_idgiangvien, string ngayhoc)
        {
            string sql = string.Format(@"   SET DATEFORMAT DMY
                                            UPDATE DSMH SET lop_idlop = {0}',monhoc_idmonhoc = {1},
                                            giangvien_idgiangvien = {2},ngayhoc=N'{3}' WHERE idddsmh = N'{4}' "
                                            , lop_idlop, monhoc_idmonhoc, giangvien_idgiangvien, ngayhoc, idddsmh);
            db.ExcuteNonQuery(sql);
        }

        public void Delete(string idddsmh)
        {
            string sql = "Delete from DSMH where idddsmh = " + idddsmh;
            db.ExcuteNonQuery(sql);
        }
    }
}
