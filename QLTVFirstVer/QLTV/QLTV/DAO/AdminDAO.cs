using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.DTO;
namespace Desktop.DAO
{
    public class AdminDAO
    {
        public string QueryCheckLogin(AdminDTO AD)
        {
            string Query = "Select * from USERADMIN where UserNameAdmin ='" + AD.UserNameAdmin + "' and PasswordAdmin ='" + AD.PasswordAdmin + "'";
            return Query;
        }
    }
}
