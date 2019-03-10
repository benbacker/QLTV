using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dtos
{
    public class CTPhieuNhapSachDtos
    {
        public int  IDCTPhieuNhap { get; set; }
        public int IDPhieuNhap { get; set; }
        public int IDSach { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal TongTien { get; set; }
    }
}
