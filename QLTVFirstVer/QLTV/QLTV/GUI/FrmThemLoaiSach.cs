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

namespace Desktop.GUI
{
    public partial class FrmThemLoaiSach : Form
    {
        public FrmThemLoaiSach()
        {
            InitializeComponent();
        }
        public string TenTheLoai;
        SachBUS Sach_BUS = new SachBUS();
        private void bt_CNDL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_ThemTheLoaiSach.Text)) { MessageBox.Show("Không được để trống tên đầu sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_ThemTheLoaiSach.Focus(); }
            {
                try
                {
                    SachDTO s = new SachDTO();
                    TenTheLoai = HelperGUI.Instance.KiemTraHoTen(tb_ThemTheLoaiSach.Text);
                    s.TenLoaiSach = TenTheLoai;
                    if (Sach_BUS.InsertTheLoaiSach(s))
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
                        tb_ThemTheLoaiSach.Text = null;
                    }
                }
                catch
                {

                }
            }
        }
    }
}
