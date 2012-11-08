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

    /// <summary>
    /// Chức năng tạo phòng thi chỉ dành cho quản lý khoa, còn giám thị và giảng viên có chức năng mở phòng => do giảng viên cũng có thể gác thi
    /// </summary>
    public partial class frm_Phongthi : frm_tool
    {
        C_Lop lop = new C_Lop();
        C_GiangVien gv = new C_GiangVien();
        C_DeThi dethi = new C_DeThi();
        C_MonHoc mh = new C_MonHoc();
        C_PhongThi pt = new C_PhongThi();

        //lớp
        DataTable dt_lop = new DataTable();
        //giảng viên
        DataTable dt_gv = new DataTable();
        //môn học
        DataTable dt_mh = new DataTable();
        //đề thi
        DataTable dt_dth = new DataTable();
        DataTable temp = new DataTable();
        DataTable dt = new DataTable();
        /// <summary>
        /// Trạng thái của form : Thêm - Sửa
        /// </summary>
        string state = "";
        public frm_Phongthi()
        {
            InitializeComponent();
        }

        private void frm_Phongthi_Load(object sender, EventArgs e)
        {
            Init();
        }
        /// <summary>
        /// Load danh sách lớp lên lookup edit 
        /// </summary>
        void LoadLop()
        {
            dt_lop = lop.GetList();
            lk_lop.Properties.DataSource = dt_lop;
            lk_lop.Properties.DisplayMember = "tenlop";
            lk_lop.Properties.ValueMember = "idlop";
        }
        /// <summary>
        /// Load danh sách môn học lên lookup edit
        /// </summary>
        /// <param name="idlop"></param>
        void LoadMonHocByIdLop(string idlop)
        {
            dt_mh = mh.GetListFromDMMH(idlop);
            lk_monthi.Properties.DataSource = dt_mh;
            lk_monthi.Properties.ValueMember = "idmonhoc";
            lk_monthi.Properties.DisplayMember = "tenmonhoc";
        }
        /// <summary>
        /// Load những đề thi nào thuộc những môn học đó
        /// </summary>
        /// <param name="idmon"></param>
        void LoadDeThiByMonHoc(string idmon)
        {
            dt_dth = dethi.GetListByIdMon(idmon);
            cbo_made.DataSource = dt_dth;
            cbo_made.DisplayMember = "madethi";
            cbo_made.ValueMember = "iddethi";
        }
        /// <summary>
        /// Load danh sách giảng viên gác thi
        /// </summary>
        void LoadGiangVien()
        {
            dt_gv = gv.GetList();
            cbo_giangvien.DataSource = dt_gv;
            cbo_giangvien.ValueMember = "idgiangvien";
            cbo_giangvien.DisplayMember = "tengiangvien";
        }
        #region Override 
        public override void DataBind()
        {
            ClearDataBind();
            txt_Maphong.DataBindings.Add("text", dt, "maphongthi");
            txt_TenPhong.DataBindings.Add("text", dt, "tenphongthi");
            //lk_lop.DataBindings.Add("editvalue", dt, "tenlop");
            //lk_monthi.DataBindings.Add("editvalue", dt, "monhoc_idmonhoc");
            cbo_made.DataBindings.Add("SelectedValue",dt,"dethi_iddethi");
            cbo_giangvien.DataBindings.Add("SelectedValue", dt, "idgiangvien");
            //date_ngaythi.DataBindings.Add("Value",dt,"thoigianthi");

            base.DataBind();
        }
        public override void ClearDataBind()
        {
            txt_Maphong.DataBindings.Clear();
            txt_TenPhong.DataBindings.Clear();
            lk_lop.DataBindings.Clear();
            lk_monthi.DataBindings.Clear();
            cbo_giangvien.DataBindings.Clear();
            cbo_made.DataBindings.Clear();
            date_ngaythi.DataBindings.Clear();
            time_batdau.DataBindings.Clear();
            spin_tongthoigian.DataBindings.Clear();
            base.ClearDataBind();
        }
        /// <summary>
        /// Phân quyền truy cập chức năng của các user
        /// </summary>
        public override void UserAccessFunction()
        {
            if(int.Parse(PreBase.obj_user.Chucvu) <= 4)
                AllowDelete = false;
                base.UserAccessFunction();
        }
        void LoadList()
        {
            dt = pt.GetList();
            grd_pt.DataSource = dt;
        }
        /// <summary>
        /// Khởi tạo chương trình loaad thông tin cần thiết
        /// </summary>
        public override void Init()
        {
            LoadList();
            LoadGiangVien();
            LoadLop();
            DataBind();
            base.Init();
        }
        /// <summary>
        /// Xóa trắng các textbox - reset lại các controls
        /// </summary>
        public override void ResetInput()
        {
            txt_Maphong.ResetText();
            txt_TenPhong.ResetText();
            cbo_giangvien.SelectedIndex = -1;
            lk_lop.ItemIndex = -1;
            lk_monthi.ItemIndex = -1;
            time_batdau.Text = "0";
            spin_tongthoigian.Value = 0;
            base.ResetInput();
        }
        /// <summary>
        /// Trạng thái thêm xóa sửa
        /// </summary>
        /// <param name="flag"></param>
        public override void Click_Perform(bool flag)
        {
            txt_Maphong.Enabled = txt_TenPhong.Enabled = !flag;
            cbo_giangvien.Enabled = lk_lop.Enabled = lk_monthi.Enabled = !flag;
            cbo_made.Enabled = !flag;
            time_batdau.Enabled =spin_tongthoigian.Enabled= !flag;
            date_ngaythi.Enabled = !flag;
            base.Click_Perform(flag);
        }
        /// <summary>
        /// Hành động thêm
        /// </summary>
        public override void Add()
        {
            state = "add";
            ClearDataBind();
            base.Add();
        }
        /// <summary>
        /// Hành động sửa
        /// </summary>
        public override void Edit()
        {
            state = "edit";
            base.Edit();
        }
        /// <summary>
        /// Xóa
        /// </summary>
        public override void Delete()
        {
            try
            {
                base.Delete();
                DialogResult Result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    string id = gridView1.GetFocusedRowCellValue("idphongthi").ToString();
                    pt.Delete(id);
                    Init();
                }
            }
            catch
            {
                XtraMessageBox.Show("Bạn không thể xóa phòng thi này !\n Vì trong phòng thi còn có danh sách thi");
            }
            base.Delete();
        }
        /// <summary>
        /// Kiểm tra điều kiện nhập
        /// </summary>
        /// <returns></returns>
        public override bool ValidInput()
        {
            if (txt_Maphong.Text.Trim() == "")
            {
                XtraMessageBox.Show("Mã phòng không được bỏ trống");
                return false;
            }
            if (txt_TenPhong.Text.Trim() == "")
            {
                XtraMessageBox.Show("Tên phòng không được bỏ trống");
                return false;
            }
            if (lk_lop.ItemIndex == -1)
            {
                XtraMessageBox.Show("Chưa chọn lớp để tạo phòng");
                return false;
            }
            if (spin_tongthoigian.Value.ToString() == "0")
            {
                XtraMessageBox.Show("Chưa thiết lập thời gian thi");
                return false;
            }
            if (lk_monthi.ItemIndex == -1)
            {
                XtraMessageBox.Show("Chưa chọn môn thi");
                return false;
            }
            if (cbo_giangvien.SelectedIndex == -1)
            {
                XtraMessageBox.Show("Chưa chọn giảng viên gác thi");
                return false;
            }
            if (cbo_made.SelectedIndex == -1)
            {
                XtraMessageBox.Show("Chưa chọn mã đề thi");
                return false;
            }
            return base.ValidInput();
        }
        /// <summary>
        /// Lưu thông tin xuống database
        /// </summary>
        public override void Save()
        {
            if (ValidInput())
            {
                string date = date_ngaythi.EditValue.ToString().Substring(0, 10); ;
                string time = time_batdau.EditValue.ToString().Substring(time_batdau.EditValue.ToString().Length - 10);
                switch (state)
                {
         
                    case "add":
                        pt.Add(txt_TenPhong.Text, txt_Maphong.Text, lk_monthi.EditValue.ToString(), cbo_made.SelectedValue.ToString(), date, time, cbo_giangvien.SelectedValue.ToString(), spin_tongthoigian.Value.ToString());
                        break;
                    case "edit":
                        //string a = date_ngaythi.
                        string id = gridView1.GetFocusedRowCellValue("idphongthi").ToString();

                        pt.Edit(id, txt_TenPhong.Text, txt_Maphong.Text, lk_monthi.EditValue.ToString(), cbo_made.SelectedValue.ToString(), date, time, cbo_giangvien.SelectedValue.ToString(), spin_tongthoigian.Value.ToString());
                        break;
                    default:
                        break;
                }
                ResetInput();
                DataBind();
                Click_Perform(true);
                Init();
            }
            else
                return;
            base.Save();
        }
        /// <summary>
        /// Hủy
        /// </summary>
        public override void Cancel()
        {
            ResetInput();
            Click_Perform(true);
            base.Cancel();
        }
        public override void ReFresh()
        {
            Init();
            base.ReFresh();
        }
        #endregion

        private void lk_lop_EditValueChanged(object sender, EventArgs e)
        {
            LoadMonHocByIdLop(lk_lop.EditValue.ToString());
        }

        private void lk_monthi_EditValueChanged(object sender, EventArgs e)
        {
            LoadDeThiByMonHoc(lk_monthi.EditValue.ToString());
        }
    }
}