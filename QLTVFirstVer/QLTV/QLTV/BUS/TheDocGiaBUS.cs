using Desktop.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desktop.DTO;
using Desktop.GUI;
using System.Data;

namespace Desktop.BUS
{
    public class TheDocGiaBUS
    {
        TheDocGiaDAO TDG_DAO = new TheDocGiaDAO();
        #region SearchTheDocGia
        public DataTable SearchTheDocGia(string SearchTT, string NhapTT)
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(TDG_DAO.QuerySearchTDG(SearchTT, NhapTT));
            return table;
        }
        #endregion
        #region LoadTheDocGia
        public DataTable LoadTheDocGia()
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(TDG_DAO.QueryLoadTDG());
            return table;
        }
        #endregion
        #region InsertTheDocGia
        public bool InsertTheDocGia(TheDocGiaDTO TDG)
        {
            bool table = false;
            if (ConnectionSQL.ExecuteNonQuery(TDG_DAO.QueryInsertTDG(TDG)) > 0)
            {
                table = true;
            }
            return table;
        }

        public bool InsertUser(UserDTO User)
        {
            bool table = false;
            if (ConnectionSQL.ExecuteNonQuery(TDG_DAO.QueryInsertUser(User)) > 0)
            {
                table = true;
            }
            return table;
        }
        #endregion
        #region DeleteTheDocGia
        public bool DeleteTheDocGia(int ID)
        {
            bool table = false;
            if (ConnectionSQL.ExecuteNonQuery(TDG_DAO.QueryDeleteUser(ID)) > 0 && ConnectionSQL.ExecuteNonQuery(TDG_DAO.QueryDeletePhieuThu(ID)) >= 0 && ConnectionSQL.ExecuteNonQuery(TDG_DAO.QueryDeleteTDG(ID)) > 0)
            {
                table = true;
            }
            return table;
        }

        public DataTable CheckTDGinPM(int ID)
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(TDG_DAO.QueryCheckTDGinPM(ID));
            return table;
        }
        #endregion
        #region UpdateTheDocGia
        public bool UpdateTheDocGia(TheDocGiaDTO TDG, UserDTO user)
        {
            bool table = false;
            if (ConnectionSQL.ExecuteNonQuery(TDG_DAO.QueryUpdateTDG(TDG)) > 0 && ConnectionSQL.ExecuteNonQuery(TDG_DAO.QueryUpdateUser(user)) > 0)
            {
                table = true;
            }
            return table;
        }
        #endregion
        #region GetTuoi
        public string GetTuoimin()
        {
            string TuoiMin;
            string Get = "TuoiMin";
            TuoiMin = ConnectionSQL.GetStringTable(Get, TDG_DAO.GetStringMin());
            return TuoiMin;
        }

        public string GetTuoimax()
        {
            string TuoiMax;
            string Get = "TuoiMax";
            TuoiMax = ConnectionSQL.GetStringTable(Get, TDG_DAO.GetStringMax());
            return TuoiMax;
        }
        #endregion
    }
}
