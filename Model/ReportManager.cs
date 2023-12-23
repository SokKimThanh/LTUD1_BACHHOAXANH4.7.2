using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
namespace LTUD1_BACHHOAXANH472.Model
{
    public class ReportManager
    {
        // Kỹ thuật lazy load danh sách các report
        private Dictionary<string, Lazy<ReportDocument>> reports = new Dictionary<string, Lazy<ReportDocument>>();

        private string reportDirectory;// thư mục chứa report

        /// <summary>
        /// Đi tới thư mục resource chứa report để tải lên các report
        /// </summary>
        public ReportManager()
        {
            GetReportFromResources();
        }


        /// <summary>
        /// Đi tới thư mục uploads chứa report để tải lên các report
        /// </summary>
        /// <param name="reportDirectory">Thư mục gốc chứa report</param>
        public ReportManager(string reportDirectory)
        {
            this.reportDirectory = reportDirectory;
            GetReportFromFolder();
        }
        /// <summary>
        /// Lấy tất cả report trong thư mục uploads
        /// </summary>
        private void GetReportFromFolder()
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
        /// Lấy tất cả report trong thư mục resources
        /// </summary>
        public void GetReportFromResources()
        {
            foreach (string reportName in Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, true, true).OfType<DictionaryEntry>().Where(entry => entry.Value is byte[] && entry.Key.ToString().EndsWith(".rpt")).Select(entry => entry.Key.ToString()))
            {
                reports.Add(reportName, new Lazy<ReportDocument>(() =>
                {
                    ReportDocument reportDocument;

                    using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(this.GetType().Namespace + "." + reportName))
                    {
                        reportDocument = new ReportDocument();
                        // Tạo một tệp tạm thời
                        string tempPath = Path.GetTempFileName();
                        using (FileStream fileStream = File.Create(tempPath))
                        {
                            stream.CopyTo(fileStream);
                        }

                        // Tải ReportDocument từ tệp tạm thời
                        reportDocument.Load(tempPath);

                        // Xóa tệp tạm thời
                        File.Delete(tempPath);
                    }

                    return reportDocument;
                }));
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
        /// Tải lại tất cả report
        /// </summary>
        public void RefreshAllReports()
        {
            foreach (string reportTitle in reports.Keys.ToList())
            {
                RefreshReport(reportTitle);
            }
        }
        /// <summary>
        /// Kiểm tra tồn tại của report trong resource
        /// </summary>
        /// <param name="reportName"></param>
        /// <returns></returns>
        public bool ReportExists(string reportName)
        {
            var resourceSet = Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, true, true);
            return resourceSet.OfType<DictionaryEntry>().Any(entry => entry.Key.ToString() == reportName);
        }

        /// <summary>
        /// Kiểm tra tồn tại của report trong thư mục chỉ định
        /// </summary>
        /// <param name="reportName"></param>
        /// <param name="reportDirectory"></param>
        /// <returns></returns>
        public bool ReportExists(string reportName, string reportDirectory)
        {
            string reportPath = Path.Combine(reportDirectory, reportName + ".rpt");
            return File.Exists(reportPath);
        }
    }
}
