using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
namespace SINHVIEN
{
    public partial class frm_KetQuaBaiThi : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        public frm_KetQuaBaiThi()
        {
            InitializeComponent();
        }
        public frm_KetQuaBaiThi(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }
        public void LoadImage()
        {
            try
            {
                MemoryStream ms = new MemoryStream((byte[])C_Base.obj.Avatar);
                pictureBox1.Image = Image.FromStream(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Refresh();
            }
            catch
            {
                pictureBox1.Image = Image.FromFile(@"Avatar/1.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Refresh();
            }
        }
        void LoadInfo()
        {
            LoadImage();
            lb_tensv.Text = C_Base.obj.Tensinhvien;
            lb_lop.Text = C_Base.obj.Lop;
            lb_mssv.Text = C_Base.obj.Masinhvien;
            lb_ngaysinh.Text = DateTime.Now.ToShortDateString();
        }
      
        private void frm_KetQuaBaiThi_Load(object sender, EventArgs e)
        {
            LoadImage();
            LoadInfo();
        
        }

        private void cmd_Thoat_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có thực sự muốn thoát chương trình", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.ExitThread();
            }
        }

        private void cmd_Hoanthanh_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

       
    }
}