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
        //private static TheDocGiaDAO instance;
        //public static TheDocGiaDAO Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //            instance = new TheDocGiaDAO();
        //        return instance;
        //    }
        //}
        //private TheDocGiaDAO() { }
        //public List<TheDocGiaDTO> Xem()
        //{
        //    List<TheDocGiaDTO> TheDocGia = new List<TheDocGiaDTO>();
        //    string query = "SELECT TheDocGia.IDDocGia,HoTenDG,DiaChiDG,EmailDG,UserName,NgaySinhDG,NgayLapThe,NgayHetHan,TenLoaiDG,TongNo from THEDOCGIA,LOAIDOCGIA,USERS where THEDOCGIA.IDLoaiDG = LOAIDOCGIA.IDLoaiDG and THEDOCGIA.IDDocGia=USERS.IDDocGia";
        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);
        //    foreach (DataRow item in data.Rows)
        //    {
        //        int IDDocGia = (int)item["IDDocGia"];
        //        string HoTenDG = item["HoTenDG"].ToString();
        //        string DiaChiDG = item["DiaChiDG"].ToString();
        //        string EmailDG = item["EmailDG"].ToString();
        //        string UserName = item["UserName"].ToString();
        //        DateTime NgaySinhDG = (DateTime)item["NgaySinhDG"];
        //        DateTime NgayLapThe = (DateTime)item["NgayLapThe"];
        //        DateTime NgayHetHan = (DateTime)item["NgayHetHan"];
        //        string TenLoaiDocGia = item["TenLoaiDG"].ToString();
        //        decimal TongNo = (decimal)item["TongNo"];
        //        TheDocGiaDTO newTDG = new TheDocGiaDTO(IDDocGia, HoTenDG, UserName, DiaChiDG, EmailDG, NgaySinhDG, NgayLapThe, NgayHetHan, TenLoaiDocGia, TongNo);
        //        TheDocGia.Add(newTDG);
        //    }
        //    return TheDocGia;
        //}
        #region QueryTheDocGia
        public string QueryLoadTDG()
        {
            string Query = "select TheDocGia.*,Users.UserName,LoaiDocGia.TenLoaiDG From TheDocGia,Users,LoaiDocGia where TheDocGia.IDDocGia = Users.IDDocGia and LoaiDocGia.IDLoaiDG = TheDocGia.IDLoaiDG order by IDDocGia asc";
            return Query;
        }

        public string QuerySearchTDG(string SearchTT, string NhapTT)
        {
            string Query = "select TheDocGia.*,Users.UserName,LoaiDocGia.TenLoaiDG From TheDocGia,Users,LoaiDocGia where TheDocGia.IDDocGia = Users.IDDocGia and LoaiDocGia.IDLoaiDG = TheDocGia.IDLoaiDG and " + SearchTT + " like '%" + NhapTT + "%' order by IDDocGia asc";
            return Query;
        }

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
