using Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface ILoaiSachService
    {   
        //add Form "LoaiSach"
        void AddFromLoaiSach(LoaiSachDtos LS);
        //getLisData IDLoaiSach From "LoaiSach"
        List<LoaiSachDtos> getFromLoaiSach(int ID);
        //getListSearch TenLoaiSach From "LoaiSach"
        List<LoaiSachDtos> getFromLoaiSachSearchTenLoaiSach(string TenLoaiSach);
    }
}
