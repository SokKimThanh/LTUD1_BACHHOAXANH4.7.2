public class GenerateID
{
    /// <summary>
    /// Tìm newid cuối của danh sách
    /// </summary>
    /// <param name="prefix">ví dụ: nv0312312</param>
    /// <param name="id_cuoi">ví dụ: 01232123</param>
    /// <returns></returns>
    public static string generateID(string prefix, string id_cuoi, int startinxdex = 2)
    {
        // idIncrease: bỏ 2 kí tự đầu và chuyển sang số, rồi cộng lên 1
        int idIncrease = Convert.ToInt32(id_cuoi.Trim().Substring(startinxdex)) + 1;
        // newid: định dạng số kết quả thành 9 số dạng chuỗi
        string newid = prefix + string.Format("{0:0000}", idIncrease);
        // newid: trả về kết quả
        return newid;//ví dụ nv0123456789
    }
}

