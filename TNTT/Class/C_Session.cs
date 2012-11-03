using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TNTT.Class
{
    public sealed class C_Session
    {
        /// <summary>
        /// Lưu thông tin id giảng viên
        /// </summary>
        private string idgiangvien;

        public string Idgiangvien
        {
            get { return idgiangvien; }
            set { idgiangvien = value; }
        }
        /// <summary>
        /// Thông tin mã giảng viên
        /// </summary>
        private string magiangvien;

        public string Magiangvien
        {
            get { return magiangvien; }
            set { magiangvien = value; }
        }

        /// <summary>
        /// Dia chi giang vien
        /// </summary>
        private string hoten_giangvien;

        public string Hoten_giangvien
        {
            get { return hoten_giangvien; }
            set { hoten_giangvien = value; }
        }
        private string diachi_giangvien;

        public string Diachi_giangvien
        {
            get { return diachi_giangvien; }
            set { diachi_giangvien = value; }
        }
        /// <summary>
        /// Avatar giảng viên
        /// </summary>
        private byte[] avatar_giangvien;

        public byte[] Avatar_giangvien
        {
            get { return avatar_giangvien; }
            set { avatar_giangvien = value; }
        }
        /// <summary>
        /// Email _giang vien
        /// </summary>
        private string email_giangvien;

        public string Email_giangvien
        {
            get { return email_giangvien; }
            set { email_giangvien = value; }
        }
        /// <summary>
        /// Chức vụ giảng viên
        /// </summary>
        private string chucvu;

        public string Chucvu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }
        /// <summary>
        /// Bo
        /// </summary>
        private string bomon_idbomon;

        public string Bomon_idbomon
        {
            get { return bomon_idbomon; }
            set { bomon_idbomon = value; }
        }
        private string idkhoa;

        public string Idkhoa
        {
            get { return idkhoa; }
            set { idkhoa = value; }
        }
        private string matkhau;

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
        private string tenbomon;

        public string Tenbomon
        {
            get { return tenbomon; }
            set { tenbomon = value; }
        }
        private bool isConnect = false;

        public bool IsConnect
        {
            get { return isConnect; }
            set { isConnect = value; }
        }



    }
}
