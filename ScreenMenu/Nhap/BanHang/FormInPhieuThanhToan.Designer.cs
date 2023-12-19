namespace LTUD1_BACHHOAXANH472
{
    partial class FormInPhieuThanhToan
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
            this.label1 = new System.Windows.Forms.Label();
            this.rpvInHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTimHoaDon = new System.Windows.Forms.TextBox();
            this.btnTimHD = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // rpvInHoaDon
            // 
            this.rpvInHoaDon.ActiveViewIndex = 0;
            this.rpvInHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rpvInHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.rpvInHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvInHoaDon.Location = new System.Drawing.Point(2, 91);
            this.rpvInHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.rpvInHoaDon.Name = "rpvInHoaDon";
            this.rpvInHoaDon.ReportSource = "D:\\TDC_HK3\\LTUD1_LETHO\\LTUD1_BACHHOAXANH472\\uploads\\PhieuInHoaDon.rpt";
            this.rpvInHoaDon.Size = new System.Drawing.Size(969, 648);
            this.rpvInHoaDon.TabIndex = 1;
            this.rpvInHoaDon.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.rpvInHoaDon.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rpvInHoaDon, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.13592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.86407F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(973, 741);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txtTimHoaDon, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTimHD, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(967, 83);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // txtTimHoaDon
            // 
            this.txtTimHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimHoaDon.Location = new System.Drawing.Point(3, 3);
            this.txtTimHoaDon.Multiline = true;
            this.txtTimHoaDon.Name = "txtTimHoaDon";
            this.txtTimHoaDon.Size = new System.Drawing.Size(477, 77);
            this.txtTimHoaDon.TabIndex = 0;
            // 
            // btnTimHD
            // 
            this.btnTimHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTimHD.Location = new System.Drawing.Point(486, 3);
            this.btnTimHD.Name = "btnTimHD";
            this.btnTimHD.Size = new System.Drawing.Size(478, 77);
            this.btnTimHD.TabIndex = 1;
            this.btnTimHD.Text = "Tìm hóa đơn\r\n";
            this.btnTimHD.UseVisualStyleBackColor = true;
            this.btnTimHD.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormInPhieuThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(973, 741);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInPhieuThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInPhieuThanhToan";
            this.Load += new System.EventHandler(this.FormInPhieuThanhToan_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rpvInHoaDon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtTimHoaDon;
        private System.Windows.Forms.Button btnTimHD;
    }
}