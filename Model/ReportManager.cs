using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace LTUD1_BACHHOAXANH472.Model
{
    public class ReportManager
    {
        // Kỹ thuật lazy load danh sách các report
        private Dictionary<string, Lazy<ReportDocument>> reports = new Dictionary<string, Lazy<ReportDocument>>();

        private string reportDirectory;// thư mục chứa report
        /// <summary>
        /// Đi tới thư mục gốc chứa report để tải lên các report
        /// </summary>
        /// <param name="reportDirectory">Thư mục gốc chứa report</param>
        public ReportManager(string reportDirectory)
        {
            this.reportDirectory = reportDirectory;
            LoadReportNames();
        }
        /// <summary>
        /// Hàm load tất cả report có trong thư mục chỉ định
        /// </summary>
        private void LoadReportNames()
        {
            foreach (string reportPath in Directory.GetFiles(reportDirectory, "*.rpt"))
            {
                string reportTitle = Path.GetFileNameWithoutExtension(reportPath);

                if (!reports.ContainsKey(reportTitle))
                {
                    reports.Add(reportTitle, new Lazy<ReportDocument>(() =>
                    {
                        ReportDocument reportDocument = new ReportDocument();
                        reportDocument.Load(reportPath);
                        return reportDocument;
                    }));
                }
            }
        }
        /// <summary>
        /// Nhập vào tên report muốn lấy ra 
        /// </summary>
        /// <param name="reportTitle">Nhập tên report</param>
        /// <returns></returns>
        public ReportDocument GetReport(string reportTitle)
        {
            if (reports.TryGetValue(reportTitle, out Lazy<ReportDocument> lazyReportDocument))
            {
                return lazyReportDocument.Value;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Tải lại một report cụ thể
        /// </summary>
        /// <param name="reportTitle">Nhập vào tên report</param>
        public void RefreshReport(string reportTitle)
        {
            string reportPath = Path.Combine(reportDirectory, reportTitle + ".rpt");

            reports[reportTitle] = new Lazy<ReportDocument>(() =>
            {
                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load(reportPath);
                return reportDocument;
            });
        }

        /// <summary>
        /// tải lại tất cả report
        /// </summary>
        public void RefreshAllReports()
        {
            foreach (string reportTitle in reports.Keys.ToList())
            {
                RefreshReport(reportTitle);
            }
        }
    }
}
