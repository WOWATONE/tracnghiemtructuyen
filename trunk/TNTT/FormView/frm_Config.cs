using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;
namespace TNTT.FormView
{
    public partial class frm_Config : DevExpress.XtraEditors.XtraForm
    {
        string connstr = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
        string[] a;
        public frm_Config()
        {
            InitializeComponent();
        }
        void GetData()
        {
            a = connstr.Split(';');
            //a[0] la datasource //a[1] luu database
            txt_srv.Text = a[0].Substring(a[0].LastIndexOf('=') + 1);
            txt_dbname.Text = a[1].Substring(a[1].LastIndexOf('=') + 1);
        }
        void SaveData()
        {
            string strcnn = "Data source ="+txt_srv.Text+";database="+txt_dbname.Text+";Integrated Security = True";
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSectionCollection sections = config.Sections;

            foreach (ConfigurationSection section in sections)
            {
                ConnectionStringsSection connSettings = section as ConnectionStringsSection;

                if (connSettings != null)
                {
                    connSettings.ConnectionStrings[0].ConnectionString = strcnn;
                }
            }
           
            Close();
        }
        private void frm_Config_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void cmd_Hide_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmd_Save_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}