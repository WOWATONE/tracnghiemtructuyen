namespace TNTT.Component
{
    partial class frm_tuychontaocauhoi
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
            this.cmd_thucong = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_ngaunhien = new DevExpress.XtraEditors.SimpleButton();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.cd_thoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_thucong
            // 
            this.cmd_thucong.Image = global::TNTT.Properties.Resources._new;
            this.cmd_thucong.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.cmd_thucong.Location = new System.Drawing.Point(27, 21);
            this.cmd_thucong.Name = "cmd_thucong";
            this.cmd_thucong.Size = new System.Drawing.Size(105, 71);
            this.cmd_thucong.TabIndex = 0;
            this.cmd_thucong.Text = "Tạo đê thủ công";
            this.cmd_thucong.Click += new System.EventHandler(this.cmd_thucong_Click);
            // 
            // cmd_ngaunhien
            // 
            this.cmd_ngaunhien.Image = global::TNTT.Properties.Resources.new1;
            this.cmd_ngaunhien.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.cmd_ngaunhien.Location = new System.Drawing.Point(162, 21);
            this.cmd_ngaunhien.Name = "cmd_ngaunhien";
            this.cmd_ngaunhien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmd_ngaunhien.Size = new System.Drawing.Size(119, 71);
            this.cmd_ngaunhien.TabIndex = 0;
            this.cmd_ngaunhien.Text = "Tạo đề Ngẫu nhiên";
            this.cmd_ngaunhien.Click += new System.EventHandler(this.cmd_ngaunhien_Click);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(282, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 135);
            this.barDockControlBottom.Size = new System.Drawing.Size(282, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 135);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(282, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 135);
            // 
            // cd_thoat
            // 
            this.cd_thoat.Location = new System.Drawing.Point(96, 108);
            this.cd_thoat.Name = "cd_thoat";
            this.cd_thoat.Size = new System.Drawing.Size(75, 23);
            this.cd_thoat.TabIndex = 5;
            this.cd_thoat.Text = "Thoát";
            // 
            // frm_tuychontaocauhoi
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 135);
            this.ControlBox = false;
            this.Controls.Add(this.cd_thoat);
            this.Controls.Add(this.cmd_ngaunhien);
            this.Controls.Add(this.cmd_thucong);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_tuychontaocauhoi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo câu hỏi";
            this.Load += new System.EventHandler(this.frm_tuychontaocauhoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmd_thucong;
        private DevExpress.XtraEditors.SimpleButton cmd_ngaunhien;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton cd_thoat;
    }
}