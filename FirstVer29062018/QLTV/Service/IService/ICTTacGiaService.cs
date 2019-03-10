using Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IService
{
    public interface ICTTacGiaService
    {
        //add FormCTTacGia
        void addFormCTTacGia(CTTacGiaDtos tacGia);
        //edit Form CTTacGia
        void editFormCTTacGia(CTTacGiaDtos ctTacGia);
    }
}
