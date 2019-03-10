using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.DTO;
namespace Service.IService
{
    public interface ITheDocGiaService
    {
        // Add From"TheDocGia" and "User"
        void AddTheDocGiaAndUser(TheDocGiaDtos DocGia, UserDtos user);
        //Edit Form "DocGia" And "User"
        void editFormDocGiaAndUser(TheDocGiaDTO thedocgia);
        #region getlist"TheDocGiaDTO" All"DocGia"and User 
        List<TheDocGiaDTO> getAllDocGiaAndUser();
        #endregion
        #region getListSearch From "TheDocGia"
        List<TheDocGiaDTO> getFromTheDocGiaSearchHoTen(string TenDG);
        List<TheDocGiaDTO> getFromTheDocGiaSearchEmaiLDG(string EmailDG);
        List<TheDocGiaDTO> getFormTheDocGiaSearchDiaChiDG(string DiaChiDG);
        List<TheDocGiaDTO> getFormTheDocGiaSearchNgayLapThe(DateTime Ngaylap);
        List<TheDocGiaDTO> getFormTheDocGiaSearchNgaySinhDG(DateTime NgaySinh);
        List<TheDocGiaDTO> getFormTheDocGiaSearchUserName(string Username);
        #endregion
        // Xuat file excel
        bool ExportToCsvFile(List<TheDocGiaDTO> TheDocGia, string fileName);

    }
}
