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
using Desktop.DAO;
using Desktop.BUS;
using Desktop.DTO;

namespace Desktop.GUI
{
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
        }
        SachBUS Sach_BUS = new SachBUS();
        #region Value
        public int IDSach;
        public int IDTacGia;
        public int IDDauSach;
        public string NhaXB;
        public int NamXB;
        public int SoLuong;
        public decimal GiaTien;
        public int IDCuonSach;
        public int IDLoaiSach;
        public string TenDauSach;

        public DateTime NgayNhap;

        public int IDCTPhieuNhap;
        public int IDPhieuNhap;

        public decimal DonGia;
        public decimal TongTien;
        #endregion
        #region fillAllDataFromTableSach
        public void fillAllDataFromTableSach()
        {
            dgv_DuLieuSach.AutoGenerateColumns = false;
            dgv_DuLieuSach.DataSource = Sach_BUS.LoadSach();
        }
        #endregion
        #region Autocombobox
        public void AutocomboboxTheLoaiSach()
        {
            cbb_TheLoaiSach.DisplayMember = "TenLoaiSach";
            cbb_TheLoaiSach.DataSource = Sach_BUS.autocombobox();
        }
        #endregion
        #region Autotextbox
        public void AutotextboxTenTacGia()
        {
            string Query = "Select * from TacGia";
            string column = "TenTacGia";
            tb_TenTacGia.AutoCompleteCustomSource = Sach_BUS.AutoTextBox(Query,column);
        }

        public void AutoTextBoxNhaXB()
        {
            string Query = "Select * from Sach";
            string column = "NhaXB";
            tb_NhaXuatBan.AutoCompleteCustomSource = Sach_BUS.AutoTextBox(Query,column);
        }
        #endregion
        #region LoadSach
        private void frmSach_Load(object sender, EventArgs e)
        {
            fillAllDataFromTableSach();
            AutocomboboxTheLoaiSach();
            AutotextboxTenTacGia();
            AutoTextBoxNhaXB();
            cbb_TheLoaiSach.SelectedIndex = -1;
        }
        #endregion
        #region Click
        private void toolStripBt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripBt_Reset_Click(object sender, EventArgs e)
        {
            fillAllDataFromTableSach();
            AutocomboboxTheLoaiSach();
            AutotextboxTenTacGia();
            AutoTextBoxNhaXB();
        }

        private void btn_ThemLoaiSach_Click(object sender, EventArgs e)
        {
            Form fsf = Application.OpenForms["FrmThemLoaiSach"];

            if (fsf != null)
            {
                fsf.WindowState = FormWindowState.Normal;
                fsf.Show();
                fsf.TopMost = true;
            }
            else
            {
                Form formSubForm = new FrmThemLoaiSach();
                formSubForm.Show();
                formSubForm.TopMost = true;
            }
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
                    SachDTO s = new SachDTO();
                    IDSach = Sach_BUS.IdentityIDSach();
                    IDDauSach = IDSach;
                    IDTacGia = Sach_BUS.ConvertNameToID(tb_TenTacGia.Text);
                    NhaXB = tb_NhaXuatBan.Text;
                    NamXB = Int32.Parse(tb_NamXuatBan.Text);
                    SoLuong = Int32.Parse(tb_SoLuong.Text);
                    GiaTien = HelperGUI.Instance.checkMoney(GiaTien, tb_GiaTien);

                    IDDauSach = IDSach;
                    TenDauSach = tb_TenDauSach.Text;
                    IDLoaiSach = cbb_TheLoaiSach.SelectedIndex + 1;

                    IDCTPhieuNhap = IDSach;
                    IDPhieuNhap = IDSach;
                    DonGia = HelperGUI.Instance.checkMoney(DonGia, tb_DonGia);
                    NgayNhap = dt_NgayNhap.Value;

                    s.IDSach = IDSach;
                    s.IDDauSach = IDDauSach;
                    s.IDTacGia = IDTacGia;
                    s.NhaXB = NhaXB;
                    s.NamXB = NamXB;
                    s.SoLuongTon = SoLuong;
                    s.GiaTien = GiaTien;

                    s.TenDauSach = TenDauSach;
                    s.IDLoaiSach = IDLoaiSach;

                    s.IDCTPhieuNhap = IDCTPhieuNhap;
                    s.IDPhieuNhap = IDPhieuNhap;
                    s.SoLuong = SoLuong;
                    s.DonGia = DonGia;
                    s.ThanhTien = SoLuong * DonGia;

                    s.NgayNhap = NgayNhap;
                    s.TongTien = SoLuong * DonGia;
                    s.TinhTrang = "Chưa cho mượn";
                    if (Sach_BUS.InsertSach(s))
                    {
                        for (int i = 0; i < SoLuong; i++)
                        {
                            Sach_BUS.InsertCuonSach(s);
                        }
                        MessageBox.Show("Cập nhật dữ liệu thành công");
                        HelperGUI.ResetAllControls(groupControl_TTS);
                        dgv_DuLieuSach.AutoGenerateColumns = false;
                        fillAllDataFromTableSach();
                        AutocomboboxTheLoaiSach();
                        AutotextboxTenTacGia();
                        AutoTextBoxNhaXB();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật dữ liệu thất bại!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        private void toolStripBt_XuatCSV_Click(object sender, EventArgs e)
        {
            HelperGUI.Instance.ExportExcel(dgv_DuLieuSach);
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            string SearchTT = "";
            if (cbb_ThongTinTimKiem.Text == "Tên sách")
            {
                SearchTT = "TenDauSach";
                dgv_DuLieuSach.DataSource = Sach_BUS.SearchSach(SearchTT, tb_NhapTT.Text.Trim());
            }
            else if (cbb_ThongTinTimKiem.Text == "Tên tác giả")
            {
                SearchTT = "TenTacGia";
                dgv_DuLieuSach.DataSource = Sach_BUS.SearchSach(SearchTT, tb_NhapTT.Text.Trim());
            }
            else if (cbb_ThongTinTimKiem.Text == "Thể loại")
            {
                SearchTT = "TenLoaiSach";
                dgv_DuLieuSach.DataSource = Sach_BUS.SearchSach(SearchTT, tb_NhapTT.Text.Trim());
            }
            else if (cbb_ThongTinTimKiem.Text == "Nhà xuất bản")
            {
                SearchTT = "NhaXB";
                dgv_DuLieuSach.DataSource = Sach_BUS.SearchSach(SearchTT, tb_NhapTT.Text.Trim());
            }
            else if (cbb_ThongTinTimKiem.Text == "Năm xuất bản")
            {
                SearchTT = "NamXB";
                dgv_DuLieuSach.DataSource = Sach_BUS.SearchSach(SearchTT, tb_NhapTT.Text.Trim());
            }
        }

        private void dgv_DuLieuSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string LDonGia;
            string LGiaTien;
            try
            {
                int i;
                i = dgv_DuLieuSach.CurrentRow.Index;
                tb_TenDauSach.Text = dgv_DuLieuSach.Rows[i].Cells["cl_TenDauSach"].Value.ToString();
                cbb_TheLoaiSach.Text = dgv_DuLieuSach.Rows[i].Cells["cl_TenLoaiSach"].Value.ToString();
                tb_TenTacGia.Text = dgv_DuLieuSach.Rows[i].Cells["cl_TenTacGia"].Value.ToString();
                dt_NgayNhap.Value = DateTime.Parse(dgv_DuLieuSach.Rows[i].Cells["cl_NgayNhap"].Value.ToString());
                tb_NamXuatBan.Text = dgv_DuLieuSach.Rows[i].Cells["cl_NamXB"].Value.ToString();
                tb_NhaXuatBan.Text = dgv_DuLieuSach.Rows[i].Cells["cl_NhaXB"].Value.ToString();
                LDonGia = dgv_DuLieuSach.Rows[i].Cells["cl_DonGia"].Value.ToString();
                long a = Convert.ToInt64(Math.Round(Convert.ToDouble(LDonGia)));
                tb_DonGia.Text = a.ToString();
                LGiaTien = dgv_DuLieuSach.Rows[i].Cells["cl_GiaTien"].Value.ToString();
                long b = Convert.ToInt64(Math.Round(Convert.ToDouble(LGiaTien)));
                tb_GiaTien.Text = b.ToString();
                tb_SoLuong.Text = dgv_DuLieuSach.Rows[i].Cells["cl_SoLuongTon"].Value.ToString();
                bt_CNDL.Enabled = false;
            }
            catch
            {
                e.ToString();
            }
        }

        private void bt_Lamlai_Click(object sender, EventArgs e)
        {
            HelperGUI.ResetAllControls(groupControl_TTS);
            bt_CNDL.Enabled = true;
        }

        private void cbb_TheLoaiSach_Click(object sender, EventArgs e)
        {
            AutocomboboxTheLoaiSach();
        }

        private void toolStripBt_SuaTT_Click(object sender, EventArgs e)
        {
                int i;
                i = dgv_DuLieuSach.CurrentCell.RowIndex;
                string SIDSach = dgv_DuLieuSach.Rows[i].Cells["cl_IDSach"].Value.ToString();
                SachDTO s = new SachDTO();
                IDSach = int.Parse(SIDSach);
                IDDauSach = IDSach;
                IDPhieuNhap = IDSach;

                IDTacGia = Sach_BUS.ConvertNameToID(tb_TenTacGia.Text);
                NhaXB = tb_NhaXuatBan.Text;
                NamXB = Int32.Parse(tb_NamXuatBan.Text);
                SoLuong = Int32.Parse(tb_SoLuong.Text);
                GiaTien = decimal.Parse(tb_GiaTien.Text);
                TenDauSach = tb_TenDauSach.Text;
                IDLoaiSach = cbb_TheLoaiSach.SelectedIndex + 1;
                DonGia = decimal.Parse(tb_DonGia.Text);
                NgayNhap = dt_NgayNhap.Value;

                s.IDSach = IDSach;
                s.IDDauSach = IDDauSach;
                s.IDPhieuNhap = IDPhieuNhap;

                s.IDTacGia = IDTacGia;
                s.NhaXB = NhaXB;
                s.NamXB = NamXB;
                s.SoLuongTon = SoLuong;
                s.GiaTien = GiaTien;
                s.TenDauSach = TenDauSach;
                s.IDLoaiSach = IDLoaiSach;
                s.SoLuong = SoLuong;
                s.DonGia = DonGia;
                s.ThanhTien = SoLuong * DonGia;
                s.TongTien = SoLuong * DonGia;
                s.NgayNhap = NgayNhap;
                if (Sach_BUS.UpdateSach(s))
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    HelperGUI.ResetAllControls(groupControl_TTS);
                    dgv_DuLieuSach.AutoGenerateColumns = false;
                    fillAllDataFromTableSach();
                    AutocomboboxTheLoaiSach();
                    AutotextboxTenTacGia();
                    AutoTextBoxNhaXB();
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thất bại!");
                }
        }

        private void btnThemTacGia_Click(object sender, EventArgs e)
        {
            Form fsf = Application.OpenForms["FrmThemTacGia"];

            if (fsf != null)
            {
                fsf.WindowState = FormWindowState.Normal;
                fsf.Show();
                fsf.TopMost = true;
            }
            else
            {
                Form formSubForm = new frmThemTacGia();
                formSubForm.Show();
                formSubForm.TopMost = true;
            }
        }

        #endregion
    }
}
