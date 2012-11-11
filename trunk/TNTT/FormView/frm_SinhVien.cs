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
using TNTT.Import_Export;
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
        string i = "";
        DataTable temp = new DataTable();
        public frm_SinhVien()
        {
            InitializeComponent();
        }

        private void frm_SinhVien_Load(object sender, EventArgs e)
        {
            UserAccessFunction();
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
            temp = sinhvien.GetListbyIdLop(str);
            i = str;
            grd_DanhSach.DataSource = dt_sinhvien;
            LoadImage();
            //ClearDataBind();
            DataBind();
            lk_lop.EditValue = str;
        }

        #region override

        public override void LayDuLieu()
        {
            base.LayDuLieu();
            frm_Import imp = new frm_Import();
            imp.ShowDialog();
        }

        public override void InDuLieu()
        {
            try
            {
                temp.Columns.Remove("avartar_sinhvien");
                temp.Columns.Remove("malop");
                Export(temp, "ThongTinSinhVien", "Thông Tin Sinh Viên");
                base.InDuLieu();
            }
            catch { }
        }

        public void Export(DataTable dt, string sheetName, string title)
        {
            int i = dt.Columns.Count;
            //Tạo các đối tượng Excel 
            Microsoft.Office.Interop.Excel.Application oExcel = new
            Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook  
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            // Tạo phần đầu 
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột  
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "masinhvien";
            cl1.ColumnWidth = 13.5;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "tensinhvien";
            cl2.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "ngaysinh_sinhvien";
            cl3.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "diachi_sinhvien";
            cl4.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "dienthoai_sinhvien";
            cl5.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "email_sinhvien";
            cl6.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("G3", "G3");
            cl8.Value2 = "lop_idlop";
            cl8.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");
            rowHead.Font.Bold = true;
            // Kẻ viền 
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền 
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            // Tạo mảng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable, 
            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng 
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                DataRow dr = dt.Rows[r];
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    arr[r, c] = dr[c];
                }
            }
            //Thiết lập vùng điền dữ liệu 
            int rowStart = 4;
            int columnStart = 1;

            int rowEnd = rowStart + dt.Rows.Count - 1;
            int columnEnd = dt.Columns.Count;
            if (rowEnd >= rowStart && columnEnd >= columnStart)
            {
                // Ô bắt đầu điền dữ liệu 
                Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];
                // Ô kết thúc điền dữ liệu 
                Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];
                // Lấy về vùng điền dữ liệu 
                Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);
                //Điền dữ liệu vào vùng đã thiết lập 
                range.Value2 = arr;
                // Kẻ viền 
                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
                // Canh giữa cột STT 
                Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];
                Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);
                oSheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            }
        }

        public override void UserAccessFunction()
        {
            Laydulieu = Indulieu = true;
            base.UserAccessFunction();
        }

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

        public override void Init()
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
                XtraMessageBox.Show("Không thể xóa sinh viên !\nvì trong sinh viên này còn danh sách thi hoặc danh sách môn học lại  !! ");
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