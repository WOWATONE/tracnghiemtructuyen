using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TNTT.FormView
{
    public partial class frm_Backup : DevExpress.XtraEditors.XtraForm
    {
        public frm_Backup()
        {
            InitializeComponent();
        }
        void LoadGuide()
        { 
            string str ="Bạn đang sử dụng phần mềm quản lý thi trắc nghiệm để backup dữ liệu. Bạn có muốn phục hồi không?";
            rich.Text = str;
        }
        private void frm_Backup_Load(object sender, EventArgs e)
        {
            LoadGuide();
        }
    }
}
