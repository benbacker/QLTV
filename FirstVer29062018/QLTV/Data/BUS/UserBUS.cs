using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.IBUS;
using Data.Model;
using Data.DAO;
using Data.DTO;

namespace Data.BUS
{
    public class UserBUS : IUserBUS
    {

        #region getListSearch UserDTO
        //getListSearch UserName From "User"
        public List<UserDTO> getFromUserSearchUserName(string Name)
        {
            try
            {
                List<UserDTO> listUserDTO = new List<UserDTO>();
                listUserDTO = UserDAO.Instance.getFromUserSearchUserName(Name);
                return listUserDTO;

            }
            catch (Exception)
            {

                throw;
            }
        }
        // getListSearch IDDocGia From "User"
        public List<UserDTO> getFromUserSearchIDDocGia(int IDDG)
        {
            try
            {
                List<UserDTO> listUserDTO = new List<UserDTO>();
                listUserDTO = UserDAO.Instance.getFromUserSearchIDDocGia(IDDG);
                return listUserDTO;

            }
            catch (Exception)
            {

                throw;
            }

        }
        #endregion
    }
}
