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
using Data.Dtos;
using Service.ABSTRACT;
using Data.DAO;
using Data.DTO;

namespace Desktop.GUI
{
    public partial class frmTacGia : Form
    {
        public frmTacGia()
        {
            InitializeComponent();
        }
        #region Value
        public string TenTacGia;
        public DateTime NgaySinh;
        #endregion
        #region Event Keypress
        private void tb_TenTacGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperGUI.Instance.CheckKiTu(sender, e);
        }
        #endregion
        #region getValueChanged Datetimepicker
        private void dt_NgaySinh_ValueChanged(object sender, EventArgs e)
        {
            NgaySinh = dt_NgaySinh.Value;
        }
        #endregion
        #region AutoComplete
        public void AutoCompleteTenTG()
        {
            HelperGUI.Instance.autocompleteTenTacGia(tb_TenTacGia);
        }
        #endregion
        #region LoadfrmTacGia
        private void frmTacGia_Load(object sender, EventArgs e)
        {
            dgv_DuLieu.AutoGenerateColumns = false;
            fillAllDataFromTableTacGia();
            AutoCompleteTenTG();
        }
        #endregion
        #region Event Click
        private void bt_CNDL_Click(object sender, EventArgs e)
        {
            TacGiaService sv = new TacGiaService();
            TacGiaDtos tdg = new TacGiaDtos();
            TenTacGia = HelperGUI.Instance.KiemTraHoTen(tb_TenTacGia.Text);
            NgaySinh = dt_NgaySinh.Value;
            tdg.TenTacGia = TenTacGia;
            tdg.NgaySinh = NgaySinh;
            sv.AddFormTacGia(tdg);
            MessageBox.Show("Thêm thành công!");
            fillAllDataFromTableTacGia();
            HelperGUI.ResetAllControls(groupControl_TTTG);
        }
        private void bt_Lamlai_Click(object sender, EventArgs e)
        {
            HelperGUI.ResetAllControls(groupControl_TTTG);
        }
        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            TacGiaService sv = new TacGiaService();
            List<TacGiaDtos> ls = new List<TacGiaDtos>();
            if(cbb_ThongTinTimKiem.Text=="Họ và tên")
            {
                ls = sv.getFormTacGiaSearchTenTacGia(tb_NhapTT.Text);
                dgv_DuLieu.DataSource = ls;
            }
        }
        private void toolStripBt_XuatCSV_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "csv File (.csv)|.csv|All files (.)|*.*";
                    sfd.Title = "Save an Excel File";
                    sfd.ShowDialog();

                    string DuongDan;
                    DuongDan = sfd.FileName;
                    List<TacGiaDtos> ls = new List<TacGiaDtos>();
                    TacGiaService pro = new TacGiaService();
                    ls = pro.getAllFormTacGia();
                    DialogResult dlg = MessageBox.Show("Bạn có chắc chắn xuất CSV!!", "Thông báo!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dlg.Equals(DialogResult.OK))
                    {
                        pro.ExportToCsvFile(ls, DuongDan);
                        MessageBox.Show("Xuất thành công!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch
            {

            }
        }
        #endregion
        public void fillAllDataFromTableTacGia()
        {
            List<TacGiaDtos> ls = new List<TacGiaDtos>();
            TacGiaService TDGsv = new TacGiaService();
            ls = TDGsv.getAllFormTacGia();
            dgv_DuLieu.DataSource = ls;
        } 
    }
}
