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
            rtb_Cauhoi.Text = thamso;
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
                if (state == "add")
                {
                    ch.Add(cbb_monhoc.SelectedValue.ToString(), rtb_Cauhoi.Text, spin_chuong.Value.ToString(), spin_phan.Value.ToString(), cbo_capdo.SelectedValue.ToString(), chk_tinhtrang.Checked == true ? "1" : "0",chk_tron.Checked==true?"1":"0", PreBase.obj_user.Idgiangvien);
                    DataTable max_id = new DataTable();
                    max_id = ch.GetMaxId();
                    thamso = max_id.Rows[0][0].ToString();
                
                }
                else
                {
                    ch.update(thamso, cbb_monhoc.SelectedValue.ToString(), rtb_Cauhoi.Text, spin_chuong.Text, spin_phan.Text, cbo_capdo.SelectedValue.ToString(), (chk_tinhtrang.Checked == true ? 1 : 0).ToString(), (chk_tron.Checked == true ? 1 : 0).ToString());
                    ctl.DeleteByIdnganhangcauhoi(thamso);
                }
                if (chk_da1.Checked == true)
                    ctl.Add(thamso, rtb_da1.Text, (chk_true1.Checked == true ? 1 : 0).ToString());
                if (chk_da2.Checked == true)
                    ctl.Add(thamso, rtb_da2.Text, (chk_true2.Checked == true ? 1 : 0).ToString());
                if (chk_da3.Checked == true)
                    ctl.Add(thamso, rtb_da3.Text, (chk_true3.Checked == true ? 1 : 0).ToString());
                if (chk_da4.Checked == true)
                    ctl.Add(thamso, rtb_da4.Text, (chk_true4.Checked == true ? 1 : 0).ToString());
                if (chk_da5.Checked == true)
                    ctl.Add(thamso, rtb_da5.Text, (chk_true5.Checked == true ? 1 : 0).ToString());
                if (chk_da6.Checked == true)
                    ctl.Add(thamso, rtb_da6.Text, (chk_true6.Checked == true ? 1 : 0).ToString());
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
            dtctl = ctl.GetListbyidnganhangcauhoi(thamso);
            dtch = ch.GetListbyidnganhangcauhoi("", thamso);
            rtb_Cauhoi.Text = dtch.Rows[0]["tieude"].ToString();
            cbo_capdo.SelectedValue = dtch.Rows[0]["capdo"].ToString();
            cbb_monhoc.SelectedValue = dtch.Rows[0]["monhoc_idmonhoc"].ToString();
            spin_chuong.Text = dtch.Rows[0]["chuong"].ToString();
            spin_phan.Text = dtch.Rows[0]["phan"].ToString();
            chk_tron.Checked = true;
            chk_tinhtrang.Checked = true;
            chk_da1.Checked = false;
            chk_da2.Checked = false;
            chk_da3.Checked = false;
            chk_da4.Checked = false;
            chk_da5.Checked = false;
            chk_da6.Checked = false;
            if (dtch.Rows[0]["troncau"].ToString().ToLower() == "false")
                chk_tron.Checked = false;
            if (dtch.Rows[0]["tinhtrang"].ToString().ToLower() == "false")
                chk_tinhtrang.Checked = false;
            ShowCauTraLoi(0, chk_da1, rtb_da1, chk_true1);
            ShowCauTraLoi(1, chk_da2, rtb_da2, chk_true2);
            ShowCauTraLoi(2, chk_da3, rtb_da3, chk_true3);
            ShowCauTraLoi(3, chk_da4, rtb_da4, chk_true4);
            ShowCauTraLoi(4, chk_da5, rtb_da5, chk_true5);
            ShowCauTraLoi(5, chk_da6, rtb_da6, chk_true6);
        }

        bool ValidInput()
        {
            int d = 0;
            if (chk_da1.Checked) d++;
            if (chk_da2.Checked) d++;
            if (chk_da3.Checked) d++;
            if (chk_da4.Checked) d++;
            if (chk_da5.Checked) d++;
            if (chk_da6.Checked) d++;
            if (d <= 1)
            { XtraMessageBox.Show("Vui lòng chọn nhiều hơn 1 đáp án"); return false; }
            if (rtb_Cauhoi.Text.Trim() == "")
            { XtraMessageBox.Show("Bạn chưa nhập câu hỏi"); return false; }
            if (chk_da1.Enabled && chk_da1.Checked && rtb_da1.Text.Trim() == "")
            {
                XtraMessageBox.Show("Đáp án 1 trống, vui lòng nhập lại"); return false;
            }
            if (chk_da2.Enabled && chk_da2.Checked && rtb_da2.Text.Trim() == "")
            {
                XtraMessageBox.Show("Đáp án 2 trống, vui lòng nhập lại"); return false;
            }
            if (chk_da3.Enabled && chk_da3.Checked && rtb_da3.Text.Trim() == "")
            {
                XtraMessageBox.Show("Đáp án 3 trống, vui lòng nhập lại"); return false;
            }
            if (chk_da4.Enabled && chk_da4.Checked && rtb_da4.Text.Trim() == "")
            {
                XtraMessageBox.Show("Đáp án 4 trống, vui lòng nhập lại"); return false;
            }
            if (chk_da5.Enabled && chk_da5.Checked && rtb_da5.Text.Trim() == "")
            {
                XtraMessageBox.Show("Đáp án 5 trống, vui lòng nhập lại"); return false;
            }
            if (chk_da6.Enabled && chk_da6.Checked && rtb_da6.Text.Trim() == "")
            {
                XtraMessageBox.Show("Đáp án 6 trống, vui lòng nhập lại"); return false;
            }
            d = 0;
            if (chk_da1.Checked && chk_true1.Checked) d++;
            if (chk_da2.Checked && chk_true2.Checked) d++;
            if (chk_da3.Checked && chk_true3.Checked) d++;
            if (chk_da4.Checked && chk_true4.Checked) d++;
            if (chk_da5.Checked && chk_true5.Checked) d++;
            if (chk_da6.Checked && chk_true6.Checked) d++;
            if (d == 0)
            { XtraMessageBox.Show("Bạn chưa chọn đáp án nào cả"); return false; }

            return true;
        }

        #region kiem tra check edit

        private void chk_da1_CheckedChanged(object sender, EventArgs e)
        {
            chk_true1.Enabled = rtb_da1.Enabled = chk_da1.Checked == true;
        }

        private void chk_da2_CheckedChanged(object sender, EventArgs e)
        {
            chk_true2.Enabled = rtb_da2.Enabled = chk_da2.Checked == true;
        }

        private void chk_da3_CheckedChanged(object sender, EventArgs e)
        {
            chk_true3.Enabled = rtb_da3.Enabled = chk_da3.Checked == true;
        }

        private void chk_da4_CheckedChanged(object sender, EventArgs e)
        {
            chk_true4.Enabled = rtb_da4.Enabled = chk_da4.Checked == true;
        }

        private void chk_da5_CheckedChanged(object sender, EventArgs e)
        {
            chk_true5.Enabled = rtb_da5.Enabled = chk_da5.Checked == true;
        }

        private void chk_da6_CheckedChanged(object sender, EventArgs e)
        {
            chk_true6.Enabled = rtb_da6.Enabled = chk_da6.Checked == true;
        }

        #endregion

    }
}