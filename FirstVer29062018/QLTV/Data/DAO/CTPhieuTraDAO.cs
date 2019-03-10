using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class CTPhieuTraDAO
    {
        #region Instance
        private static CTPhieuTraDAO instance;

        public static CTPhieuTraDAO Instance
        {
            get
            {
                if (instance == null) instance = new CTPhieuTraDAO(); return DAO.CTPhieuTraDAO.instance;
            }

            private set
            {
                DAO.CTPhieuTraDAO.instance = value;
            }
        }
        #endregion
        #region Operator+
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from a in db.CT_PHIEUTRA select a.IDPhieuTra).Max()).ToString();
                int ID = Int32.Parse(query);
                int IDadd = ++ID;
                return IDadd;
            }
        }
        #endregion
    }
}
