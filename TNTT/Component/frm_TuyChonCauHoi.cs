using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TNTT.Class;
using TNTT.FormView;
namespace TNTT.Component
{
    public partial class frm_tuychontaocauhoi : DevExpress.XtraEditors.XtraForm
    {
        public frm_tuychontaocauhoi()
        {
            InitializeComponent();
        }

        private void cmd_thucong_Click(object sender, EventArgs e)
        {
            PreBase.ShowDiaLog<frm_TaoDeThuCong>(this);
            Close();
        }

        private void cmd_ngaunhien_Click(object sender, EventArgs e)
        {
            this.Hide();
            PreBase.ShowDiaLog<frm_TaoDeNH>(this);
            this.Close();
        }

        private void cmd_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_tuychontaocauhoi_Load(object sender, EventArgs e)
        {

        }
    }
}