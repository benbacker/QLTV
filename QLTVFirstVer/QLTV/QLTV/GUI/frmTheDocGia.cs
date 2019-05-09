using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Desktop.HelperUI;
using System.Text.RegularExpressions;
using Desktop.BUS;
using Desktop.DTO;
using Desktop.DAO;
using System.IO;
using System.Text.RegularExpressions;
using app = Microsoft.Office.Interop.Excel.Application;

namespace Desktop.GUI
{
    public partial class frmTheDocGia : DevExpress.XtraEditors.XtraForm
    {
        public frmTheDocGia()
        {
            InitializeComponent();
        }
        TheDocGiaBUS TDG_BUS = new TheDocGiaBUS();
        #region Value
        //Ghi lại tất cả thuộc tính thể hiện trên frm
        public string HoTenDG;
        public string UserName;
        public string Pwd;
        public DateTime NgaySinhDG;
        public string DiaChiDG;
        public string EmailDG;
        public int IDLoaiDG;
        public DateTime NgayLapThe;
        public DateTime NgayHetHan;
        #endregion
        #region FrmLoad
        private void frmTheDocGia_Load(object sender, EventArgs e)
        {
            dgv_DuLieu.AutoGenerateColumns = false;
            fillAllDataFromTableTheDocGia();
        }
        #endregion
        #region fillAllDataFromTable
        public void fillAllDataFromTableTheDocGia()
        {
            dgv_DuLieu.AutoGenerateColumns = false;
            dgv_DuLieu.DataSource = TDG_BUS.LoadTheDocGia();
        }
        #endregion
        #region Click
        private void bt_CNDL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_HoTenDG.Text)) { MessageBox.Show("Không được để trống họ tên độc giả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_HoTenDG.Focus(); }
            else if (string.IsNullOrEmpty(tb_User.Text)) { MessageBox.Show("Không được để trống Tài khoản.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_User.Focus(); }
            else if (string.IsNullOrEmpty(tb_Passwork.Text)) { MessageBox.Show("Không được để trống Passwork.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_Passwork.Focus(); }
            else if (string.IsNullOrEmpty(tb_Diachi.Text)) { MessageBox.Show("Không được để trống địa chỉ.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_Diachi.Focus(); }
            else if (string.IsNullOrEmpty(tb_Email.Text)) { MessageBox.Show("Không được để trống Email.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_Email.Focus(); }
            else if (HelperGUI.Instance.checkIsMail(tb_Email) == false) { MessageBox.Show("Email không hợp lệ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_Email.Focus(); }
            else if (string.IsNullOrEmpty(cb_LoaiDocGia.Text)) { MessageBox.Show("Không được để trống loại độc giả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); cb_LoaiDocGia.Focus(); }
            else
            {
                try
                {
                    UserDTO user = new UserDTO();
                    TheDocGiaDTO tdg = new TheDocGiaDTO();
                    HoTenDG = HelperGUI.Instance.KiemTraHoTen(tb_HoTenDG.Text);
                    DiaChiDG = tb_Diachi.Text;
                    EmailDG = tb_Email.Text;
                    NgaySinhDG = dt_Ngaysinh.Value;
                    NgayLapThe = dt_NgayLT.Value;
                    NgayHetHan = dt_NgayLT.Value;
                    UserName = tb_User.Text;
                    Pwd = tb_Passwork.Text;
                    IDLoaiDG = cb_LoaiDocGia.SelectedIndex + 1;
                    tdg.HoTenDG = HoTenDG;
                    tdg.NgaySinhDG = NgaySinhDG;
                    tdg.DiaChiDG = DiaChiDG;
                    tdg.EmailDG = EmailDG;
                    tdg.IDLoaiDG = IDLoaiDG;
                    tdg.NgayLapThe = NgayLapThe;
                    tdg.NgayHetHan = NgayLapThe.AddMonths(6);
                    tdg.TongNo = 0;
                    user.Password = Pwd;
                    user.UserName = UserName;
                    if (TDG_BUS.InsertTheDocGia(tdg) && TDG_BUS.InsertUser(user))
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công");
                        HelperGUI.ResetAllControls(groupControl_TTDG);
                        dgv_DuLieu.AutoGenerateColumns = false;
                        fillAllDataFromTableTheDocGia();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi: Xin kiểm tra tuổi khách hàng từ " + TDG_BUS.GetTuoimin() + " đến "+TDG_BUS.GetTuoimax()+" tuổi!");
                    }
                }
                catch
                {
                    
                }
            }
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            string SearchTT="";
            if (cbb_ThongTinTimKiem.Text=="Họ và tên")
            {
                SearchTT = "HoTenDG";
                dgv_DuLieu.DataSource = TDG_BUS.SearchTheDocGia(SearchTT,tb_NhapTT.Text.Trim());
            }
            else if (cbb_ThongTinTimKiem.Text == "Email")
            {
                SearchTT = "EmailDG";
                dgv_DuLieu.DataSource = TDG_BUS.SearchTheDocGia(SearchTT, tb_NhapTT.Text.Trim());
            }
            else if (cbb_ThongTinTimKiem.Text == "Địa chỉ")
            {
                SearchTT = "DiaChiDG";
                dgv_DuLieu.DataSource = TDG_BUS.SearchTheDocGia(SearchTT, tb_NhapTT.Text.Trim());
            }
            else if (cbb_ThongTinTimKiem.Text == "Tài khoản")
            {
                SearchTT = "UserName";
                dgv_DuLieu.DataSource = TDG_BUS.SearchTheDocGia(SearchTT, tb_NhapTT.Text.Trim());
            }
        }

        private void dgv_DuLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i;
                i = dgv_DuLieu.CurrentRow.Index;
                tb_HoTenDG.Text = dgv_DuLieu.Rows[i].Cells["cl_HoTen"].Value.ToString();
                tb_User.Text = dgv_DuLieu.Rows[i].Cells["cl_User"].Value.ToString();
                tb_Email.Text = dgv_DuLieu.Rows[i].Cells["cl_Email"].Value.ToString();
                tb_Diachi.Text = dgv_DuLieu.Rows[i].Cells["cl_DiaChi"].Value.ToString();
                cb_LoaiDocGia.SelectedItem = dgv_DuLieu.Rows[i].Cells["cl_TenLoaiDG"].Value.ToString();
                dt_NgayLT.Value = DateTime.Parse(dgv_DuLieu.Rows[i].Cells["cl_NgayLapThe"].Value.ToString());
                dt_Ngaysinh.Value = DateTime.Parse(dgv_DuLieu.Rows[i].Cells["cl_Ngaysinh"].Value.ToString());
                bt_CNDL.Enabled = false;
                tb_Passwork.Enabled = false;
            }
            catch
            {
                e.ToString();
            }
        }

        private void bt_Lamlai_Click(object sender, EventArgs e)
        {
            HelperGUI.ResetAllControls(groupControl_TTDG);
            bt_CNDL.Enabled = true;
        }

        private void toolStripBt_SuaTT_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                i = dgv_DuLieu.CurrentCell.RowIndex;
                TheDocGiaDTO tdg = new TheDocGiaDTO();
                HoTenDG = HelperGUI.Instance.KiemTraHoTen(tb_HoTenDG.Text);
                DiaChiDG = tb_Diachi.Text;
                EmailDG = tb_Email.Text;
                NgaySinhDG = dt_Ngaysinh.Value;
                NgayLapThe = dt_NgayLT.Value;
                NgayHetHan = dt_NgayLT.Value;
                IDLoaiDG = cb_LoaiDocGia.SelectedIndex + 1;
                string IDDocGia = dgv_DuLieu.Rows[i].Cells["cl_ID"].Value.ToString();
                tdg.HoTenDG = HoTenDG;
                tdg.DiaChiDG = DiaChiDG;
                tdg.EmailDG = EmailDG;
                tdg.NgaySinhDG = NgaySinhDG;
                tdg.NgayLapThe = NgayLapThe;
                tdg.NgayHetHan = NgayHetHan.AddMonths(6);
                tdg.IDLoaiDG = IDLoaiDG;
                tdg.IDDocGia = int.Parse(IDDocGia);
                UserDTO user = new UserDTO();
                UserName = tb_User.Text;
                user.UserName = UserName;
                user.IDDocGia = int.Parse(IDDocGia);
                if (TDG_BUS.UpdateTheDocGia(tdg,user))
                {
                    MessageBox.Show("yes");
                    HelperGUI.ResetAllControls(groupControl_TTDG);
                    dgv_DuLieu.AutoGenerateColumns = false;
                    fillAllDataFromTableTheDocGia();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void toolStripBt_Reset_Click(object sender, EventArgs e)
        {
            fillAllDataFromTableTheDocGia();
            HelperGUI.ResetAllControls(groupControl_TTDG);
            bt_CNDL.Enabled = true;
        }

        private void toolStripBt_XuatCSV_Click(object sender, EventArgs e)
        {
            HelperGUI.Instance.ExportExcel(dgv_DuLieu);
        }

        private void toolStripBt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void toolStripBt_Muon_Click(object sender, EventArgs e)
        {
            frmPhieuMuon frm = new frmPhieuMuon();
            frm.HoTenDG = dgv_DuLieu.CurrentRow.Cells["cl_HoTen"].Value.ToString();
            frm.IDLoaiDG = Int32.Parse(dgv_DuLieu.CurrentRow.Cells["cl_ID"].Value.ToString());
            frm.Show();
        }

        private void toolStrip_Tra_Click(object sender, EventArgs e)
        {
            frmPhieuTra frm = new frmPhieuTra();
            frm.HoTenDG = dgv_DuLieu.CurrentRow.Cells["cl_HoTen"].Value.ToString();
            frm.IDLoaiDG = Int32.Parse(dgv_DuLieu.CurrentRow.Cells["cl_ID"].Value.ToString());
            frm.Show();
        }
    }
}