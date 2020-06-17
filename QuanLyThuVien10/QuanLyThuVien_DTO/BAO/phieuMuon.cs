using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyThuVien_DTO
{
    public class phieuMuon
    {
        private String maPM;
        private String maDG;
        private String maNV;
        private DateTime ngayMuon;

        public phieuMuon()
        {
        }

        public phieuMuon(string maPM, string maDG,DateTime ngayMuon,String maNV)
        {
            this.MaPM = maPM;
            this.MaDG = maDG;
            this.MaNV = maNV;
            this.NgayMuon = ngayMuon;
        }

        public string MaPM { get => maPM; set => maPM = value; }
        public string MaDG { get => maDG; set => maDG = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime NgayMuon { get => ngayMuon; set => ngayMuon = value; }
    }
}
