using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.DTO
{
    public class PhieuTraDTO
    {
        public int IDPhieuTra { get; set; }
        public int IDDocGia { get; set; }
        public string TenDocGia { get; set; }
        public DateTime NgayTra { get; set; }
        public decimal SoTienTra { get; set; }
        public int IDPhieuMuon { get; set; }
        public int IDCuonSach { get; set; }
        public int IDCTPhieuTra { get; set; }
        public string TenDauSach { get; set; }
        public int SoNgayMuon { get; set; }
        public decimal TienPhat { get; set; }
        public decimal TienPhatKyNay { get; set; }
        public decimal TienNoKyNay { get; set; }
    }
}
