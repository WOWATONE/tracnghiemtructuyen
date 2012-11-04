using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SINHVIEN.Class
{
    public sealed class C_Info
    {
        string masinhvien;

        public string Masinhvien
        {
            get { return masinhvien; }
            set { masinhvien = value; }
        }

        string tensinhvien;

        public string Tensinhvien
        {
            get { return tensinhvien; }
            set { tensinhvien = value; }
        }
        string lop;

        public string Lop
        {
            get { return lop; }
            set { lop = value; }
        }
        string ngaysinh;

        public string Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        byte[] avatar;

        public byte[] Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }
    }
}
