using LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.BanHang;
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
                System.Threading.Thread.Sleep(1000);

                // Đóng SplashForm
                splashForm.Close();

                // Tạo và hiển thị FormDangNhap
                FormDangNhap loginForm = new FormDangNhap();
                loginForm.ShowDialog();

                // Nếu đăng nhập thành công, hiển thị FormMain
                if (loginForm.LogonSuccessful)
                {
                    FormMain mainForm = new FormMain();
                    Application.Run(mainForm);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}