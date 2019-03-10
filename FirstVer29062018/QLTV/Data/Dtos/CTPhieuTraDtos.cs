using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dtos
{
    public class CTPhieuTraDtos
    {
        public int IDCTPhieuTra { get; set; }
        public int IDCuonSach { get; set; }
        public int IDPhieuTra { get; set; }
        public int  IDPhieuMuon { get; set; }
        public int SoNgayMuon { get; set; }
        public decimal TienPhat { get; set; }
    }
}
