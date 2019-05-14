using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.DAO;
using Desktop.DTO;
using System.Data;

namespace Desktop.BUS
{
    public class QuyDinhBUS
    {
        QuyDinhDAO QD_DAO = new QuyDinhDAO();
        public DataTable LoadQuyDinh()
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(QD_DAO.QueryLoadQuyDinh());
            return table;
        }
        public bool UpdateQuyDinh(QuyDinhDTO QD)
        {
            bool table = false;
            if (ConnectionSQL.ExecuteNonQuery(QD_DAO.QueryUpdate(QD)) > 0)
            {
                table = true;
            }
            return table;
        }
    }
}
