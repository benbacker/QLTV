using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Data.Dtos;
using Data.DTO;
using Data.Model;
using Data.DAO;
using System.IO;

namespace Data.BUS
{
    public class TheDocGiaBUS:ITheDocGiaBUS
    {
        #region Add From "THeDocGia" and From "User"
        public bool AddTheDocGiaAndUser(TheDocGiaDtos DocGia,UserDtos user)
        {
            try
            {
                using (var db = new QuanLyThuVienEntities())
                {
                    int ID = TheDocGiaDAO.Instance.IDPlus();
                    db.THEDOCGIAs.Add(new THEDOCGIA()
                    {
                        IDDocGia = ID,
                        HoTenDG = DocGia.HoTenDG,
                        DiaChiDG = DocGia.DiaChiDG,
                        EmailDG = DocGia.EmailDG,
                        NgaySinhDG = DocGia.NgaySinhDG,
                        NgayLapThe = DocGia.NgayLapThe,
                        IDLoaiDG = DocGia.IDLoaiDocGia,
                        TongNo = 0,
                        NgayHetHan = TheDocGiaDAO.Instance.countHanThe(DocGia.NgayLapThe),
                    });
                    db.USERS.Add(new USER()
                    {
                        IDDocGia = ID,
                        UserName = user.UserName,
                        Pwd = user.Password,
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
        #region Edit Form "DocGia" And "User"
        public bool editFormDocGiaAndUser(TheDocGiaDTO thedocgia)
        {
            try
            {
                using (var db= new QuanLyThuVienEntities())
                {
                    var Edit = (from a in db.THEDOCGIAs
                                where a.IDDocGia.Equals(thedocgia.IDDocGia)
                                select a).FirstOrDefault();
                    if (Edit == null) return false;
                    Edit.HoTenDG = thedocgia.HoTenDG;
                    Edit.DiaChiDG = thedocgia.DiaChiDG;
                    Edit.EmailDG = thedocgia.EmailDG;
                    Edit.NgaySinhDG = thedocgia.NgaySinhDG;
                    Edit.NgayLapThe = thedocgia.NgayLapThe;
                    Edit.IDLoaiDG = thedocgia.IDLoaiDocGia;
                    Edit.NgayHetHan = thedocgia.NgayHetHan;
                    Edit.TongNo = thedocgia.TongNo;
                    db.SaveChanges();
                    var EditUser = (from a in db.USERS
                                    where a.IDDocGia.Equals(thedocgia.IDDocGia)
                                    select a).FirstOrDefault();
                    if (EditUser == null) return false;
                    EditUser.Pwd = thedocgia.Password;
                    EditUser.UserName = thedocgia.UserName;
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
        #region getList All "DocGia" and "User"
        public List<TheDocGiaDTO> getAllDocGiaAndUser()
        {
            List<TheDocGiaDTO> listTheDocGiaDTO = new List<TheDocGiaDTO>();
            listTheDocGiaDTO = TheDocGiaDAO.Instance.getAllDocGiaAndUser();
            return listTheDocGiaDTO;
        }
        #endregion
        #region getListSearch From "TheDocGia"
        //getList Search DiaChiDG
        public List<TheDocGiaDTO> getFormTheDocGiaSearchDiaChiDG(string DiaChiDG)
        {
            try
            {
                List<TheDocGiaDTO> listTheDocGiaDTO = new List<TheDocGiaDTO>();
                listTheDocGiaDTO = TheDocGiaDAO.Instance.getFormTheDocGiaSearchDiaChiDG(DiaChiDG);
                return listTheDocGiaDTO;

            }
            catch (Exception)
            {

                throw;
            }
        }
        // getListSearch HoTenDG From "TheDocGia"
        public List<TheDocGiaDTO> getFromTheDocGiaSearchHoTen(string TenDG)
        {
            try
            {

                List<TheDocGiaDTO> listTheDocGiaDTO = new List<TheDocGiaDTO>();
                listTheDocGiaDTO = TheDocGiaDAO.Instance.getFromTheDocGiaSearchHoTenDG(TenDG);
                return listTheDocGiaDTO;
            }
            catch (Exception)
            {

                throw;
            }
        }
        // getListSearch EmailDG From "TheDocGia"
        public List<TheDocGiaDTO> getFormTheDocGiaSearchEmailDG(string EmailDG)
        {
            try
            {
                List<TheDocGiaDTO> listTheDocGiaDTO = new List<TheDocGiaDTO>();
                listTheDocGiaDTO = TheDocGiaDAO.Instance.getFormTheDocGiaSearchEmailDG(EmailDG);
                return listTheDocGiaDTO;

            }
            catch (Exception)
            {

                throw;
            }
        }
        // getListSearch NgayLap From "TheDocGia"
        public List<TheDocGiaDTO> getFormTheDocGiaSearchNgayLapThe(DateTime Ngaylap)
        {
            try
            {
                List<TheDocGiaDTO> listTheDocGiaDTO = new List<TheDocGiaDTO>();
                listTheDocGiaDTO = TheDocGiaDAO.Instance.getFormTheDocGiaSearchNgayLapThe(Ngaylap);
                return listTheDocGiaDTO;

            }
            catch (Exception)
            {

                throw;
            }
        }
        // getListSearch NgaySinh From "TheDocGia"
        public List<TheDocGiaDTO> getFormTheDocGiaSearchNgaySinhDG(DateTime NgaySinh)
        {
            try
            {
                List<TheDocGiaDTO> listTheDocGiaDTO = new List<TheDocGiaDTO>();
                listTheDocGiaDTO = TheDocGiaDAO.Instance.getFormTheDocGiaSearchNgaySinhDG(NgaySinh);
                return listTheDocGiaDTO;

            }
            catch (Exception)
            {

                throw;
            }
        }
        //get list Search UserName 
        public List<TheDocGiaDTO> getFormTheDocGiaSearchUserName(string Username)
        {
            try
            {
                List<TheDocGiaDTO> listTheDocGiaDTO = new List<TheDocGiaDTO>();
                listTheDocGiaDTO = TheDocGiaDAO.Instance.getFormTheDocGiaSearchUserName(Username);
                return listTheDocGiaDTO;
            }
            catch (Exception)
            {

                throw;
            };
        }
        #endregion
        #region Xuat file excel
        public bool ExportToCsvFile(List<TheDocGiaDTO> TheDocGia, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create), Encoding.UTF8))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("STT,Họ và tên,Tài khoản,Địa chỉ,Email,Ngày sinh,Ngày lập thẻ,Ngày hết hạn,Tên loại độc giả");
                foreach (var p in TheDocGia)
                {
                    sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", p.IDDocGia, p.HoTenDG, p.UserName, p.DiaChiDG, p.EmailDG, p.NgaySinhDG, p.NgayLapThe.ToString("dd-MM-yyyy"), p.NgayHetHan.ToString("dd-MM-yyyy"), p.TenLoaiDocGia));
                }

                sw.Write(sb.ToString());
                return true;
            }
        }
        #endregion

    }
    }
