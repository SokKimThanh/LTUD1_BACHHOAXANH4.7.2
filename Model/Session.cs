using System.Collections.Generic;

public class Session
{
    private static string username = "";// chưa nhớ matkhau tentk
    public string Username { get => username; set => username = value; }

    //public string MatKhau { get; set; }
    //private static bool rememberMe = false;// chưa nhớ matkhau tentk

    private readonly Dictionary<string, object> _lst = new Dictionary<string, object>();

    //public bool RememberMe { get => rememberMe; set => rememberMe = value; }

    /// <summary>
    /// tạo mới và chỉnh sửa value 
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    private void Add(string key, object value)
    {
        if (_lst.ContainsKey(key))//chỗ này là kiểm tra xem có key đó chưa nếu 
            _lst[key] = value;
        else
            _lst.Add(key, value);//còn không có thì mình add vào;
    }
    /// <summary>
    /// lấy Session theo key
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    private object Get(string key)
    {
        if (_lst.ContainsKey(key))
            return _lst[key];
        else
            return "";
    }

    public object this[string key]
    {
        set { Add(key, value); }
        get { return Get(key); }
    }
    /// <summary>
    /// xóa dữ liệu trong list (xóa Session)
    /// </summary>
    public void Clear()
    {
        _lst.Clear();
    }

    /// <summary>
    /// Lưu mật khẩu user name cho lần đăng nhập sau
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    //public void RememberMeLogin(bool RememberMeCheck)
    //{
    //if (RememberMeCheck == true)
    //    {
    //        // Ghi thông tin vào tệp  
    //        //using (var writer = new StreamWriter("login.txt"))
    //        //{//mo file
    //        //    writer.WriteLine($"{TenTaiKhoan}#{MatKhau}");
    //        //}//dong file 
    //        this["tentk"] = TenTaiKhoan;//lưu Session
    //    }
    //    else
    //    {
    //        this["tentk"] = ""; ;//xóa Session
    //    }
    //else
    //{
    //    // Đọc thông tin từ tệp 
    //    using (var reader = new StreamReader("login.txt"))
    //    {//mo file
    //        var fileContents = reader.ReadToEnd();
    //        string[] arr = fileContents.ToString().Split("#");
    //        TenTaiKhoan = arr[0];
    //        MatKhau = arr[1];
    //    }//dong file
    //    // hoặc lấy key
    //    Get(TenTaiKhoan);
    //    RememberMe = false;
    //}
    //}
}
