using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ExtendCSharpWPF
{
    public static class Extension
    {
        [DllImport("gdi32")]
        private static extern int GetPixel(int hdc, int nXPos, int nYPos);

        [DllImport("user32")]
        private static extern int GetWindowDC(int hwnd);

        [DllImport("user32")]
        private static extern int ReleaseDC(int hWnd, int hDC);

        //TODO: controllare il parametro stretch!!
        public static Size RealImageSize(this Image img)
        {
            double x = img.Source.Width;
            double y = img.Source.Width;
            double propY = img.ActualHeight/y;
            double propX = img.ActualWidth/x ;
            if( propY< propX)
            {
                return new Size(x * propY, y * propY);
            }
            else
            {
                return new Size(x * propX, y * propX);

            }
        }




        public static double Distance(this Point first,Point Other)
        {
            return Math.Sqrt(((first.X - Other.X) * (first.X - Other.X) + (first.Y - Other.Y) * (first.Y - Other.Y)));
        }





        public static Color GetPixelColor(Point point)
        {
            int lDC = GetWindowDC(0);
            int intColor = GetPixel(lDC, (int)point.X, (int)point.Y);

            // Release the DC after getting the Color.
            ReleaseDC(0, lDC);

            byte a = (byte)((intColor >> 0x18) & 0xffL);
            byte b = (byte)((intColor >> 0x10) & 0xffL);
            byte g = (byte)((intColor >> 8) & 0xffL);
            byte r = (byte)(intColor & 0xffL);
            return Color.FromRgb(r, g, b);
        }

        public static RenderTargetBitmap ToBitmap(this System.Windows.Controls.Canvas canvas)
        {
            Size size = new Size(canvas.ActualWidth, canvas.ActualHeight);

            canvas.Measure(size);
            canvas.Arrange(new Rect(size));

            // Create a render bitmap and push the surface to it
            RenderTargetBitmap renderBitmap =
              new RenderTargetBitmap(
                (int)size.Width,
                (int)size.Height,
                96d,
                96d,
                PixelFormats.Pbgra32);
            renderBitmap.Render(canvas);
            
            return renderBitmap;
        }

        public static int GetStride(this RenderTargetBitmap bitmap)
        {
            double stride = bitmap.Width * (bitmap.Format.BitsPerPixel / 8);
            var mod = stride % 4;
            if (mod != 0)
                stride += 4 - mod;
            return (int)stride;
        }

        public static byte[] GetBytes(this RenderTargetBitmap bitmap)
        {
            byte[] bytes = new byte[(int)(bitmap.Height * bitmap.Width) * 4];
            bitmap.CopyPixels(bytes, bitmap.GetStride(), 0);
            return bytes;
        }

        static public Color GetPixelColor(this Canvas canvas, Point p)
        {
            CroppedBitmap cb = new CroppedBitmap(canvas.ToBitmap(), new Int32Rect((int)p.X,(int)p.Y, 1, 1));
            var pixels = new byte[4];
            try
            {
                cb.CopyPixels(pixels, 4, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return Color.FromScRgb(pixels[3],pixels[2], pixels[1], pixels[0]);
            
        }
    }
}
