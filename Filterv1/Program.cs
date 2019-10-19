using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Filterv1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Image srcImage = Image.FromFile("res/mountains.jpg");
                Image filteredImage;
                Bitmap bmpImage = new Bitmap(srcImage);

                Bitmap filteredBitmap = new Bitmap(bmpImage.Width, bmpImage.Height);
                Color originalPixel;
                Color newPixel;

                for (int i = 0; i < bmpImage.Width; i++)
                {
                    for (int j = 0; j < bmpImage.Height; j++)
                    {
                        // remove the red colour from the image
                        originalPixel = bmpImage.GetPixel(i, j);
                        newPixel = Color.FromArgb(0, originalPixel.G, originalPixel.B);
                        filteredBitmap.SetPixel(i, j, newPixel);
                    }
                }

                filteredImage = (Image) filteredBitmap;
                filteredImage.Save("res/mountains-nored.jpg", ImageFormat.Jpeg);
                Console.WriteLine("All good");
                Console.ReadKey();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }

        }
    }
}
