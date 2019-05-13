using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.DAO
{
    public class ReportPhieuTraDAO
    {
        public string LoadReportPT()
        {
            string Query = "select * from BCSACHTRATRE";
            return Query;
        }
    }
}
