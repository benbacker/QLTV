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
using Data.DAO;
using Data.BUS;
using Data.DTO;
using Data.Dtos;
using Service.ABSTRACT;

namespace Desktop.GUI
{
    public partial class frmPhieuMuon : Form
    {
        public frmPhieuMuon()
        {
            InitializeComponent();
        }
        #region Value
        public string HoTenDG { set; get; }
        public int IDLoaiDG { set; get; }
        public string TenDauSach;
        public string TenTacGia;
        public int ID { set; get; }
        public DateTime NgayMuon;
        List<int> IDCuonSach = new List<int>();
        public string TenSach { get; set; }
        #endregion
        #region Event KeyPress 
        private void tb_TenTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckKiTu(sender, e);
        }
        private void tb_PhieuMuon_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckKiTu(sender, e);
        }
        #endregion
        #region Event Click    
        private void bt_CNDL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_TenNguoiMuon.Text)) { MessageBox.Show("Không được để trống họ tên người mượn.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_TenNguoiMuon.Focus(); }
            else if (string.IsNullOrEmpty(tb_TenDauSach.Text)) { MessageBox.Show("Không được để trống tên đầu sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_TenDauSach.Focus(); }
            else if (string.IsNullOrEmpty(cbb_TenTacGia.Text)) { MessageBox.Show("Không được để trống tên tác giả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbb_TenTacGia.Focus(); }
            else if (listbox_TenDauSach.Items.Count==0) { MessageBox.Show("Không được để trống dữ liệu sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); listbox_TenDauSach.Focus(); }
            else
            {
                try
                {
                    PhieuMuonService Sv = new PhieuMuonService();
                    PhieuMuonDtos PM = new PhieuMuonDtos();
                    HoTenDG = HelperGUI.Instance.KiemTraHoTen(tb_TenNguoiMuon.Text);
                    NgayMuon = dt_NgayMuon.Value;
                    TenDauSach = tb_TenDauSach.Text;
                    PM.NgayMuon = NgayMuon;
                    PM.TenDocGia = HoTenDG;
                    Sv.addFormPhieuMuonAndCTPhieuMuon(PM, IDCuonSach);
                    MessageBox.Show("Thêm thành công");
                    fillTheLoaiSachDataFromTableSach();
                    listbox_TenDauSach.Items.Clear(); 
                }
                catch
                {

                }
            }
        }
        private void bt_Lamlai_Click(object sender, EventArgs e)
        {
            HelperGUI.ResetAllControls(groupControl_TTPM);
            listbox_TenDauSach.Items.Clear();
        }
        private void btn_TimSach_Click(object sender, EventArgs e)
        {
            TenDauSach = tb_TenDauSach.Text;
            TenTacGia = cbb_TenTacGia.Text;
            fillTenSach();
        }
        private void btn_ChonSachVaoList_Click(object sender, EventArgs e)
        {
            ID = Int32.Parse(dgv_DuLieuTT.CurrentRow.Cells["cl_IDCuonSach"].Value.ToString());
            IDCuonSach.Add(ID);
            TenDauSach = dgv_DuLieuTT.CurrentRow.Cells["cl_DS"].Value.ToString();
            if (listbox_TenDauSach.Items.Contains(TenDauSach))
            {
                MessageBox.Show("Dữ liệu đã tồn tại");
            }
            else
            {
                listbox_TenDauSach.Items.Add(TenDauSach);
            }
        }
        private void btn_XoaSachRaKhoiList_Click(object sender, EventArgs e)
        {
            listbox_TenDauSach.Items.RemoveAt(listbox_TenDauSach.SelectedIndex);
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
        #region getValueChanged Datetimepicker  
        private void dt_NgaySinh_ValueChanged(object sender, EventArgs e)
        {
            NgayMuon = dt_NgayMuon.Value;
        }

        #endregion
        #region Load Du Lieu
        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            dgv_DuLieuTT.AutoGenerateColumns = false;
            dgv_DuLieuPM.AutoGenerateColumns = false;
            tb_TenNguoiMuon.Text = HoTenDG;
            int IDGiuBien = IDLoaiDG;
            AutocompleteTenSach();
            fillTheLoaiSachDataFromTableSach();
            fillTenSach();
        }
        #endregion
        #region Autocomplete
        public void AutocompleteTenSach()
        {
            HelperGUI.Instance.autocompleteTenDauSach(tb_TenDauSach);
        }
        private void tb_TenDauSach_TextChanged(object sender, EventArgs e)
        {
            List<string> TenTacGia = new List<string>();
            TenTacGia = GetDataDAO.Instance.getListTenTacGiaToTenDauSach(tb_TenDauSach.Text);
            cbb_TenTacGia.DataSource = TenTacGia;
        }
        #endregion
        #region LoadDataGView
        public void fillTheLoaiSachDataFromTableSach()
        {
            List<PhieuMuonDTO> ls = new List<PhieuMuonDTO>();
            PhieuMuonService PMsv = new PhieuMuonService();
            ls = PMsv.getAllFormPhieuMuonAndCTPhieuMuon();
            dgv_DuLieuPM.DataSource = ls;
        }
        public void fillTenSach()
        {
            List<CuonSachDTO> list = new List<CuonSachDTO>();
            list = GetDataDAO.Instance.getList(TenDauSach, TenTacGia);
            dgv_DuLieuTT.DataSource = list;
        }
        #endregion
    }
}

