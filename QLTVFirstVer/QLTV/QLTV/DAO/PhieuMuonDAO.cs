using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.DTO;

namespace Desktop.DAO
{
    public class PhieuMuonDAO
    {
        #region PhieuMuon
        public string QueryAutocombobox(string TenDauSach)
        {
            string Query = "select * from TacGia,Sach,DauSach where TacGia.IDTacGia = Sach.IDTacGia and DauSach.IDDauSach = Sach.IDDauSach and DauSach.TenDauSach = N'"+TenDauSach+"'";
            return Query;
        }

        public string QueryLoadSachMuon(string TenDauSach)
        {
            string Query = "SELECT CUONSACH.*,TenTacGia,TenDauSach FROM CUONSACH,SACH,TACGIA,DAUSACH where SACH.IDSach = CUONSACH.IDSach and SACH.IDTacGia = TACGIA.IDTacGia  and SACH.IDDauSach = DAUSACH.IDDauSach and TenDauSach = N'" + TenDauSach+ "' and TinhTrang =N'Chưa cho mượn'";
            return Query;
        }

        public string QueryLoadPhieuMuon()
        {
            string Query = "select IDCTPhieuMuon,HoTenDG,TenDauSach,NgayMuon,HanTra from CT_PHIEUMUON as A,PHIEUMUON as B,THEDOCGIA as C,SACH as D,CUONSACH as E,DAUSACH as F where A.IDPhieuMuon =  B.IDPhieuMuon and A.IDCuonSach = E.IDCuonSach and E.IDSach = D.IDSach and D.IDDauSach = F.IDDauSach and B.IDDocGia = C.IDDocGia";
            return Query;
        }

        public string QueryInsertCT_PHIEUMUON(PhieuMuonDTO PM)
        {
            string Query = "INSERT INTO CT_PHIEUMUON VALUES ('" + PM.IDCTPhieuMuon + "','" + PM.IDPhieuMuon + "', '" + PM.IDCuonSach + "')";
            return Query;
        }

        public string QueryInsertPHIEUMUON(PhieuMuonDTO PM)
        {
            string Query = "INSERT INTO PHIEUMUON VALUES ('" + PM.IDPhieuMuon + "','" + PM.IDDocGia + "', '" + PM.NgayMuon + "', '" + PM.HanTra + "')";
            return Query;
        }

        public string QueryUpdateCuonSach(PhieuMuonDTO PM)
        {
            string Query = "UPDATE CuonSach SET TinhTrang = N'Đã cho mượn' WHERE IDCuonSach = '" + PM.IDCuonSach + "'";
            return Query;
        }

        public string QueryDeletePhieuMuon(PhieuMuonDTO PM)
        {
            string Query = "DELETE PhieuMuon Where IDPhieuMuon = " + PM.IDPhieuMuon + "";
            return Query;
        }

        public string QuerySearch(string SearchTT,string NhapTT)
        {
            string Query = "select IDCTPhieuMuon,HoTenDG,TenDauSach,NgayMuon,HanTra from CT_PHIEUMUON as A,PHIEUMUON as B,THEDOCGIA as C,SACH as D,CUONSACH as E,DAUSACH as F where A.IDPhieuMuon =  B.IDPhieuMuon and A.IDCuonSach = E.IDCuonSach and E.IDSach = D.IDSach and D.IDDauSach = F.IDDauSach and B.IDDocGia = C.IDDocGia and " + SearchTT + " like N'%" + NhapTT + "%'";
            return Query;
        }
        #endregion
    }
}
