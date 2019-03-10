using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Data.Model;
using Data.DTO;
using Data.DAO;
namespace Data.BUS
{
    public class BCTinhHinhMuonSachBUS:IBCTinhHinhMuonSachBUS
    {
        public List<BaoCaoTinhHinhMuonSachDTO> getAllListBaoCaoTinhHinhMuonSach()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var listBaoCao = (from a in db.BCTINHHINHMUONSACHes
                                  from b in db.CT_BCTINHHINHMUONSACH
                                  where a.IDBCMuonSach.Equals(b.IDBCMuonSach)
                                  select new BaoCaoTinhHinhMuonSachDTO()
                                  {
                                      IDBCMuonSach = a.IDBCMuonSach,
                                      IDCTBCMuonSach = b.IDCTBCMuonSach,
                                      IDLoaiSach = b.IDLoaiSach,
                                      Nam = a.Nam,
                                      Thang = a.Thang,
                                      SoLuotMuon = b.SoLuotMuon,
                                      TiLe = b.TiLe,
                                      TongSoLuotMuon = a.TongSoLuotMuon,
                                  }).ToList<BaoCaoTinhHinhMuonSachDTO>();
                var getList = (from a in listBaoCao
                               select new BaoCaoTinhHinhMuonSachDTO()
                               {
                                   IDBCMuonSach = a.IDBCMuonSach,
                                   IDCTBCMuonSach = a.IDCTBCMuonSach,
                                   IDLoaiSach = a.IDLoaiSach,
                                   SoLuotMuon = a.SoLuotMuon,
                                   TiLe = a.TiLe,
                                   TongSoLuotMuon = a.TongSoLuotMuon,
                                   Nam = a.Nam,
                                   Thang = a.Thang,
                                   TenTheLoai = GetDataDAO.Instance.getTenLoaiSachToIDLoaiSach(a.IDLoaiSach),
                               }).ToList<BaoCaoTinhHinhMuonSachDTO>();
                if (getList.Count() > 0)
                    return getList;
                return new List<BaoCaoTinhHinhMuonSachDTO>();
            }
        }
        public List<BaoCaoTinhHinhMuonSachDTO> getListBaoCaoTinhHinhMuonSachToDate(int Thang,int Nam)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var getList = (from a in db.CT_BCTINHHINHMUONSACH
                               from b in db.BCTINHHINHMUONSACHes
                               where b.Thang.Equals(Thang) && b.Nam.Equals(Nam) && a.IDBCMuonSach.Equals(b.IDBCMuonSach)
                               select new BaoCaoTinhHinhMuonSachDTO()
                               {
                                   IDBCMuonSach = b.IDBCMuonSach,
                                   IDCTBCMuonSach = a.IDCTBCMuonSach,
                                   IDLoaiSach = a.IDLoaiSach,
                                   SoLuotMuon = a.SoLuotMuon,
                                   TiLe = a.TiLe,
                               }).ToList<BaoCaoTinhHinhMuonSachDTO>();
                var getListToDate = (from a in getList
                                     select new BaoCaoTinhHinhMuonSachDTO()
                                     {
                                         IDBCMuonSach = a.IDBCMuonSach,
                                         IDCTBCMuonSach = a.IDCTBCMuonSach,
                                         IDLoaiSach = a.IDLoaiSach,
                                         TenTheLoai = GetDataDAO.Instance.getTenLoaiSachToIDLoaiSach(a.IDLoaiSach),
                                         SoLuotMuon = a.SoLuotMuon,
                                         TiLe = a.TiLe,
                                     }).ToList<BaoCaoTinhHinhMuonSachDTO>();
                if (getListToDate.Count() > 0)
                    return getListToDate;
                return new List<BaoCaoTinhHinhMuonSachDTO>();
            }
        }
    }
}
