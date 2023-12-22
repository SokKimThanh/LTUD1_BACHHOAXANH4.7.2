using System.Drawing;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.ChiTietHoaDon
{
    partial class ChiTietHoaDonThongKe
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            cboHD = new ComboBox();
            btnIn = new Button();
            btnThoat = new Button();
            groupBox1 = new GroupBox();
            dgvDanhSach = new DataGridView();
            btnTiemKiem = new Button();
            txtTimKiem = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 371F));
            tableLayoutPanel1.Size = new Size(868, 458);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(cboHD);
            panel1.Controls.Add(btnIn);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnTiemKiem);
            panel1.Controls.Add(txtTimKiem);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(862, 81);
            panel1.TabIndex = 0;
            // 
            // cboHD
            // 
            cboHD.FormattingEnabled = true;
            cboHD.Location = new Point(64, 8);
            cboHD.Name = "cboHD";
            cboHD.Size = new Size(151, 28);
            cboHD.TabIndex = 2;
            cboHD.ValueMemberChanged += cboHD_TextChanged;
            cboHD.TextChanged += cboHD_TextChanged;
            cboHD.Click += cboHD_TextChanged;
            // 
            // btnIn
            // 
            btnIn.Location = new Point(602, 31);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(94, 29);
            btnIn.TabIndex = 1;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(483, 31);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvDanhSach);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(862, 365);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách";
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSach.Dock = DockStyle.Fill;
            dgvDanhSach.Location = new Point(3, 23);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.RowHeadersWidth = 51;
            dgvDanhSach.RowTemplate.Height = 29;
            dgvDanhSach.Size = new Size(856, 339);
            dgvDanhSach.TabIndex = 0;
            // 
            // btnTiemKiem
            // 
            btnTiemKiem.Location = new Point(370, 29);
            btnTiemKiem.Name = "btnTiemKiem";
            btnTiemKiem.Size = new Size(94, 29);
            btnTiemKiem.TabIndex = 1;
            btnTiemKiem.Text = "Tìm kiếm";
            btnTiemKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(64, 42);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(286, 27);
            txtTimKiem.TabIndex = 0;
            // 
            // ChiTietHoaDonThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 458);
            Controls.Add(tableLayoutPanel1);
            Name = "ChiTietHoaDonThongKe";
            Text = "ChiTietHoaDonThongKe";
            Load += button2_Click;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button btnIn;
        private Button btnThoat;
        private DataGridView dgvDanhSach;
        private ComboBox cboHD;
        private Button btnTiemKiem;
        private TextBox txtTimKiem;
    }
}