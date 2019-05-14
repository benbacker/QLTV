using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.DTO;

namespace Desktop.DAO
{
    public class ReportPhieuMuonDAO
    {
        #region Report
        public string InsertBCPHIEUMUON(ReportPhieuMuonDTO ReportPM)
        {
            string Query = "INSERT INTO BCTINHHINHMUONSACH VALUES ('" + ReportPM.IDBCMuonSach + "',N'" + ReportPM.NgayLap + "', '" + ReportPM.Thang + "', '" + ReportPM.Nam + "', '" + ReportPM.TongSoLuotMuon + "')";
            return Query;
        }

        public string LoadReportPM()
        {
            string Query = "select * from BCTINHHINHMUONSACH";
            return Query;
        }

        public string TongS(int IDBCMuonSach)
        {
            string Query = "select TongSoLuotMuon from BCTINHHINHMUONSACH where IDBCMuonSach = "+ IDBCMuonSach + "";
            return Query;
        }

        public string GetReport(int IDBCMuonSach)
        {
            string Query = "select * from BCTINHHINHMUONSACH,CT_BCTINHHINHMUONSACH,LOAISACH where BCTINHHINHMUONSACH.IDBCMuonSach = CT_BCTINHHINHMUONSACH.IDBCMuonSach and LOAISACH.IDLoaiSach = CT_BCTINHHINHMUONSACH.IDLoaiSach and BCTINHHINHMUONSACH.IDBCMuonSach = "+ IDBCMuonSach + "";
            return Query;
        }
        #endregion
    }
}
