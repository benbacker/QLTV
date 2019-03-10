using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dtos
{
    public class BCSachTraTreDtos
    {
        public int IDBCSachTre { get; set; }
        public DateTime NgayThangNam { get; set; }
        public int IDCuonSach { get; set; }
        public string TenCuonSach { get; set; }
        public int IDPhieuMuon { get; set; }
        public int SoNgayTraTre { get; set; }
    }
}
