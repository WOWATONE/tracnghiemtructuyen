namespace TNTT.FormView
{
    partial class frm_SinhVien
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
            this.dpn_content = new DevExpress.XtraBars.Docking.DockPanel();
            this.N = new DevExpress.XtraBars.Docking.ControlContainer();
            this.cmd_changeAvt = new DevExpress.XtraEditors.SimpleButton();
            this.pic_avt = new System.Windows.Forms.PictureBox();
            this.lk_lop = new DevExpress.XtraEditors.LookUpEdit();
            this.dateNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtTenSinhVien = new DevExpress.XtraEditors.TextEdit();
            this.txtDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSinhVien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dpnDanhSachLop = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.tlDanhSachLop = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grd_DanhSach = new DevExpress.XtraGrid.GridControl();
            this.gv_DanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.masinhvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tensinhvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngaysinh_sinhvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diachi_sinhvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dienthoai_sinhvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.email_sinhvien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.malop = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dpn_content.SuspendLayout();
            this.N.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_lop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSinhVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSinhVien.Properties)).BeginInit();
            this.dpnDanhSachLop.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlDanhSachLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_DanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dpn_content,
            this.dpnDanhSachLop});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dpn_content
            // 
            this.dpn_content.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.dpn_content.Appearance.Options.UseBackColor = true;
            this.dpn_content.Controls.Add(this.N);
            this.dpn_content.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.dpn_content.FloatVertical = true;
            this.dpn_content.ID = new System.Guid("a6cbc7ec-b0dd-40f8-a74d-4826ad24cc29");
            this.dpn_content.Location = new System.Drawing.Point(0, 63);
            this.dpn_content.Name = "dpn_content";
            this.dpn_content.Options.ShowCloseButton = false;
            this.dpn_content.OriginalSize = new System.Drawing.Size(200, 161);
            this.dpn_content.Size = new System.Drawing.Size(937, 161);
            this.dpn_content.Text = "Nội dung";
            // 
            // N
            // 
            this.N.Controls.Add(this.cmd_changeAvt);
            this.N.Controls.Add(this.pic_avt);
            this.N.Controls.Add(this.lk_lop);
            this.N.Controls.Add(this.dateNgaySinh);
            this.N.Controls.Add(this.txtEmail);
            this.N.Controls.Add(this.txtDiaChi);
            this.N.Controls.Add(this.txtTenSinhVien);
            this.N.Controls.Add(this.txtDienThoai);
            this.N.Controls.Add(this.txtMaSinhVien);
            this.N.Controls.Add(this.labelControl8);
            this.N.Controls.Add(this.labelControl4);
            this.N.Controls.Add(this.labelControl7);
            this.N.Controls.Add(this.labelControl2);
            this.N.Controls.Add(this.labelControl6);
            this.N.Controls.Add(this.labelControl3);
            this.N.Controls.Add(this.labelControl1);
            this.N.Location = new System.Drawing.Point(4, 25);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(929, 132);
            this.N.TabIndex = 0;
            // 
            // cmd_changeAvt
            // 
            this.cmd_changeAvt.Location = new System.Drawing.Point(91, 105);
            this.cmd_changeAvt.Name = "cmd_changeAvt";
            this.cmd_changeAvt.Size = new System.Drawing.Size(43, 23);
            this.cmd_changeAvt.TabIndex = 5;
            this.cmd_changeAvt.Text = "Đổi";
            this.cmd_changeAvt.Click += new System.EventHandler(this.cmd_changeAvt_Click);
            // 
            // pic_avt
            // 
            this.pic_avt.Location = new System.Drawing.Point(9, 4);
            this.pic_avt.Name = "pic_avt";
            this.pic_avt.Size = new System.Drawing.Size(100, 125);
            this.pic_avt.TabIndex = 4;
            this.pic_avt.TabStop = false;
            // 
            // lk_lop
            // 
            this.lk_lop.Location = new System.Drawing.Point(547, 49);
            this.lk_lop.Name = "lk_lop";
            this.lk_lop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lk_lop.Properties.NullText = "Chọn lớp";
            this.lk_lop.Size = new System.Drawing.Size(222, 20);
            this.lk_lop.TabIndex = 3;
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.EditValue = null;
            this.dateNgaySinh.Location = new System.Drawing.Point(237, 49);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateNgaySinh.Size = new System.Drawing.Size(222, 20);
            this.dateNgaySinh.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(547, 77);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.MaxLength = 50;
            this.txtEmail.Size = new System.Drawing.Size(222, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(237, 109);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Properties.MaxLength = 200;
            this.txtDiaChi.Size = new System.Drawing.Size(532, 20);
            this.txtDiaChi.TabIndex = 1;
            // 
            // txtTenSinhVien
            // 
            this.txtTenSinhVien.Location = new System.Drawing.Point(547, 20);
            this.txtTenSinhVien.Name = "txtTenSinhVien";
            this.txtTenSinhVien.Properties.MaxLength = 50;
            this.txtTenSinhVien.Size = new System.Drawing.Size(222, 20);
            this.txtTenSinhVien.TabIndex = 1;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(237, 77);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Properties.MaxLength = 11;
            this.txtDienThoai.Size = new System.Drawing.Size(222, 20);
            this.txtDienThoai.TabIndex = 1;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Location = new System.Drawing.Point(237, 20);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.Properties.MaxLength = 10;
            this.txtMaSinhVien.Size = new System.Drawing.Size(222, 20);
            this.txtMaSinhVien.TabIndex = 1;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(475, 80);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(31, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Email :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(475, 23);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Tên sinh viên :";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(478, 52);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(24, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Lớp :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(165, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Địa chỉ :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(165, 80);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(56, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Điện thoại :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(165, 23);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Mã sinh viên :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(165, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ngày sinh :";
            // 
            // dpnDanhSachLop
            // 
            this.dpnDanhSachLop.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(241)))), ((int)(((byte)(254)))));
            this.dpnDanhSachLop.Appearance.Options.UseBackColor = true;
            this.dpnDanhSachLop.Controls.Add(this.dockPanel1_Container);
            this.dpnDanhSachLop.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dpnDanhSachLop.ID = new System.Guid("5599b643-8200-4604-a0f2-ce7c02516462");
            this.dpnDanhSachLop.Location = new System.Drawing.Point(0, 224);
            this.dpnDanhSachLop.Name = "dpnDanhSachLop";
            this.dpnDanhSachLop.Options.ShowCloseButton = false;
            this.dpnDanhSachLop.OriginalSize = new System.Drawing.Size(200, 200);
            this.dpnDanhSachLop.Size = new System.Drawing.Size(200, 231);
            this.dpnDanhSachLop.Text = "Danh sách lớp";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.tlDanhSachLop);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(192, 202);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // tlDanhSachLop
            // 
            this.tlDanhSachLop.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.tlDanhSachLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlDanhSachLop.Location = new System.Drawing.Point(0, 0);
            this.tlDanhSachLop.Name = "tlDanhSachLop";
            this.tlDanhSachLop.OptionsView.ShowColumns = false;
            this.tlDanhSachLop.OptionsView.ShowHorzLines = false;
            this.tlDanhSachLop.OptionsView.ShowIndicator = false;
            this.tlDanhSachLop.OptionsView.ShowVertLines = false;
            this.tlDanhSachLop.Size = new System.Drawing.Size(192, 202);
            this.tlDanhSachLop.TabIndex = 0;
            this.tlDanhSachLop.AfterFocusNode += new DevExpress.XtraTreeList.NodeEventHandler(this.tlDanhSachLop_AfterFocusNode);
            this.tlDanhSachLop.NodeChanged += new DevExpress.XtraTreeList.NodeChangedEventHandler(this.tlDanhSachLop_NodeChanged);
            this.tlDanhSachLop.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tlDanhSachLop_FocusedNodeChanged);
            this.tlDanhSachLop.SelectionChanged += new System.EventHandler(this.tlDanhSachLop_SelectionChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Tên";
            this.treeListColumn1.FieldName = "ten";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.OptionsColumn.AllowEdit = false;
            this.treeListColumn1.OptionsColumn.AllowFocus = false;
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 142;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Id";
            this.treeListColumn2.FieldName = "id";
            this.treeListColumn2.MinWidth = 16;
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.OptionsColumn.AllowEdit = false;
            this.treeListColumn2.OptionsColumn.AllowFocus = false;
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 16;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grd_DanhSach);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(200, 224);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(737, 231);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Danh sách";
            // 
            // grd_DanhSach
            // 
            this.grd_DanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_DanhSach.Location = new System.Drawing.Point(2, 21);
            this.grd_DanhSach.MainView = this.gv_DanhSach;
            this.grd_DanhSach.Name = "grd_DanhSach";
            this.grd_DanhSach.Size = new System.Drawing.Size(733, 208);
            this.grd_DanhSach.TabIndex = 0;
            this.grd_DanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DanhSach});
            // 
            // gv_DanhSach
            // 
            this.gv_DanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.masinhvien,
            this.tensinhvien,
            this.ngaysinh_sinhvien,
            this.diachi_sinhvien,
            this.dienthoai_sinhvien,
            this.email_sinhvien,
            this.malop});
            this.gv_DanhSach.GridControl = this.grd_DanhSach;
            this.gv_DanhSach.Name = "gv_DanhSach";
            this.gv_DanhSach.OptionsView.ShowGroupPanel = false;
            this.gv_DanhSach.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gv_DanhSach_RowClick);
            // 
            // masinhvien
            // 
            this.masinhvien.Caption = "Mã sinh viên";
            this.masinhvien.FieldName = "masinhvien";
            this.masinhvien.Name = "masinhvien";
            this.masinhvien.OptionsColumn.AllowEdit = false;
            this.masinhvien.OptionsColumn.AllowFocus = false;
            this.masinhvien.Visible = true;
            this.masinhvien.VisibleIndex = 0;
            // 
            // tensinhvien
            // 
            this.tensinhvien.Caption = "Tên sinh viên";
            this.tensinhvien.FieldName = "tensinhvien";
            this.tensinhvien.Name = "tensinhvien";
            this.tensinhvien.OptionsColumn.AllowEdit = false;
            this.tensinhvien.OptionsColumn.AllowFocus = false;
            this.tensinhvien.Visible = true;
            this.tensinhvien.VisibleIndex = 1;
            // 
            // ngaysinh_sinhvien
            // 
            this.ngaysinh_sinhvien.Caption = "Ngày sinh";
            this.ngaysinh_sinhvien.FieldName = "ngaysinh_sinhvien";
            this.ngaysinh_sinhvien.Name = "ngaysinh_sinhvien";
            this.ngaysinh_sinhvien.OptionsColumn.AllowEdit = false;
            this.ngaysinh_sinhvien.OptionsColumn.AllowFocus = false;
            this.ngaysinh_sinhvien.Visible = true;
            this.ngaysinh_sinhvien.VisibleIndex = 2;
            // 
            // diachi_sinhvien
            // 
            this.diachi_sinhvien.Caption = "Địa chị";
            this.diachi_sinhvien.FieldName = "diachi_sinhvien";
            this.diachi_sinhvien.Name = "diachi_sinhvien";
            this.diachi_sinhvien.OptionsColumn.AllowEdit = false;
            this.diachi_sinhvien.OptionsColumn.AllowFocus = false;
            this.diachi_sinhvien.Visible = true;
            this.diachi_sinhvien.VisibleIndex = 3;
            // 
            // dienthoai_sinhvien
            // 
            this.dienthoai_sinhvien.Caption = "Điện thoại";
            this.dienthoai_sinhvien.FieldName = "dienthoai_sinhvien";
            this.dienthoai_sinhvien.Name = "dienthoai_sinhvien";
            this.dienthoai_sinhvien.OptionsColumn.AllowEdit = false;
            this.dienthoai_sinhvien.OptionsColumn.AllowFocus = false;
            this.dienthoai_sinhvien.Visible = true;
            this.dienthoai_sinhvien.VisibleIndex = 4;
            // 
            // email_sinhvien
            // 
            this.email_sinhvien.Caption = "Email";
            this.email_sinhvien.FieldName = "email_sinhvien";
            this.email_sinhvien.Name = "email_sinhvien";
            this.email_sinhvien.OptionsColumn.AllowEdit = false;
            this.email_sinhvien.OptionsColumn.AllowFocus = false;
            this.email_sinhvien.Visible = true;
            this.email_sinhvien.VisibleIndex = 5;
            // 
            // malop
            // 
            this.malop.Caption = "Lớp";
            this.malop.FieldName = "malop";
            this.malop.Name = "malop";
            this.malop.OptionsColumn.AllowEdit = false;
            this.malop.OptionsColumn.AllowFocus = false;
            this.malop.Visible = true;
            this.malop.VisibleIndex = 6;
            // 
            // frm_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 455);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dpnDanhSachLop);
            this.Controls.Add(this.dpn_content);
            this.Name = "frm_SinhVien";
            this.Text = "Sinh viên";
            this.Load += new System.EventHandler(this.frm_SinhVien_Load);
            this.Controls.SetChildIndex(this.dpn_content, 0);
            this.Controls.SetChildIndex(this.dpnDanhSachLop, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dpn_content.ResumeLayout(false);
            this.N.ResumeLayout(false);
            this.N.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lk_lop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSinhVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSinhVien.Properties)).EndInit();
            this.dpnDanhSachLop.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlDanhSachLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_DanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dpn_content;
        private DevExpress.XtraBars.Docking.ControlContainer N;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.Docking.DockPanel dpnDanhSachLop;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraTreeList.TreeList tlDanhSachLop;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraEditors.TextEdit txtTenSinhVien;
        private DevExpress.XtraEditors.TextEdit txtMaSinhVien;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dateNgaySinh;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtDienThoai;
        private DevExpress.XtraGrid.GridControl grd_DanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_DanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn masinhvien;
        private DevExpress.XtraGrid.Columns.GridColumn tensinhvien;
        private DevExpress.XtraGrid.Columns.GridColumn ngaysinh_sinhvien;
        private DevExpress.XtraGrid.Columns.GridColumn diachi_sinhvien;
        private DevExpress.XtraGrid.Columns.GridColumn dienthoai_sinhvien;
        private DevExpress.XtraGrid.Columns.GridColumn email_sinhvien;
        private DevExpress.XtraGrid.Columns.GridColumn malop;
        private DevExpress.XtraEditors.LookUpEdit lk_lop;
        private DevExpress.XtraEditors.SimpleButton cmd_changeAvt;
        private System.Windows.Forms.PictureBox pic_avt;

    }
}