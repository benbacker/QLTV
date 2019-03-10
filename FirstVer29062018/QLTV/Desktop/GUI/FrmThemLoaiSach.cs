using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Data.Dtos;
using Service.ABSTRACT;
using Desktop.HelperUI;


namespace Desktop.GUI
{
    public partial class FrmThemLoaiSach : Form
    {
        public FrmThemLoaiSach()
        {
            InitializeComponent();
        }

        #region Value
        public string TenLoaiSach;
        #endregion
        #region KeyPress
        private void tb_ThemTheLoaiSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckKiTu(sender, e);
        }
        #endregion
        #region Event Click
        private void bt_CNDL_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tb_ThemTheLoaiSach.Text)){ MessageBox.Show("Không được để trống thể loại sách.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_ThemTheLoaiSach.Focus(); }
            else
            {
                try
                {
                    LoaiSachService sv = new LoaiSachService();
                    LoaiSachDtos tdg = new LoaiSachDtos();
                    TenLoaiSach = tb_ThemTheLoaiSach.Text;
                    tdg.TenLoaiSach = TenLoaiSach;
                    sv.AddFromLoaiSach(tdg);
                    MessageBox.Show("Thêm thành công");
                    HelperGUI.ResetAllControls(groupControl_ThemTheLoai);
                }
                catch
                {

                }
            }
        }
        #endregion

    }
}
