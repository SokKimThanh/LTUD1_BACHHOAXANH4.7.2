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
                //ViDuPhanTrang logon = new ViDuPhanTrang();
                //FormUploadFilesReport logon = new FormUploadFilesReport();
                //FormHoaDon logon =  new FormHoaDon();
                //FormKhachHang logon = new FormKhachHang(); 
                //FormNhanVienAddEdit logon = new FormNhanVienAddEdit();
                Application.Run(logon);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}