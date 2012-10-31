namespace TNTT.Component
{
    partial class frm_EditInformation
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmd_Save = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_hoten = new DevExpress.XtraEditors.TextEdit();
            this.txt_Email = new DevExpress.XtraEditors.TextEdit();
            this.txt_Diachi = new DevExpress.XtraEditors.TextEdit();
            this.cmd_Exit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hoten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Diachi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txt_Diachi);
            this.panelControl1.Controls.Add(this.txt_Email);
            this.panelControl1.Controls.Add(this.txt_hoten);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(5, 13);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(496, 116);
            this.panelControl1.TabIndex = 8;
            // 
            // cmd_Save
            // 
            this.cmd_Save.Location = new System.Drawing.Point(353, 135);
            this.cmd_Save.Name = "cmd_Save";
            this.cmd_Save.Size = new System.Drawing.Size(75, 23);
            this.cmd_Save.TabIndex = 8;
            this.cmd_Save.Text = "Lưu thông tin";
            this.cmd_Save.Click += new System.EventHandler(this.cmd_Save_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(24, 79);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Email:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 49);
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
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(80, 11);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(411, 20);
            this.txt_hoten.TabIndex = 9;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(80, 76);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(411, 20);
            this.txt_Email.TabIndex = 11;
            // 
            // txt_Diachi
            // 
            this.txt_Diachi.Location = new System.Drawing.Point(80, 42);
            this.txt_Diachi.Name = "txt_Diachi";
            this.txt_Diachi.Size = new System.Drawing.Size(411, 20);
            this.txt_Diachi.TabIndex = 14;
            // 
            // cmd_Exit
            // 
            this.cmd_Exit.Location = new System.Drawing.Point(434, 135);
            this.cmd_Exit.Name = "cmd_Exit";
            this.cmd_Exit.Size = new System.Drawing.Size(75, 23);
            this.cmd_Exit.TabIndex = 9;
            this.cmd_Exit.Text = "Thoát";
            // 
            // frm_EditInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 169);
            this.Controls.Add(this.cmd_Exit);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.cmd_Save);
            this.Name = "frm_EditInformation";
            this.Text = "Sửa thông tin cá nhân";
            this.Load += new System.EventHandler(this.frm_EditInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hoten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Diachi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton cmd_Save;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_Diachi;
        private DevExpress.XtraEditors.TextEdit txt_Email;
        private DevExpress.XtraEditors.TextEdit txt_hoten;
        private DevExpress.XtraEditors.SimpleButton cmd_Exit;
    }
}