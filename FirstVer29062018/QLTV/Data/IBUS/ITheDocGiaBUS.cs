using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.DTO;
using Data.DAO;
namespace Data.IBUS
{
    public interface ITheDocGiaBUS
    {
        bool AddTheDocGiaAndUser(TheDocGiaDtos DocGia, UserDtos user);
        //Edit Form "DocGia" And "User"
        bool editFormDocGiaAndUser(TheDocGiaDTO thedocgia);
        #region getListSearch Form "TheDocGia"
        List<TheDocGiaDTO> getFromTheDocGiaSearchHoTen(string TenDG);
        List<TheDocGiaDTO> getFormTheDocGiaSearchEmailDG(string EmailDG);
        List<TheDocGiaDTO> getFormTheDocGiaSearchDiaChiDG(string DiaChiDG);
        List<TheDocGiaDTO> getFormTheDocGiaSearchNgayLapThe(DateTime Ngaylap);
        List<TheDocGiaDTO> getFormTheDocGiaSearchNgaySinhDG(DateTime NgaySinh);
        List<TheDocGiaDTO> getFormTheDocGiaSearchUserName(string Username);
        #endregion
        #region getlist"TheDocGiaDTO" All"DocGia"and User 
        List<TheDocGiaDTO> getAllDocGiaAndUser();
        #endregion
        // Xuat file excel
        bool ExportToCsvFile(List<TheDocGiaDTO> TheDocGia, string fileName);
    }
}