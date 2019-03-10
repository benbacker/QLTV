using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;

namespace Data.DAO
{
    public class HelperDAO
    {
        #region Instance
        private static HelperDAO instance;

        public static HelperDAO Instance
        {
            get
            {
                if (instance == null) instance = new HelperDAO(); return DAO.HelperDAO.instance;
            }

            private set
            {
                DAO.HelperDAO.instance = value;
            }
        }
        #endregion
        #region Check LoaiDocGia
        //Check LoaiDocGia  From LOAIDOCGIA to IDLoaiDG
        public string checkLoaiDocGiaFromID(int ID)
        {
            return ID.Equals(1) ?  "Thường" :  "VIP";
        }

        // Check IDLoaiDG From LOAIDOCGIA to TenLoaiDG
        public int checkIDLoaiDGFromTenLoaiDocGia(string TenLoaiDG)
        {
            return TenLoaiDG.Equals("Thường") ? 1 : 2;

        }
         //check HanTheDocGIa to IDDocGia
        public bool CheckHanDocGia(int IDDocGia)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.THEDOCGIAs
                              where a.IDDocGia.Equals(IDDocGia)
                              select a.NgayHetHan).ToString();
                DateTime date = DateTime.Parse(result);
                if (date > DateTime.Now)
                    return false;
                else return true;
            }
        }

        #endregion
        // Check Tra Tre Sach
        public bool CheckTraTre(int IDCTPhieuTra,DateTime ngaytra)
        {
            using (var db = new QuanLyThuVienEntities())
            {
               
                var checkHanTra = (from a in db.CT_PHIEUTRA
                                   from b in db.PHIEUMUONs
                                   where a.IDCTPhieuTra.Equals(IDCTPhieuTra) && b.IDPhieuMuon.Equals(a.IDPhieuMuon)
                                   select b.HanTra).FirstOrDefault();
                if (ngaytra > checkHanTra)
                    return true;
                else return false;
               
            }
        }
        // Check Tai Khoan add Mat khau
        public bool CheckTaiKhoanAndMatKhau(string TenTk,string Mk)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var Check = (from a in db.USERADMINs
                             where a.UserNameAdmin.Equals(TenTk) &&  a.PasswordAdmin.Equals(Mk)
                             select a).FirstOrDefault();
                if (Check == null) return false;
                else return true;
             }
        }
        //Check TonTai DateTime BaoCaoTinhHinhMuonSach
        public bool CheckTonTaiDateTime(DateTime ngaymuon)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                int x = ngaymuon.Month;
                int y = ngaymuon.Year;
                var Check = (from a in db.BCTINHHINHMUONSACHes
                             where a.Thang.Equals(x) && a.Nam.Equals(y)
                             select a).FirstOrDefault();
                if (Check == null)
                    return true;
                else return false;
            }
        }
        //Check Ton Tai IDLoaiSach where CTBC TInh hinh muonsach
        public bool CheckTonTaiIDLoaiSach(int IDLS,int IDBC)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                
                var checkIDLoaiSach = (from a in db.CT_BCTINHHINHMUONSACH
                                       where a.IDLoaiSach.Equals(IDLS)&& a.IDBCMuonSach.Equals(IDBC)
                                       select a).FirstOrDefault();
                if (checkIDLoaiSach == null)
                    return true;
                else return false;
            }
        }

    }
}
