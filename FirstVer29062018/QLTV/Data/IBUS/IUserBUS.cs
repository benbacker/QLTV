using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.BUS;
using Data.DTO;

namespace Data.IBUS
{
    public interface IUserBUS
    {
        //getListSearch UserName From "User"
        List<UserDTO> getFromUserSearchUserName(string Name);
        //getListSearch IDDocGia From "User"
        List<UserDTO> getFromUserSearchIDDocGia(int IDDG);
    }
}
