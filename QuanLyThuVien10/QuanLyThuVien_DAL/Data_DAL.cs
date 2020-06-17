using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace QuanLyThuVien_DAL
{
    public class Data_DAL
    {
        public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=Quan_Ly_Thu_Vien;Integrated Security=True");
            

        }
        public DataTable GetTable(string sql)
        {
            SqlConnection con = getConnect();
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return (dt);
        }
        public void ExcuteNonQuery(string sql)
        {
            SqlConnection con = getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.Clone();
        }
    }
}
