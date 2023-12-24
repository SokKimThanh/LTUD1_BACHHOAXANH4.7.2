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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.cboHoaDon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnEditSanPham = new System.Windows.Forms.Button();
            this.btnAddSP = new System.Windows.Forms.Button();
            this.btnDeleteSP = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.btnKTTonKho = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCTHoaDon = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1284, 701);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.tabPage1.Controls.Add(this.tableLayoutPanel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1276, 667);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý hóa đơn chi tiết";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1270, 661);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 655);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin mặt hàng";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox9, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5312F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5312F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5312F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.40639F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(369, 627);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboSanPham);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(3, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(363, 72);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sản phẩm";
            // 
            // cboSanPham
            // 
            this.cboSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Location = new System.Drawing.Point(3, 29);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(357, 33);
            this.cboSanPham.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.cboHoaDon);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.groupBox9.ForeColor = System.Drawing.Color.White;
            this.groupBox9.Location = new System.Drawing.Point(3, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(363, 72);
            this.groupBox9.TabIndex = 16;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Hóa đơn";
            // 
            // cboHoaDon
            // 
            this.cboHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboHoaDon.FormattingEnabled = true;
            this.cboHoaDon.Location = new System.Drawing.Point(3, 29);
            this.cboHoaDon.Name = "cboHoaDon";
            this.cboHoaDon.Size = new System.Drawing.Size(357, 33);
            this.cboHoaDon.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 854);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Địa chỉ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(384, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(883, 655);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 527);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(877, 125);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác dữ liệu";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnRefresh, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEditSanPham, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddSP, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteSP, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(871, 97);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.FlatAppearance.BorderSize = 3;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.SeaShell;
            this.btnRefresh.Location = new System.Drawing.Point(439, 5);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(207, 87);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Làm mới danh sách";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEditSanPham
            // 
            this.btnEditSanPham.BackColor = System.Drawing.Color.Transparent;
            this.btnEditSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditSanPham.FlatAppearance.BorderSize = 3;
            this.btnEditSanPham.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEditSanPham.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEditSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSanPham.ForeColor = System.Drawing.Color.SeaShell;
            this.btnEditSanPham.Location = new System.Drawing.Point(656, 5);
            this.btnEditSanPham.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditSanPham.Name = "btnEditSanPham";
            this.btnEditSanPham.Size = new System.Drawing.Size(210, 87);
            this.btnEditSanPham.TabIndex = 5;
            this.btnEditSanPham.Text = "Cập nhật sản phẩm";
            this.btnEditSanPham.UseVisualStyleBackColor = false;
            this.btnEditSanPham.Click += new System.EventHandler(this.txtCapNhat_Click);
            // 
            // btnAddSP
            // 
            this.btnAddSP.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddSP.FlatAppearance.BorderSize = 3;
            this.btnAddSP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddSP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSP.ForeColor = System.Drawing.Color.SeaShell;
            this.btnAddSP.Location = new System.Drawing.Point(5, 5);
            this.btnAddSP.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddSP.Name = "btnAddSP";
            this.btnAddSP.Size = new System.Drawing.Size(207, 87);
            this.btnAddSP.TabIndex = 3;
            this.btnAddSP.Text = "Thêm Sản phẩm";
            this.btnAddSP.UseVisualStyleBackColor = false;
            this.btnAddSP.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDeleteSP
            // 
            this.btnDeleteSP.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteSP.FlatAppearance.BorderSize = 3;
            this.btnDeleteSP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteSP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSP.ForeColor = System.Drawing.Color.SeaShell;
            this.btnDeleteSP.Location = new System.Drawing.Point(222, 5);
            this.btnDeleteSP.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteSP.Name = "btnDeleteSP";
            this.btnDeleteSP.Size = new System.Drawing.Size(207, 87);
            this.btnDeleteSP.TabIndex = 2;
            this.btnDeleteSP.Text = "Xóa sản phẩm";
            this.btnDeleteSP.UseVisualStyleBackColor = false;
            this.btnDeleteSP.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox5, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(883, 524);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel6);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(3, 422);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(877, 99);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kiểm tra tồn kho";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Controls.Add(this.txtThanhTien, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnKTTonKho, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.txtSoLuong, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(871, 71);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.txtThanhTien.Location = new System.Drawing.Point(583, 3);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(285, 39);
            this.txtThanhTien.TabIndex = 5;
            this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnKTTonKho
            // 
            this.btnKTTonKho.BackColor = System.Drawing.Color.Transparent;
            this.btnKTTonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKTTonKho.FlatAppearance.BorderSize = 3;
            this.btnKTTonKho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnKTTonKho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnKTTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKTTonKho.ForeColor = System.Drawing.Color.SeaShell;
            this.btnKTTonKho.Location = new System.Drawing.Point(295, 5);
            this.btnKTTonKho.Margin = new System.Windows.Forms.Padding(5);
            this.btnKTTonKho.Name = "btnKTTonKho";
            this.btnKTTonKho.Size = new System.Drawing.Size(280, 61);
            this.btnKTTonKho.TabIndex = 4;
            this.btnKTTonKho.Text = "Kiểm tra tồn kho";
            this.btnKTTonKho.UseVisualStyleBackColor = false;
            this.btnKTTonKho.Click += new System.EventHandler(this.btnKTTonKho_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.txtSoLuong.Location = new System.Drawing.Point(3, 3);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(284, 39);
            this.txtSoLuong.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCTHoaDon);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(877, 413);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // dgvCTHoaDon
            // 
            this.dgvCTHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvCTHoaDon.Location = new System.Drawing.Point(3, 25);
            this.dgvCTHoaDon.Name = "dgvCTHoaDon";
            this.dgvCTHoaDon.RowHeadersWidth = 51;
            this.dgvCTHoaDon.RowTemplate.Height = 29;
            this.dgvCTHoaDon.Size = new System.Drawing.Size(878, 385);
            this.dgvCTHoaDon.TabIndex = 0;
            // 
            // FormChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1284, 701);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormChiTietHoaDon";
            this.Text = "Xử lý đơn hàng(Hóa đơn chi tiết)";
            this.Load += new System.EventHandler(this.FormChiTietHoaDon_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox4;
        private ComboBox cboSanPham;
        private GroupBox groupBox9;
        private ComboBox cboHoaDon;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnRefresh;
        private Button btnEditSanPham;
        private Button btnAddSP;
        private Button btnDeleteSP;
        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox groupBox5;
        private TableLayoutPanel tableLayoutPanel6;
        private TextBox txtThanhTien;
        private Button btnKTTonKho;
        private TextBox txtSoLuong;
        private GroupBox groupBox3;
        private DataGridView dgvCTHoaDon;
    }
}