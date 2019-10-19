using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Filterv1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Image Filter");
            Console.WriteLine("Created by: L. Diaz");
            Console.WriteLine("===========================");
            Console.WriteLine("- Image filter only works with .jpg images...");
            Console.WriteLine("- Please make sure to include images in a folder named res within the");
            Console.WriteLine(" same directory as this executable file.");
            Console.WriteLine("\n Enter the file name without file extension:");
            String src = Console.ReadLine();
            try
            {
                Image srcImage = Image.FromFile("res/" + src + ".jpg");
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
                String fileName = "res/" + src + "-nored.jpg";
                filteredImage.Save(fileName, ImageFormat.Jpeg);
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
