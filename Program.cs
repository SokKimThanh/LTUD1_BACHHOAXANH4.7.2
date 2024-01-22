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
                // Tạo và hiển thị SplashForm
                FormSplash splashForm = new FormSplash();
                splashForm.Show();

                // Đợi một thời gian (ví dụ: 3 giây)
                System.Threading.Thread.Sleep(3000);

                // Đóng SplashForm
                splashForm.Close();

                // Tạo và hiển thị FormDangNhap
                FormDangNhap logon = new FormDangNhap();

                //FormMain logon = new FormMain();
                Application.Run(logon);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}