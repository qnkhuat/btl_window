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
using QuanLyThuVien_BUS;
using QuanLyThuVien_DAL;
using QuanLyThuVien_DTO;
using QuanLyThuVien_GUI.BAO;

namespace QuanLyThuVien_GUI
{
    public partial class muonSach_GUI : Form
    {
        MuonSach_BUS dataMuon = new MuonSach_BUS();
        Regex rgPM = new Regex(@"PM[0-9]+");
        public static phieuMuon pm;
        public muonSach_GUI()
        {
            InitializeComponent();
        }
        //Load dữ liệu 
        public void loaddata()
        {
            viewphieumuon.DataSource = dataMuon.getphieuMuonlq();
        }
        private void muonSach_GUI_Load(object sender, EventArgs e)
        {
            viewphieumuon.AutoGenerateColumns = false;
            loaddata();
        }
        /*
        //Thêm
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtmadg.Text.Equals("") || txtmanv.Text.Equals("") || txtmapm.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin phiếu mượn đầy đủ");
            }
            else
            {
                Boolean checknv = true;
                Boolean checkdg = true;
                Boolean checkpm = true;
                //Kiểm tra xem có phiếu mượn này chưa
                SqlDataReader sdrpm = dataMuon.getPhieuMuon();
                while (sdrpm.Read())
                {
                    if (sdrpm.GetString(0).Equals(txtmapm.Text))
                    {
                        checkpm = checkpm && false;
                        break;
                    }
                }
                //Kiểm tra xem có nhân viên này không
                SqlDataReader sdrnv = dataMuon.getNhanVien();
                while (sdrnv.Read())
                {
                    if (sdrnv.GetString(0).Equals(txtmanv.Text))
                    {
                        checknv = checknv || true;
                        break;
                    }
                    else
                    {
                        checknv = checknv && false;
                    }
                }
                //Kiểm tra xem có độc giả này không
                SqlDataReader sdrdg = dataMuon.getDocGia();
                while (sdrdg.Read())
                {
                    if (sdrdg.GetString(0).Equals(txtmadg.Text))
                    {
                        checkdg = checkdg || true;
                        break;
                    }
                    else
                    {
                        checkdg = checkdg && false;
                    }
                }
                if (!checkpm)
                {
                    MessageBox.Show("Đã có phiếu mượn này");
                }
                else
                {
                    if (!checknv)
                    {
                        MessageBox.Show("Không có nhân viên này");
                    }
                    else
                    {
                        if (!checkdg)
                            MessageBox.Show("Không có độc giả này");
                        else
                        {

                            if (!rgPM.IsMatch(txtmapm.Text))
                            {
                                MessageBox.Show("Phiếu mượn phải bắt đầu là PM và theo sau là số !!!");
                            }
                            else
                            {
                                DateTime str = DateTime.Today.Date;
                                pm = new phieuMuon(txtmapm.Text, txtmadg.Text, str, txtmanv.Text);
                                dataMuon.addPhieuMuon(new phieuMuon(muonSach_GUI.pm.MaPM, muonSach_GUI.pm.MaDG, str.Date, muonSach_GUI.pm.MaNV));
                                ThemTLvaoPM ms = new ThemTLvaoPM();
                                ms.MdiParent = this.ParentForm;
                                ms.Show();
                                DataTable datb = dataMuon.getPhieuMuonTheoMa(muonSach_GUI.pm.MaPM);
                                if (!(datb.Rows.Count == 0))
                                {
                                    viewphieumuon.DataSource = datb;
                                }
                            }
                        }
                    }
                }
            }
        }
        //Xem
        private void btxem_Click(object sender, EventArgs e)
        {
            viewphieumuon.DataSource = dataMuon.getphieuMuonlq();
        }
        //Hiển thị dữ liệu lên textbox
        private void viewphieumuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.viewphieumuon.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtmapm.Text = row.Cells[0].Value.ToString();
                txtmadg.Text = row.Cells[1].Value.ToString();
                txttendg.Text = row.Cells[2].Value.ToString();
                txtmanv.Text = row.Cells[3].Value.ToString();
                txttennv.Text = row.Cells[4].Value.ToString();
            }
        }
        //Reset
        private void btnhaplai_Click(object sender, EventArgs e)
        {
            txtmapm.Text = "";
            txtmadg.Text = "";
            txttendg.Text = "";
            txtmanv.Text = "";
            txttennv.Text = "";
        }
        //Hiển thị nhân viên khi nhập mã nhân viên
        private void txtmanv_TextChanged(object sender, EventArgs e)
        {

            SqlDataReader sdr = dataMuon.getNhanVien();
            while (sdr.Read())
            {
                if (sdr.GetString(0).Equals(txtmanv.Text))
                {
                    txttennv.Text = sdr.GetString(1);
                    break;
                }
                else
                {
                    txttennv.Text = "";
                }
            }
        }
        //Hiển thị độc giả khi nhập mã độc giả
        private void txtmadg_TextChanged(object sender, EventArgs e)
        {
            SqlDataReader sdr = dataMuon.getDocGia();
            while (sdr.Read())
            {
                if (sdr.GetString(0).Equals(txtmadg.Text))
                {
                    txttendg.Text = sdr.GetString(1);
                    break;
                }
                else
                {
                    txttendg.Text = "";
                }
            }
        }
        //Tìm kiếm
        private void bttim_Click(object sender, EventArgs e)
        {
            Boolean checkpm = true;
            if (txtmapm.Text.Equals(""))
            {
                MessageBox.Show("Nhập mã phiếu mượn để tìm kiếm !!!");
            }
            else
            {
                SqlDataReader sdrpm = dataMuon.getPhieuMuon();
                while (sdrpm.Read())
                {
                    if (sdrpm.GetString(0).Equals(txtmapm.Text))
                    {
                        checkpm = checkpm || true;
                        break;
                    }
                    else
                    {
                        checkpm = checkpm && false;
                    }

                }
                if (checkpm) { viewphieumuon.DataSource = dataMuon.getPhieuMuonTheoMa(txtmapm.Text); }
                else { MessageBox.Show("Không có phiếu mượn này !!!"); }
            }
        }
        //Sửa
        private void btsua_Click(object sender, EventArgs e)
        {
            if (txtmadg.Text.Equals("") || txtmanv.Text.Equals("") || txtmapm.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin phiếu mượn đầy đủ");
            }
            else
            {
                Boolean checknv = true;
                Boolean checkdg = true;
                Boolean checkpm = true;
                //Kiểm tra xem có phiếu mượn này chưa
                SqlDataReader sdrpm = dataMuon.getPhieuMuon();
                while (sdrpm.Read())
                {
                    if (sdrpm.GetString(0).Equals(txtmapm.Text))
                    {
                        checkpm = checkpm || true;
                        break;
                    }
                    else
                    {
                        checkpm = checkpm && false;
                    }
                }
                //Kiểm tra xem có nhân viên này không
                SqlDataReader sdrnv = dataMuon.getNhanVien();
                while (sdrnv.Read())
                {
                    if (sdrnv.GetString(0).Equals(txtmanv.Text))
                    {
                        checknv = checknv || true;
                        break;
                    }
                    else
                    {
                        checknv = checknv && false;
                    }
                }
                //Kiểm tra xem có độc giả này không
                SqlDataReader sdrdg = dataMuon.getDocGia();
                while (sdrdg.Read())
                {
                    if (sdrdg.GetString(0).Equals(txtmadg.Text))
                    {
                        checkdg = checkdg || true;
                        break;
                    }
                    else
                    {
                        checkdg = checkdg && false;
                    }
                }
                if (!checkpm)
                {
                    MessageBox.Show("Không có phiếu mượn này");
                }
                else
                {
                    if (!checknv)
                    {
                        MessageBox.Show("Không có nhân viên này");
                    }
                    else
                    {
                        if (!checkdg)
                            MessageBox.Show("Không có độc giả này");
                        else
                        {

                            DateTime str = DateTime.Now;

                            dataMuon.updatephieumuon(new phieuMuon(txtmapm.Text, txtmadg.Text, str, txtmanv.Text));
                            viewphieumuon.DataSource = dataMuon.getphieuMuonlq();
                            //viewtlmuon.DataSource = dataMuon.gettlMuonlq();
                            MessageBox.Show("Sửa thành công !!!");
                            loaddata();
                        }
                    }

                }
            }
        }
        //Xóa
        private void btxoa_Click(object sender, EventArgs e)
        {
            Boolean checkpm = true;
            if (txtmapm.Text.Equals(""))
            {
                MessageBox.Show("Chưa nhập mã phiếu mượn!!!");
            }
            else
            {
                SqlDataReader sdrpm = dataMuon.getPhieuMuon();
                while (sdrpm.Read())
                {
                    if (sdrpm.GetString(0).Equals(txtmapm.Text))
                    {
                        checkpm = checkpm || true;
                        break;
                    }
                    else
                    {
                        checkpm = checkpm && false;
                    }

                }
                if (!checkpm) { MessageBox.Show("Không có phiếu mượn này !!!"); }
                else
                {
                    Boolean checktl = true;
                    //Check tài liệu chưa trả
                    SqlDataReader sdr = dataMuon.getPhieuMuonChiTietTheoMa(txtmapm.Text);
                    while (sdr.Read())
                    {
                        if (sdr.IsDBNull(3))
                        {
                            checktl = checktl && false;
                            break;
                        }
                    }
                    if (!checktl)
                    {
                        DialogResult dlr = MessageBox.Show("Có tài liệu mượn chưa trả! Bạn có chắc muốn xóa phiếu mượn này và những thứ liên quan!",
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlr == DialogResult.No)
                        {
                        }
                        else
                        {
                            SqlDataReader sdr2 = dataMuon.getPhieuMuonChiTietTheoMa(txtmapm.Text);
                            while (sdr2.Read())
                            {
                                if (sdr2.IsDBNull(3))
                                {
                                    dataMuon.updateSoLuongTLdelete(new phieuMuonChiTiet(sdr2.GetString(0), sdr2.GetString(1), sdr2.GetInt32(2)));
                                }
                            }
                            dataMuon.deletephieuMuonChiTiet(txtmapm.Text);
                            dataMuon.deletePhieuMuon(txtmapm.Text);
                            MessageBox.Show("Xóa thành công!!!");
                        }
                    }
                    else
                    {
                        DialogResult dlr = MessageBox.Show("Bạn muốn xóa phiếu mượn này à!",
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlr == DialogResult.Yes)
                        {
                            dataMuon.deletephieuMuonChiTiet(txtmapm.Text);
                            dataMuon.deletePhieuMuon(txtmapm.Text);
                            MessageBox.Show("Xóa thành công!!!");
                            loaddata();
                        }
                        else { }

                    }
                    viewphieumuon.DataSource = dataMuon.getphieuMuonlq();
                    //  viewtlmuon.DataSource = dataMuon.gettlMuonlq();
                }
            }
        }
        //Thoát
        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Hiển thị vào textbox khi nhập mã phiếu nhập
        private void txtmapm_TextChanged(object sender, EventArgs e)
        {
            SqlDataReader sdr = dataMuon.getPhieuMuon();
            while (sdr.Read())
            {
                if (sdr.GetString(0).Equals(txtmapm.Text))
                {
                    txtmadg.Text = sdr.GetString(1);
                    txtmanv.Text = sdr.GetString(3);
                    break;
                }
                else
                {
                    txtmadg.Text = "";
                    txtmanv.Text = "";
                }
            }


        }

        private void btsuapmct_Click(object sender, EventArgs e)
        {
            if (txtmapm.Text.Equals("") || txtmanv.Text.Equals("") || txtmadg.Text.Equals("") || txttendg.Text.Equals("") || txttennv.Text.Equals(""))
            {
                MessageBox.Show("Chưa chọn phiếu mượn!!!");
            }
            else
            {
                DateTime str = DateTime.Now;
                pm = new phieuMuon(txtmapm.Text, txtmadg.Text, str, txtmanv.Text);

                ThemTLvaoPM ms = new ThemTLvaoPM();
                ms.MdiParent = this.ParentForm;
                ms.Show();
            }
        }

        private void btdonpm_Click(object sender, EventArgs e)
        {
            int i = 0;
            DialogResult dlr = MessageBox.Show("Bạn có chắc muốn xóa tất cả các phiếu mượn rỗng hoặc phiếu mượn đã trả hết tài liệu",
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No)
            {
            }
            else
            {
                SqlDataReader sdrpm = dataMuon.getPhieuMuon();
                while (sdrpm.Read())
                {
                    SqlDataReader sdrpmct = dataMuon.getPhieuMuonChiTietTheoMa(sdrpm.GetString(0));
                    if (!sdrpmct.HasRows)
                    {
                        dataMuon.deletephieuMuonChiTiet(sdrpm.GetString(0));
                        dataMuon.deletePhieuMuon(sdrpm.GetString(0));
                        i++;
                    }
                    else
                    {
                        Boolean check1 = true;
                        while (sdrpmct.Read())
                        {
                            if (sdrpmct.IsDBNull(3))
                            {
                                check1 = check1 && false;
                                break;
                            }
                        }
                        if (check1)
                        {
                            dataMuon.deletephieuMuonChiTiet(sdrpm.GetString(0));
                            dataMuon.deletePhieuMuon(sdrpm.GetString(0));
                            i++;
                        }
                    }
                }
                MessageBox.Show("Đã dọn dẹp " + i + " phiếu mượn!!! ");
                loaddata();
            }
        }

        private void btin_Click(object sender, EventArgs e)
        {
           // PrintPM_GUI pr = new PrintPM_GUI();
          //  pr.ShowDialog();
        }
        */


