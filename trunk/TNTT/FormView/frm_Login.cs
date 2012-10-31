using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TNTT.Class;

namespace TNTT.FormView
{
    public partial class frm_Login : DevExpress.XtraEditors.XtraForm
    {
        private string STR_ERROR = "Sai tên đăng nhập hoặc mật khẩu!";


        public delegate void LoginHandler();

        public event LoginHandler BeforeLogin;
        public event LoginHandler AfterLogin;

        void NotifyBeforeLogin()
        {
            if(BeforeLogin!=null)
                BeforeLogin();
        }
        void NotifyAfterLogin()
        {
            if(AfterLogin!=null)
                AfterLogin();
        }
        public frm_Login()
        {
            InitializeComponent();
        }
        void SetImage()
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width / 2 - img1.Width / 2;
            int y = Screen.PrimaryScreen.WorkingArea.Height / 2 - img1.Height ;
            img1.Location = new Point(x, y);
            txt_uid.Location = new Point(x+60,y+60);
            txt_pwd.Location = new Point(x+60,y+110);
            labelControl1.Location = new Point(x + 115 , y + 10);
            cmdDangNhap.Location = new Point(x + 115, y + 150);
        }
        void SaveInfo(C_GiangVien a,string uid,string pwd)
        { 
            DataTable dt = new DataTable();
            DataTable dt_khoa = new DataTable();
            dt =a.GetInfomation(uid,pwd);
            try
            {
                PreBase.obj_user.Idgiangvien = dt.Rows[0]["idgiangvien"].ToString();
                PreBase.obj_user.Magiangvien = dt.Rows[0]["magiangvien"].ToString();
                PreBase.obj_user.Diachi_giangvien = dt.Rows[0]["diachi_giangvien"].ToString();
                PreBase.obj_user.Email_giangvien = dt.Rows[0]["email_giangvien"].ToString();
                PreBase.obj_user.Bomon_idbomon = dt.Rows[0]["bomon_idbomon"].ToString();
                PreBase.obj_user.Chucvu = dt.Rows[0]["chucvu"].ToString();
                PreBase.obj_user.Hoten_giangvien = dt.Rows[0]["tengiangvien"].ToString();
                PreBase.obj_user.Matkhau = dt.Rows[0]["matkhau"].ToString();
                PreBase.obj_user.Tenbomon = dt.Rows[0]["tenbomon"].ToString();
                //Khi hinh anh nhom
                PreBase.obj_user.Avatar_giangvien = null;

                if (dt.Rows[0]["avatar_giangvien"] != null)
                    PreBase.obj_user.Avatar_giangvien = (byte[])dt.Rows[0]["avatar_giangvien"];
                dt_khoa = a.GetKhoaById(PreBase.obj_user.Idgiangvien);
                PreBase.obj_user.Idkhoa = dt_khoa.Rows[0][0].ToString();
            }
            catch { }
        }
        private void Login()
        {
            C_GiangVien a = new C_GiangVien();

            //a.login == true -> dang nhap thanh cong
            if (a.Login(txt_uid.Text, txt_pwd.Text))
            {
                SaveInfo(a, txt_uid.Text, txt_pwd.Text);
                NotifyAfterLogin();
                Close();

            }
            else
                MessageBox.Show(STR_ERROR);
        }
        private void frm_Login_Load(object sender, EventArgs e)
        {
            SetImage();
#if DEBUG
            txt_uid.Text = "admin";
            txt_pwd.Text = "123456";

#endif
        }
        private void frm_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Login();
        }

        private void txt_uid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Login();
        }

        private void txt_pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Login();
        }

        private void cmdDangNhap_Click(object sender, EventArgs e)
        {
            Login();
        }

        

 
    }
}