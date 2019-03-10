using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class PhieuMuonDTO
    {
        public int IDPhieuMuon { get; set; }
        public int IDDocGia { get; set; }
        public string TenNguoiMuon { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
        public int IDCuonSach { get; set; }
        public int IDCTPhieuMuon { get; set; }
        public string TenDauSach { get; set; }
    }
}
