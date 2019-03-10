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
    public class CTPhieuMuonDAO
    {
        #region Instance
        private static CTPhieuMuonDAO instance;

        public static CTPhieuMuonDAO Instance
        {
            get
            {
                if (instance == null) instance = new CTPhieuMuonDAO(); return DAO.CTPhieuMuonDAO.instance;
            }

            private set
            {
                DAO.CTPhieuMuonDAO.instance = value;
            }
        }
        #endregion
        #region Operator+
        public int IDPlus()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var query = ((from a in db.CT_PHIEUMUON select a.IDCTPhieuMuon).Max()).ToString();
                int ID = Int32.Parse(query);
                int IDadd = ++ID;
                return IDadd;
            }
        }
        #endregion
        #region getList ALl Form CTPhieuMuon
        public List<CTPhieuMuonDTO> getFormCTPhieuMuon()
        {
            using (var db = new QuanLyThuVienEntities())
            {
                var result = (from a in db.CT_PHIEUMUON
                              select new CTPhieuMuonDTO()
                              {
                                  IDCTPhieuMuon = a.IDCTPhieuMuon,
                                  IDPhieuMuon = a.IDPhieuMuon,
                                  TenDauSach = GetDataDAO.Instance.getTenCuonSach(a.IDCuonSach),
                              }).ToList<CTPhieuMuonDTO>();
                return result;
            }
        }
        #endregion
    }
}
