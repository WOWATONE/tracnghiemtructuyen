namespace TNTT.FormView
{
    partial class frm_GiangVien
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
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager();
            this.dock_NhapLieu = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.cmd_eyes = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_changevt = new DevExpress.XtraEditors.SimpleButton();
            this.lk_bomon = new DevExpress.XtraEditors.LookUpEdit();
            this.lk_chucvu = new DevExpress.XtraEditors.LookUpEdit();
            this.pic_avt = new System.Windows.Forms.PictureBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_matkhau = new DevExpress.XtraEditors.TextEdit();
            this.txt_magiangvien = new DevExpress.XtraEditors.TextEdit();
            this.txt_email = new DevExpress.XtraEditors.TextEdit();
            this.txt_dienthoai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_diachi = new DevExpress.XtraEditors.TextEdit();
            this.txt_tengiangvien = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grd_gv = new DevExpress.XtraGrid.GridControl();
            this.grd_Giangvien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_magiangvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_tengiangvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_diachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_dienthoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_bomon = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dock_NhapLieu.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lk_bomon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_chucvu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_matkhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_magiangvien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dienthoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diachi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tengiangvien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_gv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Giangvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dock_NhapLieu});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dock_NhapLieu
            // 
            this.dock_NhapLieu.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dock_NhapLieu.Appearance.Options.UseBackColor = true;
            this.dock_NhapLieu.Controls.Add(this.dockPanel1_Container);
            this.dock_NhapLieu.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.dock_NhapLieu.ID = new System.Guid("2149a136-451e-47f9-b05f-8c516f9cbeeb");
            this.dock_NhapLieu.Location = new System.Drawing.Point(0, 63);
            this.dock_NhapLieu.Name = "dock_NhapLieu";
            this.dock_NhapLieu.Options.ShowCloseButton = false;
            this.dock_NhapLieu.OriginalSize = new System.Drawing.Size(200, 144);
            this.dock_NhapLieu.Size = new System.Drawing.Size(898, 144);
            this.dock_NhapLieu.Text = "Nhập liệu";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.cmd_eyes);
            this.dockPanel1_Container.Controls.Add(this.cmd_changevt);
            this.dockPanel1_Container.Controls.Add(this.lk_bomon);
            this.dockPanel1_Container.Controls.Add(this.lk_chucvu);
            this.dockPanel1_Container.Controls.Add(this.pic_avt);
            this.dockPanel1_Container.Controls.Add(this.labelControl8);
            this.dockPanel1_Container.Controls.Add(this.labelControl2);
            this.dockPanel1_Container.Controls.Add(this.txt_matkhau);
            this.dockPanel1_Container.Controls.Add(this.txt_magiangvien);
            this.dockPanel1_Container.Controls.Add(this.txt_email);
            this.dockPanel1_Container.Controls.Add(this.txt_dienthoai);
            this.dockPanel1_Container.Controls.Add(this.labelControl5);
            this.dockPanel1_Container.Controls.Add(this.labelControl6);
            this.dockPanel1_Container.Controls.Add(this.labelControl7);
            this.dockPanel1_Container.Controls.Add(this.labelControl4);
            this.dockPanel1_Container.Controls.Add(this.labelControl3);
            this.dockPanel1_Container.Controls.Add(this.labelControl1);
            this.dockPanel1_Container.Controls.Add(this.txt_diachi);
            this.dockPanel1_Container.Controls.Add(this.txt_tengiangvien);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(890, 115);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // cmd_eyes
            // 
            this.cmd_eyes.Image = global::TNTT.Properties.Resources.eyes;
            this.cmd_eyes.Location = new System.Drawing.Point(431, 30);
            this.cmd_eyes.Name = "cmd_eyes";
            this.cmd_eyes.Size = new System.Drawing.Size(30, 19);
            this.cmd_eyes.TabIndex = 20;
            this.cmd_eyes.Click += new System.EventHandler(this.cmd_eyes_Click);
            this.cmd_eyes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmd_eyes_MouseDown);
            this.cmd_eyes.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cmd_eyes_MouseUp);
            // 
            // cmd_changevt
            // 
            this.cmd_changevt.Location = new System.Drawing.Point(87, 94);
            this.cmd_changevt.Name = "cmd_changevt";
            this.cmd_changevt.Size = new System.Drawing.Size(45, 23);
            this.cmd_changevt.TabIndex = 8;
            this.cmd_changevt.Text = "Đổi";
            this.cmd_changevt.Click += new System.EventHandler(this.cmd_changevt_Click);
            // 
            // lk_bomon
            // 
            this.lk_bomon.Location = new System.Drawing.Point(552, 57);
            this.lk_bomon.Name = "lk_bomon";
            this.lk_bomon.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit;
            this.lk_bomon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lk_bomon.Properties.NullText = "Chọn bộ môn";
            this.lk_bomon.Properties.PopupFormMinSize = new System.Drawing.Size(600, 0);
            this.lk_bomon.Size = new System.Drawing.Size(222, 20);
            this.lk_bomon.TabIndex = 6;
            // 
            // lk_chucvu
            // 
            this.lk_chucvu.Location = new System.Drawing.Point(552, 82);
            this.lk_chucvu.Name = "lk_chucvu";
            this.lk_chucvu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lk_chucvu.Properties.NullText = "Chọn chức vụ";
            this.lk_chucvu.Size = new System.Drawing.Size(222, 20);
            this.lk_chucvu.TabIndex = 7;
            // 
            // pic_avt
            // 
            this.pic_avt.Location = new System.Drawing.Point(0, 0);
            this.pic_avt.Name = "pic_avt";
            this.pic_avt.Size = new System.Drawing.Size(100, 117);
            this.pic_avt.TabIndex = 18;
            this.pic_avt.TabStop = false;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(493, 85);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(44, 13);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Chức vụ:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(164, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Mật khẩu";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(239, 29);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.Properties.Appearance.Options.UseFont = true;
            this.txt_matkhau.Properties.MaxLength = 20;
            this.txt_matkhau.Properties.UseSystemPasswordChar = true;
            this.txt_matkhau.Size = new System.Drawing.Size(222, 22);
            this.txt_matkhau.TabIndex = 1;
            this.txt_matkhau.TextChanged += new System.EventHandler(this.txt_matkhau_TextChanged);
            // 
            // txt_magiangvien
            // 
            this.txt_magiangvien.Location = new System.Drawing.Point(239, 4);
            this.txt_magiangvien.Name = "txt_magiangvien";
            this.txt_magiangvien.Properties.MaxLength = 10;
            this.txt_magiangvien.Properties.NullText = "Nhập mã giảng viên";
            this.txt_magiangvien.Properties.NullValuePrompt = "Mã giảng viên";
            this.txt_magiangvien.Size = new System.Drawing.Size(222, 20);
            this.txt_magiangvien.TabIndex = 0;
            // 
            // txt_email
            // 
            this.txt_email.EditValue = "";
            this.txt_email.Location = new System.Drawing.Point(552, 33);
            this.txt_email.Name = "txt_email";
            this.txt_email.Properties.MaxLength = 50;
            this.txt_email.Size = new System.Drawing.Size(222, 20);
            this.txt_email.TabIndex = 10;
            // 
            // txt_dienthoai
            // 
            this.txt_dienthoai.EditValue = "";
            this.txt_dienthoai.Location = new System.Drawing.Point(552, 7);
            this.txt_dienthoai.Name = "txt_dienthoai";
            this.txt_dienthoai.Properties.MaxLength = 11;
            this.txt_dienthoai.Size = new System.Drawing.Size(222, 20);
            this.txt_dienthoai.TabIndex = 9;
            this.txt_dienthoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_dienthoai_KeyPress);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(493, 62);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(39, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Bộ môn:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(496, 38);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 13);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "Email:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(493, 14);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Điện thoại:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(164, 78);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Địa chỉ:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(162, 56);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tên giảng viên:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(163, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã giảng viên:";
            // 
            // txt_diachi
            // 
            this.txt_diachi.EditValue = "";
            this.txt_diachi.Location = new System.Drawing.Point(239, 78);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Properties.MaxLength = 100;
            this.txt_diachi.Size = new System.Drawing.Size(222, 20);
            this.txt_diachi.TabIndex = 1;
            // 
            // txt_tengiangvien
            // 
            this.txt_tengiangvien.Location = new System.Drawing.Point(239, 52);
            this.txt_tengiangvien.Name = "txt_tengiangvien";
            this.txt_tengiangvien.Properties.MaxLength = 80;
            this.txt_tengiangvien.Size = new System.Drawing.Size(222, 20);
            this.txt_tengiangvien.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grd_gv);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 207);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(898, 234);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Danh Sách";
            // 
            // grd_gv
            // 
            this.grd_gv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_gv.Location = new System.Drawing.Point(2, 21);
            this.grd_gv.MainView = this.grd_Giangvien;
            this.grd_gv.Name = "grd_gv";
            this.grd_gv.Size = new System.Drawing.Size(894, 211);
            this.grd_gv.TabIndex = 0;
            this.grd_gv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grd_Giangvien});
            // 
            // grd_Giangvien
            // 
            this.grd_Giangvien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.col_magiangvien,
            this.col_tengiangvien,
            this.col_diachi,
            this.col_dienthoai,
            this.col_email,
            this.col_bomon});
            this.grd_Giangvien.GridControl = this.grd_gv;
            this.grd_Giangvien.Name = "grd_Giangvien";
            this.grd_Giangvien.OptionsBehavior.Editable = false;
            this.grd_Giangvien.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag;
            this.grd_Giangvien.OptionsView.ShowAutoFilterRow = true;
            this.grd_Giangvien.OptionsView.ShowGroupPanel = false;
            this.grd_Giangvien.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grd_Giangvien_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "STT";
            this.gridColumn1.FieldName = "gridColumn1";
            this.gridColumn1.MaxWidth = 40;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 40;
            // 
            // col_magiangvien
            // 
            this.col_magiangvien.Caption = "Mã giảng viên";
            this.col_magiangvien.FieldName = "magiangvien";
            this.col_magiangvien.Name = "col_magiangvien";
            this.col_magiangvien.OptionsColumn.AllowEdit = false;
            this.col_magiangvien.OptionsColumn.AllowFocus = false;
            this.col_magiangvien.Visible = true;
            this.col_magiangvien.VisibleIndex = 1;
            // 
            // col_tengiangvien
            // 
            this.col_tengiangvien.Caption = "Họ và tên";
            this.col_tengiangvien.FieldName = "tengiangvien";
            this.col_tengiangvien.Name = "col_tengiangvien";
            this.col_tengiangvien.OptionsColumn.AllowEdit = false;
            this.col_tengiangvien.OptionsColumn.AllowFocus = false;
            this.col_tengiangvien.Visible = true;
            this.col_tengiangvien.VisibleIndex = 2;
            // 
            // col_diachi
            // 
            this.col_diachi.Caption = "Địa chỉ";
            this.col_diachi.FieldName = "diachi_giangvien";
            this.col_diachi.Name = "col_diachi";
            this.col_diachi.OptionsColumn.AllowEdit = false;
            this.col_diachi.OptionsColumn.AllowFocus = false;
            this.col_diachi.Visible = true;
            this.col_diachi.VisibleIndex = 3;
            // 
            // col_dienthoai
            // 
            this.col_dienthoai.Caption = "Điện thoại liên hệ";
            this.col_dienthoai.FieldName = "dienthoai_giangvien";
            this.col_dienthoai.Name = "col_dienthoai";
            this.col_dienthoai.OptionsColumn.AllowEdit = false;
            this.col_dienthoai.OptionsColumn.AllowFocus = false;
            this.col_dienthoai.Visible = true;
            this.col_dienthoai.VisibleIndex = 4;
            // 
            // col_email
            // 
            this.col_email.Caption = "Email";
            this.col_email.FieldName = "email_giangvien";
            this.col_email.Name = "col_email";
            this.col_email.OptionsColumn.AllowEdit = false;
            this.col_email.OptionsColumn.AllowFocus = false;
            this.col_email.Visible = true;
            this.col_email.VisibleIndex = 5;
            // 
            // col_bomon
            // 
            this.col_bomon.Caption = "Bộ môn";
            this.col_bomon.FieldName = "tenbomon";
            this.col_bomon.Name = "col_bomon";
            this.col_bomon.OptionsColumn.AllowEdit = false;
            this.col_bomon.OptionsColumn.AllowFocus = false;
            this.col_bomon.Visible = true;
            this.col_bomon.VisibleIndex = 6;
            // 
            // frm_GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 441);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dock_NhapLieu);
            this.Name = "frm_GiangVien";
            this.Text = "Quản lý Giảng viên";
            this.Load += new System.EventHandler(this.frm_GiangVien_Load);
            this.Controls.SetChildIndex(this.dock_NhapLieu, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dock_NhapLieu.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lk_bomon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_chucvu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_matkhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_magiangvien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dienthoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_diachi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tengiangvien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_gv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Giangvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grd_gv;
        private DevExpress.XtraGrid.Views.Grid.GridView grd_Giangvien;
        private DevExpress.XtraGrid.Columns.GridColumn col_magiangvien;
        private DevExpress.XtraGrid.Columns.GridColumn col_tengiangvien;
        private DevExpress.XtraGrid.Columns.GridColumn col_diachi;
        private DevExpress.XtraGrid.Columns.GridColumn col_dienthoai;
        private DevExpress.XtraGrid.Columns.GridColumn col_email;
        private DevExpress.XtraGrid.Columns.GridColumn col_bomon;
        private DevExpress.XtraBars.Docking.DockPanel dock_NhapLieu;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.SimpleButton cmd_changevt;
        private System.Windows.Forms.PictureBox pic_avt;
        private DevExpress.XtraEditors.LookUpEdit lk_bomon;
        private DevExpress.XtraEditors.LookUpEdit lk_chucvu;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_magiangvien;
        private DevExpress.XtraEditors.TextEdit txt_email;
        private DevExpress.XtraEditors.TextEdit txt_dienthoai;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_diachi;
        private DevExpress.XtraEditors.TextEdit txt_tengiangvien;
        private DevExpress.XtraEditors.SimpleButton cmd_eyes;
        internal DevExpress.XtraEditors.TextEdit txt_matkhau;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}