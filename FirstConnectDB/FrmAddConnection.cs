using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.Win32;
using Settings = FirstConnectDB.Properties.Settings;

namespace FirstConnectDB
{
    public partial class FrmAddConnection : Form
    {
        private readonly DataTable _dtServers = new DataTable();
        private EventHandler _handler;
        private Server _mServer;
        private ServerConnection _mServerConnection;

        public FrmAddConnection()
        {
            InitializeComponent();
        }

        public Server DatabaseServer
        {
            get { return _mServer; }
        }

        public new static DialogResult Show()
        {
            var frm = new FrmAddConnection {TopMost = true};
            return frm.ShowDialog();
        }

        private IEnumerable<string> GetInstance()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\");
            }
            catch (Exception)
            {
                rk = Registry.LocalMachine.OpenSubKey(@"\SOFTWARE\Microsoft\Microsoft SQL Server\");
            }
            if (rk == null)
                return null;
            return (String[]) rk.GetValue("InstalledInstances");
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            // Application was idle and thats when we do the work.
            // Lets first un-register the event.
            Application.Idle -= _handler;

            // Find local instance
            _dtServers.Columns.Add(new DataColumn("Name"));
            IEnumerable<string> instances = GetInstance();

            //What type of authentication the user wants?  We will have to change the string as required.
            if (Settings.Default.SQLAuthenticationMode)
            {
                cbo_Type.SelectedIndex = 1;//SQL

                if (Settings.Default.SavePassword)
                {
                    txtUserName.Text = Settings.Default.UserName;
                    txtPassword.Text = Settings.Default.Password;
                }
                else
                {
                    pnlConnectionInfo.Enabled = true;
                    Cursor = Cursors.Default;
                    return;
                }
            }
            else
            {
                cbo_Type.SelectedIndex = 0;//Window
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
            }

            string tmpDbName = Settings.Default.DatabaseName;
            if (!string.IsNullOrEmpty(tmpDbName))
            {
                btnTestConnection_Click(this, null);
            }
            pnlConnectionInfo.Enabled = true;
            Cursor = Cursors.Default;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            pnlConnectionInfo.Enabled = false;
            _handler = Application_Idle;
            Application.Idle += _handler;
        }
        private bool CheckInput()
        {
            if (txt_Srv.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên máy chủ");
                return false;
            }
            if (cbo_Type.SelectedIndex == 1)
            {
                if (txtUserName.Text.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống");
                    return false;
                }
                if (txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống");
                    return false;
                }
            }
            return true;
        }
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {

                Settings.Default.Server = txt_Srv.Text;
                if (cbo_Type.SelectedIndex == 1)
                {
                    Settings.Default.UserName = txtUserName.Text;
                    Settings.Default.Password = txtPassword.Text;
                }
                Settings.Default.ConnectString = BuildConnectString();
                if (TestConnect())
                    MessageBox.Show("Kết nối máy chủ thành công");
                else
                    MessageBox.Show("Kết nối máy chủ không thành công. Vui lòng kiếm tra lại");  
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        public static string BuildConnectString()
        {
            string connectStr;
            if (!Settings.Default.SQLAuthenticationMode)
            {
                connectStr = @"Server=" + Settings.Default.Server + ";Database=" + Settings.Default.DatabaseName +
                             ";Trusted_Connection=True;";
            }
            else
            {
                connectStr = @"Server=" + Settings.Default.Server + ";Database=" + Settings.Default.DatabaseName +
                             ";Integrated Security=SSPI;User ID=" + Settings.Default.UserName + ";Password=" +
                             Settings.Default.Password + ";";
            }
            return connectStr;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Settings.Default.Server = txt_Srv.Text;
            Settings.Default.SQLAuthenticationMode = cbo_Type.SelectedIndex==1;
            Settings.Default.DatabaseName = "QLCHAMDIEMTRACNGHIEM";
            if (cbo_Type.SelectedIndex == 1)
            {
                Settings.Default.UserName = txtUserName.Text;
                Settings.Default.Password = txtPassword.Text;
                Settings.Default.SavePassword = true;
            }
            else
            {
                Settings.Default.UserName = string.Empty;
                Settings.Default.Password = string.Empty;
                Settings.Default.SavePassword = false;
            }
            Settings.Default.ConnectString = BuildConnectString();

            Settings.Default.Save();
            DialogResult = DialogResult.OK;
            Close();
            
        }

        public static bool TestConnect()
        {
            string strConnect = Settings.Default.ConnectString;
            if (strConnect.Equals(""))
                return false;
            SqlConnection mConnect = null;
            try
            {
                mConnect = new SqlConnection(strConnect);
                mConnect.Open();
                mConnect.Close();
                return true;
            }
            catch
            {
                if (mConnect != null)
                    if (mConnect.State == ConnectionState.Open)
                        mConnect.Close();
                return false;
            }
        }


       

        
        private void FrmAddConnection_Load(object sender, EventArgs e)
        {
            txt_Srv.Text = Settings.Default.Server;
            if (Settings.Default.SQLAuthenticationMode == true)
            {
                cbo_Type.SelectedIndex = 1;
                txtUserName.Text = Settings.Default.UserName;
                txtPassword.Text = Settings.Default.Password;
            }
            else
                cbo_Type.SelectedIndex = 0;

        }
    }
}