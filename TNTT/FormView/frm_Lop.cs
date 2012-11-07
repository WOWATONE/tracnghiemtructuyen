using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking;
namespace TNTT.FormView
{
    public partial class frm_Lop : frm_tool
    {
        Class.C_Lop bm = new Class.C_Lop();
        Class.C_Khoa khoa = new Class.C_Khoa();
        DataTable dt_L = new DataTable();
        DataTable dt_khoa = new DataTable();
        string _state = "";

        public frm_Lop()
        {
            InitializeComponent();
        }

        private void frm_Lop_Load(object sender, EventArgs e)
        {
            Init();
            DataBind();
            Click_Perform(true);
        }

        public override void Exit()
        {
            this.Close();
            base.Exit();
        }

        public override void ClearDataBind()
        {
            txt_MaLop.DataBindings.Clear();
            txt_TenLop.DataBindings.Clear();
            LK_MaKhoa.DataBindings.Clear();
            base.ClearDataBind();
        }

        public override void ResetInput()
        {
            txt_MaLop.Text = txt_TenLop.Text = "";
            base.ResetInput();
        }

        public override void Click_Perform(bool flag)
        {
            grd_Lop.Enabled = flag;
            txt_MaLop.Enabled = txt_TenLop.Enabled = LK_MaKhoa.Enabled =! flag;
            base.Click_Perform(flag);
        }
        public override void Expand(bool flag)
        {
            dpn_containt.Visibility = flag == true ? DockVisibility.Visible : DockVisibility.Hidden;
            base.Expand(flag);
        }
        public override void DataBind()
        {
            if (dt_L.Rows.Count > 0)
            {
                ClearDataBind();
                txt_MaLop.DataBindings.Add("text", dt_L, "malop");
                txt_TenLop.DataBindings.Add("text", dt_L, "tenlop");
                LK_MaKhoa.DataBindings.Add("editvalue", dt_L, "khoa_idkhoa");
                base.DataBind();
            }
        }
        public override void Cancel()
        {
            base.Cancel();
            _state = "";
            Init();
            DataBind();         
        }
        public override void Init()
        {
            dt_L = bm.GetList();
            BestFit();
            grd_Lop.DataSource = dt_L;
            dt_khoa = khoa.GetList();
            LK_MaKhoa.Properties.DataSource = dt_khoa;
            LK_MaKhoa.Properties.DisplayMember = "tenkhoa";
            LK_MaKhoa.Properties.ValueMember = "idkhoa";
            base.Init();
        }

        public void BestFit()
        {
            
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
                DialogResult Result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    string id = gridView1.GetFocusedRowCellValue("idlop").ToString();
                    bm.Delete(id);
                    Init();
                }
            }
            catch
            {
                XtraMessageBox.Show("Không thể xóa lớp vì trong lớp này vẫn còn Sinh viên và DSMH");
            }
        }

        public override void Save()
        {
            switch (_state)
            {
                case "add":
                    if (ValidInput())
                    {
                        bm.Add(txt_TenLop.Text, txt_MaLop.Text, LK_MaKhoa.EditValue.ToString());
                        Init();
                        DataBind();
                    }
                    break;
                case "edit":
                    if (ValidInput())
                    {
                        string id = gridView1.GetFocusedRowCellValue("idlop").ToString();
                        bm.Edit(id, txt_TenLop.Text, txt_MaLop.Text, LK_MaKhoa.EditValue.ToString());
                        Init();
                    }
                    break;

                default: break;
            }
            _state = "";
            base.Save();
        }
    }
}