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
    public class TheDocGiaDAO
    {
        #region Instance
        private static TheDocGiaDAO instance;

        public static TheDocGiaDAO Instance
        {
            get
            {
                if (instance == null) instance = new TheDocGiaDAO(); return DAO.TheDocGiaDAO.instance;
            }

            private set
            {
                DAO.TheDocGiaDAO.instance = value;
            }
        }
        #endregion
        #region Count
        // Count ID
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from b in db.THEDOCGIAs select b.IDDocGia).Max()).ToString();
                int ID = Int32.Parse(query);
                int idplus = ++ID;
                return idplus;
            }
        }
        // Count  NgayHetHan "TheDocGia"
        public DateTime countHanThe(DateTime NgayLap)
        {
            DateTime HanThe;
            HanThe = NgayLap.AddMonths(6);
            return HanThe;
        }
        #endregion
        #region getlist"TheDocGiaDTO" All"DocGia"and User 
        public List<TheDocGiaDTO> getAllDocGiaAndUser()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var resultQuery = (from a in db.THEDOCGIAs
                                   join b in db.USERS on a.IDDocGia equals b.IDDocGia
                                   select new TheDocGiaDTO()
                                   {
                                       IDDocGia = a.IDDocGia,
                                       HoTenDG = a.HoTenDG,
                                       DiaChiDG = a.DiaChiDG,
                                       EmailDG = a.EmailDG,
                                       NgaySinhDG = a.NgaySinhDG,
                                       NgayLapThe = a.NgayLapThe,
                                       NgayHetHan = a.NgayHetHan,
                                       Password = b.Pwd,
                                       IDLoaiDocGia = a.IDLoaiDG,
                                       UserName = b.UserName,
                                       TongNo = a.TongNo,
                                   }).ToList<TheDocGiaDTO>();
                var result = (from a in resultQuery
                              select new TheDocGiaDTO()
                              {
                                  IDDocGia = a.IDDocGia,
                                  HoTenDG = a.HoTenDG,
                                  DiaChiDG = a.DiaChiDG,
                                  EmailDG = a.EmailDG,
                                  NgaySinhDG = a.NgaySinhDG,
                                  NgayLapThe = a.NgayLapThe,
                                  NgayHetHan = a.NgayHetHan,
                                  Password = a.Password,
                                  TenLoaiDocGia = HelperDAO.Instance.checkLoaiDocGiaFromID(a.IDLoaiDocGia),
                                  UserName = a.UserName,
                                  TongNo = a.TongNo,
                              }).ToList<TheDocGiaDTO>();
                if (result.Count > 0)
                    return result;
                return new List<TheDocGiaDTO>();
            }
        }
        #endregion
        #region getListData TheDocGiaDtos
        //getListData IDDocGia From"THeDocGia"
        public List<TheDocGiaDtos> GetFormTheDocGia(int ID)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var Result = (from m in db.THEDOCGIAs
                              where m.IDDocGia.Equals(ID)
                              select new TheDocGiaDtos()
                              {
                                  IDDocGia = m.IDDocGia,
                                  HoTenDG = m.HoTenDG,
                                  DiaChiDG = m.DiaChiDG,
                                  EmailDG = m.EmailDG,
                                  NgayLapThe=m.NgayLapThe,
                                  NgaySinhDG=m.NgaySinhDG,
                                  IDLoaiDocGia=m.IDLoaiDG,
                              }).ToList<TheDocGiaDtos>();
                return Result;                   
            }
        }
       // getListData HoTenDG From"TheDocGia"
        public List<TheDocGiaDtos> getFormTheDocGiaToHoTenDG(string HoTenDG)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from m in db.THEDOCGIAs
                              where m.HoTenDG.ToUpper().Contains(HoTenDG.ToUpper())
                              select new TheDocGiaDtos()
                              {
                                  IDDocGia = m.IDDocGia,
                                  DiaChiDG = m.DiaChiDG,
                                  EmailDG = m.EmailDG,
                                  NgayLapThe = m.NgayLapThe,
                                  NgaySinhDG = m.NgaySinhDG,
                                  HoTenDG = m.HoTenDG,
                                  IDLoaiDocGia = m.IDLoaiDG,
                                  HetHan = m.NgayHetHan,
                                  TongNo=m.TongNo,
                              }).ToList<TheDocGiaDtos>();
                return result;
            }
        }
        #endregion
        #region getListSearch TheDocGiaDTO
        //getListSearch HoTenDG From "THEDOCGIA"
        public List<TheDocGiaDTO> getFromTheDocGiaSearchHoTenDG(string TenDG)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var Result = (from a in db.THEDOCGIAs
                             where a.HoTenDG.ToUpper().Contains(TenDG.ToUpper())
                             select new TheDocGiaDtos()
                             {
                                 IDDocGia=a.IDDocGia,
                                 HoTenDG = a.HoTenDG,
                                 EmailDG = a.EmailDG,
                                 NgaySinhDG = a.NgaySinhDG,
                                 NgayLapThe = a.NgayLapThe,
                                 HetHan = a.NgayHetHan,
                                 IDLoaiDocGia = a.IDLoaiDG,
                                 DiaChiDG = a.DiaChiDG,
                                 TongNo = a.TongNo,
                             }).ToList<TheDocGiaDtos>();
                var Resultkq = (from b in Result
                                join c in db.USERS on b.IDDocGia equals c.IDDocGia
                                select new TheDocGiaDTO()
                                {
                                    IDDocGia=b.IDDocGia,
                                    HoTenDG = b.HoTenDG,
                                    EmailDG = b.EmailDG,
                                    NgaySinhDG = b.NgaySinhDG,
                                    NgayLapThe = b.NgayLapThe,
                                    NgayHetHan = b.HetHan,
                                    IDLoaiDocGia=b.IDLoaiDocGia,
                                    DiaChiDG = b.DiaChiDG,
                                    TongNo = b.TongNo,
                                    Password=c.Pwd,
                                    UserName=c.UserName,
                                }).ToList<TheDocGiaDTO>();
                var ListSearchTenDG = (from a in Resultkq
                                       select new TheDocGiaDTO()
                                       {
                                           IDDocGia = a.IDDocGia,
                                           HoTenDG = a.HoTenDG,
                                           EmailDG = a.EmailDG,
                                           NgaySinhDG = a.NgaySinhDG,
                                           DiaChiDG = a.DiaChiDG,
                                           NgayLapThe = a.NgayLapThe,
                                           NgayHetHan = a.NgayHetHan,
                                           TenLoaiDocGia = HelperDAO.Instance.checkLoaiDocGiaFromID(a.IDLoaiDocGia),
                                           Password = a.Password,
                                           IDLoaiDocGia = a.IDLoaiDocGia,
                                           UserName = a.UserName,
                                           TongNo = a.TongNo,
                                       }).ToList<TheDocGiaDTO>();
                if (ListSearchTenDG.Count > 0)
                    return ListSearchTenDG;
                return new List<TheDocGiaDTO>();
            }
        }
        //getListSearch EmailDG from "THEDOCGIA"
        public List<TheDocGiaDTO> getFormTheDocGiaSearchEmailDG(string EmailDG)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.THEDOCGIAs
                              where a.EmailDG.ToUpper().Contains(EmailDG.ToUpper())
                              select new TheDocGiaDtos()
                              {
                                  IDDocGia=a.IDDocGia,
                                  HoTenDG = a.HoTenDG,
                                  DiaChiDG = a.DiaChiDG,
                                  NgayLapThe = a.NgayLapThe,
                                  HetHan = a.NgayHetHan,
                                  TongNo = a.TongNo,
                                  NgaySinhDG = a.NgaySinhDG,
                                  IDLoaiDocGia=a.IDLoaiDG,
                                  EmailDG = a.EmailDG,
                              }).ToList<TheDocGiaDtos>();
                var Resultkq=(from b in result
                              join c in db.USERS on b.IDDocGia equals c.IDDocGia
                              select new TheDocGiaDTO()
                              {
                                  IDDocGia=b.IDDocGia,
                                  HoTenDG=b.HoTenDG,
                                  EmailDG = b.EmailDG,
                                  NgaySinhDG = b.NgaySinhDG,
                                  NgayLapThe = b.NgayLapThe,
                                  NgayHetHan = b.HetHan,
                                  IDLoaiDocGia=b.IDLoaiDocGia,
                                  DiaChiDG = b.DiaChiDG,
                                  TongNo = b.TongNo,
                                  Password=c.Pwd,
                                  UserName=c.UserName,
                              }).ToList<TheDocGiaDTO>();
                var listSearchEmail = (from a in Resultkq
                                       select new TheDocGiaDTO()
                                       {
                                           IDDocGia = a.IDDocGia,
                                           HoTenDG = a.HoTenDG,
                                           EmailDG = a.EmailDG,
                                           NgaySinhDG = a.NgaySinhDG,
                                           DiaChiDG = a.DiaChiDG,
                                           NgayLapThe = a.NgayLapThe,
                                           NgayHetHan = a.NgayHetHan,
                                           TenLoaiDocGia = HelperDAO.Instance.checkLoaiDocGiaFromID(a.IDLoaiDocGia),
                                           Password = a.Password,
                                           IDLoaiDocGia = a.IDLoaiDocGia,
                                           UserName = a.UserName,
                                           TongNo = a.TongNo,
                                       }).ToList<TheDocGiaDTO>();
                if (listSearchEmail.Count > 0)
                    return listSearchEmail;
                return new List<TheDocGiaDTO>();

            }
        }
        //getListSearch DiaChiDG from "THEDOCGIA"
        public List<TheDocGiaDTO> getFormTheDocGiaSearchDiaChiDG(string DiaChiDG)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var Result = (from a in db.THEDOCGIAs
                              where a.DiaChiDG.ToUpper().Contains(DiaChiDG.ToUpper())
                              select new TheDocGiaDtos()
                              {
                                  IDDocGia = a.IDDocGia,
                                  HoTenDG = a.HoTenDG,
                                  EmailDG = a.EmailDG,
                                  DiaChiDG = a.DiaChiDG,
                                  HetHan = a.NgayHetHan,
                                  NgayLapThe = a.NgayLapThe,
                                  NgaySinhDG = a.NgaySinhDG,
                                  IDLoaiDocGia=a.IDLoaiDG,
                                  TongNo = a.TongNo,
                              }).ToList<TheDocGiaDtos>();
                var Resultkq = (from b in Result
                                join c in db.USERS on b.IDDocGia equals c.IDDocGia
                                select new TheDocGiaDTO()
                                {
                                    IDDocGia=b.IDDocGia,
                                    HoTenDG = b.HoTenDG,
                                    EmailDG = b.EmailDG,
                                    NgaySinhDG = b.NgaySinhDG,
                                    NgayLapThe = b.NgayLapThe,
                                    NgayHetHan = b.HetHan,
                                    IDLoaiDocGia=b.IDLoaiDocGia,
                                    DiaChiDG = b.DiaChiDG,
                                    TongNo = b.TongNo,
                                    Password=c.Pwd,
                                    UserName=c.UserName,
                                }).ToList<TheDocGiaDTO>();
                var listSearchDiaChi = (from a in Resultkq
                                        select new TheDocGiaDTO()
                                        {
                                            IDDocGia = a.IDDocGia,
                                            HoTenDG = a.HoTenDG,
                                            EmailDG = a.EmailDG,
                                            NgaySinhDG = a.NgaySinhDG,
                                            DiaChiDG = a.DiaChiDG,
                                            NgayLapThe = a.NgayLapThe,
                                            NgayHetHan = a.NgayHetHan,
                                            TenLoaiDocGia = HelperDAO.Instance.checkLoaiDocGiaFromID(a.IDLoaiDocGia),
                                            Password = a.Password,
                                            IDLoaiDocGia = a.IDLoaiDocGia,
                                            UserName = a.UserName,
                                            TongNo = a.TongNo,
                                        }).ToList<TheDocGiaDTO>();
                if (listSearchDiaChi.Count > 0)
                    return listSearchDiaChi;
                return new List<TheDocGiaDTO>();
                
            }
        }
        ////getListSearch NgayLapThe from "THEDOCGIA"
        public List<TheDocGiaDTO> getFormTheDocGiaSearchNgayLapThe(DateTime Ngaylap)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var Result = (from a in db.THEDOCGIAs
                              where a.NgayLapThe.Equals(Ngaylap)
                              select new TheDocGiaDtos()
                              {
                                  IDDocGia = a.IDDocGia,
                                  HoTenDG = a.HoTenDG,
                                  EmailDG = a.EmailDG,
                                  DiaChiDG = a.DiaChiDG,
                                  HetHan = a.NgayHetHan,
                                  NgayLapThe = Ngaylap,
                                  IDLoaiDocGia=a.IDLoaiDG,
                                  NgaySinhDG = a.NgaySinhDG,
                                  TongNo = a.TongNo,
                              }).ToList<TheDocGiaDtos>();
                var Resultkq = (from b in Result
                                join c in db.USERS on b.IDDocGia equals c.IDDocGia
                                select new TheDocGiaDTO()
                                {
                                    IDDocGia=b.IDDocGia,
                                    HoTenDG = b.HoTenDG,
                                    EmailDG = b.EmailDG,
                                    NgaySinhDG = b.NgaySinhDG,
                                    NgayLapThe = b.NgayLapThe,
                                    NgayHetHan = b.HetHan,
                                    IDLoaiDocGia=b.IDLoaiDocGia,
                                    DiaChiDG = b.DiaChiDG,
                                    TongNo = b.TongNo,
                                    Password=c.Pwd,
                                    UserName=c.UserName,
                                }).ToList<TheDocGiaDTO>();
                var listSearchNgayLap = (from a in Resultkq
                                         select new TheDocGiaDTO()
                                         {
                                             IDDocGia = a.IDDocGia,
                                             HoTenDG = a.HoTenDG,
                                             EmailDG = a.EmailDG,
                                             NgaySinhDG = a.NgaySinhDG,
                                             DiaChiDG = a.DiaChiDG,
                                             NgayLapThe = a.NgayLapThe,
                                             NgayHetHan = a.NgayHetHan,
                                             TenLoaiDocGia = HelperDAO.Instance.checkLoaiDocGiaFromID(a.IDLoaiDocGia),
                                             Password = a.Password,
                                             IDLoaiDocGia = a.IDLoaiDocGia,
                                             UserName = a.UserName,
                                             TongNo = a.TongNo,
                                         }
                                       ).ToList<TheDocGiaDTO>();
                if (listSearchNgayLap.Count > 0)
                    return listSearchNgayLap;
                return new List<TheDocGiaDTO>();
               
            }
        }
        //getListSearch NgaySinhDG from "TheDocGia"
        public List<TheDocGiaDTO> getFormTheDocGiaSearchNgaySinhDG(DateTime NgaySinh)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var Result = (from a in db.THEDOCGIAs
                              where a.NgayLapThe.Equals(NgaySinh)
                              select new TheDocGiaDtos()
                              {
                                  IDDocGia = a.IDDocGia,
                                  HoTenDG = a.HoTenDG,
                                  EmailDG = a.EmailDG,
                                  DiaChiDG = a.DiaChiDG,
                                  HetHan = a.NgayHetHan,
                                  NgayLapThe = a.NgayLapThe,
                                  IDLoaiDocGia = a.IDLoaiDG,
                                  NgaySinhDG = NgaySinh,
                                  TongNo = a.TongNo,
                              }).ToList<TheDocGiaDtos>();
                var Resultkq = (from b in Result
                                join c in db.USERS on b.IDDocGia equals c.IDDocGia
                                select new TheDocGiaDTO()
                                {
                                    IDDocGia=b.IDDocGia,
                                    HoTenDG = b.HoTenDG,
                                    EmailDG = b.EmailDG,
                                    NgaySinhDG = b.NgaySinhDG,
                                    NgayLapThe = b.NgayLapThe,
                                    NgayHetHan = b.HetHan,
                                    IDLoaiDocGia=b.IDLoaiDocGia,
                                    DiaChiDG = b.DiaChiDG,
                                    TongNo = b.TongNo,
                                    Password=c.Pwd,
                                    UserName=c.UserName,
                                }).ToList<TheDocGiaDTO>();
                var listSearchNgaySinh = (from a in Resultkq
                                          select new TheDocGiaDTO()
                                          {
                                              IDDocGia = a.IDDocGia,
                                              HoTenDG = a.HoTenDG,
                                              EmailDG = a.EmailDG,
                                              NgaySinhDG = a.NgaySinhDG,
                                              DiaChiDG = a.DiaChiDG,
                                              NgayLapThe = a.NgayLapThe,
                                              NgayHetHan = a.NgayHetHan,
                                              TenLoaiDocGia = HelperDAO.Instance.checkLoaiDocGiaFromID(a.IDLoaiDocGia),
                                              Password = a.Password,
                                              IDLoaiDocGia = a.IDLoaiDocGia,
                                              UserName = a.UserName,
                                              TongNo = a.TongNo,
                                          }
                                        ).ToList<TheDocGiaDTO>();
                if (listSearchNgaySinh.Count > 0)
                    return listSearchNgaySinh;
                return new List<TheDocGiaDTO>();
            }
        }
        //get list Search UserName 
        public List<TheDocGiaDTO> getFormTheDocGiaSearchUserName(string Username)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var Result = (from a in db.THEDOCGIAs
                              join b in db.USERS on a.IDDocGia equals b.IDDocGia
                              where b.UserName.ToUpper().Contains(Username.ToUpper())
                              select new TheDocGiaDTO()
                              {
                                  IDDocGia = a.IDDocGia,
                                  HoTenDG = a.HoTenDG,
                                  EmailDG = a.EmailDG,
                                  DiaChiDG = a.DiaChiDG,
                                  NgayHetHan = a.NgayHetHan,
                                  NgayLapThe = a.NgayLapThe,
                                  IDLoaiDocGia = a.IDLoaiDG,
                                  NgaySinhDG = a.NgaySinhDG,
                                  TongNo = a.TongNo,
                                  Password = b.Pwd,
                                  UserName = b.UserName,

                              }).ToList<TheDocGiaDTO>();
                var Resultkq = (from b in Result
                                join c in db.USERS on b.IDDocGia equals c.IDDocGia
                                select new TheDocGiaDTO()
                                {
                                    IDDocGia = b.IDDocGia,
                                    HoTenDG = b.HoTenDG,
                                    EmailDG = b.EmailDG,
                                    NgaySinhDG = b.NgaySinhDG,
                                    NgayLapThe = b.NgayLapThe,
                                    NgayHetHan = b.NgayHetHan,
                                    IDLoaiDocGia = b.IDLoaiDocGia,
                                    DiaChiDG = b.DiaChiDG,
                                    TongNo = b.TongNo,
                                    Password = c.Pwd,
                                    UserName = c.UserName,
                                }).ToList<TheDocGiaDTO>();
                var listSearchUserName = (from a in Resultkq
                                          select new TheDocGiaDTO()
                                          {
                                              IDDocGia = a.IDDocGia,
                                              HoTenDG = a.HoTenDG,
                                              EmailDG = a.EmailDG,
                                              NgaySinhDG = a.NgaySinhDG,
                                              DiaChiDG = a.DiaChiDG,
                                              NgayLapThe = a.NgayLapThe,
                                              NgayHetHan = a.NgayHetHan,
                                              TenLoaiDocGia = HelperDAO.Instance.checkLoaiDocGiaFromID(a.IDLoaiDocGia),
                                              Password = a.Password,
                                              IDLoaiDocGia = a.IDLoaiDocGia,
                                              UserName = a.UserName,
                                              TongNo = a.TongNo,
                                          }
                                        ).ToList<TheDocGiaDTO>();
                if (listSearchUserName.Count > 0)
                    return listSearchUserName;
                return new List<TheDocGiaDTO>();
            }
        }
        #endregion 
    }
}
