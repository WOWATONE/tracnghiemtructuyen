using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TNTT.Class;
using TNTT.Component;
namespace TNTT.FormView
{
    public partial class frm_DeThi : frm_tool
    {
        public frm_DeThi()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        C_DeThi dth = new C_DeThi();
        public override void  Init()
        {
            string condition="";
            switch (int.Parse(PreBase.obj_user.Chucvu))
            {
                case 2: condition += " idgiangvien= " + PreBase.obj_user.Idgiangvien; break;
                default: break;
            }
            dt=dth.GetList(condition);
            grd_dethi.DataSource = dt;
        }

        private void frm_DeThi_Load(object sender, EventArgs e)
        {
            Init();
        }

        public override void ReFresh()
        {
            Init();
            base.ReFresh();
        }

        public override void Add()
        {
            PreBase.ShowDiaLog<frm_tuychontaocauhoi>(this);
            Init();
            //base.Add();
        }

        public override void Cancel()
        {
            base.Cancel();
        }

        public override void Edit()
        {
            if (gridView1.RowCount > 0)
            {
                frm_TaoDeThuCong tdtc = new frm_TaoDeThuCong(gridView1.GetFocusedRowCellValue("iddethi").ToString());
                tdtc.ShowDialog();
            }
            //base.Edit();
        }
    }
}