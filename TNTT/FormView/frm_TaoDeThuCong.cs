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
    public partial class frm_TaoDeThuCong : DevExpress.XtraEditors.XtraForm
    {
        C_BoMon bm = new C_BoMon();
        C_CauHoi ch = new C_CauHoi();
        DataTable dt_ch = new DataTable();
        C_TaoDe td = new C_TaoDe();
        C_Time time = new C_Time();
        bool truockhichon = false, saukhichon = false;
        public frm_TaoDeThuCong()
        {
            InitializeComponent();
        }

        private void frm_TaoDeThuCong_Load(object sender, EventArgs e)
        {
            LoadBoMon();
            LoadCauHoi();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        void LoadBoMon()
        {
            try
            {
                cboBoMon.DataSource = bm.GetList();
                cboBoMon.ValueMember = "idbomon";
                cboBoMon.DisplayMember = "mabomon";
                cboBoMon.SelectedValue = PreBase.obj_user.Bomon_idbomon;
            }
            catch
            {
                XtraMessageBox.Show("Lỗi load bộ môn");
            }
        }

        void LoadCauHoi()
        {
            try
            {
                dt_ch = ch.GetListByIDMonHoc(cboBoMon.SelectedValue.ToString());
                dt_ch.Columns.Add("check",typeof(bool));
                grd_CauHoi.DataSource = dt_ch;
            }
            catch
            {
                XtraMessageBox.Show("Lỗi load câu hỏi");
            }
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
                if (gridView1.GetFocusedRowCellValue("check").ToString().ToLower() == "true")
                    saukhichon = true;
                else if (gridView1.GetFocusedRowCellValue("check").ToString().ToLower() == "false")
                    saukhichon = false;
                if (truockhichon != saukhichon)
                {
                    if (truockhichon == false)
                        txtSoCauDaChon.Text = (int.Parse(txtSoCauDaChon.Text) + 1).ToString();
                    else if (truockhichon == true)
                        txtSoCauDaChon.Text = (int.Parse(txtSoCauDaChon.Text) - 1).ToString();
                }
            }
            catch
            { }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (gridView1.GetFocusedRowCellValue("check").ToString().ToLower() == "true")
                    truockhichon = true;
                else if (gridView1.GetFocusedRowCellValue("check").ToString().ToLower() == "false")
                    truockhichon = false;
            }
            catch
            { }
        }

        private void cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtSoCau.Text) > int.Parse(txtSoCauDaChon.Text))
                {
                    XtraMessageBox.Show("Lỗi chưa chọn đủ số câu !");
                    return;
                }
                if (int.Parse(txtSoCau.Text) < int.Parse(txtSoCauDaChon.Text))
                {
                    XtraMessageBox.Show("lỗi chọn số câu vượt quy định");
                    return;
                }
                if (txtMaDe.Text == "" || txtSoCau.Text == "")
                {
                    XtraMessageBox.Show("Vui lòng điền đầy đủ thông tin !");
                    return;
                }
                string chuoiidde = "";
                int dem = 0;
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (gridView1.GetRowCellDisplayText(i,"check").ToString().ToLower() == "checked")
                    {
                        chuoiidde += gridView1.GetRowCellValue(i, "idnganhangcauhoi").ToString() + "|||";
                        dem++;
                    }
                }
                if (chuoiidde != "")
                    chuoiidde = chuoiidde.Substring(0, chuoiidde.Length - 3);
                td.Add(txtMaDe.Text, chuoiidde, cboBoMon.SelectedValue.ToString(), time.GetNowTime(), cboBoMon.SelectedValue.ToString());
                XtraMessageBox.Show(string.Format("Thêm thành công ! với số câu hỏi là : {0} .",dem));

            }
            catch
            {
                XtraMessageBox.Show("Tạo đề thi không thành công !");
            }
        }

        private void txtSoCau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

    }
}