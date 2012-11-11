﻿using System;
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
//using FirstConnectDB;
using DevExpress.XtraNavBar;
using TNTT.Class;
using System.IO;
using Settings = SINHVIEN.Properties.Settings;
using FirstConnectDB;
namespace SINHVIEN
{
    public partial class frm_MDI : DevExpress.XtraEditors.XtraForm
    {
        C_DeThi dth = new C_DeThi();

        DataTable dt_th = new DataTable();
        string[] a = new string[200];
        /// <summary>
        /// N là Số câu của đề thi, index là số câu hiện tại
        /// </summary>
        int n,index = 0;
        int current = 0;

        Class.C_Aquestion [] ds = new Class.C_Aquestion[101];
        public frm_MDI()
        {
            InitializeComponent();
        }
        public void LoadImage()
        {
            try
            {
                MemoryStream ms = new MemoryStream((byte[])C_Base.obj.Avatar);
                pictureBox1.Image = Image.FromStream(ms);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Refresh();
            }
            catch
            {
                pictureBox1.Image = Image.FromFile(@"Avatar/1.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Refresh();
            }
        }
        void LoadInfo()
        {
            LoadImage();
            lb_TenSinhVien.Text = C_Base.obj.Tensinhvien;
            lb_Lop.Text = C_Base.obj.Lop;
            lb_MaSinhVien.Text = C_Base.obj.Masinhvien;
            lb_NgayThi.Text = DateTime.Now.ToShortDateString();
        }
        private void frm_Thi_Load(object sender, EventArgs e)
        {
            LoadInfo();
            UpdateList(true);
        }
        private void cmd_Nopbai_Click(object sender, EventArgs e)
        {

        }
        public void TachDeThi()
        {
            dt_th = dth.GetIDQuestionByIdDeThi(C_Base.tt.Dethi);
            a = dt_th.Rows[0]["listidcauhoi"].ToString().Split(new string[]{"|||"},StringSplitOptions.None);
            n = a.Length;
            TronDeThi();
        }
        void LoadDapAn()
        {
            string condition = "(";
            for (int i = 0; i < a.Length; i++)
                condition += a[i] + ",";
            condition = condition.Substring(0, condition.Length - 1);
            condition += ")";


            DataTable dt_ans = new DataTable();
            dt_ans = dth.GetListAns(condition);
            for (int i = 0; i < a.Length; i++)
            {
                ds[index] = new Class.C_Aquestion();
                ds[index].Id = a[i];

                for (int j = dt_ans.Rows.Count - 1; j >= 0; j--)
                {
                    if (dt_ans.Rows[j]["nhch_idnganhangcauhoi"].ToString() == ds[index].Id)
                    {
                        //có tồn tại đáp án mới lấy
                        ds[index].Question = dt_ans.Rows[j]["tieude"].ToString();
                        //Câu thứ index có đáp án thứ hiện tại =  câu trả lới
                        //Trạng thái đúng sai = dapan trong csdl
                        ds[index].ListAns[ds[index].NumberAns] = new DA();
                        ds[index].ListAns[ds[index].NumberAns].answer = dt_ans.Rows[j]["cautraloi"].ToString();
                        ds[index].ListAns[ds[index].NumberAns].status = Convert.ToBoolean(dt_ans.Rows[j]["dapan"].ToString());
                        dt_ans.Rows.RemoveAt(j);
                        ds[index].NumberAns++; //so dap án hien tai
                    }
                }
                index++;
            }

        }
        void ResetRich()
        {
            r1.ResetText();
            r2.ResetText();
            r3.ResetText();
            r4.ResetText();
            r5.ResetText();
            r6.ResetText();
            rich_Cauhoi.ResetText();
        }
        public void TronDeThi()
        { 
            Random rd = new Random();
            for(int i=0;i<a.Length-1;i++)
            {
                int index = rd.Next(0,a.Length);
                    string temp = a[i];
                    a[i] = a[index];
                    a[index] = temp;
            }
     
        }
        void TronDapAn()
        {
           
        }
        void AnRichText(int i)
        {
            if (i < 6)
            {
                pnl_daF.Visible = false;
                splitterControl7.Visible = false;
            }
            if (i < 5)
            {
                pnl_daE.Visible = false;
                splitterControl6.Visible = false;
            }
            if (i < 4)
            {
                pnl_daD.Visible = false;
                splitterControl5.Visible = false;
            }
            if (i < 3)
            {
                pnl_daC.Visible = false;
                splitterControl4.Visible = false;
            }
            chkAA.Checked = chkB.Checked = chkC.Checked = chkD.Checked = chkE.Checked = chkF.Checked = false;

        }
        void LoadCauHoiThu(int x)
        {

            lb_cauhientai.Text = x+1 < 10 ? "0" + (x + 1).ToString() : (x + 1).ToString();
            int i = ds[x].NumberAns;
            AnRichText(i);
            rich_Cauhoi.Text = ds[x].Question;
            if (i > 0)
            {
                r1.Text = ds[x].ListAns[0].answer;
                pnl_daA.Visible = true;
                chkAA.Checked = ds[x].ListAns[0].isCheck;
            }
            if (i > 1)
            {
                r2.Text = ds[x].ListAns[1].answer;
                pnl_daB.Visible = true;
                chkB.Checked = ds[x].ListAns[1].isCheck;
            }
            if (i > 2)
            {
                r3.Text = ds[x].ListAns[2].answer;
                pnl_daC.Visible = true;
                splitterControl4.Visible = true;
                chkC.Checked = ds[x].ListAns[2].isCheck;
            }
            if (i > 3)
            {
                r4.Text = ds[x].ListAns[3].answer;
                pnl_daD.Visible = true;
                splitterControl4.Visible = true;
                chkD.Checked = ds[x].ListAns[3].isCheck;
            }
            if (i > 4)
            {
                r5.Text = ds[x].ListAns[4].answer;
                pnl_daE.Visible = true;
                splitterControl4.Visible = true;
                chkE.Checked = ds[x].ListAns[4].isCheck;
            }
            if (i > 5)
            {
                r6.Text = ds[x].ListAns[5].answer;
                pnl_daF.Visible = true;
                splitterControl4.Visible = true;
                chkF.Checked = ds[x].ListAns[5].isCheck;
                    
            }
            
            
        }
        private void cmd_Next_Click(object sender, EventArgs e)
        {
            UpdateNav(current);
            ResetRich();
            if (current == n - 1)
                current = -1;
            LoadCauHoiThu(++current);
        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            UpdateNav(current);
            ResetRich();
            if (current == 0)
                current = n ;
            LoadCauHoiThu(--current);
        }
        bool KiemTraDuocChon(Class.C_Aquestion x)
        {
            if (chkAA.Checked)
                return true;
            if (chkB.Checked)
                return true;
            if (chkC.Checked)
                return true;
            if (chkD.Checked)
                return true;
            if (chkE.Checked)
                return true;
            if (chkF.Checked)
                return true;
            return false;
        }
        void UpdateNav(int i)
        {
            if (KiemTraDuocChon(ds[i]))
                navBarGroup.ItemLinks[i].Item.SmallImage = Properties.Resources.ok;
            else
                navBarGroup.ItemLinks[i].Item.SmallImage = Properties.Resources.no;
        }
        void LoadNaViGroup()
        {
            navBarGroup.ItemLinks.Clear();
            for (int i = 0; i < n; i++)
            {
                NavBarItem item = new NavBarItem("Câu hỏi " + (i+1).ToString());
               // if (KiemTraDuocChon(ds[i]))
                    item.SmallImage = Properties.Resources.no;
                item.Tag = i.ToString();
                navBarGroup.ItemLinks.Add(item);
            }
            navBar_Cauhoi.LinkClicked += new NavBarLinkEventHandler(navBar_Cauhoi_LinkClicked);
        }

        void navBar_Cauhoi_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            UpdateNav(current);
            current = int.Parse(e.Link.Item.Tag.ToString());
            LoadCauHoiThu(int.Parse(e.Link.Item.Tag.ToString()));
     
        }

       
        private void chkAA_CheckedChanged(object sender, EventArgs e)
        {
            ds[current].ListAns[0].isCheck = chkAA.Checked;
        }

