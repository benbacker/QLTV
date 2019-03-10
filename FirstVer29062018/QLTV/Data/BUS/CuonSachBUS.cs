using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Data.Model;
using Data.DAO;
using Data.Dtos;
using Data.DTO;
namespace Data.BUS
{
    public class CuonSachBUS:ICuonSachBUS
    {
        #region add Form CuonSach
        //public bool addFormCuonSach(CuonSachDtos cuonSach)
        //{
        //    try
        //    {
        //        using (var db= new QuanLyThuVienEntities())
        //        {
        //            var ListIDSach = (from a in db.SACHes
        //                              select a.IDSach).ToList();
        //            foreach (int item in ListIDSach)
        //            {
        //                int ID = CuonSachDAO.Instance.IDPlus();
        //                db.CUONSACHes.Add(new CUONSACH()
        //                {
        //                    IDCuonSach = ID,
        //                    IDSach = item,
        //                    TinhTrang = "Chưa cho mượn",
        //                });
        //            }
        //            db.SaveChanges();
        //            return true;
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        return false;
        //    }
        //}
       
        #endregion
    }
}
