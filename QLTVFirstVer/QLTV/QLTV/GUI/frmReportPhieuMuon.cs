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
using Desktop.DTO;
using Desktop.BUS;

namespace Desktop.GUI
{
    public partial class frmReportPhieuMuon : Form
    {
        public frmReportPhieuMuon()
        {
            InitializeComponent();
        }
        #region Value
        public int Thang;
        public int Nam;
        public string NgayLap;
        public int IDBCMuonSach;
        #endregion
        ReportPhieuMuonBUS ReportPMBUS = new ReportPhieuMuonBUS();
        private void btn_TaoBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                Thang = int.Parse(tb_Thang.Text);
                Nam = int.Parse(tb_Nam.Text);
                NgayLap = DateTime.Now.Date.ToString("yyyy.MM.dd");
                ReportPhieuMuonDTO RP = new ReportPhieuMuonDTO();
                IDBCMuonSach = ReportPMBUS.IdentityIDBCPHIEUMUON();
                RP.IDBCMuonSach = IDBCMuonSach;
                RP.NgayLap = DateTime.Parse(NgayLap);
                RP.Thang = Thang;
                RP.Nam = Nam;
                RP.TongSoLuotMuon = 0;
                if (ReportPMBUS.InsertReportPM(RP))
                {
                    List<ReportPhieuMuonDTO> BC = new List<ReportPhieuMuonDTO>();
                    BC = ReportPMBUS.RPBC(IDBCMuonSach);
                    string ThangBC = tb_Thang.Text.ToString();
                    string NamBC = tb_Nam.Text.ToString();
                    string Tong = ReportPMBUS.GetTongS(IDBCMuonSach);
                    string NgayTao = DateTime.Today.Date.ToString("dd/MM/yyyy");
                    RptPhieuMuon.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "rpBaoCao";
                    rds.Value = BC;
                    Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
                    {
                        new Microsoft.Reporting.WinForms.ReportParameter("rpNgayTao",NgayTao),
                        new Microsoft.Reporting.WinForms.ReportParameter("rpThang",ThangBC),
                        new Microsoft.Reporting.WinForms.ReportParameter("rpNam",NamBC),
                        new Microsoft.Reporting.WinForms.ReportParameter("rpTongSo",Tong),
                    };
                    this.RptPhieuMuon.LocalReport.SetParameters(para);
                    RptPhieuMuon.LocalReport.DataSources.Clear();
                    RptPhieuMuon.LocalReport.DataSources.Add(rds);
                    //Refresh lại báo cáo
                    RptPhieuMuon.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Tạo báo cáo thất bại");
                }
            }
            catch
            {

            }
        }

        private void frmReportPhieuMuon_Load(object sender, EventArgs e)
        {
            dgvDuLieu.AutoGenerateColumns = false;
            this.RptPhieuMuon.RefreshReport();
            dgvDuLieu.DataSource = ReportPMBUS.LoadReportPM();
        }
    }
}
