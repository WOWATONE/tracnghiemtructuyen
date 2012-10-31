using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TNTT.Class;
namespace TNTT.FormView
{
    public partial class frm_TaoDeNH : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        DataTable dt_ngaunhien = new DataTable();
        C_CauHoi ch = new C_CauHoi();
        string socau="40", idmonhoc="-1";
        public frm_TaoDeNH()
        {
            InitializeComponent();
        }
        public frm_TaoDeNH(string socau, string idmonhoc)
        {
            this.socau = socau;
            this.idmonhoc = idmonhoc;
            InitializeComponent();
        }
        private void frm_TaoDeNH_Load(object sender, EventArgs e)
        {
            DataBind();
            Init();
            EditShowDialog();
        }
        void EditShowDialog()
        {
            Component.frm_TuyChonDeThi frm = new Component.frm_TuyChonDeThi(socau, idmonhoc);
            frm.Init += Init;
            frm.passControl = new Component.frm_TuyChonDeThi.PassControl(PassData);
            frm.ShowDialog();
        }
        void DataBind()
        {
            //lb_socau.DataBindings.Add("text", trb_Cauhoi, "value");
            lb_socaungaunhien.DataBindings.Add("text",trb_Socaungaunhien,"value");
          
        }
        void Init()
        {
           // trb_Socaungaunhien.Enabled=txt_phan.Enabled = false;
            cmd_Save.Enabled = false;
            if (dt.Columns.Count == 0)
            {
                dt.Columns.Add("idnganhangcauhoi");
                dt.Columns.Add("monhoc_idmonhoc");
                dt.Columns.Add("tenmonhoc");
                dt.Columns.Add("tieude");
                dt.Columns.Add("chuong");
                dt.Columns.Add("phan");
                dt.Columns.Add("capdo");
                dt.Columns.Add("ngaytao");
                dt.Columns.Add("tinhtrang");
                dt.Columns.Add("giangvien_idgiangvien");
                dt.Columns.Add("tengiangvien");
                dt.Columns.Add("troncau", typeof(bool));
                dt.Columns.Add("xoa");
            }
        
        }
       
        private void txt_chuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_phan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
      
