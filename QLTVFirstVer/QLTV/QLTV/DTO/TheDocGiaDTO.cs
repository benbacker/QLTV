using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.DTO
{
    public class TheDocGiaDTO
    {
        public int IDDocGia { get; set; }
        public string HoTenDG { get; set; }
        public DateTime NgaySinhDG { get; set; }
        public string DiaChiDG { get; set; }
        public string EmailDG { get; set; }
        public string TenLoaiDocGia { get; set; }
        public int IDLoaiDG { get; set; }
        public DateTime NgayLapThe { get; set; }
        public DateTime NgayHetHan { get; set; }
        public Decimal TongNo { get; set; }

        //public TheDocGiaDTO(int IDDocGia, string HoTenDG, string UserName, string DiaChiDG, string EmailDG, DateTime NgaySinhDG, DateTime NgayLapThe, DateTime NgayHetHan, string TenLoaiDocGia, Decimal TongNo)
        //{
        //    this.IDDocGia = IDDocGia;
        //    this.HoTenDG = HoTenDG;
        //    this.UserName = UserName;
        //    this.DiaChiDG = DiaChiDG;
        //    this.EmailDG = EmailDG;
        //    this.NgaySinhDG = NgaySinhDG;
        //    this.NgayLapThe = NgayLapThe;
        //    this.NgayHetHan = NgayHetHan;
        //    this.TenLoaiDocGia = TenLoaiDocGia;
        //    this.TongNo = TongNo;
        //}
    }
}
