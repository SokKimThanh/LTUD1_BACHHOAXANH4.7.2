﻿namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.BanHang
{
    partial class ViDuPhanTrang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.sotrang = new System.Windows.Forms.Label();
            this.tongsotrang = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.cboLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 267);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(438, 400);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 38);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(210, 400);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(65, 38);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // sotrang
            // 
            this.sotrang.AutoSize = true;
            this.sotrang.Location = new System.Drawing.Point(281, 413);
            this.sotrang.Name = "sotrang";
            this.sotrang.Size = new System.Drawing.Size(72, 13);
            this.sotrang.TabIndex = 3;
            this.sotrang.Text = "Trang hiện tại";
            this.sotrang.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tongsotrang
            // 
            this.tongsotrang.AutoSize = true;
            this.tongsotrang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tongsotrang.Location = new System.Drawing.Point(359, 413);
            this.tongsotrang.Name = "tongsotrang";
            this.tongsotrang.Size = new System.Drawing.Size(73, 13);
            this.tongsotrang.TabIndex = 3;
            this.tongsotrang.Text = "Tổng số trang";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(223, 75);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(290, 20);
            this.txtTenSanPham.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(533, 75);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "áp dụng";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(362, 33);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(151, 21);
            this.cboNhaCungCap.TabIndex = 6;
            this.cboNhaCungCap.SelectedIndexChanged += new System.EventHandler(this.cboNhaCungCap_SelectedIndexChanged);
            // 
            // cboLoaiSanPham
            // 
            this.cboLoaiSanPham.FormattingEnabled = true;
            this.cboLoaiSanPham.Location = new System.Drawing.Point(223, 33);
            this.cboLoaiSanPham.Name = "cboLoaiSanPham";
            this.cboLoaiSanPham.Size = new System.Drawing.Size(130, 21);
            this.cboLoaiSanPham.TabIndex = 7;
            this.cboLoaiSanPham.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSanPham_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "loại sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "nhà cung cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên sản phẩm";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(629, 75);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // ViDuPhanTrang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboLoaiSanPham);
            this.Controls.Add(this.cboNhaCungCap);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.tongsotrang);
            this.Controls.Add(this.sotrang);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViDuPhanTrang";
            this.Text = "ViDuPhanTrang";
            this.Load += new System.EventHandler(this.ViDuPhanTrang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label sotrang;
        private System.Windows.Forms.Label tongsotrang;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.ComboBox cboLoaiSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLamMoi;
    }
}