using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.Model;
using Data.DTO;

namespace Data.DAO
{
    public class UserDAO
    {
        #region Instance
        private static UserDAO instance;

        public static UserDAO Instance
        {
            get
            {
                if (instance == null) instance = new UserDAO(); return DAO.UserDAO.instance;
            }

            private set
            {
                DAO.UserDAO.instance = value;
            }
        }
        #endregion
        #region Operator+
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from a in db.USERS select a.IDDocGia).Max()).ToString();
                int ID = Int32.Parse(query);
                int IDadd = ++ID;
                return IDadd;
            }
        }
        #endregion
        #region getListSearch UserDTO
        //getListSearch UserName From "User"
        public List<UserDTO> getFromUserSearchUserName(string Name)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.USERS
                              where a.UserName.ToUpper().Contains(Name.ToUpper())
                              select new UserDtos()
                              {
                                  UserName = a.UserName,
                                  Password = a.Pwd,
                                  IDDocGia = a.IDDocGia,
                              }).ToList<UserDtos>();
                var Resultkq = (from b in result
                                select new UserDTO()
                                {
                                    UserName = b.UserName,
                                    Password = b.Password,
                                    HoTenDocGia = GetDataDAO.Instance.getTenDocGiaToIDDocGia(b.IDDocGia),
                                }).ToList<UserDTO>();
                if(Resultkq.Count>0)
                    return Resultkq;
                return new List<UserDTO>();
            }
        }
        //getListSearch IDDocGia From "User"
        public List<UserDTO> getFromUserSearchIDDocGia(int ID)
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.USERS
                              where a.IDDocGia.Equals(ID)
                              select new UserDtos()
                              {
                                  UserName = a.UserName,
                                  Password = a.Pwd,
                                  IDDocGia = a.IDDocGia,
                              }).ToList<UserDtos>();
                var Resultkq = (from b in result
                                select new UserDTO()
                                {
                                    UserName = b.UserName,
                                    Password = b.Password,
                                    IDDocGia = b.IDDocGia,
                                    HoTenDocGia = GetDataDAO.Instance.getTenDocGiaToIDDocGia(b.IDDocGia),
                                }).ToList<UserDTO>();
                if (Resultkq.Count > 0)
                    return Resultkq;
                return new List<UserDTO>();
                    
            } 
        }
        #endregion
    }

}
