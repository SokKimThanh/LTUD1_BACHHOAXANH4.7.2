using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LTUD1_BACHHOAXANH472
{
    public class PhanTrangDataGridView
    {
        private DataGridView dataGridView;
        private PhanTrangController phanTrangController;

        public PhanTrangDataGridView(DataGridView dataGridView, int recordsPerPage)
        {
            this.dataGridView = dataGridView;
            this.phanTrangController = new PhanTrangController(recordsPerPage);
        }
        /// <summary>
        /// Tải dữ liệu từ DATABASE để phân trang
        /// </summary>
        /// <param name="data"></param>
        public void LoadData(IEnumerable<object> data)
        {
            var dataList = data.ToList();
            phanTrangController.SetTotalRecords(dataList.Count);

            UpdateDataGridView(dataList);
        }

        public void FirstPage()
        {
            phanTrangController.FirstPage();
            UpdateDataGridView();
        }

        public void NextPage()
        {
            phanTrangController.NextPage();
            UpdateDataGridView();
        }

        public void PreviousPage()
        {
            phanTrangController.PreviousPage();
            UpdateDataGridView();
        }

        public void LastPage()
        {
            phanTrangController.LastPage();
            UpdateDataGridView();
        }

        private void UpdateDataGridView(IEnumerable<object> data = null)
        {
            if (data == null)
            {
                data = dataGridView.DataSource as IEnumerable<object>;
            }

            int skipRecords = (phanTrangController.GetCurrentPage() - 1) * phanTrangController.GetRecordsPerPage();
            dataGridView.DataSource = data.Skip(skipRecords).Take(phanTrangController.GetRecordsPerPage()).ToList();
            dataGridView.Refresh();

            //IEnumerable<object> data = ... // Dữ liệu của bạn
            //List<object> dataList = data.ToList(); // Chuyển đổi IEnumerable thành List
            //dataGridView.DataSource = dataList; // Gán List làm DataSource cho DataGridView
            //dataGridView.Refresh(); // Làm mới DataGridView để hiển thị dữ liệu mới

        }

    }

}
