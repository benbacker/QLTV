using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class BaoCaoTinhHinhMuonSachDTO
    {
        public int IDCTBCMuonSach { get; set; }
        public int IDBCMuonSach { get; set; }
        public int IDLoaiSach { get; set; }
        public int SoLuotMuon { get; set; }
        public double TiLe { get; set; }
        public DateTime NgayLap { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public int TongSoLuotMuon { get; set; }
        public string TenTheLoai { get; set; }
    }
}
