using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    partial class FormSanPham
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbDonVi = new System.Windows.Forms.RichTextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dtpNSX = new System.Windows.Forms.DateTimePicker();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dtpHSD = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rtbSL = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachSP = new System.Windows.Forms.DataGridView();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.cboKM = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.cboTheLoaiTimKiem = new System.Windows.Forms.ComboBox();
            this.dtpTKNgay = new System.Windows.Forms.DateTimePicker();
            this.rptThongKe = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSP)).BeginInit();
            this.groupBox14.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1370, 749);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1362, 715);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý danh sách";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1356, 709);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 703);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.groupBox9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox8, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.groupBox7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.groupBox6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.groupBox5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 675);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbDonVi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 423);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 64);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đơn vị tính";
            // 
            // rtbDonVi
            // 
            this.rtbDonVi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDonVi.Location = new System.Drawing.Point(3, 25);
            this.rtbDonVi.Name = "rtbDonVi";
            this.rtbDonVi.Size = new System.Drawing.Size(382, 36);
            this.rtbDonVi.TabIndex = 10;
            this.rtbDonVi.Text = "";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.dtpNSX);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.ForeColor = System.Drawing.Color.White;
            this.groupBox9.Location = new System.Drawing.Point(3, 143);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(388, 64);
            this.groupBox9.TabIndex = 12;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Ngày sản xuất:";
            // 
            // dtpNSX
            // 
            this.dtpNSX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpNSX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNSX.Location = new System.Drawing.Point(3, 25);
            this.dtpNSX.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dtpNSX.Name = "dtpNSX";
            this.dtpNSX.Size = new System.Drawing.Size(382, 29);
            this.dtpNSX.TabIndex = 20;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtDonGia);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.ForeColor = System.Drawing.Color.White;
            this.groupBox8.Location = new System.Drawing.Point(3, 283);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(388, 64);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDonGia.Location = new System.Drawing.Point(3, 25);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(5);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(382, 36);
            this.txtDonGia.TabIndex = 9;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dtpHSD);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(3, 213);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(388, 64);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Hạn sử dụng:";
            // 
            // dtpHSD
            // 
            this.dtpHSD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpHSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHSD.Location = new System.Drawing.Point(3, 25);
            this.dtpHSD.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.dtpHSD.Name = "dtpHSD";
            this.dtpHSD.Size = new System.Drawing.Size(382, 29);
            this.dtpHSD.TabIndex = 19;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rtbSL);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(3, 353);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(388, 64);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tồn kho";
            // 
            // rtbSL
            // 
            this.rtbSL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbSL.Location = new System.Drawing.Point(3, 25);
            this.rtbSL.Name = "rtbSL";
            this.rtbSL.Size = new System.Drawing.Size(382, 36);
            this.rtbSL.TabIndex = 10;
            this.rtbSL.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtTenSP);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.ForeColor = System.Drawing.Color.Snow;
            this.groupBox5.Location = new System.Drawing.Point(3, 73);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(388, 64);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tên sản phẩm";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenSP.Location = new System.Drawing.Point(3, 25);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenSP.Multiline = true;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(382, 36);
            this.txtTenSP.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMaSP);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.ForeColor = System.Drawing.Color.Snow;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 64);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mã sản phẩm";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Location = new System.Drawing.Point(3, 25);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaSP.Multiline = true;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(382, 36);
            this.txtMaSP.TabIndex = 11;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox15, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.groupBox14, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(409, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.41998F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.58002F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(944, 703);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.dgvDanhSachSP);
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox15.ForeColor = System.Drawing.Color.White;
            this.groupBox15.Location = new System.Drawing.Point(3, 81);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(938, 484);
            this.groupBox15.TabIndex = 7;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Danh sách";
            // 
            // dgvDanhSachSP
            // 
            this.dgvDanhSachSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachSP.Location = new System.Drawing.Point(3, 25);
            this.dgvDanhSachSP.Name = "dgvDanhSachSP";
            this.dgvDanhSachSP.RowHeadersWidth = 51;
            this.dgvDanhSachSP.Size = new System.Drawing.Size(932, 456);
            this.dgvDanhSachSP.TabIndex = 2;
            this.dgvDanhSachSP.Click += new System.EventHandler(this.dgvDanhSachSP_Click);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.tableLayoutPanel6);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox14.ForeColor = System.Drawing.Color.White;
            this.groupBox14.Location = new System.Drawing.Point(3, 571);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(938, 129);
            this.groupBox14.TabIndex = 8;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Thao tác dữ liệu";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 6;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.Controls.Add(this.btnLamMoi, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnSua, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnXoa, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnThem, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(932, 101);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLamMoi.FlatAppearance.BorderSize = 3;
            this.btnLamMoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLamMoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.SeaShell;
            this.btnLamMoi.Location = new System.Drawing.Point(315, 5);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(145, 91);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSua.FlatAppearance.BorderSize = 3;
            this.btnSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.SeaShell;
            this.btnSua.Location = new System.Drawing.Point(470, 5);
            this.btnSua.Margin = new System.Windows.Forms.Padding(5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(145, 91);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.FlatAppearance.BorderSize = 3;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.SeaShell;
            this.btnXoa.Location = new System.Drawing.Point(5, 5);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(145, 91);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.FlatAppearance.BorderSize = 3;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.SeaShell;
            this.btnThem.Location = new System.Drawing.Point(160, 5);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(145, 91);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(938, 72);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.cboKM);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.ForeColor = System.Drawing.Color.Snow;
            this.groupBox11.Location = new System.Drawing.Point(627, 3);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(308, 66);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Khuyến Mãi";
            // 
            // cboKM
            // 
            this.cboKM.DisplayMember = "None";
            this.cboKM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboKM.FormattingEnabled = true;
            this.cboKM.Location = new System.Drawing.Point(3, 25);
            this.cboKM.Margin = new System.Windows.Forms.Padding(5);
            this.cboKM.Name = "cboKM";
            this.cboKM.Size = new System.Drawing.Size(302, 29);
            this.cboKM.TabIndex = 0;
            this.cboKM.Text = "None";
            this.cboKM.ValueMember = "None";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.cboLoaiSP);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.ForeColor = System.Drawing.Color.Snow;
            this.groupBox10.Location = new System.Drawing.Point(315, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(306, 66);
            this.groupBox10.TabIndex = 2;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Loại sản phẩm";
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Location = new System.Drawing.Point(3, 25);
            this.cboLoaiSP.Margin = new System.Windows.Forms.Padding(5);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(300, 29);
            this.cboLoaiSP.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboNCC);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.Color.Snow;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 66);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhà cung cấp";
            // 
            // cboNCC
            // 
            this.cboNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(3, 25);
            this.cboNCC.Margin = new System.Windows.Forms.Padding(5);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(300, 29);
            this.cboNCC.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.tabPage2.Controls.Add(this.tableLayoutPanel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1362, 715);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "In Báo cáo";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.rptThongKe, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 99.99999F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1356, 709);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 258F));
            this.tableLayoutPanel7.Controls.Add(this.txtTimKiem, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnThongKe, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.cboTheLoaiTimKiem, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.dtpTKNgay, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1350, 58);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.txtTimKiem.Location = new System.Drawing.Point(731, 3);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(358, 52);
            this.txtTimKiem.TabIndex = 15;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThongKe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThongKe.FlatAppearance.BorderSize = 2;
            this.btnThongKe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_small_search;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(1094, 2);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(254, 54);
            this.btnThongKe.TabIndex = 14;
            this.btnThongKe.Text = "Tìm kiếm";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboTheLoaiTimKiem
            // 
            this.cboTheLoaiTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboTheLoaiTimKiem.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.cboTheLoaiTimKiem.FormattingEnabled = true;
            this.cboTheLoaiTimKiem.Items.AddRange(new object[] {
            "Theo tên",
            "Theo hạn sử dụng"});
            this.cboTheLoaiTimKiem.Location = new System.Drawing.Point(3, 3);
            this.cboTheLoaiTimKiem.Name = "cboTheLoaiTimKiem";
            this.cboTheLoaiTimKiem.Size = new System.Drawing.Size(358, 40);
            this.cboTheLoaiTimKiem.TabIndex = 10;
            // 
            // dtpTKNgay
            // 
            this.dtpTKNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpTKNgay.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.dtpTKNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTKNgay.Location = new System.Drawing.Point(367, 3);
            this.dtpTKNgay.Name = "dtpTKNgay";
            this.dtpTKNgay.Size = new System.Drawing.Size(358, 39);
            this.dtpTKNgay.TabIndex = 11;
            this.dtpTKNgay.ValueChanged += new System.EventHandler(this.dtpTKNgay_ValueChanged);
            // 
            // rptThongKe
            // 
            this.rptThongKe.ActiveViewIndex = -1;
            this.rptThongKe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptThongKe.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptThongKe.Location = new System.Drawing.Point(3, 67);
            this.rptThongKe.Name = "rptThongKe";
            this.rptThongKe.Size = new System.Drawing.Size(1350, 639);
            this.rptThongKe.TabIndex = 1;
            this.rptThongKe.Load += new System.EventHandler(this.rptSanPham_Load);
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormSanPham";
            this.Text = "Danh mục sản phẩm";
            this.Load += new System.EventHandler(this.FormSanPham_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSP)).EndInit();
            this.groupBox14.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox groupBox15;
        private GroupBox groupBox14;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox11;
        private ComboBox cboKM;
        private GroupBox groupBox10;
        private ComboBox cboLoaiSP;
        private GroupBox groupBox3;
        private ComboBox cboNCC;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel7;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptThongKe;
        private ComboBox cboTheLoaiTimKiem;
        private Button btnThongKe;
        private TextBox txtTimKiem;
        private DateTimePicker dtpTKNgay;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox2;
        private RichTextBox rtbDonVi;
        private GroupBox groupBox9;
        private DateTimePicker dtpNSX;
        private GroupBox groupBox8;
        private TextBox txtDonGia;
        private GroupBox groupBox7;
        private DateTimePicker dtpHSD;
        private GroupBox groupBox6;
        private RichTextBox rtbSL;
        private GroupBox groupBox5;
        private TextBox txtTenSP;
        private GroupBox groupBox4;
        private TextBox txtMaSP;
        private DataGridView dgvDanhSachSP;
    }
}