using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class PhieuThuTienPhatDAO
    {
        #region Instance
        private static PhieuThuTienPhatDAO instance;

        public static PhieuThuTienPhatDAO Instance
        {
            get
            {
                if (instance == null) instance = new PhieuThuTienPhatDAO(); return DAO.PhieuThuTienPhatDAO.instance;
            }

            private set
            {
                DAO.PhieuThuTienPhatDAO.instance = value;
            }
        }
        #endregion
        #region Operator+
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from a in db.PHIEUTHUTIENPHATs select a.IDPhieuThu).Max()).ToString();
                int ID = Int32.Parse(query);
                int IDadd = ++ID;
                return IDadd;
               
            }
        }
        #endregion

    }
}
