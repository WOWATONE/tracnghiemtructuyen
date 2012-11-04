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
    public partial class frm_TaoDeTC : Form
    {
        C_MonHoc mh = new C_MonHoc();
        C_CauHoi ch = new C_CauHoi();
        DataTable dt_ch = new DataTable();
        C_DeThi td = new C_DeThi();
        C_Time time = new C_Time();
        C_DeThi c_det = new C_DeThi();
        DataTable dt = new DataTable();
        DataTable dt_taode = new DataTable();
        DataTable loaddulieu = new DataTable();
        string made = "";
        int loadlendautien = 0;
        public frm_TaoDeTC()
        {
            InitializeComponent();
        }

        public frm_TaoDeTC(string madea)
        {
            InitializeComponent();
            this.made = madea;
        }

        private void frm_TaoDeTC_Load(object sender, EventArgs e)
        {
            lb_SoCauDaChon.DataBindings.Add("text", trb_Socau, "value");
            Init();
            if (made.Trim() != "")
            {
                txtMaDe.Text = made;
                loaddulieu = td.GetListiddethi(made);
                cbo_monhoc.SelectedValue = loaddulieu.Rows[0]["monhoc_idmonhoc"].ToString();
                LoadCauhoidaco();
            }
            LoadMonHoc();
            loadlendautien++;
        }

        void LoadMonHoc()
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

        void Init()
        {
            dt_taode.Clear();
            dt_taode.Columns.Clear();
            dt_taode.Columns.Add("idnganhangcauhoi");
            dt_taode.Columns.Add("tieude");
            dt_taode.Columns.Add("chuong");
            dt_taode.Columns.Add("phan");
            dt_taode.Columns.Add("capdo");
            dt_taode.Columns.Add("troncau", typeof(bool));
            dt_taode.Columns.Add("monhoc_idmonhoc");
            dt_taode.Columns.Add("tinhtrang");
            dt_taode.Columns.Add("giangvien_idgiangvien");
            dt_taode.Columns.Add("ngaytao");
            dt_taode.Columns.Add("magiangvien");            
        }

        private void cbo_monhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_monhoc.SelectedIndex > -1 && int.Parse(cbo_monhoc.SelectedValue.ToString()) > -1)
                {
                    dt = ch.GetListByIDMonHoc(cbo_monhoc.SelectedValue.ToString());
                    Loaibonhungcaudatontai();
                    grd_NHCH.DataSource = dt;
                    txtSoCauDaChon.Text = dt_taode.Rows.Count.ToString();
                    trb_Socau.Value = dt_taode.Rows.Count;
                }
                if (loadlendautien != 0)
                {
                    Init();
                }
            }
            catch
            { }
        }

        /// <summary>
        /// Loai bo nhung cau da ton tai ben cau hoi trong de so vs cau hoi trong ngan hang cau hoi
        /// </summary>
        void Loaibonhungcaudatontai()
        {
            for (int i = 0; i < dt_taode.Rows.Count; i++)
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (dt_taode.Rows[i]["idnganhangcauhoi"].ToString() == dt.Rows[j]["idnganhangcauhoi"].ToString())
                    {
                        dt.Rows.RemoveAt(j);
                    }
                }
        }

        void LoadCauhoidaco()
        {
            string[] listmade = loaddulieu.Rows[0]["listidcauhoi"].ToString().Split(new string[] { "|||" }, StringSplitOptions.None);
            for (int i = 0; i < listmade.Length ; i++)
            {
                DataTable dttemp = ch.GetListByidnganhangcauhoi(listmade[i].ToString());
                dt_taode.Rows.Add(
                                    dttemp.Rows[0]["idnganhangcauhoi"].ToString(),
                                    dttemp.Rows[0]["tieude"].ToString(),
                                    dttemp.Rows[0]["chuong"].ToString(),
                                    dttemp.Rows[0]["phan"].ToString(),
                                    dttemp.Rows[0]["capdo"].ToString(),
                                    dttemp.Rows[0]["troncau"].ToString(),
                                    dttemp.Rows[0]["monhoc_idmonhoc"].ToString(),
                                    dttemp.Rows[0]["tinhtrang"].ToString(),
                                    dttemp.Rows[0]["giangvien_idgiangvien"].ToString(),
                                    dttemp.Rows[0]["ngaytao"].ToString(),
                                    dttemp.Rows[0]["magiangvien"].ToString()
                                 );
            }
            grd_dethi.DataSource = dt_taode;
        }

        void Viewer(DevExpress.XtraGrid.Views.Grid.GridView gvtemp)
        {
            string id = gvtemp.GetFocusedRowCellValue("idnganhangcauhoi").ToString();
            Component.frm_ViewerCauHoi frm = new Component.frm_ViewerCauHoi(id);
            frm.ShowDialog();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (gridView1.FocusedColumn.FieldName == "view")
                {
                    Viewer(gridView1);
                    return;
                }
                if (gridView1.FocusedColumn.FieldName == "select")
                {
                    select();
                    return;
                }
            }
            catch { }
        }

        void select()
        {
            string id = gridView1.GetFocusedRowCellValue("idnganhangcauhoi").ToString();
            for (int i = 0; i < dt.Rows.Count; i++)
                if (dt.Rows[i]["idnganhangcauhoi"].ToString() == id)
                {
                    dt_taode.Rows.Add(dt.Rows[i]["idnganhangcauhoi"].ToString(),
                                        dt.Rows[i]["tieude"].ToString(),
                                        dt.Rows[i]["chuong"].ToString(),
                                        dt.Rows[i]["phan"].ToString(),
                                        dt.Rows[i]["capdo"].ToString(),
                                        dt.Rows[i]["troncau"].ToString(),
                                        dt.Rows[i]["monhoc_idmonhoc"].ToString(),
                                        dt.Rows[i]["tinhtrang"].ToString(),
                                        dt.Rows[i]["giangvien_idgiangvien"].ToString(),
                                        dt.Rows[i]["ngaytao"].ToString(),
                                        dt.Rows[i]["magiangvien"].ToString()
                        );
                    dt.Rows.RemoveAt(i);
                    break;
                }
            txtSoCauDaChon.Text = (int.Parse(txtSoCauDaChon.Text) + 1).ToString();
            grd_dethi.DataSource = dt_taode;
            grd_NHCH.DataSource = dt;
        }

        private void grd_NHCH_Click(object sender, EventArgs e)
        {

        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (gridView2.FocusedColumn.FieldName == "view")
                {
                    Viewer(gridView2);
                    return;
                }
                if (gridView2.FocusedColumn.FieldName == "xoadong")
                {
                    deletecot();
                    return;
                }
            }
            catch { }
        }

        void deletecot()
        {
            string id = gridView2.GetFocusedRowCellValue("idnganhangcauhoi").ToString();
            for (int i = 0; i < dt_taode.Rows.Count; i++)
                if (dt_taode.Rows[i]["idnganhangcauhoi"].ToString() == id)
                {
                    dt.Rows.Add(dt_taode.Rows[i]["idnganhangcauhoi"].ToString(),
                                    dt_taode.Rows[i]["monhoc_idmonhoc"].ToString(),
                                    dt_taode.Rows[i]["tieude"].ToString(),
                                    dt_taode.Rows[i]["chuong"].ToString(),
                                    dt_taode.Rows[i]["phan"].ToString(),
                                    dt_taode.Rows[i]["capdo"].ToString(),
                                    dt_taode.Rows[i]["tinhtrang"].ToString(),
                                    dt_taode.Rows[i]["troncau"].ToString(),
                                    dt_taode.Rows[i]["giangvien_idgiangvien"].ToString(),
                                    dt_taode.Rows[i]["ngaytao"].ToString(),
                                    dt_taode.Rows[i]["magiangvien"].ToString()
                        );
                    dt_taode.Rows.RemoveAt(i);
                    break;
                }
            txtSoCauDaChon.Text = (int.Parse(txtSoCauDaChon.Text) - 1).ToString();
            grd_dethi.DataSource = dt_taode;
            grd_NHCH.DataSource = dt;
        }

        private void cmd_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmd_luu_Click(object sender, EventArgs e)
        {
            if (int.Parse(lb_SoCauDaChon.Text) > int.Parse(txtSoCauDaChon.Text))
            {
                XtraMessageBox.Show("Lỗi chưa chọn đủ số câu !");
                return;
            }
            if (int.Parse(lb_SoCauDaChon.Text) < int.Parse(txtSoCauDaChon.Text))
            {
                XtraMessageBox.Show("lỗi chọn số câu vượt quy định");
                return;
            }
            if (txtMaDe.Text == "")
            {
                XtraMessageBox.Show("Vui lòng điền đầy đủ thông tin !");
                return;
            }

            TaoDe();
        }

        void TaoDe()
        {
            try
            {
                DataTable kt = new DataTable();
                kt = td.GetListmadethi(txtMaDe.Text);
                if (kt.Rows.Count < 1)
                {
                    string chuoiidde = "";
                    int dem = 0;
                    for (int i = 0; i < gridView2.RowCount; i++)
                    {
                        chuoiidde += gridView2.GetRowCellValue(i, "idnganhangcauhoi").ToString() + "|||";
                        dem++;
                    }
                    if (chuoiidde != "")
                        chuoiidde = chuoiidde.Substring(0, chuoiidde.Length - 3);
                    td.Add(txtMaDe.Text, chuoiidde, cbo_monhoc.SelectedValue.ToString(), time.GetNowTime(), PreBase.obj_user.Idgiangvien);
                    XtraMessageBox.Show(string.Format("Thêm thành công ! với số câu hỏi là : {0} .", dem));
                }
                else
                    XtraMessageBox.Show(string.Format("Mã đề này đã tồn tại !"));
            }
            catch
            {
                XtraMessageBox.Show("Tạo đề thi không thành công !");
            }
        }
    }

}
