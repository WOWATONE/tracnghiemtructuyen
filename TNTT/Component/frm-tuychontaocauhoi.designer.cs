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
            this.cmd_thucong = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_ngaunhien = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // cmd_thucong
            // 
            this.cmd_thucong.Image = global::TNTT.Properties.Resources._new;
            this.cmd_thucong.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.cmd_thucong.Location = new System.Drawing.Point(23, 21);
            this.cmd_thucong.Name = "cmd_thucong";
            this.cmd_thucong.Size = new System.Drawing.Size(67, 71);
            this.cmd_thucong.TabIndex = 0;
            this.cmd_thucong.Text = "Thủ công";
            this.cmd_thucong.Click += new System.EventHandler(this.cmd_thucong_Click);
            // 
            // cmd_thoat
            // 
            this.cmd_thoat.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cmd_thoat.Appearance.Options.UseFont = true;
            this.cmd_thoat.Location = new System.Drawing.Point(131, 106);
            this.cmd_thoat.Name = "cmd_thoat";
            this.cmd_thoat.Size = new System.Drawing.Size(67, 29);
            this.cmd_thoat.TabIndex = 0;
            this.cmd_thoat.Text = "Thoát";
            this.cmd_thoat.Click += new System.EventHandler(this.cmd_thoat_Click);
            // 
            // cmd_ngaunhien
            // 
            this.cmd_ngaunhien.Image = global::TNTT.Properties.Resources.new1;
            this.cmd_ngaunhien.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.cmd_ngaunhien.Location = new System.Drawing.Point(131, 21);
            this.cmd_ngaunhien.Name = "cmd_ngaunhien";
            this.cmd_ngaunhien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmd_ngaunhien.Size = new System.Drawing.Size(67, 71);
            this.cmd_ngaunhien.TabIndex = 0;
            this.cmd_ngaunhien.Text = "Ngẫu nhiên";
            this.cmd_ngaunhien.Click += new System.EventHandler(this.cmd_ngaunhien_Click);
            // 
            // frm_tuychontaocauhoi
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 147);
            this.ControlBox = false;
            this.Controls.Add(this.cmd_ngaunhien);
            this.Controls.Add(this.cmd_thoat);
            this.Controls.Add(this.cmd_thucong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_tuychontaocauhoi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo câu hỏi";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmd_thucong;
        private DevExpress.XtraEditors.SimpleButton cmd_thoat;
        private DevExpress.XtraEditors.SimpleButton cmd_ngaunhien;
    }
}