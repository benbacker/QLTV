using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Data.Model;
using Data.DAO;
using Data.Dtos;

namespace Data.BUS
{
    public class CTUserAdminBUS : ICTUserAdminBUS
    {
        //Add Form CTUSerAdmin      
        public bool AddFormCTUserAdmin(CTUserAdminDtos CTUserAdmin)
        {
            try
            {
                using (var db = new QuanLyThuVienEntities())
                {
                    int ID = CTUserAdminDAO.Instance.IDPlus();
                    db.CT_USERADMIN.Add(new CT_USERADMIN()
                    {
                        IDAdmin = ID,
                        HoTenAdmin = CTUserAdmin.HoTenAdmin,
                        DiaChiAdmin = CTUserAdmin.DiaChi,
                        EmailAdmin = CTUserAdmin.Email,
                        NgaySinhAdmin = CTUserAdmin.NgaySinh,
                    });
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #region getListSearch CTUSerAdminDtos
        //getList Search ID 
        public List<CTUserAdminDtos> getFormCTUserAdminSearchIDAdmin(int ID)
        {
            try
            {
                List<CTUserAdminDtos> ListCTUSerAdmin = new List<CTUserAdminDtos>();
                ListCTUSerAdmin = CTUserAdminDAO.Instance.getFormCTUserAdminSearchIDAdmin(ID);
                return ListCTUSerAdmin;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //get List Search HoTen
        public List<CTUserAdminDtos> getFormCTUserAdminSearchHoTenAdmin(string HoTen)
        {
            try
            {
                List<CTUserAdminDtos> ListCTUSerAdmin = new List<CTUserAdminDtos>();
                ListCTUSerAdmin = CTUserAdminDAO.Instance.getFormCTUserAdminSearchHoTenAdmin(HoTen);
                return ListCTUSerAdmin;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //get List Search DiaChi
        public List<CTUserAdminDtos> getFormCTUserAdminSearchDiaChiAdmin(string DiaChi)
        {
            try
            {
                List<CTUserAdminDtos> ListCTUSerAdmin = new List<CTUserAdminDtos>();
                ListCTUSerAdmin = CTUserAdminDAO.Instance.getFormCTUserAdminSearchDiaChiAdmin(DiaChi);
                return ListCTUSerAdmin;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //get List Search Email
        public List<CTUserAdminDtos> getFormCTUserAdminSearchEmailadmin(string Email)
        {
            try
            {
                List<CTUserAdminDtos> ListCTUSerAdmin = new List<CTUserAdminDtos>();
                ListCTUSerAdmin = CTUserAdminDAO.Instance.getFormCTUserAdminSearchEmailadmin(Email);
                return ListCTUSerAdmin;

            }
            catch (Exception)
            {

                throw;
            }
        }
        //get List Search NgaySinh
        public List<CTUserAdminDtos> getFormCTUserAdminSearchNgaySinhAdmin(DateTime NgaySinh)
        {
            try
            {
                List<CTUserAdminDtos> ListCTUSerAdmin = new List<CTUserAdminDtos>();
                ListCTUSerAdmin = CTUserAdminDAO.Instance.getFormCTUserAdminSearchNgaySinhAdmin(NgaySinh);
                return ListCTUSerAdmin;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
