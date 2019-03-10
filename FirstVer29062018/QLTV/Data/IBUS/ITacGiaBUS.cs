using Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IBUS
{
    public interface ITacGiaBUS
    {
        //getAllForm TacGia
        List<TacGiaDtos> getAllFormTacGia();
        //Edit Form "TacGia"
        bool editFormTacGia(TacGiaDtos tacgia);
        //Add Form "TacGia"
        bool AddFormTacGia(TacGiaDtos tacGia);
        // getList Search IDTacGia From"TacGia"
        List<TacGiaDtos> getFormTacGiaSearchIDTacGia(int ID);
        //getList Search TenTacGia From "TacGia"
        List<TacGiaDtos> getFormTacGiaSearchTenTacGia(string TenTG);
        //getList Search NgaySinhTacGia From "TacGia"
        List<TacGiaDtos> getFormTacGiaSearchNgaySinhTG(DateTime NgaySinh);
        //Xuat file excel
        bool ExportToCsvFile(List<TacGiaDtos> tacgia, string fileName);
    }
}
