using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class TacGiaDAO
    {
        #region Instance
        private static TacGiaDAO instance;

        internal static TacGiaDAO Instance
        {
            get
            {
                if (instance == null) instance = new TacGiaDAO(); return DAO.TacGiaDAO.instance;
            }

            private set
            {
                DAO.TacGiaDAO.instance = value;
            }
        }
        #endregion
        #region Operator+
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from a in db.TACGIAs select a.IDTacGia).Max()).ToString();
                int ID = Int32.Parse(query);
                int IDadd = ++ID;
                return IDadd;
            }
        }
        #endregion
        #region getListSearch TacGiaDtos
        // getList Search IDTacGia From"TacGia"
        public List<TacGiaDtos> getFormTacGiaSearchIDTacGia(int ID)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.TACGIAs
                              where a.IDTacGia.Equals(ID)
                              select new TacGiaDtos()
                              {
                                  IDTacGia = a.IDTacGia,
                                  TenTacGia = a.TenTacGia,
                                  NgaySinh = a.NgaySinh,
                              }).ToList<TacGiaDtos>();
                if (result.Count > 0)
                    return result;
                return new List<TacGiaDtos>();
            }
        }
        //getList Search TenTacGia From "TacGia"
        public List<TacGiaDtos> getFormTacGiaSearchTenTacGia(string TenTacGia)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.TACGIAs
                              where a.TenTacGia.ToUpper().Contains(TenTacGia.ToUpper())
                              select new TacGiaDtos()
                              {
                                  IDTacGia = a.IDTacGia,
                                  TenTacGia = a.TenTacGia,
                                  NgaySinh = a.NgaySinh,
                              }).ToList<TacGiaDtos>();
                var listSearchTenTG = (from b in result
                                       select new TacGiaDtos()
                                       {
                                           IDTacGia = b.IDTacGia,
                                           TenTacGia = b.TenTacGia,
                                           NgaySinh = b.NgaySinh
                                       }).ToList<TacGiaDtos>();
                if (listSearchTenTG.Count > 0)
                    return listSearchTenTG;
                return new List<TacGiaDtos>();

            }
        }
        //getList Search NgaySinhTacGia From "TacGia"
        public List<TacGiaDtos> getFormTacGiaSearchNgaySinhTG(DateTime NgaySinh)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.TACGIAs
                              where a.NgaySinh.Equals(NgaySinh)
                              select new TacGiaDtos()
                              {
                                  IDTacGia = a.IDTacGia,
                                  TenTacGia = a.TenTacGia,
                                  NgaySinh = a.NgaySinh,
                              }).ToList<TacGiaDtos>();
                var listSearchNgaySinhTG = (from b in result
                                       select new TacGiaDtos()
                                       {
                                           IDTacGia = b.IDTacGia,
                                           TenTacGia = b.TenTacGia,
                                           NgaySinh = b.NgaySinh
                                       }).ToList<TacGiaDtos>();
                if (listSearchNgaySinhTG.Count > 0)
                    return listSearchNgaySinhTG;
                return new List<TacGiaDtos>();

            }
        }
        #endregion
        #region getAllForm TacGia
        public List<TacGiaDtos> getAllFormTacGia()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var getAll = (from a in db.TACGIAs
                                        select new TacGiaDtos()
                                        {
                                            IDTacGia = a.IDTacGia,
                                            TenTacGia = a.TenTacGia,
                                            NgaySinh = a.NgaySinh,
                                        }).ToList<TacGiaDtos>();
                var getALLFormTacGia=(from a in getAll
                                      select new TacGiaDtos()
                                      {
                                          IDTacGia = a.IDTacGia,
                                          TenTacGia = a.TenTacGia,
                                          NgaySinh = a.NgaySinh,
                                      }
                                      ).ToList<TacGiaDtos>();
                if (getALLFormTacGia.Count > 0)
                    return getALLFormTacGia;
                return new List<TacGiaDtos>();
            }
        }
        #endregion
    }
}
