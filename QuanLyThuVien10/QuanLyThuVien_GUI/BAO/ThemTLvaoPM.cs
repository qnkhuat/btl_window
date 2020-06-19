using Microsoft.Reporting.WinForms;
using QuanLyThuVien_BUS;
using QuanLyThuVien_BUS.BAO;
using QuanLyThuVien_DTO;
using QuanLyThuVien_GUI.BAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyThuVien_GUI
{
    public partial class ThemTLvaoPM : Form
    {
        MuonSach_BUS dataMuon = new MuonSach_BUS();
        public static String matailieu = "";
        public static String mapm;
        public ThemTLvaoPM()
        {
            InitializeComponent();
        }
        //Check nhập sô lượng mượn
        Regex rgsl = new Regex("[0-9]+");
        //Load dữ liệu
        public void load()
        {
            view.DataSource = dataMuon.getphieuMuonChiTietlq(muonSach_GUI.pm.MaPM);
        }
        private void ThemTLvaoPM_Load(object sender, EventArgs e)
        {
            lbPM.Text = "Cập nhật phiếu mượn: " + muonSach_GUI.pm.MaPM;
            mapm = muonSach_GUI.pm.MaPM;
            load();
        }
        /*
        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        //Thêm
        private void btthem_Click(object sender, EventArgs e)
        {
            SqlDataReader sdr = dataMuon.getTaiLieu(txtmaTL.Text);
            if (sdr.HasRows)
            {
                sdr.Read();

                SqlDataReader sdr2 = dataMuon.getPhieuMuonChiTietTheoMa(muonSach_GUI.pm.MaPM, txtmaTL.Text);
                if (!sdr2.HasRows)
                {
                    int sl = sdr.GetInt32(3);
                    if (rgsl.IsMatch(txtsl.Text))
                    {
                        if (Int32.Parse(txtsl.Text) > sl)
                        {
                            MessageBox.Show("Không đủ sách!!! Chúng tôi chỉ còn " + sl + " cuốn");
                        }
                        else
                        {
                            dataMuon.updateSoLuongTLAdd(new phieuMuonChiTiet(muonSach_GUI.pm.MaPM, txtmaTL.Text, Int32.Parse(txtsl.Text)));

                            dataMuon.addPhieuMuonChiTiet(new phieuMuonChiTiet(muonSach_GUI.pm.MaPM, txtmaTL.Text, Int32.Parse(txtsl.Text)));
                            MessageBox.Show("Thêm thành công!!!");
                            load();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Điền Vào textbox Số Lượng Là Một Số lớn hơn 0 !!!");
                    }
                }
                else
                {
                    MessageBox.Show("Đã có tài liệu này trong phiếu mượn, Sửa nếu có thay đổi!!!");
                }
            }
            else
            {
                MessageBox.Show("Không Có Tài Liệu Này!!! hoặc textBox đang trống");
            }

        }

        //Xóa
        private void btbo_Click(object sender, EventArgs e)
        {
            SqlDataReader sdr = dataMuon.getPhieuMuonChiTietTheoMa(muonSach_GUI.pm.MaPM, txtmaTL.Text);
            if (!sdr.HasRows)
            {
                MessageBox.Show("Phiếu Mượn " + muonSach_GUI.pm.MaPM + " không chứa tài liệu này");
            }
            else
            {
                if (sdr.IsDBNull(3))
                {
                    DialogResult dlr = MessageBox.Show("Tài liệu mượn chưa trả! Bạn có chắc muốn bỏ tài liệu này khỏi phiếu mượn!",
                            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.No)
                    {
                    }
                    else
                    {
                        dataMuon.updateSoLuongTLdelete(new phieuMuonChiTiet(muonSach_GUI.pm.MaPM, matailieu, Int32.Parse(txtsl.Text)));
                        dataMuon.deletephieuMuonChiTiet(muonSach_GUI.pm.MaPM, matailieu);
                        MessageBox.Show("Xóa thành công!!!");
                        load();
                    }
                }
                else
                {
                    DialogResult dlr = MessageBox.Show("Bạn muốn xóa phiếu mượn chi tiết này?",
                                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.No)
                    {
                    }
                    else
                    {
                        dataMuon.deletephieuMuonChiTiet(muonSach_GUI.pm.MaPM, matailieu);
                        MessageBox.Show("Xóa thành công!!!");
                        load();
                    }
                }
            }
        }
        //Hiển thị từ datagridview lên
        private void view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.view.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtmaTL.Text = row.Cells[0].Value.ToString();
                txtsl.Text = row.Cells[2].Value.ToString();
            }
        }

        //Sửa
        private void btsua_Click(object sender, EventArgs e)
        {
            SqlDataReader sdr = dataMuon.getPhieuMuonChiTietTheoMa(muonSach_GUI.pm.MaPM, txtmaTL.Text);

            if (!sdr.HasRows)
            {
                MessageBox.Show("Phiếu mượn " + muonSach_GUI.pm.MaPM + " không chứa tài liệu này!!!");
            }
            else
            {
                SqlDataReader sdr2 = dataMuon.getTaiLieu(txtmaTL.Text);
                sdr2.Read();
                int sl = sdr2.GetInt32(3);
                int slcu = sdr.GetInt32(2);
                if (rgsl.IsMatch(txtsl.Text))
                {
                    if (sl < Int32.Parse(txtsl.Text) - slcu)
                    {
                        MessageBox.Show("Không đủ sách!!! Chúng tôi chỉ còn " + sl + " cuốn");
                    }
                    else
                    {
                        DialogResult dlr = MessageBox.Show("Bạn muốn sửa phiếu mượn chi tiết này!!!",
                                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlr == DialogResult.No)
                        {
                        }
                        else
                        {

                            dataMuon.updateSoLuongTLUpdate(slcu, Int32.Parse(txtsl.Text), txtmaTL.Text);
                            dataMuon.updatephieumuonchitiet(new phieuMuonChiTiet(muonSach_GUI.pm.MaPM, txtmaTL.Text, Int32.Parse(txtsl.Text)));
                            MessageBox.Show("Sửa thành công!!!");
                            load();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Điền vào một số lớn hơn 0 ở textbox số lượng !!!");
                }
            }
        }

        private void txtmaTL_TextChanged(object sender, EventArgs e)
        {
            SqlDataReader sdr = dataMuon.getPhieuMuonChiTietTheoMa(muonSach_GUI.pm.MaPM, txtmaTL.Text);

            if (sdr.HasRows)
            {
                sdr.Read();
                matailieu = txtmaTL.Text;
            }
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            txtmaTL.Text = "";
            txtsl.Text = "";
        }



        private void btIn_Click(object sender, EventArgs e)
        {
            //Kết xuất nguồn dữ liệu cho report
            //   rptPMvPMCt baocao = new rptPMvPMCt();
            //     baocao.SetDataSource(rppm.getReportPM(muonSach_GUI.pm.MaPM));
            //Hiển Thị Dữ Liệu
            //    PrintPM_GUI prf = new PrintPM_GUI();
            //    prf.reportViewer1.ReportSource = baocao;
            //    prf.ShowDialog();
        }
        */
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////


        ReportPM_BUS rppm = new ReportPM_BUS();
        private void btthoat_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btthem_Click_1(object sender, EventArgs e)
        {
            SqlDataReader sdr = dataMuon.getTaiLieu(txtmaTL.Text);
            if (sdr.HasRows)
            {
                sdr.Read();

                SqlDataReader sdr2 = dataMuon.getPhieuMuonChiTietTheoMa(muonSach_GUI.pm.MaPM, txtmaTL.Text);
                if (!sdr2.HasRows)
                {
                    int sl = sdr.GetInt32(3);
                    if (rgsl.IsMatch(txtsl.Text))
                    {
                        if (Int32.Parse(txtsl.Text) > sl)
                        {
                            MessageBox.Show("Không đủ sách!!! Chúng tôi chỉ còn " + sl + " cuốn");
                        }
                        else
                        {
                            dataMuon.updateSoLuongTLAdd(new phieuMuonChiTiet(muonSach_GUI.pm.MaPM, txtmaTL.Text, Int32.Parse(txtsl.Text)));

                            dataMuon.addPhieuMuonChiTiet(new phieuMuonChiTiet(muonSach_GUI.pm.MaPM, txtmaTL.Text, Int32.Parse(txtsl.Text)));
                            MessageBox.Show("Thêm thành công!!!");
                            load();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Điền Vào textbox Số Lượng Là Một Số lớn hơn 0 !!!");
                    }
                }
                else
                {
                    MessageBox.Show("Đã có tài liệu này trong phiếu mượn, Sửa nếu có thay đổi!!!");
                }
            }
            else
            {
                MessageBox.Show("Không Có Tài Liệu Này!!! hoặc textBox đang trống");
            }
        }

        private void btsua_Click_1(object sender, EventArgs e)
        {
            SqlDataReader sdr = dataMuon.getPhieuMuonChiTietTheoMa(muonSach_GUI.pm.MaPM, txtmaTL.Text);

            if (!sdr.HasRows)
            {
                MessageBox.Show("Phiếu mượn " + muonSach_GUI.pm.MaPM + " không chứa tài liệu này!!!");
            }
            else
            {
                SqlDataReader sdr2 = dataMuon.getTaiLieu(txtmaTL.Text);
                sdr2.Read();
                sdr.Read();
                int sl = sdr2.GetInt32(3);
                int slcu = sdr.GetInt32(2);
                if (rgsl.IsMatch(txtsl.Text))
                {
                    if (sl < Int32.Parse(txtsl.Text) - slcu)
                    {
                        MessageBox.Show("Không đủ sách!!! Chúng tôi chỉ còn " + sl + " cuốn");
                    }
                    else
                    {
                        DialogResult dlr = MessageBox.Show("Bạn muốn sửa phiếu mượn chi tiết này!!!",
                                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlr == DialogResult.No)
                        {
                        }
                        else
                        {

                            dataMuon.updateSoLuongTLUpdate(slcu, Int32.Parse(txtsl.Text), txtmaTL.Text);
                            dataMuon.updatephieumuonchitiet(new phieuMuonChiTiet(muonSach_GUI.pm.MaPM, txtmaTL.Text, Int32.Parse(txtsl.Text)));
                            MessageBox.Show("Sửa thành công!!!");
                            load();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Điền vào một số lớn hơn 0 ở textbox số lượng !!!");
                }
            }
        }

        private void btbo_Click_1(object sender, EventArgs e)
        {
            SqlDataReader sdr = dataMuon.getPhieuMuonChiTietTheoMa(muonSach_GUI.pm.MaPM, txtmaTL.Text);
            if (!sdr.HasRows)
            {
                MessageBox.Show("Phiếu Mượn " + muonSach_GUI.pm.MaPM + " không chứa tài liệu này");
            }
            else
            {
                sdr.Read();
                if (sdr.IsDBNull(3))
                {
                    DialogResult dlr = MessageBox.Show("Tài liệu mượn chưa trả! Bạn có chắc muốn bỏ tài liệu này khỏi phiếu mượn!",
                            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.No)
                    {
                    }
                    else
                    {
                        dataMuon.updateSoLuongTLdelete(new phieuMuonChiTiet(muonSach_GUI.pm.MaPM, matailieu, Int32.Parse(txtsl.Text)));
                        dataMuon.deletephieuMuonChiTiet(muonSach_GUI.pm.MaPM, matailieu);
                        MessageBox.Show("Xóa thành công!!!");
                        load();
                    }
                }
                else
                {
                    DialogResult dlr = MessageBox.Show("Bạn muốn xóa phiếu mượn chi tiết này?",
                                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.No)
                    {
                    }
                    else
                    {
                        dataMuon.deletephieuMuonChiTiet(muonSach_GUI.pm.MaPM, matailieu);
                        MessageBox.Show("Xóa thành công!!!");
                        load();
                    }
                }
            }
        }

        private void btreset_Click_1(object sender, EventArgs e)
        {
            txtmaTL.Text = "";
            txtsl.Text = "";
        }

        private void view_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.view.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtmaTL.Text = row.Cells[0].Value.ToString();
                txtsl.Text = row.Cells[2].Value.ToString();
            }
        }

        private void txtmaTL_TextChanged_1(object sender, EventArgs e)
        {
            SqlDataReader sdr = dataMuon.getPhieuMuonChiTietTheoMa(muonSach_GUI.pm.MaPM, txtmaTL.Text);

            if (sdr.HasRows)
            {
                sdr.Read();
                matailieu = txtmaTL.Text;
            }
        }

        private void btIn_Click_1(object sender, EventArgs e)
        {
           // Kết xuất nguồn dữ liệu cho report
               rptPM baocao = new rptPM();
               baocao.SetDataSource(rppm.getReportPM(muonSach_GUI.pm.MaPM));
          //  Hiển Thị Dữ Liệu
               PrintPM_GUI prf = new PrintPM_GUI();
               prf.reportViewer1.ReportSource = baocao;
               prf.ShowDialog();
        }
    }
}









   