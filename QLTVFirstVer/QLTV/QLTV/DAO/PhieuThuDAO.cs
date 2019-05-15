using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.DTO;

namespace Desktop.DAO
{
    public class PhieuThuDAO
    {
        public string QueryInsertPT(PhieuThuDTO PT)
        {
            string ID = "IDPhieuThu";
            string Bang = "PHIEUTHUTIENPHAT";
            PT.IDPhieuThu = ConnectionSQL.Identitytable(PT.IDPhieuThu, ID, Bang);
            string Query = "INSERT INTO PHIEUTHUTIENPHAT VALUES ('" + PT.IDPhieuThu + "','" + PT.IDDocGia + "', '" + PT.NgayLap + "', '" + PT.SoTienThu + "', '" + PT.ConLai + "')";
            return Query;
        }
    }
}
