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
    public partial class frm_MonHoc : frm_tool
    {
        Class.C_BoMon bm = new Class.C_BoMon();
        Class.C_MonHoc mh = new Class.C_MonHoc();
        DataTable dt_bm = new DataTable();
        DataTable dt_mh = new DataTable();
        string _state = "";
        public frm_MonHoc()
        {
            InitializeComponent();
        }
        private void frm_MonHoc_Load(object sender, EventArgs e)
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
            txt_GhiChu.DataBindings.Clear();
            txt_TenMonHoc.DataBindings.Clear();
            txt_MaMonHoc.DataBindings.Clear();
            lk_BoMon.DataBindings.Clear();
            base.ClearDataBind();
           
        }

        public override void ResetInput()
        {
            txt_GhiChu.Text = txt_MaMonHoc.Text = txt_TenMonHoc.Text = "";
            lk_BoMon.EditValue = 0;
            base.ResetInput();
        }

        public override void Click_Perform(bool flag)
        {

            txt_GhiChu.Enabled = txt_MaMonHoc.Enabled = txt_TenMonHoc.Enabled =lk_BoMon.Enabled= !flag;
            base.Click_Perform(flag);
        }

        public override void DataBind()
        {
            if (dt_mh.Rows.Count > 0)
            {
                ClearDataBind();
                txt_GhiChu.DataBindings.Add("text", dt_mh, "ghichu_monhoc");
                txt_MaMonHoc.DataBindings.Add("text", dt_mh, "mamonhoc");
                txt_TenMonHoc.DataBindings.Add("text", dt_mh, "tenmonhoc");
                lk_BoMon.DataBindings.Add("editvalue", dt_mh, "bomon_idbomon");
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
        public override  void Init()
        {
            dt_mh = mh.GetList();
            BestFit();
            grd_Monhoc.DataSource = dt_mh;
            dt_bm = bm.GetList();
            lk_BoMon.Properties.DataSource = dt_bm;
            lk_BoMon.Properties.DisplayMember = "tenbomon";
            lk_BoMon.Properties.ValueMember = "idbomon";
           
        }

        public void BestFit()
        {
            
            //gridColumn1.BestFit();
            gridColumn2.BestFit();
            gridColumn4.BestFit();
            Col_GhiChu.BestFit();
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
            base.Delete();
            DialogResult Result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Result == DialogResult.OK)
            {
                string id = gridView1.GetFocusedRowCellValue("idmonhoc").ToString();
                bm.Delete(id);
                Init();
            }
        }

        public override void Save()
        {
            switch (_state)
            {
                case "add":
                    if (ValidInput())
                    {
                        mh.Add(txt_MaMonHoc.Text, txt_TenMonHoc.Text, txt_GhiChu.Text,lk_BoMon.EditValue.ToString());
                        Init();
                        DataBind();
                    }
                    break;
                case "edit":
                    if (ValidInput())
                    {
                        string id = gridView1.GetFocusedRowCellValue("idmonhoc").ToString();
                        mh.Edit(id, txt_MaMonHoc.Text, txt_TenMonHoc.Text, txt_GhiChu.Text, lk_BoMon.EditValue.ToString());
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