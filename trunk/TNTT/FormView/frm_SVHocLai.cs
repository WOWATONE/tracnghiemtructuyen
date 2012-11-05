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
    public partial class frm_SVHocLai : frm_tool
    {
        C_SinhVienHocLai svhl = new C_SinhVienHocLai();
        C_Lop lop = new C_Lop();
        C_SinhVien sv = new C_SinhVien();
        C_MonHoc mh = new C_MonHoc();
        C_DSMH DSMH = new C_DSMH();
        int loadthe = 0;
        int loadnut = 0;
        public frm_SVHocLai()
        {
            InitializeComponent();
        }
        string _state = "";
        private void frm_SVHocLai_Load(object sender, EventArgs e)
        {
            Init();
            loadthe++;
            
        }

        public override void  Init()
        {
            grd_SinhVien.DataSource = svhl.GetList("");
 	        base.Init();
            cbo_Lop.DataSource = lop.GetList();
            cbo_Lop.DisplayMember = "malop";
            cbo_Lop.ValueMember = "idlop";
            cbo_monhoc.Enabled = false;
            cbo_sinhvien.Enabled = false;
        }

        private void cbo_Lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_Lop.SelectedIndex > -1 && loadthe != 0)
            {
                if (loadnut != 0)
                {
                    cbo_monhoc.Enabled = true;
                    cbo_sinhvien.Enabled = true;
                }
                cbo_monhoc.Text = "";
                cbo_sinhvien.Text = "";
                cbo_sinhvien.DataSource = sv.GetListbyIdLop(cbo_Lop.SelectedValue.ToString());
                cbo_sinhvien.ValueMember = "masinhvien";
                cbo_sinhvien.DisplayMember = "tensinhvien";
                cbo_monhoc.DataSource = mh.GetListByIdLop(cbo_Lop.SelectedValue.ToString());
                cbo_monhoc.ValueMember = "idmonhoc";
                cbo_monhoc.DisplayMember = "mamonhoc";
            }
        }

        #region OVERIDE
        public override bool ValidInput()
        {
            return base.ValidInput();//true
        }
        public override void Add()
        {
            base.Add();
            _state = "add";
            loadnut = 1;
        }
        public override void Edit()
        {
            base.Edit();
            _state = "edit";
            loadnut = 1;
        }
        public override void Delete()
        {
            base.Delete();
            DialogResult Result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Result == DialogResult.OK)
            {
                svhl.Delete(gridView1.GetFocusedRowCellValue("iddsmonhoclai").ToString());
                Init();
            }
        }
        public override void Save()
        {
            try
            {
                loadnut = 0;
                switch (_state)
                {
                    case "add":
                        if (ValidInput())
                        {
                            DataTable temp = DSMH.GetListbyidmonhocandidlop(cbo_monhoc.SelectedValue.ToString(), cbo_Lop.SelectedValue.ToString());
                            svhl.Add(cbo_sinhvien.SelectedValue.ToString(), temp.Rows[0]["idddsmh"].ToString());
                            Init();
                        }
                        else
                            return;
                        break;
                    case "edit":
                        if (ValidInput())
                        {
                            DataTable temp = DSMH.GetListbyidmonhocandidlop(cbo_monhoc.SelectedValue.ToString(), cbo_Lop.SelectedValue.ToString());
                            svhl.Edit(gridView1.GetFocusedRowCellValue("iddsmonhoclai").ToString(), cbo_sinhvien.SelectedValue.ToString(), temp.Rows[0]["idddsmh"].ToString());
                            Init();
                        }
                        else
                            return;
                        break;

                    default: break;
                }
                _state = "";

                base.Save();
            }
            catch
            {
                XtraMessageBox.Show("Điền đầy đủ thông tin !");
            }
        }
        public override void Cancel()
        {
            loadnut = 0;
            base.Cancel();
            _state = "";
            Init();
            DataBind();

        }
        public override void DataBind()
        {
            ClearDataBind();
            cbo_Lop.DataBindings.Add("text", grd_SinhVien.DataSource, "lop_idlop");
            base.DataBind();
        }
        public override void ClearDataBind()
        {
            cbo_Lop.DataBindings.Clear();
            base.ClearDataBind();
        }
        public override void Click_Perform(bool flag)
        {
            cbo_Lop.Enabled = !flag;
            if (loadnut != 0)
                cbo_monhoc.Enabled = cbo_sinhvien.Enabled = flag;
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