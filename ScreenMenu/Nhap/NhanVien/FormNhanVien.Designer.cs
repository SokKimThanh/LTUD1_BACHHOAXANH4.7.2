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
            this.components = new System.ComponentModel.Container();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tblNhanVien = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDanhSach = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.cmsNhanVien = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInFilePDF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmXuatFileExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.tabReport = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTimKiemThongKe = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.tblNhanVien.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDanhSach.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.cmsNhanVien.SuspendLayout();
            this.tabReport.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            // groupBox14
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
            // tableLayoutPanel6
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
            // btnEdit
            // 
            cmsNhanVien.BackColor = SystemColors.ActiveBorder;
            cmsNhanVien.Items.AddRange(new ToolStripItem[] { tsmThongKe, tsmInFilePDF, tsmXuatFileExcel });
            cmsNhanVien.Name = "contextMenuStrip1";
            cmsNhanVien.Size = new Size(164, 76);
            // 
            // btnRefresh
            // 
            tsmThongKe.BackColor = Color.FromArgb(255, 192, 192);
            tsmThongKe.Name = "tsmThongKe";
            tsmThongKe.Size = new Size(163, 24);
            tsmThongKe.Text = "Thống kê";
            tsmThongKe.Click += tsmThongKe_Click;
            // 
            // btnDelete
            // 
            tsmInFilePDF.BackColor = Color.FromArgb(255, 192, 192);
            tsmInFilePDF.Name = "tsmInFilePDF";
            tsmInFilePDF.Size = new Size(163, 24);
            tsmInFilePDF.Text = "Xuất File PDF";
            tsmInFilePDF.Click += tsmInFilePDF_Click;
            // 
            // btnAdd
            // 
            tsmXuatFileExcel.BackColor = Color.FromArgb(255, 192, 192);
            tsmXuatFileExcel.Name = "tsmXuatFileExcel";
            tsmXuatFileExcel.Size = new Size(163, 24);
            tsmXuatFileExcel.Text = "Xuất File Excel";
            tsmXuatFileExcel.Click += tsmInFileExcel_Click;
            // 
            // tableLayoutPanel1
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
            // txtHoTen
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
            // btnTimKiem
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
            // tabControl1
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
            // tabDanhSach
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvNhanVien);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(873, 440);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.ContextMenuStrip = this.cmsNhanVien;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 35);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(867, 402);
            this.dgvNhanVien.TabIndex = 0;
            // 
            // cmsNhanVien
            // 
            this.cmsNhanVien.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            // tabReport
            // 
            this.tabReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.tabReport.Controls.Add(this.tableLayoutPanel4);
            this.tabReport.Location = new System.Drawing.Point(4, 41);
            this.tabReport.Name = "tabReport";
            this.tabReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabReport.Size = new System.Drawing.Size(879, 446);
            this.tabReport.TabIndex = 1;
            this.tabReport.Text = "Report";
            // 
            // tableLayoutPanel4
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.ForeColor = System.Drawing.Color.Black;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 64);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(867, 373);
            this.crystalReportViewer1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(83, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(528, 49);
            this.textBox1.TabIndex = 0;
            // 
            // btnTimKiemThongKe
            // 
            this.btnTimKiemThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimKiemThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiemThongKe.Location = new System.Drawing.Point(616, 3);
            this.btnTimKiemThongKe.Name = "btnTimKiemThongKe";
            this.btnTimKiemThongKe.Size = new System.Drawing.Size(248, 49);
            this.btnTimKiemThongKe.TabIndex = 2;
            this.btnTimKiemThongKe.Text = "Tìm kiếm";
            this.btnTimKiemThongKe.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.ForeColor = System.Drawing.Color.Black;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 64);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(867, 373);
            this.crystalReportViewer1.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tblNhanVien, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1284, 729);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 723);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
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
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.crystalReportViewer1, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.86364F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.13636F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(873, 440);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.02932F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.97068F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnTimKiemThongKe, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(867, 55);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // btnTimKiemThongKe
            // 
            this.btnTimKiemThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimKiemThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiemThongKe.Location = new System.Drawing.Point(617, 3);
            this.btnTimKiemThongKe.Name = "btnTimKiemThongKe";
            this.btnTimKiemThongKe.Size = new System.Drawing.Size(247, 49);
            this.btnTimKiemThongKe.TabIndex = 2;
            this.btnTimKiemThongKe.Text = "Tìm kiếm";
            this.btnTimKiemThongKe.UseVisualStyleBackColor = true;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1284, 729);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormNhanVien";
            this.Text = "Nhập thông tin nhân viên";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            this.tblNhanVien.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabDanhSach.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.cmsNhanVien.ResumeLayout(false);
            this.tabReport.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

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
        private TabControl tabControl1;
        private TabPage tabDanhSach;
        private TabPage tabReport;
        private TextBox textBox1;
        private GroupBox groupBox3;
        private DataGridView dgvNhanVien;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btnTimKiemThongKe;
    }
}