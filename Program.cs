using LTUD1_BACHHOAXANH472._7._2.ScreenMenu.HeThong;
using System;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    internal class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                //FormDangNhap logon = new FormDangNhap();
                FormMain logon = new FormMain();
                //FormUploadFilesReport logon = new FormUploadFilesReport();
                //FormHoaDon logon =  new FormHoaDon();
                //FormKhachHang logon = new FormKhachHang(); 
                //FormNhanVienAddEdit logon = new FormNhanVienAddEdit();
                Application.Run(logon);

                //Trần Minh Tuấn
                // vo tu

                //gi change
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}