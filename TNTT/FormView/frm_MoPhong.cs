using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
//socket
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Collections;
using System.Data.OleDb;

//image
using System.IO;

namespace TNTT.FormView
{
    public partial class cbo_Phongthi : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        Class.C_PhongThi pt = new Class.C_PhongThi();
        string strimg = "";
        int index = -1;
        public cbo_Phongthi()
        {
            InitializeComponent();
        }

        void Loaddata()
        {
            dt = pt.GetListByIdGiamThi(Class.PreBase.obj_user.Idgiangvien);
            cbo_DsPhong.DataSource = dt;
            cbo_DsPhong.ValueMember = "idphongthi";
            cbo_DsPhong.DisplayMember = "tenphongthi";
            if(cbo_DsPhong.Items.Count>0)
                cbo_DsPhong.SelectedIndex = 0;
        }

        private void frm_MoPhong_Load(object sender, EventArgs e)
        {
            lb_ip.Text = GetIP();
            // rich_mess.Enabled = false;
            cmd_thubaithi.Enabled = false;
            lst_Log.Enabled = false;
            Loaddata();
            if (Class.PreBase.obj_user.IsConnect == false)
                OpenConnection();
            lb_tengv.Text = Class.PreBase.obj_user.Hoten_giangvien;
            LoadImage();

        }

        private void btn_TaoMK_Click(object sender, EventArgs e)
        {
            if (index != -1)
            {
                strimg = dt.Rows[index]["matkhau"].ToString();
                if (dt.Rows[index]["matkhau"].ToString().Length < 3)
                    strimg = Class.C_Random.GetStringRandom(4);
                pictureBox1.Image = Component.Com_Base.Convert_Text_to_Image(strimg, "Bookman Old Style", 20); // Passing appropriate value to Convert_Text_to_Image method 
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                btn_TaoMK.Visible = false;
                dt.Rows[index]["matkhau"] = strimg;
            }
        }

