namespace TNTT.FormView
{
    partial class frm_Lop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dpn_containt = new DevExpress.XtraBars.Docking.DockPanel();
            this.dpn_status = new DevExpress.XtraBars.Docking.ControlContainer();
            this.LK_MaKhoa = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MaLop = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TenLop = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grd_Lop = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_TenLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_MaLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_MaKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dpn_containt.SuspendLayout();
            this.dpn_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LK_MaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dpn_containt});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dpn_containt
            // 
            this.dpn_containt.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.dpn_containt.Appearance.Options.UseBackColor = true;
            this.dpn_containt.Controls.Add(this.dpn_status);
            this.dpn_containt.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.dpn_containt.ID = new System.Guid("745364bd-942b-4468-a15f-4509be299b66");
            this.dpn_containt.Location = new System.Drawing.Point(0, 0);
            this.dpn_containt.Name = "dpn_containt";
            this.dpn_containt.Options.ShowCloseButton = false;
            this.dpn_containt.OriginalSize = new System.Drawing.Size(200, 98);
            this.dpn_containt.Size = new System.Drawing.Size(748, 98);
            this.dpn_containt.Text = "Nội Dung";
            // 
            // dpn_status
            // 
            this.dpn_status.Controls.Add(this.LK_MaKhoa);
            this.dpn_status.Controls.Add(this.labelControl3);
            this.dpn_status.Controls.Add(this.txt_MaLop);
            this.dpn_status.Controls.Add(this.labelControl2);
            this.dpn_status.Controls.Add(this.txt_TenLop);
            this.dpn_status.Controls.Add(this.labelControl1);
            this.dpn_status.Location = new System.Drawing.Point(4, 25);
            this.dpn_status.Name = "dpn_status";
            this.dpn_status.Size = new System.Drawing.Size(740, 69);
            this.dpn_status.TabIndex = 0;
            // 
            // LK_MaKhoa
            // 
            this.LK_MaKhoa.EditValue = "s";
            this.LK_MaKhoa.Location = new System.Drawing.Point(465, 14);
            this.LK_MaKhoa.Name = "LK_MaKhoa";
            this.LK_MaKhoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LK_MaKhoa.Properties.NullText = "Chọn Khoa";
            this.LK_MaKhoa.Properties.View = this.gridLookUpEdit1View;
            this.LK_MaKhoa.Size = new System.Drawing.Size(251, 20);
            this.LK_MaKhoa.TabIndex = 3;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(394, 17);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Mã Khoa :";
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Location = new System.Drawing.Point(93, 40);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(251, 20);
            this.txt_MaLop.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã Lớp :";
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Location = new System.Drawing.Point(93, 14);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(251, 20);
            this.txt_TenLop.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tên Lớp :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grd_Lop);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 98);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(748, 333);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Danh Sách";
            // 
            // grd_Lop
            // 
            this.grd_Lop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Lop.Location = new System.Drawing.Point(2, 21);
            this.grd_Lop.MainView = this.gridView1;
            this.grd_Lop.Name = "grd_Lop";
            this.grd_Lop.Size = new System.Drawing.Size(744, 310);
            this.grd_Lop.TabIndex = 6;
            this.grd_Lop.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_TenLop,
            this.col_MaLop,
            this.col_MaKhoa});
            this.gridView1.GridControl = this.grd_Lop;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // col_TenLop
            // 
            this.col_TenLop.Caption = "Tên Lớp";
            this.col_TenLop.FieldName = "tenlop";
            this.col_TenLop.MaxWidth = 300;
            this.col_TenLop.Name = "col_TenLop";
            this.col_TenLop.OptionsColumn.AllowEdit = false;
            this.col_TenLop.OptionsColumn.AllowFocus = false;
            this.col_TenLop.Visible = true;
            this.col_TenLop.VisibleIndex = 1;
            // 
            // col_MaLop
            // 
            this.col_MaLop.Caption = "Mã Lớp";
            this.col_MaLop.FieldName = "malop";
            this.col_MaLop.MaxWidth = 80;
            this.col_MaLop.Name = "col_MaLop";
            this.col_MaLop.OptionsColumn.AllowEdit = false;
            this.col_MaLop.OptionsColumn.AllowFocus = false;
            this.col_MaLop.Visible = true;
            this.col_MaLop.VisibleIndex = 0;
            // 
            // col_MaKhoa
            // 
            this.col_MaKhoa.Caption = "Khoa";
            this.col_MaKhoa.FieldName = "makhoa";
            this.col_MaKhoa.Name = "col_MaKhoa";
            this.col_MaKhoa.OptionsColumn.AllowEdit = false;
            this.col_MaKhoa.OptionsColumn.AllowFocus = false;
            this.col_MaKhoa.Visible = true;
            this.col_MaKhoa.VisibleIndex = 2;
            // 
            // frm_Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 431);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dpn_containt);
            this.Name = "frm_Lop";
            this.Text = "Quản lý lớp";
            this.Load += new System.EventHandler(this.frm_Lop_Load);
            this.Controls.SetChildIndex(this.dpn_containt, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dpn_containt.ResumeLayout(false);
            this.dpn_status.ResumeLayout(false);
            this.dpn_status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LK_MaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dpn_containt;
        private DevExpress.XtraBars.Docking.ControlContainer dpn_status;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grd_Lop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_TenLop;
        private DevExpress.XtraGrid.Columns.GridColumn col_MaLop;
        private DevExpress.XtraGrid.Columns.GridColumn col_MaKhoa;
        private DevExpress.XtraEditors.TextEdit txt_TenLop;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_MaLop;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit LK_MaKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
    }
}