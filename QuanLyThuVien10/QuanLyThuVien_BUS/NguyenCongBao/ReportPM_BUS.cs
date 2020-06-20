using QuanLyThuVien_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QuanLyThuVien_BUS.BAO
{
    public class ReportPM_BUS
    {
        Data_DAL dal = new Data_DAL();
        public DataTable getReportPM(String x)
        {
            SqlDataAdapter ad = dal.getPMreportAdapter("select PhieuMuon10.maPM,PhieuMuon10.maDG,PhieuMuon10.ngayMuon" +
                ",PhieuMuon10.maNV,PhieuMuonChiTiet10.maTL,PhieuMuonChiTiet10.soLuongMuon,PhieuMuonChiTiet10.ngayTra" +
                " from PhieuMuon10 inner join PhieuMuonChiTiet10 on PhieuMuon10.maPM=PhieuMuonChiTiet10.maPM" +
                " where PhieuMuon10.maPM='" + x + "'");
            DataTable pm = new DataTable();
            ad.Fill(pm);
            return pm;
        }
    }
}
