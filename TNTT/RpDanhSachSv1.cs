using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TNTT
{
    public partial class RpDanhSachSv1 : DevExpress.XtraReports.UI.XtraReport
    {
        //public RpDanhSachSv1(System>DA
       // System.Data.DataTable dt = new System.Data.DataTable();
        string[] dayofweek = {"Sun","Mon","Tue","Web","Thu","Fri","Sat"};
        string[] ngaytrongtuan = { "Chủ nhật", "Thứ 2", "Thứ 3", "Thứ 4", "Thú 5", "Thứ 6", "Thứ 7" };
        int index;
        public RpDanhSachSv1(System.Data.DataTable dt)
        {
            InitializeComponent(); 
            this.DataSource = dt;
            DataBind();
            
            lb_Name.Text = Class.PreBase.obj_user.Hoten_giangvien;
            for(int i=0;i<6;i++)
                if(DateTime.Now.DayOfWeek.ToString().IndexOf(dayofweek[i])!=-1)
                {
                    index = i;
                    break;
                }
            lb_Date.Text = "Tp Hồ Chí Minh," + ngaytrongtuan[index] + " " + DateTime.Now.Day+ "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
        }
        public void DataBind()
        {
             
            xrEmail.DataBindings.Add("Text", DataSource, "tensinhvien");
            xrMasinhvien.DataBindings.Add("Text", DataSource, "masinhvien");
            xrNgaySinh.DataBindings.Add("Text", DataSource, "ngaysinh_sinhvien");
            xrDiachi.DataBindings.Add("Text", DataSource, "diachi_sinhvien");
            xrDienthoai.DataBindings.Add("Text", DataSource, "dienthoai_sinhvien");
            xrEmail.DataBindings.Add("Text", DataSource, "email_sinhvien");
         
           
        }
      // nen them thi viet Databinding
    }
}
