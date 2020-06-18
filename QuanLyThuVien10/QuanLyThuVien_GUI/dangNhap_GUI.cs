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
        public String loaitk;
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
                loaitk = sdr.GetString(5);
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
            }
        }
    }
}
