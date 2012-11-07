namespace SINHVIEN
{
    partial class frm_Message
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
            this.rich_Mess = new DevExpress.XtraRichEdit.RichEditControl();
            this.SuspendLayout();
            // 
            // rich_Mess
            // 
            this.rich_Mess.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.rich_Mess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rich_Mess.Location = new System.Drawing.Point(0, 0);
            this.rich_Mess.Name = "rich_Mess";
            this.rich_Mess.Size = new System.Drawing.Size(465, 261);
            this.rich_Mess.TabIndex = 0;
            this.rich_Mess.Text = "richEditControl1";
            // 
            // frm_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 261);
            this.Controls.Add(this.rich_Mess);
            this.Name = "frm_Message";
            this.Text = "frm_Message";
            this.Load += new System.EventHandler(this.frm_Message_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl rich_Mess;
    }
}