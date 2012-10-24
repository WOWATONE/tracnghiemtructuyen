namespace TNTT.Component
{
    partial class frm_TuyChonDeThi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trb_Cauhoi = new DevExpress.XtraEditors.TrackBarControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lb_socau = new DevExpress.XtraEditors.LabelControl();
            this.cbb_monhoc = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmd_OK = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Cauhoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Cauhoi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trb_Cauhoi);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.lb_socau);
            this.groupBox1.Controls.Add(this.cbb_monhoc);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 158);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // trb_Cauhoi
            // 
            this.trb_Cauhoi.EditValue = 40;
            this.trb_Cauhoi.Location = new System.Drawing.Point(41, 30);
            this.trb_Cauhoi.Name = "trb_Cauhoi";
            this.trb_Cauhoi.Properties.Maximum = 100;
            this.trb_Cauhoi.Properties.Minimum = 20;
            this.trb_Cauhoi.Properties.TickFrequency = 5;
            this.trb_Cauhoi.Size = new System.Drawing.Size(279, 45);
            this.trb_Cauhoi.TabIndex = 2;
            this.trb_Cauhoi.Value = 40;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(80, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Số câu trong 1 đề thi:";
            // 
            // lb_socau
            // 
            this.lb_socau.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_socau.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lb_socau.Location = new System.Drawing.Point(190, 4);
            this.lb_socau.Name = "lb_socau";
            this.lb_socau.Size = new System.Drawing.Size(24, 23);
            this.lb_socau.TabIndex = 3;
            this.lb_socau.Text = "20";
            // 
            // cbb_monhoc
            // 
            this.cbb_monhoc.FormattingEnabled = true;
            this.cbb_monhoc.Location = new System.Drawing.Point(126, 90);
            this.cbb_monhoc.Name = "cbb_monhoc";
            this.cbb_monhoc.Size = new System.Drawing.Size(112, 21);
            this.cbb_monhoc.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(80, 98);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Môn học";
            // 
            // cmd_OK
            // 
            this.cmd_OK.Location = new System.Drawing.Point(164, 185);
            this.cmd_OK.Name = "cmd_OK";
            this.cmd_OK.Size = new System.Drawing.Size(75, 23);
            this.cmd_OK.TabIndex = 10;
            this.cmd_OK.Text = "Chấp nhận";
            this.cmd_OK.Click += new System.EventHandler(this.cmd_OK_Click);
            // 
            // frm_TuyChonDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 220);
            this.ControlBox = false;
            this.Controls.Add(this.cmd_OK);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_TuyChonDeThi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tùy chọn đề thi";
            this.Load += new System.EventHandler(this.frm_TuyChonDeThi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Cauhoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Cauhoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TrackBarControl trb_Cauhoi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lb_socau;
        private System.Windows.Forms.ComboBox cbb_monhoc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton cmd_OK;
    }
}