using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyThuVien_DAL;
using QuanLyThuVien_DTO;
using System.Data;

namespace QuanLyThuVien_BUS
{
    public class DoiTuong_BUS
    {
        Data_DAL da = new Data_DAL();
        

        public DataTable ShowDoiTuong()
        {
            string sql = "select *from DoiTuong10";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
            
        }
        
        public void InsertDoiTuong(string ma,string ten)
        {
            string sql = "insert into DoiTuong10 values(N'" + ma + "',N'" + ten + "')";
            da.ExcuteNonQuery(sql)
;        }
        public void DeleteDoiTuong(string ma)
        {
            string sql = "delete DoiTuong10 where maDT=N'" + ma + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable LookDoiTuong(string ma)
        { 
            string sql= "select *from DoiTuong10 where maDT='" + ma+"'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void UpdateDoiTuong(string ma,string ten)
        {
            string sql = "update DoiTuong10 set tenDT=N'" + ten + "' where maDT=N'" + ma + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable SearchDoiTuong(string ma)
        {
            string sql = "select * from DoiTuong10 where maDT='" + ma + "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
