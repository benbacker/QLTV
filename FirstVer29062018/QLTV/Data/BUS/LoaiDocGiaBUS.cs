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
    public class LoaiDocGiaBUS : ILoaiDocGiaBUS
    {
        #region  Add From LoaiDocGia
        public bool ADDLoaiDocGia(LoaiDocGiaDtos LoaiDG)
        {
            try
            {
                using (var db = new QuanLyThuVienEntities())
                {
                    int ID = LoaiDocGiaDAO.Instance.IDPlus();
                    db.LOAIDOCGIAs.Add(new LOAIDOCGIA()
                    {
                        IDLoaiDG = ID,
                        TenLoaiDG = LoaiDG.TenLoaiDG,
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
        #endregion
        #region getListSearch LoaiDocGiaDtos
        //get List Search IDLoaiDG
        public List<LoaiDocGiaDtos> getFormLoaiDocGiaSearchIDLoaiDG(int ID)
        {
            try
            {
                List<LoaiDocGiaDtos> ListLoaiDG = new List<LoaiDocGiaDtos>();
                ListLoaiDG = LoaiDocGiaDAO.Instance.getFormLoaiDocGiaSearchIDLoaiDG(ID);
                return ListLoaiDG;

            }
            catch (Exception)
            {

                throw;
            }
        }
        //get List Search TenLoaiDG
        public List<LoaiDocGiaDtos> getFormLoaiDocGiaSearchTenLoaiDG(string TenLoaiDG)
        {
            try
            {
                List<LoaiDocGiaDtos> ListLoaiDG = new List<LoaiDocGiaDtos>();
                ListLoaiDG = LoaiDocGiaDAO.Instance.getFormLoaiDocGiaSearchTenLoaiDG(TenLoaiDG);
                return ListLoaiDG;

            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
