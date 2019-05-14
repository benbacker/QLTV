using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.DAO;
using Desktop.DTO;
using System.Data;

namespace Desktop.BUS
{
    public class ReportPhieuMuonBUS
    {
        ReportPhieuMuonDAO ReportPM = new ReportPhieuMuonDAO();
        #region Load
        public bool InsertReportPM(ReportPhieuMuonDTO PM)
        {
            bool table = false;
            if (ConnectionSQL.ExecuteNonQuery(ReportPM.InsertBCPHIEUMUON(PM)) > 0)
            {
                table = true;
            }
            return table;
        }

        public DataTable LoadReportPM()
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(ReportPM.LoadReportPM());
            return table;
        }
        #endregion
        #region GETReport
        public int IdentityIDBCPHIEUMUON()
        {
            int ID = 0;
            string column = "IDBCMuonSach";
            string table = "BCTINHHINHMUONSACH";
            ID = ConnectionSQL.Identitytable(ID, column, table);
            return ID;
        }

        public List<ReportPhieuMuonDTO> RPBC(int ID)
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(ReportPM.GetReport(ID));
            List<ReportPhieuMuonDTO> data = new List<ReportPhieuMuonDTO>();
            data = (from DataRow row in table.Rows
                    select new ReportPhieuMuonDTO
                    {
                        IDBCMuonSach = Convert.ToInt32(row["IDBCMuonSach"]),
                        NgayLap = Convert.ToDateTime(row["NgayLap"]),
                        Thang = Convert.ToInt32(row["Thang"]),
                        Nam = Convert.ToInt32(row["Nam"]),
                        TongSoLuotMuon = Convert.ToInt32(row["TongSoLuotMuon"]),
                        IDCTBCMuonSach = Convert.ToInt32(row["IDCTBCMuonSach"]),
                        IDLoaiSach = Convert.ToInt32(row["IDLoaiSach"]),
                        SoLuotMuon = Convert.ToInt32(row["SoLuotMuon"]),
                        TiLe = Convert.ToSingle(row["TiLe"]),
                        TenTheLoai = row["TenLoaiSach"].ToString(),
                    }).ToList();
            return data;
        }

        public string GetTongS(int ID)
        {
            string TongS;
            string Get = "TongSoLuotMuon";
            TongS = ConnectionSQL.GetStringTable(Get, ReportPM.TongS(ID));
            return TongS;
        }
        #endregion
    }
}
