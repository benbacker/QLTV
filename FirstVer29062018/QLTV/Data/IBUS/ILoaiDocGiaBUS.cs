using Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IBUS
{
    public interface ILoaiDocGiaBUS
    {
        //Add Form "LoaiDocGia"
        bool ADDLoaiDocGia(LoaiDocGiaDtos LoaiDG);
        //getList Search IDLoaiDG From "LoaiDocGia"
        List<LoaiDocGiaDtos> getFormLoaiDocGiaSearchIDLoaiDG(int ID);
        // getList Search TenLoaiDG From "LoaiDocGia"
        List<LoaiDocGiaDtos> getFormLoaiDocGiaSearchTenLoaiDG(string TenLoaiDG);
        
    }
}
