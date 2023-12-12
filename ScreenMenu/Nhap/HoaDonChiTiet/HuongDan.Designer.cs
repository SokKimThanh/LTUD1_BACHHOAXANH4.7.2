using System.Drawing;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    partial class FormChiTietHoaDon
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.btnCapNhatHD = new System.Windows.Forms.Button();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.cboKhuyenmai = new System.Windows.Forms.ComboBox();
            this.cboHinhThucKhuyenMai = new System.Windows.Forms.ComboBox();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.cboDanhMucSP = new System.Windows.Forms.ComboBox();
            this.cboHoaDon = new System.Windows.Forms.ComboBox();
            this.dgvHoaDonChiTiet = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.btnCapNhatSoLuongMua = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonChiTiet)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhân viên bán hàng tạo hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã HD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Khách hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dgvHoaDon);
            this.groupBox1.Controls.Add(this.btnCapNhatHD);
            this.groupBox1.Controls.Add(this.btnXoaHD);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnThemHD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(32, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 647);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bước 1: Lập hóa đơn";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(196, 111);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(235, 38);
            this.comboBox3.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(196, 220);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(235, 38);
            this.comboBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(196, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 38);
            this.comboBox1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(196, 278);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 36);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(9, 346);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(425, 203);
            this.dgvHoaDon.TabIndex = 4;
            // 
            // btnCapNhatHD
            // 
            this.btnCapNhatHD.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhatHD.Location = new System.Drawing.Point(323, 574);
            this.btnCapNhatHD.Name = "btnCapNhatHD";
            this.btnCapNhatHD.Size = new System.Drawing.Size(111, 51);
            this.btnCapNhatHD.TabIndex = 3;
            this.btnCapNhatHD.Text = "Cập nhật";
            this.btnCapNhatHD.UseVisualStyleBackColor = true;
            this.btnCapNhatHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.ForeColor = System.Drawing.Color.Black;
            this.btnXoaHD.Location = new System.Drawing.Point(202, 574);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(111, 51);
            this.btnXoaHD.TabIndex = 3;
            this.btnXoaHD.Text = "Xóa";
            this.btnXoaHD.UseVisualStyleBackColor = true;
            this.btnXoaHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(309, 30);
            this.label9.TabIndex = 2;
            this.label9.Text = "Hệ thống lưu thông tin hóa đơn";
            // 
            // btnThemHD
            // 
            this.btnThemHD.ForeColor = System.Drawing.Color.Black;
            this.btnThemHD.Location = new System.Drawing.Point(4, 574);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(183, 51);
            this.btnThemHD.TabIndex = 3;
            this.btnThemHD.Text = "Tạo hóa đơn mới";
            this.btnThemHD.UseVisualStyleBackColor = true;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(11, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 30);
            this.label7.TabIndex = 2;
            this.label7.Text = "Ngày lập hóa đơn";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(11, 167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 30);
            this.label15.TabIndex = 2;
            this.label15.Text = "Nhân viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(487, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(980, 647);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bước 2: Thêm/Xóa sản phẩm trong hóa đơn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(515, 30);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nhân viên tiến hành thêm/xóa sản phẩm vào hóa đơn";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(14, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(486, 30);
            this.label16.TabIndex = 2;
            this.label16.Text = "Hệ thống cho phép thêm khuyến mãi trên hóa đơn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(14, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(569, 30);
            this.label10.TabIndex = 2;
            this.label10.Text = "Hệ thống tìm tất cả sản phẩm theo danh mục theo hóa đơn";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.cboKhuyenmai);
            this.groupBox4.Controls.Add(this.cboHinhThucKhuyenMai);
            this.groupBox4.Controls.Add(this.cboSanPham);
            this.groupBox4.Controls.Add(this.cboDanhMucSP);
            this.groupBox4.Controls.Add(this.cboHoaDon);
            this.groupBox4.Controls.Add(this.dgvHoaDonChiTiet);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox4.Location = new System.Drawing.Point(19, 127);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(936, 405);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm sản phẩm theo hóa đơn theo loại theo khuyến mãi";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.numericUpDown2);
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox6.Location = new System.Drawing.Point(469, 295);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(455, 104);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tổng thành tiền hóa đơn";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(6, 35);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(443, 36);
            this.numericUpDown2.TabIndex = 17;
            // 
            // cboKhuyenmai
            // 
            this.cboKhuyenmai.FormattingEnabled = true;
            this.cboKhuyenmai.Location = new System.Drawing.Point(288, 211);
            this.cboKhuyenmai.Name = "cboKhuyenmai";
            this.cboKhuyenmai.Size = new System.Drawing.Size(175, 38);
            this.cboKhuyenmai.TabIndex = 12;
            // 
            // cboHinhThucKhuyenMai
            // 
            this.cboHinhThucKhuyenMai.FormattingEnabled = true;
            this.cboHinhThucKhuyenMai.Location = new System.Drawing.Point(288, 167);
            this.cboHinhThucKhuyenMai.Name = "cboHinhThucKhuyenMai";
            this.cboHinhThucKhuyenMai.Size = new System.Drawing.Size(175, 38);
            this.cboHinhThucKhuyenMai.TabIndex = 13;
            // 
            // cboSanPham
            // 
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Location = new System.Drawing.Point(288, 124);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(175, 38);
            this.cboSanPham.TabIndex = 14;
            // 
            // cboDanhMucSP
            // 
            this.cboDanhMucSP.FormattingEnabled = true;
            this.cboDanhMucSP.Location = new System.Drawing.Point(288, 80);
            this.cboDanhMucSP.Name = "cboDanhMucSP";
            this.cboDanhMucSP.Size = new System.Drawing.Size(175, 38);
            this.cboDanhMucSP.TabIndex = 15;
            // 
            // cboHoaDon
            // 
            this.cboHoaDon.FormattingEnabled = true;
            this.cboHoaDon.Location = new System.Drawing.Point(288, 37);
            this.cboHoaDon.Name = "cboHoaDon";
            this.cboHoaDon.Size = new System.Drawing.Size(175, 38);
            this.cboHoaDon.TabIndex = 16;
            // 
            // dgvHoaDonChiTiet
            // 
            this.dgvHoaDonChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonChiTiet.Location = new System.Drawing.Point(469, 35);
            this.dgvHoaDonChiTiet.Name = "dgvHoaDonChiTiet";
            this.dgvHoaDonChiTiet.Size = new System.Drawing.Size(455, 254);
            this.dgvHoaDonChiTiet.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(17, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 30);
            this.label14.TabIndex = 6;
            this.label14.Text = "Mã số hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(17, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "sản phẩm theo danh mục";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(17, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(262, 30);
            this.label12.TabIndex = 8;
            this.label12.Text = "khuyến mãi theo hình thức";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(17, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(273, 30);
            this.label11.TabIndex = 9;
            this.label11.Text = "Chọn 1n Khuyến mãi cho SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(17, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Chọn 1n sản phẩm cho HD";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.numericUpDown1);
            this.groupBox7.Controls.Add(this.checkBox2);
            this.groupBox7.Controls.Add(this.checkBox1);
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox7.Location = new System.Drawing.Point(8, 275);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(455, 124);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Nhập số lượng mua hàng";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(274, 34);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(175, 36);
            this.numericUpDown1.TabIndex = 17;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(20, 36);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(246, 34);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "Tự cập nhật SL tồn kho";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 76);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(240, 34);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Tự kiểm tra SL tồn kho";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnThemSP);
            this.groupBox5.Controls.Add(this.btnCapNhatSoLuongMua);
            this.groupBox5.Controls.Add(this.btnXoaSP);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(19, 538);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(936, 103);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thao tác trên sản phẩm của hóa đơn";
            // 
            // btnThemSP
            // 
            this.btnThemSP.ForeColor = System.Drawing.Color.Black;
            this.btnThemSP.Location = new System.Drawing.Point(28, 38);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(200, 50);
            this.btnThemSP.TabIndex = 7;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.UseVisualStyleBackColor = true;
            // 
            // btnCapNhatSoLuongMua
            // 
            this.btnCapNhatSoLuongMua.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhatSoLuongMua.Location = new System.Drawing.Point(469, 38);
            this.btnCapNhatSoLuongMua.Name = "btnCapNhatSoLuongMua";
            this.btnCapNhatSoLuongMua.Size = new System.Drawing.Size(450, 50);
            this.btnCapNhatSoLuongMua.TabIndex = 8;
            this.btnCapNhatSoLuongMua.Text = "Cập nhật số lượng hàng đã mua";
            this.btnCapNhatSoLuongMua.UseVisualStyleBackColor = true;
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.ForeColor = System.Drawing.Color.Black;
            this.btnXoaSP.Location = new System.Drawing.Point(247, 38);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(200, 50);
            this.btnXoaSP.TabIndex = 9;
            this.btnXoaSP.Text = "Xóa sản phẩm";
            this.btnXoaSP.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(32, 666);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1435, 254);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bước 3: Hiển thị thông tin màn hình thanh toán";
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(1106, 53);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(184, 51);
            this.button6.TabIndex = 3;
            this.button6.Text = "Thanh toán";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(1106, 157);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "In Phiếu hóa đơn";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(21, 219);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(398, 30);
            this.label25.TabIndex = 2;
            this.label25.Text = "Hệ thống cho phép tạo report in hóa đơn";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(21, 189);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(536, 30);
            this.label24.TabIndex = 2;
            this.label24.Text = "Hệ thống cập nhật số lượng tồn kho cho từng sản phẩm";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(21, 157);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(686, 30);
            this.label23.TabIndex = 2;
            this.label23.Text = "Hệ thống ghi nhận thông tin sản phẩm, số lượng mua theo mã hóa đơn ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(988, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(416, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "Hoàn tất thanh toán xin cảm ơn quý khách!";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(333, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(179, 30);
            this.label20.TabIndex = 2;
            this.label20.Text = "Ngày lập hóa đơn";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(21, 100);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(242, 30);
            this.label19.TabIndex = 2;
            this.label19.Text = "Số tiền giảm khuyến mãi";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(21, 67);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(292, 30);
            this.label18.TabIndex = 2;
            this.label18.Text = "Hình thức khuyến mãi(nếu có)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(21, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(299, 30);
            this.label17.TabIndex = 2;
            this.label17.Text = "Chi tiết thanh toán(chi tiết HD)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(333, 100);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(185, 30);
            this.label21.TabIndex = 2;
            this.label21.Text = "Số tiền thanh toán";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(333, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(225, 30);
            this.label13.TabIndex = 2;
            this.label13.Text = "Nhân viên lập hóa đơn";
            // 
            // FormChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1479, 956);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormChiTietHoaDon";
            this.Text = "Màn hình bán hàng(Hóa đơn chi tiết)";
            this.Load += new System.EventHandler(this.FormChiTietHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonChiTiet)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label label2;
        private Label label5;
        private GroupBox groupBox1;
        private Button btnThemHD;
        private Label label7;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button3;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label13;
        private Label label6;
        private Label label15;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label21;
        private Label label16;
        private Button button6;
        private Label label23;
        private Label label25;
        private Label label24;
        private DataGridView dgvHoaDon;
        private Button btnCapNhatHD;
        private Button btnXoaHD;
        private GroupBox groupBox4;
        private ComboBox cboKhuyenmai;
        private ComboBox cboHinhThucKhuyenMai;
        private ComboBox cboSanPham;
        private ComboBox cboDanhMucSP;
        private ComboBox cboHoaDon;
        private DataGridView dgvHoaDonChiTiet;
        private Label label14;
        private Label label4;
        private Label label12;
        private Label label11;
        private Label label3;
        private GroupBox groupBox5;
        private Button btnThemSP;
        private Button btnCapNhatSoLuongMua;
        private Button btnXoaSP;
        private GroupBox groupBox6;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private GroupBox groupBox7;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDown2;
    }
}