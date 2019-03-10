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
    public class SachService : ISachService
    {
        private ISachBUS _iSachBUS;
        public SachService()
        {
            this._iSachBUS = new SachBUS();
        }
        public void ADDFormSach(SachDTO sach)
        {
            this._iSachBUS.ADDFormSach(sach);
        }
        //EditForm DauSach, Sach, CT_PhieuNhap
        public void editFormDauSachAndSachAndCTPhieuNhap(SachDTO sach)
        {
            this._iSachBUS.editFormDauSachAndSachAndCTPhieuNhap(sach);
        }
        //Xuat file excel
        public bool ExportToCsvFile(List<SachDTO> sach, string fileName)
        {
            return this._iSachBUS.ExportToCsvFile(sach, fileName);
        }

        //getALl Form DauSach And CTPhieuNhap And "Sach"
        public List<SachDTO> getAllFormDauSachandCTPhieuNhapAndSach()
        {
            return this._iSachBUS.getAllFormDauSachandCTPhieuNhapAndSach();
        }
        #region getListSearch SachDTO
        //get List Search Namxuatban
        public List<SachDTO> getFormSachNamXuatBan(string NamXB)
        {
            return this._iSachBUS.getFormSachNamXuatBan(NamXB);
        }
        //get List Search NhaXuatban
        public List<SachDTO> getFormSachNhaXuatBan(string NhaxB)
        {
            return this._iSachBUS.getFormSachNhaXuatBan(NhaxB);
        }
        //get List Search GiaTien
        public List<SachDTO> getFormSachSearchGiaTien(decimal tien)
        {
            return this._iSachBUS.getFormSachSearchGiaTien(tien);
        }
        //get List Search IDSach
        public List<SachDTO> getFormSachSearchIDSach(int IDsach)
        {
            return this._iSachBUS.getFormSachSearchIDSach(IDsach);
        }
        //get List Search SoLuongTon
        public List<SachDTO> getFormSachSearchSoLuongTon(int SL)
        {
            return this._iSachBUS.getFormSachSearchSoLuongTon(SL);
        }
        //get List Search TenDauSach
        public List<SachDTO> getFormSachTenDauSach(string TenDauSach)
        {
            return this._iSachBUS.getFormSachTenDauSach(TenDauSach);
        }
        #endregion
    }
}
