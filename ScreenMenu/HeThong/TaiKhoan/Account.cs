internal class Account
{
    private string tentk, matkhau, matk;
    private DateTime createdate;
    private string phone;
    private string cccd;
    private string email;

    // return object
    public Account()
    {
        this.tentk = null;
        this.matkhau = null;
        this.matk = "";
        this.createdate = default;
        this.phone = null;
        this.cccd = null;
        this.email = null;
    }

    // update
    public Account(string tentk = null, string matkhau = null, string matk = null, string phone = null, string cccd = null, string email = null)
    {
        if (matk == null || matk.Length <= 0)
        {
            throw new Exception("Mã tài khoản không hợp lệ");
        }
        this.tentk = tentk;
        this.matkhau = matkhau;
        this.matk = matk;
        this.phone = phone;
        this.cccd = cccd;
        this.email = email;
    }
    //add
    public Account(string tentk = null, string matkhau = null, string matk = null, DateTime createdate = default, string phone = null, string cccd = null, string email = null)
    {
        if (matk == null || matk.Length <= 0)
        {
            throw new Exception("Mã tài khoản không hợp lệ");
        }
        this.tentk = tentk;
        this.matkhau = matkhau;
        this.matk = matk;
        this.createdate = createdate;
        this.phone = phone;
        this.cccd = cccd;
        this.email = email;
    }

    public string TenTaiKhoan { get => tentk; set => tentk = value; }
    public string MatKhau { get => matkhau; set => matkhau = value; }
    public string MaTaiKhoan { get => matk; set => matk = value; }
    public DateTime CreatedDate { get => createdate; set => createdate = value; }
    public string Phone { get => phone; set => phone = value; }
    public string Cccd { get => cccd; set => cccd = value; }
    public string Email { get => email; set => email = value; }


    public string InRaFile()
    {
        return $"{MaTaiKhoan}#{TenTaiKhoan}";
    }
    public string toString()
    {
        return $"ma: {MaTaiKhoan} ten: {TenTaiKhoan}";
    }
}
