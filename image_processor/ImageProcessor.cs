using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

/// <summary>
/// Class
/// </summary>
class ImageProcessor
{
    /// <summary>
    /// Public class to invert an image
    /// </summary>
    /// <param name="filenames">List of image locations to invert</param>
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach(filenames, filename =>
        {
            string file = Path.GetFileNameWithoutExtension(filename);
            string extension = Path.GetExtension(filename);

            Bitmap inverted = new Bitmap(filename);

            Rectangle rect = new Rectangle(0, 0, inverted.Width, inverted.Height);
            System.Drawing.Imaging.BitmapData invertedData =
                inverted.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                inverted.PixelFormat);

            IntPtr ptr = invertedData.Scan0;

            int bytes = Math.Abs(invertedData.Stride) * inverted.Height;
            byte[] rgbValues = new byte[bytes];

            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            for (int i = 0; i < rgbValues.Length; i++)
                rgbValues[i] = (byte)(255 - rgbValues[i]);

            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

            inverted.UnlockBits(invertedData);

            inverted.Save(file + "_inverted" + extension);
        }
        );
    }
}
