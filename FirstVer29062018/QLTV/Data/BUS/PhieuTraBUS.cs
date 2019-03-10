using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Data.DTO;
using Data.BUS;
using Data.Dtos;
using Data.Model;
using Data.DAO;
using System.IO;
//using Microsoft.Office.Interop.Excel;
//using app = Microsoft.Office.Interop.Excel.Application;
namespace Data.BUS
{
    public class PhieuTraBUS:IPhieuTraBUS
    {
        #region Add Form "PhieuTra"
        public bool AddFormPhieuTra(PhieuTraDtos phieutra,List<int> IDCuonSach)
        {
            try
            {
                using (var db = new QuanLyThuVienEntities())
                {
                    int IDCT;
                    int ID = PhieuTraDAO.Instance.IDPlus();
                    db.PHIEUTRAs.Add(new PHIEUTRA()
                    {
                        IDPhieuTra = ID,
                        IDDocGia = GetDataDAO.Instance.getIDDocGiaToHoTenDG(phieutra.TenDG),
                        NgayTra = phieutra.NgayTra,
                        SoTienTra = 0,
                        TienNoKyNay = 0,
                        TienPhatKyNay = 0,
                    });
                    for (int i = 0; i <IDCuonSach.Count(); i++)
                    { 
                        IDCT = CTPhieuTraDAO.Instance.IDPlus();
                        db.CT_PHIEUTRA.Add(new CT_PHIEUTRA()
                        {
                            IDCTPhieuTra=IDCT,
                            IDPhieuTra=ID,
                            IDPhieuMuon=GetDataDAO.Instance.getIDPhieuMuonToIDCuonSach(IDCuonSach[i]),
                            IDCuonSach=IDCuonSach[i],     
                            SoNgayMuon=PhieuTraDAO.Instance.SoNgayMuon(phieutra.NgayTra,IDCT),
                            TienPhat=PhieuTraDAO.Instance.TinhTienPhat(phieutra.NgayTra,IDCT),
                        });
                        db.SaveChanges();
                        if (HelperDAO.Instance.CheckTraTre(IDCT,phieutra.NgayTra) == true)
                        {
                            int IDBC = BCSachTraTreDAO.Instance.IDPlus();
                            db.BCSACHTRATREs.Add(new BCSACHTRATRE()
                            {
                                IDBCSachTre = IDBC,
                                IDCuonSach = IDCuonSach[i],
                                IDPhieuMuon = GetDataDAO.Instance.getIDPhieuMuonToIDCTPhieuTra(IDCT),
                                NgayThangNam = phieutra.NgayTra,
                                SoNgayTraTre = GetDataDAO.Instance.getSoNgayMuonToIDCTPhieuTra(IDCT),
                            });
                            db.SaveChanges();
                        }
                    }
                    
                    for (int i = 0; i < IDCuonSach.Count(); i++)
                    {
                        int IDCuonsach = IDCuonSach[i];
                        var updateTinhTrang = (from a in db.CUONSACHes
                                               where a.IDCuonSach.Equals(IDCuonsach)
                                               select a).FirstOrDefault<CUONSACH>();
                        updateTinhTrang.TinhTrang = "Chưa cho mượn";
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
        #region  get all from phieutra and CTPhieuTra
        public List<CTPhieuTraDTO> getALlFormPhieuTraAndCTPhieuTra()
        {
            try
            {
                List<CTPhieuTraDTO> phieutra = new List<CTPhieuTraDTO>();
                phieutra = PhieuTraDAO.Instance.getALlFormPhieuTraAndCTPhieuTra();
                return phieutra;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        #region Xuat file excel
        public bool ExportToCsvFile(List<CTPhieuTraDTO> PT, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create), Encoding.UTF8))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("STT,Tên người trả,Tên sách");
                foreach (var p in PT)
                {
                    sb.AppendLine(string.Format("{0},{1},{2}", p.IDCTPhieuTra,p.TenDocGia,p.TenDauSach));
                }

                sw.Write(sb.ToString());
                return true;
            }
        }
        #endregion
    }
}
