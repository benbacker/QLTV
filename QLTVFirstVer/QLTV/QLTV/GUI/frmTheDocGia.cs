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
        public int IDDocGia;
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
            dgv_DuLieu.Columns["cl_Pwd"].Visible = false;
        }

        private Form KiemTra(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    return f;
                }
            }
            return null;
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
                    IDDocGia = TDG_BUS.IdentityIDTDG();
                    HoTenDG = HelperGUI.Instance.KiemTraHoTen(tb_HoTenDG.Text);
                    DiaChiDG = tb_Diachi.Text;
                    EmailDG = tb_Email.Text;
                    NgaySinhDG = dt_Ngaysinh.Value;
                    NgayLapThe = dt_NgayLT.Value;
                    NgayHetHan = dt_NgayLT.Value;
                    UserName = tb_User.Text;
                    Pwd = tb_Passwork.Text;
                    IDLoaiDG = cb_LoaiDocGia.SelectedIndex + 1;
                    tdg.IDDocGia = IDDocGia;
                    tdg.HoTenDG = HoTenDG;
                    tdg.NgaySinhDG = NgaySinhDG;
                    tdg.DiaChiDG = DiaChiDG;
                    tdg.EmailDG = EmailDG;
                    tdg.IDLoaiDG = IDLoaiDG;
                    tdg.NgayLapThe = NgayLapThe;
                    tdg.NgayHetHan = NgayLapThe.AddMonths(6);
                    tdg.TongNo = 0;
                    user.IDDocGia = IDDocGia;
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
                tb_Passwork.Text = dgv_DuLieu.Rows[i].Cells["cl_Pwd"].Value.ToString(); ;
                bt_CNDL.Enabled = false;
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
                Pwd = tb_Passwork.Text;
                user.UserName = UserName;
                user.Password = Pwd;
                user.IDDocGia = int.Parse(IDDocGia);
                if (TDG_BUS.UpdateTheDocGia(tdg,user))
                {
                    MessageBox.Show("Sữa thông tin thành công!");
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

        private void toolStripBt_Muon_Click(object sender, EventArgs e)
        {
            Form frm = this.KiemTra(typeof(frmPhieuMuon));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {

                frmPhieuMuon f = new frmPhieuMuon();
                f.MdiParent = frmMain.ActiveForm;
                f.Dock = DockStyle.Fill;
                f.HoTenDG = dgv_DuLieu.CurrentRow.Cells["cl_HoTen"].Value.ToString();
                f.IDLoaiDG = Int32.Parse(dgv_DuLieu.CurrentRow.Cells["cl_ID"].Value.ToString());
                f.Show();
            }
        }

        private void toolStrip_Tra_Click(object sender, EventArgs e)
        {
            Form frm = this.KiemTra(typeof(frmPhieuTra));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {

                frmPhieuTra f = new frmPhieuTra();
                f.MdiParent = frmMain.ActiveForm;
                f.Dock = DockStyle.Fill;
                f.HoTenDG = dgv_DuLieu.CurrentRow.Cells["cl_HoTen"].Value.ToString();
                f.IDLoaiDG = Int32.Parse(dgv_DuLieu.CurrentRow.Cells["cl_ID"].Value.ToString());
                f.Show();
            }
        }

        private void toolStrip_PThu_Click(object sender, EventArgs e)
        {
            Form frm = this.KiemTra(typeof(frmPhieuThu));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {

                frmPhieuThu f = new frmPhieuThu();
                f.MdiParent = frmMain.ActiveForm;
                f.Dock = DockStyle.Fill;
                f.HoTenDG = dgv_DuLieu.CurrentRow.Cells["cl_HoTen"].Value.ToString();
                f.EmailDG = dgv_DuLieu.CurrentRow.Cells["cl_Email"].Value.ToString();
                f.DiaChiDG = dgv_DuLieu.CurrentRow.Cells["cl_DiaChi"].Value.ToString();
                f.TongNo = dgv_DuLieu.CurrentRow.Cells["cl_TongNo"].Value.ToString();
                f.IDLoaiDG = Int32.Parse(dgv_DuLieu.CurrentRow.Cells["cl_ID"].Value.ToString());
                f.Show();
            }
        }

        private void toolStripBt_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int i, ID;
                i = dgv_DuLieu.CurrentRow.Index;
                ID = Int32.Parse(dgv_DuLieu.CurrentRow.Cells["cl_ID"].Value.ToString());
                MessageBox.Show("Bạn có chắc chắn xóa không!!", "Thông báo!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                {
                    if(TDG_BUS.CheckTDGinPM(ID).Rows.Count == 0)
                    {
                        if (TDG_BUS.DeleteTheDocGia(ID))
                        {
                            MessageBox.Show("Xóa dữ liệu thất thành công!");
                            HelperGUI.ResetAllControls(groupControl_TTDG);
                            dgv_DuLieu.AutoGenerateColumns = false;
                            fillAllDataFromTableTheDocGia();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu độc giả đã tồn tại xóa thất bại!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đã tồn tại không thể xóa");
            }
        }
        #endregion
    }
}