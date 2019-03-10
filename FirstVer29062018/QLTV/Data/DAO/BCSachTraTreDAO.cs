using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class BCSachTraTreDAO
    {
        #region Instance
        private static BCSachTraTreDAO instance;

        public static BCSachTraTreDAO Instance
        {
            get
            {
                if (instance == null) instance = new BCSachTraTreDAO(); return DAO.BCSachTraTreDAO.instance;
            }

            private set
            {
                DAO.BCSachTraTreDAO.instance = value;
            }
        }
        #endregion
        #region Operator+ // if user click"add" ID... + 1
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from a in db.BCSACHTRATREs select a.IDBCSachTre).Max()).ToString();
                int ID = Int32.Parse(query);
                int IDadd = ++ID;
                return IDadd;
            }
        }
        #endregion
    }
}
