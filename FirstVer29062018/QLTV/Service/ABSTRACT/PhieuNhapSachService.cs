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
using Data.DTO;
namespace Service.ABSTRACT
{
    public class PhieuNhapSachService : IPhieuNhapSachService
    {
        private IPhieuNhapSachBUS _iNhapSachBUS;
        public PhieuNhapSachService()
        {
            this._iNhapSachBUS = new PhieuNhapSachBUS();
        }
        public void addFormPhieuNhapSach(PhieuNhapSachDtos phieuNhap)
        {
            this._iNhapSachBUS.addFormPhieuNhapSach(phieuNhap);
        }
    }
}
