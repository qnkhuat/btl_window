using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyThuVien_DTO
{
   public class TheLoai_DTO
    {
        private string maThL_;
        private string tenThL_;
        private string ghiChu_;

        
        public string maThL
        {
            get { return maThL_; }
            set { maThL_ = value; }
        }
        public string tenThL
        {
            get { return tenThL_; }
            set { tenThL_ = value; }
        }
        public string ghiChu
        {
            get { return ghiChu_; }
            set { ghiChu_ = value; }
        }
        
    }
}
