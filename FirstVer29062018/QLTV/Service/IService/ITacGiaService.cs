using Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface ITacGiaService
    {
        //getAllForm TacGia
        List<TacGiaDtos> getAllFormTacGia();
        //Add Form "TacGia"
        void AddFormTacGia(TacGiaDtos tacGia);
        //Edit Form "TacGia"
        void editFormTacGia(TacGiaDtos tacgia);
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
