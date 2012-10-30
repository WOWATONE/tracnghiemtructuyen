using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TNTT.Class;
using DevExpress.XtraEditors;
namespace TNTT.Component
{
    public partial class frm_TuyChonDeThi : XtraForm
    {
        string socau, idmonhoc;
        public delegate void EditOption();
        public delegate void PassControl(object sender,object sender2);

        public event EditOption Init;
        public PassControl passControl;

        public frm_TuyChonDeThi()
        {
            InitializeComponent();
        }

        public frm_TuyChonDeThi(string socau,string idmonhoc)
        {
            InitializeComponent();
            this.socau = socau;
            this.idmonhoc = idmonhoc;
        }

        private void frm_TuyChonDeThi_Load(object sender, EventArgs e)
        {
            DataBind();
            InitThis();
        }
        void DataBind()
        {
            lb_socau.DataBindings.Add("text", trb_Cauhoi, "value");
        }
        void InitThis()
        {
            DataTable dt_mh = new DataTable();
            C_MonHoc mh = new C_MonHoc();

            string conditon = "";

            switch (PreBase.obj_user.Chucvu)
            {
                case "2":
                    conditon = " and monhoc_idmonhoc in (select idmonhoc from monhoc where bomon_idbomon = "+PreBase.obj_user.Bomon_idbomon+")";
                    break;
                case "3":
                    conditon = " and monhoc_idmonhoc in (select idmonhoc from monhoc where bomon_idbomon = " + PreBase.obj_user.Bomon_idbomon;
                    conditon += ")";
                    break;
                default: break;
            }
            dt_mh = mh.GetList(conditon);
            cbb_monhoc.DataSource = dt_mh;
            cbb_monhoc.DisplayMember = "tenmonhoc";
            cbb_monhoc.ValueMember = "idmonhoc";

            trb_Cauhoi.Value = int.Parse(socau);
            cbb_monhoc.SelectedValue= idmonhoc;
        }
        private void cmd_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmd_OK_Click(object sender, EventArgs e)
        {
            if (cbb_monhoc.SelectedIndex == -1)
            {
                XtraMessageBox.Show("Bạn chưa chọn môn học");
                return;
            }
            this.Hide();
            if (passControl != null)
                passControl(lb_socau,cbb_monhoc);
            
            Init();
            Close();
        }
    }
}
