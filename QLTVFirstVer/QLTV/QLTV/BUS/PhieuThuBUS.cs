using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.DAO;
using Desktop.DTO;

namespace Desktop.BUS
{
    public class PhieuThuBUS
    {
        PhieuThuDAO PT_DAO = new PhieuThuDAO();
        public bool InsertPhieuThu(PhieuThuDTO PT)
        {
            bool table = false;
            if (ConnectionSQL.ExecuteNonQuery(PT_DAO.QueryInsertPT(PT)) > 0)
            {
                table = true;
            }
            return table;
        }
    }
}
