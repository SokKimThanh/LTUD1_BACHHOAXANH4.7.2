using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD1_BACHHOAXANH472.Model
{
    /// <summary>
    /// Chia sẽ các báo cáo con mỗi khi được gọi 
    /// không tải tất cả các báo cáo cùng lúc để tránh lỗi tràn bộ nhớ
    /// </summary>
    public class ReportHelper
    {
        private ReportManager reportManager;
        private string fileReportName;
        private Dictionary<string, string> parameters;
        private CrystalReportViewer crystalReportViewer1;

        public ReportHelper(ReportManager reportManager, string fileReportName, Dictionary<string, string> parameters, CrystalReportViewer crystalReportViewer1)
        {
            this.reportManager = reportManager;
            this.fileReportName = fileReportName;
            this.parameters = parameters;
            this.crystalReportViewer1 = crystalReportViewer1;
        }

        public void LoadReport()
        {
            if (parameters.Count > 0)
            {
                reportManager.RefreshReport(fileReportName);//được sử dụng để làm mới (hoặc tải lại) báo cáo mỗi khi chỉnh sửa báo cáo
                ReportDocument reportDocument = reportManager.GetReport(fileReportName);// tải một báo cáo mới
                crystalReportViewer1.ReportSource = reportDocument;// gán kết quả vào crytal report
            }
        }
    }
}