        private void lst_phongThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_DsPhong.SelectedIndex != -1)
            {
                index = cbo_DsPhong.SelectedIndex;
                lb_maphong.Text = dt.Rows[index]["maphongthi"].ToString();
                cbo_DsPhong.Text = dt.Rows[index]["tenphongthi"].ToString();
                lb_thoigian.Text = dt.Rows[index]["thoigianthi"].ToString();
                try
                {
                    //btn_TaoMK_Click(sender, e);
                }
                catch { }

            }
        }



        /// <summary>
        /// Cacs thong so de ket noi
        /// </summary>
        private OleDbConnection objConnect;
        private DataTable objDataTable;
        private System.Collections.ArrayList m_workerSocketList =
                ArrayList.Synchronized(new System.Collections.ArrayList());
        private Socket m_mainSocket;
        private int m_clientCount = 0;
        public delegate void UpdateRichEditCallback(string text);
        public delegate void UpdateClientListCallback();
        public AsyncCallback pfnWorkerCallBack;


        int port = 8000;
        void Connect()
        {
            try
            {
                string msg = "123454321";
                byte[] byData = System.Text.Encoding.ASCII.GetBytes(msg);
                Socket workerSocket = null;
                for (int i = 0; i < m_workerSocketList.Count; i++)
                {
                    workerSocket = (Socket)m_workerSocketList[i];
                    if (workerSocket != null)
                    {
                        if (workerSocket.Connected)
                        {
                            workerSocket.Send(byData);
                        }
                    }
                }
                Class.PreBase.obj_user.IsConnect = true;
            }
            catch (SocketException se)
            {

                MessageBox.Show(se.Message);
            }
        }
        void ChangeStatus(bool flag)
        {
            cmd_thubaithi.Enabled = flag;
            cmd_Mophongthi.Enabled = !flag;
            lst_Log.Enabled = !flag;
        }
        private void cmd_Mophongthi_Click(object sender, EventArgs e)
        {
            if (Class.PreBase.obj_user.IsConnect == false)
                Connect();
            ChangeStatus(true);
            if (cbo_DsPhong.SelectedIndex != -1)
                pt.OpenRoom(cbo_DsPhong.SelectedValue.ToString());

        }

        void OpenConnection()
        {
            try
            {
                ConnectToClient();
                string msg = "1111";
                msg = "Server Msg: " + msg + "\n";
                byte[] byData = System.Text.Encoding.ASCII.GetBytes(msg);
                Socket workerSocket = null;
                for (int i = 0; i < m_workerSocketList.Count; i++)
                {
                    workerSocket = (Socket)m_workerSocketList[i];
                    if (workerSocket != null)
                    {
                        if (workerSocket.Connected)
                        {
                            workerSocket.Send(byData);
                        }
                    }
                }

            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }
        void ConnectToClient()
        {
            try
            {

                // Create the listening socket...
                m_mainSocket = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream,
                    ProtocolType.Tcp);
                IPEndPoint ipLocal = new IPEndPoint(IPAddress.Any, port);
                // Bind to local IP Address...
                m_mainSocket.Bind(ipLocal);
                // Start listening...
                m_mainSocket.Listen(4);
                // Create the call back for any client connections...
                m_mainSocket.BeginAccept(new AsyncCallback(OnClientConnect), null);

                //UpdateControls(true);

            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }
        public void OnClientConnect(IAsyncResult asyn)
        {
            try
            {
                // Here we complete/end the BeginAccept() asynchronous call
                // by calling EndAccept() - which returns the reference to
                // a new Socket object
                Socket workerSocket = m_mainSocket.EndAccept(asyn);

                // Now increment the client count for this client 
                // in a thread safe manner
                Interlocked.Increment(ref m_clientCount);

                // Add the workerSocket reference to our ArrayList
                m_workerSocketList.Add(workerSocket);

                // Send a welcome message to client
                string msg = "Welcome client " + m_clientCount + "\n";
                SendMsgToClient(msg, m_clientCount);

                // Update the list box showing the list of clients (thread safe call)
                ///----------------------------------------------------------------------UpdateClientListControl();

                // Let the worker Socket do the further processing for the 
                // just connected client
                WaitForData(workerSocket, m_clientCount);

                // Since the main Socket is now free, it can go back and wait for
                // other clients who are attempting to connect
                m_mainSocket.BeginAccept(new AsyncCallback(OnClientConnect), null);
            }
            catch (ObjectDisposedException)
            {
                System.Diagnostics.Debugger.Log(0, "1", "\n OnClientConnection: Socket has been closed\n");
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }

        }
        private void UpdateClientListControl()
        {
            if (InvokeRequired) // Is this called from a thread other than the one created
            // the control
            {
                // We cannot update the GUI on this thread.
                // All GUI controls are to be updated by the main (GUI) thread.
                // Hence we will use the invoke method on the control which will
                // be called when the Main thread is free
                // Do UI update on UI thread
                lst_Log.BeginInvoke(new UpdateClientListCallback(UpdateClientList), null);
            }
            else
            {
                // This is the main thread which created this control, hence update it
                // directly 
                UpdateClientList();
            }
        }
        void UpdateClientList()
        {
            lst_Log.Items.Clear();
            for (int i = 0; i < m_workerSocketList.Count; i++)
            {
                string clientKey = Convert.ToString(i + 1);
                Socket workerSocket = (Socket)m_workerSocketList[i];
                if (workerSocket != null)
                {
                    if (workerSocket.Connected)
                    {
                        lst_Log.Items.Add(clientKey);
                    }
                }
            }
        }
        void SendMsgToClient(string msg, int clientNumber)
        {
            // Convert the reply to byte array
            byte[] byData = System.Text.Encoding.ASCII.GetBytes(msg);

            Socket workerSocket = (Socket)m_workerSocketList[clientNumber - 1];
            workerSocket.Send(byData);
        }
        public void WaitForData(System.Net.Sockets.Socket soc, int clientNumber)
        {
            try
            {
                if (pfnWorkerCallBack == null)
                {
                    // Specify the call back function which is to be 
                    // invoked when there is any write activity by the 
                    // connected client
                    pfnWorkerCallBack = new AsyncCallback(OnDataReceived);
                }
                SocketPacket theSocPkt = new SocketPacket(soc, clientNumber);

                soc.BeginReceive(theSocPkt.dataBuffer, 0,
                    theSocPkt.dataBuffer.Length,
                    SocketFlags.None,
                    pfnWorkerCallBack,
                    theSocPkt);
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }
        public class SocketPacket
        {
            // Constructor which takes a Socket and a client number
            public SocketPacket(System.Net.Sockets.Socket socket, int clientNumber)
            {
                m_currentSocket = socket;
                m_clientNumber = clientNumber;
            }
            public System.Net.Sockets.Socket m_currentSocket;
            public int m_clientNumber;
            // Buffer to store the data sent by the client
            public byte[] dataBuffer = new byte[1024];
        }
        public void OnDataReceived(IAsyncResult asyn)
        {
            SocketPacket socketData = (SocketPacket)asyn.AsyncState;
            try
            {
                // Complete the BeginReceive() asynchronous call by EndReceive() method
                // which will return the number of characters written to the stream 
                // by the client
                int iRx = socketData.m_currentSocket.EndReceive(asyn);
                char[] chars = new char[iRx + 1];
                // Extract the characters as a buffer
                System.Text.Decoder d = System.Text.Encoding.UTF8.GetDecoder();
                int charLen = d.GetChars(socketData.dataBuffer,
                    0, iRx, chars, 0);

                System.String szData = new System.String(chars);
                string msg = "" + socketData.m_clientNumber + ":";
                //AppendToRichEditControl(msg + szData);

                // Send back the reply to the client
                string replyMsg = "Server Reply:" + subCreateConnect(doilai(szData.ToUpper()));
                // Convert the reply to byte array
                byte[] byData = System.Text.Encoding.ASCII.GetBytes(replyMsg);

                Socket workerSocket = (Socket)socketData.m_currentSocket;
                workerSocket.Send(byData);

                // Continue the waiting for data on the Socket
                WaitForData(socketData.m_currentSocket, socketData.m_clientNumber);

            }

            catch (ObjectDisposedException)
            {
                System.Diagnostics.Debugger.Log(0, "1", "\nOnDataReceived: Socket has been closed\n");
            }
            catch (SocketException se)
            {
                if (se.ErrorCode == 10054) // Error code for Connection reset by peer
                {
                    string msg = "Client " + socketData.m_clientNumber + " Disconnected" + "\n";
                    //AppendToRichEditControl(msg);

                    // Remove the reference to the worker socket of the closed client
                    // so that this object will get garbage collected
                    m_workerSocketList[socketData.m_clientNumber - 1] = null;
                    UpdateClientListControl();
                }
                else
                {
                    MessageBox.Show(se.Message);
                }
            }
        }
        private string doilai(string nhap)
        {
            string ketqua;
            ketqua = nhap.Substring(0, nhap.Length - 3);
            return ketqua;
        }

        private string subCreateConnect(string qr)
        {
            string kqtrave = null;
            String varChuoiConnect = "Provider = Microsoft.Jet.OLEDB.4.0 ;" +
                        "Data Source =" + Application.StartupPath + @"\databt.mdb;";
            objConnect = new OleDbConnection(varChuoiConnect);
            objConnect.Open(); //Mở kết nối
            objDataTable = new DataTable("Abc");
            try
            {
                OleDbDataAdapter objAdapter = new OleDbDataAdapter("SELECT Info FROM info WHERE (ID LIKE '%" + qr + "%') OR(Name LIKE '%" + qr + "%')", objConnect);
                objAdapter.Fill(objDataTable);
                kqtrave = (objDataTable.Rows[0]["Info"].ToString());
            }
            catch (Exception)
            {

                kqtrave = "Khong tim thay ma truong";
            }
            finally
            {
                objConnect.Close();
            }
            return kqtrave;

        }
        void CloseSockets()
        {
            if (m_mainSocket != null)
            {
                m_mainSocket.Close();
            }
            Socket workerSocket = null;
            for (int i = 0; i < m_workerSocketList.Count; i++)
            {
                workerSocket = (Socket)m_workerSocketList[i];
                if (workerSocket != null)
                {
                    workerSocket.Close();
                    workerSocket = null;
                }
            }
        }
        void ThuBaiThi()
        {
            XtraMessageBox.Show("Đã thu bài thi");
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ChangeStatus(false);
            if (cbo_DsPhong.SelectedIndex != -1)
                pt.CloseRoom(cbo_DsPhong.SelectedValue.ToString());
            ThuBaiThi();

        }
        string GetIP()
        {
            string strHostName = Dns.GetHostName();

            // Find host by name
            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);

            // Grab the first IP addresses
            string IPStr = "";
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                IPStr = ipaddress.ToString();
                return IPStr;
            }
            return IPStr;
        }

        private void btn_Tinnhan_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = "aaaa";// rich_mess.Text;
                msg = "Tin nhan tu giam thi:" + msg + "\n";
                byte[] byData = System.Text.Encoding.ASCII.GetBytes(msg);
                Socket workerSocket = null;
                for (int i = 0; i < m_workerSocketList.Count; i++)
                {
                    workerSocket = (Socket)m_workerSocketList[i];
                    if (workerSocket != null)
                    {
                        if (workerSocket.Connected)
                        {
                            workerSocket.Send(byData);
                        }
                    }
                }
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }




        ///trinh bay giao dien
        ///

        public void LoadImage()
        {
            try
            {
                MemoryStream ms = new MemoryStream((byte[])Class.PreBase.obj_user.Avatar_giangvien);
                pictureBox2.Image = Image.FromStream(ms);
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Refresh();
            }
            catch
            {
                pictureBox2.Image = Image.FromFile(@"Avatar/1.jpg");
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.Refresh();
            }
        }

        private void cbo_DsPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = cbo_DsPhong.SelectedIndex;
            if (index != -1)
            {
                lb_maphong.Text = cbo_DsPhong.SelectedText;
                lb_thoigian.Text = dt.Rows[index]["thoigianthi"].ToString();
            }
        }

        private void cbo_Phongthi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chức năng này không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
               pt.CloseRoom(cbo_DsPhong.SelectedValue.ToString());
            }
        }

    }
}