using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DTO;
using Data.BUS;
using Data.IBUS;
using Service.IService;


namespace Service.ABSTRACT
{
    public class UserService : IUserService
    {
        private IUserBUS _UserBus;
        public UserService()
        {
            this._UserBus = new UserBUS();
        }

        public List<UserDTO> getFromUserSearchIDDocGia(int ID)
        {
            return this._UserBus.getFromUserSearchIDDocGia(ID);
        }

        public List<UserDTO> getFromUserSearchUserName(string Name)
        {
            return this._UserBus.getFromUserSearchUserName(Name);
        }
    }
}
