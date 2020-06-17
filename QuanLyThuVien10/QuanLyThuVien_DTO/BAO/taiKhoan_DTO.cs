using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyThuVien_DAL
{
    public class taiKhoan_DTO
    {
        private String tenTK;

        public String TenTK
        {
            get { return tenTK; }
            set { tenTK = value; }
        }
        private String matKhau;

        public String MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        private String loaiTK;

        public String LoaiTK
        {
            get { return loaiTK; }
            set { loaiTK = value; }
        }

        public taiKhoan_DTO(string tenTK, string matKhau, string loaiTK)
        {

            TenTK = tenTK;

            MatKhau = matKhau;
            LoaiTK = loaiTK;

        }
    }

}
