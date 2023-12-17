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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = "uploads\\PhieuInHoaDon.rpt";
            this.crystalReportViewer1.Size = new System.Drawing.Size(751, 478);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // FormBanHang
            // 
            this.ClientSize = new System.Drawing.Size(751, 478);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "FormBanHang";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn KM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewButtonColumn BtnTangSL;
        private System.Windows.Forms.DataGridViewButtonColumn btnGiamSL;
        private ComboBox cboPageSize;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label label7;
        private PictureBox btnNext;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}