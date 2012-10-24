using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using DevExpress.XtraEditors;
using TNTT.Class;
using System.IO;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace TNTT.FormView
{
    public partial class frm_SinhVien : frm_tool
    {
        byte[] avatar_sinhvien;
        Class.C_Khoa khoa = new Class.C_Khoa();
        Class.C_Lop lop = new Class.C_Lop();
        Class.C_SinhVien sinhvien = new Class.C_SinhVien();
        DataTable dt_lop = new DataTable();
        DataTable dt_khoa = new DataTable();
        DataTable dt_sinhvien = new DataTable();
        string _state = "";

        public frm_SinhVien()
        {
            InitializeComponent();
        }

        private void frm_SinhVien_Load(object sender, EventArgs e)
        {
            ResetInput();
            LoadTLDanhSachLop();
            Init();
            Click_Perform(true);
            ReloadImage();
        }

        void LoadTLDanhSachLop()
        {
            dt_khoa = khoa.GetList();
            for (int i = 0; i < dt_khoa.Rows.Count; i++)
            {
                TreeListNode code = tlDanhSachLop.AppendNode(null, null);
                code.SetValue("ten", dt_khoa.Rows[i]["tenkhoa"].ToString());

                dt_lop = lop.GetListById(dt_khoa.Rows[i]["idkhoa"].ToString());
                for (int j = 0; j < dt_lop.Rows.Count; j++)
                {
                    TreeListNode child = null;
                    child = tlDanhSachLop.AppendNode(null, code);
                    child.SetValue("ten", dt_lop.Rows[j]["tenlop"].ToString());
                    child.SetValue("id", dt_lop.Rows[j]["idlop"].ToString());
                }
            }
        }

        private void tlDanhSachLop_AfterFocusNode(object sender, NodeEventArgs e)
        {
            try
            {
                Loadtutreelist();
                //MessageBox.Show("a");
               // ReloadImage();
            }
            catch
            {
            }
        }

        void Loadtutreelist()
        {
            string str = tlDanhSachLop.FocusedNode.GetValue("id").ToString();
            dt_sinhvien = sinhvien.GetListbyIdLop(str);
            grd_DanhSach.DataSource = dt_sinhvien;
            LoadImage();
            //ClearDataBind();
            DataBind();
            lk_lop.EditValue = str;
        }

        #region override
        public override void Exit()
        {
            this.Close();
            base.Exit();
        }

        public override void ClearDataBind()
        {
            txtMaSinhVien.DataBindings.Clear();
            txtTenSinhVien.DataBindings.Clear();
            dateNgaySinh.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtDienThoai.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            //txtAvartar.DataBindings.Clear();
            lk_lop.DataBindings.Clear();
            base.ClearDataBind();
        }

        public override void ResetInput()
        {
            txtMaSinhVien.Text = txtTenSinhVien.Text = txtDiaChi.Text = txtDienThoai.Text = txtEmail.Text =  "";
            dateNgaySinh.DateTime = DateTime.Today;
            base.ResetInput();
        }

        public override void Click_Perform(bool flag)
        {
            
            txtMaSinhVien.Enabled = txtTenSinhVien.Enabled = txtDiaChi.Enabled = txtDienThoai.Enabled = txtEmail.Enabled = lk_lop.Enabled = dateNgaySinh.Enabled =cmd_changeAvt.Enabled= !flag;
            grd_DanhSach.Enabled = tlDanhSachLop.Enabled = flag;
            base.Click_Perform(flag);
        }

        public override void DataBind()
        {
            if (dt_sinhvien.Rows.Count > 0)
            {
                ClearDataBind();
                txtTenSinhVien.DataBindings.Add("text", dt_sinhvien, "tensinhvien");
                txtMaSinhVien.DataBindings.Add("text", dt_sinhvien, "masinhvien");
                dateNgaySinh.DataBindings.Add("text", dt_sinhvien, "ngaysinh_sinhvien");
                txtDiaChi.DataBindings.Add("text", dt_sinhvien, "diachi_sinhvien");
                txtDienThoai.DataBindings.Add("text", dt_sinhvien, "dienthoai_sinhvien");
                txtEmail.DataBindings.Add("text", dt_sinhvien, "email_sinhvien");
               // txtAvartar.DataBindings.Add("text", dt_sinhvien, "avartar_sinhvien");
                lk_lop.DataBindings.Add("editvalue", dt_sinhvien, "lop_idlop");
                ReloadImage();
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
        public void Init()
        {
            BestFit();
            dt_khoa = khoa.GetList();
            lk_lop.Properties.DataSource = lop.GetList() ;
            lk_lop.Properties.DisplayMember = "malop";
            lk_lop.Properties.ValueMember = "idlop";
        }

        public void BestFit()
        {

        }

        public override void Add()
        {
            base.Add();
            _state = "add";
            txtMaSinhVien.Focus();
            DefaultImage();
            ConvertImage(@"Avatar/1.jpg");
           // lk_bomon.ItemIndex = -1;
        }

        public override void Edit()
        {
            base.Edit();
            _state = "edit";
        }

        public override void Delete()
        {
            try
            {
                base.Delete();
                DialogResult Result = XtraMessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    string id = gv_DanhSach.GetFocusedRowCellValue("masinhvien").ToString();
                    sinhvien.Delete(id);
                    Loadtutreelist();
                }
            }
            catch
            {
                XtraMessageBox.Show("Không thể xóa !");
            }
        }
        public override bool ValidInput()
        {
            if (txtMaSinhVien.Text.Trim() == null)
            {
                XtraMessageBox.Show("Bạn chưa nhập mã sinh viên");
                txtMaSinhVien.Focus();
                return false;
            }
            if (dateNgaySinh.DateTime.ToString() == null)
            {
                XtraMessageBox.Show("Bạn chưa chọn ngày sinh");
                dateNgaySinh.Focus();
                return false;
            }
            if (txtDienThoai.Text.Trim() == null)
            {
                XtraMessageBox.Show("Số điện thoại không hợp lệ");
                txtDienThoai.Focus();
                return false;
            }
            if (txtTenSinhVien.Text.Trim() == null)
            {
                XtraMessageBox.Show("Bạn chưa nhập tên sinh viên");
                txtTenSinhVien.Focus();
                return false;
            }
            if (lk_lop.ItemIndex == -1)
            {
                XtraMessageBox.Show("Bạn chưa chọn lớp");
                txtTenSinhVien.Focus();
                return false;
            }
           

            return base.ValidInput();
        }
        public override void Save()
        {
            switch (_state)
            {
                case "add":
                    if (ValidInput())
                    {
                        string ngaysinh = dateNgaySinh.DateTime.Month + "-" + dateNgaySinh.DateTime.Day + "-" + dateNgaySinh.DateTime.Year;
                        sinhvien.Add(txtMaSinhVien.Text, txtTenSinhVien.Text, ngaysinh, txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text, lk_lop.EditValue.ToString());
                        SaveImage(txtMaSinhVien.Text);
                        Loadtutreelist();
                    }
                    else
                        return;
                    break;

                case "edit":
                    if (ValidInput())
                    {
                        string ngaysinh = dateNgaySinh.DateTime.Month + "-" + dateNgaySinh.DateTime.Day + "-" + dateNgaySinh.DateTime.Year;
                        sinhvien.Edit(txtMaSinhVien.Text, txtTenSinhVien.Text, ngaysinh, txtDiaChi.Text, txtDienThoai.Text, txtEmail.Text, lk_lop.EditValue.ToString());
                        SaveImage(txtMaSinhVien.Text);
                        Loadtutreelist();
                    }
                    else
                        return;
                    break;

                default: break;
            }
            _state = "";
            base.Save();
        }
        #endregion

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        void ConvertImage(string path)
        {
            FileInfo finfo = new FileInfo(path);

            byte[] btImage = new byte[finfo.Length];
            FileStream fStream = finfo.OpenRead();

            fStream.Read(btImage, 0, btImage.Length);
            fStream.Close();
            avatar_sinhvien = btImage;
            //pic_avt.Image = new Bitmap(open.FileName);
        }
        private void cmd_changeAvt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                ConvertImage(open.FileName);
                pic_avt.Image = new Bitmap(open.FileName);
            }  
        }
        void LoadImage()
        {
            try
            {
                MemoryStream ms = new MemoryStream((byte[])avatar_sinhvien);
                pic_avt.Image = Image.FromStream(ms);
                pic_avt.SizeMode = PictureBoxSizeMode.StretchImage;
                pic_avt.Refresh();
            }
            catch
            {
                pic_avt.Image = Image.FromFile(@"Avatar/1.jpg");
                pic_avt.SizeMode = PictureBoxSizeMode.StretchImage;
                pic_avt.Refresh();
            }
        }
        void SaveImage(string idsinhvien)
        {

            Database.Database db = new Database.Database();
            using (SqlConnection sqlConnection = new SqlConnection(db.connstr))
            {
                using (SqlCommand sqlCommand = new SqlCommand("UPDATE sinhvien set avartar_sinhvien=@emp_image where masinhvien='"+ idsinhvien+"'", sqlConnection))
                {
                    SqlParameter imageParameter = new SqlParameter("@emp_image", SqlDbType.Image);
                    imageParameter.Value = avatar_sinhvien;
                    sqlCommand.Parameters.Add(imageParameter);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();

                }
            }
        }
        void DefaultImage()
        {
            pic_avt.Image = Image.FromFile(@"Avatar/1.jpg");
            pic_avt.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_avt.Refresh();
        }
        void ReloadImage()
        {
            try
            {
                if (gv_DanhSach.GetFocusedRowCellValue("avatar_giangvien") != null)
                    avatar_sinhvien = (byte[])gv_DanhSach.GetFocusedRowCellValue("avatar_giangvien");
                LoadImage();
            }
            catch { LoadImage(); }
        }
        private void gv_DanhSach_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (gv_DanhSach.GetFocusedRowCellValue("avartar_sinhvien") != null)
                    avatar_sinhvien = (byte[])gv_DanhSach.GetFocusedRowCellValue("avartar_sinhvien");
                LoadImage();
            }
            catch
            {
                //click vô ô nếu không load đc image thì cho nó mặc định
                pic_avt.Image = Image.FromFile(@"Avatar/1.jpg");
                pic_avt.SizeMode = PictureBoxSizeMode.StretchImage;
                pic_avt.Refresh();
            }
        }

        private void tlDanhSachLop_SelectionChanged(object sender, EventArgs e)
        {
            MessageBox.Show("a");
            try { ReloadImage(); }
            catch { LoadImage(); }
        }

        private void tlDanhSachLop_NodeChanged(object sender, NodeChangedEventArgs e)
        {
            LoadImage();
        }

        private void tlDanhSachLop_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            pic_avt.Image = Image.FromFile(@"Avatar/1.jpg");
            pic_avt.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_avt.Refresh();
            //ClearDataBind();
        }
    }
}