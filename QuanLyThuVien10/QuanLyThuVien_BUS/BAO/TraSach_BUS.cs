using QuanLyThuVien_DAL;
using QuanLyThuVien_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyThuVien_BUS
{
    public class TraSach_BUS
    {
        Data_DAL dal = new Data_DAL();
        //Lấy All dữ liệu
        public List<Object> getphieuMuon_PMChiTietlq()
        {
            List<Object> list = new List<object>();
            dbQLTVDataContext data = new dbQLTVDataContext();
            var sp = from p in data.PhieuMuon10s
                     join k in data.PhieuMuonChiTiet10s
                     on p.maPM equals k.maPM
                     select new { p.maPM, k.maTL, p.maDG, p.maNV, k.soLuongMuon, p.ngayMuon,k.ngayTra };
            foreach (var i in sp)
            {
                list.Add(i);
            }
            return list;
        }


        //Lấy dữ liệu theo mã độc giả
        //LINQ
        public List<Object> getphieuMuon_PMChiTietlq(String x)
        {
            List<Object> list = new List<object>();
            dbQLTVDataContext data = new dbQLTVDataContext();
            var sp = from p in data.PhieuMuon10s
                     join k in data.PhieuMuonChiTiet10s
                     on p.maPM equals k.maPM
                     where p.maDG == x && k.ngayTra.Value == null
                     select new { p.maPM, k.maTL, p.maDG, p.maNV, k.soLuongMuon, p.ngayMuon, k.ngayTra };
            foreach (var i in sp)
            {
                list.Add(i);
            }
            return list;
        }
        //SQL
        public DataTable getphieuMuon_PMChiTietsql(String x) 
        {
            DataTable datb = dal.GetTable("select PhieuMuon10.maPM,maTL,maDG,maNV,soLuongMuon,ngayMuon,ngayTra from" +
                " PhieuMuon10 inner join PhieuMuonChiTiet10 on PhieuMuon10.maPM=PhieuMuonChiTiet10.maPM where maDG='"+x+"' " +
                "and ngayTra is null");
            return datb;
        }
        public void updatephieumuonchitiet(phieuMuonChiTiet x)
        {
            dal.ExcuteNonQuery("update PhieuMuonChiTiet10 set ngayTra='"+x.NgayTra+"' where maPM='" + x.MaPM + "' and  maTL='"+x.MaTL+"'");
        }

        //Update tài liệu khi trả sách
        public void updateSoLuongTLtraSach(phieuMuonChiTiet x)
        {
            dal.ExcuteNonQuery("update TaiLieu10 set soLuong+=" + x.SlMuon + " where maTL=N'" + x.MaTL + "'");
        }

    }
}
