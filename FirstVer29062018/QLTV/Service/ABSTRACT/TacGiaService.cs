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
    public class TacGiaService : ITacGiaService
    {
        private ITacGiaBUS _TacGia;
        public TacGiaService()
        {
            this._TacGia = new TacGiaBUS();
        }
        //Add Form TacGia
        public void AddFormTacGia(TacGiaDtos tacGia)
        {
            this._TacGia.AddFormTacGia(tacGia);
        }
        //Edit FormTacGia
        public void editFormTacGia(TacGiaDtos tacgia)
        {
            this._TacGia.editFormTacGia(tacgia);
        }
        //Xuat file excel
        public bool ExportToCsvFile(List<TacGiaDtos> tacgia, string fileName)
        {
            return _TacGia.ExportToCsvFile(tacgia, fileName);
        }

        //getAllForm TacGia
        public List<TacGiaDtos> getAllFormTacGia()
        {
            return this._TacGia.getAllFormTacGia();
        }
        #region getListSearch 
        //get List Search IDTacGia
        public List<TacGiaDtos> getFormTacGiaSearchIDTacGia(int ID)
        {
            return this._TacGia.getFormTacGiaSearchIDTacGia(ID);
        }
        //get List search NgaySinh
        public List<TacGiaDtos> getFormTacGiaSearchNgaySinhTG(DateTime NgaySinh)
        {
            return this._TacGia.getFormTacGiaSearchNgaySinhTG(NgaySinh);
        }
        //get List Search TenTacGia
        public List<TacGiaDtos> getFormTacGiaSearchTenTacGia(string TenTG)
        {
            return this._TacGia.getFormTacGiaSearchTenTacGia(TenTG);
        }
        #endregion
    }
}
