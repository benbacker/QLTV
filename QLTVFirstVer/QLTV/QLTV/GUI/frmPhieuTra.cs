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
        List<int> IDCuonSach = new List<int>();
        public string TenSach { get; set; }
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

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
    }
}
