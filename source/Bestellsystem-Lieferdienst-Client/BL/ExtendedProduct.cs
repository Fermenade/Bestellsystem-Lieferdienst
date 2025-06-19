using Client_Server_Code_Library;
using System.Drawing;
using System.Drawing.Imaging;
using static System.Windows.Forms.DataFormats;

namespace Bestellsystem_Lieferdienst.BL;

public class ExtendedProduct : Product
{
    private ExtendedProduct()
    {
        Name = "";
        Description = "";
        Price = 0;
        Categories = [];
        Picture = null;
    }
    public static Product CreateNewProduct() => new ExtendedProduct();

    //Generated
    byte[] DownscaleImage(byte[] image)
    {
        using (MemoryStream ms = new(image))
        {


            using (Image originalImage = Image.FromStream(ms))
            {
                // Calculate the new dimensions while maintaining the aspect ratio
                Size newSize = GetNewSize(originalImage.Size, 1000, 1000);

                // Create a new bitmap with the new dimensions
                using (Bitmap resizedImage = new Bitmap(newSize.Width, newSize.Height))
                {
                    using (Graphics graphics = Graphics.FromImage(resizedImage))
                    {
                        // Set the interpolation mode for better quality
                        graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                        // Draw the original image onto the resized bitmap
                        graphics.DrawImage(originalImage, 0, 0, newSize.Width, newSize.Height);
                    }

                    // Save the resized image
                    using (MemoryStream ms1 = new MemoryStream())
                    {
                        resizedImage.Save(ms1, ImageFormat.Png);
                        return ms1.ToArray();
                    }
                }
            }
        }
    }
    //Generated
    private static Size GetNewSize(Size originalSize, int maxWidth, int maxHeight)
    {
        // Calculate the aspect ratio
        float ratioX = (float)maxWidth / originalSize.Width;
        float ratioY = (float)maxHeight / originalSize.Height;
        float ratio = Math.Min(ratioX, ratioY);

        // Calculate new dimensions
        int newWidth = (int)(originalSize.Width * ratio);
        int newHeight = (int)(originalSize.Height * ratio);

        return new Size(newWidth, newHeight);
    }
}