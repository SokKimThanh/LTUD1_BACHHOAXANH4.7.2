using System;
using System.Drawing;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    public partial class FormDangNhap : Form
    {
        SettingImageList loginImage;//cai dat hinh
        bool setSystemCharPassword = true;//an mat khau
        bool logonSuccessful = false;

        Session session = new Session();

        public bool LogonSuccessful { get => logonSuccessful; set => logonSuccessful = value; }

        public FormDangNhap()
        {
            InitializeComponent();
            loginImage = new SettingImageList(imageListLogin);
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

            txtUserName.Focus();
            txtPassword.UseSystemPasswordChar = true;// bật ẩn ký tự mật khẩu
            ptbShowHidePassword.Image = loginImage.getIcon("hidepassword", "png");//set hình con mắt đóng
            txtUserName.Text = session.Username != "" ? session.Username : "";
        }

        private void btnLoginClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtUserName.BackColor = SystemColors.Control;
            pnUsername.BackColor = SystemColors.Control;
            txtPassword.BackColor = RGB_COLORS.PrimaryPink;
            pnPassword.BackColor = RGB_COLORS.PrimaryPink;
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            txtUserName.BackColor = RGB_COLORS.PrimaryPink;
            pnUsername.BackColor = RGB_COLORS.PrimaryPink;
            pnPassword.BackColor = SystemColors.Control;
            txtPassword.BackColor = SystemColors.Control;
        }
        private void OtherEvent(object sender, EventArgs e)
        {
            txtUserName_Click(sender, e);
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {

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
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {


        }
        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {

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
            string[] username = { "a", "admin", "NgoQuy234", "VoTu232", "ThanhSok231" };
            string[] password = { "a", "admin", "ngoquytdc123", "votutdc123", "thanhsoktdc123" };

            //int enteredUserName = 123144;
            //string enteredPassword = "NewYork";

            // Tìm chỉ mục từ mảng tên người dùng
            var indexResult = Array.FindIndex(username, u => u == enteredUserName);

            if (indexResult == -1)
            {
                return false;
            }

            // So sánh mật khẩu từ chỉ mục đó.
            if (password[indexResult] == enteredPassword)
            {
                return true;
            }
            else
            {
                return false;
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
                    session.Username = txtUserName.Text;
                    DialogResult = DialogResult.OK;
                    LogonSuccessful = true;

                    // tắt form đăng nhập
                    this.Hide();
                    // tạo mới form chính
                    FormMain main = new FormMain
                    {
                        Session = session
                    };
                    // hiển thị form  chính nhưng khi nào xử lý xong thì mới quay lại đây làm tiếp
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
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
