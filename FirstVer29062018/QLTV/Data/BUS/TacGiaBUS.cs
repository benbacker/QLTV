using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Data.Model;
using Data.DAO;
using Data.Dtos;
using System.IO;

namespace Data.BUS
{
    public class TacGiaBUS : ITacGiaBUS
    {
        #region  Add Form "TacGia"
        public bool AddFormTacGia(TacGiaDtos tacGia)
        {
            try
            {
                using (var db= new QuanLyThuVienEntities())
                {
                    int ID = TacGiaDAO.Instance.IDPlus();
                    db.TACGIAs.Add(new TACGIA()
                    {
                        IDTacGia = ID,
                        TenTacGia = tacGia.TenTacGia,
                        NgaySinh = tacGia.NgaySinh,
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
        #region Edit Form "TacGia"
        public bool editFormTacGia(TacGiaDtos tacgia)
        {
            try
            {
                using (var db = new QuanLyThuVienEntities())
                {
                    var EditTacGia = (from a in db.TACGIAs
                                      where a.IDTacGia.Equals(tacgia.IDTacGia)
                                      select a).FirstOrDefault();
                    if (EditTacGia == null) return false;
                    EditTacGia.TenTacGia = tacgia.TenTacGia;
                    EditTacGia.NgaySinh = tacgia.NgaySinh;
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
        #region getList Search TacGiaDtos
        //get All form TacGIa
        public List<TacGiaDtos> getAllFormTacGia()
        {
            try
            {
                List<TacGiaDtos> ListTacGia = new List<TacGiaDtos>();
                ListTacGia = TacGiaDAO.Instance.getAllFormTacGia();
                return ListTacGia;
            }
            catch (Exception)
            {

                throw;
            }
        }
        // getList Search IDTacGia From"TacGia"
        public List<TacGiaDtos> getFormTacGiaSearchIDTacGia(int ID)
        {
            try
            {
                List<TacGiaDtos> ListTacGia = new List<TacGiaDtos>();
                ListTacGia = TacGiaDAO.Instance.getFormTacGiaSearchIDTacGia(ID);
                return ListTacGia;
            }
            catch (Exception)
            {

                throw;
            }
        }
        //getList Search TenTacGia From "TacGia"
        public List<TacGiaDtos> getFormTacGiaSearchTenTacGia(string TenTG)
        {
            try
            {
                List<TacGiaDtos> ListTacGia = new List<TacGiaDtos>();
                ListTacGia = TacGiaDAO.Instance.getFormTacGiaSearchTenTacGia(TenTG);
                return ListTacGia;

            }
            catch (Exception)
            {

                throw;
            }
        }
        //getList Search NgaySinhTacGia From "TacGia"
        public List<TacGiaDtos> getFormTacGiaSearchNgaySinhTG(DateTime NgaySinh)
        {
            try
            {
                List<TacGiaDtos> ListTacGia = new List<TacGiaDtos>();
                ListTacGia = TacGiaDAO.Instance.getFormTacGiaSearchNgaySinhTG(NgaySinh);
                return ListTacGia;
            }
            catch (Exception)
            {

                throw;
            }
        }


        #endregion
        #region Xuat file excel
        public bool ExportToCsvFile(List<TacGiaDtos> tacgia, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create), Encoding.UTF8))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("STT,Tên tác giả,Ngày sinh");
                foreach (var p in tacgia)
                {
                    sb.AppendLine(string.Format("{0},{1},{2}", p.IDTacGia,p.TenTacGia,p.NgaySinh.ToString("dd-MM-yyyy")));
                }

                sw.Write(sb.ToString());
                return true;
            }
        }
        #endregion
    }
}
