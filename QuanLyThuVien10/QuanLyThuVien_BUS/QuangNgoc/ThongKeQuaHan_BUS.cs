using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using QuanLyThuVien_DAL;

namespace QuanLyThuVien_BUS
{
    public class ThongKeQuaHan_BUS
    {

        Data_DAL da = new Data_DAL();
        public DataTable SearchThongKe(string from, string to)
        {

            string sql = "SELECT DocGia10.maDG, hoTenDG, tenTL, ngayMuon, DATEDIFF(day,ngayMuon, GETDATE()) - 30 AS soNgayQH " +
"FROM DocGia10 " +
    "INNER JOIN  PhieuMuon10 " +
            "ON PhieuMuon10.maDG = DocGia10.maDG " +
    "INNER JOIN PhieuMuonChiTiet10 " +
            "ON PhieuMuonChiTiet10.maPM = PhieuMuon10.maPM " +
    "INNER JOIN TaiLieu10 " +
            "ON PhieuMuonChiTiet10.maTL = TaiLieu10.maTL " +
"WHERE ngayMuon >= '" + from + " '" +
    "AND ngayMuon <= '" + to + "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
    }
    }
}
