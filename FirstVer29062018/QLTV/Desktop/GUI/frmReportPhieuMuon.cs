using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.DTO;

using Service.ABSTRACT;
using Data.DAO;
using Microsoft.Reporting.WinForms;

namespace Desktop.GUI
{
    public partial class frmReportPhieuMuon : Form
    {
        public frmReportPhieuMuon()
        {
            InitializeComponent();
        }
        public int Thang;
        public int Nam;

        private void frmReportPhieuMuon_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            this.reportViewer1.RefreshReport();
            LoadDatagridView();
        }
        public void LoadDatagridView()
        {
            List<BaoCaoTinhHinhMuonSachDTO> BC = new List<BaoCaoTinhHinhMuonSachDTO>();
            BaoCaoTinhHinhMuonSachService SV = new BaoCaoTinhHinhMuonSachService();
            BC = SV.getAllListBaoCaoTinhHinhMuonSach();
            dataGridView1.DataSource = BC;

        }

        private void tb_Nam_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_Thang_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_TaoBaoCao_Click(object sender, EventArgs e)
        {
            Thang = Int32.Parse(tb_Thang.Text);
            Nam = Int32.Parse(tb_Nam.Text);
            List<BaoCaoTinhHinhMuonSachDTO> BC = new List<BaoCaoTinhHinhMuonSachDTO>();
            BaoCaoTinhHinhMuonSachService SV = new BaoCaoTinhHinhMuonSachService();
            BC = SV.getListBaoCaoTinhHinhMuonSachToDate(Thang, Nam);
            string NguoiLap = GetDataDAO.Instance.getNguoiLapBaoCao();
            string ThangBC = Thang.ToString();
            string NamBC = Nam.ToString();
            string Tong = GetDataDAO.Instance.getTongSoLuotMuonToDate(Thang,Nam);
            //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "rpBaoCao";
            rds.Value = BC;
            DateTime ngayLap = DateTime.Now;
            string NgayLapBC = ngayLap.ToString();
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("rpNguoiLap",NguoiLap),
                new Microsoft.Reporting.WinForms.ReportParameter("rpThang",ThangBC),
                new Microsoft.Reporting.WinForms.ReportParameter("rpNam",NamBC),
                new Microsoft.Reporting.WinForms.ReportParameter("rpTongSo",Tong),
                new Microsoft.Reporting.WinForms.ReportParameter("rpNgayLap",NgayLapBC),
            };
            this.reportViewer1.LocalReport.SetParameters(para);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            //Refresh lại báo cáo
            reportViewer1.RefreshReport();
        }
    }
}
