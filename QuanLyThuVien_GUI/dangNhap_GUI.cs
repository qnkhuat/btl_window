using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien_GUI
{
    public partial class dangNhap_GUI : Form
    {
        public dangNhap_GUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trangChu_GUI tc = new trangChu_GUI();
            tc.Show();
            this.Visible = false;
        }
    }
}
