using System;
using System.Drawing;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    partial class FormTaiKhoan
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlNhapThongTin = new System.Windows.Forms.TabControl();
            this.tabInputTaiKhoan = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.cboQTC = new System.Windows.Forms.ComboBox();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.tabInputQuyenTruyCap = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenQTC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMaQTC = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlXemDuLieu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvQTC = new System.Windows.Forms.DataGridView();
            this.tabControlThaoTacDuLieu = new System.Windows.Forms.TabControl();
            this.tpButtonThemThongTinTaiKhoan = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefreshTaiKhoan = new System.Windows.Forms.Button();
            this.btnEditTaiKhoan = new System.Windows.Forms.Button();
            this.btnAddThemTaiKhoan = new System.Windows.Forms.Button();
            this.btnDeleteTaiKhoan = new System.Windows.Forms.Button();
            this.tpButtonThemThongTinQuyenTruyCap = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefreshQuyenTruyCap = new System.Windows.Forms.Button();
            this.btnEditQuyenTruyCap = new System.Windows.Forms.Button();
            this.btnAddQuyenTruyCap = new System.Windows.Forms.Button();
            this.btnDeleteQuyenTruycap = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabControlNhapThongTin.SuspendLayout();
            this.tabInputTaiKhoan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tabInputQuyenTruyCap.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabControlXemDuLieu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQTC)).BeginInit();
            this.tabControlThaoTacDuLieu.SuspendLayout();
            this.tpButtonThemThongTinTaiKhoan.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tpButtonThemThongTinQuyenTruyCap.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.73209F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.26791F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1192, 804);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tabControlNhapThongTin, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 796F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(475, 796);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tabControlNhapThongTin
            // 
            this.tabControlNhapThongTin.Controls.Add(this.tabInputTaiKhoan);
            this.tabControlNhapThongTin.Controls.Add(this.tabInputQuyenTruyCap);
            this.tabControlNhapThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlNhapThongTin.Location = new System.Drawing.Point(6, 8);
            this.tabControlNhapThongTin.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tabControlNhapThongTin.Name = "tabControlNhapThongTin";
            this.tabControlNhapThongTin.SelectedIndex = 0;
            this.tabControlNhapThongTin.Size = new System.Drawing.Size(463, 780);
            this.tabControlNhapThongTin.TabIndex = 0;
            this.tabControlNhapThongTin.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabInputTaiKhoan
            // 
            this.tabInputTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.tabInputTaiKhoan.Controls.Add(this.groupBox1);
            this.tabInputTaiKhoan.Location = new System.Drawing.Point(4, 41);
            this.tabInputTaiKhoan.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tabInputTaiKhoan.Name = "tabInputTaiKhoan";
            this.tabInputTaiKhoan.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tabInputTaiKhoan.Size = new System.Drawing.Size(455, 735);
            this.tabInputTaiKhoan.TabIndex = 0;
            this.tabInputTaiKhoan.Text = "1";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.tableLayoutPanel5);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(443, 719);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin tài khoản";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoScroll = true;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.61456F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.38544F));
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.cboQTC, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.cboNV, 1, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(5, 29);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(433, 686);
            this.tableLayoutPanel5.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label4.Location = new System.Drawing.Point(5, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 71);
            this.label4.TabIndex = 34;
            this.label4.Text = "Mã QTC";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.txtMK, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(174, 74);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(256, 65);
            this.tableLayoutPanel8.TabIndex = 33;
            // 
            // txtMK
            // 
            this.txtMK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMK.Location = new System.Drawing.Point(5, 4);
            this.txtMK.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(246, 32);
            this.txtMK.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label2.Location = new System.Drawing.Point(5, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 71);
            this.label2.TabIndex = 29;
            this.label2.Text = "Mật Khẩu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 71);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tên tài khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label3.Location = new System.Drawing.Point(5, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 71);
            this.label3.TabIndex = 29;
            this.label3.Text = "Mã NV";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.txtTenTK, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(174, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(256, 65);
            this.tableLayoutPanel7.TabIndex = 32;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenTK.Location = new System.Drawing.Point(5, 4);
            this.txtTenTK.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTenTK.Multiline = true;
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(246, 46);
            this.txtTenTK.TabIndex = 22;
            // 
            // cboQTC
            // 
            this.cboQTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboQTC.FormattingEnabled = true;
            this.cboQTC.Location = new System.Drawing.Point(174, 216);
            this.cboQTC.Name = "cboQTC";
            this.cboQTC.Size = new System.Drawing.Size(256, 33);
            this.cboQTC.TabIndex = 35;
            // 
            // cboNV
            // 
            this.cboNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(174, 145);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(256, 33);
            this.cboNV.TabIndex = 36;
            // 
            // tabInputQuyenTruyCap
            // 
            this.tabInputQuyenTruyCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.tabInputQuyenTruyCap.Controls.Add(this.groupBox3);
            this.tabInputQuyenTruyCap.Location = new System.Drawing.Point(4, 38);
            this.tabInputQuyenTruyCap.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tabInputQuyenTruyCap.Name = "tabInputQuyenTruyCap";
            this.tabInputQuyenTruyCap.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tabInputQuyenTruyCap.Size = new System.Drawing.Size(455, 738);
            this.tabInputQuyenTruyCap.TabIndex = 1;
            this.tabInputQuyenTruyCap.Text = "2";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.tableLayoutPanel6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(6, 8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Size = new System.Drawing.Size(443, 722);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập thông tin quyền truy cập";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoScroll = true;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.30752F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.69248F));
            this.tableLayoutPanel6.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.txtTenQTC, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.txtMaQTC, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(5, 29);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(433, 689);
            this.tableLayoutPanel6.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 71);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 71);
            this.label12.TabIndex = 29;
            this.label12.Text = "Tên tài khoản";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenQTC
            // 
            this.txtTenQTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenQTC.Location = new System.Drawing.Point(157, 75);
            this.txtTenQTC.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTenQTC.Multiline = true;
            this.txtTenQTC.Name = "txtTenQTC";
            this.txtTenQTC.Size = new System.Drawing.Size(271, 63);
            this.txtTenQTC.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(5, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 71);
            this.label14.TabIndex = 40;
            this.label14.Text = "Mã quyền truy cập";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaQTC
            // 
            this.txtMaQTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaQTC.Location = new System.Drawing.Point(157, 4);
            this.txtMaQTC.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMaQTC.Multiline = true;
            this.txtMaQTC.Name = "txtMaQTC";
            this.txtMaQTC.Size = new System.Drawing.Size(271, 63);
            this.txtMaQTC.TabIndex = 41;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tabControlXemDuLieu, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tabControlThaoTacDuLieu, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(490, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(697, 796);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tabControlXemDuLieu
            // 
            this.tabControlXemDuLieu.Controls.Add(this.tabPage1);
            this.tabControlXemDuLieu.Controls.Add(this.tabPage2);
            this.tabControlXemDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlXemDuLieu.Location = new System.Drawing.Point(6, 8);
            this.tabControlXemDuLieu.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tabControlXemDuLieu.Name = "tabControlXemDuLieu";
            this.tabControlXemDuLieu.SelectedIndex = 0;
            this.tabControlXemDuLieu.Size = new System.Drawing.Size(685, 552);
            this.tabControlXemDuLieu.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Location = new System.Drawing.Point(4, 41);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tabPage1.Size = new System.Drawing.Size(677, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvTaiKhoan);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(6, 8);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(665, 491);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách tài khoản";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(3, 25);
            this.dgvTaiKhoan.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.RowTemplate.Height = 28;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(659, 463);
            this.dgvTaiKhoan.TabIndex = 2;
            this.dgvTaiKhoan.Click += new System.EventHandler(this.dgvTaiKhoan_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tabPage2.Size = new System.Drawing.Size(676, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvQTC);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(6, 8);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(664, 494);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Danh sách quyền truy cập";
            // 
            // dgvQTC
            // 
            this.dgvQTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQTC.Location = new System.Drawing.Point(3, 25);
            this.dgvQTC.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvQTC.Name = "dgvQTC";
            this.dgvQTC.RowHeadersWidth = 51;
            this.dgvQTC.RowTemplate.Height = 28;
            this.dgvQTC.Size = new System.Drawing.Size(658, 466);
            this.dgvQTC.TabIndex = 2;
            this.dgvQTC.Click += new System.EventHandler(this.dgvQTC_Click);
            // 
            // tabControlThaoTacDuLieu
            // 
            this.tabControlThaoTacDuLieu.Controls.Add(this.tpButtonThemThongTinTaiKhoan);
            this.tabControlThaoTacDuLieu.Controls.Add(this.tpButtonThemThongTinQuyenTruyCap);
            this.tabControlThaoTacDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlThaoTacDuLieu.Location = new System.Drawing.Point(3, 571);
            this.tabControlThaoTacDuLieu.Name = "tabControlThaoTacDuLieu";
            this.tabControlThaoTacDuLieu.SelectedIndex = 0;
            this.tabControlThaoTacDuLieu.Size = new System.Drawing.Size(691, 222);
            this.tabControlThaoTacDuLieu.TabIndex = 17;
            // 
            // tpButtonThemThongTinTaiKhoan
            // 
            this.tpButtonThemThongTinTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.tpButtonThemThongTinTaiKhoan.Controls.Add(this.groupBox2);
            this.tpButtonThemThongTinTaiKhoan.Location = new System.Drawing.Point(4, 41);
            this.tpButtonThemThongTinTaiKhoan.Name = "tpButtonThemThongTinTaiKhoan";
            this.tpButtonThemThongTinTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tpButtonThemThongTinTaiKhoan.Size = new System.Drawing.Size(683, 177);
            this.tpButtonThemThongTinTaiKhoan.TabIndex = 0;
            this.tpButtonThemThongTinTaiKhoan.Text = "1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(677, 171);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác dữ liệu tài khoản";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnRefreshTaiKhoan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEditTaiKhoan, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddThemTaiKhoan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteTaiKhoan, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 26);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(667, 141);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnRefreshTaiKhoan
            // 
            this.btnRefreshTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.btnRefreshTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefreshTaiKhoan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefreshTaiKhoan.FlatAppearance.BorderSize = 4;
            this.btnRefreshTaiKhoan.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRefreshTaiKhoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRefreshTaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRefreshTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnRefreshTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnRefreshTaiKhoan.Location = new System.Drawing.Point(171, 4);
            this.btnRefreshTaiKhoan.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRefreshTaiKhoan.Name = "btnRefreshTaiKhoan";
            this.btnRefreshTaiKhoan.Size = new System.Drawing.Size(156, 133);
            this.btnRefreshTaiKhoan.TabIndex = 39;
            this.btnRefreshTaiKhoan.Text = "Làm mới";
            this.btnRefreshTaiKhoan.UseVisualStyleBackColor = false;
            this.btnRefreshTaiKhoan.Click += new System.EventHandler(this.btnRefreshTaiKhoan_Click);
            // 
            // btnEditTaiKhoan
            // 
            this.btnEditTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.btnEditTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditTaiKhoan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditTaiKhoan.FlatAppearance.BorderSize = 4;
            this.btnEditTaiKhoan.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEditTaiKhoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEditTaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEditTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnEditTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnEditTaiKhoan.Location = new System.Drawing.Point(503, 4);
            this.btnEditTaiKhoan.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEditTaiKhoan.Name = "btnEditTaiKhoan";
            this.btnEditTaiKhoan.Size = new System.Drawing.Size(159, 133);
            this.btnEditTaiKhoan.TabIndex = 36;
            this.btnEditTaiKhoan.Text = "Sửa";
            this.btnEditTaiKhoan.UseVisualStyleBackColor = false;
            this.btnEditTaiKhoan.Click += new System.EventHandler(this.btnEditTaiKhoan_Click);
            // 
            // btnAddThemTaiKhoan
            // 
            this.btnAddThemTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.btnAddThemTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddThemTaiKhoan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddThemTaiKhoan.FlatAppearance.BorderSize = 4;
            this.btnAddThemTaiKhoan.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddThemTaiKhoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddThemTaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddThemTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddThemTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnAddThemTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnAddThemTaiKhoan.Location = new System.Drawing.Point(5, 4);
            this.btnAddThemTaiKhoan.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddThemTaiKhoan.Name = "btnAddThemTaiKhoan";
            this.btnAddThemTaiKhoan.Size = new System.Drawing.Size(156, 133);
            this.btnAddThemTaiKhoan.TabIndex = 34;
            this.btnAddThemTaiKhoan.Text = "Thêm";
            this.btnAddThemTaiKhoan.UseVisualStyleBackColor = false;
            this.btnAddThemTaiKhoan.Click += new System.EventHandler(this.btnAddThemTaiKhoan_Click);
            // 
            // btnDeleteTaiKhoan
            // 
            this.btnDeleteTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteTaiKhoan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteTaiKhoan.FlatAppearance.BorderSize = 4;
            this.btnDeleteTaiKhoan.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteTaiKhoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteTaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnDeleteTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTaiKhoan.Location = new System.Drawing.Point(337, 4);
            this.btnDeleteTaiKhoan.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDeleteTaiKhoan.Name = "btnDeleteTaiKhoan";
            this.btnDeleteTaiKhoan.Size = new System.Drawing.Size(156, 133);
            this.btnDeleteTaiKhoan.TabIndex = 35;
            this.btnDeleteTaiKhoan.Text = "Xóa";
            this.btnDeleteTaiKhoan.UseVisualStyleBackColor = false;
            this.btnDeleteTaiKhoan.Click += new System.EventHandler(this.btnDeleteTaiKhoan_Click);
            // 
            // tpButtonThemThongTinQuyenTruyCap
            // 
            this.tpButtonThemThongTinQuyenTruyCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.tpButtonThemThongTinQuyenTruyCap.Controls.Add(this.groupBox4);
            this.tpButtonThemThongTinQuyenTruyCap.Location = new System.Drawing.Point(4, 38);
            this.tpButtonThemThongTinQuyenTruyCap.Name = "tpButtonThemThongTinQuyenTruyCap";
            this.tpButtonThemThongTinQuyenTruyCap.Padding = new System.Windows.Forms.Padding(3);
            this.tpButtonThemThongTinQuyenTruyCap.Size = new System.Drawing.Size(684, 180);
            this.tpButtonThemThongTinQuyenTruyCap.TabIndex = 1;
            this.tpButtonThemThongTinQuyenTruyCap.Text = "2";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.tableLayoutPanel9);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox4.Size = new System.Drawing.Size(678, 174);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thao tác dữ liệu quyền truy cập";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 4;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.Controls.Add(this.btnRefreshQuyenTruyCap, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.btnEditQuyenTruyCap, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.btnAddQuyenTruyCap, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.btnDeleteQuyenTruycap, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(5, 26);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(668, 144);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // btnRefreshQuyenTruyCap
            // 
            this.btnRefreshQuyenTruyCap.BackColor = System.Drawing.Color.Transparent;
            this.btnRefreshQuyenTruyCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefreshQuyenTruyCap.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefreshQuyenTruyCap.FlatAppearance.BorderSize = 4;
            this.btnRefreshQuyenTruyCap.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRefreshQuyenTruyCap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRefreshQuyenTruyCap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRefreshQuyenTruyCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshQuyenTruyCap.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnRefreshQuyenTruyCap.ForeColor = System.Drawing.Color.White;
            this.btnRefreshQuyenTruyCap.Location = new System.Drawing.Point(172, 4);
            this.btnRefreshQuyenTruyCap.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRefreshQuyenTruyCap.Name = "btnRefreshQuyenTruyCap";
            this.btnRefreshQuyenTruyCap.Size = new System.Drawing.Size(157, 136);
            this.btnRefreshQuyenTruyCap.TabIndex = 39;
            this.btnRefreshQuyenTruyCap.Text = "Làm mới";
            this.btnRefreshQuyenTruyCap.UseVisualStyleBackColor = false;
            this.btnRefreshQuyenTruyCap.Click += new System.EventHandler(this.btnRefreshQuyenTruyCap_Click);
            // 
            // btnEditQuyenTruyCap
            // 
            this.btnEditQuyenTruyCap.BackColor = System.Drawing.Color.Transparent;
            this.btnEditQuyenTruyCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditQuyenTruyCap.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditQuyenTruyCap.FlatAppearance.BorderSize = 4;
            this.btnEditQuyenTruyCap.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEditQuyenTruyCap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEditQuyenTruyCap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEditQuyenTruyCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditQuyenTruyCap.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnEditQuyenTruyCap.ForeColor = System.Drawing.Color.White;
            this.btnEditQuyenTruyCap.Location = new System.Drawing.Point(506, 4);
            this.btnEditQuyenTruyCap.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEditQuyenTruyCap.Name = "btnEditQuyenTruyCap";
            this.btnEditQuyenTruyCap.Size = new System.Drawing.Size(157, 136);
            this.btnEditQuyenTruyCap.TabIndex = 36;
            this.btnEditQuyenTruyCap.Text = "Sửa";
            this.btnEditQuyenTruyCap.UseVisualStyleBackColor = false;
            this.btnEditQuyenTruyCap.Click += new System.EventHandler(this.btnEditQuyenTruyCap_Click);
            // 
            // btnAddQuyenTruyCap
            // 
            this.btnAddQuyenTruyCap.BackColor = System.Drawing.Color.Transparent;
            this.btnAddQuyenTruyCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddQuyenTruyCap.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddQuyenTruyCap.FlatAppearance.BorderSize = 4;
            this.btnAddQuyenTruyCap.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddQuyenTruyCap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddQuyenTruyCap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddQuyenTruyCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuyenTruyCap.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnAddQuyenTruyCap.ForeColor = System.Drawing.Color.White;
            this.btnAddQuyenTruyCap.Location = new System.Drawing.Point(5, 4);
            this.btnAddQuyenTruyCap.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAddQuyenTruyCap.Name = "btnAddQuyenTruyCap";
            this.btnAddQuyenTruyCap.Size = new System.Drawing.Size(157, 136);
            this.btnAddQuyenTruyCap.TabIndex = 34;
            this.btnAddQuyenTruyCap.Text = "Thêm";
            this.btnAddQuyenTruyCap.UseVisualStyleBackColor = false;
            this.btnAddQuyenTruyCap.Click += new System.EventHandler(this.btnAddQuyenTruyCap_Click);
            // 
            // btnDeleteQuyenTruycap
            // 
            this.btnDeleteQuyenTruycap.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteQuyenTruycap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteQuyenTruycap.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteQuyenTruycap.FlatAppearance.BorderSize = 4;
            this.btnDeleteQuyenTruycap.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteQuyenTruycap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteQuyenTruycap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteQuyenTruycap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteQuyenTruycap.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.btnDeleteQuyenTruycap.ForeColor = System.Drawing.Color.White;
            this.btnDeleteQuyenTruycap.Location = new System.Drawing.Point(339, 4);
            this.btnDeleteQuyenTruycap.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDeleteQuyenTruycap.Name = "btnDeleteQuyenTruycap";
            this.btnDeleteQuyenTruycap.Size = new System.Drawing.Size(157, 136);
            this.btnDeleteQuyenTruycap.TabIndex = 35;
            this.btnDeleteQuyenTruycap.Text = "Xóa";
            this.btnDeleteQuyenTruycap.UseVisualStyleBackColor = false;
            this.btnDeleteQuyenTruycap.Click += new System.EventHandler(this.btnDeleteQuyenTruycap_Click);
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1192, 804);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormTaiKhoan";
            this.Text = "Danh sách tài khoản";
            this.Load += new System.EventHandler(this.FormTaiKhoan_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tabControlNhapThongTin.ResumeLayout(false);
            this.tabInputTaiKhoan.ResumeLayout(false);
            this.tabInputTaiKhoan.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tabInputQuyenTruyCap.ResumeLayout(false);
            this.tabInputQuyenTruyCap.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tabControlXemDuLieu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQTC)).EndInit();
            this.tabControlThaoTacDuLieu.ResumeLayout(false);
            this.tpButtonThemThongTinTaiKhoan.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tpButtonThemThongTinQuyenTruyCap.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TabControl tabControlNhapThongTin;
        private TabPage tabInputTaiKhoan;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label2;
        private TabPage tabInputQuyenTruyCap;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label12;
        private TextBox txtTenQTC;
        private TabControl tabControlXemDuLieu;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label14;
        private TextBox txtMaQTC;
        private TabControl tabControlThaoTacDuLieu;
        private TabPage tpButtonThemThongTinTaiKhoan;
        private TabPage tpButtonThemThongTinQuyenTruyCap;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnRefreshTaiKhoan;
        private Button btnEditTaiKhoan;
        private Button btnAddThemTaiKhoan;
        private Button btnDeleteTaiKhoan;
        private Label label1;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel9;
        private Button btnRefreshQuyenTruyCap;
        private Button btnEditQuyenTruyCap;
        private Button btnAddQuyenTruyCap;
        private Button btnDeleteQuyenTruycap;
        private GroupBox groupBox5;
        private DataGridView dgvTaiKhoan;
        private GroupBox groupBox6;
        private DataGridView dgvQTC;
        private TextBox txtMK;
        private TextBox txtTenTK;
        private Label label4;
        private ComboBox cboQTC;
        private ComboBox cboNV;
    }
}