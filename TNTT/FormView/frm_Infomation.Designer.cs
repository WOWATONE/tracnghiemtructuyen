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
            this.lb_time = new DevExpress.XtraEditors.LabelControl();
            this.lb_cv = new DevExpress.XtraEditors.LabelControl();
            this.lb_bomon = new DevExpress.XtraEditors.LabelControl();
            this.lb_email = new DevExpress.XtraEditors.LabelControl();
            this.lb_phone = new DevExpress.XtraEditors.LabelControl();
            this.lb_name = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lb_address = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
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
            this.groupControl1.Size = new System.Drawing.Size(200, 447);
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
            this.groupControl2.Controls.Add(this.lb_time);
            this.groupControl2.Controls.Add(this.lb_cv);
            this.groupControl2.Controls.Add(this.lb_bomon);
            this.groupControl2.Controls.Add(this.lb_email);
            this.groupControl2.Controls.Add(this.lb_phone);
            this.groupControl2.Controls.Add(this.lb_name);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.lb_address);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(200, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(690, 447);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thông tin tài khoản";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(11, 84);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // lb_time
            // 
            this.lb_time.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lb_time.Location = new System.Drawing.Point(6, 39);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(95, 25);
            this.lb_time.TabIndex = 6;
            this.lb_time.Text = "Thời gian:";
            // 
            // lb_cv
            // 
            this.lb_cv.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cv.Location = new System.Drawing.Point(391, 230);
            this.lb_cv.Name = "lb_cv";
            this.lb_cv.Size = new System.Drawing.Size(0, 23);
            this.lb_cv.TabIndex = 5;
            // 
            // lb_bomon
            // 
            this.lb_bomon.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bomon.Location = new System.Drawing.Point(391, 191);
            this.lb_bomon.Name = "lb_bomon";
            this.lb_bomon.Size = new System.Drawing.Size(0, 23);
            this.lb_bomon.TabIndex = 4;
            // 
            // lb_email
            // 
            this.lb_email.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(391, 153);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(0, 23);
            this.lb_email.TabIndex = 3;
            // 
            // lb_phone
            // 
            this.lb_phone.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.Location = new System.Drawing.Point(399, 121);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(0, 23);
            this.lb_phone.TabIndex = 2;
            // 
            // lb_name
            // 
            this.lb_name.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lb_name.Location = new System.Drawing.Point(390, 52);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(68, 23);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "Họ Tên:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(302, 230);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(76, 23);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Chức vụ:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(302, 191);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 23);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Bộ Môn:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(302, 153);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(52, 23);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Email:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(302, 121);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(92, 23);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Điện thoại:";
            // 
            // lb_address
            // 
            this.lb_address.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.Location = new System.Drawing.Point(391, 85);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(0, 23);
            this.lb_address.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Silver;
            this.labelControl2.Location = new System.Drawing.Point(302, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 23);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Địa chỉ:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(301, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Họ Tên:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 20);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lb_chucvu;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton cmd_changeavt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl lb_name;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lb_cv;
        private DevExpress.XtraEditors.LabelControl lb_bomon;
        private DevExpress.XtraEditors.LabelControl lb_email;
        private DevExpress.XtraEditors.LabelControl lb_phone;
        private DevExpress.XtraEditors.LabelControl lb_address;
        private DevExpress.XtraEditors.LabelControl lb_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}