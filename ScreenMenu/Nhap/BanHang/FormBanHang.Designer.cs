using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace LTUD1_BACHHOAXANH472
{
    partial class FormBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcManHinhBanHang = new System.Windows.Forms.TabControl();
            this.tpManHinhBanHang = new System.Windows.Forms.TabPage();
            this.tlpManHinhBanHang = new System.Windows.Forms.TableLayoutPanel();
            this.tlpThongTinDangNhap = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTieuDeKhachHang = new System.Windows.Forms.Label();
            this.lblTieuDeSanPham = new System.Windows.Forms.Label();
            this.tlpThongTinKhachHangTimKiemSanPham = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.cboPageSize = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.btnSearchSanPham = new System.Windows.Forms.Button();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.lblLoaiSanPham = new System.Windows.Forms.Label();
            this.cboLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTieuDeHoaDon = new System.Windows.Forms.Label();
            this.dgvThongTinHoaDon = new System.Windows.Forms.DataGridView();
            this.pnDanhSachSanPham = new System.Windows.Forms.Panel();
            this.dgvDanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.tlpInputNhapTTKH = new System.Windows.Forms.TableLayoutPanel();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.tlpNhapTTHD = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtSoLuongMua = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnHuyThanhToan = new System.Windows.Forms.Button();
            this.tieudedanhsachsangpham = new System.Windows.Forms.TableLayoutPanel();
            this.lblTieuDeDanhSaschSanPham = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tlpPhanTrang = new System.Windows.Forms.TableLayoutPanel();
            this.lblTongSoTrang = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.PictureBox();
            this.btnThemHDCT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnTangSL = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnGiamSL = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tcManHinhBanHang.SuspendLayout();
            this.tpManHinhBanHang.SuspendLayout();
            this.tlpManHinhBanHang.SuspendLayout();
            this.tlpThongTinDangNhap.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tlpThongTinKhachHangTimKiemSanPham.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHoaDon)).BeginInit();
            this.pnDanhSachSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSanPham)).BeginInit();
            this.tlpInputNhapTTKH.SuspendLayout();
            this.tlpNhapTTHD.SuspendLayout();
            this.tieudedanhsachsangpham.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tlpPhanTrang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
            this.SuspendLayout();
            // 
            // tcManHinhBanHang
            // 
            this.tcManHinhBanHang.Controls.Add(this.tpManHinhBanHang);
            this.tcManHinhBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcManHinhBanHang.Location = new System.Drawing.Point(0, 0);
            this.tcManHinhBanHang.Margin = new System.Windows.Forms.Padding(0);
            this.tcManHinhBanHang.Name = "tcManHinhBanHang";
            this.tcManHinhBanHang.SelectedIndex = 0;
            this.tcManHinhBanHang.Size = new System.Drawing.Size(1300, 768);
            this.tcManHinhBanHang.TabIndex = 2;
            // 
            // tpManHinhBanHang
            // 
            this.tpManHinhBanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(10)))));
            this.tpManHinhBanHang.Controls.Add(this.tlpManHinhBanHang);
            this.tpManHinhBanHang.Location = new System.Drawing.Point(4, 26);
            this.tpManHinhBanHang.Margin = new System.Windows.Forms.Padding(0);
            this.tpManHinhBanHang.Name = "tpManHinhBanHang";
            this.tpManHinhBanHang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpManHinhBanHang.Size = new System.Drawing.Size(1292, 738);
            this.tpManHinhBanHang.TabIndex = 0;
            this.tpManHinhBanHang.Text = "Màn hình bán hàng";
            // 
            // tlpManHinhBanHang
            // 
            this.tlpManHinhBanHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpManHinhBanHang.BackColor = System.Drawing.Color.Green;
            this.tlpManHinhBanHang.ColumnCount = 2;
            this.tlpManHinhBanHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpManHinhBanHang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpManHinhBanHang.Controls.Add(this.tlpThongTinDangNhap, 0, 0);
            this.tlpManHinhBanHang.Controls.Add(this.lblTieuDeKhachHang, 0, 1);
            this.tlpManHinhBanHang.Controls.Add(this.lblTieuDeSanPham, 1, 1);
            this.tlpManHinhBanHang.Controls.Add(this.tlpThongTinKhachHangTimKiemSanPham, 1, 2);
            this.tlpManHinhBanHang.Controls.Add(this.lblTieuDeHoaDon, 0, 3);
            this.tlpManHinhBanHang.Controls.Add(this.dgvThongTinHoaDon, 0, 4);
            this.tlpManHinhBanHang.Controls.Add(this.pnDanhSachSanPham, 1, 4);
            this.tlpManHinhBanHang.Controls.Add(this.tlpInputNhapTTKH, 0, 2);
            this.tlpManHinhBanHang.Controls.Add(this.tlpNhapTTHD, 0, 5);
            this.tlpManHinhBanHang.Controls.Add(this.tieudedanhsachsangpham, 1, 3);
            this.tlpManHinhBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpManHinhBanHang.Location = new System.Drawing.Point(3, 2);
            this.tlpManHinhBanHang.Margin = new System.Windows.Forms.Padding(0);
            this.tlpManHinhBanHang.Name = "tlpManHinhBanHang";
            this.tlpManHinhBanHang.RowCount = 6;
            this.tlpManHinhBanHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpManHinhBanHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpManHinhBanHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tlpManHinhBanHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpManHinhBanHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpManHinhBanHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tlpManHinhBanHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpManHinhBanHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpManHinhBanHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpManHinhBanHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpManHinhBanHang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpManHinhBanHang.Size = new System.Drawing.Size(1286, 734);
            this.tlpManHinhBanHang.TabIndex = 1;
            // 
            // tlpThongTinDangNhap
            // 
            this.tlpThongTinDangNhap.AutoSize = true;
            this.tlpThongTinDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.tlpThongTinDangNhap.ColumnCount = 2;
            this.tlpManHinhBanHang.SetColumnSpan(this.tlpThongTinDangNhap, 2);
            this.tlpThongTinDangNhap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpThongTinDangNhap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpThongTinDangNhap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpThongTinDangNhap.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tlpThongTinDangNhap.Controls.Add(this.panel1, 1, 1);
            this.tlpThongTinDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpThongTinDangNhap.Location = new System.Drawing.Point(0, 0);
            this.tlpThongTinDangNhap.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.tlpThongTinDangNhap.Name = "tlpThongTinDangNhap";
            this.tlpThongTinDangNhap.RowCount = 4;
            this.tlpThongTinDangNhap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlpThongTinDangNhap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpThongTinDangNhap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpThongTinDangNhap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlpThongTinDangNhap.Size = new System.Drawing.Size(1286, 60);
            this.tlpThongTinDangNhap.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.51505F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.48495F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label19, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 1);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tlpThongTinDangNhap.SetRowSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(643, 58);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.label4.Location = new System.Drawing.Point(164, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(479, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sok Kim Thanh";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.label1.Location = new System.Drawing.Point(164, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản trị viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.label12.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_small_green_welcome;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "Welcome!";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.label19.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_small_green_taikhoan;
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(0, 29);
            this.label19.Margin = new System.Windows.Forms.Padding(0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(164, 29);
            this.label19.TabIndex = 0;
            this.label19.Text = "Quyền truy cập";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.tableLayoutPanel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(643, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.tlpThongTinDangNhap.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(643, 58);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.BackgroundImage = global::LTUD1_BACHHOAXANH472.Properties.Resources.tranparent_green_detail;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(643, 58);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(643, 58);
            this.label5.TabIndex = 2;
            this.label5.Text = "15/12/2023 11:11 AM ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTieuDeKhachHang
            // 
            this.lblTieuDeKhachHang.AutoSize = true;
            this.lblTieuDeKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.lblTieuDeKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDeKhachHang.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeKhachHang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTieuDeKhachHang.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_khachhang;
            this.lblTieuDeKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTieuDeKhachHang.Location = new System.Drawing.Point(1, 64);
            this.lblTieuDeKhachHang.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.lblTieuDeKhachHang.Name = "lblTieuDeKhachHang";
            this.lblTieuDeKhachHang.Size = new System.Drawing.Size(642, 64);
            this.lblTieuDeKhachHang.TabIndex = 4;
            this.lblTieuDeKhachHang.Text = "Thông tin khách hàng";
            this.lblTieuDeKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTieuDeSanPham
            // 
            this.lblTieuDeSanPham.AutoSize = true;
            this.lblTieuDeSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.lblTieuDeSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDeSanPham.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeSanPham.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTieuDeSanPham.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_search;
            this.lblTieuDeSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTieuDeSanPham.Location = new System.Drawing.Point(644, 64);
            this.lblTieuDeSanPham.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.lblTieuDeSanPham.Name = "lblTieuDeSanPham";
            this.lblTieuDeSanPham.Size = new System.Drawing.Size(642, 64);
            this.lblTieuDeSanPham.TabIndex = 5;
            this.lblTieuDeSanPham.Text = "Tìm kiếm sản phẩm";
            this.lblTieuDeSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpThongTinKhachHangTimKiemSanPham
            // 
            this.tlpThongTinKhachHangTimKiemSanPham.AutoSize = true;
            this.tlpThongTinKhachHangTimKiemSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(10)))));
            this.tlpThongTinKhachHangTimKiemSanPham.ColumnCount = 6;
            this.tlpThongTinKhachHangTimKiemSanPham.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.375001F));
            this.tlpThongTinKhachHangTimKiemSanPham.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.375001F));
            this.tlpThongTinKhachHangTimKiemSanPham.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.375001F));
            this.tlpThongTinKhachHangTimKiemSanPham.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.375001F));
            this.tlpThongTinKhachHangTimKiemSanPham.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tlpThongTinKhachHangTimKiemSanPham.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tlpThongTinKhachHangTimKiemSanPham.Controls.Add(this.tableLayoutPanel1, 5, 2);
            this.tlpThongTinKhachHangTimKiemSanPham.Controls.Add(this.lblTenSanPham, 0, 0);
            this.tlpThongTinKhachHangTimKiemSanPham.Controls.Add(this.txtTenSanPham, 0, 1);
            this.tlpThongTinKhachHangTimKiemSanPham.Controls.Add(this.btnSearchSanPham, 0, 2);
            this.tlpThongTinKhachHangTimKiemSanPham.Controls.Add(this.lblNhaCungCap, 5, 0);
            this.tlpThongTinKhachHangTimKiemSanPham.Controls.Add(this.lblLoaiSanPham, 4, 0);
            this.tlpThongTinKhachHangTimKiemSanPham.Controls.Add(this.cboLoaiSanPham, 4, 1);
            this.tlpThongTinKhachHangTimKiemSanPham.Controls.Add(this.cboNhaCungCap, 5, 1);
            this.tlpThongTinKhachHangTimKiemSanPham.Controls.Add(this.btnRefresh, 4, 2);
            this.tlpThongTinKhachHangTimKiemSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpThongTinKhachHangTimKiemSanPham.Location = new System.Drawing.Point(643, 128);
            this.tlpThongTinKhachHangTimKiemSanPham.Margin = new System.Windows.Forms.Padding(0);
            this.tlpThongTinKhachHangTimKiemSanPham.Name = "tlpThongTinKhachHangTimKiemSanPham";
            this.tlpThongTinKhachHangTimKiemSanPham.RowCount = 3;
            this.tlpThongTinKhachHangTimKiemSanPham.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpThongTinKhachHangTimKiemSanPham.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpThongTinKhachHangTimKiemSanPham.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpThongTinKhachHangTimKiemSanPham.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpThongTinKhachHangTimKiemSanPham.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpThongTinKhachHangTimKiemSanPham.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpThongTinKhachHangTimKiemSanPham.Size = new System.Drawing.Size(643, 128);
            this.tlpThongTinKhachHangTimKiemSanPham.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboPageSize, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(440, 84);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(203, 44);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_pagesize;
            this.label6.Location = new System.Drawing.Point(1, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 44);
            this.label6.TabIndex = 5;
            this.label6.Text = " ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboPageSize
            // 
            this.cboPageSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cboPageSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboPageSize.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPageSize.FormattingEnabled = true;
            this.cboPageSize.Location = new System.Drawing.Point(135, 1);
            this.cboPageSize.Margin = new System.Windows.Forms.Padding(1);
            this.cboPageSize.Name = "cboPageSize";
            this.cboPageSize.Size = new System.Drawing.Size(67, 40);
            this.cboPageSize.TabIndex = 7;
            this.cboPageSize.SelectedIndexChanged += new System.EventHandler(this.cboPageSize_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(33, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 44);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số sản phẩm hiển thị";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tlpThongTinKhachHangTimKiemSanPham.SetColumnSpan(this.lblTenSanPham, 4);
            this.lblTenSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTenSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.lblTenSanPham.Location = new System.Drawing.Point(0, 0);
            this.lblTenSanPham.Margin = new System.Windows.Forms.Padding(0);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(240, 42);
            this.lblTenSanPham.TabIndex = 1;
            this.lblTenSanPham.Text = "Tên sản phẩm";
            this.lblTenSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.tlpThongTinKhachHangTimKiemSanPham.SetColumnSpan(this.txtTenSanPham, 4);
            this.txtTenSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenSanPham.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.txtTenSanPham.Location = new System.Drawing.Point(0, 42);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(239, 36);
            this.txtTenSanPham.TabIndex = 3;
            // 
            // btnSearchSanPham
            // 
            this.btnSearchSanPham.BackColor = System.Drawing.Color.Transparent;
            this.tlpThongTinKhachHangTimKiemSanPham.SetColumnSpan(this.btnSearchSanPham, 4);
            this.btnSearchSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchSanPham.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchSanPham.FlatAppearance.BorderSize = 2;
            this.btnSearchSanPham.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearchSanPham.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearchSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSearchSanPham.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_small_search;
            this.btnSearchSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchSanPham.Location = new System.Drawing.Point(0, 84);
            this.btnSearchSanPham.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearchSanPham.Name = "btnSearchSanPham";
            this.btnSearchSanPham.Size = new System.Drawing.Size(240, 44);
            this.btnSearchSanPham.TabIndex = 4;
            this.btnSearchSanPham.Text = "Tìm sản phẩm";
            this.btnSearchSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchSanPham.UseVisualStyleBackColor = false;
            this.btnSearchSanPham.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.AutoSize = true;
            this.lblNhaCungCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNhaCungCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.lblNhaCungCap.Location = new System.Drawing.Point(440, 0);
            this.lblNhaCungCap.Margin = new System.Windows.Forms.Padding(0);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(203, 42);
            this.lblNhaCungCap.TabIndex = 1;
            this.lblNhaCungCap.Text = "Nhà cung cấp";
            this.lblNhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoaiSanPham
            // 
            this.lblLoaiSanPham.AutoSize = true;
            this.lblLoaiSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblLoaiSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLoaiSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLoaiSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.lblLoaiSanPham.Location = new System.Drawing.Point(240, 0);
            this.lblLoaiSanPham.Margin = new System.Windows.Forms.Padding(0);
            this.lblLoaiSanPham.Name = "lblLoaiSanPham";
            this.lblLoaiSanPham.Size = new System.Drawing.Size(200, 42);
            this.lblLoaiSanPham.TabIndex = 1;
            this.lblLoaiSanPham.Text = "Loại sản phẩm";
            this.lblLoaiSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboLoaiSanPham
            // 
            this.cboLoaiSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cboLoaiSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboLoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiSanPham.FormattingEnabled = true;
            this.cboLoaiSanPham.Location = new System.Drawing.Point(241, 43);
            this.cboLoaiSanPham.Margin = new System.Windows.Forms.Padding(1);
            this.cboLoaiSanPham.Name = "cboLoaiSanPham";
            this.cboLoaiSanPham.Size = new System.Drawing.Size(198, 40);
            this.cboLoaiSanPham.TabIndex = 7;
            this.cboLoaiSanPham.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSanPham_SelectedIndexChanged);
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cboNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(440, 42);
            this.cboNhaCungCap.Margin = new System.Windows.Forms.Padding(0);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(203, 40);
            this.cboNhaCungCap.TabIndex = 8;
            this.cboNhaCungCap.SelectedIndexChanged += new System.EventHandler(this.cboNhaCungCap_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.BorderSize = 2;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_small_lammoi;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(241, 84);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(199, 44);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // lblTieuDeHoaDon
            // 
            this.lblTieuDeHoaDon.AutoSize = true;
            this.lblTieuDeHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.lblTieuDeHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDeHoaDon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeHoaDon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTieuDeHoaDon.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_hoadon;
            this.lblTieuDeHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTieuDeHoaDon.Location = new System.Drawing.Point(1, 256);
            this.lblTieuDeHoaDon.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.lblTieuDeHoaDon.Name = "lblTieuDeHoaDon";
            this.lblTieuDeHoaDon.Size = new System.Drawing.Size(642, 64);
            this.lblTieuDeHoaDon.TabIndex = 4;
            this.lblTieuDeHoaDon.Text = "Giỏ Hàng";
            this.lblTieuDeHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvThongTinHoaDon
            // 
            this.dgvThongTinHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinHoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvThongTinHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(10)))));
            this.dgvThongTinHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongTinHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvThongTinHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASP,
            this.TenSP,
            this.DonGia,
            this.KM,
            this.SL,
            this.ThanhTien,
            this.BtnTangSL,
            this.btnGiamSL});
            this.dgvThongTinHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvThongTinHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongTinHoaDon.GridColor = System.Drawing.Color.Green;
            this.dgvThongTinHoaDon.Location = new System.Drawing.Point(4, 320);
            this.dgvThongTinHoaDon.Margin = new System.Windows.Forms.Padding(4, 0, 0, 4);
            this.dgvThongTinHoaDon.Name = "dgvThongTinHoaDon";
            this.dgvThongTinHoaDon.RowHeadersVisible = false;
            this.dgvThongTinHoaDon.RowHeadersWidth = 62;
            this.dgvThongTinHoaDon.Size = new System.Drawing.Size(639, 246);
            this.dgvThongTinHoaDon.TabIndex = 8;
            this.dgvThongTinHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinHoaDon_CellContentClick);
            this.dgvThongTinHoaDon.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHoaDon_CellMouseEnter);
            this.dgvThongTinHoaDon.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachHoaDon_CellMouseLeave);
            // 
            // pnDanhSachSanPham
            // 
            this.pnDanhSachSanPham.AutoScroll = true;
            this.pnDanhSachSanPham.BackColor = System.Drawing.Color.Black;
            this.pnDanhSachSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDanhSachSanPham.Controls.Add(this.dgvDanhSachSanPham);
            this.pnDanhSachSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDanhSachSanPham.Location = new System.Drawing.Point(647, 320);
            this.pnDanhSachSanPham.Margin = new System.Windows.Forms.Padding(4, 0, 0, 4);
            this.pnDanhSachSanPham.Name = "pnDanhSachSanPham";
            this.tlpManHinhBanHang.SetRowSpan(this.pnDanhSachSanPham, 2);
            this.pnDanhSachSanPham.Size = new System.Drawing.Size(639, 410);
            this.pnDanhSachSanPham.TabIndex = 9;
            // 
            // dgvDanhSachSanPham
            // 
            this.dgvDanhSachSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachSanPham.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(40)))), ((int)(((byte)(10)))));
            this.dgvDanhSachSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnThemHDCT});
            this.dgvDanhSachSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachSanPham.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachSanPham.GridColor = System.Drawing.Color.Green;
            this.dgvDanhSachSanPham.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSachSanPham.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.dgvDanhSachSanPham.Name = "dgvDanhSachSanPham";
            this.dgvDanhSachSanPham.RowHeadersVisible = false;
            this.dgvDanhSachSanPham.RowHeadersWidth = 62;
            this.dgvDanhSachSanPham.Size = new System.Drawing.Size(637, 408);
            this.dgvDanhSachSanPham.TabIndex = 9;
            this.dgvDanhSachSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSanPham_CellClick);
            // 
            // tlpInputNhapTTKH
            // 
            this.tlpInputNhapTTKH.AutoSize = true;
            this.tlpInputNhapTTKH.BackColor = System.Drawing.Color.Green;
            this.tlpInputNhapTTKH.ColumnCount = 3;
            this.tlpInputNhapTTKH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.00581F));
            this.tlpInputNhapTTKH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.05198F));
            this.tlpInputNhapTTKH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.94221F));
            this.tlpInputNhapTTKH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpInputNhapTTKH.Controls.Add(this.txtTenKhachHang, 1, 0);
            this.tlpInputNhapTTKH.Controls.Add(this.label2, 0, 0);
            this.tlpInputNhapTTKH.Controls.Add(this.label3, 0, 1);
            this.tlpInputNhapTTKH.Controls.Add(this.txtSDT, 1, 1);
            this.tlpInputNhapTTKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInputNhapTTKH.Location = new System.Drawing.Point(0, 128);
            this.tlpInputNhapTTKH.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.tlpInputNhapTTKH.Name = "tlpInputNhapTTKH";
            this.tlpInputNhapTTKH.RowCount = 2;
            this.tlpInputNhapTTKH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInputNhapTTKH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInputNhapTTKH.Size = new System.Drawing.Size(643, 124);
            this.tlpInputNhapTTKH.TabIndex = 10;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtTenKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpInputNhapTTKH.SetColumnSpan(this.txtTenKhachHang, 2);
            this.txtTenKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenKhachHang.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.txtTenKhachHang.Location = new System.Drawing.Point(167, 0);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(0);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(476, 61);
            this.txtTenKhachHang.TabIndex = 3;
            this.txtTenKhachHang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.label2.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_small_green_hotenkhachhang;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 62);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên Khách hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.label3.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_small_green_smartphone;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(4, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 62);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số điện thoại";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpInputNhapTTKH.SetColumnSpan(this.txtSDT, 2);
            this.txtSDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.txtSDT.Location = new System.Drawing.Point(167, 62);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(0);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(476, 61);
            this.txtSDT.TabIndex = 3;
            this.txtSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // tlpNhapTTHD
            // 
            this.tlpNhapTTHD.AutoSize = true;
            this.tlpNhapTTHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.tlpNhapTTHD.ColumnCount = 3;
            this.tlpNhapTTHD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.99079F));
            this.tlpNhapTTHD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.02423F));
            this.tlpNhapTTHD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.98499F));
            this.tlpNhapTTHD.Controls.Add(this.label10, 0, 3);
            this.tlpNhapTTHD.Controls.Add(this.txtMaHoaDon, 1, 1);
            this.tlpNhapTTHD.Controls.Add(this.label14, 0, 0);
            this.tlpNhapTTHD.Controls.Add(this.label16, 0, 1);
            this.tlpNhapTTHD.Controls.Add(this.label17, 0, 2);
            this.tlpNhapTTHD.Controls.Add(this.lblTongTien, 1, 0);
            this.tlpNhapTTHD.Controls.Add(this.txtSoLuongMua, 1, 2);
            this.tlpNhapTTHD.Controls.Add(this.btnThanhToan, 1, 3);
            this.tlpNhapTTHD.Controls.Add(this.btnHuyThanhToan, 2, 3);
            this.tlpNhapTTHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNhapTTHD.Location = new System.Drawing.Point(0, 570);
            this.tlpNhapTTHD.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.tlpNhapTTHD.Name = "tlpNhapTTHD";
            this.tlpNhapTTHD.RowCount = 4;
            this.tlpNhapTTHD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNhapTTHD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNhapTTHD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNhapTTHD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpNhapTTHD.Size = new System.Drawing.Size(643, 160);
            this.tlpNhapTTHD.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.label10.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_small_green_save;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(4, 120);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 40);
            this.label10.TabIndex = 7;
            this.label10.Text = "Thao tác dữ liệu";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.txtMaHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpNhapTTHD.SetColumnSpan(this.txtMaHoaDon, 2);
            this.txtMaHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaHoaDon.Enabled = false;
            this.txtMaHoaDon.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtMaHoaDon.Location = new System.Drawing.Point(167, 40);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(0);
            this.txtMaHoaDon.Multiline = true;
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(476, 40);
            this.txtMaHoaDon.TabIndex = 3;
            this.txtMaHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label14.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_small_hoadon;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Location = new System.Drawing.Point(1, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 40);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tổng hóa đơn";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.label16.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_green_hoadon;
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label16.Location = new System.Drawing.Point(4, 40);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(163, 40);
            this.label16.TabIndex = 0;
            this.label16.Text = "Mã hóa đơn";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.label17.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_green_hoadon;
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label17.Location = new System.Drawing.Point(4, 80);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(163, 40);
            this.label17.TabIndex = 0;
            this.label17.Text = "Tổng số lượng mua";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.lblTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpNhapTTHD.SetColumnSpan(this.lblTongTien, 2);
            this.lblTongTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTongTien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTongTien.Location = new System.Drawing.Point(167, 0);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(476, 40);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "25.000";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSoLuongMua
            // 
            this.txtSoLuongMua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.txtSoLuongMua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpNhapTTHD.SetColumnSpan(this.txtSoLuongMua, 2);
            this.txtSoLuongMua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSoLuongMua.Enabled = false;
            this.txtSoLuongMua.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongMua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSoLuongMua.Location = new System.Drawing.Point(167, 80);
            this.txtSoLuongMua.Margin = new System.Windows.Forms.Padding(0);
            this.txtSoLuongMua.Multiline = true;
            this.txtSoLuongMua.Name = "txtSoLuongMua";
            this.txtSoLuongMua.Size = new System.Drawing.Size(476, 40);
            this.txtSoLuongMua.TabIndex = 3;
            this.txtSoLuongMua.Text = "0";
            this.txtSoLuongMua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThanhToan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThanhToan.FlatAppearance.BorderSize = 2;
            this.btnThanhToan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThanhToan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_small_save;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(170, 123);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(302, 34);
            this.btnThanhToan.TabIndex = 6;
            this.btnThanhToan.Text = "Thanh toán(F9)";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnHuyThanhToan
            // 
            this.btnHuyThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.btnHuyThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHuyThanhToan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHuyThanhToan.FlatAppearance.BorderSize = 2;
            this.btnHuyThanhToan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHuyThanhToan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHuyThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnHuyThanhToan.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_small_huy;
            this.btnHuyThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyThanhToan.Location = new System.Drawing.Point(478, 123);
            this.btnHuyThanhToan.Name = "btnHuyThanhToan";
            this.btnHuyThanhToan.Size = new System.Drawing.Size(162, 34);
            this.btnHuyThanhToan.TabIndex = 5;
            this.btnHuyThanhToan.Text = "Hủy(F12)";
            this.btnHuyThanhToan.UseVisualStyleBackColor = false;
            this.btnHuyThanhToan.Click += new System.EventHandler(this.btnHuyThanhToan_Click);
            // 
            // tieudedanhsachsangpham
            // 
            this.tieudedanhsachsangpham.ColumnCount = 2;
            this.tieudedanhsachsangpham.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tieudedanhsachsangpham.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tieudedanhsachsangpham.Controls.Add(this.lblTieuDeDanhSaschSanPham, 0, 0);
            this.tieudedanhsachsangpham.Controls.Add(this.panel2, 1, 0);
            this.tieudedanhsachsangpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tieudedanhsachsangpham.Location = new System.Drawing.Point(646, 259);
            this.tieudedanhsachsangpham.Name = "tieudedanhsachsangpham";
            this.tieudedanhsachsangpham.RowCount = 1;
            this.tieudedanhsachsangpham.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tieudedanhsachsangpham.Size = new System.Drawing.Size(637, 58);
            this.tieudedanhsachsangpham.TabIndex = 12;
            // 
            // lblTieuDeDanhSaschSanPham
            // 
            this.lblTieuDeDanhSaschSanPham.AutoSize = true;
            this.lblTieuDeDanhSaschSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.lblTieuDeDanhSaschSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDeDanhSaschSanPham.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeDanhSaschSanPham.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTieuDeDanhSaschSanPham.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_sanpham;
            this.lblTieuDeDanhSaschSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTieuDeDanhSaschSanPham.Location = new System.Drawing.Point(1, 0);
            this.lblTieuDeDanhSaschSanPham.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.lblTieuDeDanhSaschSanPham.Name = "lblTieuDeDanhSaschSanPham";
            this.lblTieuDeDanhSaschSanPham.Size = new System.Drawing.Size(483, 58);
            this.lblTieuDeDanhSaschSanPham.TabIndex = 5;
            this.lblTieuDeDanhSaschSanPham.Text = "Danh sách sản phẩm";
            this.lblTieuDeDanhSaschSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.panel2.Controls.Add(this.tlpPhanTrang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(484, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 58);
            this.panel2.TabIndex = 6;
            // 
            // tlpPhanTrang
            // 
            this.tlpPhanTrang.ColumnCount = 3;
            this.tlpPhanTrang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpPhanTrang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPhanTrang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpPhanTrang.Controls.Add(this.lblTongSoTrang, 1, 1);
            this.tlpPhanTrang.Controls.Add(this.btnPrevious, 0, 1);
            this.tlpPhanTrang.Controls.Add(this.btnNext, 2, 1);
            this.tlpPhanTrang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPhanTrang.Location = new System.Drawing.Point(0, 0);
            this.tlpPhanTrang.Name = "tlpPhanTrang";
            this.tlpPhanTrang.RowCount = 3;
            this.tlpPhanTrang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tlpPhanTrang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPhanTrang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tlpPhanTrang.Size = new System.Drawing.Size(153, 58);
            this.tlpPhanTrang.TabIndex = 10;
            // 
            // lblTongSoTrang
            // 
            this.lblTongSoTrang.AutoSize = true;
            this.lblTongSoTrang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTongSoTrang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTongSoTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.lblTongSoTrang.Location = new System.Drawing.Point(35, 4);
            this.lblTongSoTrang.Name = "lblTongSoTrang";
            this.lblTongSoTrang.Padding = new System.Windows.Forms.Padding(4);
            this.lblTongSoTrang.Size = new System.Drawing.Size(83, 50);
            this.lblTongSoTrang.TabIndex = 1;
            this.lblTongSoTrang.Text = "1/40";
            this.lblTongSoTrang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPrevious.InitialImage")));
            this.btnPrevious.Location = new System.Drawing.Point(0, 4);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(32, 50);
            this.btnPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            this.btnPrevious.MouseLeave += new System.EventHandler(this.btnPrevious_MouseLeave);
            this.btnPrevious.MouseHover += new System.EventHandler(this.btnPrevious_MouseHover);
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(121, 4);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(32, 50);
            this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnNext.TabIndex = 2;
            this.btnNext.TabStop = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            this.btnNext.MouseHover += new System.EventHandler(this.btnNext_MouseHover);
            // 
            // btnThemHDCT
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.NullValue = "+";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThemHDCT.DefaultCellStyle = dataGridViewCellStyle3;
            this.btnThemHDCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHDCT.HeaderText = "Thêm HDCT";
            this.btnThemHDCT.Name = "btnThemHDCT";
            this.btnThemHDCT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.btnThemHDCT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnThemHDCT.Text = "Thao tác";
            this.btnThemHDCT.ToolTipText = "Thêm vào hóa đơn chi tiết";
            // 
            // MASP
            // 
            this.MASP.FillWeight = 1F;
            this.MASP.HeaderText = "Mã SP";
            this.MASP.MinimumWidth = 78;
            this.MASP.Name = "MASP";
            // 
            // TenSP
            // 
            this.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSP.FillWeight = 112.6024F;
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.MinimumWidth = 8;
            this.TenSP.Name = "TenSP";
            // 
            // DonGia
            // 
            this.DonGia.FillWeight = 112.6024F;
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 8;
            this.DonGia.Name = "DonGia";
            // 
            // KM
            // 
            this.KM.FillWeight = 112.6024F;
            this.KM.HeaderText = "KM";
            this.KM.MinimumWidth = 8;
            this.KM.Name = "KM";
            // 
            // SL
            // 
            this.SL.FillWeight = 112.6024F;
            this.SL.HeaderText = "SL";
            this.SL.MinimumWidth = 8;
            this.SL.Name = "SL";
            // 
            // ThanhTien
            // 
            this.ThanhTien.FillWeight = 112.6024F;
            this.ThanhTien.HeaderText = "ThanhTien";
            this.ThanhTien.MinimumWidth = 8;
            this.ThanhTien.Name = "ThanhTien";
            // 
            // BtnTangSL
            // 
            this.BtnTangSL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.NullValue = "+";
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BtnTangSL.DefaultCellStyle = dataGridViewCellStyle1;
            this.BtnTangSL.FillWeight = 87.73023F;
            this.BtnTangSL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTangSL.HeaderText = "Tăng SL";
            this.BtnTangSL.MinimumWidth = 8;
            this.BtnTangSL.Name = "BtnTangSL";
            this.BtnTangSL.Text = "Tăng";
            this.BtnTangSL.ToolTipText = "Tăng số lượng sản phẩm mua";
            this.BtnTangSL.UseColumnTextForButtonValue = true;
            this.BtnTangSL.Width = 75;
            // 
            // btnGiamSL
            // 
            this.btnGiamSL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.NullValue = "-";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.btnGiamSL.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnGiamSL.FillWeight = 85.27919F;
            this.btnGiamSL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiamSL.HeaderText = "Giảm SL";
            this.btnGiamSL.MinimumWidth = 8;
            this.btnGiamSL.Name = "btnGiamSL";
            this.btnGiamSL.Text = "Giảm";
            this.btnGiamSL.ToolTipText = "Giảm số lượng sản phẩm mua";
            this.btnGiamSL.Width = 73;
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1300, 768);
            this.ControlBox = false;
            this.Controls.Add(this.tcManHinhBanHang);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBanHang";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManHinhBanHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            this.tcManHinhBanHang.ResumeLayout(false);
            this.tpManHinhBanHang.ResumeLayout(false);
            this.tlpManHinhBanHang.ResumeLayout(false);
            this.tlpManHinhBanHang.PerformLayout();
            this.tlpThongTinDangNhap.ResumeLayout(false);
            this.tlpThongTinDangNhap.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tlpThongTinKhachHangTimKiemSanPham.ResumeLayout(false);
            this.tlpThongTinKhachHangTimKiemSanPham.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHoaDon)).EndInit();
            this.pnDanhSachSanPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSanPham)).EndInit();
            this.tlpInputNhapTTKH.ResumeLayout(false);
            this.tlpInputNhapTTKH.PerformLayout();
            this.tlpNhapTTHD.ResumeLayout(false);
            this.tlpNhapTTHD.PerformLayout();
            this.tieudedanhsachsangpham.ResumeLayout(false);
            this.tieudedanhsachsangpham.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tlpPhanTrang.ResumeLayout(false);
            this.tlpPhanTrang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcManHinhBanHang;
        private System.Windows.Forms.TabPage tpManHinhBanHang;
        private System.Windows.Forms.TableLayoutPanel tlpManHinhBanHang;
        private System.Windows.Forms.TableLayoutPanel tlpThongTinDangNhap;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTieuDeKhachHang;
        private System.Windows.Forms.TableLayoutPanel tlpThongTinKhachHangTimKiemSanPham;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Button btnSearchSanPham;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.Label lblLoaiSanPham;
        private System.Windows.Forms.ComboBox cboLoaiSanPham;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTieuDeHoaDon;
        private System.Windows.Forms.DataGridView dgvThongTinHoaDon;
        private System.Windows.Forms.Panel pnDanhSachSanPham;
        private System.Windows.Forms.DataGridView dgvDanhSachSanPham;
        private System.Windows.Forms.TableLayoutPanel tlpInputNhapTTKH;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TableLayoutPanel tlpNhapTTHD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtSoLuongMua;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuyThanhToan;
        private System.Windows.Forms.Label lblTieuDeSanPham;
        private System.Windows.Forms.TableLayoutPanel tieudedanhsachsangpham;
        private System.Windows.Forms.Label lblTieuDeDanhSaschSanPham;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTongSoTrang;
        private System.Windows.Forms.PictureBox btnPrevious;
        private System.Windows.Forms.TableLayoutPanel tlpPhanTrang;
        private ComboBox cboPageSize;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label label7;
        private PictureBox btnNext;
        private DataGridViewButtonColumn btnThemHDCT;
        private DataGridViewTextBoxColumn MASP;
        private DataGridViewTextBoxColumn TenSP;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn KM;
        private DataGridViewTextBoxColumn SL;
        private DataGridViewTextBoxColumn ThanhTien;
        private DataGridViewButtonColumn BtnTangSL;
        private DataGridViewButtonColumn btnGiamSL;
    }
}