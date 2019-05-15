using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Desktop.GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public static string QuyenHan { get; set; }

        private Form KiemTra(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    return f;
                }
            }
            return null;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(QuyenHan == "Nhân viên")
            {
                btn_Admin.Enabled = false;
                btn_QuyDinh.Enabled = false;
                ribbon_BCao.Visible = false;
            }
            if (QuyenHan == "Kế toán")
            {
                btn_Admin.Enabled = false;
                btn_QuyDinh.Enabled = false;
            }
        }
        #region Click
        private void btn_TDG_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTra(typeof(frmTheDocGia));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmTheDocGia f = new frmTheDocGia();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void btn_Sach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTra(typeof(frmSach));
            if(frm!=null)
            {
                frm.Activate();
            }
            else
            {
                frmSach f = new frmSach();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void btn_TGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTra(typeof(frmTacGia));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmTacGia f = new frmTacGia();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void btn_MuonSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTra(typeof(frmPhieuMuon));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmPhieuMuon f = new frmPhieuMuon();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void btn_TraSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTra(typeof(frmPhieuTra));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmPhieuTra f = new frmPhieuTra();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void btn_BaoCaoMuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTra(typeof(frmReportPhieuMuon));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmReportPhieuMuon f = new frmReportPhieuMuon();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void btn_BaoCaoTra_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTra(typeof(frmReportPhieuTra));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmReportPhieuTra f = new frmReportPhieuTra();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Admin_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTra(typeof(frmAdminUser));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmAdminUser f = new frmAdminUser();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void btn_QuyDinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTra(typeof(frmQuyDinh));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmQuyDinh f = new frmQuyDinh();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void btn_ThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.KiemTra(typeof(frmThongTin));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmThongTin f = new frmThongTin();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }
        #endregion

        private void btnSignOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = new frmLogin();
            f.Show();
            this.Hide();
        }
    }
}