using System.Drawing;
using System.IO;
namespace POSUI.Helper;
public static class ImageHelper
{
    public static byte[] ImageToByteArray(Image image)
    {
        using var ms = new MemoryStream();
        image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
        return ms.ToArray();
    }

    public static Image ByteArrayToImage(byte[] bytes)
    {
        if (bytes == null || bytes.Length < 4)
            return Image.FromFile("images/shop.png");

        using var ms = new MemoryStream(bytes);
        try
        {
            return Image.FromStream(ms);
        }
        catch
        {
            return Image.FromFile("images/shop.png");
        }
    }
}
