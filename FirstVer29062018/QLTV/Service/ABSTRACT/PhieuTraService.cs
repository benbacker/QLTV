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
    public class PhieuTraService : IPhieuTraService
    {
        private IPhieuTraBUS _iPhieuTraBUS;
        public PhieuTraService()
        {
            this._iPhieuTraBUS = new PhieuTraBUS();
        }
        public void AddFormPhieuTra(PhieuTraDtos phieutra, List<int> IDCuonSach)
        {
            this._iPhieuTraBUS.AddFormPhieuTra(phieutra, IDCuonSach);
        }
        //Xuat file excel
        public bool ExportToCsvFile(List<CTPhieuTraDTO> PT, string fileName)
        {
            return _iPhieuTraBUS.ExportToCsvFile(PT, fileName);
        }

        public List<CTPhieuTraDTO> getALlFormPhieuTraAndCTPhieuTra()
        {
            return this._iPhieuTraBUS.getALlFormPhieuTraAndCTPhieuTra();
        }
    }
}
