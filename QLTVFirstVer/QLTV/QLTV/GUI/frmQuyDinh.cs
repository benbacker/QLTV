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

namespace Desktop.GUI
{
    public partial class frmQuyDinh : Form
    {
        public frmQuyDinh()
        {
            InitializeComponent();
        }
        QuyDinhBUS QD_BUS = new QuyDinhBUS();
        #region fillAllDataTableQuyDinh
        public void LoadQuyDinh()
        {
            dgv_DuLieu.AutoGenerateColumns = false;
            dgv_DuLieu.DataSource = QD_BUS.LoadQuyDinh();
            LoadTextBox();
        }

        public void LoadTextBox()
        {
            try
            {
                int i;
                i = 0;
                tb_HanThe.Text = dgv_DuLieu.Rows[i].Cells["cl_HanThe"].Value.ToString();
                tb_KCach.Text = dgv_DuLieu.Rows[i].Cells["cl_KhoangCachXB"].Value.ToString();
                tb_NgayMuon.Text = dgv_DuLieu.Rows[i].Cells["cl_SoNgayMuonMax"].Value.ToString();
                tb_SachMuon.Text = dgv_DuLieu.Rows[i].Cells["cl_SoSachMuonMax"].Value.ToString();
                tb_TienPhat.Text = dgv_DuLieu.Rows[i].Cells["cl_TienPhatMoiNgay"].Value.ToString();
                tb_TuoiMax.Text = dgv_DuLieu.Rows[i].Cells["cl_TuoiMax"].Value.ToString();
                tb_TuoiMin.Text = dgv_DuLieu.Rows[i].Cells["cl_TuoiMin"].Value.ToString();
            }
            catch
            {
                
            }
        }
        #endregion
        #region Load
        private void frmQuyDinh_Load(object sender, EventArgs e)
        {
            LoadQuyDinh();
        }
        #endregion
        #region Click
        private void dgv_DuLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadTextBox();
        }

        private void btn_SuaTT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_TuoiMin.Text)) { MessageBox.Show("Không được để trống họ tên độc giả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_TuoiMin.Focus(); }
            else if (string.IsNullOrEmpty(tb_TuoiMax.Text)) { MessageBox.Show("Không được để trống Tài khoản.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_TuoiMax.Focus(); }
            else if (string.IsNullOrEmpty(tb_TienPhat.Text)) { MessageBox.Show("Không được để trống Passwork.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_TienPhat.Focus(); }
            else if (string.IsNullOrEmpty(tb_SachMuon.Text)) { MessageBox.Show("Không được để trống địa chỉ.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_SachMuon.Focus(); }
            else if (string.IsNullOrEmpty(tb_NgayMuon.Text)) { MessageBox.Show("Không được để trống Email.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_NgayMuon.Focus(); }
            else if (string.IsNullOrEmpty(tb_HanThe.Text)) { MessageBox.Show("Không được để trống Email.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_HanThe.Focus(); }
            else if (string.IsNullOrEmpty(tb_KCach.Text)) { MessageBox.Show("Không được để trống loại độc giả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_KCach.Focus(); }
            else
            {
                QuyDinhDTO QD = new QuyDinhDTO();
                QD.TuoiMin = int.Parse(tb_TuoiMin.Text);
                QD.TuoiMax = int.Parse(tb_TuoiMax.Text);
                QD.TienPhatMoiNgay = decimal.Parse(tb_TienPhat.Text);
                QD.SoSachMuonMax = int.Parse(tb_SachMuon.Text);
                QD.SoNgayMuonMax = int.Parse(tb_NgayMuon.Text);
                QD.KhoangCachXB = int.Parse(tb_KCach.Text);
                QD.HanThe = int.Parse(tb_HanThe.Text);
                if(QD_BUS.UpdateQuyDinh(QD))
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    LoadQuyDinh();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại xin kiểm tra lại!");
                }
            }
        }

        private void toolStripBt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripBt_Reset_Click(object sender, EventArgs e)
        {
            LoadQuyDinh();
            LoadTextBox();
        }
        #endregion
    }
}