        /////////////////////////////////////////////////////////////////////////////////////
        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtmadg.Text.Equals("") || txtmanv.Text.Equals("") || txtmapm.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin phiếu mượn đầy đủ");
            }
            else
            {
                Boolean checknv = true;
                Boolean checkdg = true;
                Boolean checkpm = true;
                //Kiểm tra xem có phiếu mượn này chưa
                SqlDataReader sdrpm = dataMuon.getPhieuMuon();
                while (sdrpm.Read())
                {
                    if (sdrpm.GetString(0).Equals(txtmapm.Text))
                    {
                        checkpm = checkpm && false;
                        break;
                    }
                }
                //Kiểm tra xem có nhân viên này không
                SqlDataReader sdrnv = dataMuon.getNhanVien();
                while (sdrnv.Read())
                {
                    if (sdrnv.GetString(0).Equals(txtmanv.Text))
                    {
                        checknv = checknv || true;
                        break;
                    }
                    else
                    {
                        checknv = checknv && false;
                    }
                }
                //Kiểm tra xem có độc giả này không
                SqlDataReader sdrdg = dataMuon.getDocGia();
                while (sdrdg.Read())
                {
                    if (sdrdg.GetString(0).Equals(txtmadg.Text))
                    {
                        checkdg = checkdg || true;
                        break;
                    }
                    else
                    {
                        checkdg = checkdg && false;
                    }
                }
                if (!checkpm)
                {
                    MessageBox.Show("Đã có phiếu mượn này");
                }
                else
                {
                    if (!checknv)
                    {
                        MessageBox.Show("Không có nhân viên này");
                    }
                    else
                    {
                        if (!checkdg)
                            MessageBox.Show("Không có độc giả này");
                        else
                        {

                            if (!rgPM.IsMatch(txtmapm.Text))
                            {
                                MessageBox.Show("Phiếu mượn phải bắt đầu là PM và theo sau là số !!!");
                            }
                            else
                            {
                                DateTime str = DateTime.Today.Date;
                                pm = new phieuMuon(txtmapm.Text, txtmadg.Text, str, txtmanv.Text);
                                dataMuon.addPhieuMuon(new phieuMuon(muonSach_GUI.pm.MaPM, muonSach_GUI.pm.MaDG, str.Date, muonSach_GUI.pm.MaNV));
                                ThemTLvaoPM ms = new ThemTLvaoPM();
                                ms.MdiParent = this.ParentForm;
                                ms.Show();
                                DataTable datb = dataMuon.getPhieuMuonTheoMa(muonSach_GUI.pm.MaPM);
                                if (!(datb.Rows.Count == 0))
                                {
                                    viewphieumuon.DataSource = datb;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btsua_Click_1(object sender, EventArgs e)
        {
            if (txtmadg.Text.Equals("") || txtmanv.Text.Equals("") || txtmapm.Text.Equals(""))
            {
                MessageBox.Show("Điền thông tin phiếu mượn đầy đủ");
            }
            else
            {
                Boolean checknv = true;
                Boolean checkdg = true;
                Boolean checkpm = true;
                //Kiểm tra xem có phiếu mượn này chưa
                SqlDataReader sdrpm = dataMuon.getPhieuMuon();
                while (sdrpm.Read())
                {
                    if (sdrpm.GetString(0).Equals(txtmapm.Text))
                    {
                        checkpm = checkpm || true;
                        break;
                    }
                    else
                    {
                        checkpm = checkpm && false;
                    }
                }
                //Kiểm tra xem có nhân viên này không
                SqlDataReader sdrnv = dataMuon.getNhanVien();
                while (sdrnv.Read())
                {
                    if (sdrnv.GetString(0).Equals(txtmanv.Text))
                    {
                        checknv = checknv || true;
                        break;
                    }
                    else
                    {
                        checknv = checknv && false;
                    }
                }
                //Kiểm tra xem có độc giả này không
                SqlDataReader sdrdg = dataMuon.getDocGia();
                while (sdrdg.Read())
                {
                    if (sdrdg.GetString(0).Equals(txtmadg.Text))
                    {
                        checkdg = checkdg || true;
                        break;
                    }
                    else
                    {
                        checkdg = checkdg && false;
                    }
                }
                if (!checkpm)
                {
                    MessageBox.Show("Không có phiếu mượn này");
                }
                else
                {
                    if (!checknv)
                    {
                        MessageBox.Show("Không có nhân viên này");
                    }
                    else
                    {
                        if (!checkdg)
                            MessageBox.Show("Không có độc giả này");
                        else
                        {

                            DateTime str = DateTime.Now;

                            dataMuon.updatephieumuon(new phieuMuon(txtmapm.Text, txtmadg.Text, str, txtmanv.Text));
                            viewphieumuon.DataSource = dataMuon.getphieuMuonlq();
                            //viewtlmuon.DataSource = dataMuon.gettlMuonlq();
                            MessageBox.Show("Sửa thành công !!!");
                            loaddata();
                        }
                    }

                }
            }
        }

        private void btxoa_Click_1(object sender, EventArgs e)
        {
            Boolean checkpm = true;
            if (txtmapm.Text.Equals(""))
            {
                MessageBox.Show("Chưa nhập mã phiếu mượn!!!");
            }
            else
            {
                SqlDataReader sdrpm = dataMuon.getPhieuMuon();
                while (sdrpm.Read())
                {
                    if (sdrpm.GetString(0).Equals(txtmapm.Text))
                    {
                        checkpm = checkpm || true;
                        break;
                    }
                    else
                    {
                        checkpm = checkpm && false;
                    }

                }
                if (!checkpm) { MessageBox.Show("Không có phiếu mượn này !!!"); }
                else
                {
                    Boolean checktl = true;
                    //Check tài liệu chưa trả
                    SqlDataReader sdr = dataMuon.getPhieuMuonChiTietTheoMa(txtmapm.Text);
                    while (sdr.Read())
                    {
                        if (sdr.IsDBNull(3))
                        {
                            checktl = checktl && false;
                            break;
                        }
                    }
                    if (!checktl)
                    {
                        DialogResult dlr = MessageBox.Show("Có tài liệu mượn chưa trả! Bạn có chắc muốn xóa phiếu mượn này và những thứ liên quan!",
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlr == DialogResult.No)
                        {
                        }
                        else
                        {
                            SqlDataReader sdr2 = dataMuon.getPhieuMuonChiTietTheoMa(txtmapm.Text);
                            while (sdr2.Read())
                            {
                                if (sdr2.IsDBNull(3))
                                {
                                    dataMuon.updateSoLuongTLdelete(new phieuMuonChiTiet(sdr2.GetString(0), sdr2.GetString(1), sdr2.GetInt32(2)));
                                }
                            }
                            dataMuon.deletephieuMuonChiTiet(txtmapm.Text);
                            dataMuon.deletePhieuMuon(txtmapm.Text);
                            MessageBox.Show("Xóa thành công!!!");
                            loaddata();
                        }
                    }
                    else
                    {
                        DialogResult dlr = MessageBox.Show("Bạn muốn xóa phiếu mượn này à!",
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dlr == DialogResult.Yes)
                        {
                            dataMuon.deletephieuMuonChiTiet(txtmapm.Text);
                            dataMuon.deletePhieuMuon(txtmapm.Text);
                            MessageBox.Show("Xóa thành công!!!");
                            loaddata();
                        }
                        else { }

                    }
                    viewphieumuon.DataSource = dataMuon.getphieuMuonlq();
                    //  viewtlmuon.DataSource = dataMuon.gettlMuonlq();
                }
            }
        }

        private void btsuapmct_Click_1(object sender, EventArgs e)
        {
            if (txtmapm.Text.Equals("") || txtmanv.Text.Equals("") || txtmadg.Text.Equals("") || txttendg.Text.Equals("") || txttennv.Text.Equals(""))
            {
                MessageBox.Show("Chưa chọn phiếu mượn!!!");
            }
            else
            {
                DateTime str = DateTime.Now;
                pm = new phieuMuon(txtmapm.Text, txtmadg.Text, str, txtmanv.Text);

                ThemTLvaoPM ms = new ThemTLvaoPM();
                ms.ShowDialog();
            }
        }

        private void btdonpm_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            DialogResult dlr = MessageBox.Show("Bạn có chắc muốn xóa tất cả các phiếu mượn rỗng hoặc phiếu mượn đã trả hết tài liệu",
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No)
            {
            }
            else
            {
                SqlDataReader sdrpm = dataMuon.getPhieuMuon();
                while (sdrpm.Read())
                {
                    SqlDataReader sdrpmct = dataMuon.getPhieuMuonChiTietTheoMa(sdrpm.GetString(0));
                    if (!sdrpmct.HasRows)
                    {
                        dataMuon.deletephieuMuonChiTiet(sdrpm.GetString(0));
                        dataMuon.deletePhieuMuon(sdrpm.GetString(0));
                        i++;
                    }
                    else
                    {
                        Boolean check1 = true;
                        while (sdrpmct.Read())
                        {
                            if (sdrpmct.IsDBNull(3))
                            {
                                check1 = check1 && false;
                                break;
                            }
                        }
                        if (check1)
                        {
                            dataMuon.deletephieuMuonChiTiet(sdrpm.GetString(0));
                            dataMuon.deletePhieuMuon(sdrpm.GetString(0));
                            i++;
                        }
                    }
                }
                MessageBox.Show("Đã dọn dẹp " + i + " phiếu mượn!!! ");
                loaddata();
            }
        }

        private void btnhaplai_Click_1(object sender, EventArgs e)
        {
            txtmapm.Text = "";
            txtmadg.Text = "";
            txttendg.Text = "";
            txtmanv.Text = "";
            txttennv.Text = "";
        }

        private void btthoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtmapm_TextChanged_1(object sender, EventArgs e)
        {
            SqlDataReader sdr = dataMuon.getPhieuMuon();
            while (sdr.Read())
            {
                if (sdr.GetString(0).Equals(txtmapm.Text))
                {
                    txtmadg.Text = sdr.GetString(1);
                    txtmanv.Text = sdr.GetString(3);
                    break;
                }
                else
                {
                    txtmadg.Text = "";
                    txtmanv.Text = "";
                }
            }
        }

        private void txtmadg_TextChanged_1(object sender, EventArgs e)
        {
            SqlDataReader sdr = dataMuon.getDocGia();
            while (sdr.Read())
            {
                if (sdr.GetString(0).Equals(txtmadg.Text))
                {
                    txttendg.Text = sdr.GetString(1);
                    break;
                }
                else
                {
                    txttendg.Text = "";
                }
            }
        }

        private void txtmanv_TextChanged_1(object sender, EventArgs e)
        {
            SqlDataReader sdr = dataMuon.getNhanVien();
            while (sdr.Read())
            {
                if (sdr.GetString(0).Equals(txtmanv.Text))
                {
                    txttennv.Text = sdr.GetString(1);
                    break;
                }
                else
                {
                    txttennv.Text = "";
                }
            }
        }

        private void viewphieumuon_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.viewphieumuon.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtmapm.Text = row.Cells[0].Value.ToString();
                txtmadg.Text = row.Cells[1].Value.ToString();
                txttendg.Text = row.Cells[2].Value.ToString();
                txtmanv.Text = row.Cells[3].Value.ToString();
                txttennv.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btxem_Click_1(object sender, EventArgs e)
        {
            viewphieumuon.DataSource = dataMuon.getphieuMuonlq();
        }

        private void bttim_Click_1(object sender, EventArgs e)
        {
            Boolean checkpm = true;
            if (txtmapm.Text.Equals(""))
            {
                MessageBox.Show("Nhập mã phiếu mượn để tìm kiếm !!!");
            }
            else
            {
                SqlDataReader sdrpm = dataMuon.getPhieuMuon();
                while (sdrpm.Read())
                {
                    if (sdrpm.GetString(0).Equals(txtmapm.Text))
                    {
                        checkpm = checkpm || true;
                        break;
                    }
                    else
                    {
                        checkpm = checkpm && false;
                    }

                }
                if (checkpm) { viewphieumuon.DataSource = dataMuon.getPhieuMuonTheoMa(txtmapm.Text); }
                else { MessageBox.Show("Không có phiếu mượn này !!!"); }
            }
        }
    }
}
