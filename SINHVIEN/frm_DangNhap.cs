using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TNTT;
using TNTT.Class;
using FirstConnectDB;
namespace SINHVIEN
{
    public partial class frm_DangNhap : DevExpress.XtraEditors.XtraForm
    {
        C_PhongThi pt = new C_PhongThi();
        C_SinhVien sv = new C_SinhVien();

        DataTable dt = new DataTable();
        DataTable dt_sv = new DataTable();
        string idphongthi = "";
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        void Init()
        {
            dt = pt.GetListByDate();
            cbo_Phong.DataSource = dt;
            cbo_Phong.DisplayMember = "tenphongthi";
            cbo_Phong.ValueMember = "idphongthi";
        }
        
        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            if (!FrmAddConnection.TestConnect())
            {
                var frm = new FrmAddConnection();

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Đã lưu cấu hình của chương trình!");
                    Application.Restart();
                }
            }
            Init();
            txt_Masv.Text = "1100021";
            txt_Matkhau.Text = "123456";
        }
        bool ValidInput()
        {
            if (txt_Masv.Text.Trim() == "")
            {
                XtraMessageBox.Show("Chưa nhập tên");
                return false;
            }
            if (cbo_Phong.SelectedIndex == -1)
            {
                XtraMessageBox.Show("Chưa chọn phòng để thi");
                return false;
            }
            if (txt_Matkhau.Text.Trim() == "")
            {
                XtraMessageBox.Show("Chưa nhập mật khẩu phòng thi");
                return false;
            }
            return true;
        }
        bool CheckLogin()
        {
            dt_sv = sv.Login(txt_Masv.Text,txt_Matkhau.Text);
            SINHVIEN.C_Base.obj.Masinhvien = txt_Masv.Text;
            DataTable dt_info = new DataTable();
            dt_info = sv.GetInfoById(txt_Masv.Text);
            if (dt_sv.Rows.Count == 1)
            {
                C_Base.obj.Tensinhvien = dt_info.Rows[0]["tensinhvien"].ToString();
                C_Base.obj.Ngaysinh = dt_info.Rows[0]["ngaysinh_sinhvien"].ToString();
                C_Base.obj.Lop = dt_info.Rows[0]["lop_idlop"].ToString();
               if(dt_info.Rows[0]["avartar_sinhvien"].ToString()!="")
                C_Base.obj.Avatar = (byte[])dt_info.Rows[0]["avartar_sinhvien"];


                //lay thong tin phong thi
                dt_info = new DataTable();
                dt_info = pt.GetInfo(txt_Masv.Text);


                C_Base.tt.Idphong = dt_info.Rows[0]["idphongthi"].ToString();
                C_Base.tt.Matkhau = dt_info.Rows[0]["Matkhau"].ToString();
                C_Base.tt.Dethi = dt_info.Rows[0]["dethi_iddethi"].ToString();
                C_Base.tt.Thoigian = dt_info.Rows[0]["tongthoigianthi"].ToString();

                if (!CheckScored())
                {
                   this.Hide();
                    //XtraMessageBox.Show("Sinh viên có MSSV:" + txt_Masv.Text + " đã nộp bài");
                    frm_KetQuaBaiThi frm = new frm_KetQuaBaiThi();
                    frm.ShowDialog();
                    this.Close();
                    return false;
                }
                return true;
            }  
            XtraMessageBox.Show("Đăng nhập không thành công");
            return false;
        }
        private void cmd_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Kiểm tra đã nộp bài và chấm điểm hay chưa
        /// 
        /// </summary>
        /// <returns></returns>
        bool CheckScored()
        {
            C_DanhSachThi dst = new C_DanhSachThi();
            return  dst.KiemTraDangNhap(txt_Masv.Text,cbo_Phong.SelectedValue.ToString());
        }
        bool CheckExitsUserLogin()
        {
            DataTable dt_temp = new DataTable();
            C_DanhSachDangThi dangthi=  new C_DanhSachDangThi();
            dt_temp = dangthi.GetList(C_Base.tt.Idphong,C_Base.obj.Masinhvien);
            if (dt_temp.Rows.Count >= 1)
            {
                XtraMessageBox.Show("Sinh viên "+C_Base.obj.Tensinhvien+" đang đăng nhập hệ thống tại 1 máy khác");
                return false;
            }
            return true;
        }
        private void cmd_DangNhap_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {

                if (CheckLogin() && CheckExitsUserLogin())
                {
                    Hide();
                    frm_MDI frm = new frm_MDI();
                    frm.ShowDialog();
                    Close();
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           // frm_KetQuaBaiThi 
        }
    }
}