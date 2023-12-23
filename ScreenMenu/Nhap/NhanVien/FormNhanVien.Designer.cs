using System.Drawing;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
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
            this.components = new System.ComponentModel.Container();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.cmsNhanVien = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInFilePDF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmXuatFileExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDanhSach = new System.Windows.Forms.TabPage();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbltwoColumn = new System.Windows.Forms.TableLayoutPanel();
            this.tblTimKiemThongTin = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtHoTenNV = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rptNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rtbDiaChi = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.tblNhanVien = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tcNhanVien = new System.Windows.Forms.TabControl();
            this.tbDanhSachNhanVien = new System.Windows.Forms.TabPage();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboLoaiBaoCao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dataSet1 = new System.Data.DataSet();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.cmsNhanVien.SuspendLayout();
            this.tabReport.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbltwoColumn.SuspendLayout();
            this.tblTimKiemThongTin.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tblNhanVien.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tcNhanVien.SuspendLayout();
            this.tbDanhSachNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox18
            // 
            this.groupBox18.Location = new System.Drawing.Point(0, 0);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(200, 100);
            this.groupBox18.TabIndex = 0;
            this.groupBox18.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.groupBox19, 0, 2);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.textBox5);
            this.groupBox19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox19.ForeColor = System.Drawing.Color.White;
            this.groupBox19.Location = new System.Drawing.Point(3, 3);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(194, 94);
            this.groupBox19.TabIndex = 12;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Họ tên";
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(3, 16);
            this.textBox5.Margin = new System.Windows.Forms.Padding(5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(188, 20);
            this.textBox5.TabIndex = 5;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.textBox6);
            this.groupBox20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox20.ForeColor = System.Drawing.Color.White;
            this.groupBox20.Location = new System.Drawing.Point(3, 86);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(194, 77);
            this.groupBox20.TabIndex = 11;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Số điện thoại";
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Location = new System.Drawing.Point(3, 16);
            this.textBox6.Margin = new System.Windows.Forms.Padding(5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(188, 20);
            this.textBox6.TabIndex = 9;
            // 
            // cmsNhanVien
            // 
            this.cmsNhanVien.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cmsNhanVien.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsNhanVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmThongKe,
            this.tsmInFilePDF,
            this.tsmXuatFileExcel});
            this.cmsNhanVien.Name = "contextMenuStrip1";
            this.cmsNhanVien.Size = new System.Drawing.Size(164, 76);
            // 
            // tsmThongKe
            // 
            this.tsmThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tsmThongKe.Name = "tsmThongKe";
            this.tsmThongKe.Size = new System.Drawing.Size(163, 24);
            this.tsmThongKe.Text = "Thống kê";
            // 
            // tsmInFilePDF
            // 
            this.tsmInFilePDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tsmInFilePDF.Name = "tsmInFilePDF";
            this.tsmInFilePDF.Size = new System.Drawing.Size(163, 24);
            this.tsmInFilePDF.Text = "Xuất File PDF";
            // 
            // tsmXuatFileExcel
            // 
            this.tsmXuatFileExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tsmXuatFileExcel.Name = "tsmXuatFileExcel";
            this.tsmXuatFileExcel.Size = new System.Drawing.Size(163, 24);
            this.tsmXuatFileExcel.Text = "Xuất File Excel";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(0, 0);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(100, 20);
            this.txtHoTen.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDanhSach
            // 
            this.tabDanhSach.Location = new System.Drawing.Point(0, 0);
            this.tabDanhSach.Name = "tabDanhSach";
            this.tabDanhSach.Size = new System.Drawing.Size(200, 100);
            this.tabDanhSach.TabIndex = 0;
            this.tabDanhSach.Text = "Danh sách";
            // 
            // tabReport
            // 
            this.tabReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.tabReport.Controls.Add(this.tableLayoutPanel8);
            this.tabReport.Location = new System.Drawing.Point(4, 41);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabReport.Size = new System.Drawing.Size(879, 446);
            this.tabReport.TabIndex = 1;
            this.tabReport.Text = "Báo cáo thống kê";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.95304F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.04697F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(873, 440);
            this.tableLayoutPanel8.TabIndex = 4;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(151, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.04545F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.95454F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(719, 434);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.53344F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.46656F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 253F));
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(713, 46);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi Nhánh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label2.Location = new System.Drawing.Point(287, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phòng ban";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Phòng Ban";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Trưởng Phòng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1284, 729);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.tabPage1.Controls.Add(this.tbltwoColumn);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1276, 695);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý nhân viên";
            // 
            // tbltwoColumn
            // 
            this.tbltwoColumn.ColumnCount = 2;
            this.tbltwoColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbltwoColumn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tbltwoColumn.Controls.Add(this.tblTimKiemThongTin, 0, 0);
            this.tbltwoColumn.Controls.Add(this.tblNhanVien, 1, 0);
            this.tbltwoColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbltwoColumn.Location = new System.Drawing.Point(3, 3);
            this.tbltwoColumn.Name = "tbltwoColumn";
            this.tbltwoColumn.RowCount = 1;
            this.tbltwoColumn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbltwoColumn.Size = new System.Drawing.Size(1270, 689);
            this.tbltwoColumn.TabIndex = 13;
            // 
            // tblTimKiemThongTin
            // 
            this.tblTimKiemThongTin.AutoScroll = true;
            this.tblTimKiemThongTin.ColumnCount = 1;
            this.tblTimKiemThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTimKiemThongTin.Controls.Add(this.groupBox5, 0, 6);
            this.tblTimKiemThongTin.Controls.Add(this.groupBox2, 0, 5);
            this.tblTimKiemThongTin.Controls.Add(this.groupBox9, 0, 1);
            this.tblTimKiemThongTin.Controls.Add(this.groupBox8, 0, 3);
            this.tblTimKiemThongTin.Controls.Add(this.groupBox7, 0, 2);
            this.tblTimKiemThongTin.Controls.Add(this.groupBox6, 0, 4);
            this.tblTimKiemThongTin.Controls.Add(this.groupBox4, 0, 0);
            this.tblTimKiemThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTimKiemThongTin.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.tblTimKiemThongTin.Location = new System.Drawing.Point(3, 3);
            this.tblTimKiemThongTin.Name = "tblTimKiemThongTin";
            this.tblTimKiemThongTin.RowCount = 8;
            this.tblTimKiemThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tblTimKiemThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tblTimKiemThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tblTimKiemThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tblTimKiemThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tblTimKiemThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tblTimKiemThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tblTimKiemThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tblTimKiemThongTin.Size = new System.Drawing.Size(311, 683);
            this.tblTimKiemThongTin.TabIndex = 17;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.flowLayoutPanel1);
            this.groupBox5.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(3, 435);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(305, 66);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Giới tính";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.rbNam);
            this.flowLayoutPanel1.Controls.Add(this.rbNu);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(299, 35);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Checked = true;
            this.rbNam.Location = new System.Drawing.Point(19, 3);
            this.rbNam.Name = "rbNam";
            this.rbNam.Padding = new System.Windows.Forms.Padding(4);
            this.rbNam.Size = new System.Drawing.Size(76, 37);
            this.rbNam.TabIndex = 0;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(101, 3);
            this.rbNu.Name = "rbNu";
            this.rbNu.Padding = new System.Windows.Forms.Padding(4);
            this.rbNu.Size = new System.Drawing.Size(61, 37);
            this.rbNu.TabIndex = 1;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLuong);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lương";
            // 
            // txtLuong
            // 
            this.txtLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLuong.Location = new System.Drawing.Point(3, 28);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(5);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(299, 32);
            this.txtLuong.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtHoTenNV);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.ForeColor = System.Drawing.Color.White;
            this.groupBox9.Location = new System.Drawing.Point(3, 75);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(305, 66);
            this.groupBox9.TabIndex = 12;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Họ tên";
            // 
            // txtHoTenNV
            // 
            this.txtHoTenNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHoTenNV.Location = new System.Drawing.Point(3, 28);
            this.txtHoTenNV.Margin = new System.Windows.Forms.Padding(5);
            this.txtHoTenNV.Name = "txtHoTenNV";
            this.txtHoTenNV.Size = new System.Drawing.Size(299, 32);
            this.txtHoTenNV.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtSDT);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.ForeColor = System.Drawing.Color.White;
            this.groupBox8.Location = new System.Drawing.Point(3, 219);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(305, 66);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSDT.Location = new System.Drawing.Point(3, 28);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(299, 32);
            this.txtSDT.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rptNgaySinh);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(3, 147);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(305, 66);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ngày sinh";
            // 
            // rptNgaySinh
            // 
            this.rptNgaySinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rptNgaySinh.Location = new System.Drawing.Point(3, 28);
            this.rptNgaySinh.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.rptNgaySinh.Name = "rptNgaySinh";
            this.rptNgaySinh.Size = new System.Drawing.Size(299, 32);
            this.rptNgaySinh.TabIndex = 19;
            // 
            // groupBox6
            // 
            this.groupBox6.AutoSize = true;
            this.groupBox6.Controls.Add(this.rtbDiaChi);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(3, 291);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(305, 66);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Địa chỉ";
            // 
            // rtbDiaChi
            // 
            this.rtbDiaChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDiaChi.Location = new System.Drawing.Point(3, 28);
            this.rtbDiaChi.Name = "rtbDiaChi";
            this.rtbDiaChi.Size = new System.Drawing.Size(299, 35);
            this.rtbDiaChi.TabIndex = 0;
            this.rtbDiaChi.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboPhongBan);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.ForeColor = System.Drawing.Color.Snow;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(305, 66);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Phòng ban";
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(3, 28);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(299, 33);
            this.cboPhongBan.TabIndex = 3;
            // 
            // tblNhanVien
            // 
            this.tblNhanVien.ColumnCount = 1;
            this.tblNhanVien.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblNhanVien.Controls.Add(this.groupBox14, 0, 1);
            this.tblNhanVien.Controls.Add(this.tcNhanVien, 0, 0);
            this.tblNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblNhanVien.Location = new System.Drawing.Point(320, 3);
            this.tblNhanVien.Name = "tblNhanVien";
            this.tblNhanVien.RowCount = 2;
            this.tblNhanVien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblNhanVien.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblNhanVien.Size = new System.Drawing.Size(947, 683);
            this.tblNhanVien.TabIndex = 6;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.tableLayoutPanel6);
            this.groupBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox14.ForeColor = System.Drawing.Color.White;
            this.groupBox14.Location = new System.Drawing.Point(3, 549);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(941, 131);
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
            this.tableLayoutPanel6.Controls.Add(this.btnSearch, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnRefresh, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnDelete, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnEdit, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(935, 103);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.FlatAppearance.BorderSize = 3;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.SeaShell;
            this.btnSearch.Location = new System.Drawing.Point(470, 5);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 93);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(625, 5);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(145, 93);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.SeaShell;
            this.btnDelete.Location = new System.Drawing.Point(315, 5);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 93);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.FlatAppearance.BorderSize = 3;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.SeaShell;
            this.btnEdit.Location = new System.Drawing.Point(5, 5);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(145, 93);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.ContextMenuStrip = this.cmsNhanVien;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.SeaShell;
            this.btnAdd.Location = new System.Drawing.Point(160, 5);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 93);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // tcNhanVien
            // 
            this.tcNhanVien.Controls.Add(this.tbDanhSachNhanVien);
            this.tcNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcNhanVien.Location = new System.Drawing.Point(3, 3);
            this.tcNhanVien.Name = "tcNhanVien";
            this.tcNhanVien.SelectedIndex = 0;
            this.tcNhanVien.Size = new System.Drawing.Size(941, 540);
            this.tcNhanVien.TabIndex = 9;
            // 
            // tbDanhSachNhanVien
            // 
            this.tbDanhSachNhanVien.AutoScroll = true;
            this.tbDanhSachNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.tbDanhSachNhanVien.Controls.Add(this.dgvNhanVien);
            this.tbDanhSachNhanVien.Location = new System.Drawing.Point(4, 30);
            this.tbDanhSachNhanVien.Name = "tbDanhSachNhanVien";
            this.tbDanhSachNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tbDanhSachNhanVien.Size = new System.Drawing.Size(933, 506);
            this.tbDanhSachNhanVien.TabIndex = 0;
            this.tbDanhSachNhanVien.Text = "Danh sách";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 3);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.Size = new System.Drawing.Size(927, 500);
            this.dgvNhanVien.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1276, 695);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "In báo cáo, thống kê";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.crystalReportViewer1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1270, 689);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cboLoaiBaoCao, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cboNhanVien, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1270, 40);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(638, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại báo cáo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboLoaiBaoCao
            // 
            this.cboLoaiBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboLoaiBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLoaiBaoCao.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.cboLoaiBaoCao.FormattingEnabled = true;
            this.cboLoaiBaoCao.Location = new System.Drawing.Point(894, 3);
            this.cboLoaiBaoCao.Name = "cboLoaiBaoCao";
            this.cboLoaiBaoCao.Size = new System.Drawing.Size(373, 33);
            this.cboLoaiBaoCao.TabIndex = 0;
            this.cboLoaiBaoCao.SelectedIndexChanged += new System.EventHandler(this.cboLoaiBaoCao_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 40);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhân viên";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNhanVien.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(259, 3);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(373, 33);
            this.cboNhanVien.TabIndex = 0;
            // 
            // cryKhachHang
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 40);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(0);
            this.crystalReportViewer1.Name = "cryKhachHang";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1270, 649);
            this.crystalReportViewer1.TabIndex = 3;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1284, 729);
            this.Controls.Add(this.tabControl2);
            this.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormNhanVien";
            this.Text = "Nhập thông tin nhân viên";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.cmsNhanVien.ResumeLayout(false);
            this.tabReport.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tbltwoColumn.ResumeLayout(false);
            this.tblTimKiemThongTin.ResumeLayout(false);
            this.tblTimKiemThongTin.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tblNhanVien.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tcNhanVien.ResumeLayout(false);
            this.tbDanhSachNhanVien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox18;
        private TableLayoutPanel tableLayoutPanel7;
        private GroupBox groupBox19;
        private TextBox textBox5;
        private GroupBox groupBox20;
        private TextBox textBox6;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private ContextMenuStrip cmsNhanVien;
        private ToolStripMenuItem tsmThongKe;
        private ToolStripMenuItem tsmInFilePDF;

        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem tsmXuatFileExcel;
        private TextBox txtHoTen;
        private TabControl tabControl1;
        private TabPage tabDanhSach;
        private TabPage tabReport;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;

        private Label label2;
        private TableLayoutPanel tableLayoutPanel8;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private TableLayoutPanel tbltwoColumn;
        private TableLayoutPanel tblTimKiemThongTin;
        private GroupBox groupBox5;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton rbNam;
        private RadioButton rbNu;
        private GroupBox groupBox2;
        private TextBox txtLuong;
        private GroupBox groupBox9;
        private TextBox txtHoTenNV;
        private GroupBox groupBox8;
        private TextBox txtSDT;
        private GroupBox groupBox7;
        private DateTimePicker rptNgaySinh;
        private GroupBox groupBox6;
        private RichTextBox rtbDiaChi;
        private GroupBox groupBox4;
        private ComboBox cboPhongBan;
        private TableLayoutPanel tblNhanVien;
        private GroupBox groupBox14;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btnSearch;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private TabControl tcNhanVien;
        private TabPage tbDanhSachNhanVien;
        private DataGridView dgvNhanVien;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private ComboBox cboLoaiBaoCao;
        private Label label4;
        private ComboBox cboNhanVien;
        private System.Data.DataSet dataSet1;
    }
}