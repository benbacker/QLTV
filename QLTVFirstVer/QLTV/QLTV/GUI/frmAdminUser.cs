using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop.BUS;
using Desktop.DTO;
using Desktop.HelperUI;

namespace Desktop.GUI
{
    public partial class frmAdminUser : Form
    {
        public frmAdminUser()
        {
            InitializeComponent();
        }
        AdminBUS AD_BUS = new AdminBUS();
        private void frmAdminUser_Load(object sender, EventArgs e)
        {
            LoadUserAdmin();
        }
        #region Value
        public int IDAdmin;
        public string HoTenAdmin;
        public DateTime NgaySinhAdmin;
        public string DiaChiAdmin;
        public string EmailAdmin;
        public string UserNameAdmin;
        public string PasswordAdmin;
        public string QuyenHan;
        #endregion
        #region fillLoadDataTableAdmin
        public void LoadUserAdmin()
        {
            dgv_DuLieu.AutoGenerateColumns = false;
            dgv_DuLieu.DataSource = AD_BUS.LoadAdmin();
        }
        #endregion
        #region Click
        private void bt_CNDL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_HoTenAdmin.Text)) { MessageBox.Show("Không được để trống họ tên admin.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_HoTenAdmin.Focus(); }
            else if (string.IsNullOrEmpty(tb_User.Text)) { MessageBox.Show("Không được để trống Tài khoản.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_User.Focus(); }
            else if (string.IsNullOrEmpty(tb_Passwork.Text)) { MessageBox.Show("Không được để trống Passwork.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_Passwork.Focus(); }
            else if (string.IsNullOrEmpty(tb_Diachi.Text)) { MessageBox.Show("Không được để trống địa chỉ.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_Diachi.Focus(); }
            else if (string.IsNullOrEmpty(tb_Email.Text)) { MessageBox.Show("Không được để trống Email.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_Email.Focus(); }
            else if (HelperGUI.Instance.checkIsMail(tb_Email) == false) { MessageBox.Show("Email không hợp lệ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_Email.Focus(); }
            else if (string.IsNullOrEmpty(cb_ChucVu.Text)) { MessageBox.Show("Không được để trống chức vụ.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); cb_ChucVu.Focus(); }
            else
            {
                try
                {
                    IDAdmin = AD_BUS.IdentityIDAdmin();
                    HoTenAdmin = HelperGUI.Instance.KiemTraHoTen(tb_HoTenAdmin.Text);
                    NgaySinhAdmin = dt_Ngaysinh.Value;
                    DiaChiAdmin = tb_Diachi.Text;
                    EmailAdmin = tb_Email.Text;
                    UserNameAdmin = tb_User.Text;
                    PasswordAdmin = tb_Passwork.Text;
                    QuyenHan = cb_ChucVu.Text;
                    AdminDTO AD = new AdminDTO();
                    AD.IDAdmin = IDAdmin;
                    AD.HoTenAdmin = HoTenAdmin;
                    AD.NgaySinhAdmin = NgaySinhAdmin;
                    AD.DiaChiAdmin = DiaChiAdmin;
                    AD.EmailAdmin = EmailAdmin;
                    AD.UserNameAdmin = UserNameAdmin;
                    AD.PasswordAdmin = PasswordAdmin;
                    AD.QuyenHan = QuyenHan;
                    if(AD_BUS.InsertAdmin(AD))
                    {
                        MessageBox.Show("Thêm dữ liệu thành công");
                        HelperGUI.ResetAllControls(groupControl_TTDG);
                        LoadUserAdmin();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản đã tồn tại xin kiểm tra lại!");
                    }
                }
                catch
                {

                }
            }
        }

        private void toolStripBt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripBt_Reset_Click(object sender, EventArgs e)
        {
            LoadUserAdmin();
            HelperGUI.ResetAllControls(groupControl_TTDG);
            bt_CNDL.Enabled = true;
        }

        private void bt_Lamlai_Click(object sender, EventArgs e)
        {
            HelperGUI.ResetAllControls(groupControl_TTDG);
            bt_CNDL.Enabled = true;
        }

        private void toolStripBt_XuatCSV_Click(object sender, EventArgs e)
        {
            HelperGUI.Instance.ExportExcel(dgv_DuLieu);
        }

        private void dgv_DuLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i;
                i = dgv_DuLieu.CurrentRow.Index;
                tb_HoTenAdmin.Text = dgv_DuLieu.Rows[i].Cells["cl_HoTenAdmin"].Value.ToString();
                tb_User.Text = dgv_DuLieu.Rows[i].Cells["cl_UserNameAdmin"].Value.ToString();
                tb_Email.Text = dgv_DuLieu.Rows[i].Cells["cl_EmailAdmin"].Value.ToString();
                tb_Diachi.Text = dgv_DuLieu.Rows[i].Cells["cl_DiaChiAdmin"].Value.ToString();
                cb_ChucVu.SelectedItem = dgv_DuLieu.Rows[i].Cells["cl_QuyenHan"].Value.ToString();
                dt_Ngaysinh.Value = DateTime.Parse(dgv_DuLieu.Rows[i].Cells["cl_NgaySinhAdmin"].Value.ToString());
                tb_Passwork.Text = "passwork nè xem đi hihi";
                bt_CNDL.Enabled = false;
            }
            catch
            {
                e.ToString();
            }
        }

        private void toolStripBt_SuaTT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_HoTenAdmin.Text)) { MessageBox.Show("Không được để trống họ tên admin.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_HoTenAdmin.Focus(); }
            else if (string.IsNullOrEmpty(tb_User.Text)) { MessageBox.Show("Không được để trống Tài khoản.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_User.Focus(); }
            else if (string.IsNullOrEmpty(tb_Passwork.Text)) { MessageBox.Show("Không được để trống Passwork.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_Passwork.Focus(); }
            else if (string.IsNullOrEmpty(tb_Diachi.Text)) { MessageBox.Show("Không được để trống địa chỉ.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_Diachi.Focus(); }
            else if (string.IsNullOrEmpty(tb_Email.Text)) { MessageBox.Show("Không được để trống Email.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_Email.Focus(); }
            else if (HelperGUI.Instance.checkIsMail(tb_Email) == false) { MessageBox.Show("Email không hợp lệ", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_Email.Focus(); }
            else if (string.IsNullOrEmpty(cb_ChucVu.Text)) { MessageBox.Show("Không được để trống chức vụ.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); cb_ChucVu.Focus(); }
            else
            {
                try
                {
                    int i;
                    i = dgv_DuLieu.CurrentRow.Index;
                    IDAdmin = int.Parse(dgv_DuLieu.Rows[i].Cells["cl_IDAdmin"].Value.ToString());
                    HoTenAdmin = HelperGUI.Instance.KiemTraHoTen(tb_HoTenAdmin.Text);
                    NgaySinhAdmin = dt_Ngaysinh.Value;
                    DiaChiAdmin = tb_Diachi.Text;
                    EmailAdmin = tb_Email.Text;
                    UserNameAdmin = tb_User.Text;
                    PasswordAdmin = tb_Passwork.Text;
                    QuyenHan = cb_ChucVu.Text;
                    AdminDTO AD = new AdminDTO();
                    AD.IDAdmin = IDAdmin;
                    AD.HoTenAdmin = HoTenAdmin;
                    AD.NgaySinhAdmin = NgaySinhAdmin;
                    AD.DiaChiAdmin = DiaChiAdmin;
                    AD.EmailAdmin = EmailAdmin;
                    AD.UserNameAdmin = UserNameAdmin;
                    AD.PasswordAdmin = PasswordAdmin;
                    AD.QuyenHan = QuyenHan;
                    if (AD_BUS.UpdateAdmin(AD))
                    {
                        MessageBox.Show("Thêm dữ liệu thành công");
                        HelperGUI.ResetAllControls(groupControl_TTDG);
                        LoadUserAdmin();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản đã tồn tại xin kiểm tra lại!");
                    }
                }
                catch
                {

                }
            }
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            string SearchTT = "";
            if (cbb_ThongTinTimKiem.Text == "Họ và tên")
            {
                SearchTT = "HoTenAdmin";
                dgv_DuLieu.DataSource = AD_BUS.SearchAdmin(SearchTT, tb_NhapTT.Text.Trim());
            }
            else if (cbb_ThongTinTimKiem.Text == "Email")
            {
                SearchTT = "EmailAdmin";
                dgv_DuLieu.DataSource = AD_BUS.SearchAdmin(SearchTT, tb_NhapTT.Text.Trim());
            }
            else if (cbb_ThongTinTimKiem.Text == "Tài khoản")
            {
                SearchTT = "UserNameAdmin";
                dgv_DuLieu.DataSource = AD_BUS.SearchAdmin(SearchTT, tb_NhapTT.Text.Trim());
            }
        }

        private void toolStripBt_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                i = dgv_DuLieu.CurrentCell.RowIndex;
                int IDAdmin = Int32.Parse(dgv_DuLieu.Rows[i].Cells["cl_IDAdmin"].Value.ToString());
                DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa không!!", "Thông báo!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                {
                    if (result == DialogResult.OK)
                    {
                        if (AD_BUS.DeleteAdmin(IDAdmin))
                        {
                            MessageBox.Show("Xóa dữ liệu thất thành công!");
                            HelperGUI.ResetAllControls(groupControl_TTDG);
                            dgv_DuLieu.AutoGenerateColumns = false;
                            LoadUserAdmin();
                        }
                        else
                        {
                            MessageBox.Show("Dữ liệu độc giả đã tồn tại xóa thất bại!");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đã tồn tại không thể xóa");
            }
        }
        #endregion

        private void btn_ThemLoaiSach_Click(object sender, EventArgs e)
        {
            Form fsf = Application.OpenForms["frmPasssWork"];
            if (fsf != null)
            {
                fsf.WindowState = FormWindowState.Normal;
                fsf.Show();
                fsf.TopMost = true;
            }
            else
            {
                int i;
                i = dgv_DuLieu.CurrentRow.Index;
                frmPasssWork formSubForm = new frmPasssWork();
                formSubForm.IDUser = int.Parse(dgv_DuLieu.Rows[i].Cells["cl_IDAdmin"].Value.ToString());
                formSubForm.UserName = dgv_DuLieu.Rows[i].Cells["cl_UserNameAdmin"].Value.ToString();
                formSubForm.Show();
                formSubForm.TopMost = true;
            }
        }
    }
}
