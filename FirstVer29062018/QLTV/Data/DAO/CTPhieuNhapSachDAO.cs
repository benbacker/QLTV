using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class CTPhieuNhapSachDAO
    {
        #region Instance
        private static CTPhieuNhapSachDAO instance;

        public static CTPhieuNhapSachDAO Instance
        {
            get
            {
                if (instance == null) instance = new CTPhieuNhapSachDAO(); return DAO.CTPhieuNhapSachDAO.instance;
            }

            private set
            {
                DAO.CTPhieuNhapSachDAO.instance = value;
            }
        }
        #endregion
        #region Operator+
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from a in db.CT_PHIEUNHAPSACH select a.IDCTPhieuNhap).Max()).ToString();
                int ID = Int32.Parse(query);
                int IDadd = ++ID;
                return IDadd;
            }
        }
        #endregion
      
    }
}
