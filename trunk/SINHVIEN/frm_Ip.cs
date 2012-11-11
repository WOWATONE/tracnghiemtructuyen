using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
namespace SINHVIEN
{
    public partial class frm_Ip : Form
    {
        public delegate void Iphandler(string ip);
        public event Iphandler getIP;
        

        public frm_Ip()
        {
            InitializeComponent();
        }

        private void frm_Ip_Load(object sender, EventArgs e)
        {

        }
        public void GetIpAdress(string ip)
        {
            try
            {
                IPAddress ip_temp = IPAddress.Parse(txt_IP.Text);
                getIP(txt_IP.Text);
            }
            catch
            {
                MessageBox.Show("Địa chỉ IP sai, vui lòng nhập lại");
            }
        }
        public void cmd_OK_Click(object sender, EventArgs e)
        {
          //  getIP(ip);
          //  GetIpAdress(ip);
            
        }
    }
}
