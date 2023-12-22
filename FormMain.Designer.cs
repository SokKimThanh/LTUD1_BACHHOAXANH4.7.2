using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace LTUD1_BACHHOAXANH472
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tlpBHX = new System.Windows.Forms.TableLayoutPanel();
            this.flpSetting = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.tlpNavigationBar = new System.Windows.Forms.TableLayoutPanel();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnHinhThucKM = new System.Windows.Forms.Button();
            this.btnDanhMucSP = new System.Windows.Forms.Button();
            this.btnChiTietHD = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnNhaCungCap = new System.Windows.Forms.Button();
            this.btnNhaCCCT = new System.Windows.Forms.Button();
            this.btnKhuyenMai = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnChiNhanh = new System.Windows.Forms.Button();
            this.btnPhongBan = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.cmsLogOut = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentChangeButton = new System.Windows.Forms.Button();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.currentChangeTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnTrangChu = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.tlpExit = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconChildForm = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.listIcon_navigation_bar = new System.Windows.Forms.ImageList(this.components);
            this.lisIcon_navigation_bar_transparent10 = new System.Windows.Forms.ImageList(this.components);
            this.tlpBHX.SuspendLayout();
            this.flpSetting.SuspendLayout();
            this.panelSetting.SuspendLayout();
            this.tlpNavigationBar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.tlpHeader.SuspendLayout();
            this.cmsLogOut.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.tlpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTrangChu)).BeginInit();
            this.tlpExit.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconChildForm)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBHX
            // 
            this.tlpBHX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.tlpBHX.Controls.Add(this.flpSetting, 0, 2);
            this.tlpBHX.Controls.Add(this.panelDesktop, 1, 1);
            this.tlpBHX.Controls.Add(this.tlpNavigationBar, 0, 1);
            this.tlpBHX.Controls.Add(this.panelHeader, 1, 0);
            this.tlpBHX.Controls.Add(this.panelMenu, 0, 0);
            this.tlpBHX.Controls.Add(this.tlpExit, 1, 2);
            resources.ApplyResources(this.tlpBHX, "tlpBHX");
            this.tlpBHX.Name = "tlpBHX";
            // 
            // flpSetting
            // 
            this.flpSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(42)))), ((int)(((byte)(25)))));
            this.flpSetting.Controls.Add(this.panelSetting);
            resources.ApplyResources(this.flpSetting, "flpSetting");
            this.flpSetting.Name = "flpSetting";
            // 
            // panelSetting
            // 
            this.panelSetting.BackColor = System.Drawing.Color.Transparent;
            this.panelSetting.Controls.Add(this.btnSetting);
            resources.ApplyResources(this.panelSetting, "panelSetting");
            this.panelSetting.Name = "panelSetting";
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSetting, "btnSetting");
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSetting.ForeColor = System.Drawing.Color.Transparent;
            this.btnSetting.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_setting;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            resources.ApplyResources(this.panelDesktop, "panelDesktop");
            this.panelDesktop.Name = "panelDesktop";
            // 
            // tlpNavigationBar
            // 
            resources.ApplyResources(this.tlpNavigationBar, "tlpNavigationBar");
            this.tlpNavigationBar.BackColor = System.Drawing.Color.Transparent;
            this.tlpNavigationBar.Controls.Add(this.btnBanHang, 0, 0);
            this.tlpNavigationBar.Controls.Add(this.btnNhanVien, 0, 1);
            this.tlpNavigationBar.Controls.Add(this.btnHinhThucKM, 0, 9);
            this.tlpNavigationBar.Controls.Add(this.btnDanhMucSP, 0, 8);
            this.tlpNavigationBar.Controls.Add(this.btnChiTietHD, 0, 7);
            this.tlpNavigationBar.Controls.Add(this.btnKhachHang, 0, 6);
            this.tlpNavigationBar.Controls.Add(this.btnNhaCungCap, 0, 5);
            this.tlpNavigationBar.Controls.Add(this.btnNhaCCCT, 0, 11);
            this.tlpNavigationBar.Controls.Add(this.btnKhuyenMai, 0, 4);
            this.tlpNavigationBar.Controls.Add(this.btnHoaDon, 0, 3);
            this.tlpNavigationBar.Controls.Add(this.btnSanPham, 0, 2);
            this.tlpNavigationBar.Controls.Add(this.btnChiNhanh, 0, 12);
            this.tlpNavigationBar.Controls.Add(this.btnPhongBan, 0, 10);
            this.tlpNavigationBar.Name = "tlpNavigationBar";
            // 
            // btnBanHang
            // 
            resources.ApplyResources(this.btnBanHang, "btnBanHang");
            this.btnBanHang.FlatAppearance.BorderSize = 0;
            this.btnBanHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnBanHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBanHang.ForeColor = System.Drawing.Color.White;
            this.btnBanHang.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_banhang;
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnNhanVien
            // 
            resources.ApplyResources(this.btnNhanVien, "btnNhanVien");
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_nhanvien;
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnHinhThucKM
            // 
            resources.ApplyResources(this.btnHinhThucKM, "btnHinhThucKM");
            this.btnHinhThucKM.FlatAppearance.BorderSize = 0;
            this.btnHinhThucKM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnHinhThucKM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHinhThucKM.ForeColor = System.Drawing.Color.White;
            this.btnHinhThucKM.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.hinhthuckhuyenmai;
            this.btnHinhThucKM.Name = "btnHinhThucKM";
            this.btnHinhThucKM.UseVisualStyleBackColor = true;
            this.btnHinhThucKM.Click += new System.EventHandler(this.btnHinhThucKM_Click);
            // 
            // btnDanhMucSP
            // 
            resources.ApplyResources(this.btnDanhMucSP, "btnDanhMucSP");
            this.btnDanhMucSP.FlatAppearance.BorderSize = 0;
            this.btnDanhMucSP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnDanhMucSP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDanhMucSP.ForeColor = System.Drawing.Color.White;
            this.btnDanhMucSP.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.danhmucsanpham;
            this.btnDanhMucSP.Name = "btnDanhMucSP";
            this.btnDanhMucSP.UseVisualStyleBackColor = true;
            this.btnDanhMucSP.Click += new System.EventHandler(this.btnDanhMucSP_Click);
            // 
            // btnChiTietHD
            // 
            resources.ApplyResources(this.btnChiTietHD, "btnChiTietHD");
            this.btnChiTietHD.FlatAppearance.BorderSize = 0;
            this.btnChiTietHD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnChiTietHD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChiTietHD.ForeColor = System.Drawing.Color.White;
            this.btnChiTietHD.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.chitiethoadon;
            this.btnChiTietHD.Name = "btnChiTietHD";
            this.btnChiTietHD.UseVisualStyleBackColor = true;
            this.btnChiTietHD.Click += new System.EventHandler(this.btnChiTietHD_Click);
            // 
            // btnKhachHang
            // 
            resources.ApplyResources(this.btnKhachHang, "btnKhachHang");
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_khachhang;
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNhaCungCap
            // 
            resources.ApplyResources(this.btnNhaCungCap, "btnNhaCungCap");
            this.btnNhaCungCap.FlatAppearance.BorderSize = 0;
            this.btnNhaCungCap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnNhaCungCap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhaCungCap.ForeColor = System.Drawing.Color.White;
            this.btnNhaCungCap.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_nhacungcap;
            this.btnNhaCungCap.Name = "btnNhaCungCap";
            this.btnNhaCungCap.UseVisualStyleBackColor = true;
            this.btnNhaCungCap.Click += new System.EventHandler(this.btnNhaCungCap_Click);
            // 
            // btnNhaCCCT
            // 
            resources.ApplyResources(this.btnNhaCCCT, "btnNhaCCCT");
            this.btnNhaCCCT.FlatAppearance.BorderSize = 0;
            this.btnNhaCCCT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnNhaCCCT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhaCCCT.ForeColor = System.Drawing.Color.White;
            this.btnNhaCCCT.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.nhacungcapct;
            this.btnNhaCCCT.Name = "btnNhaCCCT";
            this.btnNhaCCCT.UseVisualStyleBackColor = true;
            this.btnNhaCCCT.Click += new System.EventHandler(this.btnNhaCCCT_Click);
            // 
            // btnKhuyenMai
            // 
            resources.ApplyResources(this.btnKhuyenMai, "btnKhuyenMai");
            this.btnKhuyenMai.FlatAppearance.BorderSize = 0;
            this.btnKhuyenMai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnKhuyenMai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhuyenMai.ForeColor = System.Drawing.Color.White;
            this.btnKhuyenMai.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_khuyenmai;
            this.btnKhuyenMai.Name = "btnKhuyenMai";
            this.btnKhuyenMai.UseVisualStyleBackColor = true;
            this.btnKhuyenMai.Click += new System.EventHandler(this.btnKhuyenMai_Click);
            // 
            // btnHoaDon
            // 
            resources.ApplyResources(this.btnHoaDon, "btnHoaDon");
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnHoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_hoadon;
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnSanPham
            // 
            resources.ApplyResources(this.btnSanPham, "btnSanPham");
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnSanPham.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSanPham.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_sanpham;
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnChiNhanh
            // 
            resources.ApplyResources(this.btnChiNhanh, "btnChiNhanh");
            this.btnChiNhanh.FlatAppearance.BorderSize = 0;
            this.btnChiNhanh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnChiNhanh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChiNhanh.ForeColor = System.Drawing.Color.White;
            this.btnChiNhanh.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_diadiem;
            this.btnChiNhanh.Name = "btnChiNhanh";
            this.btnChiNhanh.UseVisualStyleBackColor = true;
            this.btnChiNhanh.Click += new System.EventHandler(this.btnChiNhanh_Click);
            // 
            // btnPhongBan
            // 
            resources.ApplyResources(this.btnPhongBan, "btnPhongBan");
            this.btnPhongBan.FlatAppearance.BorderSize = 0;
            this.btnPhongBan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnPhongBan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhongBan.ForeColor = System.Drawing.Color.White;
            this.btnPhongBan.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.phongban;
            this.btnPhongBan.Name = "btnPhongBan";
            this.btnPhongBan.UseVisualStyleBackColor = true;
            this.btnPhongBan.Click += new System.EventHandler(this.btnPhongBan_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.tlpHeader);
            resources.ApplyResources(this.panelHeader, "panelHeader");
            this.panelHeader.Name = "panelHeader";
            // 
            // tlpHeader
            // 
            resources.ApplyResources(this.tlpHeader, "tlpHeader");
            this.tlpHeader.Controls.Add(this.btnDangNhap, 3, 0);
            this.tlpHeader.Controls.Add(this.currentChangeButton, 0, 0);
            this.tlpHeader.Controls.Add(this.lblAccountName, 2, 0);
            this.tlpHeader.Controls.Add(this.currentChangeTitle, 1, 0);
            this.tlpHeader.Name = "tlpHeader";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.ContextMenuStrip = this.cmsLogOut;
            resources.ApplyResources(this.btnDangNhap, "btnDangNhap");
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnDangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangNhap.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_user_login;
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // cmsLogOut
            // 
            this.cmsLogOut.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsLogOut.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.cmsLogOut.Name = "contextMenuStrip1";
            resources.ApplyResources(this.cmsLogOut, "cmsLogOut");
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.đăngXuấtToolStripMenuItem, "đăngXuấtToolStripMenuItem");
            this.đăngXuấtToolStripMenuItem.ForeColor = System.Drawing.Color.Green;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.tsmDangXuat_Click);
            // 
            // currentChangeButton
            // 
            this.currentChangeButton.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.currentChangeButton, "currentChangeButton");
            this.currentChangeButton.FlatAppearance.BorderSize = 0;
            this.currentChangeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.currentChangeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.currentChangeButton.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_home;
            this.currentChangeButton.Name = "currentChangeButton";
            this.currentChangeButton.UseVisualStyleBackColor = false;
            // 
            // lblAccountName
            // 
            this.lblAccountName.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblAccountName, "lblAccountName");
            this.lblAccountName.ForeColor = System.Drawing.Color.White;
            this.lblAccountName.Name = "lblAccountName";
            // 
            // currentChangeTitle
            // 
            this.currentChangeTitle.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.currentChangeTitle, "currentChangeTitle");
            this.currentChangeTitle.ForeColor = System.Drawing.Color.White;
            this.currentChangeTitle.Name = "currentChangeTitle";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.tlpMenu);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // tlpMenu
            // 
            resources.ApplyResources(this.tlpMenu, "tlpMenu");
            this.tlpMenu.Controls.Add(this.btnTrangChu, 0, 0);
            this.tlpMenu.Controls.Add(this.btnMenu, 0, 0);
            this.tlpMenu.Name = "tlpMenu";
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnTrangChu, "btnTrangChu");
            this.btnTrangChu.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.BXHLOGO2;
            this.btnTrangChu.InitialImage = global::LTUD1_BACHHOAXANH472.Properties.Resources.BXHLOGO2;
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.TabStop = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMenu
            // 
            resources.ApplyResources(this.btnMenu, "btnMenu");
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMenu.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_menu;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // tlpExit
            // 
            resources.ApplyResources(this.tlpExit, "tlpExit");
            this.tlpExit.Controls.Add(this.btnExit, 0, 0);
            this.tlpExit.Controls.Add(this.lblExit, 0, 0);
            this.tlpExit.Name = "tlpExit";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_exit;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblExit
            // 
            resources.ApplyResources(this.lblExit, "lblExit");
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Name = "lblExit";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.iconChildForm);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // iconChildForm
            // 
            this.iconChildForm.BackgroundImage = global::LTUD1_BACHHOAXANH472.Properties.Resources.icon_home;
            resources.ApplyResources(this.iconChildForm, "iconChildForm");
            this.iconChildForm.Name = "iconChildForm";
            this.iconChildForm.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // panel6
            // 
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // listIcon_navigation_bar
            // 
            this.listIcon_navigation_bar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listIcon_navigation_bar.ImageStream")));
            this.listIcon_navigation_bar.TransparentColor = System.Drawing.Color.Transparent;
            this.listIcon_navigation_bar.Images.SetKeyName(0, "icon_home.png");
            this.listIcon_navigation_bar.Images.SetKeyName(1, "icon_menu.png");
            this.listIcon_navigation_bar.Images.SetKeyName(2, "icon_exit.png");
            this.listIcon_navigation_bar.Images.SetKeyName(3, "icon_user_login.png");
            this.listIcon_navigation_bar.Images.SetKeyName(4, "icon_chinhanh.png");
            this.listIcon_navigation_bar.Images.SetKeyName(5, "icon_hoadon.png");
            this.listIcon_navigation_bar.Images.SetKeyName(6, "icon_khachhang.png");
            this.listIcon_navigation_bar.Images.SetKeyName(7, "icon_khuyenmai.png");
            this.listIcon_navigation_bar.Images.SetKeyName(8, "icon_nhacungcap.png");
            this.listIcon_navigation_bar.Images.SetKeyName(9, "icon_nhanvien.png");
            this.listIcon_navigation_bar.Images.SetKeyName(10, "icon_sanpham.png");
            this.listIcon_navigation_bar.Images.SetKeyName(11, "icon_search.png");
            this.listIcon_navigation_bar.Images.SetKeyName(12, "icon_setting.png");
            this.listIcon_navigation_bar.Images.SetKeyName(13, "BXHLOGO.png");
            // 
            // lisIcon_navigation_bar_transparent10
            // 
            this.lisIcon_navigation_bar_transparent10.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lisIcon_navigation_bar_transparent10.ImageStream")));
            this.lisIcon_navigation_bar_transparent10.TransparentColor = System.Drawing.Color.Transparent;
            this.lisIcon_navigation_bar_transparent10.Images.SetKeyName(0, "user.png");
            this.lisIcon_navigation_bar_transparent10.Images.SetKeyName(1, "aChangeIcon.png");
            this.lisIcon_navigation_bar_transparent10.Images.SetKeyName(2, "chinhanh.png");
            this.lisIcon_navigation_bar_transparent10.Images.SetKeyName(3, "hoadon.png");
            this.lisIcon_navigation_bar_transparent10.Images.SetKeyName(4, "khachhang.png");
            this.lisIcon_navigation_bar_transparent10.Images.SetKeyName(5, "khuyenmai.png");
            this.lisIcon_navigation_bar_transparent10.Images.SetKeyName(6, "menu.png");
            this.lisIcon_navigation_bar_transparent10.Images.SetKeyName(7, "cboNhaCungCap.png");
            this.lisIcon_navigation_bar_transparent10.Images.SetKeyName(8, "nhanvien.png");
            this.lisIcon_navigation_bar_transparent10.Images.SetKeyName(9, "sanpham.png");
            this.lisIcon_navigation_bar_transparent10.Images.SetKeyName(10, "search.png");
            this.lisIcon_navigation_bar_transparent10.Images.SetKeyName(11, "navigationBar.png");
            this.lisIcon_navigation_bar_transparent10.Images.SetKeyName(12, "thoat.png");
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpBHX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpBHX.ResumeLayout(false);
            this.tlpBHX.PerformLayout();
            this.flpSetting.ResumeLayout(false);
            this.panelSetting.ResumeLayout(false);
            this.tlpNavigationBar.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.tlpHeader.ResumeLayout(false);
            this.cmsLogOut.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.tlpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnTrangChu)).EndInit();
            this.tlpExit.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconChildForm)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpBHX;
        private FlowLayoutPanel flpSetting;
        //private Panel panelSidebar;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel panelSetting;
        private Button btnSetting;
        private Panel panelDesktop;
        public ImageList listIcon_navigation_bar;
        private ImageList lisIcon_navigation_bar_transparent10;
        private Panel panel4;
        private PictureBox iconChildForm;
        private Panel panel2;
        private Label label1;
        private Panel panel5;
        private Label label2;
        private Panel panel6;
        private TableLayoutPanel tlpNavigationBar;
        private Button btnNhanVien;
        private Button btnKhachHang;
        private Button btnNhaCungCap;
        private Button btnKhuyenMai;
        private Button btnHoaDon;
        private Button btnSanPham;
        private Panel panelHeader;
        private TableLayoutPanel tlpHeader;
        private Button btnDangNhap;
        private Button currentChangeButton;
        private Label lblAccountName;
        private Label currentChangeTitle;
        private Panel panelMenu;
        private TableLayoutPanel tlpMenu;
        private PictureBox btnTrangChu;
        private Button btnMenu;
        private ContextMenuStrip cmsLogOut;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private TableLayoutPanel tlpExit;
        private Button btnExit;
        private Label lblExit;
        private Button btnChiTietHD;
        private Button btnDanhMucSP;
        private Button btnPhongBan;
        private Button btnHinhThucKM;
        private Button btnChiNhanh;
        private Button btnNhaCCCT;
        private Button btnBanHang;
    }
}