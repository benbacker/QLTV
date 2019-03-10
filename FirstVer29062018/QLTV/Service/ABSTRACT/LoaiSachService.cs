using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Data.Dtos;
using Service.IService;
using Data.BUS;
namespace Service.ABSTRACT
{
    public class LoaiSachService : ILoaiSachService
    {
        private ILoaiSachBUS _LoaiSachBUS;
        public LoaiSachService()
        {
            this._LoaiSachBUS = new LoaiSachBUS();
        }
        //add Form "LoaiSach"
        public void AddFromLoaiSach(LoaiSachDtos LS)
        {
            this._LoaiSachBUS.AddFromLoaiSach(LS);
        }
        //getLisData IDLoaiSach From "LoaiSach"
        public List<LoaiSachDtos> getFromLoaiSach(int ID)
        {
            return this._LoaiSachBUS.getFromLoaiSach(ID);
        }
        //getListSearch TenLoaiSach From "LoaiSach"
        public List<LoaiSachDtos> getFromLoaiSachSearchTenLoaiSach(string TenLoaiSach)
        {
            return this._LoaiSachBUS.getFromLoaiSachSearchTenLoaiSach(TenLoaiSach);
        }
    }
}
