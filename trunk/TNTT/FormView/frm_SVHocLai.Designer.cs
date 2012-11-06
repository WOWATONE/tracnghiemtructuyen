namespace TNTT.FormView
{
    partial class frm_SVHocLai
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grd_SinhVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.cbo_sinhvien = new System.Windows.Forms.ComboBox();
            this.cbo_monhoc = new System.Windows.Forms.ComboBox();
            this.cbo_Lop = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_SinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grd_SinhVien);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 178);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(705, 181);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Sinh viên";
            // 
            // grd_SinhVien
            // 
            this.grd_SinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_SinhVien.Location = new System.Drawing.Point(2, 21);
            this.grd_SinhVien.MainView = this.gridView1;
            this.grd_SinhVien.Name = "grd_SinhVien";
            this.grd_SinhVien.Size = new System.Drawing.Size(701, 158);
            this.grd_SinhVien.TabIndex = 0;
            this.grd_SinhVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.grd_SinhVien;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã sinh viên";
            this.gridColumn1.FieldName = "sinhvien_masinhvien";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Môn học";
            this.gridColumn2.FieldName = "monhoc_idmonhoc";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Lớp";
            this.gridColumn3.FieldName = "malop";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dockPanel1.Appearance.Options.UseBackColor = true;
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.dockPanel1.ID = new System.Guid("9bb71881-c62f-4dc0-b34e-d44374c6ca6a");
            this.dockPanel1.Location = new System.Drawing.Point(0, 65);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Options.ShowCloseButton = false;
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 113);
            this.dockPanel1.Size = new System.Drawing.Size(705, 113);
            this.dockPanel1.Text = "Nội dung";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.cbo_sinhvien);
            this.dockPanel1_Container.Controls.Add(this.cbo_monhoc);
            this.dockPanel1_Container.Controls.Add(this.cbo_Lop);
            this.dockPanel1_Container.Controls.Add(this.labelControl3);
            this.dockPanel1_Container.Controls.Add(this.labelControl2);
            this.dockPanel1_Container.Controls.Add(this.labelControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(697, 86);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // cbo_sinhvien
            // 
            this.cbo_sinhvien.Enabled = false;
            this.cbo_sinhvien.FormattingEnabled = true;
            this.cbo_sinhvien.Location = new System.Drawing.Point(413, 20);
            this.cbo_sinhvien.Name = "cbo_sinhvien";
            this.cbo_sinhvien.Size = new System.Drawing.Size(172, 21);
            this.cbo_sinhvien.TabIndex = 1;
            // 
            // cbo_monhoc
            // 
            this.cbo_monhoc.Enabled = false;
            this.cbo_monhoc.FormattingEnabled = true;
            this.cbo_monhoc.Location = new System.Drawing.Point(91, 51);
            this.cbo_monhoc.Name = "cbo_monhoc";
            this.cbo_monhoc.Size = new System.Drawing.Size(172, 21);
            this.cbo_monhoc.TabIndex = 1;
            // 
            // cbo_Lop
            // 
            this.cbo_Lop.FormattingEnabled = true;
            this.cbo_Lop.Location = new System.Drawing.Point(91, 20);
            this.cbo_Lop.Name = "cbo_Lop";
            this.cbo_Lop.Size = new System.Drawing.Size(172, 21);
            this.cbo_Lop.TabIndex = 1;
            this.cbo_Lop.SelectedIndexChanged += new System.EventHandler(this.cbo_Lop_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(22, 54);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Môn học :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(326, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Mã sinh viên :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Lớp :";
            // 
            // frm_SVHocLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 359);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dockPanel1);
            this.Name = "frm_SVHocLai";
            this.Text = "Danh sách sinh viên học lại";
            this.Load += new System.EventHandler(this.frm_SVHocLai_Load);
            this.Controls.SetChildIndex(this.dockPanel1, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_SinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grd_SinhVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private System.Windows.Forms.ComboBox cbo_sinhvien;
        private System.Windows.Forms.ComboBox cbo_monhoc;
        private System.Windows.Forms.ComboBox cbo_Lop;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}