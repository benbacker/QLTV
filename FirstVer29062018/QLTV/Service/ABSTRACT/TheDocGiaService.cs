using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.IService;
using Data.IBUS;
using Data.BUS;
using Data.Dtos;
using Data.DAO;
using Data.DTO;

namespace Service.ABSTRACT
{
    public class TheDocGiaService : ITheDocGiaService
    {
        private ITheDocGiaBUS _TheDocGiaBUS;
        public TheDocGiaService()
        {
            this._TheDocGiaBUS = new TheDocGiaBUS();
        }
        // Add List "THeDocGia" and "User"
        public void AddTheDocGiaAndUser(TheDocGiaDtos DocGia, UserDtos user)
        {
            _TheDocGiaBUS.AddTheDocGiaAndUser(DocGia, user);
        }
        // Edit Form DocGia and User
        public void editFormDocGiaAndUser(TheDocGiaDTO thedocgia)
        {
            this._TheDocGiaBUS.editFormDocGiaAndUser(thedocgia);
        }
        #region getList"TheDOcGiaDTO" All "DocGia" and "User"
        public List<TheDocGiaDTO> getAllDocGiaAndUser()
        {
            return this._TheDocGiaBUS.getAllDocGiaAndUser();
        }
        #endregion
        #region getListSearch From "TheDocGia"
        // getListSearch HoTenDG From "TheDocGia"
        public List<TheDocGiaDTO> getFromTheDocGiaSearchHoTen(string TenDG)
        {
            return _TheDocGiaBUS.getFromTheDocGiaSearchHoTen(TenDG);
        }
        // getListSearch DiaChiDG From "TheDocGia"
        public List<TheDocGiaDTO> getFormTheDocGiaSearchDiaChiDG(string DiaChiDG)
        {
            return _TheDocGiaBUS.getFormTheDocGiaSearchDiaChiDG(DiaChiDG);
        }
        // getListSearch NgayLap From "TheDocGia"
        public List<TheDocGiaDTO> getFormTheDocGiaSearchNgayLapThe(DateTime Ngaylap)
        {
            return _TheDocGiaBUS.getFormTheDocGiaSearchNgayLapThe(Ngaylap);
        }
        // getListSearch NgaySinhDG From "TheDocGia"
        public List<TheDocGiaDTO> getFormTheDocGiaSearchNgaySinhDG(DateTime NgaySinh)
        {
            return _TheDocGiaBUS.getFormTheDocGiaSearchNgaySinhDG(NgaySinh);
        }
        // getListSearch EmailDG From "TheDocGia"
        public List<TheDocGiaDTO> getFromTheDocGiaSearchEmaiLDG(string EmailDG)
        {
            return _TheDocGiaBUS.getFormTheDocGiaSearchEmailDG(EmailDG);
        }
        //getListSearch UserName
        public List<TheDocGiaDTO> getFormTheDocGiaSearchUserName(string Username)
        {
            return _TheDocGiaBUS.getFormTheDocGiaSearchUserName(Username);
        }
        #endregion
        // xuat file excel
        public bool ExportToCsvFile(List<TheDocGiaDTO> TheDocGia, string fileName)
        {
            return _TheDocGiaBUS.ExportToCsvFile(TheDocGia, fileName);
        }

    }

}
