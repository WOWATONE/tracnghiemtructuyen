using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using TNTT.FormView;
using TNTT.Class;
namespace TNTT
{
    public partial class frm_MDI : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_MDI()
        {
            InitializeComponent();
            InitSkinGallery();

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void frm_MDI_Load(object sender, EventArgs e)
        {
            
            Login();
        }

        public void BeforeLogin()
        {
            PreBase.CloseAllForm(this);
            PreBase.VisibleMenu(this, false);
            rpg_Infomation.Visible = false;
        }
        public void AfterLogin()
        {
            ///xử lý các sự kiện sau khi đăng nhập như phân quyền, lưu thông tin user,hiển thị forrm mặc định
            btn_Login.Caption = "Đăng Xuất";
            btn_Login.LargeGlyph = Properties.Resources.logout;
            siStatus.Caption = PreBase.obj_user.Hoten_giangvien;

            rpg_Infomation.Visible = true;
            PreBase.VisibleMenu(this, true);

            string pq = PreBase.UserAcessControl(int.Parse(PreBase.obj_user.Chucvu));
            for (int i = 0; i < pq.Length; i++)
                if (pq[i] == '1')
                    this.Ribbon.Pages[i].Visible = true;
                else
                    this.Ribbon.Pages[i].Visible = false;
            PreBase.DefaultFormAfterLogin(PreBase.obj_user.Chucvu, this);
        }
        public void Login()
        {
            try
            {
                BeforeLogin();
                var x = typeof(frm_Login);
                var frm = (frm_Login)PreBase.GetChild(this, x.FullName);
                if (frm == null || frm.IsDisposed)
                {
                    frm = new frm_Login();
                    frm.MdiParent = this;
                }
                frm.BeforeLogin += BeforeLogin;
                frm.AfterLogin += AfterLogin;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_Login_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btn_Login.Caption == "Đăng Xuất")
            {
                btn_Login.Caption = "Đăng Nhập";
                btn_Login.LargeGlyph = Properties.Resources.login1;
                siStatus.Caption = "Khách!";
            }
            Login();
        }

        private void iExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btn_Bomon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PreBase.ShowForm<FormView.frm_BoMon>(this);
        }

        private void btn_khoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PreBase.ShowForm<FormView.frm_Khoa>(this);
        }

        private void btn_lop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PreBase.ShowForm<FormView.frm_Lop>(this);
        }

        private void btn_ChangeInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PreBase.ShowForm<FormView.frm_Infomation>(this);
        }

        private void btn_Setup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PreBase.ShowDiaLog<FormView.frm_Config>(this);
        }

        private void btn_Monhoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PreBase.ShowForm<FormView.frm_MonHoc>(this);
        }

        private void btn_CloseAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PreBase.CloseAllForm(this);
        }

        private void btn_sinhvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PreBase.ShowForm<FormView.frm_SinhVien>(this);
        }

        private void btn_Exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Giangvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PreBase.ShowForm<FormView.frm_GiangVien>(this);
        }

        private void btn_dmmh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PreBase.ShowForm<FormView.frm_DSMH>(this);
        }

        private void btn_Question_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PreBase.ShowForm<FormView.frm_Nganhangcauhoi>(this);
        }

        private void btn_DeThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PreBase.ShowForm<FormView.frm_DeThi>(this);
        }

        private void btn_TaoDeNH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PreBase.ShowDiaLog<FormView.frm_TaoDeNH>(this);
        }

        private void btn_TaoDeTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PreBase.ShowDiaLog<FormView.frm_TaoDeThuCong>(this);
        }

        private void btn_Backup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void btn_Phongthi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PreBase.ShowForm<FormView.frm_Phongthi>(this);
        }

        private void TabMDI_SelectedPageChanged(object sender, EventArgs e)
        {
           
        }

        private void ribbonGalleryBarItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_ChangePass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PreBase.ShowDiaLog<Component.frm_ChangePwd>(this);
        }
    }
}