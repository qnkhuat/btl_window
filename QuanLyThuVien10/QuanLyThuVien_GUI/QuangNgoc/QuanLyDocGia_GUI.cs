using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QuanLyThuVien_BUS;
using QuanLyThuVien_DAL;
using QuanLyThuVien_DTO;

namespace QuanLyThuVien_GUI
{
    
    public partial class QuanLyDocGia_GUI : Form
    {
        //TaiLieu_DTO L=new TaiLieu_DTO();
     
        DocGia_BUS docgia = new DocGia_BUS();

        DataTable dtDocGia, dtTimKiem;
        public QuanLyDocGia_GUI()
        {
            InitializeComponent();
        }

        
        public void LoadData()
        {
            dtDocGia = new DataTable();
            dtDocGia = docgia.ShowDocGia();
            dgvQuanLyTaiLieu.DataSource = dtDocGia;
            cbMaDT.DataSource = docgia.getcomboMaDoiTuong();
            cbMaDT.DisplayMember = "maDT";
            cbMaDT.ValueMember = "maDT";
            cbGioiTinh.DataSource = docgia.getcomboMaDocGia10();
            cbGioiTinh.DisplayMember = "gioiTinh";
            cbGioiTinh.ValueMember = "gioiTinh";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                this.Dispose();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaDG.Text = "";
            txtTenDG.Text = "";
            txtNgayHetHan.Text = "";
            cbGioiTinh.Text = "";
            txtNgaySinh.Text = "";
            txtNgayCap.Text = "";
            cbMaDT.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaDG.Text == "")
                    MessageBox.Show("Bạn chưa nhập mã độc giả, nhập lại!");
                else if (txtTenDG.Text == "")
                    MessageBox.Show("Bạn chưa nhập tên độc giả, nhập lại!");
                else if (txtNgayHetHan.Text == "")
                    MessageBox.Show("Bạn chưa nhập ngày hết hạn, nhập lại!");
                else if (txtNgayCap.Text == "")
                    MessageBox.Show("Bạn chưa nhập ngày cấp, nhập lại");
                else if (txtNgaySinh.Text == "")
                    MessageBox.Show("Bạn chưa nhập ngày sinh, nhập lại");
                else
                {
                    int dem = 0;
                    foreach(DataRow row in dtDocGia.Rows)
                    {
                        var check = row["maDG"].ToString().Trim();
                        if(txtMaDG.Text.Trim()==check)
                        {
                            dem++;
                            break;
                        }    
                    }    
                    if(dem==0)
                    {
                       
                        docgia.InsertDocGia(txtMaDG.Text, txtTenDG.Text, cbGioiTinh.SelectedValue.ToString(), txtNgaySinh.Text, cbMaDT.SelectedValue.ToString(), txtNgayCap.Text, txtNgayHetHan.Text);
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Mã Độc Giả đã tồn tại, nhập lại", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }  
            }
            catch(Exception)
            {
                MessageBox.Show("không thêm được độc giả, thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
           
                if (txtMaDG.Text == "")
                    MessageBox.Show("Bạn chưa nhập mã tài liệu, nhập lại");
                else if (txtTenDG.Text == "")
                    MessageBox.Show("Tên tài liệu chưa được nhập, nhập lại");
                else if (txtNgayCap.Text == "")
                    MessageBox.Show("Năm xuất bản chưa được nhập, nhập lại");
                else if (txtNgaySinh.Text == "")
                    MessageBox.Show("nhà xuất bản chưa được nhập, nhập lại");
                else if (txtNgayHetHan.Text == "")
                    MessageBox.Show("Tác giả chwua được nhập, nhập lại");
                else
                {
                    int dem = 0;
                    foreach(DataRow row in dtDocGia.Rows)
                    {
                        var check = row["maDG"].ToString().Trim();
                        if(txtMaDG.Text.Trim()==check)
                        {
                            dem++;
                            break;
                        }    
                    }    
                    if(dem!=0)
                    {
                        docgia.UpdateDocGia(txtMaDG.Text, txtTenDG.Text, cbGioiTinh.SelectedValue.ToString(), txtNgaySinh.Text, cbMaDT.SelectedValue.ToString(), txtNgayCap.Text, txtNgayHetHan.Text);
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Mã tài liệu không tồn tại,nhập lại");
                    }
                }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("bạn có thực sự muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                docgia.DeleteDocGia(txtMaDG.Text.Trim());
                MessageBox.Show("Xóa thành công!");
                LoadData();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dtTimKiem = new DataTable();
            dtTimKiem = docgia.SearchDocGia(txtTim.Text.Trim());
            dgvQuanLyTaiLieu.DataSource = dtTimKiem;
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvQuanLyTaiLieu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            int dong = e.RowIndex;
            txtMaDG.Text = dgvQuanLyTaiLieu.Rows[dong].Cells[0].Value.ToString();
            txtTenDG.Text = dgvQuanLyTaiLieu.Rows[dong].Cells[1].Value.ToString();
            cbGioiTinh.SelectedValue = dgvQuanLyTaiLieu.Rows[dong].Cells[2].Value.ToString();
            txtNgaySinh.Text = dgvQuanLyTaiLieu.Rows[dong].Cells[3].Value.ToString();
            cbMaDT.SelectedValue = dgvQuanLyTaiLieu.Rows[dong].Cells[4].Value.ToString();
            txtNgayCap.Text = dgvQuanLyTaiLieu.Rows[dong].Cells[5].Value.ToString();
            txtNgayHetHan.Text = dgvQuanLyTaiLieu.Rows[dong].Cells[6].Value.ToString();
           
        }
        
        private void QuanLyTaiLieu_GUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
