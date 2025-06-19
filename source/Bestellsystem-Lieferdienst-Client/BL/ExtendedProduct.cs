using Client_Server_Code_Library;
using System.Diagnostics;
using System.Drawing.Imaging;

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

    public static Product CreateProduct(int id, string name, string description, string price, byte[] picture, object[] categories)
    {
        if (!decimal.TryParse(price, out decimal Price))
        {
            throw new Exception("Price is not of type decimal");
        }


        return new(id, name, description, Price, categories.Cast<ProductCategory>().ToArray(), picture);
    }

    public static Product CreateProduct(string name, string description, string price, byte[] picture, object[] categories)
    {
        if (!decimal.TryParse(price, out decimal Price))
        {
            throw new Exception("Price is not of type decimal");
        }
        if (picture.Length > ServerClientConfig.streamsize / 10)
        {
            int maxwidth = 500;
            int maxheight = 500;
            Debug.WriteLine("Picture to big, trying to downscale image");
            do
            {
                picture = ReduceImage(picture, maxwidth, maxheight);
                maxwidth /= 2;
                maxheight /= 2;
            } while (picture.Length > ServerClientConfig.streamsize / 100);


        }

        return new(name, description, Price, categories.Cast<ProductCategory>().ToArray(), picture);
    }

    //All following code is just because I get all products from the database and filter local (maybe filtering in the database would be a good idea next time)

    //Generated
    static byte[] ReduceImage(byte[] image, int maxWidth, int maxHeight)
    {
        using (MemoryStream ms = new(image))
        {
            using (Image originalImage = Image.FromStream(ms))
            {
                // Calculate the new dimensions while maintaining the aspect ratio
                Size newSize = GetNewSize(originalImage.Size, maxWidth, maxHeight);

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

                    // Save the resized image as JPEG with quality settings
                    long quality = 20L; // Adjust quality (0-100, where 100 is the best quality)
                    return BitmapToByteArray(resizedImage, ImageFormat.Jpeg, quality);
                }
            }
        }
    }
    //generated
    private static byte[] BitmapToByteArray(Bitmap bitmap, ImageFormat format, long quality)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            // Set the quality parameter for JPEG
            if (format == ImageFormat.Jpeg)
            {
                var encoderParameters = new EncoderParameters(1);
                encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, quality);
                ImageCodecInfo jpegCodec = GetEncoder(ImageFormat.Jpeg);
                bitmap.Save(ms, jpegCodec, encoderParameters);
            }
            else
            {
                bitmap.Save(ms, format);
            }
            return ms.ToArray();
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
    //Generated
    private static ImageCodecInfo GetEncoder(ImageFormat format)
    {
        ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
        foreach (ImageCodecInfo codec in codecs)
        {
            if (codec.FormatID == format.Guid)
            {
                return codec;
            }
        }
        return null;
    }
}