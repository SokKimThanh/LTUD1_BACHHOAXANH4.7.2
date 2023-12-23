using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    public partial class ViDuPhanTrangRuntime : Form
    {
        private PhanTrangDataGridView phanTrangDataGridView;
        private BindingSource bindingSource = new BindingSource();

        public ViDuPhanTrangRuntime()
        {
            InitializeComponent();

            dataGridView1.DataSource = bindingSource;

            phanTrangDataGridView = new PhanTrangDataGridView(dataGridView1, 10);

            //LoadData(1, 8);
        }
        private void ViDuPhanTrangRuntime_Load(object sender, EventArgs e)
        {
            CreatePagingButtons(panel1);
        }
        public void LoadData(int currentPage, int recordsPerPage)
        {
            using (SqlConnection connection = new SqlConnection(Utils.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("sp_sanpham_phantrang", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm các tham số cho stored procedure
                    command.Parameters.AddWithValue("@LOAISANPHAM", "L01");
                    command.Parameters.AddWithValue("@NHACUNGCAP", "NCC02");
                    command.Parameters.AddWithValue("@TENSANPHAM", "A");
                    command.Parameters.AddWithValue("@CURRPAGE", currentPage);
                    command.Parameters.AddWithValue("@RECODPERPAGE", recordsPerPage);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var data = new List<object>();

                        while (reader.Read())
                        {
                            // Giả sử sanpham có các cột MASP, TENSP, DONVI, DONGIA, GIAMGIA, GIABAN, SLTONKHO
                            data.Add(new
                             SanPham
                            {
                                MaSP = reader.GetInt64(0).ToString(),
                                TenSP = reader.GetString(1),
                                DonVi = reader.GetString(2),
                                Dongia = reader.GetInt16(3),
                                Giamgia = reader.GetDouble(4),
                                Giaban = reader.GetDouble(5),
                                SLTonKho = reader.GetInt16(6)
                            });
                        }

                        phanTrangDataGridView.LoadData(data);
                    }
                }
            }
        }


        public void CreatePagingButtons(Panel panel)
        {
            int buttonWidth = 100; // Đặt chiều rộng của nút
            int margin = 3; // Đặt margin

            // Tạo nút "Trang đầu tiên"
            Button btnFirstPage = new Button();
            btnFirstPage.Text = "Trang đầu tiên";
            btnFirstPage.Width = buttonWidth;
            btnFirstPage.Margin = new Padding(margin);
            btnFirstPage.Location = new Point(0, 0);
            btnFirstPage.Name = "btnFirstPage";

            btnFirstPage.Click += (s, e) =>
            {
                // Thêm mã xử lý sự kiện click vào đây
                phanTrangDataGridView.FirstPage();
            };
            panel.Controls.Add(btnFirstPage);

            // Tạo nút "Trang trước"
            Button btnPreviousPage = new Button();
            btnPreviousPage.Text = "Trang trước";
            btnPreviousPage.Width = buttonWidth;
            btnPreviousPage.Margin = new Padding(margin);
            btnPreviousPage.Location = new Point(btnFirstPage.Right + margin, 0);
            btnPreviousPage.Name = "btnPreviousPage";

            btnPreviousPage.Click += (s, e) =>
            {
                // Thêm mã xử lý sự kiện click vào đây
                phanTrangDataGridView.PreviousPage();
            };
            panel.Controls.Add(btnPreviousPage);

            // Tạo nút "Trang sau"
            Button btnNextPage = new Button();
            btnNextPage.Text = "Trang sau";
            btnNextPage.Width = buttonWidth;
            btnNextPage.Margin = new Padding(margin);
            btnNextPage.Location = new Point(btnPreviousPage.Right + margin, 0);
            btnNextPage.Name = "btnNextPage";

            btnNextPage.Click += (s, e) =>
            {
                // Thêm mã xử lý sự kiện click vào đây
                phanTrangDataGridView.NextPage();
            };
            panel.Controls.Add(btnNextPage);

            // Tạo nút "Trang cuối cùng"
            Button btnLastPage = new Button();
            btnLastPage.Text = "Trang cuối cùng";
            btnLastPage.Width = buttonWidth;
            btnLastPage.Margin = new Padding(margin);
            btnLastPage.Location = new Point(btnNextPage.Right + margin, 0);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Click += (s, e) =>
            {
                // Thêm mã xử lý sự kiện click vào đây
                phanTrangDataGridView.LastPage();
            };

            panel.Controls.Add(btnLastPage);
        }

    }
}
