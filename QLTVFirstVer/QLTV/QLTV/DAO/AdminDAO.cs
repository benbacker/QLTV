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
        #region Admin
        public string QueryCheckLogin(AdminDTO AD)
        {
            string Query = "Select * from USERADMIN where UserNameAdmin ='" + AD.UserNameAdmin + "' and PasswordAdmin ='" + AD.PasswordAdmin + "'";
            return Query;
        }

        public string QueryLoadAdmin()
        {
            string Query = "select * from USERADMIN,CT_USERADMIN where USERADMIN.IDAdmin = CT_USERADMIN.IDAdmin";
            return Query;
        }

        public string QuerySearchAdmin(string SearchTT, string NhapTT)
        {
            string Query = "select * from USERADMIN,CT_USERADMIN where USERADMIN.IDAdmin = CT_USERADMIN.IDAdmin and " + SearchTT + " like N'%" + NhapTT + "%'";
            return Query;
        }

        public string QueryInsertAdmin(AdminDTO AD)
        {
            string Query = "INSERT INTO USERADMIN VALUES ('" + AD.UserNameAdmin + "','" + AD.PasswordAdmin + "', N'" + AD.QuyenHan + "', N'" + AD.IDAdmin + "')";
            return Query;
        }

        public string QueryInsertCTAdmin(AdminDTO AD)
        {
            string Query = "INSERT INTO CT_USERADMIN VALUES ('" + AD.IDAdmin + "',N'" + AD.HoTenAdmin + "', '" + AD.NgaySinhAdmin + "', N'" + AD.DiaChiAdmin + "', N'" + AD.EmailAdmin + "')";
            return Query;
        }

        public string QueryGetChucVu(AdminDTO AD)
        {
            string Query = "select QuyenHan from USERADMIN where UserNameAdmin = '" + AD.UserNameAdmin + "' and PasswordAdmin = '" + AD.PasswordAdmin + "'";
            return Query;
        }

        public string QueryUpdateAdmin(AdminDTO AD)
        {
            string Query = "UPDATE CT_USERADMIN SET HoTenAdmin = N'" + AD.HoTenAdmin + "', NgaySinhAdmin = '" + AD.NgaySinhAdmin + "', DiaChiAdmin = N'" + AD.DiaChiAdmin + "', EmailAdmin = '" + AD.EmailAdmin + "' WHERE IDAdmin = '" + AD.IDAdmin + "'";
            return Query;
        }
        #endregion
    }
}
