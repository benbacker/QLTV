using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Data.Model;
using Data.DAO;
using Data.DTO;
using Data.Dtos;
using System.IO;

namespace Data.BUS
{
    public class PhieuMuonBUS:IPhieuMuonBUS
    {
        #region Add Form PhieuMuon and CTPhieuMuon 
        public bool AddFormPhieuMuonAndCTPhieuMuon(PhieuMuonDtos  phieuMuon,List<int> IDCuonSach)
        {
            try
            {
                
                using (var db = new QuanLyThuVienEntities())
                {
                    List<int> IDLoaiSachBC = new List<int>();
                    IDLoaiSachBC = GetDataDAO.Instance.getListTheLoaiSach();
                    int ID = PhieuMuonDAO.Instance.IDPlus();
                    db.PHIEUMUONs.Add(new PHIEUMUON()
                    {
                        IDPhieuMuon = ID,
                        IDDocGia = GetDataDAO.Instance.getIDDocGiaToHoTenDG(phieuMuon.TenDocGia),
                        NgayMuon = phieuMuon.NgayMuon,
                        HanTra = PhieuMuonDAO.Instance.HanMuonSach(phieuMuon.NgayMuon),
                    });
                    for (int i = 0; i < IDCuonSach.Count(); i++)
                    {

                        int IDCT = CTPhieuMuonDAO.Instance.IDPlus();
                        db.CT_PHIEUMUON.Add(new CT_PHIEUMUON()
                        {
                            IDCTPhieuMuon = IDCT,
                            IDCuonSach = IDCuonSach[i],
                            IDPhieuMuon = ID,
                        });
                        db.SaveChanges();
                        int temp = IDCuonSach[i];
                        var updateTinhTrang = (from a in db.CUONSACHes
                                               where a.IDCuonSach.Equals(temp)
                                               select a).FirstOrDefault<CUONSACH>();
                        updateTinhTrang.TinhTrang = "Đã cho mượn";
                        db.SaveChanges();
                       
                    }
                    if (HelperDAO.Instance.CheckTonTaiDateTime(phieuMuon.NgayMuon) == true)
                    {
                        int IDBCMuonSach = BCTinhHinhMuonSachDAO.Instance.IDPlus();
                        db.BCTINHHINHMUONSACHes.Add(new BCTINHHINHMUONSACH()
                        {
                            IDBCMuonSach = IDBCMuonSach,
                            Thang = phieuMuon.NgayMuon.Month,
                            Nam = phieuMuon.NgayMuon.Year,
                            NgayLap = phieuMuon.NgayMuon,
                            TongSoLuotMuon = 0,
                        });
                        db.SaveChanges();
                        for (int i = 0; i < IDLoaiSachBC.Count(); i++)
                        {
                            int IDCTBC = CTBCTinhHinhMuonSachDAO.Instance.IDPlus();
                            db.CT_BCTINHHINHMUONSACH.Add(new CT_BCTINHHINHMUONSACH()
                            {
                                IDBCMuonSach = IDBCMuonSach,
                                IDCTBCMuonSach = IDCTBC,
                                IDLoaiSach = IDLoaiSachBC[i],
                                SoLuotMuon = 0,
                                TiLe = 0,

                            });
                            db.SaveChanges();
                        }
                        var updateTongSoLuotMuon = (from a in db.BCTINHHINHMUONSACHes
                                                    where a.IDBCMuonSach.Equals(IDBCMuonSach)
                                                    select a).FirstOrDefault<BCTINHHINHMUONSACH>();
                        updateTongSoLuotMuon.TongSoLuotMuon = updateTongSoLuotMuon.TongSoLuotMuon + IDCuonSach.Count();
                        db.SaveChanges();

                    }
                    else
                    {
                        int IDBaocao = GetDataDAO.Instance.getIDBCMuonSachToNgayMuon(phieuMuon.NgayMuon);

                        var updateTongSoLuotMuon = (from a in db.BCTINHHINHMUONSACHes
                                                    where a.IDBCMuonSach.Equals(IDBaocao)
                                                    select a).FirstOrDefault<BCTINHHINHMUONSACH>();
                        updateTongSoLuotMuon.TongSoLuotMuon = updateTongSoLuotMuon.TongSoLuotMuon + IDCuonSach.Count();
                        db.SaveChanges();
                    }
                    
                    for (int i = 0; i < IDCuonSach.Count(); i++)
                    {
                        int IDLS = GetDataDAO.Instance.getIDLoaiSachToIDCuonSach(IDCuonSach[i]);
                        int IDBC = GetDataDAO.Instance.getIDBCMuonSachToNgayMuon(phieuMuon.NgayMuon);
                        int TongSoLuotMuon = GetDataDAO.Instance.getTongSoluotMuonToIDBC(IDBC);
                        if (HelperDAO.Instance.CheckTonTaiIDLoaiSach(IDLS, IDBC) == true)
                        {
                            int IDCTBC = CTBCTinhHinhMuonSachDAO.Instance.IDPlus();
                            db.CT_BCTINHHINHMUONSACH.Add(new CT_BCTINHHINHMUONSACH()
                            {
                                IDBCMuonSach = IDBC,
                                IDCTBCMuonSach = IDCTBC,
                                IDLoaiSach = IDLS,
                                SoLuotMuon = 0,
                                TiLe = 0,
                            });
                            db.SaveChanges();
                            var update = (from a in db.CT_BCTINHHINHMUONSACH
                                            where a.IDLoaiSach.Equals(IDLS) && a.IDBCMuonSach.Equals(IDBC)
                                            select a).FirstOrDefault<CT_BCTINHHINHMUONSACH>();
                            update.SoLuotMuon = update.SoLuotMuon + 1;
                            update.TiLe = (double)update.SoLuotMuon / TongSoLuotMuon;
                            db.SaveChanges();

                        }  
                        else
                        {                          
                            var updateSL = (from a in db.CT_BCTINHHINHMUONSACH
                                            where a.IDLoaiSach.Equals(IDLS) && a.IDBCMuonSach.Equals(IDBC)
                                            select a).FirstOrDefault<CT_BCTINHHINHMUONSACH>();
                            updateSL.SoLuotMuon = updateSL.SoLuotMuon + 1;
                            db.SaveChanges();
                            for (int j = 0; j < IDLoaiSachBC.Count(); j++)
                            {
                                updateSL.TiLe = (double)updateSL.SoLuotMuon / TongSoLuotMuon;
                                db.SaveChanges();
                            }

                        }

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
        #region getList Search PhieuMuonDTO
        //get List IDDocGia
        public List<PhieuMuonDTO> getFormPhieuMuonSearchIDDocGia(int ID)
        {
            try
            {
                List<PhieuMuonDTO> ListPhieuMuon = new List<PhieuMuonDTO>();
                ListPhieuMuon = PhieuMuonDAO.Instance.getFormPhieuMuonSearchIDDocGia(ID);
                return ListPhieuMuon;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //get List search IDPhieuMuon
        public List<PhieuMuonDTO> getFormPhieuMuonSearchIDPhieuMuon(int ID)
        {
            try
            {
                List<PhieuMuonDTO> ListPhieuMuon = new List<PhieuMuonDTO>();
                ListPhieuMuon = PhieuMuonDAO.Instance.getFormPhieuMuonSearchIDPhieuMuon(ID);
                return ListPhieuMuon;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //get List search ngaymuon
        public List<PhieuMuonDTO> getFormPhieuMuonSearchNgayMuon(DateTime ngaymuon)
        {
            try
            {
                List<PhieuMuonDTO> ListPhieuMuon = new List<PhieuMuonDTO>();
                ListPhieuMuon = PhieuMuonDAO.Instance.getFormPhieuMuonSearchNgayMuon(ngaymuon);
                return ListPhieuMuon;
            }
            catch (Exception)
            {

                throw;
            }
        }
        // get list search Han Tra
        public List<PhieuMuonDTO> getFormPhieuMuonSearchHanTra(DateTime hantra)
        {
            try
            {
                List<PhieuMuonDTO> ListPhieuMuon = new List<PhieuMuonDTO>();
                ListPhieuMuon = PhieuMuonDAO.Instance.getFormPhieuMuonSearchHanTra(hantra);
                return ListPhieuMuon;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        #region editForm PhieuMuon And CTPhieuMuon
        public bool editFormPhieuMuonAndCTPhieuMuon(PhieuMuonDTO phieumuon)
        {
            try
            {
                using (var db= new QuanLyThuVienEntities())
                {
                    var Edit = (from a in db.PHIEUMUONs
                                where a.IDPhieuMuon.Equals(phieumuon.IDPhieuMuon)
                                select a).FirstOrDefault();
                    if (Edit == null) return false;
                    Edit.NgayMuon = phieumuon.NgayMuon;
                    Edit.IDDocGia = phieumuon.IDDocGia;
                    Edit.HanTra = PhieuMuonDAO.Instance.HanMuonSach(phieumuon.NgayMuon);
                    var EditCT = (from a in db.CT_PHIEUMUON
                                  where a.IDCTPhieuMuon.Equals(phieumuon.IDCTPhieuMuon)
                                  select a).FirstOrDefault();
                    if (EditCT == null) return false;
                    EditCT.IDCuonSach = GetDataDAO.Instance.getIDCuonSach(phieumuon.TenDauSach);
                    EditCT.IDPhieuMuon = phieumuon.IDPhieuMuon;
                    var updateTinhTrang = (from a in db.CUONSACHes
                                           where a.IDCuonSach.Equals(GetDataDAO.Instance.getIDCuonSach(phieumuon.TenDauSach))
                                           select a).FirstOrDefault<CUONSACH>();
                    updateTinhTrang.TinhTrang = "Đã cho mượn";
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
        #region getAll FormPhieuMuonAndCTPhieuMuon
        public List<PhieuMuonDTO> getAllFormPhieuMuonAndCTPhieuMuon()
        {
            try
            {
                List<PhieuMuonDTO> ListPhieuMuon = new List<PhieuMuonDTO>();
                ListPhieuMuon = PhieuMuonDAO.Instance.getAllFormPhieuMuonAndCTPhieuMuon();
                return ListPhieuMuon;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        #region Xuat file excel
        public bool ExportToCsvFile(List<PhieuMuonDTO> PM, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create), Encoding.UTF8))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("STT,Tên người mượn,Tên đầu sách,Ngày mượn");
                foreach (var p in PM)
                {
                    sb.AppendLine(string.Format("{0},{1},{2},{3}", p.IDCTPhieuMuon,p.TenNguoiMuon,p.TenDauSach,p.NgayMuon.ToString("dd-MM-yyyy")));
                }

                sw.Write(sb.ToString());
                return true;
            }
        }
        #endregion
    }
}
