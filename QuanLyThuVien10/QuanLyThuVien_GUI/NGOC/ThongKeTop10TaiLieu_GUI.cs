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
    public partial class ThongKeTop10TaiLieu_GUI : Form
    {
        ReportDataSource rp = new ReportDataSource();
        ThongKeTop10_BUS bus = new ThongKeTop10_BUS();
        DataTable dt;
        public ThongKeTop10TaiLieu_GUI()
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

        private void ThongKeTop10TaiLieu_GUI_Load(object sender, EventArgs e)
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
            List<ThongKe> list = new List<ThongKe>();
            for(int i = 0; i < dgvThongKe.Rows.Count; i++)
            {
                ThongKe tk = new ThongKe();
                tk.Sott = dgvThongKe.Rows[i].Cells[0].Value.ToString();
                tk.Tentailieu = dgvThongKe.Rows[i].Cells[1].Value.ToString();
                tk.Tentheloai= dgvThongKe.Rows[i].Cells[2].Value.ToString();
                tk.Ghichu= dgvThongKe.Rows[i].Cells[3].Value.ToString();
                tk.Slmuon= dgvThongKe.Rows[i].Cells[4].Value.ToString();
                tk.Matl= dgvThongKe.Rows[i].Cells[5].Value.ToString();
                list.Add(tk);
            }
            rp.Name = "DataSet1";
            rp.Value = list;
            Report rc = new Report();
            rc.reportViewer1.LocalReport.DataSources.Clear();
            rc.reportViewer1.LocalReport.DataSources.Add(rp);
            rc.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien_GUI.Report.rdlc";
            rc.ShowDialog();
        }
    }

    public class ThongKe
    {
        string sott, tentailieu, tentheloai, ghichu, slmuon,matl;

        public string Sott { get => sott; set => sott = value; }
        public string Tentailieu { get => tentailieu; set => tentailieu = value; }
        public string Tentheloai { get => tentheloai; set => tentheloai = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }
        public string Slmuon { get => slmuon; set => slmuon = value; }
        public string Matl { get => matl; set => matl = value; }
    }
}
