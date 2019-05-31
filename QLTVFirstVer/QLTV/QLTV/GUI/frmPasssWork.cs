using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop.DTO;
using Desktop.BUS;

namespace Desktop.GUI
{
    public partial class frmPasssWork : Form
    {
        public frmPasssWork()
        {
            InitializeComponent();
        }
        AdminBUS PassAdmin = new AdminBUS();
        #region Value
        public string UserName { get; set; }
        public int IDUser { get; set; }
        public string NewPass;
        #endregion
        #region Load
        private void frmPasssWork_Load(object sender, EventArgs e)
        {
            lbTaiKhoan.Text = UserName.ToString();
            TickYes.Visible = false;
            Tick.Visible = false;
        }
        #endregion
        #region Click
        private void bt_CNDL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPass.Text)) { MessageBox.Show("Không được để trống mật khẩu củ.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbPass.Focus(); }
            else if (string.IsNullOrEmpty(tbPassWork.Text)) { MessageBox.Show("Không được để trống mật khẩu mới.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbPassWork.Focus(); }
            else if (string.IsNullOrEmpty(tbNewPwd.Text)) { MessageBox.Show("bạn chưa xác nhận mật khẩu.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tbNewPwd.Focus(); }
            else
            {
                try
                {
                    NewPass = tbNewPwd.Text;
                    AdminDTO AD = new AdminDTO();
                    AD.IDAdmin = IDUser;
                    AD.UserNameAdmin = UserName;
                    AD.PasswordAdmin = tbPass.Text.Trim();
                    if (PassAdmin.CheckLogin(AD))
                    {
                        AD.PasswordAdmin = NewPass;
                        if (PassAdmin.UpdatePassAdmin(AD))
                        {
                            MessageBox.Show("Sữa dữ liệu thành công");
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu củ không đúng xin kiểm tra lại!");
                    }
                }
                catch
                {

                }
            }
        }
        #endregion
        #region TextChanged
        private void tbNewPwd_TextChanged(object sender, EventArgs e)
        {
            if(tbNewPwd.Text == tbPassWork.Text)
            {
                TickYes.Visible = true;
            }
            else
            {
                TickYes.Visible = false;
            }
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            AdminDTO AD = new AdminDTO();
            AD.UserNameAdmin = UserName;
            AD.PasswordAdmin = tbPass.Text.Trim();
            if (PassAdmin.CheckLogin(AD))
            {
                Tick.Visible = true;
            }
            else
            {
                Tick.Visible = false;
            }
        }
        #endregion
    }
}
