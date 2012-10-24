namespace TNTT.FormView
{
    partial class frm_MonHoc
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
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lk_BoMon = new DevExpress.XtraEditors.LookUpEdit();
            this.txt_GhiChu = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.txt_MaMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grd_Monhoc = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dpn_content.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lk_BoMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Monhoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dpn_content});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dpn_content
            // 
            this.dpn_content.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dpn_content.Appearance.Options.UseBackColor = true;
            this.dpn_content.Controls.Add(this.dockPanel1_Container);
            this.dpn_content.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.dpn_content.ID = new System.Guid("ce957706-760e-4fd9-8b48-7825674ce838");
            this.dpn_content.Location = new System.Drawing.Point(0, 59);
            this.dpn_content.Name = "dpn_content";
            this.dpn_content.OriginalSize = new System.Drawing.Size(200, 96);
            this.dpn_content.Size = new System.Drawing.Size(764, 96);
            this.dpn_content.Text = "Nội dung";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.labelControl3);
            this.dockPanel1_Container.Controls.Add(this.labelControl4);
            this.dockPanel1_Container.Controls.Add(this.labelControl2);
            this.dockPanel1_Container.Controls.Add(this.labelControl1);
            this.dockPanel1_Container.Controls.Add(this.lk_BoMon);
            this.dockPanel1_Container.Controls.Add(this.txt_GhiChu);
            this.dockPanel1_Container.Controls.Add(this.txt_TenMonHoc);
            this.dockPanel1_Container.Controls.Add(this.txt_MaMonHoc);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 24);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(758, 69);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(305, 7);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Ghi chú:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(305, 38);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Bộ môn:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Tên môn học:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Mã môn học:";
            // 
            // lk_BoMon
            // 
            this.lk_BoMon.Location = new System.Drawing.Point(350, 35);
            this.lk_BoMon.Name = "lk_BoMon";
            this.lk_BoMon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lk_BoMon.Properties.NullText = "";
            this.lk_BoMon.Size = new System.Drawing.Size(263, 20);
            this.lk_BoMon.TabIndex = 3;
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(349, 3);
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(263, 20);
            this.txt_GhiChu.TabIndex = 2;
            // 
            // txt_TenMonHoc
            // 
            this.txt_TenMonHoc.Location = new System.Drawing.Point(86, 32);
            this.txt_TenMonHoc.Name = "txt_TenMonHoc";
            this.txt_TenMonHoc.Size = new System.Drawing.Size(202, 20);
            this.txt_TenMonHoc.TabIndex = 1;
            // 
            // txt_MaMonHoc
            // 
            this.txt_MaMonHoc.Location = new System.Drawing.Point(86, 3);
            this.txt_MaMonHoc.Name = "txt_MaMonHoc";
            this.txt_MaMonHoc.Size = new System.Drawing.Size(202, 20);
            this.txt_MaMonHoc.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grd_Monhoc);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 155);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(764, 274);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Danh sách";
            // 
            // grd_Monhoc
            // 
            this.grd_Monhoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Monhoc.Location = new System.Drawing.Point(2, 21);
            this.grd_Monhoc.MainView = this.gridView1;
            this.grd_Monhoc.Name = "grd_Monhoc";
            this.grd_Monhoc.Size = new System.Drawing.Size(760, 251);
            this.grd_Monhoc.TabIndex = 0;
            this.grd_Monhoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.Col_GhiChu,
            this.gridColumn4});
            this.gridView1.GridControl = this.grd_Monhoc;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã môn học";
            this.gridColumn1.FieldName = "mamonhoc";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên môn học";
            this.gridColumn2.FieldName = "tenmonhoc";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // Col_GhiChu
            // 
            this.Col_GhiChu.Caption = "Ghi chú";
            this.Col_GhiChu.FieldName = "ghichu_monhoc";
            this.Col_GhiChu.Name = "Col_GhiChu";
            this.Col_GhiChu.Visible = true;
            this.Col_GhiChu.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Tên khoa";
            this.gridColumn4.FieldName = "tenbomon";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // frm_MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 429);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dpn_content);
            this.Name = "frm_MonHoc";
            this.Text = "frm_MonHoc";
            this.Load += new System.EventHandler(this.frm_MonHoc_Load);
            this.Controls.SetChildIndex(this.dpn_content, 0);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dpn_content.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lk_BoMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Monhoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grd_Monhoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn Col_GhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraBars.Docking.DockPanel dpn_content;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lk_BoMon;
        private DevExpress.XtraEditors.TextEdit txt_GhiChu;
        private DevExpress.XtraEditors.TextEdit txt_TenMonHoc;
        private DevExpress.XtraEditors.TextEdit txt_MaMonHoc;
    }
}