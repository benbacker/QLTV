using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Desktop.BUS;

namespace Desktop.GUI
{
    public partial class frmReportPhieuTra : Form
    {
        public frmReportPhieuTra()
        {
            InitializeComponent();
        }
        ReportPhieuTraBUS RP_BUS = new ReportPhieuTraBUS();
        #region Value
        public int IDBCSachTre;
        public DateTime NgayThangNam;
        public int IDCuonSach;
        public int IDPhieuMuon;
        public int SoNgayTraTre;
        #endregion

        private void frmReportPhieuTra_Load(object sender, EventArgs e)
        {
            dgvDuLieu.AutoGenerateColumns = false;
            this.RpvBaoCao.RefreshReport();
            dgvDuLieu.DataSource = RP_BUS.LoadReportPT();
        }
    }
}
