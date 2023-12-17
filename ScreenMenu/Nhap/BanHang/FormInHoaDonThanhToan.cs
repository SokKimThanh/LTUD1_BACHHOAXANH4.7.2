using CrystalDecisions.CrystalReports.Engine;
using LTUD1_BACHHOAXANH472.Model;
using System;
using System.IO;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    public partial class FormInHoaDonThanhToan : Form
    {
        string mahd;
        ReportManager reportManager = new ReportManager(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"ScreenMenu\Nhap\NhanVien"));

        public FormInHoaDonThanhToan(string mahd)
        {
            InitializeComponent();
            this.mahd = mahd;
        }

        public FormInHoaDonThanhToan()
        {
        }

        public string Mahd { get => mahd; set => mahd = value; }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mahd))
            {
                MessageBox.Show("Chưa có mã hd");
            }
            else
            {
                ReportDocument s = new ReportDocument();
                s.Load("PhieuInHoaDon");
            }
        }

        private void FormInHoaDonThanhToan_Load(object sender, EventArgs e)
        {

        }
    }
}
