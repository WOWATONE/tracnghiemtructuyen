using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TNTT.Class;
using DevExpress.XtraEditors;
namespace TNTT.FormView
{
    public partial class frm_Nganhangcauhoi : frm_tool
    {
        C_CauHoi ch = new C_CauHoi();
        DataTable dt = new DataTable();
        C_CauTraLoi tl = new C_CauTraLoi();
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
            try
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
            catch
            {
                XtraMessageBox.Show("Không thể xóa câu hỏi này !\n Vì trong nó còn có câu trả lời !");
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

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                int i = (int)gridView1.GetFocusedRowCellValue("idnganhangcauhoi");
                if (i > 0)
                {
                    DataTable dttemp = ch.GetListbyidnganhangcauhoi("", i.ToString());
                    rec_NoiDung.Text = dttemp.Rows[0]["tieude"].ToString();
                    int socau = 65;
                    string dapandung = "";
                    DataTable dttempcautraloi = tl.GetListbyidnganhangcauhoi(i.ToString());
                    for (int k = 0; k < dttempcautraloi.Rows.Count; k++)
                    {
                        rec_NoiDung.Text += "\n " + (char)socau + " :" + dttempcautraloi.Rows[k]["cautraloi"].ToString();
                        if (dttempcautraloi.Rows[k]["dapan"].ToString().ToLower() == "true")
                            dapandung += (char)socau + ",";
                        socau++;
                    }
                    dapandung = dapandung.Substring(0, dapandung.Length - 1);
                    rec_NoiDung.Text += "\n\n\n Đáp án đúng : " + dapandung;
                }
            }
            catch
            {
                XtraMessageBox.Show("Lỗi load câu hỏi !");
            }
        }
    }
}
