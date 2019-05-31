using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.DTO;
using Desktop.DAO;
using System.Data;

namespace Desktop.BUS
{
    class TacGiaBUS
    {
        private static TheDocGiaBUS instance;
        public static TheDocGiaBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TheDocGiaBUS();
                return instance;
            }
        }
        TacGiaDAO TG_DAO = new TacGiaDAO();
        #region LoadTacGia
        public DataTable LoadTacGia()
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(TG_DAO.QueryLoadTG());
            return table;
        }
        #endregion
        #region InsertTacGia
        public bool InsertTacGia(TacGiaDTO TG)
        {
            bool table = false;
            if (ConnectionSQL.ExecuteNonQuery(TG_DAO.QueryInsertTG(TG)) > 0)
            {
                table = true;
            }
            return table;
        }
        #endregion
        #region UpdateTacGia
        public bool UpdateTacGia(TacGiaDTO TG)
        {
            bool table = false;
            if (ConnectionSQL.ExecuteNonQuery(TG_DAO.QueryUpdateTG(TG)) > 0)
            {
                table = true;
            }
            return table;
        }
        #endregion
        #region DeleteTacGia
        public bool DeteleTacGia(int IDTG)
        {
            bool table = false;
            if (ConnectionSQL.ExecuteNonQuery(TG_DAO.QueryDeleteTacGia(IDTG)) > 0)
            {
                table = true;
            }
            return table;
        }
        #endregion
        #region SearchTacGia
        public DataTable SearchTacGia(string SearchTT, string NhapTT)
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(TG_DAO.QuerySearchTG(SearchTT,NhapTT));
            return table;
        }
        #endregion
    }
}
