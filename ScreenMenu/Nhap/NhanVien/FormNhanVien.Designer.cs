using System.Drawing;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.Screen
{
    partial class FormNhanVien
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
            components = new System.ComponentModel.Container();
            groupBox18 = new GroupBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            groupBox19 = new GroupBox();
            textBox5 = new TextBox();
            groupBox20 = new GroupBox();
            textBox6 = new TextBox();
            tblNhanVien = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            dgvNhanVien = new DataGridView();
            cmsNhanVien = new ContextMenuStrip(components);
            tsmThongKe = new ToolStripMenuItem();
            tsmInFilePDF = new ToolStripMenuItem();
            tsmXuatFileExcel = new ToolStripMenuItem();
            groupBox14 = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnEdit = new Button();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnTimKiem = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox5 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            rbNam = new RadioButton();
            rbNu = new RadioButton();
            groupBox2 = new GroupBox();
            txtLuong = new TextBox();
            groupBox9 = new GroupBox();
            txtHoTenNV = new TextBox();
            groupBox8 = new GroupBox();
            txtSDT = new TextBox();
            groupBox7 = new GroupBox();
            rptNgaySinh = new DateTimePicker();
            groupBox6 = new GroupBox();
            rtbDiaChi = new RichTextBox();
            groupBox4 = new GroupBox();
            cboPhongBan = new ComboBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            saveFileDialog1 = new SaveFileDialog();
            txtHoTen = new TextBox();
            tableLayoutPanel7.SuspendLayout();
            groupBox19.SuspendLayout();
            groupBox20.SuspendLayout();
            tblNhanVien.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            cmsNhanVien.SuspendLayout();
            groupBox14.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox18
            // 
            groupBox18.Location = new Point(0, 0);
            groupBox18.Name = "groupBox18";
            groupBox18.Size = new Size(200, 100);
            groupBox18.TabIndex = 0;
            groupBox18.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(groupBox19, 0, 2);
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 3;
            tableLayoutPanel7.Size = new Size(200, 100);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // groupBox19
            // 
            groupBox19.Controls.Add(textBox5);
            groupBox19.Dock = DockStyle.Fill;
            groupBox19.ForeColor = Color.White;
            groupBox19.Location = new Point(3, 3);
            groupBox19.Name = "groupBox19";
            groupBox19.Size = new Size(194, 94);
            groupBox19.TabIndex = 12;
            groupBox19.TabStop = false;
            groupBox19.Text = "Họ tên";
            // 
            // textBox5
            // 
            textBox5.Dock = DockStyle.Fill;
            textBox5.Location = new Point(3, 22);
            textBox5.Margin = new Padding(5);
            textBox5.Name = "textBox5";
            //textBox5.PlaceholderText = "Họ và tên";
            textBox5.Size = new Size(188, 26);
            textBox5.TabIndex = 5;
            // 
            // groupBox20
            // 
            groupBox20.Controls.Add(textBox6);
            groupBox20.Dock = DockStyle.Fill;
            groupBox20.ForeColor = Color.White;
            groupBox20.Location = new Point(3, 86);
            groupBox20.Name = "groupBox20";
            groupBox20.Size = new Size(194, 77);
            groupBox20.TabIndex = 11;
            groupBox20.TabStop = false;
            groupBox20.Text = "Số điện thoại";
            // 
            // textBox6
            // 
            textBox6.Dock = DockStyle.Fill;
            textBox6.Location = new Point(3, 22);
            textBox6.Margin = new Padding(5);
            textBox6.Name = "textBox6";
            //textBox6.PlaceholderText = "số điện thoại";
            textBox6.Size = new Size(188, 26);
            textBox6.TabIndex = 9;
            // 
            // tblNhanVien
            // 
            tblNhanVien.ColumnCount = 1;
            tblNhanVien.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblNhanVien.Controls.Add(groupBox3, 0, 1);
            tblNhanVien.Controls.Add(groupBox14, 0, 2);
            tblNhanVien.Controls.Add(tableLayoutPanel1, 0, 0);
            tblNhanVien.Dock = DockStyle.Fill;
            tblNhanVien.Location = new Point(388, 3);
            tblNhanVien.Name = "tblNhanVien";
            tblNhanVien.RowCount = 3;
            tblNhanVien.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1715078F));
            tblNhanVien.RowStyles.Add(new RowStyle(SizeType.Percent, 68.7413559F));
            tblNhanVien.RowStyles.Add(new RowStyle(SizeType.Percent, 18.9463253F));
            tblNhanVien.Size = new Size(893, 723);
            tblNhanVien.TabIndex = 6;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvNhanVien);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(3, 91);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(887, 491);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.ContextMenuStrip = cmsNhanVien;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(3, 35);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.Size = new Size(881, 453);
            dgvNhanVien.TabIndex = 0;
            // 
            // cmsNhanVien
            // 
            cmsNhanVien.BackColor = SystemColors.ActiveBorder;
            cmsNhanVien.Items.AddRange(new ToolStripItem[] { tsmThongKe, tsmInFilePDF, tsmXuatFileExcel });
            cmsNhanVien.Name = "contextMenuStrip1";
            cmsNhanVien.Size = new Size(164, 76);
            // 
            // tsmThongKe
            // 
            tsmThongKe.BackColor = Color.FromArgb(255, 192, 192);
            tsmThongKe.Name = "tsmThongKe";
            tsmThongKe.Size = new Size(163, 24);
            tsmThongKe.Text = "Thống kê";
            tsmThongKe.Click += tsmThongKe_Click;
            // 
            // tsmInFilePDF
            // 
            tsmInFilePDF.BackColor = Color.FromArgb(255, 192, 192);
            tsmInFilePDF.Name = "tsmInFilePDF";
            tsmInFilePDF.Size = new Size(163, 24);
            tsmInFilePDF.Text = "Xuất File PDF";
            tsmInFilePDF.Click += tsmInFilePDF_Click;
            // 
            // tsmXuatFileExcel
            // 
            tsmXuatFileExcel.BackColor = Color.FromArgb(255, 192, 192);
            tsmXuatFileExcel.Name = "tsmXuatFileExcel";
            tsmXuatFileExcel.Size = new Size(163, 24);
            tsmXuatFileExcel.Text = "Xuất File Excel";
            tsmXuatFileExcel.Click += tsmInFileExcel_Click;
            // 
            // groupBox14
            // 
            groupBox14.Controls.Add(tableLayoutPanel6);
            groupBox14.Dock = DockStyle.Fill;
            groupBox14.ForeColor = Color.White;
            groupBox14.Location = new Point(3, 588);
            groupBox14.Name = "groupBox14";
            groupBox14.Size = new Size(887, 132);
            groupBox14.TabIndex = 8;
            groupBox14.TabStop = false;
            groupBox14.Text = "Thao tác dữ liệu";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 6;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel6.Controls.Add(btnEdit, 0, 0);
            tableLayoutPanel6.Controls.Add(btnRefresh, 0, 0);
            tableLayoutPanel6.Controls.Add(btnDelete, 0, 0);
            tableLayoutPanel6.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel6.Location = new Point(3, 35);
            tableLayoutPanel6.Margin = new Padding(5);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 162F));
            tableLayoutPanel6.Size = new Size(881, 94);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.FlatAppearance.BorderSize = 3;
            btnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.SeaShell;
            btnEdit.Location = new Point(297, 5);
            btnEdit.Margin = new Padding(5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(136, 84);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.Dock = DockStyle.Fill;
            btnRefresh.FlatAppearance.BorderSize = 3;
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.SeaShell;
            btnRefresh.Location = new Point(443, 5);
            btnRefresh.Margin = new Padding(5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(136, 84);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FlatAppearance.BorderSize = 3;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.SeaShell;
            btnDelete.Location = new Point(5, 5);
            btnDelete.Margin = new Padding(5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 84);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.FlatAppearance.BorderSize = 3;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.SeaShell;
            btnAdd.Location = new Point(151, 5);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 84);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.60124F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.3987579F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(txtHoTen, 0, 0);
            tableLayoutPanel1.Controls.Add(btnTimKiem, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(887, 82);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.Transparent;
            btnTimKiem.Dock = DockStyle.Fill;
            btnTimKiem.FlatAppearance.BorderSize = 3;
            btnTimKiem.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnTimKiem.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.ForeColor = Color.SeaShell;
            btnTimKiem.Location = new Point(604, 5);
            btnTimKiem.Margin = new Padding(5);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(278, 72);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(tblNhanVien, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1284, 729);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 723);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBox5, 0, 6);
            tableLayoutPanel2.Controls.Add(groupBox2, 0, 5);
            tableLayoutPanel2.Controls.Add(groupBox9, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox8, 0, 3);
            tableLayoutPanel2.Controls.Add(groupBox7, 0, 2);
            tableLayoutPanel2.Controls.Add(groupBox6, 0, 4);
            tableLayoutPanel2.Controls.Add(groupBox4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 35);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(373, 685);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(flowLayoutPanel1);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(3, 513);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(367, 79);
            groupBox5.TabIndex = 0;
            groupBox5.TabStop = false;
            groupBox5.Text = "Giới tính";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(rbNam);
            flowLayoutPanel1.Controls.Add(rbNu);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 35);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(16, 0, 16, 0);
            flowLayoutPanel1.Size = new Size(361, 41);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // rbNam
            // 
            rbNam.AutoSize = true;
            rbNam.Location = new Point(19, 3);
            rbNam.Name = "rbNam";
            rbNam.Padding = new Padding(4);
            rbNam.Size = new Size(89, 44);
            rbNam.TabIndex = 0;
            rbNam.TabStop = true;
            rbNam.Text = "Nam";
            rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            rbNu.AutoSize = true;
            rbNu.Location = new Point(114, 3);
            rbNu.Name = "rbNu";
            rbNu.Padding = new Padding(4);
            rbNu.Size = new Size(70, 44);
            rbNu.TabIndex = 1;
            rbNu.TabStop = true;
            rbNu.Text = "Nữ";
            rbNu.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtLuong);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(3, 428);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(367, 79);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lương";
            // 
            // txtLuong
            // 
            txtLuong.Dock = DockStyle.Fill;
            txtLuong.Location = new Point(3, 35);
            txtLuong.Margin = new Padding(5);
            txtLuong.Name = "txtLuong";
            //txtLuong.PlaceholderText = "Lương";
            txtLuong.Size = new Size(361, 39);
            txtLuong.TabIndex = 0;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(txtHoTenNV);
            groupBox9.Dock = DockStyle.Fill;
            groupBox9.ForeColor = Color.White;
            groupBox9.Location = new Point(3, 88);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(367, 79);
            groupBox9.TabIndex = 12;
            groupBox9.TabStop = false;
            groupBox9.Text = "Họ tên";
            // 
            // txtHoTenNV
            // 
            txtHoTenNV.Dock = DockStyle.Fill;
            txtHoTenNV.Location = new Point(3, 35);
            txtHoTenNV.Margin = new Padding(5);
            txtHoTenNV.Name = "txtHoTenNV";
            //txtHoTenNV.PlaceholderText = "Họ và tên";
            txtHoTenNV.Size = new Size(361, 39);
            txtHoTenNV.TabIndex = 0;
            txtHoTenNV.TextChanged += txtHoTenNV_TextChanged;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(txtSDT);
            groupBox8.Dock = DockStyle.Fill;
            groupBox8.ForeColor = Color.White;
            groupBox8.Location = new Point(3, 258);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(367, 79);
            groupBox8.TabIndex = 11;
            groupBox8.TabStop = false;
            groupBox8.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            txtSDT.Dock = DockStyle.Fill;
            txtSDT.Location = new Point(3, 35);
            txtSDT.Margin = new Padding(5);
            txtSDT.Name = "txtSDT";
            //txtSDT.PlaceholderText = "số điện thoại";
            txtSDT.Size = new Size(361, 39);
            txtSDT.TabIndex = 0;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(rptNgaySinh);
            groupBox7.Dock = DockStyle.Fill;
            groupBox7.ForeColor = Color.White;
            groupBox7.Location = new Point(3, 173);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(367, 79);
            groupBox7.TabIndex = 10;
            groupBox7.TabStop = false;
            groupBox7.Text = "Ngày sinh";
            // 
            // rptNgaySinh
            // 
            rptNgaySinh.Dock = DockStyle.Fill;
            rptNgaySinh.Format = DateTimePickerFormat.Short;
            rptNgaySinh.Location = new Point(3, 35);
            rptNgaySinh.Margin = new Padding(6, 4, 6, 4);
            rptNgaySinh.Name = "rptNgaySinh";
            rptNgaySinh.Size = new Size(361, 39);
            rptNgaySinh.TabIndex = 19;
            // 
            // groupBox6
            // 
            groupBox6.AutoSize = true;
            groupBox6.Controls.Add(rtbDiaChi);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.ForeColor = Color.White;
            groupBox6.Location = new Point(3, 343);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(367, 79);
            groupBox6.TabIndex = 9;
            groupBox6.TabStop = false;
            groupBox6.Text = "Địa chỉ";
            // 
            // rtbDiaChi
            // 
            rtbDiaChi.Dock = DockStyle.Fill;
            rtbDiaChi.Location = new Point(3, 35);
            rtbDiaChi.Name = "rtbDiaChi";
            rtbDiaChi.Size = new Size(361, 41);
            rtbDiaChi.TabIndex = 0;
            rtbDiaChi.Text = "";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cboPhongBan);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.ForeColor = Color.Snow;
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(367, 79);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Phòng ban";
            // 
            // cboPhongBan
            // 
            cboPhongBan.Dock = DockStyle.Fill;
            cboPhongBan.FormattingEnabled = true;
            cboPhongBan.Location = new Point(3, 35);
            cboPhongBan.Margin = new Padding(5);
            cboPhongBan.Name = "cboPhongBan";
            cboPhongBan.Size = new Size(361, 40);
            cboPhongBan.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Phòng Ban";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Trưởng Phòng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // txtHoTen
            // 
            txtHoTen.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtHoTen.Dock = DockStyle.Fill;
            txtHoTen.Location = new Point(3, 3);
            txtHoTen.Multiline = true;
            txtHoTen.Name = "txtHoTen";
            //txtHoTen.PlaceholderText = "Tìm theo họ tên";
            txtHoTen.ScrollBars = ScrollBars.Both;
            txtHoTen.Size = new Size(593, 76);
            txtHoTen.TabIndex = 5;
            txtHoTen.TextAlign = HorizontalAlignment.Center;
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 88, 52);
            ClientSize = new Size(1284, 729);
            Controls.Add(tableLayoutPanel3);
            Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(5);
            Name = "FormNhanVien";
            Text = "Nhập thông tin nhân viên";
            Load += FormNhanVien_Load;
            tableLayoutPanel7.ResumeLayout(false);
            groupBox19.ResumeLayout(false);
            groupBox19.PerformLayout();
            groupBox20.ResumeLayout(false);
            groupBox20.PerformLayout();
            tblNhanVien.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            cmsNhanVien.ResumeLayout(false);
            groupBox14.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox5.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox18;
        private TableLayoutPanel tableLayoutPanel7;
        private GroupBox groupBox19;
        private TextBox textBox5;
        private GroupBox groupBox20;
        private TextBox textBox6;
        private TableLayoutPanel tblNhanVien;
        private GroupBox groupBox14;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnAdd;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox9;
        private TextBox txtHoTenNV;
        private GroupBox groupBox8;
        private TextBox txtSDT;
        private GroupBox groupBox7;
        private GroupBox groupBox6;
        private RichTextBox rtbDiaChi;
        private GroupBox groupBox4;
        private DateTimePicker dtpNgaySinh;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private GroupBox groupBox3;
        private DataGridView dgvNhanVien;
        private Button btnEdit;
        private GroupBox groupBox2;
        private TextBox txtLuong;
        private DateTimePicker rptNgaySinh;
        private ComboBox cboPhongBan;
        private GroupBox groupBox5;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton rbNam;
        private RadioButton rbNu;
        private ContextMenuStrip cmsNhanVien;
        private ToolStripMenuItem tsmThongKe;
        private ToolStripMenuItem tsmInFilePDF;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnTimKiem;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem tsmXuatFileExcel;
        private TextBox txtHoTen;
    }
}