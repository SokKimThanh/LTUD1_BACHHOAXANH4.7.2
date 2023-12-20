using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace LTUD1_BACHHOAXANH472.ScreenMenu.HeThong
{
    public partial class TaoBieuDoDonGian : Form
    {
        public TaoBieuDoDonGian()
        {
            InitializeComponent();
        }

        private void TaoBieuDoDonGian_Load(object sender, EventArgs e)
        {


            // Tạo một đối tượng mới của lớp 'Chart'
            Chart chart = new Chart();

            // Tạo một đối tượng mới của lớp 'ChartArea'
            ChartArea area = new ChartArea("Area1");

            // Thêm 'ChartArea' vào 'Chart'
            chart.ChartAreas.Add(area);

            // Tạo một đối tượng mới của lớp 'Series'
            Series series = new Series("Series1");

            // Đặt loại biểu đồ là 'Column'
            series.ChartType = SeriesChartType.Column;

            // Thêm dữ liệu vào 'Series'
            series.Points.AddXY("Q1", 20000);
            series.Points.AddXY("Q2", 30000);
            series.Points.AddXY("Q3", 25000);
            series.Points.AddXY("Q4", 40000);

            // Thêm 'Series' vào 'Chart'
            chart.Series.Add(series);

            //this.FormBorderStyle = FormBorderStyle.None;
            // Hiển thị 'Chart' trên một form hoặc control nào đó
            this.Controls.Add(chart);
        }
    }
}
