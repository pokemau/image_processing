using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace image_processing
{
    static class BasicDIP
    {
        public static void PixelCopy(ref Bitmap a, ref Bitmap b)
        {
            b = new Bitmap(a.Width, a.Height);
            Color pixel;
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    pixel = a.GetPixel(x, y);
                    b.SetPixel(x, y, pixel);
                }
            }
        }

        public static void GrayScale(ref Bitmap a, ref Bitmap b)
        {
            b = new Bitmap(a.Width, a.Height);

            Color pixel;
            int average;
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    pixel = a.GetPixel(x, y);
                    average = (int)(pixel.R + pixel.G + pixel.B) / 3;
                    Color gray = Color.FromArgb(average, average, average);
                    b.SetPixel(x, y, gray);
                }
            }
        }

        public static void Inversion(ref Bitmap a, ref Bitmap b)
        {
            b = new Bitmap(a.Width, a.Height);

            Color pixel;
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    pixel = a.GetPixel(x, y);
                    Color inverted = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    b.SetPixel(x, y, inverted);
                }
            }
        }

        public static void MirrorHorizontal(ref Bitmap a, ref Bitmap b)
        {
            b = new Bitmap(a.Width, a.Height);

            Color pixel;
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    pixel = a.GetPixel(x, y);
                    b.SetPixel(x, a.Height - y - 1, pixel);
                }
            }
        }
        public static void MirrorVertical(ref Bitmap a, ref Bitmap b)
        {
            b = new Bitmap(a.Width, a.Height);

            Color pixel;
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    pixel = a.GetPixel(x, y);
                    b.SetPixel(a.Width - x - 1, y, pixel);
                }
            }
        }

        public static void Hist(ref Bitmap a, ref Bitmap b)
        {
            Color sample;
            Byte grayData;
            int[] histdata = new int[256];
            
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    sample = a.GetPixel(x, y);
                    grayData = (byte)((sample.R + sample.G + sample.B) / 3);
                    histdata[grayData]++;
                }
            }

            b = new Bitmap(256, 800);
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < Math.Min(histdata[x] / 5, b.Height - 1); y++)
                {
                    b.SetPixel(x, (b.Height - 1) - y, Color.Black);
                }
            }
        }

        public static void Brightness(ref Bitmap a, ref Bitmap b, int value)
        {
            b = new Bitmap(a.Width, a.Height);

            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    Color temp = a.GetPixel(x, y);
                    Color changed;
                    
                   if (value > 0)
                        changed = Color.FromArgb(
                            Math.Min(temp.R + value, 255), 
                            Math.Min(temp.G + value, 255), 
                            Math.Min(temp.B + value, 255));
                   else
                        changed = Color.FromArgb(
                            Math.Max(temp.R + value, 0), 
                            Math.Max(temp.G + value, 0), 
                            Math.Max(temp.B + value, 0));
                    b.SetPixel(x, y, changed);
                }
            }
        }
    }
}
