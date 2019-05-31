using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.DTO;

namespace Desktop.DAO
{
    class TacGiaDAO
    {
        #region QueryTacGia
        public string QueryLoadTG()
        {
            string Query = "select * From TacGia order by IDTacGia asc";
            return Query;
        }

        public string QueryInsertTG(TacGiaDTO TG)
        {
            string ID = "IDTacGia";
            string Bang = "TacGia";
            TG.IDTacGia = ConnectionSQL.Identitytable(TG.IDTacGia, ID, Bang);
            string Query = "INSERT INTO TacGia VALUES ('" + TG.IDTacGia + "',N'" + TG.TenTacGia + "', '" + TG.NgaySinh + "')";
            return Query;
        }

        public string QueryUpdateTG(TacGiaDTO TG)
        {
            string Query = "UPDATE TacGia SET TenTacGia = N'" + TG.TenTacGia + "', NgaySinh = '" + TG.NgaySinh + "' WHERE IDTacGia = '" + TG.IDTacGia + "'";
            return Query;
        }

        public string QuerySearchTG(string SearchTT, string NhapTT)
        {
            string Query = "select * From TacGia where  " + SearchTT + " like N'%" + NhapTT + "%' order by IDTacGia asc";
            return Query;
        }

        public string QueryDeleteTacGia(int IDTG)
        {
            string Query = "DELETE TacGia WHERE IDTacGia = " + IDTG + "";
            return Query;
        }
        #endregion
    }
}
