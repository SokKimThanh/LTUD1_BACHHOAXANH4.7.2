using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.BanHang
{
    public class PhanTrangController
    {
        private int currentPage;
        private int recordsPerPage;
        private int totalRecords;

        public PhanTrangController(int recordsPerPage)
        {
            this.recordsPerPage = recordsPerPage;
            this.currentPage = 1;
        }

        public void FirstPage()
        {
            this.currentPage = 1;
        }

        public void NextPage()
        {
            if (this.currentPage * this.recordsPerPage < this.totalRecords)
            {
                this.currentPage++;
            }
        }

        public void PreviousPage()
        {
            if (this.currentPage > 1)
            {
                this.currentPage--;
            }
        }

        public void LastPage()
        {
            this.currentPage = (this.totalRecords + this.recordsPerPage - 1) / this.recordsPerPage;
        }

        public int GetCurrentPage()
        {
            return this.currentPage;
        }

        public void SetTotalRecords(int totalRecords)
        {
            this.totalRecords = totalRecords;
        }
    }

}
