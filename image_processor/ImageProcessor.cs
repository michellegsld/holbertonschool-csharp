using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

class ImageProcessor
{
    public static void Inverse(string[] filenames)
    {
        Parallel.ForEach(filenames, filename =>
        {
            int x = 0;
            int y = 0;

            string file = Path.GetFileNameWithoutExtension(filename);
            string extension = Path.GetExtension(filename);

            Bitmap inverted = new Bitmap(filename);

            for (; x < inverted.Width; x++)
            {
                for (y = 0; y < inverted.Height; y++)
                {
                    Color currentPixel = inverted.GetPixel(x, y);
                    currentPixel = Color.FromArgb(255 - currentPixel.R, 255 - currentPixel.G, 255 - currentPixel.B);
                    inverted.SetPixel(x, y, currentPixel);
                }
            }

            inverted.Save(file + "_inverted" + extension);
        }
        );
    }
}
