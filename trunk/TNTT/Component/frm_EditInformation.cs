using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TNTT.Class;
namespace TNTT.Component
{
    public partial class frm_EditInformation : DevExpress.XtraEditors.XtraForm
    {
        public delegate void EditHandler();
        public event EditHandler Infomation;

        public frm_EditInformation()
        {
            InitializeComponent();
        }
        public void Init()
        {
            txt_hoten.Text = PreBase.obj_user.Hoten_giangvien;
            txt_Diachi.Text = PreBase.obj_user.Diachi_giangvien;
            txt_Email.Text = PreBase.obj_user.Email_giangvien;
        }
        bool ValidInput()
        {
            if (txt_hoten.Text.Trim() == "")
            {
                XtraMessageBox.Show("Chưa nhập họ tên");
                return false;
            }
            return true;
        }
        private void cmd_Save_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                Class.C_GiangVien gv = new Class.C_GiangVien();
                gv.UpdateInfo(PreBase.obj_user.Idgiangvien, txt_hoten.Text, txt_Diachi.Text, txt_Email.Text);
                PreBase.obj_user.Hoten_giangvien = txt_hoten.Text;
                PreBase.obj_user.Diachi_giangvien = txt_Diachi.Text;
                PreBase.obj_user.Email_giangvien = txt_Email.Text;
                XtraMessageBox.Show("Cập nhật thông tin thành công");
                Infomation();
                Close();
            }
        }

        private void frm_EditInformation_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}