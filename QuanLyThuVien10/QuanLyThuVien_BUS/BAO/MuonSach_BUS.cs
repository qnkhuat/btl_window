using QuanLyThuVien_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using QuanLyThuVien_DTO;

namespace QuanLyThuVien_BUS
{
    public class MuonSach_BUS
    {

        //Kết nối CSDL là LINQ
        //Lấy dữ liệu
        public List<Object> getphieuMuonlq()
        {
            List<Object> list = new List<object>();
            dbQLTVDataContext data = new dbQLTVDataContext();
            var sp = from p in data.PhieuMuon10s
                     join k in data.NhanVien10s
                     on p.maNV equals k.maNV
                     join h in data.DocGia10s
                     on p.maDG equals h.maDG
                     select new { p.maPM, h.maDG, h.hoTenDG, k.maNV, k.hoTenNV, p.ngayMuon };
            foreach (var i in sp)
            {
                list.Add(i);
            }
                return list;
            }
        //Lấy phiếu mượn chi tiết theo mã
        public List<Object> getphieuMuonChiTietlq(String x)
        {
            List<Object> list = new List<object>();
            dbQLTVDataContext data = new dbQLTVDataContext();
            var sp = from p in data.PhieuMuonChiTiet10s
                     join k in data.TaiLieu10s
                     on p.maTL equals k.maTL
                     where p.maPM == x
                     select new {p.maTL,k.tenTL,p.soLuongMuon};
            foreach (var i in sp)
            {
                list.Add(i);
            }
            return list;
        }

        //Truy vấn bằng SQL
        Data_DAL dal = new Data_DAL();


        //Lấy Nhân Viên
        public SqlDataReader getNhanVien()
        {
            SqlDataReader sdr = null;
            sdr = dal.getData("select * from NhanVien10");
            return sdr;
        }
        
        
        //Lấy Độc Giả 
        public SqlDataReader getDocGia()
        {
            SqlDataReader sdr = null;
            sdr = dal.getData("select * from DocGia10");
            return sdr;
        }
        
        
        
        //Lấy phiếu mượn
        public SqlDataReader getPhieuMuon()
        {
            SqlDataReader sdr = null;
            sdr = dal.getData("select * from PhieuMuon10");
            return sdr;
        }
        //Tìm phiếu mượn/ Lấy phiếu mượn theo mã
        public DataTable getPhieuMuonTheoMa(String x) 
        {
            DataTable pm = dal.GetTable("select PhieuMuon10.maPM,DocGia10.maDG,DocGia10.hoTenDG,PhieuMuon10.ngayMuon" +
                ",NhanVien10.maNV,NhanVien10.hoTenNV from PhieuMuon10 inner join DocGia10 on PhieuMuon10.maDG=DocGia10.maDG" +
                " inner join NhanVien10 on PhieuMuon10.maNV = NhanVien10.maNV where PhieuMuon10.maPM='"+x+"'");
            return pm;
        }
        //Thêm phiếu mượn
        public void addPhieuMuon(phieuMuon x)
        {
            dal.ExcuteNonQuery("insert into PhieuMuon10 values('"+x.MaPM+"','"+x.MaDG+"','"+x.NgayMuon+"','"+x.MaNV+"')");
        }
        //Update phiếu mượn
        public void updatephieumuon(phieuMuon x) 
        {
            dal.ExcuteNonQuery("update PhieuMuon10 set maDG='"+x.MaDG+"',maNV='"+x.MaNV+"' where maPM='"+x.MaPM+"'");
        }
        //Xóa Phiếu Mượn
        public void deletePhieuMuon(String x) 
        {
            dal.ExcuteNonQuery("delete from PhieuMuon10 where maPM='" + x + "'");
        }



        //Lấy phiếu mượn chi tiết theo mã PM
        public SqlDataReader getPhieuMuonChiTietTheoMa(String x)
        {
            SqlDataReader pm = dal.getData("select * from PhieuMuonChiTiet10 where maPM='"+x+"'");
            return pm;
        }
        //Lấy phiếu mượn chi tiết theo mã PM và mã TL trả về SQLDataReader
        public SqlDataReader getPhieuMuonChiTietTheoMa(String x,String y)
        {
            SqlDataReader pm = dal.getData("select * from PhieuMuonChiTiet10 where maPM='"+x+ "' and maTL='" + y + "'");
            return pm;
        }
        //Lấy phiếu mượn chi tiết theo mã PM và mã TL trả về DataTable
        public DataTable getPhieuMuonChiTietTheoMatable(String x, String y)
        {
            DataTable pm = dal.GetTable("select * from PhieuMuonChiTiet10 where maPM='" + x + "' and maTL='" + y + "'");
            return pm;
        }
        //Thêm phiếu mượn chi tiết
        public void addPhieuMuonChiTiet(phieuMuonChiTiet x)
        {
            dal.ExcuteNonQuery("insert into PhieuMuonChiTiet10 values('" + x.MaPM + "','" + x.MaTL + "','" + x.SlMuon + "',null)");
        }
        //Update phiếu mượn chi tiết
        public void updatephieumuonchitiet(phieuMuonChiTiet x)
        {
            dal.ExcuteNonQuery("update PhieuMuonChiTiet10 set ngayTra=null,soLuongMuon='" + x.SlMuon + "' where maPM='" + x.MaPM + "' and maTL='" + x.MaTL + "'");
        }
        //Xóa phiếu mượn chi tiết( Sửa )
        public void deletephieuMuonChiTiet(String x) 
        {
            dal.ExcuteNonQuery("delete from PhieuMuonChiTiet10 where maPM='" + x +"'");
        }
        public void deletephieuMuonChiTiet(String x,String y)
        {
            dal.ExcuteNonQuery("delete from PhieuMuonChiTiet10 where maPM='" + x + "' and maTL='"+y+"'");
        }

        // Một Phiếu mượn có thể lưu nhiều tài liệu  Dùng ArrayList để lưu tài liệu nhớ

        //Lấy tài liệu
        public SqlDataReader getTaiLieu()
        {
            SqlDataReader sdr = null;
            sdr = dal.getData("select * from TaiLieu10");
            return sdr;
        }
        //Lấy tài liệu theo mã
        public SqlDataReader getTaiLieu(String x)
        {
            SqlDataReader sdr = null;
            sdr = dal.getData("select * from TaiLieu10 where maTL='"+x+"'");
            return sdr;
        }
        //Update bảng tài liệu
        //Thêm phiếu mượn
        public void updateSoLuongTLAdd(phieuMuonChiTiet x)
        {
            dal.ExcuteNonQuery("update TaiLieu10 set soLuong-=" + x.SlMuon + " where maTL=N'" + x.MaTL + "'");
        }
        //Sửa phiếu mượn
        public void updateSoLuongTLUpdate(int x, int y,String matl)
        {
            if (!(x == y))
            {
                dal.ExcuteNonQuery("update TaiLieu10 set soLuong+=" + (x-y) + " where maTL=N'" + matl + "'");
            }
        }
        //Xóa phiếu mượn
        public void updateSoLuongTLdelete(phieuMuonChiTiet x) 
        {
            dal.ExcuteNonQuery("update TaiLieu10 set soLuong+=" + x.SlMuon + " where maTL=N'" + x.MaTL + "'");
        }



    }
}
