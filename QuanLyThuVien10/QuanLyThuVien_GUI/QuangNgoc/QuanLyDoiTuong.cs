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
    public partial class QuanLyDoiTuong_GUI : Form
    {
        
        DoiTuong_BUS doituong = new DoiTuong_BUS();

        DataTable dtdoituong, dtTimKiem;
       


        public QuanLyDoiTuong_GUI()
        {
            InitializeComponent();
        }

        private void QuanLyTheLoai_GUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            dtdoituong = new DataTable();
            dtdoituong = doituong.ShowDoiTuong();
            dgvQuanLyTheLoai.DataSource = dtdoituong;

        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaDT.Text = "";
            txtTenDT.Text = "";
            txtMaDT.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (txtMaDT.Text == "")
                    MessageBox.Show("Bạn chưa nhập mã đối tượng, nhập lại");
                else if (txtTenDT.Text == "")
                    MessageBox.Show("Bạn chưa nhập tên đối tượng, xin nhập lại");
                else
                {
                    int dem = 0;
                    foreach(DataRow row in dtdoituong.Rows)
                    {
                        var check = row["maDT"].ToString().Trim();
                        if(txtMaDT.Text.Trim()==check)
                        {
                            dem++;
                            break;
                        }    

                    }   
                    if(dem==0)
                    {
                        doituong.InsertDoiTuong(txtMaDT.Text, txtTenDT.Text);
                        MessageBox.Show("Thêm thể loại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Mã đối tượng đã tồn tại, nhập lại", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            //}
            //catch(Exception)
            //{
            //    MessageBox.Show("khong them được đối tượng, thử lại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaDT.Text == "")
                    MessageBox.Show("Mã đối tượng không được bỏ trống");
                else if (txtTenDT.Text == "")
                    MessageBox.Show("Tên đối tượng không được bỏ trống");
                else
                {
                    int dem = 0;
                    foreach(DataRow row in dtdoituong.Rows)
                    {
                        foreach (DataColumn a in dtdoituong.Columns)
                        {
                            var check = row[a].ToString().Trim();
                            if(txtMaDT.Text.Trim()==check)
                            {
                                dem++;
                                break;
                            }    
                        }    
                            
                        
                    }
                    if (dem != 0)
                    {
                        doituong.UpdateDoiTuong(txtMaDT.Text, txtTenDT.Text);
                        QuanLyTheLoai_GUI_Load(sender, e);
                        MessageBox.Show("Cập nhật đối tượng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Mã đối tượng không tồn tại, nhập lại", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }    
            }
            catch(Exception)
            {
                MessageBox.Show("không cập nhật được đối tượng, nhập lại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tl;
            tl = (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question));
            if(tl==DialogResult.Yes)
             {
                doituong.DeleteDoiTuong(txtMaDT.Text.Trim());
                MessageBox.Show("Xóa thành công!");
                LoadData();
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
                this.Dispose();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dtTimKiem = new DataTable();
            dtTimKiem = doituong.SearchDoiTuong(txtTim.Text.Trim());
            dgvQuanLyTheLoai.DataSource = dtTimKiem;

        }

        private void dgvQuanLyTheLoai_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            int dong = e.RowIndex;
            txtMaDT.Text = dgvQuanLyTheLoai.Rows[dong].Cells[0].Value.ToString();
            txtTenDT.Text = dgvQuanLyTheLoai.Rows[dong].Cells[1].Value.ToString();
            
        }

        

        
    }
}
