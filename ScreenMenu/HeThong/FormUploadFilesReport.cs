using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472._7._2.ScreenMenu.HeThong
{
    public partial class FormUploadFilesReport : Form
    {
      
        public FormUploadFilesReport()
        {
            InitializeComponent();
        }

        private void FormUploadFilesReport_Load(object sender, EventArgs e)
        {

            // Create a new Panel.
            Panel panel1 = new Panel();
            TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
            VScrollBar vScrollBar1 = new VScrollBar();

            int rowCount = 20;
            int columnCount = 1;
            int sizerow = 64;
            Random rnd = new Random();

            string[] arr = new string[rowCount];
            for (int i = 0; i < rowCount; i++)
            {
                arr[i] = rnd.NextDouble().ToString();
            }
            // chinh srollbar
            vScrollBar1.Width = 10;
            vScrollBar1.Dock = DockStyle.Right;


            tableLayoutPanel1.RowCount = rowCount;// so dong
            tableLayoutPanel1.ColumnCount = columnCount;// so cot


            // Set the Dock property of the TableLayoutPanel to Fill.
            tableLayoutPanel1.Dock = DockStyle.Fill;
            // tạo thanh cuộn 
            tableLayoutPanel1.AutoScroll = true;
            // cách để làm scroll bar tableLayoutPanel1 nhỏ lại  
            tableLayoutPanel1.MaximumSize = new Size(200, 200);
            tableLayoutPanel1.RowStyles.Clear();

            // thêm thông tin cho tableLayoutPanel1
            for (int i = 0; i < rowCount; i++)
            {
                // chỉnh số dòng đều nhau
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, sizerow));
                GroupBox groupBox = new GroupBox();
                groupBox.BackColor = Color.LightGreen;
                groupBox.Dock = DockStyle.Fill;
                groupBox.Text = i.ToString();
                Label label = new Label();
                label.Text = arr[i].ToString();
                label.ForeColor = Color.Black;
                label.Dock = DockStyle.Fill;
                groupBox.Controls.Add(label);
                tableLayoutPanel1.Controls.Add(label, 0, i);
            }


            //panel1.Controls.Add(vScrollBar1);
            // chỉnh panel 
            panel1.Dock = DockStyle.Fill;
            // Add the TableLayoutPanel and VScrollBar to the Panel.
            panel1.Controls.Add(tableLayoutPanel1);
            this.Controls.Add(panel1);
        }

    }
}
