using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
namespace Data.DAO
{
    public class CTUserAdminDAO
    {
        #region Instance
        private static CTUserAdminDAO instance;

        public static CTUserAdminDAO Instance
        {
            get
            {
                if (instance == null) instance = new CTUserAdminDAO(); return DAO.CTUserAdminDAO.instance;
            }

            private set
            {
                DAO.CTUserAdminDAO.instance = value;
            }
        }
        #endregion
        #region Operator+
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from a in db.CT_USERADMIN select a.IDAdmin).Max()).ToString();
                int ID = Int32.Parse(query);
                int IDadd = ++ID;
                return IDadd;
            }
        }
        #endregion
        #region getListSearch CTUSerAdminDtos
        //getList Search ID 
        public List<CTUserAdminDtos> getFormCTUserAdminSearchIDAdmin(int ID)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.CT_USERADMIN
                              where a.IDAdmin.Equals(ID)
                              select new CTUserAdminDtos()
                              {
                                  IDAdmin = a.IDAdmin,
                                  HoTenAdmin = a.HoTenAdmin,
                                  DiaChi = a.DiaChiAdmin,
                                  NgaySinh = a.NgaySinhAdmin,
                                  Email = a.EmailAdmin,
                              }).ToList<CTUserAdminDtos>();
                if (result.Count > 0)
                    return result;
                return new List<CTUserAdminDtos>();
            }
        }
        // get List Search HoTenAdmin 
        public List<CTUserAdminDtos> getFormCTUserAdminSearchHoTenAdmin(string HoTen)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.CT_USERADMIN
                              where a.HoTenAdmin.ToUpper().Contains(HoTen.ToUpper())
                              select new CTUserAdminDtos()
                              {
                                  IDAdmin = a.IDAdmin,
                                  HoTenAdmin = a.HoTenAdmin,
                                  DiaChi = a.DiaChiAdmin,
                                  NgaySinh = a.NgaySinhAdmin,
                                  Email = a.EmailAdmin,
                              }).ToList<CTUserAdminDtos>();
                if (result.Count > 0)
                    return result;
                return new List<CTUserAdminDtos>();
            }
        }
        //get List Search DiaChiAdmin
        public List<CTUserAdminDtos> getFormCTUserAdminSearchDiaChiAdmin(string DiaChi)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.CT_USERADMIN
                              where a.HoTenAdmin.ToUpper().Contains(DiaChi.ToUpper())
                              select new CTUserAdminDtos()
                              {
                                  IDAdmin = a.IDAdmin,
                                  HoTenAdmin = a.HoTenAdmin,
                                  DiaChi = a.DiaChiAdmin,
                                  NgaySinh = a.NgaySinhAdmin,
                                  Email = a.EmailAdmin,
                              }).ToList<CTUserAdminDtos>();
                if (result.Count > 0)
                    return result;
                return new List<CTUserAdminDtos>();
            }
        }
        //get List Search Emailadmin
        public List<CTUserAdminDtos> getFormCTUserAdminSearchEmailadmin(string Email)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.CT_USERADMIN
                              where a.HoTenAdmin.ToUpper().Contains(Email.ToUpper())
                              select new CTUserAdminDtos()
                              {
                                  IDAdmin = a.IDAdmin,
                                  HoTenAdmin = a.HoTenAdmin,
                                  DiaChi = a.DiaChiAdmin,
                                  NgaySinh = a.NgaySinhAdmin,
                                  Email = a.EmailAdmin,
                              }).ToList<CTUserAdminDtos>();
                if (result.Count > 0)
                    return result;
                return new List<CTUserAdminDtos>();
            }
        }
        //get List Search NgaySinhAdmin
        public List<CTUserAdminDtos> getFormCTUserAdminSearchNgaySinhAdmin(DateTime NgaySinh)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.CT_USERADMIN
                              where a.NgaySinhAdmin.Equals(NgaySinh)
                              select new CTUserAdminDtos()
                              {
                                  IDAdmin = a.IDAdmin,
                                  HoTenAdmin = a.HoTenAdmin,
                                  DiaChi = a.DiaChiAdmin,
                                  NgaySinh = a.NgaySinhAdmin,
                                  Email = a.EmailAdmin,
                              }).ToList<CTUserAdminDtos>();
                if (result.Count > 0)
                    return result;
                return new List<CTUserAdminDtos>();
            }
        }
        #endregion
    }
}
