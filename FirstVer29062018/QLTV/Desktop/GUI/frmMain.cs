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
    }
}