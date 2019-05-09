using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.DTO;

namespace Desktop.DAO
{
    public class PhieuTraDAO
    {
        public string QueryLoadSachTra(int IDDocGia)
        {
            string Query = "select CuonSach.*,TenDauSach from CuonSach,PHIEUMUON,CT_PHIEUMUON,THEDOCGIA,SACH,DAUSACH where TinhTrang = N'Đã cho mượn' and DAUSACH.IDDauSach = SACH.IDDauSach and SACH.IDSach = CUONSACH.IDSach and CUONSACH.IDCuonSach = CT_PHIEUMUON.IDCuonSach and PHIEUMUON.IDPhieuMuon = CT_PHIEUMUON.IDPhieuMuon and PHIEUMUON.IDDocGia = THEDOCGIA.IDDocGia and THEDOCGIA.IDDocGia = " + IDDocGia + "";
            return Query;
        }

        public string QueryLoadPhieuTra()
        {
            string Query = "select * from CT_PHIEUTRA,PHIEUTRA,THEDOCGIA,CUONSACH,SACH,DAUSACH where CT_PHIEUTRA.IDPhieuTra = PHIEUTRA.IDPhieuTra and PHIEUTRA.IDDocGia = THEDOCGIA.IDDocGia and CUONSACH.IDCuonSach = CT_PHIEUTRA.IDCuonSach and SACH.IDSach = CUONSACH.IDSach and DAUSACH.IDDauSach = SACH.IDDauSach";
            return Query;
        }
    }
}
