using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.DTO;
using Desktop.DAO;
using System.Data;
using System.Windows.Forms;

namespace Desktop.BUS
{
    public class SachBUS
    {
        SachDAO Sach_DAO = new SachDAO();
        #region LoadSach
        public DataTable LoadSach()
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(Sach_DAO.QueryLoadSach());
            return table;
        }
        #endregion
        #region AutocomboboxSach
        public DataTable autocombobox()
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(Sach_DAO.QueryAutocombobox());
            return table;
        }
        #endregion
        #region AutoTextBox
        public AutoCompleteStringCollection AutoTextBox(string Query,string column)
        {
            AutoCompleteStringCollection col;
            col = ConnectionSQL.AutoTextbox(Query, column);
            return col;
        }
        #endregion
        #region CovertID
        public int ConvertNameToID(string TenTG)
        {
            int ID = ConnectionSQL.ConvertNameToID(TenTG);
            return ID;
        }
        #endregion
        #region IdentityID
        public int IdentityIDSach()
        {
            int ID = 0;
            string column = "IDSach";
            string table = "Sach";
            ID = ConnectionSQL.Identitytable(ID, column, table);
            return ID;
        }
        #endregion
        #region InsertSach
        public bool InsertSach(SachDTO S)
        {
            bool table = false;
            if (ConnectionSQL.ExecuteNonQuery(Sach_DAO.QueryInsertDauSach(S)) > 0 && ConnectionSQL.ExecuteNonQuery(Sach_DAO.QueryInsertSach(S)) > 0 && ConnectionSQL.ExecuteNonQuery(Sach_DAO.QueryInsertPhieuNhapSach(S)) > 0 && ConnectionSQL.ExecuteNonQuery(Sach_DAO.QueryInsertCT_PhieuNhapSach(S)) > 0)
            {
                table = true;
            }
            return table;
        }

        public bool InsertCuonSach(SachDTO S)
        {
            bool table = false;
            if (ConnectionSQL.ExecuteNonQuery(Sach_DAO.QueryInsertCuonSach(S)) > 0)
            {
                table = true;
            }
            return table;
        }

        public bool InsertTheLoaiSach(SachDTO S)
        {
            bool table = false;
            if (ConnectionSQL.ExecuteNonQuery(Sach_DAO.QueryInsertTheLoaiSach(S)) > 0)
            {
                table = true;
            }
            return table;
        }
        #endregion
        #region UpdateSach
        public bool UpdateSach(SachDTO S)
        {
            bool table = false;
            if (ConnectionSQL.ExecuteNonQuery(Sach_DAO.QueryUpdateSach(S)) > 0 && ConnectionSQL.ExecuteNonQuery(Sach_DAO.QueryUpdateDauSach(S)) > 0 && ConnectionSQL.ExecuteNonQuery(Sach_DAO.QueryUpdateCT_PHIEUNHAPSACH(S)) > 0 && ConnectionSQL.ExecuteNonQuery(Sach_DAO.QueryUpdatePHIEUNHAPSACH(S)) > 0)
            {
                table = true;
            }
            return table;
        }
        #endregion
        #region SearchSach
        public DataTable SearchSach(string SearchTT, string NhapTT)
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(Sach_DAO.QuerySearchSach(SearchTT, NhapTT));
            return table;
        }
        #endregion
    }
}
