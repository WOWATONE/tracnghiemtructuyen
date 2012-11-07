namespace TNTT.FormView
{
    partial class frm_TaoCauHoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TaoCauHoi));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.cmd_Themmoi = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmd_Hide = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmd_dapan = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmd_Luu = new DevExpress.XtraBars.BarLargeButtonItem();
            this.cmd_Huy = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.axFramerControl1 = new AxDSOFramer.AxFramerControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axFramerControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.cmd_Themmoi,
            this.cmd_Hide,
            this.cmd_dapan,
            this.cmd_Luu,
            this.cmd_Huy});
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Left;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmd_Themmoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmd_Hide, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmd_dapan),
            new DevExpress.XtraBars.LinkPersistInfo(this.cmd_Luu),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.cmd_Huy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Offset = 6;
            this.bar1.Text = "Tools";
            // 
            // cmd_Themmoi
            // 
            this.cmd_Themmoi.Id = 1;
            this.cmd_Themmoi.LargeGlyph = global::TNTT.Properties.Resources.add;
            this.cmd_Themmoi.Name = "cmd_Themmoi";
            this.cmd_Themmoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmd_Themmoi_ItemClick);
            // 
            // cmd_Hide
            // 
            this.cmd_Hide.Id = 2;
            this.cmd_Hide.LargeGlyph = global::TNTT.Properties.Resources.Eye_icon;
            this.cmd_Hide.Name = "cmd_Hide";
            this.cmd_Hide.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cmd_Hide_ItemClick);
            // 
            // cmd_dapan
            // 
            this.cmd_dapan.Id = 3;
            this.cmd_dapan.LargeGlyph = global::TNTT.Properties.Resources.comment;
            this.cmd_dapan.Name = "cmd_dapan";
            // 
            // cmd_Luu
            // 
            this.cmd_Luu.Id = 4;
            this.cmd_Luu.LargeGlyph = global::TNTT.Properties.Resources.save;
            this.cmd_Luu.Name = "cmd_Luu";
            // 
            // cmd_Huy
            // 
            this.cmd_Huy.Id = 5;
            this.cmd_Huy.LargeGlyph = global::TNTT.Properties.Resources.cancel;
            this.cmd_Huy.Name = "cmd_Huy";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(731, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 344);
            this.barDockControlBottom.Size = new System.Drawing.Size(731, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(49, 344);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(731, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 344);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // axFramerControl1
            // 
            this.axFramerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axFramerControl1.Enabled = true;
            this.axFramerControl1.Location = new System.Drawing.Point(49, 0);
            this.axFramerControl1.Name = "axFramerControl1";
            this.axFramerControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axFramerControl1.OcxState")));
            this.axFramerControl1.Size = new System.Drawing.Size(682, 344);
            this.axFramerControl1.TabIndex = 0;
            // 
            // frm_TaoCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 344);
            this.Controls.Add(this.axFramerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_TaoCauHoi";
            this.Text = "Tạo câu hỏi mới";
            this.Load += new System.EventHandler(this.frm_TaoCauHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axFramerControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarLargeButtonItem cmd_Themmoi;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarLargeButtonItem cmd_Hide;
        private DevExpress.XtraBars.BarLargeButtonItem cmd_dapan;
        private AxDSOFramer.AxFramerControl axFramerControl1;
        private DevExpress.XtraBars.BarLargeButtonItem cmd_Luu;
        private DevExpress.XtraBars.BarLargeButtonItem cmd_Huy;
    }
}