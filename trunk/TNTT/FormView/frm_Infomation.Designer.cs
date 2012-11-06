namespace TNTT.FormView
{
    partial class frm_Infomation
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
            this.cmd_changeavt = new DevExpress.XtraEditors.SimpleButton();
            this.lb_chucvu = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmd_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.lb_address = new DevExpress.XtraEditors.LabelControl();
            this.lb_email = new DevExpress.XtraEditors.LabelControl();
            this.lb_cv = new DevExpress.XtraEditors.LabelControl();
            this.lb_bomon = new DevExpress.XtraEditors.LabelControl();
            this.lb_name = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lb_time = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.pictureBox1);
            this.groupControl1.Controls.Add(this.cmd_changeavt);
            this.groupControl1.Controls.Add(this.lb_chucvu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(183, 447);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tài khoản cá nhân";
            // 
            // cmd_changeavt
            // 
            this.cmd_changeavt.Location = new System.Drawing.Point(46, 223);
            this.cmd_changeavt.Name = "cmd_changeavt";
            this.cmd_changeavt.Size = new System.Drawing.Size(75, 23);
            this.cmd_changeavt.TabIndex = 2;
            this.cmd_changeavt.Text = "Đổi Ảnh";
            this.cmd_changeavt.Click += new System.EventHandler(this.cmd_changeavt_Click);
            // 
            // lb_chucvu
            // 
            this.lb_chucvu.Location = new System.Drawing.Point(31, 203);
            this.lb_chucvu.Name = "lb_chucvu";
            this.lb_chucvu.Size = new System.Drawing.Size(44, 13);
            this.lb_chucvu.TabIndex = 1;
            this.lb_chucvu.Text = "Chức vụ:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.monthCalendar1);
            this.groupControl2.Controls.Add(this.panelControl1);
            this.groupControl2.Controls.Add(this.lb_time);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(183, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(707, 447);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thông tin tài khoản";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 65);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmd_Sua);
            this.panelControl1.Controls.Add(this.lb_address);
            this.panelControl1.Controls.Add(this.lb_email);
            this.panelControl1.Controls.Add(this.lb_cv);
            this.panelControl1.Controls.Add(this.lb_bomon);
            this.panelControl1.Controls.Add(this.lb_name);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(249, 64);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(520, 182);
            this.panelControl1.TabIndex = 7;
            // 
            // cmd_Sua
            // 
            this.cmd_Sua.Location = new System.Drawing.Point(21, 143);
            this.cmd_Sua.Name = "cmd_Sua";
            this.cmd_Sua.Size = new System.Drawing.Size(75, 23);
            this.cmd_Sua.TabIndex = 8;
            this.cmd_Sua.Text = "Sửa thông tin";
            this.cmd_Sua.Click += new System.EventHandler(this.cmd_Sua_Click);
            // 
            // lb_address
            // 
            this.lb_address.Location = new System.Drawing.Point(60, 42);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(54, 13);
            this.lb_address.TabIndex = 11;
            this.lb_address.Text = "Họ và tên :";
            // 
            // lb_email
            // 
            this.lb_email.Location = new System.Drawing.Point(57, 120);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(54, 13);
            this.lb_email.TabIndex = 10;
            this.lb_email.Text = "Họ và tên :";
            // 
            // lb_cv
            // 
            this.lb_cv.Location = new System.Drawing.Point(71, 95);
            this.lb_cv.Name = "lb_cv";
            this.lb_cv.Size = new System.Drawing.Size(54, 13);
            this.lb_cv.TabIndex = 8;
            this.lb_cv.Text = "Họ và tên :";
            // 
            // lb_bomon
            // 
            this.lb_bomon.Location = new System.Drawing.Point(66, 68);
            this.lb_bomon.Name = "lb_bomon";
            this.lb_bomon.Size = new System.Drawing.Size(54, 13);
            this.lb_bomon.TabIndex = 7;
            this.lb_bomon.Text = "Họ và tên :";
            // 
            // lb_name
            // 
            this.lb_name.Location = new System.Drawing.Point(82, 18);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(54, 13);
            this.lb_name.TabIndex = 5;
            this.lb_name.Text = "Họ và tên :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(23, 120);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Email:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 95);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Chức vụ:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(39, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Bộ môn:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Địa chỉ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Họ và tên :";
            // 
            // lb_time
            // 
            this.lb_time.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lb_time.Location = new System.Drawing.Point(27, 33);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(95, 25);
            this.lb_time.TabIndex = 6;
            this.lb_time.Text = "Thời gian:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 177);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Infomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 447);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_Infomation";
            this.Text = "Thông tin cá nhân";
            this.Load += new System.EventHandler(this.frm_Infomation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lb_chucvu;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton cmd_changeavt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl lb_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lb_address;
        private DevExpress.XtraEditors.LabelControl lb_email;
        private DevExpress.XtraEditors.LabelControl lb_cv;
        private DevExpress.XtraEditors.LabelControl lb_bomon;
        private DevExpress.XtraEditors.LabelControl lb_name;
        private DevExpress.XtraEditors.SimpleButton cmd_Sua;
    }
}