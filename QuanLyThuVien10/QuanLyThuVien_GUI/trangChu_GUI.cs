using QuanLyThuVien_GUI.BAO;
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
        String tendn = dangNhap_GUI.tendn;

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
        

     /*   private void ntmuonsach_Click(object sender, EventArgs e)
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
        }*/

      /*  private void bttrasach_Click(object sender, EventArgs e)
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
        }*/

        private void trangChu_GUI_Load(object sender, EventArgs e)
        {
            if (dangNhap_GUI.loaitk == "admin") 
            {
                //fasle
                btqlchucvu.Enabled = false;
                btqldocgia.Enabled = false;
                btqldoituong.Enabled = false;
                btqlnhanvien.Enabled = false;
                btqltailieu.Enabled = false;
                btqltheloai.Enabled = false;
                //true
                btsoluongmuontheotheloai.Enabled = true;
                bttlmuonquahan.Enabled = true;
                bttop10tl.Enabled = true;
                btqltrasach.Enabled = true;
                btqlmuonsach.Enabled = true;
            }
            else 
            {
                //fasle
                btqlchucvu.Enabled = true;
                btqldocgia.Enabled = true;
                btqldoituong.Enabled = true;
                btqlnhanvien.Enabled = true;
                btqltailieu.Enabled = true;
                btqltheloai.Enabled = true;
                //xoa di nay
                btsoluongmuontheotheloai.Enabled = true;
                bttlmuonquahan.Enabled = true;
                bttop10tl.Enabled = true;
                btqltrasach.Enabled = true;
                btqlmuonsach.Enabled = true;
              /*  //true
                btsoluongmuontheotheloai.Enabled = false;
                bttlmuonquahan.Enabled = false;
                bttop10tl.Enabled = false;
                btqltrasach.Enabled = false;
                btqlmuonsach.Enabled = false;*/
            }
        }

        private void btqltheloai_Click(object sender, EventArgs e)
        {
            if (checkformExist("QuanLyTheLoai_GUI"))
            {
                activeForm("QuanLyTheLoai_GUI");
            }
            else
            {
                QuanLyTheLoai_GUI f = new QuanLyTheLoai_GUI();
                f.MdiParent = this;
                f.Show();
            }
        }
        
        private void bttop10tl_Click(object sender, EventArgs e)
        {
            if (checkformExist("ThongKeTop10TaiLieu_GUI"))
            {
                activeForm("ThongKeTop10TaiLieu_GUI");
            }
            else
            {
                ThongKeTop10TaiLieu_GUI f = new ThongKeTop10TaiLieu_GUI();
                f.MdiParent = this;
                f.Show();
            }
        }
        
        private void btqltailieu_Click(object sender, EventArgs e)
        {
            if (checkformExist("QuanLyTaiLieu_GUI"))
            {
                activeForm("QuanLyTaiLieu_GUI");
            }
            else
            {
                QuanLyTaiLieu_GUI f = new QuanLyTaiLieu_GUI();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkformExist("qlMatKhau_GUI"))
            {
                activeForm("qlMatKhau_GUI");
            }
            else
            {
                qlMatKhau_GUI f = new qlMatKhau_GUI();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btdangxuat_Click(object sender, EventArgs e)
        {
           
            /*dangNhap_GUI dn = new dangNhap_GUI();
            dn.txttendn.Text = tendn;
            dn.ShowDialog();
            this.SetVisibleCore(false);*/
            dangNhap_GUI dn = new dangNhap_GUI();
            this.Hide();
            dn.ShowDialog();
            this.Show();
            Application.Exit();
        }

        private void btqlmuonsach_Click(object sender, EventArgs e)
        {
            if (checkformExist("muonSach_GUI"))
            {
                activeForm("muonSach_GUI");
            }
            else
            {
                muonSach_GUI f = new muonSach_GUI();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btqltrasach_Click(object sender, EventArgs e)
        {
            if (checkformExist("traSach_GUI"))
            {
                activeForm("traSach_GUI");
            }
            else
            {
                traSach_GUI f = new traSach_GUI();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
    }
