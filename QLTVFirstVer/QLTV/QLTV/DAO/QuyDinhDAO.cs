using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.DTO;

namespace Desktop.DAO
{
    public class QuyDinhDAO
    {
        #region QuyDinh
        public string QueryLoadQuyDinh()
        {
            string Query = "Select * from ThamSo";
            return Query;
        }

        public string QueryUpdate(QuyDinhDTO QD)
        {
            string Query = "UPDATE ThamSo SET TuoiMin = N'" + QD.TuoiMin + "', TuoiMax = '" + QD.TuoiMax + "', HanThe = '" + QD.HanThe + "', KhoangCachXB = '" + QD.KhoangCachXB + "', SoSachMuonMax = '" + QD.SoSachMuonMax + "', SoNgayMuonMax = '" + QD.SoNgayMuonMax + "', TienPhatMoiNgay = '" + QD.TienPhatMoiNgay + "'";
            return Query;
        }
        #endregion
    }
}
