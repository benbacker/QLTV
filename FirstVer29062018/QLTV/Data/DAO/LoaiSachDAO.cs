using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class LoaiSachDAO
    {
        #region Instance
        private static LoaiSachDAO instance;

        public static LoaiSachDAO Instance
        {
            get
            {
                if (instance == null) instance = new LoaiSachDAO(); return DAO.LoaiSachDAO.instance;
            }

            private set
            {
                DAO.LoaiSachDAO.instance = value;
            }
        }
        #endregion
        #region Operator+
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from a in db.LOAISACHes select a.IDLoaiSach).Max()).ToString();
                int ID = Int32.Parse(query);
                int IDadd = ++ID;
                return IDadd;
            }
        }
        #endregion
        #region getListData LoaiSachDtos
        //getListData IDLoaiSach From"LoaiSach"
        public List<LoaiSachDtos> getFromLoaiSach(int ID)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.LOAISACHes
                              where a.IDLoaiSach.Equals(ID)
                              select new LoaiSachDtos()
                              {
                                  IDLoaiSach = a.IDLoaiSach,
                                  TenLoaiSach = a.TenLoaiSach,
                              }).ToList<LoaiSachDtos>();
                var Resultkq = (from a in result
                                select new LoaiSachDtos()
                                {
                                    IDLoaiSach = a.IDLoaiSach,
                                    TenLoaiSach = a.TenLoaiSach,
                                }).ToList<LoaiSachDtos>();
                if (Resultkq.Count > 0)
                    return Resultkq;
                return new List<LoaiSachDtos>();
            }
        }
        #endregion
        #region getListSearch LoaiSachDtos
        //getListSearch TenLoaiSach From "LoaiSach"
        public List<LoaiSachDtos> getFromLoaiSachSearchTenLoaiSach(string TenLoaiSach)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.LOAISACHes
                              where a.TenLoaiSach.ToUpper().Contains(TenLoaiSach.ToUpper())
                              select new LoaiSachDtos()
                              {
                                  TenLoaiSach = a.TenLoaiSach,
                                  IDLoaiSach = a.IDLoaiSach,
                              }).ToList<LoaiSachDtos>();
                var listSearchTenloaiSach = (from a in result
                                             select new LoaiSachDtos()
                                             {
                                                 TenLoaiSach = a.TenLoaiSach,
                                                 IDLoaiSach = a.IDLoaiSach,
                                             }).ToList<LoaiSachDtos>();
                if (listSearchTenloaiSach.Count > 0)
                    return listSearchTenloaiSach;
                return new List<LoaiSachDtos>();
            }
        }
        #endregion
    }
}
