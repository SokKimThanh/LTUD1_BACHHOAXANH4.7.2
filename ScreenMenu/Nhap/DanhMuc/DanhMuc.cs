using System;
namespace LTUD1_BACHHOAXANH472.ScreenMenu.Nhap.DanhMuc
{
    internal class DanhMuc
    {
        private string ma, ten, ghichu;
        public DanhMuc()
        {
            this.ma = "";
            this.ten = "";
            this.ghichu = "";
        }
        public DanhMuc(string ma, string ten, string ghichu)
        {
            if (ma.Length != 10)
            {
                throw new Exception("ma khong hop le");
            }
            if (ten.Length > 256)
            {
                throw new Exception("ten khong hop le");
            }
            this.ma = ma;
            this.ten = ten;
            this.ghichu = ghichu;
        }

        public string Ma
        {
            get => ma; set
            {
                //if (value.Length != 10)
                //{
                //    throw new Exception("ma khong hop le");
                //}
                ma = value;
            }
        }
        public string Ten
        {
            get => ten; set
            {
                if (value.Length > 256)
                {
                    throw new Exception("ten khong hop le");
                }
                ten = value;
            }
        }
        public string Ghichu { get => ghichu; set => ghichu = value; }

    }
}
