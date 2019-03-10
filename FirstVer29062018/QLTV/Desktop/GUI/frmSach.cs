using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop.HelperUI;
using System.Text.RegularExpressions;
using Data.DAO;
using Service.ABSTRACT;
using Data.Dtos;
using Data.DTO;

namespace Desktop.GUI
{
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
        }

        #region Value
        public int IDSach;
        public int IDTacGia;
        public int IDDauSach;
        public DateTime NgayNhap;
        public string TenDauSach;
        public string NhaXB;
        string TenLoaiSach;
        string TenTG;
        public int NamXB;
        public int SoLuong;
        public decimal GiaTien;
        public decimal DonGia;
        public decimal TongTien;
        #endregion
        #region Event KeyPress
        private void tb_TenDauSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckKiTu(sender, e);
        }
        private void tb_NhaXuatBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckKiTu(sender, e);
        }
        private void tb_TenTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckKiTu(sender, e);
        }
        private void tb_SoLuongTon_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckInt(sender, e);
        }
        private void tb_GiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckInt(sender, e);
        }
        private void tb_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckInt(sender, e);
        }
        private void tb_DonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckInt(sender, e);
        }
        private void tb_ThanhTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckInt(sender, e);
        }

        #endregion
        #region Event Click
        private void btn_ThemLoaiSach_Click(object sender, EventArgs e)
        {
            FrmThemLoaiSach frm = new FrmThemLoaiSach();
            frm.ShowDialog();
        }
        private void bt_Lamlai_Click(object sender, EventArgs e)
        {
            HelperGUI.ResetAllControls(groupControl_TTS);
        }
        private void bt_CNDL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_TenDauSach.Text)) { MessageBox.Show("Không được để trống tên đầu sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_TenDauSach.Focus(); }
            else if (string.IsNullOrEmpty(cbb_TheLoaiSach.Text)) { MessageBox.Show("Không được để trống thể loại sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbb_TheLoaiSach.Focus(); }
            else if (string.IsNullOrEmpty(tb_TenTacGia.Text)) { MessageBox.Show("Không được để trống tên tác giả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_TenTacGia.Focus(); }
            else if (string.IsNullOrEmpty(tb_NhaXuatBan.Text)) { MessageBox.Show("Không được để trống nhà xuất bản.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_NhaXuatBan.Focus(); }
            else if (string.IsNullOrEmpty(tb_NamXuatBan.Text)) { MessageBox.Show("Không được để trống năm xuất bản.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_NamXuatBan.Focus(); }
            else if (string.IsNullOrEmpty(tb_GiaTien.Text)) { MessageBox.Show("Không được để trống giá tiền", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_GiaTien.Focus(); }
            else if (string.IsNullOrEmpty(tb_SoLuong.Text)) { MessageBox.Show("Không được để trống số lượng.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_SoLuong.Focus(); }
            else if (string.IsNullOrEmpty(tb_DonGia.Text)) { MessageBox.Show("Không được để trống đơn giá.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_DonGia.Focus(); }
            else
            {
                try
                {
                    SachService sv = new SachService();
                    SachDTO s = new SachDTO();

                    TenDauSach = tb_TenDauSach.Text;
                    TenLoaiSach = cbb_TheLoaiSach.Text;
                    TenTG = tb_TenTacGia.Text;
                    NhaXB = tb_NhaXuatBan.Text;
                    NamXB = Int32.Parse(tb_NamXuatBan.Text);
                    GiaTien = HelperGUI.Instance.checkMoney(GiaTien, tb_GiaTien);
                    SoLuong = Int32.Parse(tb_SoLuong.Text);
                    DonGia = HelperGUI.Instance.checkMoney(DonGia, tb_DonGia);
                    NgayNhap = dt_NgayNhap.Value;
                    s.IDTacGia =IDTacGia;
                    s.IDSach = IDSach;
                    s.TenTG = TenTG;
                    s.IDDauSach = IDDauSach;
                    s.NamXB = NamXB;
                    s.NhaXB = NhaXB;
                    s.GiaTien = GiaTien;
                    s.DonGia = DonGia;
                    s.SoLuong = SoLuong;
                    s.TenDauSach = TenDauSach;
                    s.TenLoaiSach = TenLoaiSach;
                    s.NgayNhap = NgayNhap;
                    sv.ADDFormSach(s);
                    MessageBox.Show("Thêm thành công!");
                    fillTheLoaiSachDataFromTableSach();
                    HelperGUI.ResetAllControls(groupControl_TTS);
                }
                catch
                {

                }
            }
        }
        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            SachService svSach = new SachService();
            List<SachDTO> lsSach = new List<SachDTO>();
            if(cbb_ThongTinTimKiem.Text== "Tên sách")
            {
                lsSach = svSach.getFormSachNhaXuatBan(tb_NhapTT.Text);
                dgv_DuLieuSach.DataSource = lsSach;
            }
            else if (cbb_ThongTinTimKiem . Text == "Năm xuất bản")
            {
                lsSach = svSach.getFormSachNamXuatBan(tb_NhapTT.Text);
                dgv_DuLieuSach.DataSource = lsSach;
            }
            else if (cbb_ThongTinTimKiem.Text== "Tên sách")
            {
                lsSach = svSach.getFormSachTenDauSach(tb_NhapTT.Text);
                dgv_DuLieuSach.DataSource = lsSach;
            }
        }
        private void toolStripBt_XuatCSV_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "csv File (.csv)|.csv|All files (.)|*.*";
                    sfd.Title = "Save an Excel File";
                    sfd.ShowDialog();

                    string DuongDan;
                    DuongDan = sfd.FileName;
                    List<TacGiaDtos> ls = new List<TacGiaDtos>();
                    TacGiaService pro = new TacGiaService();
                    ls = pro.getAllFormTacGia();
                    DialogResult dlg = MessageBox.Show("Bạn có chắc chắn xuất CSV!!", "Thông báo!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dlg.Equals(DialogResult.OK))
                    {
                        pro.ExportToCsvFile(ls, DuongDan);
                        MessageBox.Show("Xuất thành công!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch
            {

            }
        }
        #endregion
        #region Load Data to Combobox
        //get Thể Loại Sáchd Database
        public void LoadDateCombobox()
        {
            List<string> TenTheLoai = new List<string>();
            TenTheLoai = GetDataDAO.Instance.getListTenTheLoaiSach();
            cbb_TheLoaiSach.DataSource = TenTheLoai;
        }
        #endregion
        #region Autocomplete
        public void AutocompleteTenTG()
        {
            HelperGUI.Instance.autocompleteTenTacGia(tb_TenTacGia);
        }
        public void AutocompleteNhaSX()
        {
            HelperGUI.Instance.autocompleteNhaXuatBan(tb_NhaXuatBan);
        }
        #endregion
        #region Load Du Lieu
        private void frmSach_Load(object sender, EventArgs e)
        {
            dgv_DuLieuSach.AutoGenerateColumns = false;
            fillTheLoaiSachDataFromTableSach();
            LoadDateCombobox();
            AutocompleteTenTG();
            AutocompleteNhaSX();
        }

        #endregion
        #region Datimepicker changed
        private void dt_NgayNhap_ValueChanged(object sender, EventArgs e)
        {
            NgayNhap = dt_NgayNhap.Value;
        }
        #endregion
        #region LoadDataGV
        public void fillTheLoaiSachDataFromTableSach()
        {
            List<SachDTO> ls = new List<SachDTO>();
            SachService TDGsv = new SachService();
            ls = TDGsv.getAllFormDauSachandCTPhieuNhapAndSach();
            dgv_DuLieuSach.DataSource = ls;
        }
        #endregion

       
    }
}
