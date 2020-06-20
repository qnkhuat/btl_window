using QuanLyThuVien_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien_GUI.BAO
{
    public partial class qlMatKhau_GUI : Form
    {
        public qlMatKhau_GUI()
        {
            InitializeComponent();
        }

        private void qlMatKhau_GUI_Load(object sender, EventArgs e)
        {
            txttendn.Enabled = false;
            txttendn.Text=dangNhap_GUI.tendn;
        }
        Data_DAL dal = new Data_DAL();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txttendn.Text.Equals("") || txtmkcu.Text.Equals("") || txtmkmoi.Text.Equals("") || txtconfirmmkmoi.Text.Equals("")) 
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
            }
            else 
            {
                SqlDataReader sdr = dal.getData("select * from NhanVien10 where taiKhoan='"+txttendn.Text+"' " +
                    "and matKhau='"+txtmkcu.Text+"'");
                if (sdr.HasRows)
                {
                    sdr.Read();
                    if (txtmkmoi.Text.Equals(txtconfirmmkmoi.Text)) 
                    {
                        dal.ExcuteNonQuery("update NhanVien10 set matKhau='"+txtmkmoi.Text+"' " +
                            "where taiKhoan='"+txttendn.Text+"' and matKhau='"+txtmkcu.Text+"'");
                        MessageBox.Show("Đổi thành công!");
                    }
                    else 
                    {
                        MessageBox.Show("Xác nhận mật khẩu sai");
                    }
                }
                else 
                {
                    MessageBox.Show("Sai mật khẩu cũ!");
                }

            }
        }
    }
}
