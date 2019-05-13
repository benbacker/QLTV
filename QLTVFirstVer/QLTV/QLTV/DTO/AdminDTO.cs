using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.DTO
{
    public class AdminDTO
    {
        public int IDAdmin { get; set; }
        public string HoTenAdmin { get; set; }
        public DateTime NgaySinhAdmin { get; set; }
        public string DiaChiAdmin { get; set; }
        public string EmailAdmin { get; set; }
        public string UserNameAdmin { get; set; }
        public string PasswordAdmin { get; set; }
        public string QuyenHan { get; set; }
    }
}
