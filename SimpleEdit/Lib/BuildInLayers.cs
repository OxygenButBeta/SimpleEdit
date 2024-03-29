using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEdit.Lib
{
    public static class BuildInLayers
    {
        public static Layer.LayerOnRender Invert()
        {
            return (Pixel In) =>
            {
                In.PixelColor = Color.FromArgb(255 - In.PixelColor.R, 255 - In.PixelColor.G, 255 - In.PixelColor.B);
                return In;
            };
        }
        public static Layer.LayerOnRender GrayScale()
        {
            return (Pixel In) =>
            {
                int Gray = (In.PixelColor.R + In.PixelColor.G + In.PixelColor.B) / 3;
                In.PixelColor = Color.FromArgb(Gray, Gray, Gray);
                return In;
            };

        }
        public static Layer.LayerOnRender Brightness(int Value)
        {
            return (Pixel In) =>
            {
                int r, g, b;
                r = SafeByte(In.PixelColor.R + Value);
                g = SafeByte(In.PixelColor.G + Value);
                b = SafeByte(In.PixelColor.B + Value);
                In.PixelColor = Color.FromArgb(r,g,b);
                return In;
            };
        }
        public static Layer.LayerOnRender Contrast(int Value)
        {
            return (Pixel In) =>
            {
                int r, g, b;
                r = SafeByte((In.PixelColor.R - 128) * Value + 128);

                g = SafeByte((In.PixelColor.G - 128) * Value + 128);
                b = SafeByte((In.PixelColor.B - 128) * Value + 128);

                In.PixelColor = Color.FromArgb(r, g, b);
                return In;
            };

        }
        public static Layer.LayerOnRender Gamma(double Value)
        {
            return (Pixel In) =>
            {
                int r, g, b;
                r = (int)(255 * Math.Pow(In.PixelColor.R / 255, 1 / Value));
                g = (int)(255 * Math.Pow(In.PixelColor.G / 255, 1 / Value));
                b = (int)(255 * Math.Pow(In.PixelColor.B / 255, 1 / Value));
                In.PixelColor = Color.FromArgb(r, g, b);
                return In;
            };

        }
        public static Layer.LayerOnRender Saturation(int Value)
        {
            double AValue = Value / 1;
            return (Pixel In) =>
            {
                int Gray = (In.PixelColor.R + In.PixelColor.G + In.PixelColor.B) / 3;
                byte r, g, b;
                r = SafeByte(Gray + AValue * (In.PixelColor.R - Gray));
                g = SafeByte(Gray + AValue * (In.PixelColor.G - Gray));
                b = SafeByte(Gray + AValue * (In.PixelColor.B - Gray));
                In.PixelColor = Color.FromArgb(r, g, b);
                return In;
            };
        }

        public static Layer.LayerOnRender ColorBalance(int Red, int Green, int Blue)
        {
            return (Pixel In) =>
            {
                int r = SafeByte(In.PixelColor.R + Red);
                int g = SafeByte(In.PixelColor.G + Green);
                int b = SafeByte(In.PixelColor.B + Blue);
                In.PixelColor = Color.FromArgb(r, g, b);
                return In;
            };
        }
        public static Layer.LayerOnRender Replace(Color Target, Color next)
        {

            return (Pixel In) =>
            {
                if (In.PixelColor == Target)
                {
                    In.PixelColor = next;
                }
                return In;
            };
        }
        static byte SafeByte(int value)
        {
            if (value > 255) return 255;
            if (value < 0) return 0;
            else return (byte)value;
        }
        static byte SafeByte(double value)
        {
            if (value > 255) return 255;
            if (value < 0) return 0;
            else return (byte)value;
        }
        public static Layer.LayerOnRender MirrorEffect()
        {
            return (Pixel In) =>
            {
                In.PixelIndex = new Point(In.SizeOfImage.X - 1 - In.PixelIndex.X, In.PixelIndex.Y);
                return In;
            };

        }
        public static Layer.LayerOnRender FlipVertically()
        {
            return (Pixel In) =>
            {
                In.PixelIndex = new Point(In.SizeOfImage.X - 1 - In.PixelIndex.X, In.SizeOfImage.Y - 1 - In.PixelIndex.Y);
                return In;
            };

        }
    }
}
