using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.DAO;
using Desktop.HelperUI;

namespace Desktop.GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        #region Event Click
        private void btn_login_Click(object sender, EventArgs e)
        {
            if(GetDataDAO.Instance.CheckTaiKhoanAndMatKhau(tb_user.Text,tb_passwork.Text))
            {
                frmMain frm = new frmMain();
                this.Hide();
                MessageBox.Show("Đăng nhập thành công");
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản mật khẩu không đúng!");
            }
        }
        private void tb_user_MouseClick(object sender, MouseEventArgs e)
        {
            if(tb_user.Text=="Username")
            {
                tb_user.Text = "";
            }
            if(tb_user.TabIndex==0)
            {
                tb_passwork.Text = "";
                tb_passwork.PasswordChar = '*';
            }
        }
        private void tb_passwork_MouseClick(object sender, MouseEventArgs e)
        {
            if(tb_passwork.Text=="Passwork")
            {
                tb_passwork.Text = "";
                tb_passwork.PasswordChar = '*';
            }
        }
        #endregion
        #region Event KeyDown
        private void tb_passwork_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (GetDataDAO.Instance.CheckTaiKhoanAndMatKhau(tb_user.Text, tb_passwork.Text))
                {
                    frmMain frm = new frmMain();
                    this.Hide();
                    MessageBox.Show("Đăng nhập thành công");
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản mật khẩu không đúng!");
                }
            }
        }
        #endregion
    }
}
