using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.IService;
using Data.IBUS;
using Data.BUS;
using Data.Dtos;
using Data.DAO;
using Data.DTO;
namespace Service.ABSTRACT
{
    public class CTUserAdminService : ICTUserAdminService
    {
        private ICTUserAdminBUS _ICTUserAdmin;
        public CTUserAdminService()
        {
            this._ICTUserAdmin = new CTUserAdminBUS();
        }
        //add Form CTUserAdmin
        public void AddFormCTUserAdmin(CTUserAdminDtos CTUserAdmin)
        {
            this._ICTUserAdmin.AddFormCTUserAdmin(CTUserAdmin);
        }
        #region getList Search
        //getList Search DiaChi
        public List<CTUserAdminDtos> getFormCTUserAdminSearchDiaChiAdmin(string DiaChi)
        {
            return this._ICTUserAdmin.getFormCTUserAdminSearchDiaChiAdmin(DiaChi);
        }
        //getList Search Email
        public List<CTUserAdminDtos> getFormCTUserAdminSearchEmailadmin(string Email)
        {
            return this._ICTUserAdmin.getFormCTUserAdminSearchEmailadmin(Email);
        }
        //getList Search HoTen
        public List<CTUserAdminDtos> getFormCTUserAdminSearchHoTenAdmin(string HoTen)
        {
            return this._ICTUserAdmin.getFormCTUserAdminSearchHoTenAdmin(HoTen);
        }
        //getList Search ID 
        public List<CTUserAdminDtos> getFormCTUserAdminSearchIDAdmin(int ID)
        {
            return this._ICTUserAdmin.getFormCTUserAdminSearchIDAdmin(ID);
        }
        //getList Search NgaySinh
        public List<CTUserAdminDtos> getFormCTUserAdminSearchNgaySinhAdmin(DateTime NgaySinh)
        {
            return this._ICTUserAdmin.getFormCTUserAdminSearchNgaySinhAdmin(NgaySinh);
        }
        #endregion
    }
}
