public static class DataGridViewHelper
{
    public static void ConfigureDataGridView(DataGridView dgv)
    {
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgv.ForeColor = Color.Black;
        dgv.ReadOnly = true;
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgv.MultiSelect = false;
        dgv.Dock = DockStyle.Fill;
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        dgv.AllowUserToAddRows = false;
    }
    public static void TaoCotHoaDon(DataGridView dgvThongTinHoaDon)
    {
        // Tạo cột Mã sản phẩm
        DataGridViewTextBoxColumn colMaSP = new DataGridViewTextBoxColumn();
        colMaSP.Name = "MASP";
        colMaSP.HeaderText = "Mã sản phẩm";
        dgvThongTinHoaDon.Columns.Add(colMaSP);

        // Tạo cột Tên sản phẩm
        DataGridViewTextBoxColumn colTenSP = new DataGridViewTextBoxColumn();
        colTenSP.Name = "TENSP";
        colTenSP.HeaderText = "Tên sản phẩm";
        dgvThongTinHoaDon.Columns.Add(colTenSP);

        // Tạo cột Đơn giá
        DataGridViewTextBoxColumn colDonGia = new DataGridViewTextBoxColumn();
        colDonGia.Name = "DONGIA";
        colDonGia.HeaderText = "Đơn giá";
        dgvThongTinHoaDon.Columns.Add(colDonGia);

        // Tạo cột Số lượng
        DataGridViewTextBoxColumn colSoLuong = new DataGridViewTextBoxColumn();
        colSoLuong.Name = "SOLUONG";
        colSoLuong.HeaderText = "Số lượng";
        dgvThongTinHoaDon.Columns.Add(colSoLuong);

        // Tạo cột Tổng
        DataGridViewTextBoxColumn colTong = new DataGridViewTextBoxColumn();
        colTong.Name = "TONG";
        colTong.HeaderText = "Tổng";
        dgvThongTinHoaDon.Columns.Add(colTong);

        // Tạo cột Tăng số lượng
        DataGridViewButtonColumn btnTangSoLuong = new DataGridViewButtonColumn();
        btnTangSoLuong.Name = "BtnTangSoLuong";
        btnTangSoLuong.HeaderText = "Tăng số lượng";
        dgvThongTinHoaDon.Columns.Add(btnTangSoLuong);

        // Tạo cột Giảm số lượng
        DataGridViewButtonColumn btnGiamSoLuong = new DataGridViewButtonColumn();
        btnGiamSoLuong.Name = "BtnGiamSoLuong";
        btnGiamSoLuong.HeaderText = "Giảm số lượng";
        dgvThongTinHoaDon.Columns.Add(btnGiamSoLuong);

    }
}


