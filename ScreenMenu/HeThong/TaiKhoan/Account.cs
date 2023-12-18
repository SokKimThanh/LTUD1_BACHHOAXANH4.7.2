internal class Account
{
    private string tentk, matkhau, manv, maqtc;

    public Account(string tentk, string matkhau, string manv, string maqtc)
    {
        this.Tentk = tentk;
        this.Matkhau = matkhau;
        this.Manv = manv;
        this.Maqtc = maqtc;
    }
    public Account()
    {

    }

    public string Tentk { get => tentk; set => tentk = value; }
    public string Matkhau { get => matkhau; set => matkhau = value; }
    public string Manv { get => manv; set => manv = value; }
    public string Maqtc { get => maqtc; set => maqtc = value; }

    // return object
}
