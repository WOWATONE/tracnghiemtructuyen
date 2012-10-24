using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using System.Data;
using System.Data.SqlClient;
namespace TNTT.FormView
{
    using TNTT.Class;
    public partial class frm_Infomation : DevExpress.XtraEditors.XtraForm
    {
        string[] chucvu=  {"Giám thị","Giảng viên","Quản lý khoa","Trưởng khoa","Administrator"};

        public frm_Infomation()
        {
            InitializeComponent();
        }
        private void Infomation()
        {
            lb_name.Text = PreBase.obj_user.Hoten_giangvien;
            lb_address.Text = PreBase.obj_user.Diachi_giangvien;
            lb_bomon.Text = PreBase.obj_user.Bomon_idbomon;
            lb_cv.Text = PreBase.obj_user.Chucvu;
            lb_email.Text = PreBase.obj_user.Email_giangvien;
            lb_chucvu.Text = "Chức vụ:" + chucvu[Convert.ToInt32(PreBase.obj_user.Chucvu) - 1];

        }
        private void frm_Infomation_Load(object sender, EventArgs e)
        {
         
                Infomation();
                timer1.Start();
                LoadImage();
          

        }
        private void cmd_changeavt_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Database.Database db = new Database.Database();
                using (SqlConnection sqlConnection = new SqlConnection(db.connstr))
                {

                 FileInfo finfo = new FileInfo(open.FileName);
     
                byte[] btImage = new byte[finfo.Length];
                FileStream fStream = finfo.OpenRead();
    
               fStream.Read(btImage, 0, btImage.Length);
               fStream.Close();
    
    
                     using (SqlCommand sqlCommand = new SqlCommand("UPDATE Giangvien set avatar_giangvien=@emp_image where idgiangvien="+PreBase.obj_user.Idgiangvien,sqlConnection))
                     {
                       SqlParameter imageParameter =  new SqlParameter("@emp_image", SqlDbType.Image);
                       imageParameter.Value = btImage;
                       sqlCommand.Parameters.Add(imageParameter);
                       sqlConnection.Open();
                       sqlCommand.ExecuteNonQuery();
                       sqlConnection.Close();
                       pictureBox1.Image =new Bitmap(open.FileName);
                    }
  
              }
                
            }  
        }
        public void LoadImage()
        {
            try
            {
                MemoryStream ms = new MemoryStream((byte[])PreBase.obj_user.Avatar_giangvien);
                pictureBox1.Image = Image.FromStream(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Refresh();
            }
            catch
            {
                pictureBox1.Image = Image.FromFile(@"Avatar/1.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Refresh();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_time.Text = "Bây giờ là: "+DateTime.Now.ToString("hh:mm:ss");
        }
    }   
}











//try
//{
//    OpenFileDialog open = new OpenFileDialog();
//    open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
//    if (open.ShowDialog() == DialogResult.OK)
//    {

//        string name = open.FileName;
//        name = name.Substring(name.LastIndexOf("\\") + 1);

//        File.Copy(open.FileName, @"Avatar/" + name);
//        pic_avt.Image = new Bitmap(open.FileName);
//    }
//}
//catch (Exception ex)
//{
//    MessageBox.Show(ex.Message);
//   // throw new ApplicationException("Failed loading image");
//}