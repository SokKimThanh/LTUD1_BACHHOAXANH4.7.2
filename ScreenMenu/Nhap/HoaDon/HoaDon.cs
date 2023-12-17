using System;


internal class HoaDon
{
    private string maHD, maNV, maKH;
    private DateTime ngayHD;
    private decimal tongTien;
    public HoaDon()
    { }
    public HoaDon(string maHD, string maNV, string maKH, DateTime ngayHD, decimal tongTien)
    {
        this.MaHD = maHD;
        this.MaNV = maNV;
        this.MaKH = maKH;
        this.NgayHD = ngayHD;
        this.TongTien = tongTien;
    }

    public string MaHD { get => maHD; set => maHD = value; }
    public string MaNV { get => maNV; set => maNV = value; }
    public string MaKH { get => maKH; set => maKH = value; }
    public DateTime NgayHD { get => ngayHD; set => ngayHD = value; }
    public decimal TongTien { get => tongTien; set => tongTien = value; }
}

