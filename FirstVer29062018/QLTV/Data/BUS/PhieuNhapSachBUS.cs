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
    public class PhieuNhapSachBUS:IPhieuNhapSachBUS
    {
        #region add Form PhieuNhapSach
        public bool addFormPhieuNhapSach(PhieuNhapSachDtos phieuNhap)
        {
            try
            {
                using (var db = new QuanLyThuVienEntities())
                {
                    int ID = PhieuNhapSachDAO.Instance.IDPlus();
                    db.PHIEUNHAPSACHes.Add(new PHIEUNHAPSACH()
                    {
                        IDPhieuNhap = ID,
                        NgayNhap = phieuNhap.NgayNhap,
                        TongTien = 0,
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
    }
}
