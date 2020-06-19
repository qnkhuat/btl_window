
using QuanLyThuVien_BUS.BAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien_GUI
{
    public partial class dangNhap_GUI : Form
    {
        public static String loaitk;
        public static String tendn;
        dangNhap_BUS dnb = new dangNhap_BUS();
        public dangNhap_GUI()
        {
            InitializeComponent();
        }
        //Đăng nhập
        private void button1_Click(object sender, EventArgs e)
        {
            if (txttendn.Text.Equals("") || txtmatkhau.Text.Equals(""))
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống!");
            }
            else
            { 
            SqlDataReader sdr = dnb.getNhanVien(txttendn.Text, txtmatkhau.Text);
            if (sdr.HasRows)
            {
                    sdr.Read();
                    loaitk = sdr.GetString(5);
                    tendn = sdr.GetString(3);
                    trangChu_GUI tc = new trangChu_GUI();
                    tc.ShowDialog();
                    this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
            }
        }
    }
}
