using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TNTT.FormView
{
    public partial class frm_DSMH : frm_tool
    {
        Class.C_Lop lop = new Class.C_Lop();
        Class.C_DSMH DSMH = new Class.C_DSMH();
        Class.C_MonHoc monhoc = new Class.C_MonHoc();
        Class.C_GiangVien giangvien = new Class.C_GiangVien();
        DataTable dt_DSMH = new DataTable();
        string _state = "";

        public frm_DSMH()
        {
            InitializeComponent();
        }

        private void frm_DSMH_Load(object sender, EventArgs e)
        {
            dat_ngayhoc.DateTime = DateTime.Now;
            Click_Perform(true);
            loadlophoc();
            Init();
            DataBind();
        }

        void loadlophoc()
        {
            try
            {
                lk_lophoc.Properties.DataSource = lop.GetList();
                lk_lophoc.Properties.ValueMember = "idlop";
                lk_lophoc.Properties.DisplayMember = "malop";
            }
            catch
            {
                XtraMessageBox.Show("Lỗi load lớp học");
            }
        }

        void loadmonhoc(string malop)
        {
            try
            {
                lk_monhoc.Properties.DataSource = monhoc.GetListByIdLop(malop);
                lk_monhoc.Properties.ValueMember = "idmonhoc";
                lk_monhoc.Properties.DisplayMember = "mamonhoc";
            }
            catch
            {
                XtraMessageBox.Show("Lỗi load môn học");
            }
        }

        void loadgiangvien(string malop)
        {
            try
            {
                lk_giangvien.Properties.DataSource = giangvien.GetListByIdMonHoc(malop);
                lk_giangvien.Properties.ValueMember = "idgiangvien";
                lk_giangvien.Properties.DisplayMember = "tengiangvien";
            }
            catch
            {
                XtraMessageBox.Show("Lỗi load giảng viên");
            }
        }

        private void lk_lophoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtrong = new DataTable();
                lk_monhoc.Properties.DataSource = dtrong;
                lk_giangvien.Properties.DataSource = dtrong;
                loadmonhoc(lk_lophoc.EditValue.ToString());
                lk_monhoc.Enabled = true;
            }
            catch
            {
                XtraMessageBox.Show("Lỗi chọn lớp học");
            }
        }

        private void lk_monhoc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                loadgiangvien(lk_monhoc.EditValue.ToString());
                lk_giangvien.Enabled = true;
            }
            catch
            {
                XtraMessageBox.Show("Lỗi chọn môn học");
            }
        }

        #region OVERIDE
    
        public override void Init()
        {
            dt_DSMH = DSMH.GetList();
            grd_DanhSachMonHoc.DataSource = dt_DSMH;
            DataBind();
        }

        public override void Add()
        {
            base.Add();
            _state = "add";
        }

        public override void Edit()
        {
            base.Edit();
            _state = "edit";
        }
        public override void Delete()
        {
            try
            {
                base.Delete();
                DialogResult Result = XtraMessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    string dsmh = gridView1.GetFocusedRowCellValue("idddsmh").ToString();
                    DSMH.Delete(dsmh);
                    Init();
                }
            }
            catch
            {
                XtraMessageBox.Show("Lỗi xóa DSMH");
            }
        }
        public override void Save()
        {
            string ngay = dat_ngayhoc.DateTime.Day + "-" + dat_ngayhoc.DateTime.Month + "-" + dat_ngayhoc.DateTime.Year;
            switch (_state)
            {
                case "add":                        
                        DSMH.Add(lk_lophoc.EditValue.ToString(), lk_monhoc.EditValue.ToString(), lk_giangvien.EditValue.ToString(), ngay);
                        Init();
                    break;
                case "edit":
                    string dsmh = gridView1.GetFocusedRowCellValue("idddsmh").ToString();
                    DSMH.Edit(dsmh, lk_lophoc.EditValue.ToString(), lk_monhoc.EditValue.ToString(), lk_giangvien.EditValue.ToString(), ngay);
                    Init();
                    break;

                default: break;
            }
            _state = "";
            base.Save();
        }
        public override void Cancel()
        {
            base.Cancel();
            _state = "";
            Init();
            DataBind();
        }
        public override void DataBind()
        {
            if (dt_DSMH.Rows.Count > 0)
            {
                ClearDataBind();
                lk_lophoc.DataBindings.Add("editvalue", dt_DSMH, "lop_idlop");
                lk_giangvien.DataBindings.Add("editvalue", dt_DSMH, "giangvien_idgiangvien");
                lk_monhoc.DataBindings.Add("editvalue", dt_DSMH, "monhoc_idmonhoc");
                base.DataBind();
            }
        }
        
        public override void ClearDataBind()
        {
            lk_lophoc.DataBindings.Clear();
            lk_giangvien.DataBindings.Clear();
            lk_monhoc.DataBindings.Clear();
            base.ClearDataBind();
        }

        public override void Click_Perform(bool flag)
        {
            lk_lophoc.Enabled = dat_ngayhoc.Enabled = !flag;
            lk_giangvien.Enabled = lk_monhoc.Enabled = !flag;
            grd_DanhSachMonHoc.Enabled = flag;
            base.Click_Perform(flag);
        }

        public override void ResetInput()
        {
            base.ResetInput();
        }

        public override void Exit()
        {
            this.Close();
            base.Exit();
        }
        #endregion
    }
}