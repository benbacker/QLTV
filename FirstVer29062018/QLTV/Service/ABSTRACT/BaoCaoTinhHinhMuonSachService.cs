using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DTO;
using Service.IService;
using Data.BUS;
using Data.IBUS;
namespace Service.ABSTRACT
{
    public class BaoCaoTinhHinhMuonSachService : IBaoCaoTinhHinhMuonSachService
    {
        private IBCTinhHinhMuonSachBUS _IBaoCaoService;
        public BaoCaoTinhHinhMuonSachService()
        {
            this._IBaoCaoService = new BCTinhHinhMuonSachBUS();
        }
        public List<BaoCaoTinhHinhMuonSachDTO> getAllListBaoCaoTinhHinhMuonSach()
        {
            return _IBaoCaoService.getAllListBaoCaoTinhHinhMuonSach();
        }

        public List<BaoCaoTinhHinhMuonSachDTO> getListBaoCaoTinhHinhMuonSachToDate(int Thang, int Nam)
        {
            return _IBaoCaoService.getListBaoCaoTinhHinhMuonSachToDate(Thang, Nam);
        }
    }
}
