namespace TNTT.Component
{
    partial class frm_ViewerCauHoi
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
            this.redit = new DevExpress.XtraRichEdit.RichEditControl();
            this.SuspendLayout();
            // 
            // redit
            // 
            this.redit.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.redit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.redit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redit.Enabled = false;
            this.redit.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.redit.Location = new System.Drawing.Point(0, 0);
            this.redit.Name = "redit";
            this.redit.ReadOnly = true;
            this.redit.Size = new System.Drawing.Size(637, 374);
            this.redit.TabIndex = 0;
            // 
            // frm_ViewerCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 374);
            this.Controls.Add(this.redit);
            this.Name = "frm_ViewerCauHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết câu hỏi";
            this.Load += new System.EventHandler(this.frm_ViewerCauHoi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl redit;

    }
}