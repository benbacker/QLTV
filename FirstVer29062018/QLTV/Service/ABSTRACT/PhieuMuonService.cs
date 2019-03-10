using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.IService;
using Data.IBUS;
using Data.BUS;
using Data.Dtos;
using Data.DAO;
using Data.DTO;

namespace Service.ABSTRACT
{
    public class PhieuMuonService : IPhieuMuonService
    {
        private IPhieuMuonBUS _iPhieuMuonBUS;
        public PhieuMuonService()
        {
            this._iPhieuMuonBUS = new PhieuMuonBUS();
        }
        //add Form "PhieuMuon" And Form "CTPhieuMuon"
        public void addFormPhieuMuonAndCTPhieuMuon(PhieuMuonDtos phieuMuon, List<int> tb_TenSach)
        {
            this._iPhieuMuonBUS.AddFormPhieuMuonAndCTPhieuMuon(phieuMuon, tb_TenSach);
        }
        //edit Form PhieuMuon and CTphieuMuon
        public void editFormPhieuMuonAndCTPhieuMuon(PhieuMuonDTO phieumuon)
        {
            this._iPhieuMuonBUS.editFormPhieuMuonAndCTPhieuMuon(phieumuon);
        }

        public bool ExportToCsvFile(List<PhieuMuonDTO> PM, string fileName)
        {
            return this._iPhieuMuonBUS.ExportToCsvFile(PM, fileName);
        }


        #region getAll Form PhieuMuon and CTPhieuMuon
        public List<PhieuMuonDTO> getAllFormPhieuMuonAndCTPhieuMuon()
        {
            return this._iPhieuMuonBUS.getAllFormPhieuMuonAndCTPhieuMuon();
        }
        #endregion
        #region getList Search phieumuondtos
        public List<PhieuMuonDTO> getFormPhieuMuonSearchHanTra(DateTime hantra)
        {
            return this._iPhieuMuonBUS.getFormPhieuMuonSearchHanTra(hantra);
        }

        public List<PhieuMuonDTO> getFormPhieuMuonSearchIDDocGia(int ID)
        {
            return this._iPhieuMuonBUS.getFormPhieuMuonSearchIDDocGia(ID);
        }

        public List<PhieuMuonDTO> getFormPhieuMuonSearchIDPhieuMuon(int ID)
        {
            return this._iPhieuMuonBUS.getFormPhieuMuonSearchIDPhieuMuon(ID);
        }

        public List<PhieuMuonDTO> getFormPhieuMuonSearchNgayMuon(DateTime ngaymuon)
        {
            return this._iPhieuMuonBUS.getFormPhieuMuonSearchNgayMuon(ngaymuon);
        }
        #endregion
    }
}
