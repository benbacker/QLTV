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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        AdminBUS AD_BUS = new AdminBUS();
        #region Value
        public string UserNameAdmin;
        public string PasswordAdmin;
        public string QuyenHan;
        #endregion
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                AdminDTO AD = new AdminDTO();
                UserNameAdmin = tbUser.Text.Trim();
                PasswordAdmin = tbPassWork.Text.Trim();
                AD.UserNameAdmin = UserNameAdmin;
                AD.PasswordAdmin = PasswordAdmin;
                if(AD_BUS.CheckLogin(AD))
                {
                    MessageBox.Show("Đăng nhập thành công");
                    frmMain f = new frmMain();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản và mật khẩu không hợp lệ");
                }
            }
            catch
            {

            }
        }

        private void btnCSDL_Click(object sender, EventArgs e)
        {
            frmConnection f = new frmConnection();
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbPassWork_OnValueChanged(object sender, EventArgs e)
        {
            tbPassWork.isPassword = true;
        }
    }
}
