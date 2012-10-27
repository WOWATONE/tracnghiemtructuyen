using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Text.RegularExpressions;
using TNTT.Class;
namespace TNTT.FormView
{
    public partial class frm_TaoDeThuCong : DevExpress.XtraEditors.XtraForm
    {
        C_MonHoc mh = new C_MonHoc();
        C_CauHoi ch = new C_CauHoi();
        DataTable dt_ch = new DataTable();
        C_DeThi td = new C_DeThi();
        C_Time time = new C_Time();
        C_DeThi c_det = new C_DeThi();
        bool truockhichon = false, saukhichon = false,blsuade = false;
        string suade = "";
        public frm_TaoDeThuCong()
        {
            InitializeComponent();
        }

        public frm_TaoDeThuCong(string iddethi)
        {
            InitializeComponent();
            suade = iddethi;
            blsuade = true;
        }

        void LoadFormThuCongTheoIdmade(string iddethi)
        {
            int dem = 0;
            DataTable dt_dethi = c_det.GetListiddethi(iddethi);
            txtMaDe.Text = dt_dethi.Rows[0]["madethi"].ToString();
            cbo_monhoc.Enabled = false;
            cbo_monhoc.SelectedValue = dt_dethi.Rows[0]["monhoc_idmonhoc"].ToString();
            string[] mangdethi = dt_dethi.Rows[0]["listidcauhoi"].ToString().Split(new string[] { "|||" }, StringSplitOptions.None);
            for (int i = 0; i < mangdethi.Length; i++)
            {
                for (int j = 0; j < gridView1.RowCount; j++)
                {
                    if (mangdethi[i] == gridView1.GetRowCellValue(j, "idnganhangcauhoi").ToString())
                    {
                        gridView1.SetRowCellValue(j, "check", "True");
                        dem++;
                        truockhichon = false;
                        saukhichon = false;
                        break;
                    }
                }
            }
            txtSoCauDaChon.Text = txtSoCau.Text = dem.ToString();
        }

        private void frm_TaoDeThuCong_Load(object sender, EventArgs e)
        {
            LoadBoMon();
            if (suade != "" && blsuade == true)
                LoadFormThuCongTheoIdmade(suade);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        void LoadBoMon()
        {
            try
            {
                cbo_monhoc.DataSource = mh.GetListByIDBoMon(PreBase.obj_user.Bomon_idbomon);
                cbo_monhoc.ValueMember = "idmonhoc";
                cbo_monhoc.DisplayMember = "mamonhoc";
            }
            catch
            {
                XtraMessageBox.Show("Lỗi load bộ môn");
            }
        }

        void LoadCauHoi(string idmonhoc)
        {
            try
            {
                dt_ch = ch.GetListByIDMonHoc(idmonhoc);
                dt_ch.Columns.Add("check", typeof(bool));
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
                int demc = 0;
                for (int j = 0; j < gridView1.RowCount; j++)
                {
                    if (gridView1.GetRowCellValue(j, "check").ToString().ToLower() == "true")
                    {
                        demc++;
                    }
                }
                txtSoCauDaChon.Text = demc.ToString();
            }
            catch
            { }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
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

            if (blsuade == false)
            {
                try
                {
                    string chuoiidde = "";
                    int dem = 0;
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        if (gridView1.GetRowCellDisplayText(i, "check").ToString().ToLower() == "checked")
                        {
                            chuoiidde += gridView1.GetRowCellValue(i, "idnganhangcauhoi").ToString() + "|||";
                            dem++;
                        }
                    }
                    if (chuoiidde != "")
                        chuoiidde = chuoiidde.Substring(0, chuoiidde.Length - 3);
                    td.Add(txtMaDe.Text, chuoiidde, cbo_monhoc.SelectedValue.ToString(), time.GetNowTime(), PreBase.obj_user.Idgiangvien);
                    XtraMessageBox.Show(string.Format("Thêm thành công ! với số câu hỏi là : {0} .", dem));
                }
                catch
                {
                    XtraMessageBox.Show("Tạo đề thi không thành công !");
                }
            }
            else if (blsuade)
            {
                string chuoiidde = "";
                int dem = 0;
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (gridView1.GetRowCellDisplayText(i, "check").ToString().ToLower() == "checked")
                    {
                        chuoiidde += gridView1.GetRowCellValue(i, "idnganhangcauhoi").ToString() + "|||";
                        dem++;
                    }
                }
                if (chuoiidde != "")
                    chuoiidde = chuoiidde.Substring(0, chuoiidde.Length - 3);
                td.edit(suade,txtMaDe.Text, chuoiidde, cbo_monhoc.SelectedValue.ToString(), time.GetNowTime(), PreBase.obj_user.Idgiangvien);
                XtraMessageBox.Show(string.Format("Sửa thành công ! với số câu hỏi là : {0} .", dem));
            }
        }

        private void txtSoCau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                frm_CauHoi frm_ch = new frm_CauHoi(gridView1.GetFocusedRowCellValue("idnganhangcauhoi").ToString(), "");
                frm_ch.ShowDialog();
            }
            catch
            { }
        }

        private void cbo_monhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_monhoc.SelectedIndex > -1 && int.Parse(cbo_monhoc.SelectedValue.ToString()) > -1)
                {
                    LoadCauHoi(cbo_monhoc.SelectedValue.ToString());
                    txtSoCauDaChon.Text = "0";
                }
            }
            catch
            { }
        }

    }
}