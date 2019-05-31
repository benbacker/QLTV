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
using Desktop.DAO;
using Desktop.DTO;
using Desktop.BUS;

namespace Desktop.GUI
{
    public partial class frmTacGia : Form
    {
        public frmTacGia()
        {
            InitializeComponent();
        }
        //TacGiaDAO TG_DAO = new TacGiaDAO();
        TacGiaBUS TG_BUS = new TacGiaBUS();
        #region Value
        public string TenTacGia;
        public DateTime NgaySinh;
        #endregion
        #region getValueChanged Datetimepicker
        private void dt_NgaySinh_ValueChanged(object sender, EventArgs e)
        {
            NgaySinh = dt_NgaySinh.Value;
        }
        #endregion
        #region fillAllDataFromTableTacGia
        public void fillAllDataFromTableTacGia()
        {
            dgv_DuLieu.DataSource = TG_BUS.LoadTacGia();
        }
        #endregion
        #region FromLoadTacGia
        private void frmTacGia_Load(object sender, EventArgs e)
        {
            dgv_DuLieu.AutoGenerateColumns = false;
            fillAllDataFromTableTacGia();
        }
        #endregion
        #region Click
        private void bt_CNDL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_TenTacGia.Text)) { MessageBox.Show("Không được để trống họ tên độc giả.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_TenTacGia.Focus(); }
            else
            {
                try
                {
                    TacGiaDTO tg = new TacGiaDTO();
                    TenTacGia = HelperGUI.Instance.KiemTraHoTen(tb_TenTacGia.Text);
                    NgaySinh = dt_NgaySinh.Value;
                    tg.TenTacGia = TenTacGia;
                    tg.NgaySinh = NgaySinh;
                    if(TG_BUS.InsertTacGia(tg))
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công");
                        HelperGUI.ResetAllControls(groupControl_TTTG);
                        dgv_DuLieu.AutoGenerateColumns = false;
                        fillAllDataFromTableTacGia();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật dữ liệu thất bại");
                    }
                }
                catch
                {

                }
            }
        }

        private void bt_Lamlai_Click(object sender, EventArgs e)
        {
            HelperGUI.ResetAllControls(groupControl_TTTG);
            bt_CNDL.Enabled = true;
        }

        private void toolStripBt_Reset_Click(object sender, EventArgs e)
        {
            fillAllDataFromTableTacGia();
            HelperGUI.ResetAllControls(groupControl_TTTG);
            bt_CNDL.Enabled = true;
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            string SearchTT = "";
            if (cbb_ThongTinTimKiem.Text == "Họ và tên")
            {
                SearchTT = "TenTacGia";
                dgv_DuLieu.DataSource = TG_BUS.SearchTacGia(SearchTT, tb_NhapTT.Text.Trim());
            }
        }

        private void toolStripBt_SuaTT_Click(object sender, EventArgs e)
        {
            int i;
            i = dgv_DuLieu.CurrentCell.RowIndex;
            string IDTacGia = dgv_DuLieu.Rows[i].Cells["cl_IDTacGia"].Value.ToString();
            TacGiaDTO tg = new TacGiaDTO();
            TenTacGia = HelperGUI.Instance.KiemTraHoTen(tb_TenTacGia.Text);
            NgaySinh = dt_NgaySinh.Value;
            tg.IDTacGia = int.Parse(IDTacGia);
            tg.TenTacGia = TenTacGia;
            tg.NgaySinh = NgaySinh;
            if (TG_BUS.UpdateTacGia(tg))
            {
                MessageBox.Show("Sữa dữ liệu thành công");
                HelperGUI.ResetAllControls(groupControl_TTTG);
                dgv_DuLieu.AutoGenerateColumns = false;
                fillAllDataFromTableTacGia();
            }
            else
            {
                MessageBox.Show("Sữa dữ liệu thất bại");
            }
        }

        private void dgv_DuLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int i;
                i = dgv_DuLieu.CurrentRow.Index;
                tb_TenTacGia.Text = dgv_DuLieu.Rows[i].Cells["cl_TenTacGia"].Value.ToString();
                dt_NgaySinh.Value = DateTime.Parse(dgv_DuLieu.Rows[i].Cells["cl_NgaySinh"].Value.ToString());
                bt_CNDL.Enabled = false;
            }
            catch
            {
                e.ToString();
            }
        }

        private void toolStripBt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripBt_XuatCSV_Click(object sender, EventArgs e)
        {
            HelperGUI.Instance.ExportExcel(dgv_DuLieu);
        }

        private void toolStripBt_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                i = dgv_DuLieu.CurrentCell.RowIndex;
                int IDTacGia = Int32.Parse(dgv_DuLieu.Rows[i].Cells["cl_IDTacGia"].Value.ToString());
                DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa không!!", "Thông báo!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                {
                    if (result == DialogResult.OK)
                    {
                        if (TG_BUS.DeteleTacGia(IDTacGia))
                        {
                            MessageBox.Show("Xóa dữ liệu thất thành công!");
                            HelperGUI.ResetAllControls(groupControl_TTTG);
                            dgv_DuLieu.AutoGenerateColumns = false;
                            fillAllDataFromTableTacGia();
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
        #region KeyPress
        private void tb_TenTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckKiTu(sender, e);
        }
        #endregion
    }
}
