using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
//soc ket
using System.Net.Sockets;
using System.Net;
using FirstConnectDB;
namespace SINHVIEN
{
    public partial class frm_MDI : DevExpress.XtraEditors.XtraForm
    {
        public frm_MDI()
        {
            InitializeComponent();
        }

        private void frm_Thi_Load(object sender, EventArgs e)
        {
            //ConnectToServer();
            var frm = new FrmAddConnection();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(@"Đã lưu cấu hình của chương trình!\nChương trình sẽ khởi động lại để cập nhật dữ liệu!");
                 Application.Restart();
            }
            //frm.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel5.Visible = false;
            panel7.Visible = false;
            panel9.Visible = false;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel5.Visible = true;
            panel7.Visible = true;
            panel9.Visible = true;
        }








        /// <summary>
        /// Socket
        /// </summary>
        byte[] m_dataBuffer = new byte[10];
        IAsyncResult m_result;
        public AsyncCallback m_pfnCallBack;
        private System.Windows.Forms.Button btnClear;
        public Socket m_clientSocket;
        int port = 8000;
        void ConnectToServer()
        {
            try
            {
                //UpdateControls(false);
                // Create the socket instance
                m_clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                // Cet the remote IP address
                IPAddress ip = IPAddress.Parse("192.168.1.100");
                int iPortNo = port;
                // Create the end point 
                IPEndPoint ipEnd = new IPEndPoint(ip, iPortNo);
                // Connect to the remote host
                m_clientSocket.Connect(ipEnd);
                if (m_clientSocket.Connected)
                {

                   // UpdateControls(true);
                    //Wait for data asynchronously 
                    WaitForData();
                }
            }
            catch (SocketException se)
            {
                string str;
                str = "\nConnection failed, is the server running?\n" + se.Message;
                MessageBox.Show(str);
               // UpdateControls(false);
            }		
        }
        public void WaitForData()
        {
            try
            {
                if (m_pfnCallBack == null)
                {
                    m_pfnCallBack = new AsyncCallback(OnDataReceived);
                }
                SocketPacket theSocPkt = new SocketPacket();
                theSocPkt.thisSocket = m_clientSocket;
                // Start listening to the data asynchronously
                m_result = m_clientSocket.BeginReceive(theSocPkt.dataBuffer,
                                                        0, theSocPkt.dataBuffer.Length,
                                                        SocketFlags.None,
                                                        m_pfnCallBack,
                                                        theSocPkt);
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }

        }
        public void OnDataReceived(IAsyncResult asyn)
        {
            try
            {
                
                SocketPacket theSockId = (SocketPacket)asyn.AsyncState;
                int iRx = theSockId.thisSocket.EndReceive(asyn);
                char[] chars = new char[iRx + 1];
                System.Text.Decoder d = System.Text.Encoding.UTF8.GetDecoder();
                int charLen = d.GetChars(theSockId.dataBuffer, 0, iRx, chars, 0);
                System.String szData = new System.String(chars);
                string straa = szData;
                if (straa == "123454321")
                {
                    cmd_Nopbai.Enabled = true;
                    //MessageBox.Show("1");
                }
                else
                {
                    //notifyIcon1.BalloonTipTitle = "Tin nhắn từ giám thị";
                    //notifyIcon1.BalloonTipText = straa;
                    //notifyIcon1.Icon = Properties.Resources._ws;
                    //notifyIcon1.ShowBalloonTip(5000, "Tin nhắn", straa, ToolTipIcon.Info);
                    //MessageBox.Show("2");
                    richEditControl1.Text = szData;
                }
                    WaitForData();
                
            }
            catch (ObjectDisposedException)
            {
                System.Diagnostics.Debugger.Log(0, "1", "\nOnDataReceived: Socket has been closed\n");
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }
        public class SocketPacket
        {
            public System.Net.Sockets.Socket thisSocket;
            public byte[] dataBuffer = new byte[1024];
        }

        private void cmd_Nopbai_Click(object sender, EventArgs e)
        {

        }
    }
}