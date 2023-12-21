using System.Drawing;
using System.Windows.Forms;

public struct RGB_COLORS
{
    public static Color PrimaryGreen = Color.FromArgb(0, 31, 72);
    public static Color SecondaryGreen = Color.FromArgb(0, 128, 0);//green
    public static Color DarkGreen = Color.FromArgb(5, 42, 25);
    public static Color PrimaryPink = Color.FromArgb(255, 169, 169);
    public static Color SecondaryPink = Color.FromArgb(240, 140, 140);
    public static Color DarkPink = Color.FromArgb(190, 149, 149);
}
public class SettingImageList
{
    private ImageList iconList;

    public SettingImageList(ImageList iconList)
    {
        this.iconList = iconList;
    }

    public ImageList IconList { get => iconList; set => iconList = value; }


    public Image getIcon(string nameImage, string type)
    {
        return IconList.Images[IconList.Images.Keys.IndexOf(nameImage + "." + type)];
    }
}

