using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Dtos;
using Data.DTO;

namespace Service.IService
{
    public interface IPhieuMuonService
    {
        // editForm PhieuMuon And CTPhieuMuon
        void editFormPhieuMuonAndCTPhieuMuon(PhieuMuonDTO phieumuon);
        //Add Form PhieuMuon and CTPhieuMuon
        void  addFormPhieuMuonAndCTPhieuMuon(PhieuMuonDtos phieuMuon, List<int> tb_TenSach);
        #region getList Search PhieuMuonDTO
        //get List Search IDDocGia
        List<PhieuMuonDTO> getFormPhieuMuonSearchIDDocGia(int ID);
        //get List Search IDPhieuMuon
        List<PhieuMuonDTO> getFormPhieuMuonSearchIDPhieuMuon(int ID);
        //get List Search NgayMuon
        List<PhieuMuonDTO> getFormPhieuMuonSearchNgayMuon(DateTime ngaymuon);
        //get List Search HanTra
        List<PhieuMuonDTO> getFormPhieuMuonSearchHanTra(DateTime hantra);
        #endregion
        // getAll Form "PhieuMuon" And "CTPhieuMuon"
        List<PhieuMuonDTO> getAllFormPhieuMuonAndCTPhieuMuon();
        //Xuat file excel
        bool ExportToCsvFile(List<PhieuMuonDTO> PM, string fileName);
    }
}
