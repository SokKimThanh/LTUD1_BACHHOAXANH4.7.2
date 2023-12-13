using System.Drawing;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap
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
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            rtbDonVi = new RichTextBox();
            groupBox9 = new GroupBox();
            dtpNSX = new DateTimePicker();
            groupBox8 = new GroupBox();
            txtDonGia = new TextBox();
            groupBox7 = new GroupBox();
            dtpHSD = new DateTimePicker();
            groupBox6 = new GroupBox();
            rtbSL = new RichTextBox();
            groupBox5 = new GroupBox();
            txtTenSP = new TextBox();
            groupBox4 = new GroupBox();
            txtMaSP = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            groupBox15 = new GroupBox();
            dgvDanhSachSP = new DataGridView();
            groupBox14 = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox11 = new GroupBox();
            cboKM = new ComboBox();
            groupBox10 = new GroupBox();
            cboLoaiSP = new ComboBox();
            groupBox3 = new GroupBox();
            cboNCC = new ComboBox();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSP).BeginInit();
            groupBox14.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1370, 749);
            tableLayoutPanel3.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(405, 743);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBox2, 0, 6);
            tableLayoutPanel2.Controls.Add(groupBox9, 0, 2);
            tableLayoutPanel2.Controls.Add(groupBox8, 0, 4);
            tableLayoutPanel2.Controls.Add(groupBox7, 0, 3);
            tableLayoutPanel2.Controls.Add(groupBox6, 0, 5);
            tableLayoutPanel2.Controls.Add(groupBox5, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 43);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel2.Size = new Size(399, 697);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rtbDonVi);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(3, 597);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 97);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Đơn vị tính";
            // 
            // rtbDonVi
            // 
            rtbDonVi.Dock = DockStyle.Fill;
            rtbDonVi.Location = new Point(3, 43);
            rtbDonVi.Name = "rtbDonVi";
            rtbDonVi.Size = new Size(387, 51);
            rtbDonVi.TabIndex = 10;
            rtbDonVi.Text = "";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(dtpNSX);
            groupBox9.Dock = DockStyle.Fill;
            groupBox9.ForeColor = Color.White;
            groupBox9.Location = new Point(3, 201);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(393, 93);
            groupBox9.TabIndex = 12;
            groupBox9.TabStop = false;
            groupBox9.Text = "Ngày sản xuất:";
            // 
            // dtpNSX
            // 
            dtpNSX.Dock = DockStyle.Fill;
            dtpNSX.Format = DateTimePickerFormat.Short;
            dtpNSX.Location = new Point(3, 43);
            dtpNSX.Margin = new Padding(6, 4, 6, 4);
            dtpNSX.Name = "dtpNSX";
            dtpNSX.Size = new Size(387, 47);
            dtpNSX.TabIndex = 20;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(txtDonGia);
            groupBox8.Dock = DockStyle.Fill;
            groupBox8.ForeColor = Color.White;
            groupBox8.Location = new Point(3, 399);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(393, 93);
            groupBox8.TabIndex = 11;
            groupBox8.TabStop = false;
            groupBox8.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            txtDonGia.Dock = DockStyle.Fill;
            txtDonGia.Location = new Point(3, 43);
            txtDonGia.Margin = new Padding(5);
            txtDonGia.Name = "txtDonGia";
            //txtDonGia.PlaceholderText = "Đơn giá mặt hàng";
            txtDonGia.Size = new Size(387, 47);
            txtDonGia.TabIndex = 9;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(dtpHSD);
            groupBox7.Dock = DockStyle.Fill;
            groupBox7.ForeColor = Color.White;
            groupBox7.Location = new Point(3, 300);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(393, 93);
            groupBox7.TabIndex = 10;
            groupBox7.TabStop = false;
            groupBox7.Text = "Hạn sử dụng:";
            // 
            // dtpHSD
            // 
            dtpHSD.Dock = DockStyle.Fill;
            dtpHSD.Format = DateTimePickerFormat.Short;
            dtpHSD.Location = new Point(3, 43);
            dtpHSD.Margin = new Padding(6, 4, 6, 4);
            dtpHSD.Name = "dtpHSD";
            dtpHSD.Size = new Size(387, 47);
            dtpHSD.TabIndex = 19;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(rtbSL);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.ForeColor = Color.White;
            groupBox6.Location = new Point(3, 498);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(393, 93);
            groupBox6.TabIndex = 9;
            groupBox6.TabStop = false;
            groupBox6.Text = "Tồn kho";
            // 
            // rtbSL
            // 
            rtbSL.Dock = DockStyle.Fill;
            rtbSL.Location = new Point(3, 43);
            rtbSL.Name = "rtbSL";
            rtbSL.Size = new Size(387, 47);
            rtbSL.TabIndex = 10;
            rtbSL.Text = "";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtTenSP);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.ForeColor = Color.Snow;
            groupBox5.Location = new Point(3, 102);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(393, 93);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tên sản phẩm";
            // 
            // txtTenSP
            // 
            txtTenSP.Dock = DockStyle.Fill;
            txtTenSP.Location = new Point(3, 43);
            txtTenSP.Margin = new Padding(5);
            txtTenSP.Name = "txtTenSP";
            //txtTenSP.PlaceholderText = "Tên mặt hàng";
            txtTenSP.Size = new Size(387, 47);
            txtTenSP.TabIndex = 10;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtMaSP);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.ForeColor = Color.Snow;
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(393, 93);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Mã sản phẩm";
            // 
            // txtMaSP
            // 
            txtMaSP.Dock = DockStyle.Fill;
            txtMaSP.Location = new Point(3, 43);
            txtMaSP.Margin = new Padding(5);
            txtMaSP.Name = "txtMaSP";
            //txtMaSP.PlaceholderText = "Mã mặt hàng";
            txtMaSP.Size = new Size(387, 47);
            txtMaSP.TabIndex = 11;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(groupBox15, 0, 1);
            tableLayoutPanel5.Controls.Add(groupBox14, 0, 2);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(414, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.55451F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 63.52624F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9192486F));
            tableLayoutPanel5.Size = new Size(953, 743);
            tableLayoutPanel5.TabIndex = 6;
            // 
            // groupBox15
            // 
            groupBox15.Controls.Add(dgvDanhSachSP);
            groupBox15.Dock = DockStyle.Fill;
            groupBox15.ForeColor = Color.White;
            groupBox15.Location = new Point(3, 126);
            groupBox15.Name = "groupBox15";
            groupBox15.Size = new Size(947, 465);
            groupBox15.TabIndex = 7;
            groupBox15.TabStop = false;
            groupBox15.Text = "Danh sách";
            // 
            // dgvDanhSachSP
            // 
            dgvDanhSachSP.AllowUserToOrderColumns = true;
            dgvDanhSachSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvDanhSachSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSP.Location = new Point(3, 46);
            dgvDanhSachSP.Name = "dgvDanhSachSP";
            dgvDanhSachSP.RowHeadersWidth = 51;
            dgvDanhSachSP.RowTemplate.Height = 29;
            dgvDanhSachSP.Size = new Size(933, 389);
            dgvDanhSachSP.TabIndex = 0;
            dgvDanhSachSP.CellContentClick += dgvDanhSachSP_CellContentClick;
            // 
            // groupBox14
            // 
            groupBox14.Controls.Add(tableLayoutPanel6);
            groupBox14.Dock = DockStyle.Fill;
            groupBox14.ForeColor = Color.White;
            groupBox14.Location = new Point(3, 597);
            groupBox14.Name = "groupBox14";
            groupBox14.Size = new Size(947, 143);
            groupBox14.TabIndex = 8;
            groupBox14.TabStop = false;
            groupBox14.Text = "Thao tác dữ liệu";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 6;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel6.Controls.Add(btnSua, 0, 0);
            tableLayoutPanel6.Controls.Add(btnXoa, 0, 0);
            tableLayoutPanel6.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel6.Location = new Point(3, 43);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 162F));
            tableLayoutPanel6.Size = new Size(941, 97);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Transparent;
            btnSua.Dock = DockStyle.Fill;
            btnSua.FlatAppearance.BorderSize = 3;
            btnSua.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnSua.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = Color.SeaShell;
            btnSua.Location = new Point(317, 5);
            btnSua.Margin = new Padding(5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(146, 87);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Transparent;
            btnXoa.Dock = DockStyle.Fill;
            btnXoa.FlatAppearance.BorderSize = 3;
            btnXoa.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnXoa.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = Color.SeaShell;
            btnXoa.Location = new Point(161, 5);
            btnXoa.Margin = new Padding(5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(146, 87);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.Transparent;
            btnThem.Dock = DockStyle.Fill;
            btnThem.FlatAppearance.BorderSize = 3;
            btnThem.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnThem.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = Color.SeaShell;
            btnThem.Location = new Point(5, 5);
            btnThem.Margin = new Padding(5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(146, 87);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(groupBox11, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox10, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(947, 117);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(cboKM);
            groupBox11.Dock = DockStyle.Fill;
            groupBox11.ForeColor = Color.Snow;
            groupBox11.Location = new Point(633, 3);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(311, 111);
            groupBox11.TabIndex = 3;
            groupBox11.TabStop = false;
            groupBox11.Text = "Khuyến Mãi";
            // 
            // cboKM
            // 
            cboKM.DisplayMember = "None";
            cboKM.Dock = DockStyle.Fill;
            cboKM.FormattingEnabled = true;
            cboKM.Location = new Point(3, 43);
            cboKM.Margin = new Padding(5);
            cboKM.Name = "cboKM";
            cboKM.Size = new Size(305, 49);
            cboKM.TabIndex = 0;
            cboKM.Text = "None";
            cboKM.ValueMember = "None";
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(cboLoaiSP);
            groupBox10.Dock = DockStyle.Fill;
            groupBox10.ForeColor = Color.Snow;
            groupBox10.Location = new Point(318, 3);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(309, 111);
            groupBox10.TabIndex = 2;
            groupBox10.TabStop = false;
            groupBox10.Text = "Loại sản phẩm";
            // 
            // cboLoaiSP
            // 
            cboLoaiSP.Dock = DockStyle.Fill;
            cboLoaiSP.FormattingEnabled = true;
            cboLoaiSP.Location = new Point(3, 43);
            cboLoaiSP.Margin = new Padding(5);
            cboLoaiSP.Name = "cboLoaiSP";
            cboLoaiSP.Size = new Size(303, 49);
            cboLoaiSP.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboNCC);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.ForeColor = Color.Snow;
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(309, 111);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nhà cung cấp";
            // 
            // cboNCC
            // 
            cboNCC.Dock = DockStyle.Fill;
            cboNCC.FormattingEnabled = true;
            cboNCC.Location = new Point(3, 43);
            cboNCC.Margin = new Padding(5);
            cboNCC.Name = "cboNCC";
            cboNCC.Size = new Size(303, 49);
            cboNCC.TabIndex = 0;
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(16F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 88, 52);
            ClientSize = new Size(1370, 749);
            Controls.Add(tableLayoutPanel3);
            Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(6);
            Name = "FormSanPham";
            Text = "Danh mục sản phẩm";
            Load += FormSanPham_Load;
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            groupBox15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSP).EndInit();
            groupBox14.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox11.ResumeLayout(false);
            groupBox10.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox9;
  
        private GroupBox groupBox8;
        private TextBox txtDonGia;
        private GroupBox groupBox7;
        private DateTimePicker dtpHSD;
        private GroupBox groupBox6;
        private RichTextBox rtbSL;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox groupBox15;
        private GroupBox groupBox14;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox2;
        private RichTextBox rtbDonVi;
        private TextBox txtTenSP;
        private DataGridView dgvDanhSachSP;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox11;
        private ComboBox cboKM;
        private GroupBox groupBox10;
        private ComboBox cboLoaiSP;
        private GroupBox groupBox3;
        private ComboBox cboNCC;
        private DateTimePicker dtpNSX;
        private TextBox txtMaSP;
    }
}