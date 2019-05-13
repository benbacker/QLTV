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
using Desktop.HelperUI;
namespace Desktop.GUI
{
    public partial class frmPhieuMuon : Form
    {
        public frmPhieuMuon()
        {
            InitializeComponent();
        }
        PhieuMuonBUS PhieuMuon_BUS = new PhieuMuonBUS();
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
        #region FrmLoad
        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            tb_TenNguoiMuon.Text = HoTenDG;
            AutocompleteTenSach();
            AutoTextboxTenDocGia();
            LoadPhieuMuon();
        }
        #endregion
        #region fillAllDataFromTablePhieuMuon
        public void LoadCuonSachMuon()
        {
            dgv_DuLieuTT.AutoGenerateColumns = false;
            dgv_DuLieuTT.DataSource = PhieuMuon_BUS.LoadSachPhieuMuon(tb_TenDauSach.Text.Trim());
        }
        public void LoadPhieuMuon()
        {
            dgv_DuLieuPM.AutoGenerateColumns = false;
            dgv_DuLieuPM.DataSource = PhieuMuon_BUS.LoadPhieuMuon();
        }
        #endregion
        #region Autocomplete
        public void AutocompleteTenSach()
        {
            string Query = "Select * from DauSach";
            string column = "TenDauSach";
            tb_TenDauSach.AutoCompleteCustomSource = PhieuMuon_BUS.AutoTextBox(Query, column);
        }

        public void AutocomboboxTenTacGia()
        {
            cbb_TenTacGia.DisplayMember = "TenTacGia";
            cbb_TenTacGia.DataSource = PhieuMuon_BUS.autocombobox(tb_TenDauSach.Text.Trim());
        }

        public void AutoTextboxTenDocGia()
        {

            string Query = "Select * from THEDOCGIA";
            string column = "HoTenDG";
            tb_TenNguoiMuon.AutoCompleteCustomSource = PhieuMuon_BUS.AutoTextBox(Query,column);
        }
        #endregion
        #region EventTextChanged
        private void tb_TenDauSach_TextChanged(object sender, EventArgs e)
        {
            AutocomboboxTenTacGia();
        }
        #endregion
        #region Click
        private void btn_TimSach_Click(object sender, EventArgs e)
        {
            LoadCuonSachMuon();
        }

        private void btn_ChonSachVaoList_Click(object sender, EventArgs e)
        {
            ID = Int32.Parse(dgv_DuLieuTT.CurrentRow.Cells["cl_IDCuonSach"].Value.ToString());
            TenDauSach = dgv_DuLieuTT.CurrentRow.Cells["cl_DS"].Value.ToString();
            if (IDCuonSach.Contains(ID))
            {
                MessageBox.Show("Dữ liệu đã tồn tại");
            }
            else
            {
                IDCuonSach.Add(ID);
                listbox_TenDauSach.Items.Add(TenDauSach);
            }
        }

        private void btn_XoaSachRaKhoiList_Click(object sender, EventArgs e)
        {
            IDCuonSach.RemoveAt(listbox_TenDauSach.SelectedIndex);
            listbox_TenDauSach.Items.RemoveAt(listbox_TenDauSach.SelectedIndex);
        }

        private void bt_CNDL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_TenNguoiMuon.Text)) { MessageBox.Show("Không được để trống họ tên người mượn.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_TenNguoiMuon.Focus(); }
            else if (string.IsNullOrEmpty(tb_TenDauSach.Text)) { MessageBox.Show("Không được để trống tên đầu sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_TenDauSach.Focus(); }
            else if (string.IsNullOrEmpty(cbb_TenTacGia.Text)) { MessageBox.Show("Không được để trống tên tác giả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); cbb_TenTacGia.Focus(); }
            else if (listbox_TenDauSach.Items.Count == 0) { MessageBox.Show("Không được để trống dữ liệu sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); listbox_TenDauSach.Focus(); }
            else
            {
                try
                {
                    PhieuMuonDTO PM = new PhieuMuonDTO();
                    NgayMuon = dt_NgayMuon.Value;
                    PM.IDPhieuMuon = PhieuMuon_BUS.IdentityIDPhieuMuon();
                    PM.IDDocGia = IDLoaiDG;
                    PM.NgayMuon = NgayMuon;
                    PM.HanTra = NgayMuon.AddDays(5);
                    PM.IDCuonSach = IDCuonSach[0];
                    PM.IDCTPhieuMuon = PhieuMuon_BUS.IdentityIDCTPhieuMuon();
                    if (PhieuMuon_BUS.InsertPhieuMuon(PM)  && PhieuMuon_BUS.InsertCTPhieuMuon(PM))
                    {
                        foreach (int item in IDCuonSach)
                        {
                            PM.IDCTPhieuMuon = PhieuMuon_BUS.IdentityIDCTPhieuMuon();
                            PM.IDCuonSach = item;
                            PhieuMuon_BUS.InsertCTPhieuMuon(PM);
                        }
                        //for (int i = 1; i < IDCuonSach.Count; i++)
                        //{
                        //    PM.IDCuonSach = IDCuonSach[i];
                        //    PhieuMuon_BUS.InsertCTPhieuMuon(PM);
                        //}
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
                        LoadCuonSachMuon();
                        LoadPhieuMuon();
                        listbox_TenDauSach.Items.Clear();
                        IDCuonSach.Clear();
                    }
                    else
                    {
                        listbox_TenDauSach.Items.Clear();
                        IDCuonSach.Clear();
                        PhieuMuon_BUS.DeleteCTPhieuMuon(PM);
                        MessageBox.Show("Cập nhật dữ liệu thất bại");
                    }
                }   
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void toolStripBt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripBt_Reset_Click(object sender, EventArgs e)
        {
            LoadPhieuMuon();
        }

        private void toolStripBt_XuatCSV_Click(object sender, EventArgs e)
        {
            HelperGUI.Instance.ExportExcel(dgv_DuLieuPM);
        }
        #endregion
    }
}

