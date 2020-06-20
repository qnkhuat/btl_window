using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyThuVien_DTO
{
    public class phieuMuonChiTiet
    {
        private String maPM;
        private String maTL;
        private int slMuon;
        private DateTime? ngayTra;

        public phieuMuonChiTiet()
        {
        }

        public phieuMuonChiTiet(string maPM, string maTL, int slMuon)
        {
            this.MaPM = maPM;
            this.MaTL = maTL;
            this.SlMuon = slMuon;
            this.ngayTra = null;
        }
        public phieuMuonChiTiet(string maPM, string maTL, int slMuon, DateTime? ngayTra)
        {
            this.MaPM = maPM;
            this.MaTL = maTL;
            this.SlMuon = slMuon;
            this.NgayTra = ngayTra;
        }
        public string MaPM { get => maPM; set => maPM = value; }
        public string MaTL { get => maTL; set => maTL = value; }
        public int SlMuon { get => slMuon; set => slMuon = value; }
        public DateTime? NgayTra { get => ngayTra; set => ngayTra = value; }
    }
}
