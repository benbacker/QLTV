using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.DTO;
using Data.Model;
namespace Data.DAO
{
    public class PhieuMuonDAO
    {
        #region Instance
        private static PhieuMuonDAO instance;

        public static PhieuMuonDAO Instance
        {
            get
            {
                if (instance == null) instance = new PhieuMuonDAO(); return DAO.PhieuMuonDAO.instance;
            }

            private set
            {
                DAO.PhieuMuonDAO.instance = value;
            }
        }
        #endregion
        #region Count
        //ID Plus
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from a in db.PHIEUMUONs select a.IDPhieuMuon).Max()).ToString();
                int ID = Int32.Parse(query);
                int IDadd = ++ID;
                return IDadd;
            }
        }
        // count HanMuon
        public DateTime HanMuonSach(DateTime ngaymuon)
        {
            DateTime HanMuonSach = ngaymuon.AddDays(5);
            return HanMuonSach;
        }
        #endregion
        #region getList Search PhieuMuonDtos
        //get List Search IDDocGia
        public List<PhieuMuonDTO> getFormPhieuMuonSearchIDDocGia(int ID)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.PHIEUMUONs
                              join b in db.CT_PHIEUMUON on a.IDPhieuMuon equals b.IDPhieuMuon
                              where a.IDDocGia.Equals(ID)
                              select new PhieuMuonDTO()
                              {
                                  IDDocGia = ID,
                                  IDPhieuMuon = a.IDPhieuMuon,
                                  NgayMuon = a.NgayMuon,
                                  HanTra = a.HanTra,
                                  IDCTPhieuMuon = b.IDCTPhieuMuon,
                                  IDCuonSach=b.IDCuonSach,
                              }).ToList<PhieuMuonDTO>();
                var listSearchIDDG=(from a in result
                                    select new PhieuMuonDTO()
                                    {
                                        IDDocGia = ID,
                                        IDPhieuMuon = a.IDPhieuMuon,
                                        NgayMuon = a.NgayMuon,
                                        HanTra = a.HanTra,
                                        IDCTPhieuMuon=a.IDCTPhieuMuon,
                                        TenDauSach=GetDataDAO.Instance.getTenDausachToIDDauSach(a.IDCuonSach),
                                        IDCuonSach=a.IDCuonSach,
                                    }).ToList<PhieuMuonDTO>();
                if (listSearchIDDG.Count > 0)
                    return listSearchIDDG;
                return new List<PhieuMuonDTO>();

            }
        }
        //get List Search IDPhieuMuon
        public List<PhieuMuonDTO> getFormPhieuMuonSearchIDPhieuMuon(int ID)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.PHIEUMUONs
                              join b in db.CT_PHIEUMUON on a.IDPhieuMuon equals b.IDPhieuMuon
                              where a.IDPhieuMuon.Equals(ID)
                              select new PhieuMuonDTO()
                              {
                                  IDDocGia = a.IDDocGia,
                                  IDPhieuMuon = ID,
                                  NgayMuon = a.NgayMuon,
                                  HanTra = a.HanTra,
                                  IDCTPhieuMuon = b.IDCTPhieuMuon,
                                  IDCuonSach=b.IDCuonSach,
                              }).ToList<PhieuMuonDTO>();
                var listSearchIDPhieuMuon = (from a in result
                                             select new PhieuMuonDTO()
                                             {
                                                 IDDocGia = a.IDDocGia,
                                                 IDPhieuMuon = a.IDPhieuMuon,
                                                 NgayMuon = a.NgayMuon,
                                                 HanTra = a.HanTra,
                                                 IDCTPhieuMuon = a.IDCTPhieuMuon,
                                                 TenDauSach = GetDataDAO.Instance.getTenDausachToIDDauSach(a.IDCuonSach),
                                                 IDCuonSach = a.IDCuonSach,
                                             }).ToList<PhieuMuonDTO>();
                if (listSearchIDPhieuMuon.Count > 0)
                    return listSearchIDPhieuMuon;
                return new List<PhieuMuonDTO>();
            }
        }
        //get List Search NgayMuon
        public List<PhieuMuonDTO> getFormPhieuMuonSearchNgayMuon(DateTime ngaymuon)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.PHIEUMUONs
                              join b in db.CT_PHIEUMUON on a.IDPhieuMuon equals b.IDPhieuMuon
                              where a.NgayMuon.Equals(ngaymuon)
                              select new PhieuMuonDTO()
                              {
                                  IDDocGia = a.IDDocGia,
                                  IDPhieuMuon = a.IDPhieuMuon,
                                  NgayMuon = ngaymuon,
                                  HanTra = a.HanTra,
                                  IDCTPhieuMuon = b.IDCTPhieuMuon,
                                  IDCuonSach=b.IDCuonSach,
                              }).ToList<PhieuMuonDTO>();
                var listSearchNgayMuon = (from a in result
                                          select new PhieuMuonDTO()
                                          {
                                              IDDocGia = a.IDDocGia,
                                              IDPhieuMuon = a.IDPhieuMuon,
                                              NgayMuon = a.NgayMuon,
                                              HanTra = a.HanTra,
                                              IDCTPhieuMuon = a.IDCTPhieuMuon,
                                              TenDauSach = GetDataDAO.Instance.getTenDausachToIDDauSach(a.IDCuonSach),
                                              IDCuonSach = a.IDCuonSach,
                                          }).ToList<PhieuMuonDTO>();
                if (listSearchNgayMuon.Count > 0)
                    return listSearchNgayMuon;
                return new List<PhieuMuonDTO>();

            }
        }
        //get List Search HanTra
        public List<PhieuMuonDTO> getFormPhieuMuonSearchHanTra(DateTime hantra)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.PHIEUMUONs
                              join b in db.CT_PHIEUMUON on a.IDPhieuMuon equals b.IDPhieuMuon
                              where a.HanTra.Equals(hantra)
                              select new PhieuMuonDTO()
                              {
                                  IDDocGia = a.IDDocGia,
                                  IDPhieuMuon = a.IDPhieuMuon,
                                  NgayMuon = a.NgayMuon,
                                  HanTra = hantra,
                                  IDCTPhieuMuon=b.IDCTPhieuMuon,
                                  IDCuonSach=b.IDCuonSach,    
                              }).ToList<PhieuMuonDTO>();
                var listSearchHanTra = (from a in result
                                        select new PhieuMuonDTO()
                                        {
                                            IDDocGia = a.IDDocGia,
                                            IDPhieuMuon = a.IDPhieuMuon,
                                            NgayMuon = a.NgayMuon,
                                            HanTra = a.HanTra,
                                            IDCTPhieuMuon = a.IDCTPhieuMuon,
                                            TenDauSach = GetDataDAO.Instance.getTenDausachToIDDauSach(a.IDCuonSach),
                                            IDCuonSach = a.IDCuonSach,
                                        }).ToList<PhieuMuonDTO>();
                if (listSearchHanTra.Count > 0)
                    return listSearchHanTra;
                return new List<PhieuMuonDTO>();
               
            }
        }
        #endregion
        #region getAllForm PhieuMuonandCTphieuMuon
        public List<PhieuMuonDTO> getAllFormPhieuMuonAndCTPhieuMuon()
        {
            using (var db= new QuanLyThuVienEntities())
            {
                var result = (from a in db.PHIEUMUONs
                              join b in db.CT_PHIEUMUON on a.IDPhieuMuon equals b.IDPhieuMuon
                              select new PhieuMuonDTO()
                              {
                                  IDDocGia = a.IDDocGia,
                                  IDPhieuMuon = a.IDPhieuMuon,
                                  NgayMuon = a.NgayMuon,
                                  HanTra = a.HanTra,
                                  IDCTPhieuMuon = b.IDCTPhieuMuon,
                                  IDCuonSach = b.IDCuonSach,
                              }).ToList<PhieuMuonDTO>();
                var Result = (from c in result
                              select new PhieuMuonDTO()
                              {
                                  IDDocGia = c.IDDocGia,
                                  IDPhieuMuon = c.IDPhieuMuon,
                                  IDCTPhieuMuon = c.IDCTPhieuMuon,
                                  IDCuonSach = c.IDCuonSach,
                                  NgayMuon = c.NgayMuon,
                                  HanTra = c.HanTra,
                                  TenNguoiMuon = GetDataDAO.Instance.getTenDocGiaToIDDocGia(c.IDDocGia),
                                  TenDauSach = GetDataDAO.Instance.getTenCuonSach(c.IDCuonSach),
                              }).ToList<PhieuMuonDTO>();
                if (Result.Count > 0)
                    return Result;                             
                return new List<PhieuMuonDTO>();
            }
        }
        #endregion 

    }
}
