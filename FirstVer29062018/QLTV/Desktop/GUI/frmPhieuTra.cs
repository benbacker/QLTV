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
using Data.DTO;
using Data.DAO;
using Data.Dtos;
using Service.ABSTRACT;

namespace Desktop.GUI
{
    public partial class frmPhieuTra : Form
    {
        public frmPhieuTra()
        {
            InitializeComponent();
        }
        #region VaLue
        public string HoTenDG { set; get; }
        public int IDLoaiDG { set; get; }
        public int ID { set; get; }
        public int IDPhieuMuon { get; set; }
        public DateTime NgayTra;
        List<int> IDCuonSach = new List<int>();
        public string TenSach { get; set; }
        #endregion
        #region Load DateGridview
        private void frmPhieuTra_Load(object sender, EventArgs e)
        {
            dgv_DuLieuPT.AutoGenerateColumns = false;
            tb_TenNguoiMuon.Text = HoTenDG;
            int IDGiuBien = IDLoaiDG;
            fillPhieuTra();
        }
        #endregion
        #region Event Click
        private void bt_CNDL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_TenNguoiMuon.Text)) { MessageBox.Show("Không được để trống họ tên người mượn.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_TenNguoiMuon.Focus(); }
            else
            {
                try
                {
                    if (string.IsNullOrEmpty(tb_TenNguoiMuon.Text)) { MessageBox.Show("Không được để trống họ tên người mượn.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_TenNguoiMuon.Focus(); }
                    else if (listbox_TenDauSach.Items.Count == 0) { MessageBox.Show("Không được để trống dữ liệu sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); listbox_TenDauSach.Focus(); }
                    else
                    {
                        PhieuTraService PTSv = new PhieuTraService();
                        PhieuTraDtos ls = new PhieuTraDtos();
                        HoTenDG = tb_TenNguoiMuon.Text;
                        NgayTra = dt_NgayTra.Value;
                        ls.NgayTra = NgayTra;
                        ls.TenDG = HoTenDG;
                       
                        PTSv.AddFormPhieuTra(ls, IDCuonSach);
                        MessageBox.Show("Thêm thành công");
                        fillPhieuTra();
                        listbox_TenDauSach.Items.Clear();
                    }
                }
                catch
                {

                }
            }
        }
        private void bt_Lamlai_Click(object sender, EventArgs e)
        {
            HelperGUI.ResetAllControls(groupControl_TTPT);
            listbox_TenDauSach.Items.Clear();
        }
        private void tb_TenNguoiMuon_TextChanged(object sender, EventArgs e)
        {
            List<CuonSachDtos> cuonsach = new List<CuonSachDtos>();
            cuonsach = GetDataDAO.Instance.getListCuonSachDtos(tb_TenNguoiMuon.Text);
            dgv_DuLieuTra.DataSource = cuonsach;
        }
        private void btn_ChonSachVaoList_Click(object sender, EventArgs e)
        {
            ID = Int32.Parse(dgv_DuLieuTra.CurrentRow.Cells["cl_IDCuonSach"].Value.ToString());
            IDCuonSach.Add(ID);
            TenSach = dgv_DuLieuTra.CurrentRow.Cells["cl_TenCuonSach"].Value.ToString();
            if (listbox_TenDauSach.Items.Contains(TenSach))
            {
                MessageBox.Show("Dữ liệu đã tồn tại");
            }
            else
            {
                listbox_TenDauSach.Items.Add(TenSach);
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
        #region DatetimepickerChanged
        private void dt_NgayTra_ValueChanged(object sender, EventArgs e)
        {
            NgayTra = dt_NgayTra.Value;
        }
        #endregion
        #region Load Du Lieu
        public void fillPhieuTra()
        {
            List<CTPhieuTraDTO> ls = new List<CTPhieuTraDTO>();
            PhieuTraService PTSv = new PhieuTraService();
            ls = PTSv.getALlFormPhieuTraAndCTPhieuTra();
            dgv_DuLieuPT.DataSource = ls;
        }
        #endregion
    }
}
