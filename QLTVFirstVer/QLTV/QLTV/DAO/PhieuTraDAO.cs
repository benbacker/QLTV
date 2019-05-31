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
        #region PhieuTra
        #region Load
        public string QueryLoadSachTra(int IDDocGia)
        {
            string Query = "select* from( select CuonSach.*, PhieuMuon.IDPhieuMuon, TenDauSach from CuonSach, PHIEUMUON, CT_PHIEUMUON, THEDOCGIA, SACH, DAUSACH where TinhTrang = N'Đã cho mượn' and DAUSACH.IDDauSach = SACH.IDDauSach and SACH.IDSach = CUONSACH.IDSach and CUONSACH.IDCuonSach = CT_PHIEUMUON.IDCuonSach and PHIEUMUON.IDPhieuMuon = CT_PHIEUMUON.IDPhieuMuon and PHIEUMUON.IDDocGia = THEDOCGIA.IDDocGia and THEDOCGIA.IDDocGia = " + IDDocGia + ") as A where NOT EXISTS(SELECT IDPhieuTra FROM CT_PhieuTra B WHERE A.IDPhieuMuon = B.IDPhieuMuon)";
            //string Query = "select CuonSach.*,PhieuMuon.IDPhieuMuon,TenDauSach from CuonSach,PHIEUMUON,CT_PHIEUMUON,THEDOCGIA,SACH,DAUSACH where TinhTrang = N'Đã cho mượn' and DAUSACH.IDDauSach = SACH.IDDauSach and SACH.IDSach = CUONSACH.IDSach and CUONSACH.IDCuonSach = CT_PHIEUMUON.IDCuonSach and PHIEUMUON.IDPhieuMuon = CT_PHIEUMUON.IDPhieuMuon and PHIEUMUON.IDDocGia = THEDOCGIA.IDDocGia and THEDOCGIA.IDDocGia = " + IDDocGia + "";
            return Query;
        }

        public string QueryLoadPhieuTra()
        {
            string Query = "select * from CT_PHIEUTRA,PHIEUTRA,THEDOCGIA,CUONSACH,SACH,DAUSACH where CT_PHIEUTRA.IDPhieuTra = PHIEUTRA.IDPhieuTra and PHIEUTRA.IDDocGia = THEDOCGIA.IDDocGia and CUONSACH.IDCuonSach = CT_PHIEUTRA.IDCuonSach and SACH.IDSach = CUONSACH.IDSach and DAUSACH.IDDauSach = SACH.IDDauSach";
            return Query;
        }
        #endregion
        #region Insert
        public string QueryGetSoTienTra(int IDDocGia,int IDCuonSach)
        {
            string Query = "select A.GiaTien as SL from (select TheDocGia.IDDocGia, DauSach.TenDauSach, Sach.GiaTien, CuonSach.IDCuonSach from TheDocGia, PhieuMuon, CT_PhieuMuon, CuonSach, Sach, DauSach where TheDocGia.IDDocGia = PhieuMuon.IDDocGia and CT_PhieuMuon.IDPhieuMuon = PhieuMuon.IDPhieuMuon and CuonSach.IDCuonSach = CT_PhieuMuon.IDCuonSach and Sach.IDSach = CuonSach.IDSach and DauSach.IDDauSach = Sach.IDDauSach) as A where A.IDDocGia = "+ IDDocGia + " and A.IDCuonSach = "+ IDCuonSach + " ";
            return Query;
        }

        public string QueryInsertPhieuTra(PhieuTraDTO PT)
        {
            string Query = "INSERT INTO PhieuTra VALUES ('" + PT.IDPhieuTra + "','" + PT.IDDocGia + "', '" + PT.NgayTra + "', '" + PT.TienPhatKyNay + "', '" + PT.SoTienTra + "', '" + PT.TienNoKyNay + "')";
            return Query;
        }

        public string QueryInsertCTPhieuTra(PhieuTraDTO PT)
        {
            string Query = "INSERT INTO CT_PHIEUTRA VALUES ('" + PT.IDCTPhieuTra + "','" + PT.IDPhieuTra + "', '" + PT.IDCuonSach + "', '" + PT.IDPhieuMuon + "', '" + PT.SoNgayMuon + "', '" + PT.TienPhat + "')";
            return Query;
        }
        #endregion
        #region Search
        public string QuerySearch(string SearchTT, string NhapTT)
        {
            string Query = "select * from CT_PHIEUTRA,PHIEUTRA,THEDOCGIA,CUONSACH,SACH,DAUSACH where CT_PHIEUTRA.IDPhieuTra = PHIEUTRA.IDPhieuTra and PHIEUTRA.IDDocGia = THEDOCGIA.IDDocGia and CUONSACH.IDCuonSach = CT_PHIEUTRA.IDCuonSach and SACH.IDSach = CUONSACH.IDSach and DAUSACH.IDDauSach = SACH.IDDauSach and " + SearchTT + " like N'%" + NhapTT + "%'";
            return Query;
        }
        #endregion
        #region Delete
        public string QueryDeleteCT_PHIEUTRA(int ID)
        {
            string Query = "DELETE CT_PHIEUTRA WHERE IDCTPhieuTra = " + ID + "";
            return Query;
        }
        public string QueryDeletePHIEUTRA(int ID)
        {
            string Query = "DELETE PHIEUTRA WHERE IDPhieuTra = " + ID + "";
            return Query;
        }
        #endregion
        #endregion
    }
}
