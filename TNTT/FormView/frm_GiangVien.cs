using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TNTT.Class;
using System.IO;
using System.Data.SqlClient;
//dành cho thanh dock
using DevExpress.XtraBars.Docking;
namespace TNTT.FormView
{
    public partial class frm_GiangVien : frm_tool
    {
        C_GiangVien gv = new C_GiangVien();
        C_BoMon bm = new C_BoMon();
        DataTable dt_bomon = new DataTable();
        DataTable dt = new DataTable();
        string[] chucvu = {"Giám thị","Giảng viên","Quản lý khoa","Trưởng khoa","Administrator"};
        DataTable dt_chucvu = new DataTable();
        string _state = "";
        byte[] avatar_giangvien;

        void LoadChucVu()
        {
            if (dt_chucvu.Columns.Count <= 0)
            {
                dt_chucvu.Columns.Add("ma chuc vu");
                dt_chucvu.Columns.Add("ten chuc vu");
                dt_chucvu.Rows.Add("1", "Giám thị");
                dt_chucvu.Rows.Add("2", "Giảng viên");
                dt_chucvu.Rows.Add("3", "Quản lý khoa");
                dt_chucvu.Rows.Add("4", "Trưởng khoa");
                dt_chucvu.Rows.Add("5", "Administrator");
                lk_chucvu.Properties.DataSource = dt_chucvu;
                lk_chucvu.Properties.DisplayMember = "ten chuc vu";
                lk_chucvu.Properties.ValueMember = "ma chuc vu";
            }
        }

        public frm_GiangVien()
        {
            InitializeComponent();
        }
      
