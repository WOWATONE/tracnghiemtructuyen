using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TNTT.Component
{
    public partial class frm_Thongbao : DevExpress.XtraEditors.XtraForm
    {
        public frm_Thongbao()
        {
            InitializeComponent();
        }
        public delegate void PassControl(object sender);
 
    // Create instance (null)
        public PassControl passControl;
        private void frm_Thongbao_Load(object sender, EventArgs e)
        {

        }

        private void cmd_Gửi_Click(object sender, EventArgs e)
        {
            if (passControl != null)
            {
                passControl(rich_mess);
            }
            this.Hide();
        }
    }
}