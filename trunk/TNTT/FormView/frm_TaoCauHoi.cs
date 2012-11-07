using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TNTT.FormView
{
    public partial class frm_TaoCauHoi : DevExpress.XtraEditors.XtraForm
    {
        public frm_TaoCauHoi()
        {
            InitializeComponent();
        }

        private void frm_TaoCauHoi_Load(object sender, EventArgs e)
        {
            //axFramerControl1.Toolbars = true;
            //axFramerControl1.Menubar = false;
            //axFramerControl1.Titlebar = false;
        }

        private void cmd_Hide_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            axFramerControl1.Toolbars = !axFramerControl1.Toolbars;
        }

        private void cmd_Themmoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            axFramerControl1.CreateNew("Word.Document");
            axFramerControl1.Menubar = false;
            axFramerControl1.Titlebar = false;
            axFramerControl1.Toolbars = false;
        }
    }
}