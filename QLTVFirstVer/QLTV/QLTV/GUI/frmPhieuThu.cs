using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop.BUS;
using Desktop.DTO;

namespace Desktop.GUI
{
    public partial class frmPhieuThu : Form
    {
        public frmPhieuThu()
        {
            InitializeComponent();
        }
        PhieuThuBUS PT_BUS = new PhieuThuBUS();
        #region Value
        public string HoTenDG { get; set; }
        public int IDLoaiDG { get; set; }
        public string DiaChiDG { get; set; }
        public string EmailDG { get; set; }
        public string TongNo { get; set; }
        #endregion

        private void frmPhieuThu_Load(object sender, EventArgs e)
        {
            lbHoTen.Text = HoTenDG;
            lbEmail.Text = EmailDG;
            lbDiaChi.Text = DiaChiDG;
            lbNgayLapPhieu.Text = DateTime.Today.Date.ToString("dd/MM/yyyy");
            this.rpvPhieuThu.RefreshReport();
        }

        private void bt_CNDL_Click(object sender, EventArgs e)
        {
            int Tien = int.Parse(tb_TienThu.Text);
            long a = Convert.ToInt64(Math.Round(Convert.ToDouble(TongNo)));
            if (string.IsNullOrEmpty(tb_TienThu.Text)) { MessageBox.Show("Xin mời nhập số tiền thu.", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning); tb_TienThu.Focus(); }
            else
            {
                PhieuThuDTO PT = new PhieuThuDTO();
                PT.IDDocGia = IDLoaiDG;
                PT.NgayLap = DateTime.Today.Date;
                PT.SoTienThu = decimal.Parse(tb_TienThu.Text);
                PT.ConLai = 0;
                if (Tien <= a)
                {
                    if (PT_BUS.InsertPhieuThu(PT))
                    {
                        try
                        {
                            string HoTen = HoTenDG;
                            string DiaChi = DiaChiDG;
                            string NLap = DateTime.Today.Date.ToString("dd/MM/yyyy");
                            long TinhTien = a - Tien;
                            string TienThu = string.Format("{0:#,0}", Tien);
                            string TongS = string.Format("{0:#,0}", a);
                            string ConLai = string.Format("{0:#,0}", TinhTien);
                            //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
                            rpvPhieuThu.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
                            {
                            new Microsoft.Reporting.WinForms.ReportParameter("rpHoTenDG",HoTen),
                            new Microsoft.Reporting.WinForms.ReportParameter("rpNgayLap",NLap),
                            new Microsoft.Reporting.WinForms.ReportParameter("rpDiaChi",DiaChi),
                            new Microsoft.Reporting.WinForms.ReportParameter("rpTienThu",TienThu),
                            new Microsoft.Reporting.WinForms.ReportParameter("rpTongNo",TongS),
                            new Microsoft.Reporting.WinForms.ReportParameter("rpConLai",ConLai),
                            };
                            this.rpvPhieuThu.LocalReport.SetParameters(para);
                            rpvPhieuThu.LocalReport.DataSources.Clear();
                            //Refresh lại báo cáo
                            rpvPhieuThu.RefreshReport();
                        }
                        catch
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Tạo phiết phạt thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Số tiền thu đã vượt quá số tiền nợ xin mời nhập lại!");
                }
            }
        }
    }
}
