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
    public partial class frm_ChangePwd : DevExpress.XtraEditors.XtraForm
    {
        public frm_ChangePwd()
        {
            InitializeComponent();
        }

        private void frm_ChangePwd_Load(object sender, EventArgs e)
        {
            pictureBox1.Image =Com_Base.Convert_Text_to_Image("1234", "Bookman Old Style", 20); // Passing appropriate value to Convert_Text_to_Image method 
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}