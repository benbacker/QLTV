using Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IBUS
{
    public interface IPhieuNhapSachBUS
    {
        // Add Form PhieuNhapSach
        bool addFormPhieuNhapSach(PhieuNhapSachDtos phieuNhap);
    }
}
