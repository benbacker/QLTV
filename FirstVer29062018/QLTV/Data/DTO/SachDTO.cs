using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class SachDTO
    {
        public int IDSach { get; set; }
        public int IDDauSach { get; set; }
        public int IDTacGia { get; set; }
        public string TenTG { get; set; }
        public string NhaXB { get; set; }
        public int NamXB { get; set; }
        public int SoLuongTon { get; set; }
        public decimal GiaTien { get; set; }
        public string TenDauSach { get; set; }
        public int IDLoaiSach { get; set; }
        public string TenLoaiSach { get; set; }
        public int IDCTPhieuNhap { get; set; }
        public int IDPhieuNhap { get; set; }
        public DateTime NgayNhap { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal TongTien { get; set; }
    }
}
