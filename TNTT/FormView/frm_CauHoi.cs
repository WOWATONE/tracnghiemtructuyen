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
    public partial class frm_CauHoi : DevExpress.XtraEditors.XtraForm
    {

        public delegate void AddHandler();

        public event AddHandler Init;
        C_MonHoc mh = new C_MonHoc();
        C_CauHoi ch = new C_CauHoi();
        C_CauTraLoi ctl = new C_CauTraLoi();
        C_GiangVien gv = new C_GiangVien();
        DataTable dtch = new DataTable();
        DataTable dtctl = new DataTable();

        string thamso = "";
        /// <summary>
        /// Có 2 trạng thái là sửa và thêm
        /// </summary>
        string state="add";
        DataTable dt = new DataTable();


        public frm_CauHoi()
        {
            InitializeComponent();
            this.Text = "Thêm mới câu hỏi";
        }

        public frm_CauHoi(string str)
        {
            InitializeComponent();
            state = "edit";
            thamso = str;
            this.Text = "Sửa câu hỏi";
        }

        public frm_CauHoi(string str,string xem)
        {
            InitializeComponent();
            Enableall(false);
            state = "edit";
            thamso = str;
            this.Text = "Sửa câu hỏi";
        }

        void Enableall(bool ena = true)
        {
            groupControl4.Enabled = ena;
            groupControl2.Enabled = ena;
            cbo_capdo.Enabled = ena;
            cbb_monhoc.Enabled = ena;
            spin_chuong.Enabled = ena;
            spin_phan.Enabled = ena;
            cmd_luu.Enabled = ena;
            chk_tron.Enabled = ena;
            chk_tinhtrang.Enabled = ena;
        }
        /// <summary>
        /// Khởi tạo form
        /// </summary>
        void Initthis()
        {
            dt = mh.GetList();
            //load lên môn học
            cbb_monhoc.DataSource = dt;
            cbb_monhoc.DisplayMember = "tenmonhoc";
            cbb_monhoc.ValueMember = "idmonhoc";
            //Load lên cấp độ
            DataTable dt_capdo = new DataTable();
            if (dt_capdo.Columns.Count <= 0)
            {
                dt_capdo.Columns.Add("Id");
                dt_capdo.Columns.Add("Muc do");
                dt_capdo.Rows.Add("1", "Dễ");
                dt_capdo.Rows.Add("2", "Trung Bình");
                dt_capdo.Rows.Add("3", "Khó");
            }
            cbo_capdo.DataSource = dt_capdo;
            cbo_capdo.DisplayMember = "Muc do";
            cbo_capdo.ValueMember = "Id";
        }
        
        
        private void frm_CauHoi_Load(object sender, EventArgs e)
        {
            rtb_Fck.Text = thamso;
            Initthis();
            if (state == "edit")
                LoadCauHoi();
        }

        void ShowCauTraLoi(int itemp, CheckEdit chktemp, RichTextBox rtbtemp, CheckEdit chk_tr)
        {
            if (dtctl.Rows.Count > itemp)
            {
                chktemp.Checked = true;
                rtbtemp.Text = dtctl.Rows[itemp]["cautraloi"].ToString();
                chk_tr.Checked = true;
                if (dtctl.Rows[itemp]["dapan"].ToString().ToLower() == "false")
                    chk_tr.Checked = false;
            }
        }

        private void cmd_luu_Click_1(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                
                if(Init!=null)
                Init();
                Close();
      
            }
        }

        private void cmd_Huy_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Thể hiện thôn tin controls lên
        /// </summary>
        void LoadCauHoi()
        {
           
        }

        bool ValidInput()
        {
      

            return true;
        }

        #region kiem tra check edit

        private void chk_da1_CheckedChanged(object sender, EventArgs e)
        {
           // chk_true1.Enabled = rtb_da1.Enabled = chk_da1.Checked == true;
        }

        
        #endregion

    }
}