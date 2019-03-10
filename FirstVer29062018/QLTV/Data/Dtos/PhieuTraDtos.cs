using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dtos
{
    public class PhieuTraDtos
    {
        public int IDPhieuTra { get; set; }
        public int IDDocGia { get; set; }
        public string TenDG { get; set; }
        public DateTime NgayTra { get; set; }
        public int IDPhieuMuon { get; set; }
    }
}
