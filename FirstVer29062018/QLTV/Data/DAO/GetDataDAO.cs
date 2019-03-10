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
    public class GetDataDAO
    {
        #region Instance
        private static GetDataDAO instance;

        public static GetDataDAO Instance
        {
            get
            {
                if (instance == null) instance = new GetDataDAO(); return DAO.GetDataDAO.instance;
            }

            private set
            {
                DAO.GetDataDAO.instance = value;
            }
        }
        #endregion
        #region get Name to ID
        // get TenDocGia to IDDocGia
        public string getTenDocGiaToIDDocGia(int ID)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var TenDocGia = (from a in db.THEDOCGIAs
                                 where a.IDDocGia.Equals(ID)
                                 select a.HoTenDG).FirstOrDefault();
                return TenDocGia;
            }
        }
        //get IDTacGia To TenTacGia
        public int getIDTacGiaToTenTacGia(string TenTacGia)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var Id = (from a in db.TACGIAs
                          where a.TenTacGia.Equals(TenTacGia)
                          select a.IDTacGia).FirstOrDefault();

                return Id;
            }
        }
        //get TenDauSach to IDDauSach
        public string getTenDausachToIDDauSach(int ID)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var TenDauSach = (from a in db.DAUSACHes
                                  where a.IDDauSach.Equals(ID)
                                  select a.TenDauSach).ToString();
                return TenDauSach;
            }
        }
        // get TenLoaiSach to IDLoaiSach
        public string getTenLoaiSachToIDLoaiSach(int ID)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var TenLoaiSach = (from a in db.LOAISACHes
                                   where a.IDLoaiSach.Equals(ID)
                                   select a.TenLoaiSach).FirstOrDefault();
                return TenLoaiSach;
            }
        }
        // get IDCuonSach to TenDauSach
        public int getIDCuonSach(string tb_TenSach)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.DAUSACHes
                              from b in db.SACHes
                              from c in db.CUONSACHes
                              where a.TenDauSach.Equals(tb_TenSach) && b.IDDauSach.Equals(a.IDDauSach) && b.IDSach.Equals(c.IDSach) && c.TinhTrang.Equals("Chưa cho mượn")
                              select c.IDCuonSach).FirstOrDefault();
                return result;

            }
        }
        //get TenCuonSach to IDCuonSach
        public string getTenCuonSach(int IDCuonSach)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var TenCuonSach = (from a in db.CUONSACHes
                                   from b in db.DAUSACHes
                                   from c in db.SACHes
                                   where a.IDCuonSach.Equals(IDCuonSach) && a.IDSach.Equals(c.IDSach) && b.IDDauSach.Equals(c.IDDauSach)
                                   select b.TenDauSach).FirstOrDefault();
                return TenCuonSach;
            }
        }
        public int getTongSoluotMuonToIDBC(int ID)
        {
            using (var db =new QuanLyThuVienEntities())
            {
                var SoLuot = (from a in db.BCTINHHINHMUONSACHes
                              where a.IDBCMuonSach.Equals(ID)
                              select a.TongSoLuotMuon).FirstOrDefault();
                return SoLuot;
            }
        }
        //get IDLoaiSach to TenLoaiSach
        public int getIDLoaiSachToTenLoaiSach(string TenLoaiSach)
        {
            using (var db= new QuanLyThuVienEntities())
            {
                var IDLoaiSach = (from a in db.LOAISACHes
                                  where a.TenLoaiSach.Equals(TenLoaiSach)
                                  select a.IDLoaiSach).FirstOrDefault();

                return IDLoaiSach;
            }
        }
       // getIDPhieuNhap to NgayNhapSach
       public int getIDPhieuNhapToNgayNhapSach(DateTime NgayNhap)
        {
            using (var db= new QuanLyThuVienEntities())
            {
                var IDPhieuNhap = (from a in db.PHIEUNHAPSACHes
                                   where a.NgayNhap.Equals(NgayNhap)
                                   select a.IDPhieuNhap);
                if (IDPhieuNhap.Count() != 0)
                    return PhieuNhapSachDAO.Instance.IDPlus();
                else
                    return IDPhieuNhap.FirstOrDefault();
            }
        }
        //HanTRa to IDCTPhieuTra
        public DateTime HanTraSachToIDCTPhieuTra(int IDCTPhieuTra)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var HanTra = (from a in db.CT_PHIEUTRA
                              from b in db.PHIEUMUONs
                              where a.IDCTPhieuTra.Equals(IDCTPhieuTra) && b.IDPhieuMuon.Equals(a.IDPhieuMuon)
                              select b.HanTra).ToString();
                DateTime HanTraS = DateTime.Parse(HanTra);
                return HanTraS;
            }
        }
        // get TenTacGia To IDTacGia
        public string getTenTacGiaToIDTacGia(int IDTG)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var TenTacGia = (from a in db.TACGIAs
                                 where a.IDTacGia.Equals(IDTG)
                                 select a.TenTacGia).FirstOrDefault();
                return TenTacGia;
            }
        }
        // get Songaymuon to IDCT Phieu Tra
        public int getSoNgayMuonToIDCTPhieuTra(int ID)
        {
            using (var db= new QuanLyThuVienEntities())
            {
                var SoNgay = (from a in db.CT_PHIEUTRA 
                              where a.IDCTPhieuTra.Equals(ID)
                              select a.SoNgayMuon).FirstOrDefault();
                return SoNgay; 
            }
        }
        //get IDPhieuMuon to IDCTPhieuTra
        public int getIDPhieuMuonToIDCTPhieuTra(int ID)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var IDPhieuMuon = (from a in db.CT_PHIEUTRA
                          select a.IDPhieuMuon).FirstOrDefault();
                return IDPhieuMuon;
            }
        }
        
        //get IDDG to HoTenDG
        public int getIDDocGiaToHoTenDG(string HoTenDG)
        {
            using (var db =new QuanLyThuVienEntities())
            {
                var IDDG = (from a in db.THEDOCGIAs
                            where a.HoTenDG.Equals(HoTenDG)
                            select a.IDDocGia).FirstOrDefault();
                return IDDG;
            }
        }
        //get Idphieumuon to IDCuonSach
        public int getIDPhieuMuonToIDCuonSach(int IDCuonSach)
        {
            using (var db= new QuanLyThuVienEntities())
            {
                var IDPhieuMuon = (
                                 from b in db.PHIEUMUONs
                                 from c in db.CT_PHIEUMUON
                                 where c.IDCuonSach.Equals(IDCuonSach) && b.IDPhieuMuon.Equals(c.IDPhieuMuon)
                                 select b.IDPhieuMuon).FirstOrDefault();
                return IDPhieuMuon;
                                 
            }
        }
        //get IDLoaiSach to IDCuonSach
        public int getIDLoaiSachToIDCuonSach(int IDCS)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var IDLoaiSach = (from a in db.CUONSACHes
                                  from b in db.SACHes
                                  from c in db.DAUSACHes
                                  where a.IDCuonSach.Equals(IDCS) && a.IDSach.Equals(b.IDSach) && b.IDDauSach.Equals(c.IDDauSach)
                                  select c.IDLoaiSach).FirstOrDefault();
                return IDLoaiSach;
            }
        }
        // get IDBCMuonSach to ngaymuon
        public int getIDBCMuonSachToNgayMuon(DateTime ngaymuon)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                int x = ngaymuon.Month;
                int y = ngaymuon.Year;
                var IDBC = (from a in db.BCTINHHINHMUONSACHes
                            where a.Thang.Equals(x) && a.Nam.Equals(y)
                            select a.IDBCMuonSach).FirstOrDefault();
                return IDBC;
            }
        }
        //Count Sum TongSoLuotMuon BCSachTra Tre to datetime
        public string TongSoLuotMuon(DateTime NgayLap)
        {
            using (var db= new QuanLyThuVienEntities())
            {
                var TongSoLuotMuon = (from a in db.BCSACHTRATREs
                                      where a.NgayThangNam.CompareTo(NgayLap) <= 0
                                      select a.SoNgayTraTre).Sum().ToString();
                return TongSoLuotMuon;
            }
        }
        // get NguoiLapBaoCao
        public string getNguoiLapBaoCao()
        {
            using (var db= new QuanLyThuVienEntities())
            {
                var NguoiLap = (from a in db.USERADMINs
                                select a.UserNameAdmin).FirstOrDefault();
                return NguoiLap;
            }
        }
        // get Tong So Luot Muon to date 
        public string getTongSoLuotMuonToDate(int Thang,int Nam)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var TongLuotMuon = (from a in db.BCTINHHINHMUONSACHes
                                    where a.Thang.Equals(Thang) && a.Nam.Equals(Nam)
                                    select a.TongSoLuotMuon.ToString()).FirstOrDefault();
                return TongLuotMuon;
            }
        }
        #endregion
        #region Get list and Array 
        //getList TenTheLoai Sach
        public List<string> getListTenTheLoaiSach()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var listTenTheLoai = (from a in db.LOAISACHes
                                      select a.TenLoaiSach.ToString()).ToList();
                return listTenTheLoai;
            }
        }
        //get Array TenTacGia 
        public string[] getArrayTenTacGia()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var ArrTenTacGia = (from a in db.TACGIAs
                                    select a.TenTacGia).ToArray();
                return ArrTenTacGia;
            }
        }
        // get List TenTacGia
        public List<string> getListTenTacGia()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var listTenTacGia = (from a in db.TACGIAs
                                     select a.TenTacGia.ToString()).ToList();
                return listTenTacGia;
            }
        }
        //get list IDCuonSach To IDPhieuMuon
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
        // get List auto complete TenTheLoai Sach
        public List<string> getListAutoTenTheLoai(string tb_TenTheLoai)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var ListTheLoai = (from a in db.LOAISACHes
                                   where a.TenLoaiSach.ToUpper().Contains(tb_TenTheLoai.ToUpper())
                                   select a.TenLoaiSach.ToString()).ToList();
                return ListTheLoai;
            }
        }
        //get List auto complete TenTacGia
        public List<string> getListAutoTenTacGia(String tb_TenTacGia)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var ListTenTacGia = (from a in db.TACGIAs
                                     where a.TenTacGia.ToUpper().Contains(tb_TenTacGia.ToUpper())
                                     select a.TenTacGia.ToString()).ToList();
                return ListTenTacGia;
            }
        }
        //getList auto complete HoTenDG
        public List<string> getListAutoHoTenDG(String tb_HoTenDG)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var ListHoTenDG = (from a in db.THEDOCGIAs
                                   where a.HoTenDG.ToUpper().Contains(tb_HoTenDG.ToUpper())
                                   select a.HoTenDG.ToString()).ToList();
                return ListHoTenDG;
            }
        }
        //get arr IDDG
        public int[] getArrIDDG()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var ArrIDDG = (from a in db.THEDOCGIAs
                                select a.IDDocGia).ToArray();
                return ArrIDDG;
            }
        }
        // get Array Auto TenTacGia
        public string[] getArrAutoTenTacGia(string tb_TenTacGia)
        {
            using (var db= new QuanLyThuVienEntities())
            {
                var ArrTenTacGia = (from a in db.TACGIAs
                                    where a.TenTacGia.ToUpper().Contains(tb_TenTacGia.ToUpper())
                                    select a.TenTacGia.ToString()).ToArray();
                return ArrTenTacGia;
            }
        }
        //get Array auto TenTheLoai Sach
        public string[] getArrAutoTenTheLoai(string tb_TenTheLoai)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var ArrTenTheLoai = (from a in db.LOAISACHes
                                     where a.TenLoaiSach.ToUpper().Contains(tb_TenTheLoai.ToUpper())
                                     select a.TenLoaiSach.ToString()).ToArray();
                return ArrTenTheLoai;
            }
        }
        //get list NhaXB
        public string[] getArrNhaXB()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var listNhaXB = (from a in db.SACHes
                                 select a.NhaXB.ToString()).ToArray();
                return listNhaXB;
            }
        }
        //get Arr TenDauSach
        public String[] getArrTenDauSach()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var ArrTenDauSach = (from a in db.DAUSACHes
                                     select a.TenDauSach.ToString()).ToArray();
                return ArrTenDauSach;
            }
        }
        public string[] getArrTenDG()
        {
            using (var db=new QuanLyThuVienEntities())
            {
                var arr = (from a in db.THEDOCGIAs
                           select a.HoTenDG.ToString()).ToArray();
                return arr;
            }
        }
        //get list TenTac Gia To TenDauSach
        public List<string> getListTenTacGiaToTenDauSach(string TenDauSach)
        {
            using (var db = new QuanLyThuVienEntities())
            {

                var listTenTacGia = (from a in db.DAUSACHes
                                     from b in db.SACHes
                                     from c in db.TACGIAs
                                     where a.TenDauSach.Equals(TenDauSach) && a.IDDauSach.Equals(b.IDDauSach) && b.IDTacGia.Equals(c.IDTacGia)
                                     select c.TenTacGia.ToString()).ToList();
                return listTenTacGia;
            }
        }
        // get list CuonSachDTO
        public List<CuonSachDTO> getList(string TenDauSach, string TenTacGia)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var list = (from a in db.DAUSACHes
                            join b in db.SACHes on a.IDDauSach equals b.IDDauSach
                            join c in db.TACGIAs on b.IDTacGia equals c.IDTacGia
                            join d in db.CUONSACHes on b.IDSach equals d.IDSach
                            where a.TenDauSach.Equals(TenDauSach) && c.TenTacGia.Equals(TenTacGia) && d.TinhTrang == "Chưa cho mượn"
                            select new CuonSachDTO()
                            {
                                IDCuonSach = d.IDCuonSach,
                                IDSach = d.IDSach,
                                TinhTrang = "Chưa cho mượn",
                                TenDauSach = TenDauSach,
                                TenTacGia = TenTacGia,
                            }).ToList<CuonSachDTO>();
                var getList = (from a in list
                               select new CuonSachDTO()
                               {
                                   IDCuonSach = a.IDCuonSach,
                                   IDSach = a.IDSach,
                                   TenDauSach = a.TenDauSach,
                                   TenTacGia = a.TenTacGia,
                                   TinhTrang = a.TinhTrang,
                               }).ToList<CuonSachDTO>();
                if (getList.Count > 0)
                    return getList;
                return new List<CuonSachDTO>();
            }
        }
        //get List cuonsachDtos to HoTenDG
        public List<CuonSachDtos> getListCuonSachDtos(string HoTenDG)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var list = (
                          from b in db.THEDOCGIAs
                          from d in db.PHIEUMUONs
                          from c in db.CUONSACHes
                          from a in db.CT_PHIEUMUON
                          where b.HoTenDG.Equals(HoTenDG) && b.IDDocGia.Equals(d.IDDocGia) && d.IDPhieuMuon.Equals(a.IDPhieuMuon)
                          && c.IDCuonSach.Equals(a.IDCuonSach) && c.TinhTrang == "Đã cho mượn"
                          select new CuonSachDtos()
                          {
                              IDCuonSach = a.IDCuonSach,
                              IDSach = c.IDSach,
                              TinhTrang = c.TinhTrang,
                          }).ToList<CuonSachDtos>();
                var listkq = (from a in list
                              select new CuonSachDtos()
                              {
                                  IDCuonSach = a.IDCuonSach,
                                  IDSach = a.IDSach,
                                  TenCuonSach=getTenCuonSach(a.IDCuonSach),
                                  TinhTrang=a.TinhTrang,
                              }).ToList<CuonSachDtos>();
                if (listkq.Count > 0)
                    return listkq;
                return new List<CuonSachDtos>();
            }
        }
        // get list IDPhieumuon to HoTenDG
        public List<string> getListIDPhieuMuonToHoTenDG(string HoTenDG)
        {
            using (var db= new QuanLyThuVienEntities())
            {
                var listID = (from a in db.THEDOCGIAs
                              from b in db.PHIEUMUONs
                              where a.HoTenDG.Equals(HoTenDG) && a.IDDocGia.Equals(b.IDDocGia)
                              select b.IDPhieuMuon.ToString()).ToList();
                return listID;
            }
        }
        // get list TheLoaiSach 
        public List<int> getListTheLoaiSach()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var listTheLoai = (from a in db.LOAISACHes
                                   select a.IDLoaiSach).ToList<int>();
                return listTheLoai;
            }
        }
        // Check Tai Khoan add Mat khau
        public bool CheckTaiKhoanAndMatKhau(string TenTk, string Mk)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var Check = (from a in db.USERADMINs
                             where a.UserNameAdmin.Equals(TenTk) && a.PasswordAdmin.Equals(Mk)
                             select a).FirstOrDefault();
                if (Check == null) return false;
                else return true;
            }
        }
        #endregion
        
    }

}
