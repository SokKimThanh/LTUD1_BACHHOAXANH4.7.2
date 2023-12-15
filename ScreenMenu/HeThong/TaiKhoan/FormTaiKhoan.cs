using System;
using System.Data;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    public partial class FormTaiKhoan : Form
    {
        readonly AccountController controller;


        public FormTaiKhoan()
        {
            InitializeComponent();
            controller = new AccountController(Utils.ConnectionString);
            // data grid view setting
            DataGridViewHelper.ConfigureDataGridView(dgvTaiKhoan);
            dgvTaiKhoan.Click += new EventHandler(DgvTaiKhoan_Click);
        }



        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                controller.SelectAll();
                dgvTaiKhoan.DataSource = controller.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void Reset()
        {
            try
            {
                controller.SelectAll();
                dgvTaiKhoan.DataSource = controller.DataSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                controller.Delete(txtTenTaiKhoan.Text);
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {

            try
            {
                controller.Update(new Account(txtTenTaiKhoan.Text, txtMK.Text, "", txtSDT.Text, txtCCCD.Text, txtEmail.Text));
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void TxtTenTK_TextChanged(object sender, EventArgs e)
        {

        }



        private void DgvTaiKhoan_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dgvTaiKhoan.CurrentCell.RowIndex;
                txtTenTaiKhoan.Text = dgvTaiKhoan.Rows[dong].Cells[0].Value.ToString();
                DataRow row = controller.SelectByID(txtTenTaiKhoan.Text).Rows[0];

                Account o = (Account)controller.FromDataRow(row);
                if (o != null)
                {
                    txtTenTaiKhoan.Text = o.TenTaiKhoan;
                    txtSDT.Text = o.Phone;
                    txtEmail.Text = o.Email;
                    txtCCCD.Text = o.Cccd;
                    txtMK.Text = o.MatKhau;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy tabControl1 từ form hoặc từ nơi nó được khởi tạo
            TabControl tabControl1 = this.tabControlXemDuLieu;

            // Đảm bảo rằng tabControl1 có đủ số lượng tab
            if (tabControl1.TabCount >= tabControlNhapThongTin.TabCount)
            {
                // Đặt tab được chọn trên tabControl1 để khớp với tab được chọn trên tabControl2
                tabControl1.SelectedIndex = tabControlNhapThongTin.SelectedIndex;
            }
            else
            {
                // Xử lý trường hợp khi tabControl1 không có đủ số lượng tab
                Console.WriteLine("TabControl1 không có đủ số lượng tab để khớp với TabControl2.");
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Lấy tabControlNhapThongTin và tabXemDuLieu từ form hoặc từ nơi chúng được khởi tạo
            TabControl tabControlNhapThongTin = this.tabControlNhapThongTin;
            TabControl tabXemDuLieu = this.tabControlXemDuLieu;

            // Kiểm tra tab đang được chọn trên mỗi TabControl
            int selectedTabNhapThongTin = tabControlNhapThongTin.SelectedIndex;
            int selectedTabXemDuLieu = tabXemDuLieu.SelectedIndex;

            // Phân biệt giữa các tab trên tabControlNhapThongTin và tabXemDuLieu
            if (selectedTabNhapThongTin == 0 && selectedTabXemDuLieu == 0) // TabTaiKhoan và tabXemThongTinTaiKhoan
            {
                Console.WriteLine("Bạn đang thêm thông tin vào bảng TaiKhoan.");
                // Thêm mã để xử lý việc thêm thông tin vào bảng TaiKhoan tại đây
            }
            else if (selectedTabNhapThongTin == 1 && selectedTabXemDuLieu == 1) // TabLoaiTaiKhoan và TabXemThongTinLoaiTaiKhoan
            {
                Console.WriteLine("Bạn đang thêm thông tin vào bảng LoaiTaiKhoan.");
                // Thêm mã để xử lý việc thêm thông tin vào bảng LoaiTaiKhoan tại đây
            }
            else
            {
                // Xử lý trường hợp khi các tab không tương ứng với nhau
                Console.WriteLine("Các tab trên tabControlNhapThongTin và tabXemDuLieu không tương ứng với nhau.");
            }
        }

        private void FormTaiKhoan_Load_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}