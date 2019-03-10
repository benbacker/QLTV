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
    public class CTTacGiaService : ICTTacGiaService
    {
        private ICTTacGiaBUS _iTacGiaBUS;
        public CTTacGiaService()
        {
            this._iTacGiaBUS = new CTTacGiaBUS();
        }
        public void addFormCTTacGia(CTTacGiaDtos tacGia)
        {
            this._iTacGiaBUS.addFormCTTacGia(tacGia);
        }

        public void editFormCTTacGia(CTTacGiaDtos ctTacGia)
        {
            this._iTacGiaBUS.editFormCTTacGia(ctTacGia);
        }
    }
}
