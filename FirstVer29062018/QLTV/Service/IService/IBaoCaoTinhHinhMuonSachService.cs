using Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface IBaoCaoTinhHinhMuonSachService
    {
        List<BaoCaoTinhHinhMuonSachDTO> getAllListBaoCaoTinhHinhMuonSach();
        List<BaoCaoTinhHinhMuonSachDTO> getListBaoCaoTinhHinhMuonSachToDate(int Thang, int Nam);
    }
}
