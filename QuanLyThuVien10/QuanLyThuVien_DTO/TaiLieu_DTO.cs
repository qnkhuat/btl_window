using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyThuVien_DTO
{
    public class TaiLieu_DTO
    {
        string ma, ten, MaThL,NhaXB,TacGia;
        int sl;
        int NamXB;
        public TaiLieu_DTO()
        {

        }
        public TaiLieu_DTO(string ma, string ten, string MaThL, string NhaXB, string TacGia, int sl, int NamXB)
        {
            this.ma = ma;
            this.ten = ten;
            this.MaThL = MaThL;
            this.NhaXB = NhaXB;
            this.NhaXB = NhaXB;
            this.TacGia = TacGia;
            this.sl = sl;
            
        }
        public string maTL { get => ma; set => ma = value; }
        public string tenTL { get => ten; set => ten = value; }
        public string maThL { get => MaThL; set =>MaThL= value; }
        public string nhaXB { get => NhaXB; set => NhaXB = value; }
        public string tacGia { get => TacGia; set => TacGia = value; }
        public int soLuong { get => sl; set => sl = value; }
        public int namXb { get => NamXB; set => NamXB = value; }

    }
}
