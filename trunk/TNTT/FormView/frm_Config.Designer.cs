namespace TNTT.FormView
{
    partial class frm_Config
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
            this.cmd_Save = new DevExpress.XtraEditors.SimpleButton();
            this.cmd_Hide = new DevExpress.XtraEditors.SimpleButton();
            this.lb_srv = new DevExpress.XtraEditors.LabelControl();
            this.txt_srv = new DevExpress.XtraEditors.TextEdit();
            this.txt_dbname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_srv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dbname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_Save
            // 
            this.cmd_Save.Location = new System.Drawing.Point(193, 123);
            this.cmd_Save.Name = "cmd_Save";
            this.cmd_Save.Size = new System.Drawing.Size(75, 23);
            this.cmd_Save.TabIndex = 0;
            this.cmd_Save.Text = "Lưu cấu hình";
            this.cmd_Save.Click += new System.EventHandler(this.cmd_Save_Click);
            // 
            // cmd_Hide
            // 
            this.cmd_Hide.Location = new System.Drawing.Point(294, 123);
            this.cmd_Hide.Name = "cmd_Hide";
            this.cmd_Hide.Size = new System.Drawing.Size(75, 23);
            this.cmd_Hide.TabIndex = 0;
            this.cmd_Hide.Text = "Ẩn";
            this.cmd_Hide.Click += new System.EventHandler(this.cmd_Hide_Click);
            // 
            // lb_srv
            // 
            this.lb_srv.Location = new System.Drawing.Point(52, 43);
            this.lb_srv.Name = "lb_srv";
            this.lb_srv.Size = new System.Drawing.Size(44, 13);
            this.lb_srv.TabIndex = 1;
            this.lb_srv.Text = "Máy chủ:";
            // 
            // txt_srv
            // 
            this.txt_srv.Location = new System.Drawing.Point(102, 44);
            this.txt_srv.Name = "txt_srv";
            this.txt_srv.Size = new System.Drawing.Size(267, 20);
            this.txt_srv.TabIndex = 2;
            // 
            // txt_dbname
            // 
            this.txt_dbname.Location = new System.Drawing.Point(102, 79);
            this.txt_dbname.Name = "txt_dbname";
            this.txt_dbname.Size = new System.Drawing.Size(267, 20);
            this.txt_dbname.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 83);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Cơ Sở dữ liệu:";
            // 
            // frm_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 158);
            this.ControlBox = false;
            this.Controls.Add(this.txt_dbname);
            this.Controls.Add(this.txt_srv);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lb_srv);
            this.Controls.Add(this.cmd_Hide);
            this.Controls.Add(this.cmd_Save);
            this.Name = "frm_Config";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình hệ thống";
            this.Load += new System.EventHandler(this.frm_Config_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_srv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dbname.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cmd_Save;
        private DevExpress.XtraEditors.SimpleButton cmd_Hide;
        private DevExpress.XtraEditors.LabelControl lb_srv;
        private DevExpress.XtraEditors.TextEdit txt_srv;
        private DevExpress.XtraEditors.TextEdit txt_dbname;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}