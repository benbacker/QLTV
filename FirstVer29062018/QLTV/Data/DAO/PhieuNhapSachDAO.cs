using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class PhieuNhapSachDAO
    {
        #region Instance
        private static PhieuNhapSachDAO instance;

        public static PhieuNhapSachDAO Instance
        {
            get
            {
                if (instance == null) instance = new PhieuNhapSachDAO(); return DAO.PhieuNhapSachDAO.instance;
            }

            private set
            {
                DAO.PhieuNhapSachDAO.instance = value;
            }
        }
        #endregion
        #region Operator+
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from a in db.PHIEUNHAPSACHes select a.IDPhieuNhap).Max()).ToString();
                int ID = Int32.Parse(query);
                int IDadd = ++ID;
                return IDadd;
            }
        }
        #endregion
       
    }
}
