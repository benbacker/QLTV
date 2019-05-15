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
    public class AdminBUS
    {
        AdminDAO AD_DAO = new AdminDAO();
        #region Admin
        public bool CheckLogin(AdminDTO AD)
        {
            if (ConnectionSQL.check(AD_DAO.QueryCheckLogin(AD)) == true) return true;
            return false;
        }

        public DataTable LoadAdmin()
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(AD_DAO.QueryLoadAdmin());
            return table;
        }

        public DataTable SearchAdmin(string TT,string Search)
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(AD_DAO.QuerySearchAdmin(TT,Search));
            return table;
        }

        public bool InsertAdmin(AdminDTO AD)
        {
            bool table = false;
            if (ConnectionSQL.ExecuteNonQuery(AD_DAO.QueryInsertCTAdmin(AD)) > 0 && ConnectionSQL.ExecuteNonQuery(AD_DAO.QueryInsertAdmin(AD)) > 0)
            {
                table = true;
            }
            return table;
        }

        public bool UpdateAdmin(AdminDTO AD)
        {
            bool table = false;
            if (ConnectionSQL.ExecuteNonQuery(AD_DAO.QueryUpdateAdmin(AD)) > 0)
            {
                table = true;
            }
            return table;
        }

        public int IdentityIDAdmin()
        {
            int ID = 0;
            string column = "IDAdmin";
            string table = "CT_USERADMIN";
            ID = ConnectionSQL.Identitytable(ID, column, table);
            return ID;
        }

        public string GetQuyenHan(AdminDTO AD)
        {
            string QuyenHan;
            string Get = "QuyenHan";
            QuyenHan = ConnectionSQL.GetStringTable(Get, AD_DAO.QueryGetChucVu(AD));
            return QuyenHan;
        }
        #endregion
    }
}
