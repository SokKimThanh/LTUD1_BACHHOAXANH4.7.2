using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using LTUD1_BACHHOAXANH472.Model;
using LTUD1_BACHHOAXANH472.uploads;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
namespace LTUD1_BACHHOAXANH472.HeThong
{
    public partial class FormUploadFilesReport : Form
    {
        ReportManager reportManager;
        // Tạo một từ điển để lưu trữ các báo cáo
        Dictionary<string, ReportDocument> reports = new Dictionary<string, ReportDocument>();
        // khởi tạo kết nối

        private TreeNode selectedNode;
        // Hàm hỗ trợ kiểm tra lỗi nhập
        //ErrTxt errtxt;
        ErrColors color = new ErrColors();

        public FormUploadFilesReport(ReportManager reportManager)
        {
            InitializeComponent();
            this.reportManager = reportManager;
        }
        private void tvReport_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            selectedNode = e.Node;
        }
        /// <summary>
        /// Sự kiện report nhấp vào hiển thị report được chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvReport_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Lấy tên của node được chọn
            string reportTitle = e.Node.Text;
            // Tô màu node
            e.Node.BackColor = color.primaryGreen;
            // Lấy báo cáo tương ứng
            ReportDocument reportDocument = reportManager.GetReport(reportTitle);

            // Truyền tham số vào báo cáo
            if (reportDocument != null)
            {
                switch (reportTitle)
                {
                    // load all lần đầu 
                    case "rp_nhanvien_select_all":
                        //reportDocument.SetParameterValue("@keyword", string.IsNullOrEmpty(txtHoTenNV.Text) ? "" : txtHoTenNV.Text);

                        // Tạo một instance của form bạn muốn hiển thị
                        //var formToDisplay = new FormToDisplay();

                        // Đặt form này như một control con của panelReportControl
                        //formToDisplay.TopLevel = false;
                        //groupBox10.Controls.Add(formToDisplay);

                        // Hiển thị form
                        //formToDisplay.Show();
                        break;

                    default: break;
                }
                // Thêm các tham số khác nếu cần thiết

                crystalReportViewer1.ReportSource = reportDocument;
            }
        }
    }
}
