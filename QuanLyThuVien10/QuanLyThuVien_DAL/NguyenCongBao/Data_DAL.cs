using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QuanLyThuVien_DAL.BAO
{
    //Kết Nối CSDL là SQL Server
    public class Data_DAL
    {
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=DESKTOP-9O7NFIJ\SQLEXPRESS;Initial Catalog=Quan_Ly_Thu_Vien;Integrated Security=True");
        }
        //Lấy bảng dữ liệu
        public DataTable GetTable(String sql)
        {
            SqlConnection con = getConnect();
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return (dt);
        }
        //Lấy dữ liệu để duyệt
        public SqlDataReader getData(String sql)
        {
            SqlConnection con = getConnect();
            SqlDataReader sdr = null;
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            sdr = cmd.ExecuteReader();
            return sdr;
        }
        //Update dữ liệu
        public void ExcuteNonQuery(String sql)
        {
            SqlConnection con = getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
        //get dataAdepter
        public SqlDataAdapter getPMreportAdapter(String sql)
        {
            SqlConnection con = getConnect();
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            return ad;
        }
    }
}
