namespace SINHVIEN
{
    partial class frm_DangNhap
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
            this.txt_Masv = new DevExpress.XtraEditors.TextEdit();
            this.txt_Matkhau = new DevExpress.XtraEditors.TextEdit();
            this.cbo_Phong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmd_Config = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_DangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_Thoat = new DevExpress.XtraEditors.SimpleButton();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Masv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Matkhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Masv
            // 
            this.txt_Masv.Location = new System.Drawing.Point(123, 34);
            this.txt_Masv.Name = "txt_Masv";
            this.txt_Masv.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Masv.Properties.Appearance.Options.UseFont = true;
            this.txt_Masv.Size = new System.Drawing.Size(199, 22);
            this.txt_Masv.TabIndex = 0;
            // 
            // txt_Matkhau
            // 
            this.txt_Matkhau.Location = new System.Drawing.Point(123, 89);
            this.txt_Matkhau.Name = "txt_Matkhau";
            this.txt_Matkhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Matkhau.Properties.Appearance.Options.UseFont = true;
            this.txt_Matkhau.Properties.UseSystemPasswordChar = true;
            this.txt_Matkhau.Size = new System.Drawing.Size(199, 22);
            this.txt_Matkhau.TabIndex = 1;
            // 
            // cbo_Phong
            // 
            this.cbo_Phong.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Phong.FormattingEnabled = true;
            this.cbo_Phong.Location = new System.Drawing.Point(123, 60);
            this.cbo_Phong.Name = "cbo_Phong";
            this.cbo_Phong.Size = new System.Drawing.Size(199, 24);
            this.cbo_Phong.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã sinh viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phòng thi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu phòng thi:";
            // 
            // cmd_Config
            // 
            this.cmd_Config.Location = new System.Drawing.Point(12, 167);
            this.cmd_Config.Name = "cmd_Config";
            this.cmd_Config.Size = new System.Drawing.Size(75, 23);
            this.cmd_Config.TabIndex = 4;
            this.cmd_Config.Text = "Cấu hình";
            this.cmd_Config.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmd_DangNhap
            // 
            this.cmd_DangNhap.Location = new System.Drawing.Point(157, 127);
            this.cmd_DangNhap.Name = "cmd_DangNhap";
            this.cmd_DangNhap.Size = new System.Drawing.Size(75, 23);
            this.cmd_DangNhap.TabIndex = 4;
            this.cmd_DangNhap.Text = "Đăng Nhập";
            this.cmd_DangNhap.Click += new System.EventHandler(this.cmd_DangNhap_Click);
            // 
            // cmd_Thoat
            // 
            this.cmd_Thoat.Location = new System.Drawing.Point(238, 127);
            this.cmd_Thoat.Name = "cmd_Thoat";
            this.cmd_Thoat.Size = new System.Drawing.Size(75, 23);
            this.cmd_Thoat.TabIndex = 4;
            this.cmd_Thoat.Text = "Thoát";
            this.cmd_Thoat.Click += new System.EventHandler(this.cmd_Thoat_Click);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 202);
            this.Controls.Add(this.cmd_Thoat);
            this.Controls.Add(this.cmd_DangNhap);
            this.Controls.Add(this.cmd_Config);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_Phong);
            this.Controls.Add(this.txt_Matkhau);
            this.Controls.Add(this.txt_Masv);
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập phòng thi";
            this.Load += new System.EventHandler(this.frm_DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Masv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Matkhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_Masv;
        private DevExpress.XtraEditors.TextEdit txt_Matkhau;
        private System.Windows.Forms.ComboBox cbo_Phong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton cmd_Config;
        private DevExpress.XtraEditors.SimpleButton cmd_DangNhap;
        private DevExpress.XtraEditors.SimpleButton cmd_Thoat;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}