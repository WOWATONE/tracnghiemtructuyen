namespace TNTT.FormView
{
    partial class frm_DSMH
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
            this.dcpNoiDung = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dat_ngayhoc = new DevExpress.XtraEditors.DateEdit();
            this.lk_giangvien = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lk_lophoc = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lk_monhoc = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grd_DanhSachMonHoc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idddsmh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.malop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mamonhoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tengiangvien = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dcpNoiDung.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_ngayhoc.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dat_ngayhoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_giangvien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_lophoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_monhoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_DanhSachMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dcpNoiDung});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dcpNoiDung
            // 
            this.dcpNoiDung.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.dcpNoiDung.Appearance.Options.UseBackColor = true;
            this.dcpNoiDung.Controls.Add(this.dockPanel1_Container);
            this.dcpNoiDung.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.dcpNoiDung.ID = new System.Guid("cfe0d7ed-a69f-4230-82fb-c4cfb8bb30be");
            this.dcpNoiDung.Location = new System.Drawing.Point(0, 65);
            this.dcpNoiDung.Name = "dcpNoiDung";
            this.dcpNoiDung.Options.ShowCloseButton = false;
            this.dcpNoiDung.OriginalSize = new System.Drawing.Size(200, 99);
            this.dcpNoiDung.Size = new System.Drawing.Size(711, 99);
            this.dcpNoiDung.Text = "Nội dung :";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.dat_ngayhoc);
            this.dockPanel1_Container.Controls.Add(this.lk_giangvien);
            this.dockPanel1_Container.Controls.Add(this.lk_lophoc);
            this.dockPanel1_Container.Controls.Add(this.lk_monhoc);
            this.dockPanel1_Container.Controls.Add(this.labelControl5);
            this.dockPanel1_Container.Controls.Add(this.labelControl4);
            this.dockPanel1_Container.Controls.Add(this.labelControl3);
            this.dockPanel1_Container.Controls.Add(this.labelControl2);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(703, 72);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // dat_ngayhoc
            // 
            this.dat_ngayhoc.EditValue = null;
            this.dat_ngayhoc.Location = new System.Drawing.Point(84, 41);
            this.dat_ngayhoc.Name = "dat_ngayhoc";
            this.dat_ngayhoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dat_ngayhoc.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dat_ngayhoc.Size = new System.Drawing.Size(252, 20);
            this.dat_ngayhoc.TabIndex = 8;
            // 
            // lk_giangvien
            // 
            this.lk_giangvien.Enabled = false;
            this.lk_giangvien.Location = new System.Drawing.Point(443, 41);
            this.lk_giangvien.Name = "lk_giangvien";
            this.lk_giangvien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lk_giangvien.Properties.NullText = "Chọn giảng viên";
            this.lk_giangvien.Properties.View = this.gridView2;
            this.lk_giangvien.Size = new System.Drawing.Size(252, 20);
            this.lk_giangvien.TabIndex = 7;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // lk_lophoc
            // 
            this.lk_lophoc.Location = new System.Drawing.Point(84, 15);
            this.lk_lophoc.Name = "lk_lophoc";
            this.lk_lophoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lk_lophoc.Properties.NullText = "Chọn lớp học";
            this.lk_lophoc.Properties.View = this.gridLookUpEdit2View;
            this.lk_lophoc.Size = new System.Drawing.Size(252, 20);
            this.lk_lophoc.TabIndex = 7;
            this.lk_lophoc.EditValueChanged += new System.EventHandler(this.lk_lophoc_EditValueChanged);
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // lk_monhoc
            // 
            this.lk_monhoc.Enabled = false;
            this.lk_monhoc.Location = new System.Drawing.Point(443, 15);
            this.lk_monhoc.Name = "lk_monhoc";
            this.lk_monhoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lk_monhoc.Properties.NullText = "Chọn môn học";
            this.lk_monhoc.Properties.View = this.gridLookUpEdit1View;
            this.lk_monhoc.Size = new System.Drawing.Size(252, 20);
            this.lk_monhoc.TabIndex = 6;
            this.lk_monhoc.EditValueChanged += new System.EventHandler(this.lk_monhoc_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(7, 44);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 13);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Ngày Học :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(371, 44);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Giảng Viên :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(371, 18);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Môn Học :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 18);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Lớp Học :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grd_DanhSachMonHoc);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 164);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(711, 182);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Danh sách môn học";
            // 
            // grd_DanhSachMonHoc
            // 
            this.grd_DanhSachMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_DanhSachMonHoc.Location = new System.Drawing.Point(2, 21);
            this.grd_DanhSachMonHoc.MainView = this.gridView1;
            this.grd_DanhSachMonHoc.Name = "grd_DanhSachMonHoc";
            this.grd_DanhSachMonHoc.Size = new System.Drawing.Size(707, 159);
            this.grd_DanhSachMonHoc.TabIndex = 0;
            this.grd_DanhSachMonHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idddsmh,
            this.malop,
            this.mamonhoc,
            this.tengiangvien});
            this.gridView1.GridControl = this.grd_DanhSachMonHoc;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // idddsmh
            // 
            this.idddsmh.Caption = "ID DSMH";
            this.idddsmh.FieldName = "idddsmh";
            this.idddsmh.Name = "idddsmh";
            this.idddsmh.OptionsColumn.AllowEdit = false;
            this.idddsmh.OptionsColumn.AllowFocus = false;
            this.idddsmh.Visible = true;
            this.idddsmh.VisibleIndex = 0;
            // 
            // malop
            // 
            this.malop.Caption = "Mã Lớp";
            this.malop.FieldName = "malop";
            this.malop.Name = "malop";
            this.malop.OptionsColumn.AllowEdit = false;
            this.malop.OptionsColumn.AllowFocus = false;
            this.malop.Visible = true;
            this.malop.VisibleIndex = 1;
            // 
            // mamonhoc
            // 
            this.mamonhoc.Caption = "Mã Môn Học";
            this.mamonhoc.FieldName = "mamonhoc";
            this.mamonhoc.Name = "mamonhoc";
            this.mamonhoc.OptionsColumn.AllowEdit = false;
            this.mamonhoc.OptionsColumn.AllowFocus = false;
            this.mamonhoc.Visible = true;
            this.mamonhoc.VisibleIndex = 2;
            // 
            // tengiangvien
            // 
            this.tengiangvien.Caption = "Tên Giảng Viên";
            this.tengiangvien.FieldName = "tengiangvien";
            this.tengiangvien.Name = "tengiangvien";
            this.tengiangvien.OptionsColumn.AllowEdit = false;
            this.tengiangvien.OptionsColumn.AllowFocus = false;
            this.tengiangvien.Visible = true;
            this.tengiangvien.VisibleIndex = 3;
            // 
            // frm_DSMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 346);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dcpNoiDung);
            this.Name = "frm_DSMH";
            this.Text = "Danh mục môn học";
            this.Load += new System.EventHandler(this.frm_DSMH_Load);
            this.Controls.SetChildIndex(this.dcpNoiDung, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dcpNoiDung.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dat_ngayhoc.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dat_ngayhoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_giangvien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_lophoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_monhoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_DanhSachMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dcpNoiDung;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grd_DanhSachMonHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dat_ngayhoc;
        private DevExpress.XtraEditors.GridLookUpEdit lk_giangvien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GridLookUpEdit lk_lophoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.GridLookUpEdit lk_monhoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn idddsmh;
        private DevExpress.XtraGrid.Columns.GridColumn malop;
        private DevExpress.XtraGrid.Columns.GridColumn mamonhoc;
        private DevExpress.XtraGrid.Columns.GridColumn tengiangvien;
    }
}