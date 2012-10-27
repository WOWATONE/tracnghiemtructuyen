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
    public partial class frm_BoMon : frm_tool
    {
        Class.C_BoMon bm = new Class.C_BoMon();
        Class.C_Khoa khoa = new Class.C_Khoa();
        DataTable dt_bm = new DataTable();
        DataTable dt_khoa = new DataTable();
        string _state = "";
        public frm_BoMon()
        {
            InitializeComponent();
        }
        public void BestFit()
        {
            Col_GhiChuBm.BestFit();
        }
        public override void Init()
        {
            dt_bm = bm.GetList();
            BestFit();
            grd_bomon.DataSource = dt_bm;
            dt_khoa = khoa.GetList();
            lk_khoa.Properties.DataSource = dt_khoa;
            lk_khoa.Properties.DisplayMember = "tenkhoa";
            lk_khoa.Properties.ValueMember = "idkhoa";
           
        }
        private void frm_BoMon_Load(object sender, EventArgs e)
        {
            Init();
            DataBind();
            Click_Perform(true);
        }
        #region OVERIDE
        public override bool ValidInput()
        {

            if (txt_mabomon.Text.Trim() == "")
            {
                XtraMessageBox.Show("Mã bộ môn không được bỏ trống!");
                return false;
            }
            if (txt_tenbomon.Text.Trim() == "")
            {
                XtraMessageBox.Show("Tên bộ môn không được bỏ trống!");
                return false;
            }
            for(int i=0;i<dt_bm.Rows.Count;i++)
                if (txt_mabomon.Text.ToLower() == dt_bm.Rows[i]["mabomon"].ToString().ToLower())
                {
                    XtraMessageBox.Show("Mã bộ môn đã có sẵn, vui lòng nhập lại!");
                    return false;
                }
            return base.ValidInput();//true
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
            DialogResult Result = MessageBox.Show("Bạn có chắc muốn xóa không?","Xác nhận",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (Result == DialogResult.OK)
            {
                string id = gridView1.GetFocusedRowCellValue("idbomon").ToString();
                bm.Delete(id);
                Init();
            }
        }
        public override void Save()
        {
           switch(_state)
           {
               case "add":
                   if (ValidInput())
                   {
                       bm.Add(txt_mabomon.Text, txt_tenbomon.Text, txt_GhiChu.Text, lk_khoa.EditValue.ToString());
                       Init();
                       DataBind();
                   }
                   else
                       return;
                   break; 
               case "edit":
                   if (ValidInput())
                   {
                       string id = gridView1.GetFocusedRowCellValue("idbomon").ToString();
                       bm.Edit(id, txt_tenbomon.Text, txt_mabomon.Text, txt_GhiChu.Text, lk_khoa.EditValue.ToString());
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
        public override void Cancel()
        {
            base.Cancel();
            _state = "";
            Init();
            DataBind();
            
        }
        public override void DataBind()
        {
            if (dt_bm.Rows.Count > 0)
            {
                ClearDataBind();
                txt_mabomon.DataBindings.Add("text", dt_bm, "mabomon");
                txt_tenbomon.DataBindings.Add("text", dt_bm, "tenbomon");
                txt_GhiChu.DataBindings.Add("text", dt_bm, "ghichu_bomon");
                lk_khoa.DataBindings.Add("editvalue", dt_bm, "khoa_idkhoa");
                base.DataBind();
            }
     
        }
        public override void ClearDataBind()
        {
            txt_GhiChu.DataBindings.Clear();
            txt_mabomon.DataBindings.Clear();
            txt_tenbomon.DataBindings.Clear();
            lk_khoa.DataBindings.Clear();
            base.ClearDataBind();
        }
        public override void Click_Perform(bool flag)
        {
            txt_GhiChu.Enabled = txt_mabomon.Enabled =txt_tenbomon.Enabled=lk_khoa.Enabled = !flag;
            base.Click_Perform(flag);
        }
        public override void ResetInput()
        {
            txt_GhiChu.Text = txt_mabomon.Text = txt_tenbomon.Text = "";
         
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