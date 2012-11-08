namespace TNTT.FormView
{
    partial class frm_BoMon
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lk_khoa = new DevExpress.XtraEditors.LookUpEdit();
            this.txt_GhiChu = new DevExpress.XtraEditors.TextEdit();
            this.txt_tenbomon = new DevExpress.XtraEditors.TextEdit();
            this.txt_mabomon = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grd_bomon = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Col_MaBM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_TenBm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_GhiChuBm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Col_Khoa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lk_khoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenbomon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mabomon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_bomon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.lk_khoa);
            this.groupControl1.Controls.Add(this.txt_GhiChu);
            this.groupControl1.Controls.Add(this.txt_tenbomon);
            this.groupControl1.Controls.Add(this.txt_mabomon);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 63);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(897, 100);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Nội dung";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Tên Bộ Môn";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(391, 32);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Ghi Chú:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(390, 62);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Khoa:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Mã Bộ Môn:";
            // 
            // lk_khoa
            // 
            this.lk_khoa.Location = new System.Drawing.Point(453, 57);
            this.lk_khoa.Name = "lk_khoa";
            this.lk_khoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lk_khoa.Size = new System.Drawing.Size(270, 20);
            this.lk_khoa.TabIndex = 3;
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(451, 25);
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(271, 20);
            this.txt_GhiChu.TabIndex = 2;
            // 
            // txt_tenbomon
            // 
            this.txt_tenbomon.Location = new System.Drawing.Point(92, 55);
            this.txt_tenbomon.Name = "txt_tenbomon";
            this.txt_tenbomon.Size = new System.Drawing.Size(252, 20);
            this.txt_tenbomon.TabIndex = 1;
            // 
            // txt_mabomon
            // 
            this.txt_mabomon.Location = new System.Drawing.Point(92, 25);
            this.txt_mabomon.Name = "txt_mabomon";
            this.txt_mabomon.Size = new System.Drawing.Size(252, 20);
            this.txt_mabomon.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.grd_bomon);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 163);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(897, 307);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Danh Sách";
            // 
            // grd_bomon
            // 
            this.grd_bomon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_bomon.Location = new System.Drawing.Point(2, 21);
            this.grd_bomon.MainView = this.gridView1;
            this.grd_bomon.Name = "grd_bomon";
            this.grd_bomon.Size = new System.Drawing.Size(893, 284);
            this.grd_bomon.TabIndex = 0;
            this.grd_bomon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Col_MaBM,
            this.Col_TenBm,
            this.Col_GhiChuBm,
            this.Col_Khoa});
            this.gridView1.GridControl = this.grd_bomon;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Col_MaBM
            // 
            this.Col_MaBM.Caption = "Mã Bộ Môn";
            this.Col_MaBM.FieldName = "mabomon";
            this.Col_MaBM.Name = "Col_MaBM";
            this.Col_MaBM.Visible = true;
            this.Col_MaBM.VisibleIndex = 0;
            this.Col_MaBM.Width = 119;
            // 
            // Col_TenBm
            // 
            this.Col_TenBm.Caption = "Tên Bộ Môn";
            this.Col_TenBm.FieldName = "tenbomon";
            this.Col_TenBm.Name = "Col_TenBm";
            this.Col_TenBm.Visible = true;
            this.Col_TenBm.VisibleIndex = 1;
            this.Col_TenBm.Width = 193;
            // 
            // Col_GhiChuBm
            // 
            this.Col_GhiChuBm.Caption = "Ghi Chú";
            this.Col_GhiChuBm.FieldName = "idkhoa";
            this.Col_GhiChuBm.Name = "Col_GhiChuBm";
            this.Col_GhiChuBm.Visible = true;
            this.Col_GhiChuBm.VisibleIndex = 3;
            this.Col_GhiChuBm.Width = 615;
            // 
            // Col_Khoa
            // 
            this.Col_Khoa.Caption = "Khoa";
            this.Col_Khoa.FieldName = "tenkhoa";
            this.Col_Khoa.Name = "Col_Khoa";
            this.Col_Khoa.Visible = true;
            this.Col_Khoa.VisibleIndex = 2;
            this.Col_Khoa.Width = 250;
            // 
            // frm_BoMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 470);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_BoMon";
            this.Text = "Quản lý bộ môn";
            this.Load += new System.EventHandler(this.frm_BoMon_Load);
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.groupControl2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lk_khoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenbomon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mabomon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_bomon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lk_khoa;
        private DevExpress.XtraEditors.TextEdit txt_GhiChu;
        private DevExpress.XtraEditors.TextEdit txt_tenbomon;
        private DevExpress.XtraEditors.TextEdit txt_mabomon;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl grd_bomon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Col_MaBM;
        private DevExpress.XtraGrid.Columns.GridColumn Col_TenBm;
        private DevExpress.XtraGrid.Columns.GridColumn Col_GhiChuBm;
        private DevExpress.XtraGrid.Columns.GridColumn Col_Khoa;
    }
}