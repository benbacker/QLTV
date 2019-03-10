using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
using Data.DTO;

namespace Data.DAO
{
    public class PhieuTraDAO
    {
        #region Instance
        private static PhieuTraDAO instance;

        public static PhieuTraDAO Instance
        {
            get
            {
                if (instance == null) instance = new PhieuTraDAO(); return DAO.PhieuTraDAO.instance;
            }

            private set
            {
                DAO.PhieuTraDAO.instance = value;
            }
        }
        #endregion
        #region Count
        // Count ID
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from a in db.PHIEUTRAs select a.IDPhieuTra).Max()).ToString();
                int ID = Int32.Parse(query);
                int IDadd = ++ID;
                return IDadd;
            }
        }
        //Tinh So ngay muon 
        public int SoNgayMuon(DateTime ngaytra, int IDCTPhieuTra)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var ngaymuon = (from a in db.CT_PHIEUTRA
                                from b in db.PHIEUMUONs
                                where a.IDPhieuMuon.Equals(b.IDPhieuMuon) && a.IDCTPhieuTra.Equals(IDCTPhieuTra)
                                select b.NgayMuon).FirstOrDefault();

                DateTime ngay = ngaymuon;
                TimeSpan songay = ngaytra - ngaymuon;
                int t = songay.Days;
                return t;
            }
        }
        public DateTime ngaymuontoID(int ID)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var ngaymuon = (from a in db.CT_PHIEUTRA
                                from b in db.PHIEUMUONs
                                where a.IDPhieuMuon.Equals(b.IDPhieuMuon) && a.IDCTPhieuTra.Equals(ID)
                                select b.NgayMuon).FirstOrDefault();
                return ngaymuon;
            }
        }
        //Tinh tien phat
        public int TinhTienPhat(DateTime ngaytra, int IDCTPhieuTra)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var HanTra = (from a in db.CT_PHIEUTRA
                              from b in db.PHIEUMUONs
                              where a.IDPhieuMuon.Equals(b.IDPhieuMuon) && a.IDCTPhieuTra.Equals(IDCTPhieuTra)
                              select b.HanTra).FirstOrDefault();
                TimeSpan SoNgay = ngaytra - HanTra;
                int Ngay = SoNgay.Days;
                if (Ngay <= 0)
                    return 0;
                else
                    return Ngay * 1000;
            }
        }
        #endregion
        public List<int> ListIDCuonSach(int tb_IDPhieuMuon)
        {

            using (var db = new QuanLyThuVienEntities())
            {
                var list = (from a in db.PHIEUMUONs
                            join b in db.CT_PHIEUMUON on a.IDPhieuMuon equals b.IDPhieuMuon
                            join c in db.CUONSACHes on b.IDCuonSach equals c.IDCuonSach
                            where a.IDPhieuMuon.Equals(tb_IDPhieuMuon) && c.TinhTrang == "Đã cho mượn"
                            select b.IDCuonSach).ToList<int>();
                return list;
            }
        }
        public List<CTPhieuTraDTO> getALlFormPhieuTraAndCTPhieuTra()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var getAll = (from a in db.PHIEUTRAs
                              join b in db.CT_PHIEUTRA on a.IDPhieuTra equals b.IDPhieuTra
                              select new CTPhieuTraDTO()
                              {
                                  IDPhieuMuon = b.IDPhieuMuon,
                                  IDDocGia = a.IDDocGia,
                                  IDCTPhieuTra = b.IDCTPhieuTra,
                                  NgayTra = a.NgayTra,
                                  IDPhieuTra = a.IDPhieuTra,
                                  SoNgayMuon = b.SoNgayMuon,
                                  SoTienTra=a.SoTienTra,
                                  TienPhat = b.TienPhat,
                                  IDCuonSach = b.IDCuonSach,
                              }).ToList<CTPhieuTraDTO>();
                var getAllForm = (from a in getAll
                                  select new CTPhieuTraDTO()
                                  {
                                      IDPhieuMuon = a.IDPhieuMuon,
                                      IDDocGia = a.IDDocGia,
                                      IDCTPhieuTra = a.IDCTPhieuTra,
                                      NgayTra = a.NgayTra,
                                      IDPhieuTra = a.IDPhieuTra,
                                      SoNgayMuon = a.SoNgayMuon,
                                      SoTienTra = a.SoTienTra,
                                      TienPhat = a.TienPhat,
                                      TenDocGia = GetDataDAO.Instance.getTenDocGiaToIDDocGia(a.IDDocGia),
                                      TenDauSach = GetDataDAO.Instance.getTenCuonSach(a.IDCuonSach),
                                  }
                                ).ToList<CTPhieuTraDTO>();
                if (getAllForm.Count > 0)
                    return getAllForm;
                return new List<CTPhieuTraDTO>();
            }
        }
    }
}
