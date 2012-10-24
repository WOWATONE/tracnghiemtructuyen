namespace TNTT.FormView
{
    partial class frm_Login
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
            this.txt_uid = new DevExpress.XtraEditors.TextEdit();
            this.txt_pwd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmdDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.img1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_uid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_uid
            // 
            this.txt_uid.Location = new System.Drawing.Point(310, 149);
            this.txt_uid.Name = "txt_uid";
            this.txt_uid.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_uid.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txt_uid.Properties.Appearance.Options.UseFont = true;
            this.txt_uid.Properties.Appearance.Options.UseForeColor = true;
            this.txt_uid.Size = new System.Drawing.Size(239, 30);
            this.txt_uid.TabIndex = 2;
            this.txt_uid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_uid_KeyDown);
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(310, 196);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pwd.Properties.Appearance.Options.UseFont = true;
            this.txt_pwd.Properties.UseSystemPasswordChar = true;
            this.txt_pwd.Size = new System.Drawing.Size(239, 30);
            this.txt_pwd.TabIndex = 3;
            this.txt_pwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pwd_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.labelControl1.Location = new System.Drawing.Point(377, 98);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(119, 29);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Đăng Nhập";
            // 
            // cmdDangNhap
            // 
            this.cmdDangNhap.Location = new System.Drawing.Point(381, 246);
            this.cmdDangNhap.Name = "cmdDangNhap";
            this.cmdDangNhap.Size = new System.Drawing.Size(119, 31);
            this.cmdDangNhap.TabIndex = 5;
            this.cmdDangNhap.Text = "Đăng Nhập";
            this.cmdDangNhap.Click += new System.EventHandler(this.cmdDangNhap_Click);
            // 
            // img1
            // 
            this.img1.EditValue = global::TNTT.Properties.Resources._login;
            this.img1.Location = new System.Drawing.Point(264, 95);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(345, 191);
            this.img1.TabIndex = 0;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 453);
            this.Controls.Add(this.cmdDangNhap);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_uid);
            this.Controls.Add(this.img1);
            this.Name = "frm_Login";
            this.Text = "Đăng Nhập Hệ Thống";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Login_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txt_uid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit img1;
        private DevExpress.XtraEditors.TextEdit txt_uid;
        private DevExpress.XtraEditors.TextEdit txt_pwd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cmdDangNhap;

    }
}