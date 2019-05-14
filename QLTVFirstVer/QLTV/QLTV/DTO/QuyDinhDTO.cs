using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.DTO
{
    public class QuyDinhDTO
    {
        public int TuoiMin { get; set; }
        public int TuoiMax { get; set; }
        public int HanThe { get; set; }
        public int KhoangCachXB { get; set; }
        public int SoSachMuonMax { get; set; }
        public int SoNgayMuonMax { get; set; }
        public decimal TienPhatMoiNgay { get; set; }
        public int ApDungQDSoTienThu { get; set; }
    }
}
