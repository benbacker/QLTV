using Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface ICTUserAdminService
    {
        //Add Form CTUserAdmin
        void AddFormCTUserAdmin(CTUserAdminDtos CTUserAdmin);
        #region getListSearch CTUSerAdminDtos
        //getList Search ID 
        List<CTUserAdminDtos> getFormCTUserAdminSearchIDAdmin(int ID);
        // get List Search HoTenAdmin 
        List<CTUserAdminDtos> getFormCTUserAdminSearchHoTenAdmin(string HoTen);
        //get List Search DiaChiAdmin
        List<CTUserAdminDtos> getFormCTUserAdminSearchDiaChiAdmin(string DiaChi);
        //get List Search Emailadmin
        List<CTUserAdminDtos> getFormCTUserAdminSearchEmailadmin(string Email);
        //get List Search NgaySinhAdmin
        List<CTUserAdminDtos> getFormCTUserAdminSearchNgaySinhAdmin(DateTime NgaySinh);
        #endregion

    }
}
