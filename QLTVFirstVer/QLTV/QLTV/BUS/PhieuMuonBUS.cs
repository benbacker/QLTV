using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop.DAO;
using System.Data;
using Desktop.DTO;

namespace Desktop.BUS
{
    public class PhieuMuonBUS
    {
        PhieuMuonDAO PhieuMuon_DAO = new PhieuMuonDAO();
        #region LoadPhieuMuon
        public DataTable LoadSachPhieuMuon(string TenDauSach)
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(PhieuMuon_DAO.QueryLoadSachMuon(TenDauSach));
            return table;
        }
        public DataTable LoadPhieuMuon()
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(PhieuMuon_DAO.QueryLoadPhieuMuon());
            return table;
        }
        #endregion
        #region AutoTextBox
        public AutoCompleteStringCollection AutoTextBox(string Query, string column)
        {
            AutoCompleteStringCollection col;
            col = ConnectionSQL.AutoTextbox(Query, column);
            return col;
        }
        #endregion
        #region Autocombobox
        #region AutocomboboxPhieuMuon
        public DataTable autocombobox(string TenDauSach)
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(PhieuMuon_DAO.QueryAutocombobox(TenDauSach));
            return table;
        }
        #endregion
        #endregion
        #region Identity
        public int IdentityIDPhieuMuon()
        {
            int ID = 0;
            string column = "IDPhieuMuon";
            string table = "PhieuMuon";
            ID = ConnectionSQL.Identitytable(ID, column, table);
            return ID;
        }
        public int IdentityIDCTPhieuMuon()
        {
            int ID = 0;
            string column = "IDCTPhieuMuon";
            string table = "CT_PHIEUMUON";
            ID = ConnectionSQL.Identitytable(ID, column, table);
            return ID;
        }
        #endregion
        #region InsertPhieuMuon
        public bool InsertPhieuMuon(PhieuMuonDTO PM)
        {
            bool table = false;
            if (ConnectionSQL.ExecuteNonQuery(PhieuMuon_DAO.QueryInsertPHIEUMUON(PM)) > 0)
            {
                table = true;
            }
            return table;
        }

        public bool InsertCTPhieuMuon(PhieuMuonDTO PM)
        {
            bool table = false;
            if (ConnectionSQL.ExecuteNonQuery(PhieuMuon_DAO.QueryInsertCT_PHIEUMUON(PM)) > 0 && ConnectionSQL.ExecuteNonQuery(PhieuMuon_DAO.QueryUpdateCuonSach(PM)) > 0)
            {
                table = true;
            }
            return table;
        }
        #endregion
        public bool DeleteCTPhieuMuon(PhieuMuonDTO PM)
        {
            bool table = false;
            if (ConnectionSQL.ExecuteNonQuery(PhieuMuon_DAO.QueryDeletePhieuMuon(PM)) > 0)
            {
                table = true;
            }
            return table;
        }
    }
}
