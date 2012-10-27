using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
namespace TNTT.FormView
{
    public partial class frm_tool : DevExpress.XtraEditors.XtraForm
    {
        public frm_tool()
        {
            InitializeComponent();
        }
        #region VIRTUAL
        public virtual void Add()
        {
            ClearDataBind();
            ResetInput();
            Click_Perform(false);
            Expand(true);
            isReadOnly(true);
        }
        public virtual void Edit()
        {
            Click_Perform(false);
            Expand(true);
            isReadOnly(true);
        }
        public virtual void Delete()
        {
            //Click_Perform(false);
           // isReadOnly(true);
        }
        public virtual void Save()
        {
            Expand(false);
            Click_Perform(true);
        }
        public virtual void Cancel()
        {
            Expand(false);
            ReFresh();
            Click_Perform(true);
        }
        public virtual void Search()
        {
            Click_Perform(false);
            isReadOnly(true);
            Expand(true);
        
        }
        public virtual void Print()
        {
            //Click_Perform(false);
        }
        public virtual void ReFresh()
        {
            //Click_Perform(false);
        }
        public virtual void Init()
        {
            Click_Perform(true);
            UserAccessFunction();
        }
        public virtual void Encode() { }
        public virtual void Decode() { }
        public virtual void UserAccessFunction() { }
        public virtual void Exit() { }
        public virtual void DataBind() { }
        public virtual void ClearDataBind() { }
        public virtual void ResetInput() { }
        public virtual bool ValidInput() { return true; }
        public virtual void VisibleTool(bool flag)
        {
            if (flag == false)
            {
                cmd_Add.Visibility = cmd_Cancel.Visibility=cmd_Delete.Visibility = BarItemVisibility.Never;
                cmd_Edit.Visibility =cmd_Save.Visibility= BarItemVisibility.Never;
            }
        }
        public virtual void Expand(bool flag)
        { 
            //
        }
        public virtual void isReadOnly(bool flag)
        { }
        public virtual void Click_Perform(bool flag)
        {
            cmd_Add.Enabled = cmd_Delete.Enabled = cmd_Edit.Enabled = cmd_Refresh.Enabled= cmd_Print.Enabled=cmd_Search.Enabled= flag;
            cmd_Save.Enabled = cmd_Cancel.Enabled = !flag;
        }
        #endregion
        private void cmd_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Add();
           
        }

        private void cmd_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Delete();
           
        }

        private void cmd_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Edit();
            
        }

        private void cmd_Search_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Search();
            
        }

        private void cmd_Save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Save();
            
        }

        private void cmd_Cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Cancel();
          
        }

        private void cmd_Print_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Print();
           
        }

        private void cmd_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReFresh();
        }

        private void cmd_Close_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Exit();
        }

        private void frm_tool_Load(object sender, EventArgs e)
        {
            Init();
        }
        private bool allowAdd;
        /// <summary>
        /// Hiển thị nút add hay không
        /// </summary>
        [DefaultValue(false)]
        public bool AllowAdd
        {
            get { return allowAdd; }
            set
            {
                allowAdd = value;
                if (!allowAdd)
                    cmd_Add.Visibility = BarItemVisibility.Never;
                else cmd_Add.Visibility = BarItemVisibility.Always;
            }
        }
        private bool allowDelete;
        /// <summary>
        /// CÓ HIỂN THỊ NÚT DELETE HAY KHÔNG
        /// </summary>
        [DefaultValue(false)]
        public bool AllowDelete
        {
            get { return allowDelete; }
            set
            { 
                allowDelete = value;
                if (!allowDelete)
                    cmd_Delete.Visibility = BarItemVisibility.Never;
                else cmd_Delete.Visibility = BarItemVisibility.Always;
            }
        }
        private bool allowEdit;
        /// <summary>
        /// CÓ HIỂN THỊ NÚT sửa HAY KHÔNG
        /// </summary>
        [DefaultValue(false)]
        public bool AllowEdit
        {
            get { return allowEdit; }
            set
            {
                allowEdit = value;
                if (!allowEdit)
                    cmd_Edit.Visibility = BarItemVisibility.Never;
                else cmd_Edit.Visibility = BarItemVisibility.Always;
            }
        }
        private bool allowSave;
        /// <summary>
        /// CÓ HIỂN THỊ NÚT DELETE HAY KHÔNG
        /// </summary>
        [DefaultValue(false)]
        public bool AllowSave
        {
            get { return allowSave; }
            set
            {
                allowSave = value;
                if (!allowSave)
                    cmd_Save.Visibility = BarItemVisibility.Never;
                else cmd_Save.Visibility = BarItemVisibility.Always;
            }
        }
        private bool allowCancel;
        /// <summary>
        /// CÓ HIỂN THỊ NÚT hủy HAY KHÔNG
        /// </summary>
        [DefaultValue(false)]
        public bool AllowCancel
        {
            get { return allowCancel; }
            set
            {
                allowCancel = value;
                if (!allowCancel)
                    cmd_Cancel.Visibility = BarItemVisibility.Never;
                else cmd_Cancel.Visibility = BarItemVisibility.Always;
            }
        }
        private bool allowSearch;
        /// <summary>
        /// CÓ HIỂN THỊ NÚT DELETE HAY KHÔNG
        /// </summary>
        [DefaultValue(false)]
        public bool AllowSearch
        {
            get { return allowSearch; }
            set
            {
                allowSearch = value;
                if (!allowSearch)
                    cmd_Search.Visibility = BarItemVisibility.Never;
                else cmd_Search.Visibility = BarItemVisibility.Always;
            }
        }
        private bool allowPrint;
        /// <summary>
        /// CÓ HIỂN THỊ NÚT DELETE HAY KHÔNG
        /// </summary>
        [DefaultValue(false)]
        public bool AllowPrint
        {
            get { return allowPrint; }
            set
            {
                allowPrint = value;
                if (!allowPrint)
                    cmd_Print.Visibility = BarItemVisibility.Never;
                else cmd_Print.Visibility = BarItemVisibility.Always;
            }
        }

        
        

    }
}