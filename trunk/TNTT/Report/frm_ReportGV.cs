using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports;


namespace TNTT.Report
{
    public partial class frm_ReportGV : Form
    {
        DataTable dt = new DataTable();
        public frm_ReportGV(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void frm_ReportDeThi_Load(object sender, EventArgs e)
        {
            rpt_Giangvien crp = new rpt_Giangvien();
            crp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = crp;
        }
    }
}
