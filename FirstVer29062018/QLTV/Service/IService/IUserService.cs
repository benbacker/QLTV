using Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface IUserService
    {
        //getListSearch IDDocGia From "User"
        List<UserDTO> getFromUserSearchIDDocGia(int ID);
        //getListSearch UserName From "User"
        List<UserDTO> getFromUserSearchUserName(string Name);
    }
}
