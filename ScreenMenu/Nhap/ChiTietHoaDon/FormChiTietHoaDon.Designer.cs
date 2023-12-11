using System.Drawing;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.ScreenDetail
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox6 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            cboSanPham = new ComboBox();
            groupBox13 = new GroupBox();
            cboLoaiSanPham = new ComboBox();
            groupBox9 = new GroupBox();
            cboHoaDon = new ComboBox();
            label4 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnEditSanPham = new Button();
            btnAddSP = new Button();
            btnDeleteSP = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            groupBox5 = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            txtThanhTien = new TextBox();
            btnKTTonKho = new Button();
            txtSoLuong = new TextBox();
            groupBox3 = new GroupBox();
            dgvCTHoaDon = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            groupBox13.SuspendLayout();
            groupBox9.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            groupBox5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTHoaDon).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1284, 729);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Controls.Add(label4);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 723);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin mặt hàng";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBox6, 0, 3);
            tableLayoutPanel2.Controls.Add(groupBox4, 0, 2);
            tableLayoutPanel2.Controls.Add(groupBox13, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox9, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 35);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5312033F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5312033F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5312033F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 62.40639F));
            tableLayoutPanel2.Size = new Size(373, 685);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dataGridView1);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox6.ForeColor = Color.White;
            groupBox6.Location = new Point(3, 258);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(367, 424);
            groupBox6.TabIndex = 22;
            groupBox6.TabStop = false;
            groupBox6.Text = "Thông tin chi tiết sản phẩm";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 29);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(361, 392);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cboSanPham);
            groupBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(3, 173);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(367, 79);
            groupBox4.TabIndex = 21;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sản phẩm";
            // 
            // cboSanPham
            // 
            cboSanPham.Dock = DockStyle.Fill;
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(3, 29);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(361, 33);
            cboSanPham.TabIndex = 0;
            // 
            // groupBox13
            // 
            groupBox13.Controls.Add(cboLoaiSanPham);
            groupBox13.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox13.ForeColor = Color.White;
            groupBox13.Location = new Point(3, 88);
            groupBox13.Name = "groupBox13";
            groupBox13.Size = new Size(367, 79);
            groupBox13.TabIndex = 20;
            groupBox13.TabStop = false;
            groupBox13.Text = "Loại Sản phẩm";
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.Dock = DockStyle.Fill;
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(3, 29);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(361, 33);
            cboLoaiSanPham.TabIndex = 0;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(cboHoaDon);
            groupBox9.Dock = DockStyle.Fill;
            groupBox9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox9.ForeColor = Color.White;
            groupBox9.Location = new Point(3, 3);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(367, 79);
            groupBox9.TabIndex = 16;
            groupBox9.TabStop = false;
            groupBox9.Text = "Hóa đơn";
            // 
            // cboHoaDon
            // 
            cboHoaDon.Dock = DockStyle.Fill;
            cboHoaDon.FormattingEnabled = true;
            cboHoaDon.Location = new Point(3, 29);
            cboHoaDon.Name = "cboHoaDon";
            cboHoaDon.Size = new Size(361, 33);
            cboHoaDon.TabIndex = 1;
            cboHoaDon.SelectedIndexChanged += cboHoaDon_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 854);
            label4.Margin = new Padding(8, 0, 8, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 32);
            label4.TabIndex = 9;
            label4.Text = "Địa chỉ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(388, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Size = new Size(893, 723);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(3, 581);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(887, 139);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao tác dữ liệu";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(btnEditSanPham, 0, 0);
            tableLayoutPanel1.Controls.Add(btnAddSP, 0, 0);
            tableLayoutPanel1.Controls.Add(btnDeleteSP, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(881, 101);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnEditSanPham
            // 
            btnEditSanPham.BackColor = Color.Transparent;
            btnEditSanPham.Dock = DockStyle.Fill;
            btnEditSanPham.FlatAppearance.BorderSize = 3;
            btnEditSanPham.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnEditSanPham.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnEditSanPham.FlatStyle = FlatStyle.Flat;
            btnEditSanPham.ForeColor = Color.SeaShell;
            btnEditSanPham.Location = new Point(591, 5);
            btnEditSanPham.Margin = new Padding(5);
            btnEditSanPham.Name = "btnEditSanPham";
            btnEditSanPham.Size = new Size(285, 91);
            btnEditSanPham.TabIndex = 5;
            btnEditSanPham.Text = "Cập nhật sản phẩm";
            btnEditSanPham.UseVisualStyleBackColor = false;
            btnEditSanPham.Click += txtCapNhat_Click;
            // 
            // btnAddSP
            // 
            btnAddSP.BackColor = Color.Transparent;
            btnAddSP.Dock = DockStyle.Fill;
            btnAddSP.FlatAppearance.BorderSize = 3;
            btnAddSP.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnAddSP.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnAddSP.FlatStyle = FlatStyle.Flat;
            btnAddSP.ForeColor = Color.SeaShell;
            btnAddSP.Location = new Point(298, 5);
            btnAddSP.Margin = new Padding(5);
            btnAddSP.Name = "btnAddSP";
            btnAddSP.Size = new Size(283, 91);
            btnAddSP.TabIndex = 3;
            btnAddSP.Text = "Thêm Sản phẩm";
            btnAddSP.UseVisualStyleBackColor = false;
            btnAddSP.Click += btnThem_Click;
            // 
            // btnDeleteSP
            // 
            btnDeleteSP.BackColor = Color.Transparent;
            btnDeleteSP.Dock = DockStyle.Fill;
            btnDeleteSP.FlatAppearance.BorderSize = 3;
            btnDeleteSP.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnDeleteSP.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnDeleteSP.FlatStyle = FlatStyle.Flat;
            btnDeleteSP.ForeColor = Color.SeaShell;
            btnDeleteSP.Location = new Point(5, 5);
            btnDeleteSP.Margin = new Padding(5);
            btnDeleteSP.Name = "btnDeleteSP";
            btnDeleteSP.Size = new Size(283, 91);
            btnDeleteSP.TabIndex = 2;
            btnDeleteSP.Text = "Xóa sản phẩm";
            btnDeleteSP.UseVisualStyleBackColor = false;
            btnDeleteSP.Click += btnXoa_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(groupBox5, 0, 1);
            tableLayoutPanel5.Controls.Add(groupBox3, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Size = new Size(893, 578);
            tableLayoutPanel5.TabIndex = 9;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(tableLayoutPanel6);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(3, 465);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(887, 110);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Kiểm tra tồn kho";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel6.Controls.Add(txtThanhTien, 2, 0);
            tableLayoutPanel6.Controls.Add(btnKTTonKho, 1, 0);
            tableLayoutPanel6.Controls.Add(txtSoLuong, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel6.Location = new Point(3, 35);
            tableLayoutPanel6.Margin = new Padding(5);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(881, 72);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Dock = DockStyle.Fill;
            txtThanhTien.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtThanhTien.Location = new Point(589, 3);
            txtThanhTien.Name = "txtThanhTien";
            //txtThanhTien.PlaceholderText = "Tạm tính";
            txtThanhTien.Size = new Size(289, 39);
            txtThanhTien.TabIndex = 5;
            txtThanhTien.TextAlign = HorizontalAlignment.Right;
            // 
            // btnKTTonKho
            // 
            btnKTTonKho.BackColor = Color.Transparent;
            btnKTTonKho.Dock = DockStyle.Fill;
            btnKTTonKho.FlatAppearance.BorderSize = 3;
            btnKTTonKho.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnKTTonKho.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnKTTonKho.FlatStyle = FlatStyle.Flat;
            btnKTTonKho.ForeColor = Color.SeaShell;
            btnKTTonKho.Location = new Point(298, 5);
            btnKTTonKho.Margin = new Padding(5);
            btnKTTonKho.Name = "btnKTTonKho";
            btnKTTonKho.Size = new Size(283, 62);
            btnKTTonKho.TabIndex = 4;
            btnKTTonKho.Text = "Kiểm tra tồn kho";
            btnKTTonKho.UseVisualStyleBackColor = false;
            btnKTTonKho.Click += btnKTTonKho_Click;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Dock = DockStyle.Fill;
            txtSoLuong.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoLuong.Location = new Point(3, 3);
            txtSoLuong.Name = "txtSoLuong";
             
            txtSoLuong.Size = new Size(287, 39);
            txtSoLuong.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvCTHoaDon);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(887, 456);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách";
            // 
            // dgvCTHoaDon
            // 
            dgvCTHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTHoaDon.Dock = DockStyle.Left;
            dgvCTHoaDon.Location = new Point(3, 35);
            dgvCTHoaDon.Name = "dgvCTHoaDon";
            dgvCTHoaDon.RowHeadersWidth = 51;
            dgvCTHoaDon.RowTemplate.Height = 29;
            dgvCTHoaDon.Size = new Size(878, 418);
            dgvCTHoaDon.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FormChiTietHoaDon
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 88, 52);
            ClientSize = new Size(1284, 729);
            Controls.Add(tableLayoutPanel3);
            Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "FormChiTietHoaDon";
            Text = "Xử lý đơn hàng(Hóa đơn chi tiết)";
            Load += FormChiTietHoaDon_Load;
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox13.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCTHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox2;
        private Button btnThem;
        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btnKTTonKho;
        private TextBox txtSoLuong;
        private GroupBox groupBox9;
        private TextBox txtThanhTien;
        private GroupBox groupBox13;
        private ComboBox cboLoaiSanPham;
        private DataGridView dgvCTHoaDon;
        private ComboBox cboHoaDon;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnEditSanPham;
        private Button btnAddSP;
        private Button btnDeleteSP;
        private GroupBox groupBox4;
        private ComboBox cboSanPham;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBox6;
        private DataGridView dataGridView1;
    }
}