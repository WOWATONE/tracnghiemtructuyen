using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SINHVIEN
{
    public partial class frm_Message : Form
    {
        string mess;
        public frm_Message(string mess)
        {
            InitializeComponent();
            this.mess = mess;
        }

        private void frm_Message_Load(object sender, EventArgs e)
        {
            rich_Mess.Text = mess;
        }
    }
}
