namespace TNTT.Component
{
    partial class frm_Thongbao
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
            this.rich_mess = new DevExpress.XtraRichEdit.RichEditControl();
            this.cmd_Gửi = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // rich_mess
            // 
            this.rich_mess.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.rich_mess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rich_mess.Location = new System.Drawing.Point(0, 0);
            this.rich_mess.Name = "rich_mess";
            this.rich_mess.Size = new System.Drawing.Size(684, 261);
            this.rich_mess.TabIndex = 0;
            // 
            // cmd_Gửi
            // 
            this.cmd_Gửi.Location = new System.Drawing.Point(572, 216);
            this.cmd_Gửi.Name = "cmd_Gửi";
            this.cmd_Gửi.Size = new System.Drawing.Size(75, 23);
            this.cmd_Gửi.TabIndex = 1;
            this.cmd_Gửi.Text = "Gửi";
            this.cmd_Gửi.Click += new System.EventHandler(this.cmd_Gửi_Click);
            // 
            // frm_Thongbao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.ControlBox = false;
            this.Controls.Add(this.cmd_Gửi);
            this.Controls.Add(this.rich_mess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Thongbao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông báo đến sinh viên";
            this.Load += new System.EventHandler(this.frm_Thongbao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl rich_mess;
        private DevExpress.XtraEditors.SimpleButton cmd_Gửi;
    }
}