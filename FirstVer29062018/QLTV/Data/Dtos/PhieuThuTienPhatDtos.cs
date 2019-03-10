using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dtos
{
    public class PhieuThuTienPhatDtos
    {
        public int IDPhieuThu { get; set; }
        public int IDDocGia { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal SoTienThu { get; set; }
        public decimal ConLai { get; set; }
    }
}
