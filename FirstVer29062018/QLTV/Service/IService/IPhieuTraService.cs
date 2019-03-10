using Data.DTO;
using Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface IPhieuTraService
    {
        //Add Form "PhieuTra"
        void AddFormPhieuTra(PhieuTraDtos phieutra, List<int> IDCuonSach);
        //get AllFrmPhieuTra And CTPhieuTra
        List<CTPhieuTraDTO> getALlFormPhieuTraAndCTPhieuTra();
        //Xuat file excel
        bool ExportToCsvFile(List<CTPhieuTraDTO> PT, string fileName);
    }
}
