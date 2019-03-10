using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class CTBCTinhHinhMuonSachDAO
    {
        #region Instance
        private static CTBCTinhHinhMuonSachDAO instance;

        public static CTBCTinhHinhMuonSachDAO Instance
        {
            get
            {
                if (instance == null) instance = new CTBCTinhHinhMuonSachDAO(); return DAO.CTBCTinhHinhMuonSachDAO.instance;
            }

            private set
            {
                DAO.CTBCTinhHinhMuonSachDAO.instance = value;
            }
        }
        #endregion
        #region Operator+
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from a in db.CT_BCTINHHINHMUONSACH select a.IDCTBCMuonSach).Max()).ToString();
                int ID = Int32.Parse(query);
                int IDadd = ++ID;
                return IDadd;
            }
        }
        #endregion
    }
}
