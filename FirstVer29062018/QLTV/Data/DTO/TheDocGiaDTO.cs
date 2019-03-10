using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class TheDocGiaDTO
    {
        public int IDDocGia { get; set; }
        public string HoTenDG { get; set; }
        public DateTime NgaySinhDG { get; set; }
        public string DiaChiDG { get; set; }
        public string EmailDG { get; set; }
        public string TenLoaiDocGia { get; set; }
        public int IDLoaiDocGia { get; set; }
        public DateTime NgayLapThe { get; set; }
        public DateTime NgayHetHan { get; set; }
        public Decimal TongNo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
