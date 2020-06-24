using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using QuanLyThuVien_DAL;
namespace QuanLyThuVien_BUS
{
    public class DocGia_BUS
    {

        Data_DAL da = new Data_DAL();
        public DataTable ShowDocGia()
        {
            string sql = "select *from DocGia10";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable getcomboMaDocGia10()
        {
            string sql = "select * from DocGia10";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable getcomboMaDoiTuong()
        {
            string sql = "select * from DoiTuong10";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertDocGia(string ma, string ten, string gioiTinh, string ngaySinh, string maDoiTuong, string ngayCap, string ngayHetHan)
        {
            string sql = "insert into DocGia10 values(N'" + ma + "',N'" + ten + "',N'" + gioiTinh + "',N'" + ngaySinh + "',N'" + maDoiTuong + "',N'" + ngayCap + "','" + ngayHetHan + "')";
            da.ExcuteNonQuery(sql);
        }
        public void DeleteDocGia(string ma)
        {
            string sql = "delete DocGia10 where maDG=N'" + ma + "'";
            da.ExcuteNonQuery(sql);

        }
        public void UpdateDocGia(string ma, string ten, string gioiTinh, string ngaySinh, string maDoiTuong, string ngayCap, string ngayHetHan)
        {
            string sql = "update DocGia10 set hoTenDG=N'" + ten + "',gioiTinh=N'" + gioiTinh + "',ngaySinh=N'" + ngaySinh + "',maDT=N'" + maDoiTuong + "',ngayCap=N'" + ngayCap + "',ngayHetHan=N'" + ngayHetHan + "'where maDG=N'" + ma + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable SearchDocGia(string ma)
        {
            string sql = "select *from DocGia10 where maDG ='" + ma + "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

    }
}
