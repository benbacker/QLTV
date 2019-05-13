using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.DAO;

namespace Desktop.BUS
{
    public class ReportPhieuTraBUS
    {
        ReportPhieuTraDAO RP = new ReportPhieuTraDAO();
        public DataTable LoadReportPT()
        {
            DataTable table;
            table = ConnectionSQL.TaoBang(RP.LoadReportPT());
            return table;
        }
    }
}
