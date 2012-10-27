using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TNTT.Class;
namespace TNTT.FormView
{
    public partial class frm_Nganhangcauhoi : frm_tool
    {
        C_CauHoi ch = new C_CauHoi();
        DataTable dt = new DataTable();
        string _state = "";
        public frm_Nganhangcauhoi()
        {
            InitializeComponent();
        }

        private void frm_Nganhangcauhoi_Load(object sender, EventArgs e)
        {
            UserAccessFunction();
            Init();
        }
        public void BestFit()
        {
            gridColumn4.BestFit();
        }
        public override void Init()
        {
            dt = ch.GetList("");
            BestFit();
            grd_NHCauHoi.DataSource = dt;
        }
        private void frm_BoMon_Load(object sender, EventArgs e)
        {
            UserAccessFunction();
            Init();
            DataBind();
            Click_Perform(true);
        }
        #region OVERIDE
       
        public override void UserAccessFunction()
        {
            AllowSave = AllowCancel = AllowPrint = AllowSearch = AllowPrint = false;
            if (int.Parse(PreBase.obj_user.Chucvu) <= 2)
                AllowDelete = false;
            base.UserAccessFunction();
        }
        public override void Add()
        {
            //PreBase.ShowDiaLog<frm_CauHoi>(this);
            frm_CauHoi frm = new frm_CauHoi();
            frm.Init += Init;
            frm.ShowDialog();
        }

        public override void Edit()
        {
            frm_CauHoi frmch = new frm_CauHoi(gridView1.GetFocusedRowCellValue("idnganhangcauhoi").ToString());
            frmch.ShowDialog();
            Init();
        }
        public override void Delete()
        {
            base.Delete();
            DialogResult Result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Result == DialogResult.OK)
            {
                string id = gridView1.GetFocusedRowCellValue("idnganhangcauhoi").ToString();
                ch.Delete(id);
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
                       // khoa.Add(txt_tenkhoa.Text, txt_makhoa.Text, txt_ghichu.Text);
                        Init();

                    }
                    DataBind();
                    break;
                case "edit":
                    if (ValidInput())
                    {
                        string id = gridView1.GetFocusedRowCellValue("idkhoa").ToString();
                        //khoa.Edit(id, txt_tenkhoa.Text, txt_makhoa.Text, txt_ghichu.Text);
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
        public override void Refresh()
        {
            Init();
        }
      
        public override void Exit()
        {
            this.Close();
            base.Exit();
        }
        #endregion
    }
}
