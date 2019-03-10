using Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IBUS
{
    public interface ILoaiSachBUS
    {
        //ADDfrom "LoaiSach"
        bool AddFromLoaiSach(LoaiSachDtos LS);
        //getListSearch TenLoaiSach from "LoaiSach"
        List<LoaiSachDtos> getFromLoaiSachSearchTenLoaiSach(string TenLoaiSach);
        //getListData IDLoaiSach from "LoaiSach"
        List<LoaiSachDtos> getFromLoaiSach(int ID);
    }
}
