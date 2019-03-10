using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Service.IService;
using Data.BUS;
using Data.Dtos;
using Data.DAO;
namespace Service.ABSTRACT
{
    public class BCSachTraTreService : IBCSachTraTreService
    {
        private IBCSachTraTreBUS _iBCSach;
        public BCSachTraTreService()
        {
            this._iBCSach = new BCSachTraTreBUS();
        }

        public List<BCSachTraTreDtos> getListAllBCSachTraTre()
        {
            return this._iBCSach.getListAllBCSachTraTre();  
        }

        public List<BCSachTraTreDtos> loadBaoCaoToDate(DateTime NgayLapBaoCao)
        {
            return this._iBCSach.loadBaoCaoToDate(NgayLapBaoCao);
        }

        public List<BCSachTraTreDtos> loadBaoCaoToThangNam(int Thang, int Nam)
        {
            return this._iBCSach.loadBaoCaoToThangNam(Thang, Nam);
        }

        public List<BCSachTraTreDtos> LoadForm()
        {
            return this._iBCSach.LoadForm();
        }
    }
}
