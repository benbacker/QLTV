using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Dtos;
using Service.ABSTRACT;
using Desktop.HelperUI;

namespace Desktop.GUI
{
    public partial class frmThemTacGia : Form
    {
        public frmThemTacGia()
        {
            InitializeComponent();
        }
        #region Value
        public string TenTacGia;
        public DateTime NgaySinh;
        #endregion
        #region KeyPress
        private void tb_TenTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckKiTu(sender, e);
        }
        #endregion
        #region getValueChanged Datetimepicker     
        private void dt_NgaySinh_ValueChanged(object sender, EventArgs e)
        {
            NgaySinh = dt_NgaySinh.Value;
        }
        #endregion
        #region Event Click
        private void bt_CNDL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_TenTacGia.Text)) { MessageBox.Show("Không được để trống thể loại sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_TenTacGia.Focus(); }
            else
            {
                try
                {
                    TacGiaService sv = new TacGiaService();
                    TacGiaDtos tdg = new TacGiaDtos();
                    TenTacGia = HelperGUI.Instance.KiemTraHoTen(tb_TenTacGia.Text);
                    NgaySinh = dt_NgaySinh.Value;
                    tdg.TenTacGia = TenTacGia;
                    tdg.NgaySinh = NgaySinh;
                    sv.AddFormTacGia(tdg);
                    MessageBox.Show("Thêm thành công!");
                    HelperGUI.ResetAllControls(groupControl_ThemTacGia);
                }
                catch
                {

                }
            }
        }
        #endregion
    }
}
