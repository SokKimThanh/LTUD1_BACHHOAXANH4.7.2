using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
namespace LTUD1_BACHHOAXANH472.HeThong
{
    partial class FormUploadFilesReport
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tvReport = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboReportPhongBan = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.cboReportChiNhanh = new System.Windows.Forms.ComboBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tvReportNhanVien = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTieuDeReport = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox11);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.81208F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.18792F));
            this.tableLayoutPanel9.Controls.Add(this.tvReport, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel9.TabIndex = 2;
            // 
            // tvReport
            // 
            this.tvReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tvReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvReport.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.tvReport.Location = new System.Drawing.Point(0, 0);
            this.tvReport.Margin = new System.Windows.Forms.Padding(0);
            this.tvReport.Name = "tvReport";
            this.tvReport.Size = new System.Drawing.Size(171, 418);
            this.tvReport.TabIndex = 5;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Controls.Add(this.crystalReportViewer1, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(171, 0);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.86408F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.13593F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(615, 418);
            this.tableLayoutPanel10.TabIndex = 6;
            // 
            // cryKhachHang
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 74);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(0);
            this.crystalReportViewer1.Name = "cryKhachHang";
            this.crystalReportViewer1.Size = new System.Drawing.Size(615, 344);
            this.crystalReportViewer1.TabIndex = 4;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.groupBox10, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(615, 74);
            this.tableLayoutPanel11.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboReportPhongBan);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(307, 0);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 74);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phòng ban";
            // 
            // cboReportPhongBan
            // 
            this.cboReportPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboReportPhongBan.FormattingEnabled = true;
            this.cboReportPhongBan.Location = new System.Drawing.Point(3, 16);
            this.cboReportPhongBan.Margin = new System.Windows.Forms.Padding(0);
            this.cboReportPhongBan.Name = "cboReportPhongBan";
            this.cboReportPhongBan.Size = new System.Drawing.Size(302, 21);
            this.cboReportPhongBan.TabIndex = 3;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.cboReportChiNhanh);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.ForeColor = System.Drawing.Color.White;
            this.groupBox10.Location = new System.Drawing.Point(0, 0);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(307, 74);
            this.groupBox10.TabIndex = 7;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Chi nhánh";
            // 
            // cboReportChiNhanh
            // 
            this.cboReportChiNhanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboReportChiNhanh.FormattingEnabled = true;
            this.cboReportChiNhanh.Location = new System.Drawing.Point(3, 16);
            this.cboReportChiNhanh.Margin = new System.Windows.Forms.Padding(0);
            this.cboReportChiNhanh.Name = "cboReportChiNhanh";
            this.cboReportChiNhanh.Size = new System.Drawing.Size(301, 21);
            this.cboReportChiNhanh.TabIndex = 3;
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.groupBox11.Controls.Add(this.label4);
            this.groupBox11.Controls.Add(this.tvReportNhanVien);
            this.groupBox11.Controls.Add(this.label3);
            this.groupBox11.Controls.Add(this.txtTieuDeReport);
            this.groupBox11.Controls.Add(this.btnImport);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.ForeColor = System.Drawing.Color.White;
            this.groupBox11.Location = new System.Drawing.Point(3, 3);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(786, 418);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Thêm báo cáo mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Danh sách báo cáo";
            // 
            // tvReportNhanVien
            // 
            this.tvReportNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tvReportNhanVien.Location = new System.Drawing.Point(66, 81);
            this.tvReportNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.tvReportNhanVien.Name = "tvReportNhanVien";
            this.tvReportNhanVien.Size = new System.Drawing.Size(267, 367);
            this.tvReportNhanVien.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(365, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiêu đề báo cáo";
            // 
            // txtTieuDeReport
            // 
            this.txtTieuDeReport.Location = new System.Drawing.Point(371, 81);
            this.txtTieuDeReport.Margin = new System.Windows.Forms.Padding(0);
            this.txtTieuDeReport.Name = "txtTieuDeReport";
            this.txtTieuDeReport.Size = new System.Drawing.Size(211, 20);
            this.txtTieuDeReport.TabIndex = 1;
            // 
            // btnImport
            // 
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(371, 404);
            this.btnImport.Margin = new System.Windows.Forms.Padding(0);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(211, 44);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Chọn báo cáo";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // FormUploadFilesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(88)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormUploadFilesReport";
            this.Text = "FormUploadFilesReport";
            //this.Load += new System.EventHandler(this.FormUploadFilesReport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel9;
        private TreeView tvReport;
        private TableLayoutPanel tableLayoutPanel10;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private TableLayoutPanel tableLayoutPanel11;
        private GroupBox groupBox3;
        private ComboBox cboReportPhongBan;
        private GroupBox groupBox10;
        private ComboBox cboReportChiNhanh;
        private TabPage tabPage2;
        private GroupBox groupBox11;
        private Label label4;
        private TreeView tvReportNhanVien;
        private Label label3;
        private TextBox txtTieuDeReport;
        private Button btnImport;
    }
}