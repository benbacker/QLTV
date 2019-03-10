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
    public class SachDAO
    {
        #region Instance
        private static SachDAO instance;

        public static SachDAO Instance
        {
            get
            {
                if (instance == null) instance = new SachDAO(); return DAO.SachDAO.instance;
            }

            private set
            {
                DAO.SachDAO.instance = value;
            }
        }
        #endregion
        #region Operator+
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from a in db.SACHes select a.IDSach).Max()).ToString();
                int ID = Int32.Parse(query);
                int IDadd = ++ID;
                return IDadd;
            }          
        }
        #endregion
        #region getListSearch SachDTO
        //get List Search IDSach 
        public List<SachDTO> getFormSachSearchIDSach(int IDsach)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.SACHes
                              where a.IDSach.Equals(IDsach)
                              select new SachDTO()
                              {
                                  IDSach = a.IDSach,
                                  IDDauSach = a.IDDauSach,
                                  IDTacGia=a.IDTacGia,
                                  TenDauSach=GetDataDAO.Instance.getTenDausachToIDDauSach(a.IDDauSach),
                                  TenTG=GetDataDAO.Instance.getTenTacGiaToIDTacGia(a.IDTacGia),
                                  NamXB=a.NamXB,
                                  NhaXB=a.NhaXB,
                                  GiaTien=a.GiaTien,
                                  SoLuongTon=a.SoLuongTon,                  
                              }).ToList<SachDTO>();
                if (result.Count > 0)
                    return result;
                return new List<SachDTO>();
            }
        }
        //get List Search TenDauSach
        public List<SachDTO> getFormSachTenDauSach(string TenDauSach)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var list1 = (from a in db.DAUSACHes
                             join b in db.SACHes on a.IDDauSach equals b.IDDauSach
                             where a.TenDauSach.ToUpper().Contains(TenDauSach.ToUpper())
                             select new SachDTO()
                             {
                                 IDDauSach = a.IDDauSach,
                                 IDSach = b.IDSach,
                                 IDLoaiSach = a.IDLoaiSach,
                                 IDTacGia = b.IDTacGia,
                                 //TenTG = GetDataDAO.Instance.getTenTacGiaToIDTacGia(b.IDTacGia),
                                 NamXB = b.NamXB,
                                 NhaXB = b.NhaXB,
                                 GiaTien = b.GiaTien,
                                 TenDauSach = a.TenDauSach,
                                 SoLuongTon = b.SoLuongTon,
                             }).ToList<SachDTO>();
                var list2 = (from a in list1
                             join b in db.CT_PHIEUNHAPSACH on a.IDSach equals b.IDSach
                             join c in db.PHIEUNHAPSACHes on b.IDPhieuNhap equals c.IDPhieuNhap
                             select new SachDTO()
                             {
                                 IDDauSach = a.IDDauSach,
                                 IDSach = a.IDSach,
                                 IDTacGia = a.IDTacGia,
                                 IDCTPhieuNhap = b.IDCTPhieuNhap,
                                 IDPhieuNhap = b.IDPhieuNhap,
                                 IDLoaiSach = a.IDLoaiSach,
                                 DonGia = b.DonGia,
                                 SoLuong = b.SoLuong,
                                 GiaTien = a.GiaTien,
                                 NamXB = a.NamXB,
                                 NhaXB = a.NhaXB,
                                 SoLuongTon = a.SoLuongTon,
                                 TenDauSach = a.TenDauSach,
                             }).ToList<SachDTO>();
                var list3 = (from a in list2
                             select new SachDTO()
                             {
                                 IDDauSach = a.IDDauSach,
                                 IDSach = a.IDSach,
                                 IDTacGia = a.IDTacGia,
                                 IDCTPhieuNhap = a.IDCTPhieuNhap,
                                 IDPhieuNhap = a.IDPhieuNhap,
                                 IDLoaiSach = a.IDLoaiSach,
                                 DonGia = a.DonGia,
                                 SoLuong = a.SoLuong,
                                 GiaTien = a.GiaTien,
                                 NamXB = a.NamXB,
                                 NhaXB = a.NhaXB,
                                 SoLuongTon = a.SoLuongTon,
                                 TenDauSach = a.TenDauSach,
                                 TenLoaiSach = GetDataDAO.Instance.getTenLoaiSachToIDLoaiSach(a.IDLoaiSach),
                                 TenTG = GetDataDAO.Instance.getTenTacGiaToIDTacGia(a.IDTacGia),
                             }).ToList<SachDTO>();
                if (list3.Count > 0)
                    return list3;
                return new List<SachDTO>();

            }
        }
        // get List Search NhaXuatBan
        public List<SachDTO> getFormSachNhaXuatBan(string NhaxB)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var list1 = (from a in db.SACHes
                             from b in db.CT_PHIEUNHAPSACH
                             where a.NhaXB.ToUpper().Contains(NhaxB.ToUpper()) && a.IDSach.Equals(b.IDSach)
                             select new SachDTO()
                             {
                                 IDSach = a.IDSach,
                                 IDDauSach = a.IDDauSach,
                                 IDTacGia = a.IDTacGia,
                                 //TenDauSach = GetDataDAO.Instance.getTenDausachToIDDauSach(a.IDDauSach),
                                 //TenTG = GetDataDAO.Instance.getTenTacGiaToIDTacGia(a.IDTacGia),
                                 NamXB = a.NamXB,
                                 NhaXB = a.NhaXB,
                                 GiaTien = a.GiaTien,
                                 SoLuongTon = a.SoLuongTon,
                                 IDCTPhieuNhap = b.IDCTPhieuNhap,
                                 IDPhieuNhap = b.IDPhieuNhap,
                                 DonGia = b.DonGia,
                                 SoLuong = b.SoLuong,
                             }).ToList<SachDTO>();
                var list2 = (from a in list1
                             from b in db.DAUSACHes
                             select new SachDTO()
                             {
                                 IDSach = a.IDSach,
                                 IDDauSach = a.IDDauSach,
                                 IDTacGia = a.IDTacGia,
                                 //TenTG = GetDataDAO.Instance.getTenTacGiaToIDTacGia(a.IDTacGia),
                                 NamXB = a.NamXB,
                                 NhaXB = a.NhaXB,
                                 GiaTien = a.GiaTien,
                                 SoLuongTon = a.SoLuongTon,
                                 IDCTPhieuNhap = a.IDCTPhieuNhap,
                                 IDPhieuNhap = a.IDPhieuNhap,
                                 DonGia = a.DonGia,
                                 SoLuong = a.SoLuong,
                                 TenDauSach = b.TenDauSach,
                                 IDLoaiSach = b.IDLoaiSach,
                             }).ToList<SachDTO>();
                var list3 = (from a in list2
                             select new SachDTO()
                             {
                                 IDSach = a.IDSach,
                                 IDDauSach = a.IDDauSach,
                                 IDTacGia = a.IDTacGia,
                                 TenTG = GetDataDAO.Instance.getTenTacGiaToIDTacGia(a.IDTacGia),
                                 NamXB = a.NamXB,
                                 NhaXB = a.NhaXB,
                                 GiaTien = a.GiaTien,
                                 SoLuongTon = a.SoLuongTon,
                                 IDCTPhieuNhap = a.IDCTPhieuNhap,
                                 IDPhieuNhap = a.IDPhieuNhap,
                                 DonGia = a.DonGia,
                                 SoLuong = a.SoLuong,
                                 TenDauSach = a.TenDauSach,
                                 IDLoaiSach = a.IDLoaiSach,
                                 TenLoaiSach = GetDataDAO.Instance.getTenLoaiSachToIDLoaiSach(a.IDLoaiSach),
                             }).ToList<SachDTO>();
                if (list3.Count > 0)
                    return list3;
                return new List<SachDTO>();
            }
        }
        // get List Search NamXuatBan 
        public List<SachDTO> getFormSachNamXuatBan(string NamXB)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.SACHes
                              from b in db.CT_PHIEUNHAPSACH
                              where a.NamXB.Equals(NamXB) && a.IDSach.Equals(b.IDSach)
                              select new SachDTO()
                              {
                                  IDSach = a.IDSach,
                                  IDDauSach = a.IDDauSach,
                                  IDTacGia = a.IDTacGia,
                                  //TenDauSach = GetDataDAO.Instance.getTenDausachToIDDauSach(a.IDDauSach),
                                  //TenTG = GetDataDAO.Instance.getTenTacGiaToIDTacGia(a.IDTacGia),
                                  NamXB = a.NamXB,
                                  NhaXB = a.NhaXB,
                                  GiaTien = a.GiaTien,
                                  SoLuongTon = a.SoLuongTon,
                                  IDCTPhieuNhap = b.IDCTPhieuNhap,
                                  IDPhieuNhap = b.IDPhieuNhap,
                                  DonGia = b.DonGia,

                              }).ToList<SachDTO>();
                if (result.Count > 0)
                    return result;
                return new List<SachDTO>();
            }
        }
        // get List Search GiaTien
        public List<SachDTO> getFormSachSearchGiaTien(decimal tien)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.SACHes
                              where a.GiaTien.Equals(tien)
                              select new SachDTO()
                              {
                                  IDSach = a.IDSach,
                                  IDDauSach = a.IDDauSach,
                                  IDTacGia = a.IDTacGia,
                                  TenDauSach = GetDataDAO.Instance.getTenDausachToIDDauSach(a.IDDauSach),
                                  TenTG = GetDataDAO.Instance.getTenTacGiaToIDTacGia(a.IDTacGia),
                                  NamXB = a.NamXB,
                                  NhaXB = a.NhaXB,
                                  GiaTien = a.GiaTien,
                                  SoLuongTon = a.SoLuongTon,
                              }).ToList<SachDTO>();
                if (result.Count > 0)
                    return result;
                return new List<SachDTO>();
            }
        }
        //get List Search SoLuongTon
        public List<SachDTO> getFormSachSearchSoLuongTon(int SL)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.SACHes
                              where a.SoLuongTon.Equals(SL)
                              select new SachDTO()
                              {
                                  IDSach = a.IDSach,
                                  IDDauSach = a.IDDauSach,
                                  IDTacGia = a.IDTacGia,
                                  TenDauSach = GetDataDAO.Instance.getTenDausachToIDDauSach(a.IDDauSach),
                                  TenTG = GetDataDAO.Instance.getTenTacGiaToIDTacGia(a.IDTacGia),
                                  NamXB = a.NamXB,
                                  NhaXB = a.NhaXB,
                                  GiaTien = a.GiaTien,
                                  SoLuongTon = a.SoLuongTon,
                              }).ToList<SachDTO>();
                if (result.Count > 0)
                    return result;
                return new List<SachDTO>();
            }
        }
        #endregion
        #region getALl Form DauSach And CTPhieuNhap And "Sach"
        public List<SachDTO> getAllFormDauSachandCTPhieuNhapAndSach()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var getAll = (from a in db.DAUSACHes
                              join b in db.SACHes on a.IDDauSach equals b.IDDauSach
                              select new SachDTO()
                              {
                                  IDSach = b.IDSach,
                                  IDDauSach = b.IDDauSach,
                                  IDTacGia = b.IDTacGia,
                                  NamXB = b.NamXB,
                                  NhaXB = b.NhaXB,
                                  IDLoaiSach = a.IDLoaiSach,
                                  SoLuongTon = b.SoLuongTon,
                                  TenDauSach = a.TenDauSach,
                                  GiaTien = b.GiaTien,
                              }
                            ).ToList<SachDTO>();
                var GetAll = (from a in getAll
                              join b in db.CT_PHIEUNHAPSACH on a.IDSach equals b.IDSach
                              select new SachDTO()
                              {
                                  IDSach = a.IDSach,
                                  IDDauSach = a.IDDauSach,
                                  IDTacGia = a.IDTacGia,
                                  NamXB = a.NamXB,
                                  NhaXB = a.NhaXB,
                                  IDLoaiSach = a.IDLoaiSach,
                                  SoLuongTon = a.SoLuongTon,
                                  TenDauSach = a.TenDauSach,
                                  GiaTien = a.GiaTien,
                                  SoLuong = b.SoLuong,
                                  DonGia = b.DonGia,
                                  IDCTPhieuNhap = b.IDCTPhieuNhap,
                                  IDPhieuNhap = b.IDPhieuNhap,
                                  TongTien=b.ThanhTien,
                              }).ToList<SachDTO>();
                var getAllForm = (from a in GetAll
                                  select new SachDTO()
                                  {
                                      IDSach = a.IDSach,
                                      IDDauSach = a.IDDauSach,
                                      IDTacGia = a.IDTacGia,
                                      NamXB = a.NamXB,
                                      NhaXB = a.NhaXB,
                                      IDLoaiSach = a.IDLoaiSach,
                                      SoLuongTon = a.SoLuongTon,
                                      TenDauSach = a.TenDauSach,
                                      GiaTien = a.GiaTien,
                                      SoLuong = a.SoLuong,
                                      DonGia = a.DonGia,
                                      IDCTPhieuNhap = a.IDCTPhieuNhap,
                                      IDPhieuNhap = a.IDPhieuNhap,
                                      TenLoaiSach = GetDataDAO.Instance.getTenLoaiSachToIDLoaiSach(a.IDLoaiSach),
                                      TenTG = GetDataDAO.Instance.getTenTacGiaToIDTacGia(a.IDTacGia),
                                      TongTien=a.TongTien,
                                  }).ToList<SachDTO>();
                if (getAllForm.Count > 0)
                    return getAllForm;
                return new List<SachDTO>();
            }
        }
        #endregion 
    }
}
