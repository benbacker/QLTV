using Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IBUS
{
    public interface IBCTinhHinhMuonSachBUS
    {
        List<BaoCaoTinhHinhMuonSachDTO> getAllListBaoCaoTinhHinhMuonSach();
        List<BaoCaoTinhHinhMuonSachDTO> getListBaoCaoTinhHinhMuonSachToDate(int Thang, int Nam);
    }
}
