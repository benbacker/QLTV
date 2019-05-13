using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.DAO;
using Desktop.DTO;

namespace Desktop.BUS
{
    public class AdminBUS
    {
        AdminDAO AD_DAO = new AdminDAO();
        public bool CheckLogin(AdminDTO AD)
        {
            if (ConnectionSQL.check(AD_DAO.QueryCheckLogin(AD)) == true) return true;
            return false;
        }
    }
}
