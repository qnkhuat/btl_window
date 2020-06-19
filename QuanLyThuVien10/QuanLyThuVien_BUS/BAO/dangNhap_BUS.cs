using QuanLyThuVien_DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QuanLyThuVien_BUS.BAO
{
    public class dangNhap_BUS
    {
        Data_DAL dal = new Data_DAL();
        public SqlDataReader getNhanVien(String x, String y)
        {
            SqlDataReader dtr = dal.getData("select * from NhanVien10 where taiKhoan='" + x + "' and matKhau='" + y + "'");
            return dtr;
        }
    }
}