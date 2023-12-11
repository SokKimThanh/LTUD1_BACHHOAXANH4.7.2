using System.Drawing;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    partial class FormNhaCungCap
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
            txtDiaChi = new TextBox();
            groupBox5 = new GroupBox();
            txtSDTNCC = new TextBox();
            groupBox4 = new GroupBox();
            txtTenNhaCC = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            groupBox3 = new GroupBox();
            dgvNhaCungCap = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsmNhaCCOld = new ToolStripMenuItem();
            tsmNCCNew = new ToolStripMenuItem();
            tsmNCCALL = new ToolStripMenuItem();
            tsmExportPDF = new ToolStripMenuItem();
            tsmExportExcel = new ToolStripMenuItem();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).BeginInit();
            contextMenuStrip1.SuspendLayout();
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
            tableLayoutPanel3.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 723);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBox6, 0, 2);
            tableLayoutPanel2.Controls.Add(groupBox5, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 35);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(373, 685);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtDiaChi);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox6.ForeColor = Color.White;
            groupBox6.Location = new Point(0, 274);
            groupBox6.Margin = new Padding(0);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(373, 137);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Dock = DockStyle.Fill;
            txtDiaChi.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.Location = new Point(3, 29);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(367, 39);
            txtDiaChi.TabIndex = 2;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(txtSDTNCC);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(0, 137);
            groupBox5.Margin = new Padding(0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(373, 137);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Số điện thoại";
            // 
            // txtSDTNCC
            // 
            txtSDTNCC.Dock = DockStyle.Fill;
            txtSDTNCC.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtSDTNCC.Location = new Point(3, 29);
            txtSDTNCC.Name = "txtSDTNCC";
            txtSDTNCC.Size = new Size(367, 39);
            txtSDTNCC.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtTenNhaCC);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(367, 131);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tên nhà cung cấp";
            // 
            // txtTenNhaCC
            // 
            txtTenNhaCC.Dock = DockStyle.Fill;
            txtTenNhaCC.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenNhaCC.Location = new Point(3, 29);
            txtTenNhaCC.Name = "txtTenNhaCC";
            txtTenNhaCC.Size = new Size(361, 39);
            txtTenNhaCC.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel4.Controls.Add(groupBox3, 0, 0);
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
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.Controls.Add(btnDelete, 0, 0);
            tableLayoutPanel1.Controls.Add(btnRefresh, 0, 0);
            tableLayoutPanel1.Controls.Add(btnEdit, 0, 0);
            tableLayoutPanel1.Controls.Add(btnAdd, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(3, 35);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 162F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(881, 101);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FlatAppearance.BorderSize = 3;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.SeaShell;
            btnDelete.Location = new Point(297, 5);
            btnDelete.Margin = new Padding(5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 91);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
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
            btnRefresh.Size = new Size(136, 91);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.FlatAppearance.BorderSize = 3;
            btnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.SeaShell;
            btnEdit.Location = new Point(5, 5);
            btnEdit.Margin = new Padding(5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(136, 91);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.FlatAppearance.BorderSize = 3;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.SeaShell;
            btnAdd.Location = new Point(151, 5);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(136, 91);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnThem_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvNhaCungCap);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(887, 572);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách";
            // 
            // dgvNhaCungCap
            // 
            dgvNhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhaCungCap.Dock = DockStyle.Fill;
            dgvNhaCungCap.Location = new Point(3, 35);
            dgvNhaCungCap.Name = "dgvNhaCungCap";
            dgvNhaCungCap.RowTemplate.Height = 28;
            dgvNhaCungCap.Size = new Size(881, 534);
            dgvNhaCungCap.TabIndex = 0;
            dgvNhaCungCap.Click += dgvNhaCungCap_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.FromArgb(255, 192, 192);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tsmNhaCCOld, tsmNCCNew, tsmNCCALL, tsmExportPDF, tsmExportExcel });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(201, 124);
            // 
            // tsmNhaCCOld
            // 
            tsmNhaCCOld.Name = "tsmNhaCCOld";
            tsmNhaCCOld.Size = new Size(200, 24);
            tsmNhaCCOld.Text = "Nhà cung cấp cũ";
            tsmNhaCCOld.Click += tsmNhaCCOld_Click;
            // 
            // tsmNCCNew
            // 
            tsmNCCNew.Name = "tsmNCCNew";
            tsmNCCNew.Size = new Size(200, 24);
            tsmNCCNew.Text = "Nhà cung cấp mới";
            tsmNCCNew.Click += tsmNCCNew_Click;
            // 
            // tsmNCCALL
            // 
            tsmNCCALL.Name = "tsmNCCALL";
            tsmNCCALL.Size = new Size(200, 24);
            tsmNCCALL.Text = "Tất cả nhà cung cấp";
            tsmNCCALL.Click += tsmNCCALL_Click;
            // 
            // tsmExportPDF
            // 
            tsmExportPDF.Name = "tsmExportPDF";
            tsmExportPDF.Size = new Size(200, 24);
            tsmExportPDF.Text = "Xuất file pdf";
            tsmExportPDF.Click += tsmExportPDF_Click;
            // 
            // tsmExportExcel
            // 
            tsmExportExcel.Name = "tsmExportExcel";
            tsmExportExcel.Size = new Size(200, 24);
            tsmExportExcel.Text = "Xuất file exel";
            tsmExportExcel.Click += tsmExportExcel_Click;
            // 
            // FormNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 88, 52);
            ClientSize = new Size(1284, 729);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(tableLayoutPanel3);
            Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "FormNhaCungCap";
            Text = "FormNhaCungCap";
            Load += FormNhaCungCap_Load;
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox6;
        private TextBox txtDiaChi;
        private GroupBox groupBox5;
        private TextBox txtSDTNCC;
        private GroupBox groupBox4;
        private TextBox txtTenNhaCC;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnRefresh;
        private DataGridView dgvNhaCungCap;
        private Button btnDelete;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsmNhaCCOld;
        private ToolStripMenuItem tsmNCCNew;
        private ToolStripMenuItem tsmNCCALL;
        private ToolStripMenuItem tsmExportPDF;
        private ToolStripMenuItem tsmExportExcel;
    }
}