using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyThuVien_DAL;
using QuanLyThuVien_BUS;
using QuanLyThuVien_DTO;
using Microsoft.Reporting.WinForms;

namespace QuanLyThuVien_GUI
{
    public partial class ThongKeTaiLieuQuaHan_GUI : Form
    {
        ReportDataSource rp = new ReportDataSource();
        ThongKeQuaHan_BUS bus = new ThongKeQuaHan_BUS();
        DataTable dt;
        public ThongKeTaiLieuQuaHan_GUI()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            /*if (dtNgayM.Value.Equals("2/ 2/1999") || dtNgayT.Value.Equals(DateTime.Now.ToString("yyyy-MM-dd")))
            {
                DateTime dat = DateTime.Parse("02/02/1999");
                MessageBox.Show("Bạn chưa chọn ngày Mượn và ngày Trả! Ứng dụng sẽ xuất tài liệu ra từ đầu đến bây giờ");
                dt = new DataTable();
                dt = bus.SearchThongKe(dat.ToString("yyyy-MM-dd"), DateTime.Now.ToString("yyyy-MM-dd"));
                dgvThongKe.DataSource = dt;
            }
            else
            {*/
                dt = new DataTable();
                dt = bus.SearchThongKe(dtNgayM.Value.Date.ToString("yyyy-MM-dd"), dtNgayT.Value.Date.ToString("yyyy-MM-dd"));
                dgvThongKe.DataSource = dt;
           // }
        }

        private void ThongKeTaiLieuQuaHan_GUI_Load(object sender, EventArgs e)
        {
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvThongKe_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvThongKe.Rows.Count; i++)
            {
                dgvThongKe.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            List<ThongKeQuaHan> list = new List<ThongKeQuaHan>();
            for(int i = 0; i < dgvThongKe.Rows.Count; i++)
            {
                ThongKeQuaHan tk = new ThongKeQuaHan();
                tk.Sott = dgvThongKe.Rows[i].Cells[0].Value.ToString();
                tk.Madocgia = dgvThongKe.Rows[i].Cells[1].Value.ToString();
                tk.Tendocgia = dgvThongKe.Rows[i].Cells[2].Value.ToString();
                tk.Tentailieu = dgvThongKe.Rows[i].Cells[3].Value.ToString();   
                tk.Ngaymuon= dgvThongKe.Rows[i].Cells[4].Value.ToString();
                tk.SongayQH= dgvThongKe.Rows[i].Cells[5].Value.ToString();
                list.Add(tk);
            }
            rp.Name = "DataSet1";
            rp.Value = list;
            Report rc = new Report();
            
            rc.reportViewer1.LocalReport.DataSources.Clear();
            rc.reportViewer1.LocalReport.DataSources.Add(rp);
            rc.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien_GUI.QuangNgoc.Report1.rdlc";
            rc.reportViewer1.Refresh();
            rc.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    public class ThongKeQuaHan
    {
        string sott, madocgia, tendocgia, tentailieu, ngaymuon,songayQH;

        public string Sott { get => sott; set => sott = value; }
        public string Madocgia { get => madocgia; set => madocgia = value; }
        public string Tendocgia { get => tendocgia; set => tendocgia = value; }
        public string Tentailieu { get => tentailieu; set => tentailieu = value; }
        public string Ngaymuon { get => ngaymuon; set => ngaymuon = value; }
        public string SongayQH { get => songayQH; set => songayQH = value; }
    }
}
