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
using Desktop.DTO;

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
            dgvDuLieu.DataSource = RP_BUS.RPBC();
        }

        private void btn_TaoBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                string TongS = RP_BUS.GetTongS();
                string NgayLap = dtNgayLapBC.Value.Date.ToString("dd/MM/yyyy");
                List<ReportPhieuTraDTO> BC = new List<ReportPhieuTraDTO>();
                BC = RP_BUS.RPBC();
                //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
                RpvBaoCao.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "rpBaoCaoTra";
                rds.Value = BC;
                Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
                {
                   new Microsoft.Reporting.WinForms.ReportParameter("RptNgayLap",NgayLap),
                   new Microsoft.Reporting.WinForms.ReportParameter("RptTongS",TongS),
                };
                this.RpvBaoCao.LocalReport.SetParameters(para);
                RpvBaoCao.LocalReport.DataSources.Clear();
                RpvBaoCao.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                RpvBaoCao.RefreshReport();
            }
            catch
            {

            }
        }
    }
}
