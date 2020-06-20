using QuanLyThuVien_BUS;
using QuanLyThuVien_DTO;
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
    public partial class traSach_GUI : Form
    {
        phieuMuonChiTiet x = new phieuMuonChiTiet("", "", 0);
        public traSach_GUI()
        {
            InitializeComponent();
        }
        TraSach_BUS dataTra = new TraSach_BUS();
        public void load()
        {
            lbstatus.Text = "      ";
            txtmadg.Text = "";
            txtslmuon.Text = "";
            txtmaTL.Text = "";
            view.DataSource = dataTra.getphieuMuon_PMChiTietlq();
        }
        private void traSach_Load(object sender, EventArgs e)
        {
            load();
            view.AutoGenerateColumns = false;
        }
        /*
        private void btview_Click(object sender, EventArgs e)
        {
            load();
        }

        private void txtmadg_TextChanged(object sender, EventArgs e)
        {
            lbstatus.Text = "Các Tài Liệu Mượn Chưa Trả Của Độc Giả Có Mã : " + txtmadg.Text;
            if (!txtmadg.Text.Equals(""))
            {
                view.DataSource = dataTra.getphieuMuon_PMChiTietsql(txtmadg.Text);
            }
            else
            {
                load();
            }
        }

        private void view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lưu lại dòng dữ liệu vừa kích chọn
            DataGridViewRow row = view.Rows[e.RowIndex];
            x.MaPM = row.Cells[0].Value.ToString();
            x.MaTL = row.Cells[1].Value.ToString();
            txtmaTL.Text = row.Cells[1].Value.ToString();
            txtslmuon.Text = row.Cells[4].Value.ToString();
            txtmadg.Text = row.Cells[2].Value.ToString();
            x.SlMuon = Int32.Parse(txtslmuon.Text);
            x.NgayTra = DateTime.Now;
            //Đưa dữ liệu vào textbox
            //txtmapm.Text = row.Cells[0].Value.ToString();
            //   txtmadg.Text = row.Cells[1].Value.ToString();
            //  txttendg.Text = row.Cells[2].Value.ToString();
            //  txtmanv.Text = row.Cells[4].Value.ToString();
            //  txttennv.Text = row.Cells[5].Value.ToString();
        }
        private void bttrasach_Click(object sender, EventArgs e)
        {
            if (!x.MaPM.Equals(""))
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn trả tài liệu có mã: " + x.MaTL + " trong phiếu mượn có mã: " + x.MaPM,
                           "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.No)
                {
                }
                else
                {
                    dataTra.updateSoLuongTLtraSach(x);
                    dataTra.updatephieumuonchitiet(x);
                    load();
                }
            }
            else
            {
                MessageBox.Show("Chọn một tài liệu để trả!!!");
            }
        }
        */
        /// ////////////////////////////////////////////////////////////////////////////////////////////

        private void btview_Click_1(object sender, EventArgs e)
        {
            load();
        }

        private void bttrasach_Click_1(object sender, EventArgs e)
        {
            if (!x.MaPM.Equals(""))
            {
                DialogResult dlr = MessageBox.Show("Bạn muốn trả tài liệu có mã: " + x.MaTL + " trong phiếu mượn có mã: " + x.MaPM,
                           "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlr == DialogResult.No)
                {
                }
                else
                {
                    dataTra.updateSoLuongTLtraSach(x);
                    dataTra.updatephieumuonchitiet(x);
                    load();
                }
            }
            else
            {
                MessageBox.Show("Chọn một tài liệu để trả!!!");
            }
        }

        private void txtmadg_TextChanged_1(object sender, EventArgs e)
        {
            lbstatus.Text = "Các Tài Liệu Mượn Chưa Trả Của Độc Giả Có Mã : " + txtmadg.Text;
            if (!txtmadg.Text.Equals(""))
            {
                view.DataSource = dataTra.getphieuMuon_PMChiTietsql(txtmadg.Text);
            }
            else
            {
                load();
            }
        }

        private void view_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Lưu lại dòng dữ liệu vừa kích chọn
            DataGridViewRow row = view.Rows[e.RowIndex];
            x.MaPM = row.Cells[0].Value.ToString();
            x.MaTL = row.Cells[1].Value.ToString();
            txtmaTL.Text = row.Cells[1].Value.ToString();
            txtslmuon.Text = row.Cells[4].Value.ToString();
            txtmadg.Text = row.Cells[2].Value.ToString();
            x.SlMuon = Int32.Parse(txtslmuon.Text);
            x.NgayTra = DateTime.Now;
        }
    }
}
