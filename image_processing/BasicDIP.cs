using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace image_processing
{
    static class BasicDIP
    {
        public static void PixelCopy(Bitmap a, ref Bitmap b)
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

        public static void GrayScale(Bitmap a, ref Bitmap b)
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

        public static void Inversion(Bitmap a, ref Bitmap b)
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

        public static void MirrorHorizontal(Bitmap a, ref Bitmap b)
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
        public static void MirrorVertical(Bitmap a, ref Bitmap b)
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

        public static void Hist(Bitmap a, ref Bitmap b)
        {
            Color sample;
            Color gray;
            Byte graydata;
            int[] histtdata = new int[256];
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    sample = a.GetPixel(x, y);
                    graydata = (byte)((sample.R + sample.G + sample.B) / 3);
                    histtdata[graydata]++;
                }
            }

            b = new Bitmap(256, 800);
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < 800; y++)
                {
                    b.SetPixel(x, y, Color.White);
                }
            }
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < Math.Min(histtdata[x] / 5, b.Height - 1); y++)
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

        public static void Sepia(Bitmap a, ref Bitmap b)
        {
            b = new Bitmap(a.Width, a.Height);

            Color pixel;
            int pr, pg, pb;

            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    pixel = a.GetPixel(x, y);
                    pr = (int)((pixel.R * .393) + (pixel.G * .769) + (pixel.B * .189));
                    pg = (int)((pixel.R * .349) + (pixel.G * .686) + (pixel.B * .168));
                    pb = (int)((pixel.R * .272) + (pixel.G * .534) + (pixel.B * .131));
                    Color color = Color.FromArgb((Math.Min(255, pr)), Math.Min(255, pg), Math.Min(255, pb));
                    b.SetPixel(x, y, color);
                }
            }
        }
    }
}
