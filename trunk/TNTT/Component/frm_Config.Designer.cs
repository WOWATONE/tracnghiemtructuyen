namespace TNTT.Component
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
            this.lk_svrname = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_Chonmaychu = new DevExpress.XtraEditors.SimpleButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lk_svrname.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lk_svrname
            // 
            this.lk_svrname.Location = new System.Drawing.Point(80, 37);
            this.lk_svrname.Name = "lk_svrname";
            this.lk_svrname.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lk_svrname.Size = new System.Drawing.Size(182, 20);
            this.lk_svrname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên máy chủ:";
            // 
            // cmd_Chonmaychu
            // 
            this.cmd_Chonmaychu.Location = new System.Drawing.Point(268, 34);
            this.cmd_Chonmaychu.Name = "cmd_Chonmaychu";
            this.cmd_Chonmaychu.Size = new System.Drawing.Size(34, 23);
            this.cmd_Chonmaychu.TabIndex = 3;
            this.cmd_Chonmaychu.Text = "...";
            this.cmd_Chonmaychu.Click += new System.EventHandler(this.cmd_Chonmaychu_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(80, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmd_Chonmaychu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lk_svrname);
            this.Name = "frm_Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Config";
            this.Load += new System.EventHandler(this.frm_Config_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lk_svrname.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lk_svrname;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton cmd_Chonmaychu;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}