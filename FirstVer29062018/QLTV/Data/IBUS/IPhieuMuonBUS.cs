using Data.DTO;
using Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IBUS
{
    public interface IPhieuMuonBUS
    {
        // editForm PhieuMuon And CTPhieuMuon
        bool editFormPhieuMuonAndCTPhieuMuon(PhieuMuonDTO phieumuon);
        //Add Form PhieuMuon and CTPhieuMuon
        bool AddFormPhieuMuonAndCTPhieuMuon(PhieuMuonDtos phieuMuon, List<int> TenDauSach);
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
        //Get All Form "PhieuMuon" and "CTPhieuMuon"
        List<PhieuMuonDTO> getAllFormPhieuMuonAndCTPhieuMuon();
        //Xuat file excel
        bool ExportToCsvFile(List<PhieuMuonDTO> PM, string fileName);


    }
}