        private void chkB_CheckedChanged(object sender, EventArgs e)
        {
            ds[current].ListAns[1].isCheck = chkB.Checked;
        }

        private void chkC_CheckedChanged(object sender, EventArgs e)
        {
            ds[current].ListAns[2].isCheck = chkC.Checked;
        }

        private void chkD_CheckedChanged(object sender, EventArgs e)
        {
            ds[current].ListAns[3].isCheck = chkD.Checked;
        }

        private void chkE_CheckedChanged(object sender, EventArgs e)
        {
            ds[current].ListAns[4].isCheck = chkE.Checked;
        }

        private void chkF_CheckedChanged(object sender, EventArgs e)
        {
            ds[current].ListAns[5].isCheck = chkF.Checked;
        }

        private void navBar_Cauhoi_DoubleClick(object sender, EventArgs e)
        {
            return;
        }

        private void frm_MDI_KeyPress(object sender, KeyPressEventArgs e)
        {
          

        }

        private void frm_MDI_KeyDown(object sender, KeyEventArgs e)
        {
            UpdateNav(current);
            switch (e.KeyCode)
            { 
                case Keys.Right:
                case Keys.Enter:
                        ResetRich();
                        if (current == 0)
                            current = n;
                        LoadCauHoiThu(--current);
                        break;

                case Keys.Left:
                         ResetRich();
                        if (current == 0)
                            current = n ;
                        LoadCauHoiThu(--current);
                        break;
                default: break;
            }
        }

      
        void ConvertToSec(int time)
        {
            int h = time / 3600;
            int m = time % 3600 / 60;
            int s = time % 60;
          
            lb_ThoiGianThi.Text = h + ":" + m + ":" + s;
        }
        void timer1_Tick(object sender, EventArgs e)
        {
            if (Settings.Default.Thoigianlambai > 0)
            {
                Settings.Default.Thoigianlambai--;
                ConvertToSec(Settings.Default.Thoigianlambai);
            }
            else
            {
                Nopbai();
                timer1.Stop();
            }
                //throw new NotImplementedException();
        }
        void Nopbai()
        {
            XtraMessageBox.Show("Hết thời gian làm bài");
        }

