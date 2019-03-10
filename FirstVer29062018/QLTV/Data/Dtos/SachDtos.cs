using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Dtos
{
    public class SachDtos
    {
        public int IDSach { get; set; }
        public int IDDauSach { get; set; }
        public int IDCTTacGia { get; set; }
        public string  NhaXB { get; set; }
        public int  NamXB { get; set; }
        public int SoLuongTon { get; set; }
        public decimal GiaTien { get; set; }
    }

}
