using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class DauSachDAO
    {
        #region Instance
        private static DauSachDAO instance;

        public static DauSachDAO Instance
        {
            get
            {
                if (instance == null) instance = new DauSachDAO(); return DAO.DauSachDAO.instance;
            }

            private set
            {
                DAO.DauSachDAO.instance = value;
            }
        }
        #endregion
        #region Operator+
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from a in db.DAUSACHes select a.IDDauSach).Max()).ToString();
                int ID = Int32.Parse(query);
                int IDadd = ++ID;
                return IDadd;
            }
        }
        #endregion
    }
}
