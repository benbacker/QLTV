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
using Desktop.DTO;
using Desktop.BUS;

namespace Desktop.GUI
{
    public partial class frmThemTacGia : Form
    {
        public frmThemTacGia()
        {
            InitializeComponent();
        }
        TacGiaBUS TG_BUS = new TacGiaBUS();
        #region Value
        public string TenTacGia;
        public DateTime NgaySinh;
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
                    if (TG_BUS.InsertTacGia(tg))
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công");
                        tb_TenTacGia.Text = null;
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
        #endregion
    }
}
