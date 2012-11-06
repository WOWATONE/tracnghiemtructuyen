using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Docking;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using DevExpress.XtraEditors;
using TNTT.Class;
using System.Configuration;
namespace TNTT.Class
{
    public static class PreBase
    {
        public static C_Session obj_user = new C_Session();
        public static void CloseAllForm(Form parent)
        {
            if (parent.MdiChildren != null)
                foreach (Form i in parent.MdiChildren)
                    i.Close();
        }
        public static Form GetChild(Form parent, string child)
        {
            if (parent.MdiChildren != null)
                foreach (Form i in parent.MdiChildren)
                    if (i.GetType().FullName == child)
                        return i;
            return null;
        }
        public static void ShowDiaLog<T>(Form parent) where T : Form, new()
        {
            var frm = new T();
            frm.ShowDialog();
        }
        public static void ShowFormSpecial(Form frm)
        { 
            
        }
        //static Timer t;
        public static void ShowForm<T>(Form parent) where T : Form, new()
        {
            var x = typeof(T);
            var frm = (T)GetChild(parent, x.FullName);
            Component.frm_Loading frm_loading = new Component.frm_Loading();


            if (frm == null || frm.IsDisposed)
            {
                frm = new T() { MdiParent = parent };
                //frm_loading.progress.Caption = "Đang load dữ liệu";
                //frm_loading.progress.Description = "Loading ...";

                frm.Show();
                //frm_loading.Show();
                //t = new Timer();
                //t.Interval = 1000;
                //t.Tick += new EventHandler((Object sender, EventArgs e) =>
                //{
                //    t_Tick(frm_loading);
                //});
                //t.Start();
            }
            else
            {
                frm.Activate();
                int index = NumberRibbonPageActiveForm(frm, parent);
                //((RibbonForm)parent).Ribbon.Page
            }
        }

        static void t_Tick(Form frm)
        {
           // frm.Close();
            //throw new NotImplementedException();
        }
        public static void VisibleMenu(Form parent, bool visible = true)
        {
            if (parent != null)
            {
                var i = ((RibbonForm)parent).Ribbon.Pages.Count - 1;
                while (i-- > 1)
                    ((RibbonForm)parent).Ribbon.Pages[i].Visible = visible;

            }
        }
        public static string UserAcessControl(int chucvu)
        {
            string[] cv = { "100101", "111001", "111001", "111101", "111111" };
            return cv[chucvu - 1];
        }
        public static void DefaultFormAfterLogin(string chucvu, Form parent)
        {
            switch (int.Parse(chucvu))
            {
                case 1:
                    ShowForm<FormView.frm_Infomation>(parent);
                    break;

                case 2:
                case 3:
                    ShowForm<FormView.frm_Nganhangcauhoi>(parent);
                    break;

                default:
                    ShowForm<FormView.frm_GiangVien>(parent); break;
            }
        }
        public static int NumberRibbonPageActiveForm(Form child,Form parent)
        {
            
            return 1;
        }
        public static void CheckBeforeLoad(Form parent)
        {
            try
            {
                SqlConnection sqlcnn;
                string connstr = ConfigurationManager.ConnectionStrings["database"].ConnectionString;
                sqlcnn = new SqlConnection(connstr);
                sqlcnn.Open();
            }
            catch
            {
                ShowDiaLog<Component.frm_Config>(parent);
            }
        }
    }
}