        private void cbb_monhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            grd_Dethi.DataSource = dt = null;
        }
        Timer a;
        Component.frm_Loading frm;

        private void cmd_Create_Click(object sender, EventArgs e)
        {
            frm = new Component.frm_Loading();
            if (CheckTrackbar())
            {
                frm.Show();
                a = new Timer();
                a.Interval = 1000;
                a.Start();
                a.Tick += new EventHandler(a_Tick);
            }
      
           
        }
        /// <summary>
        /// Kiểm tra số câu còn lại có lớn hơn số câu đang chọn hay ko?
        /// </summary>
        /// <returns></returns>
        bool CheckTrackbar()
        {
            int x = int.Parse(socau) - int.Parse(lb_socauduocchon.Text);
            if (x < trb_Socaungaunhien.Value)
            {
                XtraMessageBox.Show("Số câu còn lại là " + x.ToString() + " .Bạn vui lòng chọn số câu ít hơn");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Tạo câu hỏi
        /// </summary>
        bool Create()
        {
            dt_ngaunhien.Rows.Clear();
            dt_ngaunhien = ch.GetListRandom(trb_Socaungaunhien.Value.ToString(), Condition());
           // MessageBox.Show(trb_Socaungaunhien.Value.ToString());
            if (dt_ngaunhien.Rows.Count < trb_Socaungaunhien.Value)
            {
                XtraMessageBox.Show("Câu hỏi trong ngân hàng câu hỏi không đủ để thực hiện thao tác này");
                return false;
            }
            grd_Dethi.DataSource = null;
            try
            {
                for (int i = 0; dt.Rows.Count < int.Parse(socau) && i < dt_ngaunhien.Rows.Count; i++)
                    AddColums(i);
                return true;
            }
            catch { return false; }         
        }
        /// <summary>
        /// Bắt sưj kiện để tắt form loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void a_Tick(object sender, EventArgs e)
        {
            
            a.Stop();
            frm.Close();
            //tạo thành công
            if (Create())
                AfterCreate();
        }
        /// <summary>
        /// sau khi tạo xong set thuộc tính lại ban đầu
        /// </summary>
        void AfterCreate()
        {
            lb_socauduocchon.Text = dt.Rows.Count.ToString();
            trb_Socaungaunhien.Properties.Maximum = int.Parse(socau) - dt.Rows.Count;
            if (int.Parse(socau) - dt.Rows.Count != 0)
            {
                if (trb_Socaungaunhien.Value > trb_Socaungaunhien.Properties.Maximum)
                    trb_Socaungaunhien.Value = trb_Socaungaunhien.Properties.Maximum;
            }
            else
            {
                trb_Socaungaunhien.Value = 0;
                lb_socaungaunhien.Text = "0";

            }

            grd_Dethi.DataSource = dt;
            if (dt.Rows.Count == int.Parse(lb_socau.Text))
                cmd_Save.Enabled = true;
            else
                cmd_Save.Enabled = false;
        }
        private void txt_chuong_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void cmd_Sua_Click(object sender, EventArgs e)
        {
            Component.frm_TuyChonDeThi frm = new Component.frm_TuyChonDeThi(socau,idmonhoc);
            frm.Init += Init;
            frm.passControl = new Component.frm_TuyChonDeThi.PassControl(PassData);
            frm.ShowDialog();
        }
        private void PassData(object sender,object sender2)
        {
            // Set de text of the textbox to the value of the textbox of form 2
            socau = ((LabelControl)sender).Text;
            if (int.Parse(socau) < int.Parse(lb_socauduocchon.Text))
            {
                XtraMessageBox.Show("Bạn không thể chọn số câu nhỏ hơn số lượng câu hỏi đã chọn");
                EditShowDialog();
                return;
            }
            //nếu thay đổi môn học thì phải gán nó null
            string var = ((System.Windows.Forms.ComboBox)sender2).SelectedValue.ToString();
            if (idmonhoc != var)
            {
                grd_Dethi.DataSource = null;
                lb_socauduocchon.Text = "0";

            }

            idmonhoc = ((System.Windows.Forms.ComboBox)sender2).SelectedValue.ToString();
            lb_socau.Text = socau = ((LabelControl)sender).Text;
            lb_monhoc.Text = ((System.Windows.Forms.ComboBox)sender2).Text;
            trb_Socaungaunhien.Properties.Maximum = int.Parse(socau);

           
            //MessageBox.Show(idmonhoc);
        }
        string Condition()
        {
            string condition = " and monhoc_idmonhoc = "+idmonhoc;
            if (txt_chuong.Text != null)
                condition += " and chuong like '%" + txt_chuong.Text + "%' ";
            if (txt_phan.Text != null)
                condition += " and phan like '%" + txt_phan.Text + "%' ";
            if(rdg_Level.SelectedIndex!=0)
                condition += " and capdo ="+rdg_Level.SelectedIndex+" ";
            if (dt.Rows.Count > 0)
            {
                condition += " and idnganhangcauhoi not in( ";
                for (int i = 0; i < dt.Rows.Count; i++)
                    condition += "'"+dt.Rows[i]["idnganhangcauhoi"].ToString() + "' ,";
                condition = condition.Substring(0, condition.LastIndexOf(",") - 1);
                condition += " ) ";
                //MessageBox.Show(condition);
            }
            return condition;
        }
        void AddColums(int i)
        {
            string idnganhangcauhoi, monhoc_idmonhoc, tenmonhoc, tieude, chuong, phan, capdo, ngaytao, tinhtrang, giangvien_idgiangvien, tengiangvien, troncau;
            idnganhangcauhoi = dt_ngaunhien.Rows[i]["idnganhangcauhoi"].ToString();
            monhoc_idmonhoc = dt_ngaunhien.Rows[i]["monhoc_idmonhoc"].ToString();
            tenmonhoc = dt_ngaunhien.Rows[i]["tenmonhoc"].ToString();
            tieude = dt_ngaunhien.Rows[i]["tieude"].ToString(); ;
            chuong = dt_ngaunhien.Rows[i]["chuong"].ToString();
            phan = dt_ngaunhien.Rows[i]["phan"].ToString(); ;
            capdo = dt_ngaunhien.Rows[i]["capdo"].ToString();
            ngaytao = dt_ngaunhien.Rows[i]["ngaytao"].ToString();
            tinhtrang = dt_ngaunhien.Rows[i]["tinhtrang"].ToString();
            giangvien_idgiangvien = dt_ngaunhien.Rows[i]["giangvien_idgiangvien"].ToString();
            tengiangvien = dt_ngaunhien.Rows[i]["tengiangvien"].ToString();
            troncau = dt_ngaunhien.Rows[i]["troncau"].ToString();
            dt.Rows.Add(idnganhangcauhoi, monhoc_idmonhoc, tenmonhoc, tieude, chuong, phan, capdo, ngaytao, tinhtrang, giangvien_idgiangvien, tengiangvien, troncau);
                   
        }
        
        private void cmd_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmd_Taolai_Click(object sender, EventArgs e)
        {
            DialogResult tl = XtraMessageBox.Show("Bạn có muốn tạo lại? Những câu hỏi đã chọn sẽ bị mất", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (tl == DialogResult.OK)
            {
                grd_Dethi.DataSource = null;
                dt.Rows.Clear();
                dt_ngaunhien.Rows.Clear();
                lb_socauduocchon.Text = "0";
                trb_Socaungaunhien.Properties.Maximum = int.Parse(socau);
                trb_Socaungaunhien.Value = 1;
            }
            
        }
        /// <summary>
        /// Xoa du lieu trong 1 dong
        /// </summary>
        void Delete()
        {
            string id = gridView1.GetFocusedRowCellValue("idnganhangcauhoi").ToString();
            for (int i = 0; i < dt.Rows.Count; i++)
                if (dt.Rows[i]["idnganhangcauhoi"].ToString() == id)
                {
                    dt.Rows.RemoveAt(i);
                    lb_socauduocchon.Text = dt.Rows.Count.ToString();
                    trb_Socaungaunhien.Properties.Maximum = int.Parse(socau) - dt.Rows.Count;
                    break;
                }
            grd_Dethi.DataSource = dt;

        }
        private void grd_Dethi_Click(object sender, EventArgs e)
        {
           
        }
        string ListIdcauhoi()
        {
            string s = "";
            for (int i = 0; i < dt.Rows.Count; i++)
                s += dt.Rows[i]["idnganhangcauhoi"].ToString() + "|||" ;
            s = s.Substring(0, s.Length - 3);
            return s;
        }
        bool ValidInput()
        {
            if (txt_madethi.Text.Trim() == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập mã đề");
                txt_made.Focus();
                return false;
            }
            return true;
        }
        private void cmd_Save_Click(object sender, EventArgs e)
        {
            if(ValidInput())
            if (dt.Rows.Count == int.Parse(socau) )
            {
                C_DeThi dth = new C_DeThi();
                C_Time a = new C_Time();
                dth.Add(txt_madethi.Text, ListIdcauhoi(), idmonhoc, a.GetNowTime(), PreBase.obj_user.Idgiangvien);
                Close();
            }
            else
                XtraMessageBox.Show("Câu hỏi không đủ để tạo đề!");
        }

        private void grd_Dethi_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void txt_madethi_TextChanged(object sender, EventArgs e)
        {
            txt_madethi.Text = txt_madethi.Text.ToUpper();
        }
        void Viewer()
        {
            string id = gridView1.GetFocusedRowCellValue("idnganhangcauhoi").ToString();
            Component.frm_ViewerCauHoi frm = new Component.frm_ViewerCauHoi(id);
            frm.ShowDialog();
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                if (gridView1.FocusedColumn.FieldName == "xoa")
                    Delete();
                if (gridView1.FocusedColumn.FieldName == "view")
                    Viewer();
                
            }
            catch { }
        }

        private void cmd_Print_Click(object sender, EventArgs e)
        {
            Report.frm_ReportDeThi frm = new Report.frm_ReportDeThi(dt);
            frm.ShowDialog();
        }

    }
}