using System.Drawing;


/// <summary>
/// Phải vừa đổi được màu html sang màu hệ thống, 
/// phải vừa có màu mặc định để gọi cho lẹ. 
/// phải vừa dùng được cả trong đầu vào các hàm khác nhau
/// </summary>
public class ErrColors
{
    //Trong c# cách để thêm 1 màu mới
    //tetradic #E25966 #AAE259 #59E2D5 #9159E2
    public Color err_txt_required = ColorTranslator.FromHtml("#E25966");// "light red"
    public Color err_txt_notext = ColorTranslator.FromHtml("#AAE259");// "dark red"
    public Color err_txt_nonumber = ColorTranslator.FromHtml("#59E2D5");// "light green" 
    public Color err_txt_nospace = ColorTranslator.FromHtml("#9159E2");// "????" 

    //analogous #E29159 #E29159 #E259AA
    public Color err_txt_nocontains_exist_item = ColorTranslator.FromHtml("#E29159");// "????" 
    public Color err_txt_minmax_length = ColorTranslator.FromHtml("#E259AA");// "????" 
                                                                             //triadic #E25966 #66E259   #5966E2
    internal Color err_txt_nosymbol = ColorTranslator.FromHtml("#5966E2");// "????"

    // message color
    public Color mes_error = ColorTranslator.FromHtml("#DA2E3E");// "light red"        
    public Color mes_success = ColorTranslator.FromHtml("#94DA2E");// "light green"        
    public Color mes_warning = ColorTranslator.FromHtml("#FFF767");// "light yellow"      
    public Color mes_info = ColorTranslator.FromHtml("#2EDACA");// "water"      
    public Color mes_black = ColorTranslator.FromHtml("#000000");// "black"      
    public Color mes_white = ColorTranslator.FromHtml("#ffffff");// "white"      
    public Color mes_purple = ColorTranslator.FromHtml("#742EDA");// "purple"
    public Color mes_primary = ColorTranslator.FromHtml("#2E3EDA");// "primary blue"      


    public Color err_lv_listview_back_color = ColorTranslator.FromHtml("#aa0906");// "red brown"
    public Color Transparent = Color.Transparent;
    public Color primaryGreen = ColorTranslator.FromHtml("#9159E2");
}

