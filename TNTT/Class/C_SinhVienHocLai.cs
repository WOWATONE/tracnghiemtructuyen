using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace TNTT.Class
{
    class C_SinhVienHocLai
    {
        Database.Database db = new Database.Database();
        public DataTable GetList(string condition)
        {
            string sql = @" select iddsmonhoclai,sinhvien_masinhvien,dsmh_idddsmh,lop_idlop,monhoc_idmonhoc,malop,mamonhoc
                            FROM DSMONHOCLAI DSHL,DSMH,LOP,MONHOC MH
                            WHERE DSMH.idddsmh = DSHL.dsmh_idddsmh and LOP.idlop = DSMH.lop_idlop and MH.idmonhoc = DSMH.monhoc_idmonhoc" + condition;
            return db.GetData(sql);
        }

        public void Add(string madsmhl, string iddsmh)
        {
            string sql = string.Format("INSERT INTO DSMONHOCLAI VALUES (N'{0}',{1});", madsmhl, iddsmh);
            db.ExcuteNonQuery(sql);
        }

        public void Edit(string iddsmonhoclai,string madsmhl, string iddsmh)
        {
            string sql = string.Format(@"   UPDATE DSMONHOCLAI SET sinhvien_masinhvien = '{0}',dsmh_idddsmh = {1}
                                            WHERE iddsmonhoclai = {2} ", madsmhl, iddsmh, iddsmonhoclai);
            db.ExcuteNonQuery(sql);
        }

        public void Delete(string iddsmonhoclai)
        {
            string sql = "Delete from DSMONHOCLAI where iddsmonhoclai = " + iddsmonhoclai;
            db.ExcuteNonQuery(sql);
        }
    }
}
