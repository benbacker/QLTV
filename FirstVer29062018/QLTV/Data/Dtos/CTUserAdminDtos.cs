using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dtos
{
    public class CTUserAdminDtos
    {
        public int IDAdmin { get; set; }
        public string HoTenAdmin { get; set; }
        public string  DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Email { get; set; }
    }
}
