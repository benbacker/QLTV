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
        #region Insert
        public bool InsertPhieuTra(PhieuTraDTO PT)
        {
            bool table = false;
            if (ConnectionSQL.ExecuteNonQuery(PhieuTra_DAO.QueryInsertPhieuTra(PT)) > 0)
            {
                table = true;
            }
            return table;
        }

        public bool InsertCTPhieuTra(PhieuTraDTO PT)
        {
            bool table = false;
            if (ConnectionSQL.ExecuteNonQuery(PhieuTra_DAO.QueryInsertCTPhieuTra(PT)) > 0)
            {
                table = true;
            }
            return table;
        }
        #endregion
        #region GetPhieuTra
        public int IdentityID()
        {
            int ID = 0;
            string column = "IDPhieuTra";
            string table = "PHIEUTRA";
            ID = ConnectionSQL.Identitytable(ID, column, table);
            return ID;
        }

        public int IdentityIDCTPhieuTra()
        {
            int ID = 0;
            string column = "IDCTPhieuTra";
            string table = "CT_PhieuTra";
            ID = ConnectionSQL.Identitytable(ID, column, table);
            return ID;
        }

        public decimal GetSoTienTra(int IDDocGia,int IDCuonSach)
        {
            decimal SLThamSo;
            string Get = "SL";
            SLThamSo = decimal.Parse(ConnectionSQL.GetStringTable(Get, PhieuTra_DAO.QueryGetSoTienTra(IDDocGia, IDCuonSach)));
            return SLThamSo;
        }
        #endregion
        #region Search
        public DataTable SearchPhieuTra(string SearchTT, string NhapTT)
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(PhieuTra_DAO.QuerySearch(SearchTT, NhapTT));
            return table;
        }
        #endregion
    }
}
