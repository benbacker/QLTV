using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.DAO
{
    public class ReportPhieuTraDAO
    {
        #region Report
        public string LoadReportPT()
        {
            string Query = "select * from BCSACHTRATRE";
            return Query;
        }

        public string LoadTTReportPT()
        {
            string Query = "select * from BCSACHTRATRE,CUONSACH,SACH,DAUSACH where BCSACHTRATRE.IDCuonSach = CUONSACH.IDCuonSach and CUONSACH.IDSach = Sach.IDSach and DAUSACH.IDDauSach = Sach.IDDauSach";
            return Query;
        }

        public string TongS()
        {
            string Query = "select sum(SoNgayTraTre) AS SL from BCSACHTRATRE";
            return Query;
        }
        #endregion
    }
}
