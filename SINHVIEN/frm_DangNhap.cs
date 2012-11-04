using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TNTT;
using TNTT.Class;
namespace SINHVIEN
{
    public partial class frm_DangNhap : DevExpress.XtraEditors.XtraForm
    {
        C_PhongThi pt = new C_PhongThi();
        DataTable dt = new DataTable();
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        void Init()
        {
            dt = pt.GetListByDate();
            cbo_Phong.DataSource = dt;
            cbo_Phong.DisplayMember = "tenphongthi";
            cbo_Phong.ValueMember = "idphongthi";
        }
        private void frm_DangNhap_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}