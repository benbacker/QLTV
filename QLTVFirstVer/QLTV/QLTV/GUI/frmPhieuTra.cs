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
using Desktop.BUS;
using Desktop.DTO;
using Desktop.GUI;

namespace Desktop.GUI
{
    public partial class frmPhieuTra : Form
    {
        public frmPhieuTra()
        {
            InitializeComponent();
        }
        PhieuTraBUS PhieuTra_BUS = new PhieuTraBUS();
        #region VaLue
        public string HoTenDG { set; get; }
        public int IDLoaiDG { set; get; }
        public int ID { set; get; }
        public int IDPhieuMuon { get; set; }
        public DateTime NgayTra;
        //List<int> Data = new List<int>();
        Dictionary<int, int> Data = new Dictionary<int, int>();
        public string TenSach { get; set; }
        public decimal SoTienTra =0;
        #endregion

        private void frmPhieuTra_Load(object sender, EventArgs e)
        {
            tb_TenNguoiTra.Text = HoTenDG;
            LoadSachTra();
            LoadPhieuTra();
        }
        #region fillAllDataFromTablePhieuTra
        public void LoadSachTra()
        {
            dgv_DuLieuTra.AutoGenerateColumns = false;
            dgv_DuLieuTra.DataSource = PhieuTra_BUS.LoadSachPhieuTra(IDLoaiDG);
            dgv_DuLieuTra.Columns["cl_IDPhieuMuon"].Visible = false;
        }

        public void LoadPhieuTra()
        {
            dgv_DuLieuPT.AutoGenerateColumns = false;
            dgv_DuLieuPT.DataSource = PhieuTra_BUS.LoadPhieuTra();
        }
        #endregion
        private void bt_CNDL_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tb_TenNguoiTra.Text)) { MessageBox.Show("Không được để trống họ tên người mượn.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_TenNguoiTra.Focus(); }
                else if (listbox_TenDauSach.Items.Count == 0) { MessageBox.Show("Không được để trống dữ liệu sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); listbox_TenDauSach.Focus(); }
                else
                {
                    PhieuTraDTO PT = new PhieuTraDTO();
                    PT.IDPhieuTra = PhieuTra_BUS.IdentityID();
                    PT.IDDocGia = IDLoaiDG;
                    NgayTra = dt_NgayTra.Value;
                    PT.NgayTra = NgayTra;
                    PT.TienPhatKyNay = 0;
                    PT.SoTienTra = 0;
                    PT.TienNoKyNay = 0;
                    PT.SoNgayMuon = 0;
                    PT.TienPhat = 0;
                    if (PhieuTra_BUS.InsertPhieuTra(PT))
                    {
                        foreach (KeyValuePair<int, int> item in Data)
                        {
                            PT.IDCTPhieuTra = PhieuTra_BUS.IdentityIDCTPhieuTra();
                            PT.IDCuonSach = item.Key;
                            PT.IDPhieuMuon = item.Value;
                            PhieuTra_BUS.InsertCTPhieuTra(PT);
                        }
                        MessageBox.Show("Cập nhật thành công!");
                        LoadSachTra();
                        LoadPhieuTra();
                        listbox_TenDauSach.Items.Clear();
                        Data.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_ChonSachVaoList_Click(object sender, EventArgs e)
        {
            ID = int.Parse(dgv_DuLieuTra.CurrentRow.Cells["cl_IDCuonSach"].Value.ToString());
            IDPhieuMuon = int.Parse(dgv_DuLieuTra.CurrentRow.Cells["cl_IDPhieuMuon"].Value.ToString());
            TenSach = dgv_DuLieuTra.CurrentRow.Cells["cl_TenCuonSach"].Value.ToString();
            if (Data.ContainsKey(ID))
            {
                MessageBox.Show("Dữ liệu đã tồn tại");
            }
            else
            {
                Data.Add(ID, IDPhieuMuon);
                listbox_TenDauSach.Items.Add(TenSach);
            }
        }

        private void bt_Lamlai_Click(object sender, EventArgs e)
        {
            listbox_TenDauSach.Items.Clear();
            Data.Clear();
        }

        private void btn_XoaListSach_Click(object sender, EventArgs e)
        {
            Data.Remove(listbox_TenDauSach.SelectedIndex);
            listbox_TenDauSach.Items.RemoveAt(listbox_TenDauSach.SelectedIndex);
        }

        private void toolStripBt_XuatCSV_Click(object sender, EventArgs e)
        {
            HelperGUI.Instance.ExportExcel(dgv_DuLieuPT);
        }

        private void toolStripBt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
