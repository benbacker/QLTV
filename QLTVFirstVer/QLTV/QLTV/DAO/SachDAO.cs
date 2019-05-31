using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.DTO;

namespace Desktop.DAO
{
    public class SachDAO
    {
        #region QuerySach
        #region QueryLoadSach
        public string QueryLoadSach()
        {
            string Query = "select S.*,T.TenTacGia,D.TenDauSach,P.NgayNhap,L.TenLoaiSach,C.DonGia,ThanhTien from Sach as S,TacGia as T,DauSach as D,LoaiSach as L,CT_PHIEUNHAPSACH as C,PHIEUNHAPSACH as P where S.IDTacGia = T.IDTacGia and D.IDLoaiSach = L.IDLoaiSach and D.IDDauSach = S.IDDauSach and P.IDPhieuNhap = C. IDPhieuNhap and S.IDSach = C.IDSach";
            return Query;
        }
        #endregion
        #region QueryAutocombobox
        public string QueryAutocombobox()
        {
            string Query = "select * from LoaiSach";
            return Query;
        }
        #endregion
        #region QueryInsert
        public string QueryInsertSach(SachDTO S)
        {
            string Query = "INSERT INTO SACH VALUES ('" + S.IDSach + "','" + S.IDDauSach + "', '" + S.IDTacGia + "', N'" + S.NhaXB + "', '" + S.NamXB + "', '" + S.SoLuongTon + "', '" + S.GiaTien + "')";
            return Query;
        }

        public string QueryInsertCuonSach(SachDTO S)
        {
            string ID = "IDCuonSach";
            string Bang = "CUONSACH";
            S.IDCuonSach = ConnectionSQL.Identitytable(S.IDCuonSach, ID, Bang);
            string Query = "INSERT INTO CUONSACH VALUES ('" + S.IDCuonSach + "','" + S.IDSach + "', N'" + S.TinhTrang + "')";
            return Query;
        }

        public string QueryInsertCT_PhieuNhapSach(SachDTO S)
        {
            string Query = "INSERT INTO CT_PHIEUNHAPSACH VALUES ('" + S.IDCTPhieuNhap + "','" + S.IDPhieuNhap + "', '" + S.IDSach + "', N'" + S.SoLuong + "', '" + S.DonGia + "', '" + S.ThanhTien + "')";
            return Query;
        }

        public string QueryInsertPhieuNhapSach(SachDTO S)
        {
            string Query = "INSERT INTO PHIEUNHAPSACH VALUES ('" + S.IDPhieuNhap + "','" + S.NgayNhap + "', '" + S.TongTien + "')";
            return Query;
        }

        public string QueryInsertDauSach(SachDTO S)
        {
            string Query = "INSERT INTO DAUSACH VALUES ('" + S.IDDauSach + "',N'" + S.TenDauSach + "', '" + S.IDLoaiSach + "')";
            return Query;
        }

        public string QueryInsertTheLoaiSach(SachDTO S)
        {
            string ID = "IDLoaiSach";
            string Bang = "LoaiSach";
            S.IDLoaiSach = ConnectionSQL.Identitytable(S.IDCuonSach, ID, Bang);
            string Query = "INSERT INTO LOAISACH VALUES ('" + S.IDLoaiSach + "',N'" + S.TenLoaiSach + "')";
            return Query;
        }
        #endregion
        #region QuerySearch
        public string QuerySearchSach(string SearchTT, string NhapTT)
        {
            string Query = "select S.*,T.TenTacGia,D.TenDauSach,P.NgayNhap,L.TenLoaiSach,C.DonGia,ThanhTien from Sach as S,TacGia as T,DauSach as D,LoaiSach as L,CT_PHIEUNHAPSACH as C,PHIEUNHAPSACH as P where S.IDTacGia = T.IDTacGia and D.IDLoaiSach = L.IDLoaiSach and D.IDDauSach = S.IDDauSach and P.IDPhieuNhap = C. IDPhieuNhap and S.IDSach = C.IDSach and " + SearchTT + " like N'%" +NhapTT+ "%'";
            return Query;
        }
        #endregion
        #region QueryUpdateSach
        public string QueryUpdateSach(SachDTO S)
        {
            string Query = "UPDATE SACH SET IDTacGia = '" + S.IDTacGia + "', NhaXB = N'" + S.NhaXB + "', NamXB = '" + S.NamXB + "', SoLuongTon = '" + S.SoLuongTon + "', GiaTien = '" + S.GiaTien + "' WHERE IDSach = '" + S.IDSach + "'";
            return Query;
        }

        public string QueryUpdateDauSach(SachDTO S)
        {
            string Query = "UPDATE DAUSACH SET TenDauSach = N'" + S.TenDauSach + "', IDLoaiSach = '" + S.IDLoaiSach + "' WHERE IDDauSach = '" + S.IDDauSach + "'";
            return Query;
        }

        public string QueryUpdateCT_PHIEUNHAPSACH(SachDTO S)
        {
            string Query = "UPDATE CT_PHIEUNHAPSACH SET SoLuong = '" + S.SoLuong + "', DonGia = '" + S.DonGia + "', ThanhTien = '" + S.ThanhTien + "' WHERE IDSach = '" + S.IDSach + "'";
            return Query;
        }

        public string QueryUpdatePHIEUNHAPSACH(SachDTO S)
        {
            string Query = "UPDATE PHIEUNHAPSACH SET NgayNhap = '" + S.NgayNhap + "', TongTien = '" + S.TongTien + "' WHERE IDPhieuNhap = '" + S.IDPhieuNhap + "'";
            return Query;
        }
        #endregion
        #region QueryDelete
        public string QueryDeleteDAUSACH(int ID)
        {
            string Query = "DELETE DAUSACH WHERE IDDauSach = "+ ID +"";
            return Query;
        }

        public string QueryDeletePhieuNhapSach(int ID)
        {
            string Query = "DELETE PHIEUNHAPSACH WHERE IDPhieuNhap =" + ID + "";
            return Query;
        }

        public string QueryDeleteCT_PHIEUNHAPSACH(int ID)
        {
            string Query = "DELETE CT_PHIEUNHAPSACH WHERE IDPhieuNhap =" + ID + "";
            return Query;
        }

        public string QueryDeleteCUONSACH(int ID)
        {
            string Query = "DELETE CUONSACH WHERE IDSach =" + ID + "";
            return Query;
        }

        public string QueryDeleteSACH(int ID)
        {
            string Query = "DELETE SACH WHERE IDSach = " + ID + "";
            return Query;
        }
        #endregion
        #endregion
    }
}
