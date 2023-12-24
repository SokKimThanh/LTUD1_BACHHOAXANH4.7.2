using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
namespace LTUD1_BACHHOAXANH472
{
    public partial class FormDangNhap : Form
    {
        private BackgroundWorker bw;
        SettingImageList loginImage;//cai dat hinh
        bool setSystemCharPassword = true;//an mat khau
        LoginController loginController = new LoginController();
        Session session = new Session();

        public FormDangNhap()
        {
            InitializeComponent();
            loginImage = new SettingImageList(imageListLogin);

            bw = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            bw.DoWork += bw_DoWork;
            bw.ProgressChanged += bw_ProgressChanged;
            bw.RunWorkerCompleted += bw_RunWorkerCompleted;
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

            txtUserName.Focus();
            txtPassword.UseSystemPasswordChar = true;// bật ẩn ký tự mật khẩu
            ptbShowHidePassword.Image = loginImage.getIcon("hidepassword", "png");//set hình con mắt đóng
            txtUserName.Text = session.Username != "" ? session.Username : "";
            lblKetQuaDangNhap.Visible = false;
            progressBar1.Visible = false;
        }

        private void btnLoginClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtUserName.BackColor = SystemColors.Control;
            tlpUsername.BackColor = SystemColors.Control;
            txtPassword.BackColor = RGB_COLORS.PrimaryPink;
            tlpPassword.BackColor = RGB_COLORS.PrimaryPink;
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.BackColor = RGB_COLORS.PrimaryPink;
            tlpUsername.BackColor = RGB_COLORS.PrimaryPink;
            tlpPassword.BackColor = SystemColors.Control;
            txtPassword.BackColor = SystemColors.Control;
        }
        private void OtherEvent(object sender, EventArgs e)
        {
            txtUserName_Click(sender, e);
            progressBar1.Visible = false;
            lblKetQuaDangNhap.Visible = false;
        }


        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.ForeColor = RGB_COLORS.DarkGreen;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.ForeColor = Color.White;
        }



        private void ptbShowHidePassword_Click(object sender, EventArgs e)
        {

            PictureBox ptb = (PictureBox)sender;
            if (txtPassword.Text.Length > 0)
            {
                // cho phép hiện paswordd
                if (setSystemCharPassword)
                {
                    txtPassword.UseSystemPasswordChar = false;
                    ptb.Image = loginImage.getIcon("showpassword", "png");
                    setSystemCharPassword = false;//show 
                }
                else
                {
                    // nhấn lần nữa để ẩn đi matkhau
                    txtPassword.UseSystemPasswordChar = true;
                    ptb.Image = loginImage.getIcon("hidepassword", "png");
                    setSystemCharPassword = true;//hide
                }
            }
            //TH: chưa nhập mật khẩu thì vẫn là không cho hiện
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                ptb.Image = loginImage.getIcon("showpassword", "png");
                setSystemCharPassword = false;//show 
            }
        }
        public bool VerifyAccount(string enteredUserName, string enteredPassword)
        {
            lblKetQuaDangNhap.Visible = true;// hiển thị label và kết quả đăng nhập
            if (loginController.DangNhap(enteredUserName, enteredPassword) == 1)
            {
                // xác minh nhân vien dăng nhập và quyền đăng nhập
                //loginController.CapQuyen(enteredUserName, enteredPassword);
                return true;// dang nhap thanh cong
            }
            else
            {
                lblKetQuaDangNhap.Text = "Đăng nhập thất bại";
                return false;// dang nhap that bai
            }

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Vui lòng gõ tên đăng nhập");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
            }
            else
            {
                if (VerifyAccount(txtUserName.Text, txtPassword.Text))
                {
                    // Hiển thị ProgressBar
                    progressBar1.Visible = true;

                    // Khởi chạy BackgroundWorker
                    if (!bw.IsBusy)
                    {
                        bw.RunWorkerAsync();
                    }
                }
            }
        }
        /// <summary>
        /// Sau khi đăng xuất thì xóa trống tất cả
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormDangNhap_Shown(object sender, EventArgs e)
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUserName.Focus();
            OtherEvent(sender, e);
        }
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                // Chờ 10 mili giây
                System.Threading.Thread.Sleep(10);

                // Báo cáo tiến trình
                bw.ReportProgress(i);
            }
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Cập nhật giá trị của ProgressBar
            progressBar1.Value = e.ProgressPercentage;
        }


        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Ẩn ProgressBar
            progressBar1.Visible = false;

            session.Username = txtUserName.Text;
            DialogResult = DialogResult.OK;
            loginController.LogonSuccessful = true;
            lblKetQuaDangNhap.Text = "Đăng nhập thành công";
            // tắt form đăng nhập
            this.Hide();
            // tạo mới form chính
            FormMain main = new FormMain(session);

            // hiển thị form chính nhưng khi nào xử lý xong thì mới quay lại đây làm tiếp
            main.ShowDialog();
            //btn out kiểm tra coi là bấm thoát luôn hay là bấm đăng xuất
            //Nếu vẫn chưa thoát thì đăng nhập
            if (!main.btn_out)
            {
                // hiển thị form đăng nhập
                this.Show();
                txtUserName.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtUserName.Focus();
                OtherEvent(sender, e);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
