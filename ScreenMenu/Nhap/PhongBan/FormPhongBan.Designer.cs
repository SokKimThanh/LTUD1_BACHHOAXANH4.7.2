using System.Drawing;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.PhongBan
{
    partial class FormPhongBan
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
            groupBox1 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox7 = new GroupBox();
            cbbMaCN = new ComboBox();
            groupBox6 = new GroupBox();
            txtTenPB = new TextBox();
            groupBox2 = new GroupBox();
            txtMaPB = new TextBox();
            dgvPB = new DataGridView();
            btnSua = new Button();
            button2 = new Button();
            btnThem = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            groupBox4 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPB).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(tableLayoutPanel3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 543);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập thông tin";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(groupBox7, 0, 2);
            tableLayoutPanel3.Controls.Add(groupBox6, 0, 1);
            tableLayoutPanel3.Controls.Add(groupBox2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 22);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 10;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20.5741634F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 21.7703342F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 36.6300354F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 2.014652F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 2.87081337F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 5.74162674F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 1.91387558F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 2.15311F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 3.11004782F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 2.87081337F));
            tableLayoutPanel3.Size = new Size(372, 518);
            tableLayoutPanel3.TabIndex = 19;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cbbMaCN);
            groupBox7.Dock = DockStyle.Fill;
            groupBox7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox7.ForeColor = Color.White;
            groupBox7.Location = new Point(0, 219);
            groupBox7.Margin = new Padding(0);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(372, 190);
            groupBox7.TabIndex = 6;
            groupBox7.TabStop = false;
            groupBox7.Text = "Mã chi nhánh";
            groupBox7.Enter += groupBox7_Enter;
            // 
            // cbbMaCN
            // 
            cbbMaCN.Dock = DockStyle.Fill;
            cbbMaCN.FormattingEnabled = true;
            cbbMaCN.Location = new Point(3, 29);
            cbbMaCN.Margin = new Padding(6, 4, 6, 4);
            cbbMaCN.Name = "cbbMaCN";
            cbbMaCN.Size = new Size(366, 33);
            cbbMaCN.TabIndex = 10;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(txtTenPB);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox6.ForeColor = Color.White;
            groupBox6.Location = new Point(0, 106);
            groupBox6.Margin = new Padding(0);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(372, 113);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Tên phòng ban";
            // 
            // txtTenPB
            // 
            txtTenPB.Dock = DockStyle.Fill;
            txtTenPB.Location = new Point(3, 29);
            txtTenPB.Name = "txtTenPB";
            txtTenPB.Size = new Size(366, 33);
            txtTenPB.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(txtMaPB);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(366, 100);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mã Phòng Ban";
            // 
            // txtMaPB
            // 
            txtMaPB.Dock = DockStyle.Fill;
            txtMaPB.Location = new Point(3, 29);
            txtMaPB.Name = "txtMaPB";
            txtMaPB.Size = new Size(360, 33);
            txtMaPB.TabIndex = 0;
            // 
            // dgvPB
            // 
            dgvPB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPB.BackgroundColor = SystemColors.ActiveBorder;
            dgvPB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPB.Dock = DockStyle.Fill;
            dgvPB.Location = new Point(3, 22);
            dgvPB.Name = "dgvPB";
            dgvPB.RowHeadersWidth = 51;
            dgvPB.RowTemplate.Height = 29;
            dgvPB.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPB.Size = new Size(885, 408);
            dgvPB.TabIndex = 0;
            dgvPB.CellContentClick += dataGridView1_CellContentClick;
            dgvPB.Click += dgvPB_Click;
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
            btnSua.Location = new Point(299, 5);
            btnSua.Margin = new Padding(5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(137, 69);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 192, 192);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.SeaShell;
            button2.Location = new Point(152, 5);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(137, 69);
            button2.TabIndex = 1;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnXoa;
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
            btnThem.Size = new Size(137, 69);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
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
            tableLayoutPanel1.Controls.Add(button2, 0, 0);
            tableLayoutPanel1.Controls.Add(btnThem, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(3, 22);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tableLayoutPanel1.Size = new Size(885, 79);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(tableLayoutPanel1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(3, 442);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(891, 104);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thao tác dữ liệu";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(groupBox3, 0, 1);
            tableLayoutPanel4.Controls.Add(groupBox4, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(384, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Size = new Size(897, 549);
            tableLayoutPanel4.TabIndex = 24;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Transparent;
            groupBox4.Controls.Add(dgvPB);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(891, 433);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách";
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
            tableLayoutPanel2.Size = new Size(1281, 549);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // FormPhongBan
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(10, 88, 52);
            ClientSize = new Size(1281, 549);
            Controls.Add(tableLayoutPanel2);
            Name = "FormPhongBan";
            Text = "FormPhongBan";
            Load += FormPhongBan_Load;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPB).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private DataGridView dgvPB;
        private Button btnSua;
        private Button button2;
        private Button btnThem;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox4;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox7;
        private ComboBox cbbMaCN;
        private GroupBox groupBox6;
        private TextBox txtTenPB;
        private GroupBox groupBox2;
        private TextBox txtMaPB;
    }
}