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
    public partial class trangChu_GUI : Form
    {
        public trangChu_GUI()
        {
            InitializeComponent();
        }


        //Check form có tồn tại không
        private Boolean checkformExist(String name)
        {
            Boolean check = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }


        //Kích hoạt form
        private void activeForm(String name)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == name)
                {
                    f.Activate();
                    break;
                }
            }
        }


        private void ntmuonsach_Click(object sender, EventArgs e)
        {
            if (checkformExist("muonSach_GUI"))
            {
                activeForm("muonSach_GUI");
            }
            else
            {
                muonSach_GUI ms = new muonSach_GUI();
                ms.MdiParent = this;
                ms.Show();
            }
        }

        private void bttrasach_Click(object sender, EventArgs e)
        {
            if (checkformExist("traSach_GUI"))
            {
                activeForm("traSach_GUI");
            }
            else
            {
                traSach_GUI ts = new traSach_GUI();
                ts.MdiParent = this;
                ts.Show();
            }
        }


    }
}