        private void cmd_mess_DragOver(object sender, DragEventArgs e)
        {
            cmd_mess.Image = Properties.Resources.Messages48;
        }

        private void cmd_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectToServer();
            }
            catch
            {
                XtraMessageBox.Show("Không thể kết nối với máy chủ. Vui lòng thử lại");
            }
        }

         private void cmd_mess_Click(object sender, EventArgs e)
        {
            cmd_mess.Image = Properties.Resources.Messages48;
            cmd_mess.Enabled = false;
            frm_Message frm = new frm_Message(message);
            frm.Show();
        }
        void CloseSocket()
        {
            if (m_clientSocket != null)
            {
                m_clientSocket.Close();
                m_clientSocket = null;
               
                //UpdateControls(false);
            }
        }
        void Scoring()
        {
            //chạy từ đầu tới cuối danh sách
            DataTable dt_temp = new DataTable();
            dt_temp.Columns.Add("STT");
            dt_temp.Columns.Add("Trạng thái");
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
               // Số thứ tự
                
                bool isTrue = true;
                for (int j = 0; j < ds[i].NumberAns; j++)
                {
                    //trong cau hoi do, trong list cau tra loi so sanh tung phan tu
                    if (ds[i].ListAns[j].isCheck != ds[i].ListAns[j].status)
                        isTrue = false;
                }
                if (isTrue)
                {
                    dt_temp.Rows.Add(i.ToString(), "Đúng");
                    count++;
                }
                else
                    dt_temp.Rows.Add(i.ToString(), "Sai");
            }
            TNTT.Class.C_PhongThi pt = new C_PhongThi();
            pt.Scoring(C_Base.obj.Masinhvien,C_Base.tt.Idphong,((count/a.Length)*10).ToString());
            C_Base.obj.Diem = (count / a.Length) * 10;
            frm_KetQuaBaiThi frm = new frm_KetQuaBaiThi(dt_temp);
            frm.ShowDialog();         
            
        }
        private void cmd_nop_Click(object sender, EventArgs e)
        {
            cmd_nop.Enabled = false;
            Scoring();
            CloseSocket();
        }

        private void cmdConnect_Click_1(object sender, EventArgs e)
        {
            ConnectToServer();
        }

        private void cmd_LamBai_Click_2(object sender, EventArgs e)
        {
            cmd_LamBai.Enabled = false;
            cmd_nop.Enabled = true;
            cmd_mess.Enabled = true;
            group_cauhoi.Enabled = true;
            navBar_Cauhoi.Enabled = true;
            TachDeThi();
            TronDeThi();
            LoadDapAn();
            LoadCauHoiThu(current);
            LoadNaViGroup();
            Settings.Default.Thoigianlambai = int.Parse(C_Base.tt.Thoigian) * 60;
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }




        #region SOCKET
        /// <summary>
        /// Socket
        /// </summary>
        byte[] m_dataBuffer = new byte[10];
        IAsyncResult m_result;
        public AsyncCallback m_pfnCallBack;
        private System.Windows.Forms.Button btnClear;
        public Socket m_clientSocket;
        int port = 8000;
        void UpdateControls()
        {
            cmdConnect.Enabled = false;
            //cmd_LamBai.Enabled = true;
        }
        string ipaddress = "192.168.1.101";
        void UpdateList(bool add)
        {
            if (add)
            {
                C_DanhSachDangThi dathi = new C_DanhSachDangThi();
                dathi.Add(C_Base.tt.Idphong, C_Base.obj.Masinhvien);
            }
            else
            {
                C_DanhSachDangThi dathi = new C_DanhSachDangThi();
                dathi.Delete(C_Base.obj.Masinhvien,C_Base.tt.Idphong);

            }
        }
        void ConnectToServer()
        {
            try
            {
                // Create the socket instance
                m_clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse("192.168.1.101");
                int iPortNo = port;
                IPEndPoint ipEnd = new IPEndPoint(ip, iPortNo);
                m_clientSocket.Connect(ipEnd);
                if (m_clientSocket.Connected)
                    WaitForData();
                //sau khi ket noi thanh cong tien hang gui thong tin den máy chủ
                SendInfo();
                UpdateControls();
                //danh sach thi
                //UpdateList(true);
            }
            catch (SocketException se)
            {
                var result = MessageBox.Show("Máy chủ không hoạt động. Bạn có muốn cấu hình với 1 IP khác không?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    frm_Ip frm = new frm_Ip();
                    //ipaddress += new frm_Ip.Iphandler(
                }
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
                m_result = m_clientSocket.BeginReceive(theSocPkt.dataBuffer, 0, theSocPkt.dataBuffer.Length, SocketFlags.None, m_pfnCallBack, theSocPkt);
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }

        }
        string message = "";
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
                RecivedSignal(szData);
                message = szData;
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
        void RecivedSignal(string message)
        {
            if (InvokeRequired)
            {
                //Không thể cập nhật giao diện trên thread
                object[] pList = { message };
                //cmd_mess.Invoke(new (OnUpdateRichEdit), pList);
                if (message.ToString() == "mode1001")
                    cmd_LamBai.Enabled = true;
                else
                    OnUpdateSignal(message);
            }
            else
                OnUpdateSignal(message);
        }
        void OnUpdateSignal(string message)
        {
            if (message.Length < 10)
            {
                cmd_LamBai.Enabled = true;
                // MessageBox.Show(message);
                this.message = message;
                cmd_mess.Image = Properties.Resources.newMessages48;
                cmd_mess.Enabled = true;
            }
        }
        public class SocketPacket
        {
            public System.Net.Sockets.Socket thisSocket;
            public byte[] dataBuffer = new byte[1024];
        }
        void SendInfo()
        {
            try
            {
                string msg = C_Base.obj.Masinhvien;
                NetworkStream networkStream = new NetworkStream(m_clientSocket);
                System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(networkStream);
                streamWriter.WriteLine(msg);
                streamWriter.Flush();
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }
        }
        #endregion

        private void frm_MDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            //xoa danh sách
            UpdateList(false);
        }


    }
}