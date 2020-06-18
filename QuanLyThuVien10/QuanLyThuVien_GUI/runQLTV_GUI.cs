using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QuanLyThuVien_GUI
{
    static class runQLTV_GUI
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            //Application.Run(new traSach_GUI());
            //Application.Run(new muonSach_GUI());
            Thread thread = new Thread(new ThreadStart(work));
            Thread thread2 = new Thread(new ThreadStart(work2));
            thread.Start();
            thread2.Start();
        }
        public static void work() 
        {
            Application.Run(new traSach_GUI());
        }
        public static void work2()
        {
            Application.Run(new muonSach_GUI());
=======
            Application.Run(new trangChu_GUI());
            

>>>>>>> 3bb1764584efddf9fa91f41580ca8d87d1bfb291
        }
    }
}
    