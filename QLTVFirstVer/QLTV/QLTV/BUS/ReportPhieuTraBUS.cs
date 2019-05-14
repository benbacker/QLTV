using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.DAO;
using Desktop.DTO;

namespace Desktop.BUS
{
    public class ReportPhieuTraBUS
    {
        ReportPhieuTraDAO RP = new ReportPhieuTraDAO();
        #region Load
        public DataTable LoadReportPT()
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(RP.LoadReportPT());
            return table;
        }
        #endregion
        #region GETReport
        public List<ReportPhieuTraDTO> RPBC()
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(RP.LoadTTReportPT());
            List<ReportPhieuTraDTO> data = new List<ReportPhieuTraDTO>();
            data = (from DataRow row in table.Rows
                    select new ReportPhieuTraDTO
                    {
                        IDBCSachTre = Convert.ToInt32(row["IDBCSachTre"]),
                        NgayThangNam = Convert.ToDateTime(row["NgayThangNam"]),
                        IDCuonSach = Convert.ToInt32(row["IDCuonSach"]),
                        TenCuonSach = row["TenDauSach"].ToString(),
                        IDPhieuMuon = Convert.ToInt32(row["IDPhieuMuon"]),
                        SoNgayTraTre = Convert.ToInt32(row["SoNgayTraTre"])

                    }).ToList();
            return data;
        }

        public string GetTongS()
        {
            string TongS;
            string Get = "SL";
            TongS = ConnectionSQL.GetStringTable(Get, RP.TongS());
            return TongS;
        }
        #endregion
    }
}
