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
    public class LoaiSachBUS : ILoaiSachBUS
    {
        //Add From "LoaiSach"
        public bool AddFromLoaiSach(LoaiSachDtos LS)
        {
            try
            {
                using (var db = new QuanLyThuVienEntities())
                {
                    int ID = LoaiSachDAO.Instance.IDPlus();
                    db.LOAISACHes.Add(new LOAISACH()
                    {
                        IDLoaiSach = ID,
                        TenLoaiSach = LS.TenLoaiSach,
                    });
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }
        #region getListData IDLoaiSach from "LoaiSach"
        public List<LoaiSachDtos> getFromLoaiSach(int ID)
        {
            try
            {
                List<LoaiSachDtos> LoaiSachDtos = new List<LoaiSachDtos>();
                LoaiSachDtos = LoaiSachDAO.Instance.getFromLoaiSach(ID);
                return LoaiSachDtos;

            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
        #region getListSearch TenLoaiSach From "LoaiSach"
        public List<LoaiSachDtos> getFromLoaiSachSearchTenLoaiSach(string TenLoaiSach)
        {
            try
            {
                List<LoaiSachDtos> LoaiSachDtos = new List<LoaiSachDtos>();
                LoaiSachDtos = LoaiSachDAO.Instance.getFromLoaiSachSearchTenLoaiSach(TenLoaiSach);
                return LoaiSachDtos;

            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
