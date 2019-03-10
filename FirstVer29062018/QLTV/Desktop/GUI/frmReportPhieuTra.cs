using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.ABSTRACT;
using Service.IService;
using Data.DTO;
using Data.Dtos;
using Data.DAO;
using Microsoft.Reporting.WinForms;

namespace Desktop.GUI
{
    public partial class frmReportPhieuTra : Form
    {
        public frmReportPhieuTra()
        {
            InitializeComponent();
        }
        // value
        public DateTime NgayLapBC;

        private void frmReportPhieuTra_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            this.RpvBaoCao.RefreshReport();
            LoadDataGridView();
        }
        public void LoadDataGridView()
        {
            List<BCSachTraTreDtos> BC = new List<BCSachTraTreDtos>();
            BCSachTraTreService BCSV = new BCSachTraTreService();
            BC = BCSV.getListAllBCSachTraTre();
            dataGridView1.DataSource = BC;
        }

        private void btn_TaoBaoCao_Click(object sender, EventArgs e)
        {             
            NgayLapBC = dateTimePicker1.Value;
            List<BCSachTraTreDtos> BC = new List<BCSachTraTreDtos>();
            BCSachTraTreService SV = new BCSachTraTreService();
            BC = SV.loadBaoCaoToDate(NgayLapBC);
            string NguoiLap=GetDataDAO.Instance.getNguoiLapBaoCao();
            string SoNgay =GetDataDAO.Instance.TongSoLuotMuon(NgayLapBC);
            DateTime ngayLap = DateTime.Now;
            string NgayLap = ngayLap.ToString();
            //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
            RpvBaoCao.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "rpBaoCaoTra";
            rds.Value = BC;
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("rpNguoiLap1",NguoiLap),
                new Microsoft.Reporting.WinForms.ReportParameter("rpTongS",SoNgay),
                new Microsoft.Reporting.WinForms.ReportParameter("rpNgayLap",NgayLap),
            };
            this.RpvBaoCao.LocalReport.SetParameters(para);
            RpvBaoCao.LocalReport.DataSources.Clear();  
            RpvBaoCao.LocalReport.DataSources.Add(rds);
            //Refresh lại báo cáo
            RpvBaoCao.RefreshReport();
        }
        //Load datetime
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            NgayLapBC = dateTimePicker1.Value;
        }
    }
}