        private void frm_GiangVien_Load(object sender, EventArgs e)
        {
            UserAccessFunction();
            Init();
            LoadChucVu();
            DataBind();
            Click_Perform(true);
            ReloadImage();
            
        }
        public void BestFit()
        {
            col_bomon.BestFit();
        }
        public override void Expand(bool flag)
        {
            dock_NhapLieu.Visibility = flag?DockVisibility.Visible:DockVisibility.Hidden;
            base.Expand(flag);
        }
        public override void Init()
        {
           // dock_NhapLieu.Visibility = DockVisibility.Hidden;
            dt = gv.GetList();
            Decode();
            grd_gv.DataSource = dt;
            dt_bomon = bm.GetList();
            lk_bomon.Properties.DataSource = dt_bomon;
            lk_bomon.Properties.ValueMember = "idbomon";
            lk_bomon.Properties.DisplayMember ="tenbomon";
            //lk_chucvu.Properties.DataSource = chucvu;
            BestFit();
            //var col = grd_Giangvien.Columns.Add();
            //col.FieldName = "STT";
            //col.Visible = true;
            //col.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            grd_Giangvien.CustomUnboundColumnData += gridView1_CustomUnboundColumnData;
            
        }
        void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
                e.Value = e.ListSourceRowIndex + 1;
        }
        void loadImage()
        {
            try
            {
                MemoryStream ms = new MemoryStream((byte[])avatar_giangvien) ;
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
        void ReloadImage()
        {
            try
            {
                if (grd_Giangvien.GetFocusedRowCellValue("avatar_giangvien") != null)
                    avatar_giangvien = (byte[])grd_Giangvien.GetFocusedRowCellValue("avatar_giangvien");
                loadImage();
            }
            catch { }
        }
        private void frm_BoMon_Load(object sender, EventArgs e)
        {
            LoadChucVu();
            Init();
            DataBind();
            Click_Perform(true);
        }
        #region OVERIDE CÁC HÀM OVERRIDE TỪ TOOL
        public override void UserAccessFunction()
        {
            switch (int.Parse(PreBase.obj_user.Chucvu))
            {
                case 3:
                case 4: AllowDelete = false;break;
                case 5: break;
                default : VisibleTool(false); break;

            }
            base.UserAccessFunction();
        }
        public override bool ValidInput()
        {
            if (txt_magiangvien.Text.Trim() == "")
            {
                txt_tengiangvien.Focus();
                XtraMessageBox.Show("Mã giảng viên không được bỏ trống!");
                return false;
            }
            if (txt_matkhau.Text.Trim() == "")
            {
                txt_matkhau.Focus();
                XtraMessageBox.Show("Mật khẩu không được bỏ trống");
                return false;
            }
            if (lk_bomon.EditValue.ToString().Trim() == "")
            {
                XtraMessageBox.Show("Bộ môn không được bỏ trống");
                return false;
            }
            if (lk_chucvu.ItemIndex == -1)
            {
                XtraMessageBox.Show("Chưa chọn chức vụ");
                return false;
            }
            if (!C_Valid.isEmail(txt_email.Text))
                return false;
            if (!Class.C_Valid.isPhone(txt_dienthoai.Text))
                return false;
            return base.ValidInput();//true
        }
        
        public override void Add()
        {
            base.Add();
            _state = "add";
            txt_magiangvien.Focus();
            //Đặt hình mặc định là no avatar
            DefaultImage();
            //chuyên tấm hình mặc định qua binary
            ConvertImage(@"Avatar/1.jpg");
            //
            lk_bomon.ItemIndex = -1;
            //dock_NhapLieu.Visibility = DockVisibility.Visible;
        }

        public override void Edit()
        {
            base.Edit();
            _state = "edit";
        }
        public override void Delete()
        {
            base.Delete();
            DialogResult Result = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Result == DialogResult.OK)
            {
                string id = grd_Giangvien.GetFocusedRowCellValue("idgiangvien").ToString();
                gv.Delete(id);
                Init();
            }
        }
        public override void Encode()
        {
            txt_tengiangvien.Text=Base.Encode(txt_tengiangvien.Text);
            txt_diachi.Text = Base.Encode(txt_diachi.Text);
            base.Encode();
        }
        public override void Decode()
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["tengiangvien"] = Base.Decode(dt.Rows[i]["tengiangvien"].ToString());
                dt.Rows[i]["diachi_giangvien"] = Base.Decode(dt.Rows[i]["diachi_giangvien"].ToString());
            }
            base.Decode();
        }
        public override void Save()
        {
            //MessageBox.Show(lk_chucvu.ItemIndex.ToString());
            switch (_state)
            {
                case "add":
                    if (ValidInput())
                    {
                        Encode();
                        gv.Add(txt_magiangvien.Text, txt_matkhau.Text, txt_tengiangvien.Text, txt_diachi.Text, txt_dienthoai.Text, txt_email.Text, lk_bomon.EditValue.ToString(), lk_chucvu.EditValue.ToString());
                        DataTable dt_idgiangvien = new DataTable();
                        //lưu xuống trước rồi mới update hình ảnh được
                        dt_idgiangvien = gv.GetIdByUid(txt_magiangvien.Text);
                        SaveImage(dt_idgiangvien.Rows[0]["idgiangvien"].ToString());
                        Init();
                        DataBind();

                        _state = "";
                    }
                    else
                        return;
                    break;
                case "edit":
                    if (ValidInput())
                    {
                        string id = grd_Giangvien.GetFocusedRowCellValue("idgiangvien").ToString();
                        Encode();
                        gv.Edit(id, txt_magiangvien.Text, txt_matkhau.Text, txt_tengiangvien.Text, txt_diachi.Text, txt_dienthoai.Text, txt_email.Text, lk_bomon.EditValue.ToString(), lk_chucvu.EditValue.ToString());
                        SaveImage(id);
                        Init();
                        DataBind();
                    }
                    else
                        return;
                    break;

                default: break;
            }
            base.Save();
           
        }
        public override void Cancel()
        {
            _state = "";
            Init();
            DataBind();
            ReloadImage();
            base.Cancel();
        }
        public override void DataBind()
        {
            if (dt.Rows.Count > 0)
            {
                ClearDataBind();
                txt_diachi.DataBindings.Add("text", dt, "diachi_giangvien");
                txt_dienthoai.DataBindings.Add("text", dt, "dienthoai_giangvien");
                txt_email.DataBindings.Add("text", dt, "email_giangvien");
                txt_magiangvien.DataBindings.Add("text", dt, "magiangvien");
                txt_matkhau.DataBindings.Add("text", dt, "matkhau");
                txt_tengiangvien.DataBindings.Add("text", dt, "tengiangvien");
                lk_bomon.DataBindings.Add("editvalue", dt, "bomon_idbomon");
                lk_chucvu.DataBindings.Add("editvalue", dt, "chucvu");
                //set focus cho no la 3
                //grd_Giangvien.FocusedRowHand;
                base.DataBind();
            }

        }
        public override void ClearDataBind()
        {
            txt_diachi.DataBindings.Clear();
            txt_dienthoai.DataBindings.Clear();
            txt_email.DataBindings.Clear();
            txt_magiangvien.DataBindings.Clear();
            txt_matkhau.DataBindings.Clear();
            txt_tengiangvien.DataBindings.Clear();
            lk_bomon.DataBindings.Clear();
            lk_chucvu.DataBindings.Clear();
            base.ClearDataBind();
        }
        public override void Click_Perform(bool flag)
        {
            txt_diachi.Enabled = txt_dienthoai.Enabled = txt_email.Enabled = txt_diachi.Enabled = txt_magiangvien.Enabled = txt_matkhau.Enabled = txt_tengiangvien.Enabled = lk_bomon.Enabled = lk_chucvu.Enabled = !flag;
            grd_gv.Enabled =flag;
            cmd_changevt.Enabled  =cmd_eyes.Enabled= !flag;
            base.Click_Perform(flag);
        }
        public override void ResetInput()
        {
            txt_diachi.Text = txt_dienthoai.Text = txt_email.Text = "";
            txt_magiangvien.Text = txt_matkhau.Text = txt_tengiangvien.Text = "";
            lk_bomon.EditValue =lk_chucvu.EditValue= "";
            base.ResetInput();
        }
        public override void Exit()
        {
            this.Close();
            base.Exit();
        }
        #endregion
        /// <summary>
        /// Xử lý sự kiện dòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grd_Giangvien_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (grd_Giangvien.GetFocusedRowCellValue("avatar_giangvien") != null)
                    avatar_giangvien = (byte[])grd_Giangvien.GetFocusedRowCellValue("avatar_giangvien");
                loadImage();
            }
            catch
            {
                //click vô ô nếu không load đc image thì cho nó mặc định
                pic_avt.Image = Image.FromFile(@"Avatar/1.jpg");
                pic_avt.SizeMode = PictureBoxSizeMode.StretchImage;
                pic_avt.Refresh();
            }
            //MessageBox.Show(id);
        }
        /// <summary>
        /// Chuyển đổi hình về dạng binary
        /// </summary>
        /// <param name="path"></param>
        void ConvertImage(string path)
        {
            FileInfo finfo = new FileInfo(path);

            byte[] btImage = new byte[finfo.Length];
            FileStream fStream = finfo.OpenRead();

            fStream.Read(btImage, 0, btImage.Length);
            fStream.Close();
            avatar_giangvien = btImage;
            //pic_avt.Image = new Bitmap(open.FileName);
        }
        private void cmd_changevt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                    ConvertImage(open.FileName);
                    pic_avt.Image = new Bitmap(open.FileName);
            }  
        }
        /// <summary>
        /// Lưu hình ảnh xuống db
        /// </summary>
        /// <param name="idgiangvien">tham số truyền vô để thay đổi cho cá nhấn đó</param>
        void SaveImage(string idgiangvien)
        { 
   
             Database.Database db = new Database.Database();
                using (SqlConnection sqlConnection = new SqlConnection(db.connstr))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("UPDATE Giangvien set avatar_giangvien=@emp_image where idgiangvien=" + idgiangvien, sqlConnection))
                     {
                                SqlParameter imageParameter = new SqlParameter("@emp_image", SqlDbType.Image);
                                imageParameter.Value = avatar_giangvien;
                                sqlCommand.Parameters.Add(imageParameter);
                                sqlConnection.Open();
                                sqlCommand.ExecuteNonQuery();
                                sqlConnection.Close();
                       
                    }
                }
        }
        /// <summary>
        /// Gán hình ảnh mặc định
        /// </summary>
        void DefaultImage()
        {
            pic_avt.Image = Image.FromFile(@"Avatar/1.jpg");
            pic_avt.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_avt.Refresh();
        }

        private void cmd_eyes_MouseDown(object sender, MouseEventArgs e)
        {
            txt_matkhau.Properties.UseSystemPasswordChar = false;
        }

        private void cmd_eyes_MouseUp(object sender, MouseEventArgs e)
        {
            txt_matkhau.Properties.UseSystemPasswordChar = true;
        }

        private void txt_matkhau_TextChanged(object sender, EventArgs e)
        {
            if (txt_matkhau.Text == "")
                cmd_eyes.Visible = false;
            else
                cmd_eyes.Visible = true;

        }

        private void txt_dienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}