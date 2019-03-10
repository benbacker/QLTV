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
    public class LoaiDocGiaService:ILoaiDocGiaService
    {
        private ILoaiDocGiaBUS _LoaiDocGia;
        public LoaiDocGiaService()
        {
            this._LoaiDocGia = new LoaiDocGiaBUS();
        }
        //add form LoaiDocGia
        public void ADDLoaiDocGia(LoaiDocGiaDtos LoaiDG)
        {
            this._LoaiDocGia.ADDLoaiDocGia(LoaiDG);
        }
        #region getList Search
        // getlist Search IDLoaiDG
        public List<LoaiDocGiaDtos> getFormLoaiDocGiaSearchIDLoaiDG(int ID)
        {
            return this._LoaiDocGia.getFormLoaiDocGiaSearchIDLoaiDG(ID);
        }
        //get List Search TenLoaiDG
        public List<LoaiDocGiaDtos> getFormLoaiDocGiaSearchTenLoaiDG(string TenLoaiDG)
        {
            return this._LoaiDocGia.getFormLoaiDocGiaSearchTenLoaiDG(TenLoaiDG);
        }
        #endregion
    }
}
