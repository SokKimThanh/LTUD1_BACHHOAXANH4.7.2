using System.Drawing;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.Screen
{
    partial class FormHoaDon
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
            tableLayoutPanel4 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            groupBox4 = new GroupBox();
            dgvHD = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox7 = new GroupBox();
            txtMaHD = new TextBox();
            groupBox9 = new GroupBox();
            txtTongTien = new TextBox();
            groupBox6 = new GroupBox();
            dtpkNgayLap = new DateTimePicker();
            groupBox5 = new GroupBox();
            cbbMaKH = new ComboBox();
            groupBox2 = new GroupBox();
            cbbMaNV = new ComboBox();
            tableLayoutPanel4.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHD).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(groupBox3, 0, 1);
            tableLayoutPanel4.Controls.Add(groupBox4, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(388, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Size = new Size(893, 723);
            tableLayoutPanel4.TabIndex = 24;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableLayoutPanel1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(3, 581);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(887, 139);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thao tác dữ liệu";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.Controls.Add(btnSua, 0, 0);
            tableLayoutPanel1.Controls.Add(btnXoa, 0, 0);
            tableLayoutPanel1.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(3, 35);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 162F));
            tableLayoutPanel1.Size = new Size(881, 101);
            tableLayoutPanel1.TabIndex = 0;
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
            btnSua.Location = new Point(297, 5);
            btnSua.Margin = new Padding(5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(136, 91);
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
            btnXoa.Location = new Point(151, 5);
            btnXoa.Margin = new Padding(5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(136, 91);
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
            btnThem.Size = new Size(136, 91);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvHD);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(887, 572);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách";
            // 
            // dgvHD
            // 
            dgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHD.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHD.Location = new Point(6, 40);
            dgvHD.MultiSelect = false;
            dgvHD.Name = "dgvHD";
            dgvHD.RowHeadersWidth = 51;
            dgvHD.RowTemplate.Height = 29;
            dgvHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHD.Size = new Size(875, 526);
            dgvHD.TabIndex = 0;
            dgvHD.CellContentClick += dgvHD_CellContentClick;
            dgvHD.Click += dgvHD_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.ForeColor = Color.Black;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1284, 729);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 723);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(groupBox7, 0, 0);
            tableLayoutPanel3.Controls.Add(groupBox9, 0, 3);
            tableLayoutPanel3.Controls.Add(groupBox6, 0, 2);
            tableLayoutPanel3.Controls.Add(groupBox5, 0, 1);
            tableLayoutPanel3.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 35);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 6;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel3.Size = new Size(373, 685);
            tableLayoutPanel3.TabIndex = 19;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(txtMaHD);
            groupBox7.Dock = DockStyle.Fill;
            groupBox7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox7.ForeColor = Color.White;
            groupBox7.Location = new Point(0, 0);
            groupBox7.Margin = new Padding(0);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(373, 114);
            groupBox7.TabIndex = 9;
            groupBox7.TabStop = false;
            groupBox7.Text = "Mã Hóa Đơn";
            // 
            // txtMaHD
            // 
            txtMaHD.Dock = DockStyle.Fill;
            txtMaHD.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaHD.Location = new Point(3, 29);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(367, 39);
            txtMaHD.TabIndex = 2;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(txtTongTien);
            groupBox9.Dock = DockStyle.Fill;
            groupBox9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox9.ForeColor = Color.White;
            groupBox9.Location = new Point(0, 456);
            groupBox9.Margin = new Padding(0);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(373, 114);
            groupBox9.TabIndex = 8;
            groupBox9.TabStop = false;
            groupBox9.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.Dock = DockStyle.Fill;
            txtTongTien.Enabled = false;
            txtTongTien.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtTongTien.Location = new Point(3, 29);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(367, 39);
            txtTongTien.TabIndex = 2;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dtpkNgayLap);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox6.ForeColor = Color.White;
            groupBox6.Location = new Point(0, 342);
            groupBox6.Margin = new Padding(0);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(373, 114);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Ngày lập";
            // 
            // dtpkNgayLap
            // 
            dtpkNgayLap.Dock = DockStyle.Fill;
            dtpkNgayLap.Format = DateTimePickerFormat.Short;
            dtpkNgayLap.Location = new Point(3, 29);
            dtpkNgayLap.Margin = new Padding(6, 4, 6, 4);
            dtpkNgayLap.Name = "dtpkNgayLap";
            dtpkNgayLap.Size = new Size(367, 33);
            dtpkNgayLap.TabIndex = 14;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(cbbMaKH);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(0, 114);
            groupBox5.Margin = new Padding(0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(373, 114);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Khách hàng";
            // 
            // cbbMaKH
            // 
            cbbMaKH.Dock = DockStyle.Fill;
            cbbMaKH.FormattingEnabled = true;
            cbbMaKH.Location = new Point(3, 29);
            cbbMaKH.Margin = new Padding(6, 4, 6, 4);
            cbbMaKH.Name = "cbbMaKH";
            cbbMaKH.Size = new Size(367, 33);
            cbbMaKH.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbbMaNV);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(3, 231);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(367, 108);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nhân viên";
            // 
            // cbbMaNV
            // 
            cbbMaNV.Dock = DockStyle.Fill;
            cbbMaNV.FormattingEnabled = true;
            cbbMaNV.Location = new Point(3, 29);
            cbbMaNV.Margin = new Padding(6, 4, 6, 4);
            cbbMaNV.Name = "cbbMaNV";
            cbbMaNV.Size = new Size(361, 33);
            cbbMaNV.TabIndex = 9;
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 88, 52);
            ClientSize = new Size(1284, 729);
            Controls.Add(tableLayoutPanel2);
            Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            Margin = new Padding(6, 4, 6, 4);
            Name = "FormHoaDon";
            Text = "Danh sách hóa đơn";
            Load += FormHoaDon_Load;
            tableLayoutPanel4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHD).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox9;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private ComboBox cbbMaKH;
        private GroupBox groupBox2;
        private ComboBox cbbMaNV;
        private DateTimePicker dtpkNgayLap;
        private TextBox txtTongTien;
        private DataGridView dgvHD;
        private GroupBox groupBox7;
        private TextBox txtMaHD;
    }
}