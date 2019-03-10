using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Data.Model;
using Data.DAO;
using Data.BUS;
using Data.Dtos;
using Data.DTO;
using System.IO;

namespace Data.BUS
{
    public  class SachBUS :ISachBUS
    {
        #region Add Form DauSach , Sach ,CT _PhieuNhap
        public bool ADDFormSach(SachDTO sach)
        {
            try
            {
                using (var db = new QuanLyThuVienEntities())
                {
                    int ID = DauSachDAO.Instance.IDPlus();
                    db.DAUSACHes.Add(new DAUSACH()
                    {
                        IDDauSach = ID,
                        IDLoaiSach = GetDataDAO.Instance.getIDLoaiSachToTenLoaiSach(sach.TenLoaiSach),
                        TenDauSach = sach.TenDauSach
                    });
                    int IDsach = SachDAO.Instance.IDPlus();
                    db.SACHes.Add(new SACH()
                    {
                        IDSach = IDsach,
                        IDDauSach = ID,
                        IDTacGia = GetDataDAO.Instance.getIDTacGiaToTenTacGia(sach.TenTG),
                        GiaTien = sach.GiaTien,
                        NamXB = sach.NamXB,
                        SoLuongTon = 0,
                        NhaXB = sach.NhaXB,
                    });
                    int IDPhieuNhap = PhieuNhapSachDAO.Instance.IDPlus();
                    db.PHIEUNHAPSACHes.Add(new PHIEUNHAPSACH()
                    {
                        IDPhieuNhap = IDPhieuNhap,
                        NgayNhap = sach.NgayNhap,
                        TongTien = sach.DonGia*sach.SoLuong,
                    });
                    int IDCT = CTPhieuNhapSachDAO.Instance.IDPlus();
                    db.CT_PHIEUNHAPSACH.Add(new CT_PHIEUNHAPSACH()
                    {
                        IDCTPhieuNhap = IDCT,
                        IDPhieuNhap = IDPhieuNhap,
                        IDSach = IDsach,
                        SoLuong = sach.SoLuong,
                        DonGia = sach.DonGia,
                        ThanhTien = sach.DonGia*sach.SoLuong,
                    });
                    db.SaveChanges();
                    var updateSoLuong = (from a in db.SACHes
                                         where a.IDSach.Equals(IDsach)
                                         select a).FirstOrDefault<SACH>();
                    updateSoLuong.SoLuongTon = updateSoLuong.SoLuongTon + sach.SoLuong;
                    db.SaveChanges();
                    for (int i = 0; i < sach.SoLuong; i++)
                    {
                        int IDCuonSach = CuonSachDAO.Instance.IDPlus();
                        db.CUONSACHes.Add(new CUONSACH()
                        {
                            IDCuonSach = IDCuonSach,
                            IDSach = IDsach,
                            TinhTrang = "Chưa cho mượn"
                        });
                        db.SaveChanges();
                    }
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
        #region EditForm DauSach,Sach,CT_PhieuNhap
        public bool editFormDauSachAndSachAndCTPhieuNhap(SachDTO sach)
        {
            try
            {
                using(var db = new QuanLyThuVienEntities())
                {
                    var EditDAUSACH = (from a in db.DAUSACHes
                                where a.IDDauSach.Equals(sach.IDDauSach)
                                select a).FirstOrDefault();
                    if (EditDAUSACH == null) return false;
                    EditDAUSACH.IDLoaiSach = GetDataDAO.Instance.getIDLoaiSachToTenLoaiSach(sach.TenLoaiSach);
                    EditDAUSACH.TenDauSach = sach.TenDauSach;
                    var EditSach = (from a in db.SACHes
                                    where a.IDSach.Equals(sach.IDSach)
                                    select a).FirstOrDefault();
                    if (EditSach == null) return false;
                    EditSach.IDDauSach = sach.IDDauSach;   
                    EditSach.IDTacGia = GetDataDAO.Instance.getIDTacGiaToTenTacGia(sach.TenTG);
                    EditSach.NamXB = sach.NamXB;
                    EditSach.NhaXB = sach.NhaXB;
                    EditSach.SoLuongTon = sach.SoLuongTon + sach.SoLuong;
                    EditSach.GiaTien = sach.GiaTien;
                    var EditCTPhieuNhap = (from a in db.CT_PHIEUNHAPSACH
                                           where a.IDCTPhieuNhap.Equals(sach.IDCTPhieuNhap)
                                           select a).FirstOrDefault();
                    EditCTPhieuNhap.IDPhieuNhap = GetDataDAO.Instance.getIDPhieuNhapToNgayNhapSach(sach.NgayNhap);
                    EditCTPhieuNhap.IDSach = sach.IDSach;
                    EditCTPhieuNhap.SoLuong = sach.SoLuong;
                    EditCTPhieuNhap.DonGia = sach.DonGia;
                    EditCTPhieuNhap.ThanhTien = sach.SoLuong * sach.DonGia;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }  
        #endregion
        #region getListSearch SachDTO
        //get List Search NamXuatban
        public List<SachDTO> getFormSachNamXuatBan(string NamXB)
        {
            try
            {
                List<SachDTO> listSach = new List<SachDTO>();
                listSach = SachDAO.Instance.getFormSachNamXuatBan(NamXB);
                return listSach;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //get List Search NhaXuatBan
        public List<SachDTO> getFormSachNhaXuatBan(string NhaxB)
        {
            try
            {
                List<SachDTO> listSach = new List<SachDTO>();
                listSach = SachDAO.Instance.getFormSachNhaXuatBan(NhaxB);
                return listSach;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //get List Search GiaTien
        public List<SachDTO> getFormSachSearchGiaTien(decimal tien)
        {
            try
            {
                List<SachDTO> listSach = new List<SachDTO>();
                listSach = SachDAO.Instance.getFormSachSearchGiaTien(tien);
                return listSach;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //get List Search IDSach
        public List<SachDTO> getFormSachSearchIDSach(int IDsach)
        {
            try
            {
                List<SachDTO> listSach = new List<SachDTO>();
                listSach = SachDAO.Instance.getFormSachSearchIDSach(IDsach);
                return listSach;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //get List Search SoluongTon
        public List<SachDTO> getFormSachSearchSoLuongTon(int SL)
        {
            try
            {
                List<SachDTO> listSach = new List<SachDTO>();
                listSach = SachDAO.Instance.getFormSachSearchSoLuongTon(SL);
                return listSach;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //get List Search TenDauSach
        public List<SachDTO> getFormSachTenDauSach(string TenDauSach)
        {
            try
            {
                List<SachDTO> listSach = new List<SachDTO>();
                listSach = SachDAO.Instance.getFormSachTenDauSach(TenDauSach);
                return listSach;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        #region GetallFormDauSachand Sach And CTPhieuNhap
        public List<SachDTO> getAllFormDauSachandCTPhieuNhapAndSach()
        {
            try
            {
                List<SachDTO> listSach = new List<SachDTO>();
                listSach = SachDAO.Instance.getAllFormDauSachandCTPhieuNhapAndSach();
                return listSach;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        #region Xuat file excel
        public bool ExportToCsvFile(List<SachDTO> sach, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create), Encoding.UTF8))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("STT,Tên Sách,Tên tác giả,Thể loại,Nhà xuất bản,Năm xuất bản,Giá tiền");
                foreach (var p in sach)
                {
                    sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6}",p.IDSach,p.TenDauSach,p.TenTG,p.TenLoaiSach,p.NhaXB,p.NamXB,p.GiaTien ));
                }

                sw.Write(sb.ToString());
                return true;
            }
        }
        #endregion
    }
}
    