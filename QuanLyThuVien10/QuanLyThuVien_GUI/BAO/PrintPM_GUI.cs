using QuanLyThuVien_BUS.BAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyThuVien_GUI.BAO
{
    public partial class PrintPM_GUI : Form
    {
        public PrintPM_GUI()
        {
            InitializeComponent();
        }
        ReportPM_BUS rppm = new ReportPM_BUS();
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrRpPhieuMuon crpm = new CrRpPhieuMuon();
            DataSet tbpm = rppm.getReportPM(ThemTLvaoPM.mapm);
            crpm.SetDataSource(tbpm.Tables[0]);
            crrpview.ReportSource = crpm;
            crrpview.RefreshReport();
        }
    }
}
