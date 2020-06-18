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
    
    public partial class QuanLyTaiLieu_GUI : Form
    {
        TaiLieu_DTO L=new TaiLieu_DTO();
     
        TaiLieu_BUS tailieu = new TaiLieu_BUS();

        DataTable dtTaiLieu, dtTimKiem;
        public QuanLyTaiLieu_GUI()
        {
            InitializeComponent();
        }

        
        public void LoadData()
        {
            dtTaiLieu = new DataTable();
            dtTaiLieu = tailieu.ShowTaiLieu();
            dgvQuanLyTaiLieu.DataSource = dtTaiLieu;
            cbMaThL.DataSource = tailieu.getcomboMaTheLoai();
            cbMaThL.DisplayMember = "maTHL";
            cbMaThL.ValueMember = "maThL";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                this.Dispose();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaTL.Text = "";
            txtTenTL.Text = "";
            txtTG.Text = "";
            txtSL.Text = "";
            txtNhaXB.Text = "";
            txtNamXB.Text = "";
            cbMaThL.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaTL.Text == "")
                    MessageBox.Show("Bạn chưa nhập mã tài liệu, nhập lại!");
                else if (txtTenTL.Text == "")
                    MessageBox.Show("Bạn chưa nhập tên tài liệu, nhập lại!");
                else if (txtTG.Text == "")
                    MessageBox.Show("Bạn chưa nhập tên tác giả, nhập lại!");
                else if (txtNamXB.Text == "")
                    MessageBox.Show("Bạn chưa nhập năm xuất bạn, nhập lại");
                else if (txtNhaXB.Text == "")
                    MessageBox.Show("Bạn chưa nhập Nhà xuất bản, nhập lại");
                else if (txtSL.Text == "")
                    MessageBox.Show("Bạn chưa nhập số lượng, nhập lại");
                else
                {
                    int dem = 0;
                    foreach(DataRow row in dtTaiLieu.Rows)
                    {
                        var check = row["maTL"].ToString().Trim();
                        if(txtMaTL.Text.Trim()==check)
                        {
                            dem++;
                            break;
                        }    
                    }    
                    if(dem==0)
                    {
                        L.maTL = txtMaTL.Text;
                        L.tenTL = txtTenTL.Text;
                        L.namXb = Int32.Parse(txtNamXB.Text);
                        L.nhaXB = txtNhaXB.Text;
                        L.soLuong = Int32.Parse(txtSL.Text);
                        L.tacGia = txtTG.Text;
                        L.maThL = cbMaThL.SelectedValue.ToString();

                        tailieu.InsertTaiLieu(L.maTL, L.tenTL, L.maThL, L.soLuong, L.nhaXB, L.namXb, L.tacGia);
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Mã Tài liệu đã tồn tại, nhập lại", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
            }
            catch(Exception)

            {
                MessageBox.Show("không thêm được tài liệu, thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaTL.Text == "")
                    MessageBox.Show("Bạn chưa nhập mã tài liệu, nhập lại");
                else if (txtTenTL.Text == "")
                    MessageBox.Show("Tên tài liệu chưa được nhập, nhập lại");
                else if (txtNamXB.Text == "")
                    MessageBox.Show("Năm xuất bản chưa được nhập, nhập lại");
                else if (txtNhaXB.Text == "")
                    MessageBox.Show("nhà xuất bản chưa được nhập, nhập lại");
                else if (txtSL.Text == "")
                    MessageBox.Show("số lượng tài liệu chưa được nhập, nhập lại");
                else if (txtTG.Text == "")
                    MessageBox.Show("Tác giả chwua được nhập, nhập lại");
                else
                {
                    int dem = 0;
                    foreach(DataRow row in dtTaiLieu.Rows)
                    {
                        var check = row["maTL"].ToString().Trim();
                        if(txtMaTL.Text.Trim()==check)
                        {
                            dem++;
                            break;
                        }    
                    }    
                    if(dem!=0)
                    {
                        L.maTL = txtMaTL.Text;
                        L.tenTL = txtTenTL.Text;
                        L.nhaXB = txtNhaXB.Text;
                        L.tacGia = txtTG.Text;
                        L.namXb = Int32.Parse(txtNamXB.Text);
                        L.soLuong = Int32.Parse(txtSL.Text);
                        L.maThL = cbMaThL.SelectedValue.ToString();

                        tailieu.UpdatetaiLieu(L.maTL, L.tenTL, L.maThL, L.soLuong, L.nhaXB, L.namXb, L.tacGia);
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Mã tài liệu không tồn tại,nhập lại");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("không sửa được tài liệu, thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = MessageBox.Show("bạn có thực sự muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                tailieu.DeleteTaiLieu(txtMaTL.Text.Trim());
                MessageBox.Show("Xóa thành công!");
                LoadData();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dtTimKiem = new DataTable();
            dtTimKiem = tailieu.SearchTaiLieu(txtTim.Text.Trim());
            dgvQuanLyTaiLieu.DataSource = dtTimKiem;
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvQuanLyTaiLieu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            int dong = e.RowIndex;
            txtMaTL.Text = dgvQuanLyTaiLieu.Rows[dong].Cells[0].Value.ToString();
            txtTenTL.Text = dgvQuanLyTaiLieu.Rows[dong].Cells[1].Value.ToString();
            cbMaThL.SelectedValue = dgvQuanLyTaiLieu.Rows[dong].Cells[2].Value.ToString();
            txtSL.Text = dgvQuanLyTaiLieu.Rows[dong].Cells[3].Value.ToString();
            txtNhaXB.Text = dgvQuanLyTaiLieu.Rows[dong].Cells[4].Value.ToString();
            txtNamXB.Text = dgvQuanLyTaiLieu.Rows[dong].Cells[5].Value.ToString();
            txtTG.Text = dgvQuanLyTaiLieu.Rows[dong].Cells[6].Value.ToString();
           
           
            
        }
        
        private void QuanLyTaiLieu_GUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
