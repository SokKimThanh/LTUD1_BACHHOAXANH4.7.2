using System.Windows.Forms;
namespace LTUD1_BACHHOAXANH472
{
    partial class FormDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.imageListLogin = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnLoginClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnForgotPassword = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblKetQuaDangNhap = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.goldenratio = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpUsername = new System.Windows.Forms.TableLayoutPanel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tlpPassword = new System.Windows.Forms.TableLayoutPanel();
            this.ptbShowHidePassword = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.goldenratio.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlpUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tlpPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbShowHidePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListLogin
            // 
            this.imageListLogin.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLogin.ImageStream")));
            this.imageListLogin.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLogin.Images.SetKeyName(0, "hidepassword.png");
            this.imageListLogin.Images.SetKeyName(1, "showpassword.png");
            this.imageListLogin.Images.SetKeyName(2, "green_password.png");
            this.imageListLogin.Images.SetKeyName(3, "green_user.png");
            // 
            // btnLoginClose
            // 
            this.btnLoginClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoginClose.FlatAppearance.BorderSize = 0;
            this.btnLoginClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnLoginClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoginClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginClose.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnLoginClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.btnLoginClose.Location = new System.Drawing.Point(310, 0);
            this.btnLoginClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoginClose.Name = "btnLoginClose";
            this.btnLoginClose.Size = new System.Drawing.Size(33, 32);
            this.btnLoginClose.TabIndex = 9;
            this.btnLoginClose.Text = "X";
            this.btnLoginClose.UseVisualStyleBackColor = true;
            this.btnLoginClose.Click += new System.EventHandler(this.btnLoginClose_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label4, 3);
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.label4.Location = new System.Drawing.Point(0, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "XIN BẠN VUI LÒNG ĐĂNG NHẬP";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(8, 185);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(8, 16, 8, 16);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(139, 66);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            this.btnLogin.MouseHover += new System.EventHandler(this.btnLogin_MouseHover);
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnForgotPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForgotPassword.FlatAppearance.BorderSize = 0;
            this.btnForgotPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnForgotPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgotPassword.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.btnForgotPassword.Location = new System.Drawing.Point(158, 185);
            this.btnForgotPassword.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.Size = new System.Drawing.Size(149, 66);
            this.btnForgotPassword.TabIndex = 13;
            this.btnForgotPassword.Text = "Quên mật khẩu?";
            this.btnForgotPassword.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.label9.ForeColor = System.Drawing.Color.DarkGray;
            this.label9.Location = new System.Drawing.Point(3, 270);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Hỗ trợ phần mềm:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.SetColumnSpan(this.label10, 2);
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(3, 294);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(304, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "Cần hỗ trợ phần mềm hoặc đặt câu hỏi xin vui lòng";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.label11.ForeColor = System.Drawing.Color.DarkGray;
            this.label11.Location = new System.Drawing.Point(3, 318);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 41);
            this.label11.TabIndex = 7;
            this.label11.Text = "Gửi email về địa chỉ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.linkLabel1, 2);
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(155, 315);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(188, 47);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "22211tt0063@mail.tdc.edu.vn";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKetQuaDangNhap
            // 
            this.lblKetQuaDangNhap.AutoSize = true;
            this.lblKetQuaDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKetQuaDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.lblKetQuaDangNhap.Location = new System.Drawing.Point(158, 153);
            this.lblKetQuaDangNhap.Name = "lblKetQuaDangNhap";
            this.lblKetQuaDangNhap.Size = new System.Drawing.Size(149, 16);
            this.lblKetQuaDangNhap.TabIndex = 16;
            this.lblKetQuaDangNhap.Text = "Đăng nhập thành công!!!";
            this.lblKetQuaDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKetQuaDangNhap.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 156);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(149, 10);
            this.progressBar1.TabIndex = 17;
            // 
            // goldenratio
            // 
            this.goldenratio.ColumnCount = 2;
            this.goldenratio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.02439F));
            this.goldenratio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.97561F));
            this.goldenratio.Controls.Add(this.panel1, 0, 0);
            this.goldenratio.Controls.Add(this.panel2, 1, 0);
            this.goldenratio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goldenratio.Location = new System.Drawing.Point(0, 0);
            this.goldenratio.Margin = new System.Windows.Forms.Padding(0);
            this.goldenratio.Name = "goldenratio";
            this.goldenratio.RowCount = 1;
            this.goldenratio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.goldenratio.Size = new System.Drawing.Size(562, 362);
            this.goldenratio.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 362);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 314);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(219, 48);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.label7.Location = new System.Drawing.Point(11, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "QTT Galaxy T E C H N O L O G Y";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.label6.Location = new System.Drawing.Point(11, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phát triển bởi NHÓM CÔNG NGHỆ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(219, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 362);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.Controls.Add(this.tlpUsername, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnLoginClose, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblKetQuaDangNhap, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.linkLabel1, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.progressBar1, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.btnLogin, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.btnForgotPassword, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tlpPassword, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.63492F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.36508F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(343, 362);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // tlpUsername
            // 
            this.tlpUsername.ColumnCount = 3;
            this.tableLayoutPanel2.SetColumnSpan(this.tlpUsername, 3);
            this.tlpUsername.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpUsername.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUsername.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpUsername.Controls.Add(this.txtUserName, 0, 0);
            this.tlpUsername.Controls.Add(this.pictureBox4, 0, 0);
            this.tlpUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUsername.Location = new System.Drawing.Point(0, 89);
            this.tlpUsername.Margin = new System.Windows.Forms.Padding(0);
            this.tlpUsername.Name = "tlpUsername";
            this.tlpUsername.RowCount = 1;
            this.tlpUsername.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUsername.Size = new System.Drawing.Size(343, 32);
            this.tlpUsername.TabIndex = 22;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Snow;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserName.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.txtUserName.Location = new System.Drawing.Point(37, 0);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(0);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(269, 32);
            this.txtUserName.TabIndex = 17;
            this.txtUserName.Click += new System.EventHandler(this.txtUserName_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox4.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.green_user;
            this.pictureBox4.InitialImage = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_small_user;
            this.pictureBox4.Location = new System.Drawing.Point(5, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // tlpPassword
            // 
            this.tlpPassword.ColumnCount = 3;
            this.tableLayoutPanel2.SetColumnSpan(this.tlpPassword, 3);
            this.tlpPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpPassword.Controls.Add(this.ptbShowHidePassword, 0, 0);
            this.tlpPassword.Controls.Add(this.txtPassword, 0, 0);
            this.tlpPassword.Controls.Add(this.pictureBox3, 0, 0);
            this.tlpPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPassword.Location = new System.Drawing.Point(0, 121);
            this.tlpPassword.Margin = new System.Windows.Forms.Padding(0);
            this.tlpPassword.Name = "tlpPassword";
            this.tlpPassword.RowCount = 1;
            this.tlpPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPassword.Size = new System.Drawing.Size(343, 32);
            this.tlpPassword.TabIndex = 19;
            // 
            // ptbShowHidePassword
            // 
            this.ptbShowHidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbShowHidePassword.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbShowHidePassword.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.showpassword;
            this.ptbShowHidePassword.Location = new System.Drawing.Point(306, 0);
            this.ptbShowHidePassword.Margin = new System.Windows.Forms.Padding(0);
            this.ptbShowHidePassword.Name = "ptbShowHidePassword";
            this.ptbShowHidePassword.Size = new System.Drawing.Size(32, 32);
            this.ptbShowHidePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbShowHidePassword.TabIndex = 18;
            this.ptbShowHidePassword.TabStop = false;
            this.ptbShowHidePassword.Click += new System.EventHandler(this.ptbShowHidePassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Snow;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.txtPassword.Location = new System.Drawing.Point(37, 0);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(269, 26);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.green_password;
            this.pictureBox3.Location = new System.Drawing.Point(5, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 362);
            this.ControlBox = false;
            this.Controls.Add(this.goldenratio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.Shown += new System.EventHandler(this.FormDangNhap_Shown);
            this.goldenratio.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tlpUsername.ResumeLayout(false);
            this.tlpUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tlpPassword.ResumeLayout(false);
            this.tlpPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbShowHidePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ImageList imageListLogin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnLoginClose;
        private Label label4;
        public Button btnLogin;
        public Button btnForgotPassword;
        private Label label9;
        private Label label10;
        private Label label11;
        private LinkLabel linkLabel1;
        private Label lblKetQuaDangNhap;
        private ProgressBar progressBar1;
        private TableLayoutPanel goldenratio;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label7;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tlpPassword;
        private PictureBox ptbShowHidePassword;
        private TextBox txtPassword;
        private PictureBox pictureBox3;
        private TableLayoutPanel tlpUsername;
        private TextBox txtUserName;
        private PictureBox pictureBox4;
    }
}