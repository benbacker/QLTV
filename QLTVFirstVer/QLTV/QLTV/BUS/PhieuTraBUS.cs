using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.DAO;
using System.Data;

namespace Desktop.BUS
{
    public class PhieuTraBUS
    {
        PhieuTraDAO PhieuTra_DAO = new PhieuTraDAO();
        #region LoadPhieuTra
        public DataTable LoadSachPhieuTra(int IDDocGia)
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(PhieuTra_DAO.QueryLoadSachTra(IDDocGia));
            return table;
        }

        public DataTable LoadPhieuTra()
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(PhieuTra_DAO.QueryLoadPhieuTra());
            return table;
        }
        #endregion
    }
}
