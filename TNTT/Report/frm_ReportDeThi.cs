using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;
namespace TNTT.Report
{
    public partial class frm_ReportDeThi : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        public frm_ReportDeThi(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void frm_ReportDeThi_Load(object sender, EventArgs e)
        {
            rpt_Dethi crp = new rpt_Dethi();
            crp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = crp;
        }
    }
}