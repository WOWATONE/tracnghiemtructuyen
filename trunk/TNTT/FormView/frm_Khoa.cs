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
    public partial class frm_Khoa : frm_tool
    {
        Class.C_Khoa khoa = new Class.C_Khoa();
        DataTable dt_khoa = new DataTable();
        string _state = "";
        public frm_Khoa()
        {
            InitializeComponent();
        }

        private void frm_Khoa_Load(object sender, EventArgs e)
        {
            Init();
            DataBind();
            Click_Perform(true);
        }
       
 
        public void BestFit()
        {
            gridColumn4.BestFit();
        }
        public void Init()
        {
            dt_khoa = khoa.GetList();
            BestFit();
            grd_khoa.DataSource = dt_khoa;
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
            if (txt_makhoa.Text.Trim() == "")
            {
                XtraMessageBox.Show("Mã khoa không hợp lệ");
                return false;
            }
            if (txt_tenkhoa.Text.Trim() == "")
                return false;
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
                string id = gridView1.GetFocusedRowCellValue("idkhoa").ToString();
                khoa.Delete(id);
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
                       khoa.Add(txt_tenkhoa.Text,txt_makhoa.Text,txt_ghichu.Text);
                       Init();
                       
                   }
                   DataBind();
                   break;
               case "edit":
                   if (ValidInput())
                   {
                       string id = gridView1.GetFocusedRowCellValue("idkhoa").ToString();
                       khoa.Edit(id,txt_tenkhoa.Text,txt_makhoa.Text,txt_ghichu.Text);
                       Init();
                   }
                   DataBind();
                   break;

               default: break;
           }
           _state = "";
            base.Save();
        }
        public override void Cancel()
        {
            _state = "";
            Init();
            DataBind();
            base.Cancel();
        }
        public override void DataBind()
        {
            if (dt_khoa.Rows.Count > 0)
            {
                ClearDataBind();
                txt_makhoa.DataBindings.Add("text", dt_khoa, "makhoa");
                txt_tenkhoa.DataBindings.Add("text", dt_khoa, "tenkhoa");
                txt_ghichu.DataBindings.Add("text", dt_khoa, "ghichu_khoa");

                base.DataBind();
            }
     
        }
        public override void ClearDataBind()
        {
            txt_makhoa.DataBindings.Clear();
            txt_tenkhoa.DataBindings.Clear();
            txt_ghichu.DataBindings.Clear();
            base.ClearDataBind();
        }
        public override void Click_Perform(bool flag)
        {
            txt_makhoa.Enabled = txt_tenkhoa.Enabled =txt_ghichu.Enabled = !flag;
            base.Click_Perform(flag);
        }
        public override void ResetInput()
        {
            txt_makhoa.Text = txt_tenkhoa.Text = txt_ghichu.Text = "";
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