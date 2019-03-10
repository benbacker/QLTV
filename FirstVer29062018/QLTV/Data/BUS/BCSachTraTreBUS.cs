using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Data.Model;
using Data.Dtos;
using Data.DAO; 
namespace Data.BUS
{
    public class BCSachTraTreBUS:IBCSachTraTreBUS
    {
        #region load Form BaoCaoSachTraTre
        public List<BCSachTraTreDtos> LoadForm()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var BaoCao = (from a in db.CT_PHIEUMUON
                              from b in db.PHIEUMUONs
                              from d in db.PHIEUTRAs
                              from c in db.CT_PHIEUTRA
                              where a.IDPhieuMuon.Equals(b.IDPhieuMuon) && b.IDPhieuMuon.Equals(c.IDPhieuMuon) && d.IDPhieuTra.Equals(c.IDPhieuTra)
                              && (d.NgayTra > b.HanTra)
                              select new BCSachTraTreDtos()
                              {
                                  IDPhieuMuon = a.IDPhieuMuon,
                                  NgayThangNam = d.NgayTra,
                                  IDCuonSach = a.IDCuonSach,
                                  SoNgayTraTre = (d.NgayTra - b.HanTra).Days,
                              }
                            ).ToList<BCSachTraTreDtos>();
                var listBaoCao = (from a in BaoCao
                                  select new BCSachTraTreDtos()
                                  {
                                      IDBCSachTre = BCSachTraTreDAO.Instance.IDPlus(),
                                      IDCuonSach = a.IDCuonSach,
                                      NgayThangNam = a.NgayThangNam,
                                      IDPhieuMuon = a.IDPhieuMuon,
                                      SoNgayTraTre = a.SoNgayTraTre,
                                      TenCuonSach = GetDataDAO.Instance.getTenCuonSach(a.IDCuonSach),
                                  }).ToList<BCSachTraTreDtos>();

                if (listBaoCao.Count > 0)
                    return listBaoCao;
                return new List<BCSachTraTreDtos>();
            }
        }
        #endregion
        #region getListAll BCSachTratre
        public List<BCSachTraTreDtos> getListAllBCSachTraTre()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var getList = (from a in db.BCSACHTRATREs
                               select new BCSachTraTreDtos()
                               {
                                   IDBCSachTre = a.IDBCSachTre,
                                   IDCuonSach = a.IDCuonSach,
                                   IDPhieuMuon = a.IDPhieuMuon,
                                   NgayThangNam = a.NgayThangNam,
                                   SoNgayTraTre = a.SoNgayTraTre,
                               }).ToList<BCSachTraTreDtos>();
                var getListAll = (from a in getList
                                  select new BCSachTraTreDtos()
                                  {
                                      IDBCSachTre = a.IDBCSachTre,
                                      IDCuonSach = a.IDCuonSach,
                                      IDPhieuMuon = a.IDPhieuMuon,
                                      NgayThangNam = a.NgayThangNam,
                                      SoNgayTraTre = a.SoNgayTraTre,
                                      TenCuonSach = GetDataDAO.Instance.getTenCuonSach(a.IDCuonSach),
                                  }).ToList<BCSachTraTreDtos>();
                if (getListAll.Count > 0)
                    return getListAll;
                return new List<BCSachTraTreDtos>();
            }
        }
        #endregion
        #region Load BaoCao to Date
        public List<BCSachTraTreDtos> loadBaoCaoToDate(DateTime NgayLapBaoCao)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var load = (from a in db.BCSACHTRATREs
                            where a.NgayThangNam.CompareTo(NgayLapBaoCao)<=0
                            select new BCSachTraTreDtos()
                            {
                                IDBCSachTre = a.IDBCSachTre,
                                IDCuonSach = a.IDCuonSach,
                                IDPhieuMuon = a.IDPhieuMuon,
                                NgayThangNam = a.NgayThangNam,
                                SoNgayTraTre = a.SoNgayTraTre,
                            }
                          ).ToList<BCSachTraTreDtos>();
                var LoadBaoCao = (from a in load
                                  select new BCSachTraTreDtos()
                                  {
                                      IDBCSachTre = a.IDBCSachTre,
                                      IDCuonSach = a.IDCuonSach,
                                      IDPhieuMuon = a.IDPhieuMuon,
                                      NgayThangNam = a.NgayThangNam,
                                      SoNgayTraTre = a.SoNgayTraTre,
                                      TenCuonSach = GetDataDAO.Instance.getTenCuonSach(a.IDCuonSach),
                                  }
                                ).ToList<BCSachTraTreDtos>();
                if (LoadBaoCao.Count > 0)
                    return LoadBaoCao;
                return new List<BCSachTraTreDtos>();
            }
        }
        #endregion
        #region Load Bao cao to Thang Nam
        public List<BCSachTraTreDtos> loadBaoCaoToThangNam(int Thang,int Nam)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var load = (from a in db.BCSACHTRATREs
                            where a.NgayThangNam.Month.Equals(Thang) && a.NgayThangNam.Month.Equals(Nam)
                            select new BCSachTraTreDtos()
                            {
                                IDBCSachTre = a.IDBCSachTre,
                                IDCuonSach = a.IDCuonSach,
                                IDPhieuMuon = a.IDPhieuMuon,
                                NgayThangNam = a.NgayThangNam,
                                SoNgayTraTre = a.SoNgayTraTre,
                            }
                          ).ToList<BCSachTraTreDtos>();
                var LoadBaoCao = (from a in load
                                  select new BCSachTraTreDtos()
                                  {
                                      IDBCSachTre = a.IDBCSachTre,
                                      IDCuonSach = a.IDCuonSach,
                                      IDPhieuMuon = a.IDPhieuMuon,
                                      NgayThangNam = a.NgayThangNam,
                                      SoNgayTraTre = a.SoNgayTraTre,
                                      TenCuonSach = GetDataDAO.Instance.getTenCuonSach(a.IDCuonSach),
                                  }
                                ).ToList<BCSachTraTreDtos>();
                if (LoadBaoCao.Count > 0)
                    return LoadBaoCao;
                return new List<BCSachTraTreDtos>();
            }
        }
        #endregion
    }
}
