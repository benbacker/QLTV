using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desktop.DTO;
using System.Data;

namespace Desktop.DAO
{
    public class TheDocGiaDAO
    {
        #region QueryTheDocGia
        #region LoadTheDocGia
        public string QueryLoadTDG()
        {
            string Query = "select TheDocGia.*,Users.UserName,LoaiDocGia.TenLoaiDG From TheDocGia,Users,LoaiDocGia where TheDocGia.IDDocGia = Users.IDDocGia and LoaiDocGia.IDLoaiDG = TheDocGia.IDLoaiDG order by IDDocGia asc";
            return Query;
        }
        #endregion
        #region Search
        public string QuerySearchTDG(string SearchTT, string NhapTT)
        {
            string Query = "select TheDocGia.*,Users.UserName,LoaiDocGia.TenLoaiDG From TheDocGia,Users,LoaiDocGia where TheDocGia.IDDocGia = Users.IDDocGia and LoaiDocGia.IDLoaiDG = TheDocGia.IDLoaiDG and " + SearchTT + " like N'%" + NhapTT + "%' order by IDDocGia asc";
            return Query;
        }
        #endregion
        #region Insert
        public string QueryInsertTDG(TheDocGiaDTO TDG)
        {
            TDG.IDDocGia = ConnectionSQL.Identity(TDG.IDDocGia);
            string Query = "INSERT INTO THEDOCGIA VALUES ('" + TDG.IDDocGia + "',N'" + TDG.HoTenDG + "', '" + TDG.NgaySinhDG + "', N'" + TDG.DiaChiDG + "', '" + TDG.EmailDG + "', '" + TDG.IDLoaiDG + "', '" + TDG.NgayLapThe + "', '" + TDG.NgayHetHan + "','" + TDG.TongNo + "')";
            return Query;
        }

        public string QueryInsertUser(UserDTO User)
        {
            TheDocGiaDTO TDG = new TheDocGiaDTO();
            TDG.IDDocGia = ConnectionSQL.Identity(TDG.IDDocGia) - 1;
            User.IDDocGia = TDG.IDDocGia;
            string Query = "insert into Users values ('" + User.UserName + "','" + User.Password + "','" + User.IDDocGia + "')";
            return Query;
        }
        #endregion
        #region Update
        public string QueryUpdateTDG(TheDocGiaDTO TDG)
        {
            string Query = "UPDATE THEDOCGIA SET HoTenDG = N'" + TDG.HoTenDG + "', NgaySinhDG = '" + TDG.NgaySinhDG + "', DiaChiDG = N'" + TDG.DiaChiDG + "', EmailDG = '" + TDG.EmailDG + "', IDLoaiDG = '" + TDG.IDLoaiDG + "', NgayLapThe = '" + TDG.NgayLapThe + "', NgayHetHan = '" + TDG.NgayHetHan + "' WHERE IDDocGia = '" + TDG.IDDocGia + "'";
            return Query;
        }

        public string QueryUpdateUser(UserDTO user)
        {
            string Query = "UPDATE USERS SET UserName = '" + user.UserName + "' WHERE IDDocGia = '" + user.IDDocGia + "'";
            return Query;
        }
        #endregion
        #region DeleteTheDocGia
        public string QueryDeleteTDG(int IDTDG)
        {
            string Query = "DELETE THEDOCGIA WHERE IDDocGia = "+ IDTDG + "";
            return Query;
        }

        public string QueryDeleteUser(int IDuser)
        {
            string Query = "DELETE USERS WHERE IDDocGia = " + IDuser + "";
            return Query;
        }

        public string QueryDeletePhieuThu(int IDPThu)
        {
            string Query = "DELETE PHIEUTHUTIENPHAT WHERE IDDocGia = " + IDPThu + "";
            return Query;
        }

        public string QueryCheckTDGinPM(int IDTDG)
        {
            string Query = "select IDDocGia from THEDOCGIA where EXISTS (select IDDocGia from PHIEUMUON where PHIEUMUON.IDDocGia = THEDOCGIA.IDDocGia) and IDDocGia = "+ IDTDG +"";
            return Query;
        }
        #endregion
        #endregion
        #region QueryThamSo
        public string GetStringMax()
        {
            string Query = "select TuoiMax from ThamSo";
            return Query;
        }

        public string GetStringMin()
        {
            string Query = "select TuoiMin from ThamSo";
            return Query;
        }
        #endregion
    }
}
