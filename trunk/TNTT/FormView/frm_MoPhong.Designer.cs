﻿namespace TNTT.FormView
{
    partial class cbo_Phongthi
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.btn_TaoMK = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lb_ip = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbo_DsPhong = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_thoigian = new DevExpress.XtraEditors.LabelControl();
            this.lb_maphong = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupControlContainer2 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.lb_chucvu = new DevExpress.XtraEditors.LabelControl();
            this.lb_tengv = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.btn_Tinnhan = new DevExpress.XtraEditors.SimpleButton();
            this.lst_Log = new System.Windows.Forms.ListBox();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.rich_mess = new DevExpress.XtraRichEdit.RichEditControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmd_thubaithi = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_Mophongthi = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_Help = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.navBarControl1.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.navBarGroupControlContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.navBarControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(235, 593);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "groupControl1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer2);
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem2});
            this.navBarControl1.Location = new System.Drawing.Point(2, 2);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 231;
            this.navBarControl1.Size = new System.Drawing.Size(231, 558);
            this.navBarControl1.TabIndex = 9;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Chọn phòng thi";
            this.navBarGroup1.ControlContainer = this.navBarGroupControlContainer1;
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupClientHeight = 181;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Controls.Add(this.btn_TaoMK);
            this.navBarGroupControlContainer1.Controls.Add(this.labelControl2);
            this.navBarGroupControlContainer1.Controls.Add(this.lb_ip);
            this.navBarGroupControlContainer1.Controls.Add(this.labelControl4);
            this.navBarGroupControlContainer1.Controls.Add(this.cbo_DsPhong);
            this.navBarGroupControlContainer1.Controls.Add(this.pictureBox1);
            this.navBarGroupControlContainer1.Controls.Add(this.lb_thoigian);
            this.navBarGroupControlContainer1.Controls.Add(this.lb_maphong);
            this.navBarGroupControlContainer1.Controls.Add(this.labelControl3);
            this.navBarGroupControlContainer1.Controls.Add(this.labelControl1);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(223, 174);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // btn_TaoMK
            // 
            this.btn_TaoMK.Image = global::TNTT.Properties.Resources.taomatkhau;
            this.btn_TaoMK.Location = new System.Drawing.Point(44, 81);
            this.btn_TaoMK.Name = "btn_TaoMK";
            this.btn_TaoMK.Size = new System.Drawing.Size(144, 50);
            this.btn_TaoMK.TabIndex = 5;
            this.btn_TaoMK.Text = "Tạo mật khẩu";
            this.btn_TaoMK.Click += new System.EventHandler(this.btn_TaoMK_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(2, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên phòng:";
            // 
            // lb_ip
            // 
            this.lb_ip.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ip.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lb_ip.Location = new System.Drawing.Point(95, 143);
            this.lb_ip.Name = "lb_ip";
            this.lb_ip.Size = new System.Drawing.Size(40, 19);
            this.lb_ip.TabIndex = 8;
            this.lb_ip.Text = "lb_ip";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(29, 146);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "IP máy chủ:";
            // 
            // cbo_DsPhong
            // 
            this.cbo_DsPhong.FormattingEnabled = true;
            this.cbo_DsPhong.Location = new System.Drawing.Point(74, 7);
            this.cbo_DsPhong.Name = "cbo_DsPhong";
            this.cbo_DsPhong.Size = new System.Drawing.Size(131, 21);
            this.cbo_DsPhong.TabIndex = 1;
            this.cbo_DsPhong.SelectedIndexChanged += new System.EventHandler(this.cbo_DsPhong_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(56, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 50);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lb_thoigian
            // 
            this.lb_thoigian.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thoigian.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lb_thoigian.Location = new System.Drawing.Point(98, 62);
            this.lb_thoigian.Name = "lb_thoigian";
            this.lb_thoigian.Size = new System.Drawing.Size(85, 16);
            this.lb_thoigian.TabIndex = 3;
            this.lb_thoigian.Text = "labelControl4";
            // 
            // lb_maphong
            // 
            this.lb_maphong.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_maphong.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lb_maphong.Location = new System.Drawing.Point(73, 39);
            this.lb_maphong.Name = "lb_maphong";
            this.lb_maphong.Size = new System.Drawing.Size(85, 16);
            this.lb_maphong.TabIndex = 2;
            this.lb_maphong.Text = "labelControl3";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 62);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Thời gian bắt đầu:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 37);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Mã phòng:";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "navBarItem1";
            this.navBarItem1.Name = "navBarItem1";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "navBarItem2";
            this.navBarItem2.Name = "navBarItem2";
            // 
            // navBarGroupControlContainer2
            // 
            this.navBarGroupControlContainer2.Controls.Add(this.lb_chucvu);
            this.navBarGroupControlContainer2.Controls.Add(this.lb_tengv);
            this.navBarGroupControlContainer2.Controls.Add(this.labelControl9);
            this.navBarGroupControlContainer2.Controls.Add(this.pictureBox2);
            this.navBarGroupControlContainer2.Controls.Add(this.labelControl5);
            this.navBarGroupControlContainer2.Name = "navBarGroupControlContainer2";
            this.navBarGroupControlContainer2.Size = new System.Drawing.Size(223, 284);
            this.navBarGroupControlContainer2.TabIndex = 1;
            // 
            // lb_chucvu
            // 
            this.lb_chucvu.Location = new System.Drawing.Point(56, 207);
            this.lb_chucvu.Name = "lb_chucvu";
            this.lb_chucvu.Size = new System.Drawing.Size(44, 13);
            this.lb_chucvu.TabIndex = 11;
            this.lb_chucvu.Text = "Chức vụ:";
            // 
            // lb_tengv
            // 
            this.lb_tengv.Location = new System.Drawing.Point(86, 188);
            this.lb_tengv.Name = "lb_tengv";
            this.lb_tengv.Size = new System.Drawing.Size(0, 13);
            this.lb_tengv.TabIndex = 12;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(6, 207);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(44, 13);
            this.labelControl9.TabIndex = 11;
            this.labelControl9.Text = "Chức vụ:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(31, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 179);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 188);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(74, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Tên giảng viên:";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Thông tin giảng viên";
            this.navBarGroup2.ControlContainer = this.navBarGroupControlContainer2;
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupClientHeight = 291;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl4);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(235, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(721, 593);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btn_Tinnhan);
            this.groupControl4.Controls.Add(this.lst_Log);
            this.groupControl4.Controls.Add(this.groupControl6);
            this.groupControl4.Controls.Add(this.groupControl5);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(2, 2);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.ShowCaption = false;
            this.groupControl4.Size = new System.Drawing.Size(717, 589);
            this.groupControl4.TabIndex = 8;
            // 
            // btn_Tinnhan
            // 
            this.btn_Tinnhan.Image = global::TNTT.Properties.Resources.chuyenlop;
            this.btn_Tinnhan.Location = new System.Drawing.Point(207, 167);
            this.btn_Tinnhan.Name = "btn_Tinnhan";
            this.btn_Tinnhan.Size = new System.Drawing.Size(64, 31);
            this.btn_Tinnhan.TabIndex = 2;
            this.btn_Tinnhan.Text = "Gửi";
            this.btn_Tinnhan.Click += new System.EventHandler(this.btn_Tinnhan_Click);
            // 
            // lst_Log
            // 
            this.lst_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_Log.FormattingEnabled = true;
            this.lst_Log.Location = new System.Drawing.Point(291, 2);
            this.lst_Log.Name = "lst_Log";
            this.lst_Log.Size = new System.Drawing.Size(424, 523);
            this.lst_Log.TabIndex = 3;
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.rich_mess);
            this.groupControl6.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl6.Location = new System.Drawing.Point(2, 2);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.ShowCaption = false;
            this.groupControl6.Size = new System.Drawing.Size(289, 523);
            this.groupControl6.TabIndex = 2;
            this.groupControl6.Text = "groupControl6";
            // 
            // rich_mess
            // 
            this.rich_mess.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.rich_mess.Dock = System.Windows.Forms.DockStyle.Top;
            this.rich_mess.Location = new System.Drawing.Point(2, 2);
            this.rich_mess.Name = "rich_mess";
            this.rich_mess.Size = new System.Drawing.Size(285, 200);
            this.rich_mess.TabIndex = 1;
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.panel1);
            this.groupControl5.Controls.Add(this.cmd_Help);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl5.Location = new System.Drawing.Point(2, 525);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.ShowCaption = false;
            this.groupControl5.Size = new System.Drawing.Size(713, 62);
            this.groupControl5.TabIndex = 0;
            this.groupControl5.Text = "Chức năng:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmd_thubaithi);
            this.panel1.Controls.Add(this.cmd_Mophongthi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(468, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 58);
            this.panel1.TabIndex = 1;
            // 
            // cmd_thubaithi
            // 
            this.cmd_thubaithi.Image = global::TNTT.Properties.Resources.saoluudulieu;
            this.cmd_thubaithi.Location = new System.Drawing.Point(118, 10);
            this.cmd_thubaithi.Name = "cmd_thubaithi";
            this.cmd_thubaithi.Size = new System.Drawing.Size(115, 42);
            this.cmd_thubaithi.TabIndex = 0;
            this.cmd_thubaithi.Text = "Thu bài thi";
            this.cmd_thubaithi.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // cmd_Mophongthi
            // 
            this.cmd_Mophongthi.Image = global::TNTT.Properties.Resources.open;
            this.cmd_Mophongthi.Location = new System.Drawing.Point(11, 11);
            this.cmd_Mophongthi.Name = "cmd_Mophongthi";
            this.cmd_Mophongthi.Size = new System.Drawing.Size(98, 42);
            this.cmd_Mophongthi.TabIndex = 0;
            this.cmd_Mophongthi.Text = "Mở phòng";
            this.cmd_Mophongthi.Click += new System.EventHandler(this.cmd_Mophongthi_Click);
            // 
            // cmd_Help
            // 
            this.cmd_Help.Image = global::TNTT.Properties.Resources.help;
            this.cmd_Help.Location = new System.Drawing.Point(21, 13);
            this.cmd_Help.Name = "cmd_Help";
            this.cmd_Help.Size = new System.Drawing.Size(98, 40);
            this.cmd_Help.TabIndex = 0;
            this.cmd_Help.Text = "Trợ giúp";
            this.cmd_Help.Click += new System.EventHandler(this.cmd_Mophongthi_Click);
            // 
            // cbo_Phongthi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 593);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Name = "cbo_Phongthi";
            this.Text = "Mở phòng thi";
            this.Load += new System.EventHandler(this.frm_MoPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.navBarControl1.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            this.navBarGroupControlContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.navBarGroupControlContainer2.ResumeLayout(false);
            this.navBarGroupControlContainer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lb_maphong;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmd_thubaithi;
        private DevExpress.XtraEditors.SimpleButton cmd_Mophongthi;
        private DevExpress.XtraEditors.LabelControl lb_thoigian;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btn_TaoMK;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.ListBox lst_Log;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.SimpleButton btn_Tinnhan;
        private DevExpress.XtraRichEdit.RichEditControl rich_mess;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.LabelControl lb_ip;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbo_DsPhong;
        private DevExpress.XtraEditors.SimpleButton cmd_Help;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer2;
        private DevExpress.XtraEditors.LabelControl lb_chucvu;
        private DevExpress.XtraEditors.LabelControl lb_tengv;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
    }
}