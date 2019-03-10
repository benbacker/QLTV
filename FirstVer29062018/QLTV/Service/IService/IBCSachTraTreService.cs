using Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface IBCSachTraTreService
    {
        //Load Form BaoCaoSachTraTre
        List<BCSachTraTreDtos> LoadForm();
        //getListAll BCSachTratre
        List<BCSachTraTreDtos> getListAllBCSachTraTre();
        //Load BaoCao to Date
        List<BCSachTraTreDtos> loadBaoCaoToDate(DateTime NgayLapBaoCao);
        //Load Bao cao to Thang Nam
        List<BCSachTraTreDtos> loadBaoCaoToThangNam(int Thang, int Nam);
    }
}
