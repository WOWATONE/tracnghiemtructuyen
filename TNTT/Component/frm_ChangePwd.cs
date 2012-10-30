using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TNTT.Component
{
    public partial class frm_ChangePwd : DevExpress.XtraEditors.XtraForm
    {
        string strimg;
        public frm_ChangePwd()
        {
            InitializeComponent();
        }
        void LoadCatpcha()
        {
            strimg = Class.C_Random.GetStringRandom(6);
            pictureBox1.Image = Com_Base.Convert_Text_to_Image(strimg, "Bookman Old Style", 20); // Passing appropriate value to Convert_Text_to_Image method 
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void frm_ChangePwd_Load(object sender, EventArgs e)
        {
            LoadCatpcha();
            cmd_Hide.Visible = cmd_Hide1.Visible = cmd_Hide2.Visible = false;
        }

        private void cmd_Refresh_Click(object sender, EventArgs e)
        {
            LoadCatpcha();
        }

        private void cmd_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        bool ValidInput()
        {
            if (txt_Matkhaucu.Text.Trim() == "")
            {
                XtraMessageBox.Show("Chưa nhập mật khẩu cũ");
                return false;
            }
            if (txt_MatKhauMoi.Text.Trim() == "")
            {
                XtraMessageBox.Show("Chưa nhập mật khẩu mới");
                return false;
            }
            if (txt_Xacnhanmk.Text.Trim() != txt_MatKhauMoi.Text.Trim())
            {
                XtraMessageBox.Show("Mật khẩu nhập 2 lần phải trùng nhau");
                return false;
            }
            if(txt_Maxacnhan.Text.Trim()!=strimg)
            {
                XtraMessageBox.Show("Bạn nhập mã xác nhận sai");
                return false;
            }
            if (txt_Matkhaucu.Text.ToLower() != Class.PreBase.obj_user.Matkhau.ToLower())
            {
                XtraMessageBox.Show("Mật khẩu cũ không hợp lệ");
                return false;
            }
            return true;
        }
        private void cmd_save_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                Class.C_GiangVien gv = new Class.C_GiangVien();
                gv.ChangePwd(Class.PreBase.obj_user.Magiangvien, txt_MatKhauMoi.Text);
                this.Hide();
                XtraMessageBox.Show("Đổi mật khẩu thành công");
                this.Close();
            }
        }

        private void txt_Matkhaucu_TextChanged(object sender, EventArgs e)
        {
            if (txt_Matkhaucu.Text.Trim() == "")
                cmd_Hide.Visible = false;
            else
                cmd_Hide.Visible = true;
        }

        private void txt_MatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            if (txt_MatKhauMoi.Text.Trim() == "")
                cmd_Hide1.Visible = false;
            else
                cmd_Hide1.Visible = true;
        }

        private void txt_Xacnhanmk_TextChanged(object sender, EventArgs e)
        {
            if (txt_Xacnhanmk.Text.Trim() == "")
                cmd_Hide2.Visible = false;
            else
                cmd_Hide2.Visible = true;
        }

        private void cmd_Hide_MouseDown(object sender, MouseEventArgs e)
        {
            txt_Matkhaucu.Properties.UseSystemPasswordChar = false;
        }

        private void cmd_Hide_MouseUp(object sender, MouseEventArgs e)
        {
            txt_Matkhaucu.Properties.UseSystemPasswordChar = true;
        }

        private void cmd_Hide1_MouseDown(object sender, MouseEventArgs e)
        {
            txt_MatKhauMoi.Properties.UseSystemPasswordChar = false;
        }

        private void cmd_Hide2_MouseDown(object sender, MouseEventArgs e)
        {
            txt_Xacnhanmk.Properties.UseSystemPasswordChar = false;
        }

        private void cmd_Hide1_MouseUp(object sender, MouseEventArgs e)
        {
            txt_MatKhauMoi.Properties.UseSystemPasswordChar = true;
        }

        private void cmd_Hide2_MouseUp(object sender, MouseEventArgs e)
        {
            txt_Xacnhanmk.Properties.UseSystemPasswordChar = true;
        }

    }
}