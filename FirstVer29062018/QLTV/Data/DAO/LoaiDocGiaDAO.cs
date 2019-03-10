using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class LoaiDocGiaDAO
    {
        #region Instance
        private static LoaiDocGiaDAO instance;

        public static LoaiDocGiaDAO Instance
        {
            get
            {
                if (instance == null) instance = new LoaiDocGiaDAO(); return DAO.LoaiDocGiaDAO.instance;
            }
            private set
            {
                DAO.LoaiDocGiaDAO.instance = value;
            }
        }
        #endregion
        #region Operator+
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from a in db.LOAIDOCGIAs select a.IDLoaiDG).Max()).ToString();
                int ID = Int32.Parse(query);
                int IDadd = ++ID;
                return IDadd;
            }
        }
        #endregion
        #region getListSearch LoaiDocGiaDtos
        //getList Search IDLoaiDG From "LoaiDocGia"
        public List<LoaiDocGiaDtos> getFormLoaiDocGiaSearchIDLoaiDG(int ID)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.LOAIDOCGIAs
                              where a.IDLoaiDG.Equals(ID)
                              select new LoaiDocGiaDtos()
                              {
                                  IDLoaiDG = a.IDLoaiDG,
                                  TenLoaiDG = a.TenLoaiDG,
                              }).ToList<LoaiDocGiaDtos>();
                var listSearchIDLoaiDG = (from a in result
                                          select new LoaiDocGiaDtos()
                                          {
                                              IDLoaiDG = a.IDLoaiDG,
                                              TenLoaiDG = a.TenLoaiDG,
                                          }).ToList<LoaiDocGiaDtos>();
                if (listSearchIDLoaiDG.Count > 0)
                    return listSearchIDLoaiDG;
                return new List<LoaiDocGiaDtos>();
            }
        }
        // getList Search TenLoaiDG From "LoaiDocGia"
        public List<LoaiDocGiaDtos> getFormLoaiDocGiaSearchTenLoaiDG(string TenLoaiDG)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.LOAIDOCGIAs
                              where a.TenLoaiDG.ToUpper().Contains(TenLoaiDG.ToUpper())
                              select new LoaiDocGiaDtos()
                              {
                                  IDLoaiDG = a.IDLoaiDG,
                                  TenLoaiDG = a.TenLoaiDG,
                              }).ToList<LoaiDocGiaDtos>();
                var listSearchTenLoaiDG = (from a in result
                                          select new LoaiDocGiaDtos()
                                          {
                                              IDLoaiDG = a.IDLoaiDG,
                                              TenLoaiDG = a.TenLoaiDG,
                                          }).ToList<LoaiDocGiaDtos>();
                if (listSearchTenLoaiDG.Count > 0)
                    return listSearchTenLoaiDG;
                return new List<LoaiDocGiaDtos>();
            }
        }
        #endregion
    }
}