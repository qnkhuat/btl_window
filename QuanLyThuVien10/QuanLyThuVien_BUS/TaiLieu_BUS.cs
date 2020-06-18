using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyThuVien_DTO;
using QuanLyThuVien_DAL;
using System.Data;
using System.Globalization;

namespace QuanLyThuVien_BUS
{
    public class TaiLieu_BUS
    {
        
        Data_DAL da = new Data_DAL();
        public DataTable ShowTaiLieu()
        {
            string sql = "select *from TaiLieu10";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable getcomboMaTheLoai()
        {
            string sql = "select * from TheLoai10";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertTaiLieu(string ma, string ten, string MaThL, int sl, string NhaXB,  int NamXB,string TacGia)
        {
            string sql = "insert into TaiLieu10 values(N'" + ma + "',N'" + ten + "',N'" + MaThL + "',N'" + sl + "',N'" + NhaXB + "',N'" + NamXB + "','" + TacGia + "')";
            da.ExcuteNonQuery(sql);
        }
        public void DeleteTaiLieu(string ma)
        {
            string sql ="delete TaiLieu10 where maTL=N'"+ma+"'";
            da.ExcuteNonQuery(sql);

        }
        public void UpdatetaiLieu(string ma, string ten, string MaThL, int sl, string NhaXB, int NamXB,string TacGia)
        {
            string sql = "update TaiLieu10 set tenTL=N'" + ten + "',maThL=N'" + MaThL + "',soLuong=N'" + sl + "',nhaXB=N'" +NhaXB + "',namXB=N'" + NamXB + "',tacGia=N'" + TacGia + "'where maTL=N'" + ma + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable SearchTaiLieu(string ma)
        {
            string sql = "select *from TaiLieu10 where maTL ='" +ma+ "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        
    }
}
