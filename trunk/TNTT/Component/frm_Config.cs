using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Runtime.InteropServices;
using System.Security;
using System.Collections;
using System.Net;
using System.Net.NetworkInformation;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace TNTT.Component
{
    public partial class frm_Config : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        public frm_Config()
        {
            InitializeComponent();
        }
        void InitData()
        {
            dt.Columns.Add("Tên máy chủ trong mạng");
            dt.Columns.Add("Địa chỉ IP");
        }
        public void GetAllIPAndHostNames()
        {
            
            string strHostName;

            // Getting Ip address of local machine...
            // First get the host name of local machine.
            strHostName = Dns.GetHostName();
            Console.WriteLine("Local Machine's Host Name: " + strHostName);

            IPHostEntry remoteIP;

            //using host name, get the IP address list..
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            int i = 0;
            while (i < addr.Length)
            {
                    remoteIP = Dns.GetHostEntry(addr[i].ToString());
                    dt.Rows.Add(remoteIP.HostName.ToString(), addr[i].ToString());
                    i++;
            }
               
            lk_svrname.Properties.DataSource = dt;
            lk_svrname.Properties.ValueMember = "Địa chỉ IP";
            lk_svrname.Properties.DisplayMember = "Tên máy chủ trong mạng";

            //return 0;
        }
       
        private void frm_Config_Load(object sender, EventArgs e)
        {

            InitData();
            //LocalIPAddress();
           
            
        }
        Timer a;
        frm_Loading frm;
        int time = 15;
        private void cmd_Chonmaychu_Click(object sender, System.EventArgs e)
        {
            frm = new frm_Loading();
            frm.progress.Text = "Đang xử lý. Còn"+time+" giây";
            frm.progress.Caption = "Hệ thống đang dò tìm";
            a = new Timer();
            a.Interval = 1000;
            a.Tick += new System.EventHandler(a_Tick);
            a.Start();
            frm.ShowDialog();
            GetAllIPAndHostNames();
        }

        void a_Tick(object sender, System.EventArgs e)
        {
            time--;
            frm.progress.Text = "Đang xử lý. Còn" + time + " giây";
            if (time <= 0)
            {
                frm.Close();
                a.Stop();
            }
            //throw new System.NotImplementedException();
        }
        public void LocalIPAddress()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
              //  if (ip.AddressFamily == AddressFamily.InterNetwork)
              //  {
                    localIP = ip.ToString();
                    MessageBox.Show(localIP);
               // }
            }
           // return localIP;
        }
        public void Getsql()
        {
            DataTable dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            MessageBox.Show(dt.Rows.Count.ToString());
            foreach (DataRow dr in dt.Rows)
            {

                comboBox1.Items.Add(string.Concat(dr["ServerName"], "\\", dr["InstanceName"]));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            DataTable dtable = SmoApplication.EnumAvailableSqlServers(false);
            string ServerName;

            foreach (DataRow dr in dtable.Rows)
            {
                ServerName = dr["Server"].ToString();

                if (!Convert.IsDBNull(dr["Instance"]) & dr["Instance"].ToString().Length > 0)
                    ServerName += "\\" + dr["Instance"].ToString();

                if (comboBox1.Items.IndexOf(ServerName) < 0)
                    comboBox1.Items.Add(ServerName);

                if (comboBox1.Items.Count > 0)
                    comboBox1.SelectedIndex = 0;
            }
        }
    }
}