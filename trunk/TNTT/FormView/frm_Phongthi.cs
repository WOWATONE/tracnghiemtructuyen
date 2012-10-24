using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TNTT.Class;

namespace TNTT.FormView
{
    public partial class frm_Phongthi : frm_tool
    {
        public frm_Phongthi()
        {
            InitializeComponent();
        }

        private void frm_Phongthi_Load(object sender, EventArgs e)
        {

        }

        #region Override 
        /// <summary>
        /// Phân quyền truy cập chức năng của các user
        /// </summary>
        public override void UserAccessFunction()
        {
            if(int.Parse(PreBase.obj_user.Chucvu) <= 4)
                AllowDelete = false;
                base.UserAccessFunction();
        }
        #endregion
    }
}