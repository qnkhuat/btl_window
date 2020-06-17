using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using QuanLyThuVien_BUS;
using QuanLyThuVien_DAL;
using QuanLyThuVien_DTO;

namespace QuanLyThuVien_GUI
{
    public partial class QuanLyTheLoai_GUI : Form
    {
        TheLoai_DTO L = new TheLoai_DTO();
        TheLoai_BUS theloai = new TheLoai_BUS();

        DataTable dtTheloai;

        public QuanLyTheLoai_GUI()
        {
            InitializeComponent();
        }

        private void QuanLyTheLoai_GUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            dtTheloai = new DataTable();
            dtTheloai = theloai.ShowTheLoai();
            dgvQuanLyTheLoai.DataSource = dtTheloai;

        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtGhiChu.Text = "";
            txtMa.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMa.Text == "")
                    MessageBox.Show("Bạn chưa nhập mã thể loại, nhập lại");
                else if (txtTen.Text == "")
                    MessageBox.Show("Bạn chưa nhập tên thể loại, xin nhập lại");
                else
                {
                    int dem = 0;
                    foreach(DataRow row in dtTheloai.Rows)
                    {
                        var check = row["maThL"].ToString().Trim();
                        if(txtMa.Text.Trim()==check)
                        {
                            dem++;
                            break;
                        }    

                    }   
                    if(dem==0)
                    {
                        theloai.InsertTheLoai(txtMa.Text, txtTen.Text, txtGhiChu.Text);
                        MessageBox.Show("Thêm thể loại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Mã thể loại đã tồn tại, nhập lại", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("khong them được thể loại, thử lại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMa.Text == "")
                    MessageBox.Show("Mã thể loại không được bỏ trống");
                else if (txtTen.Text == "")
                    MessageBox.Show("Tên thể loại không được bỏ trống");
                else
                {
                    L.maThL = txtMa.Text;
                    L.tenThL = txtTen.Text;
                    L.ghiChu = txtGhiChu.Text;
                    int dem = 0;
                    foreach(DataRow row in dtTheloai.Rows)
                    {
                        foreach (DataColumn a in dtTheloai.Columns)
                        {
                            var check = row[a].ToString().Trim();
                            if(txtMa.Text.Trim()==check)
                            {
                                dem++;
                                break;
                            }    
                        }    
                            
                        
                    }
                    if (dem != 0)
                    {
                        theloai.UpdateTheLoai(L.maThL, L.tenThL, L.ghiChu);
                        QuanLyTheLoai_GUI_Load(sender, e);
                        MessageBox.Show("Cập nhật thể loại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Mã thể loại không tồn tại, nhập lại", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }    
            }
            catch(Exception)
            {
                MessageBox.Show("không cập nhật được thể loại, nhập lại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvQuanLyTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
