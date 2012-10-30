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
    public partial class frm_ViewerCauHoi : DevExpress.XtraEditors.XtraForm
    {
        string id = "";
        char[] prefix = {'A','B','C','D','E','F'};
        public frm_ViewerCauHoi()
        {
            InitializeComponent();
        }
        public frm_ViewerCauHoi(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        void Init()
        {
            Class.C_CauHoi ch = new Class.C_CauHoi();
            DataTable dt = new DataTable();
            dt = ch.GetInfoById(this.id);
            if (dt.Rows.Count > 0)
            {
                string question = dt.Rows[0][0].ToString() + "\n";
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    question += prefix[i] + ".  "+dt.Rows[i]["cautraloi"].ToString() + "\n";
                }
                redit.Text = question;
            }
            else
                redit.Text = "Câu hỏi này không có đáp án";
        }
        private void frm_ViewerCauHoi_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}