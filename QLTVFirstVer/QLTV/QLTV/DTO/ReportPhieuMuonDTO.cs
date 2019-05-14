using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.DTO
{
    public class ReportPhieuMuonDTO
    {
        public int IDBCMuonSach { get; set; }
        public DateTime NgayLap { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public int TongSoLuotMuon { get; set; }
        public int IDCTBCMuonSach { get; set; }
        public int IDLoaiSach { get; set; }
        public int SoLuotMuon { get; set; }
        public string TenTheLoai { get; set; }
        public float TiLe { get; set; }
    }
}
