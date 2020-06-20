using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using QuanLyThuVien_DAL;

namespace QuanLyThuVien_BUS
{
    public class ThongKeTop10_BUS
    {

        Data_DAL da = new Data_DAL();
        public DataTable SearchThongKe(string ngayM, string ngayT)
        {
            string sql = "select top(10) tenTL,tenThL,ghiChu,sum(soLuongMuon) as tongslMuon,PhieuMuonChiTiet10.maTL from PhieuMuonChiTiet10 inner join PhieuMuon10 on PhieuMuonChiTiet10.maPM=PhieuMuon10.maPM "+
                " inner join TaiLieu10 on PhieuMuonChiTiet10.maTL = TaiLieu10.maTL inner join TheLoai10 on TaiLieu10.maThL = TheLoai10.maThL where ngayMuon >= '"+ngayM+ "' and ngayTra <= '"+ngayT+"' "+
                " group by PhieuMuonChiTiet10.maTL,tenTL,tenThL,ghiChu "+
                " order by sum(soLuongMuon) desc";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
    }
    }
}
