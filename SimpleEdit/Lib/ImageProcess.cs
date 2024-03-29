using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SimpleEdit.Lib.Layer;

namespace SimpleEdit.Lib
{
    public static class ImageProcess
    {
        public static async Task<Bitmap> ReDrawBitmap(Bitmap _image, LayerTree LayerTree, Label l, CancellationToken token, float scale = 1, string UpdateKey = "Processing")
        {

            return await Task.Run(() =>
            {

                Bitmap image = ResizeImage(_image, scale);

                long Current = 0;
                long Total = image.Width * image.Height;
                long Fix = 0;

                if (image == null)
                    return null;
                List<LayerOnRender> RenderLayers = GetRenderLayers(LayerTree);

                Bitmap img = new Bitmap(image.Width, image.Height);

                Pixel ParameterPixel = new Pixel()
                {
                    SizeOfImage = new Point(image.Width, image.Height)
                };

                Pixel ResultPixel = new Pixel();
                if (RenderLayers == null)
                    return image;

                bool Continue = false;
                foreach (LayerOnRender layer in RenderLayers)
                {
                    if (layer != null)
                        Continue = true;
                }
                if (!Continue)
                    return image;

                for (int x = 0; x < image.Width; x++)
                {
                    for (int y = 0; y < image.Height; y++)
                    {



                        ParameterPixel.PixelIndex = new Point(x, y);
                        ParameterPixel.PixelColor = image.GetPixel(x, y);

                        for (int i = 0; i < RenderLayers.Count; i++)
                        {
                            if (RenderLayers[i] != null)
                                ResultPixel = RenderLayers[i](ParameterPixel);
                            else
                                ResultPixel = ParameterPixel;
                        }
                        if (Fix % 50 == 0)
                        {
                            l.Invoke(new Action(() =>
                            {
                                Current++;
                                l.Text = $"{UpdateKey} : {((double)Current / Total * 100) * 50:0.0}%";

                            }));
                        }

                        Fix++;

                        img.SetPixel(ResultPixel.PixelIndex.X, ResultPixel.PixelIndex.Y, ResultPixel.PixelColor);

                    }
                    if (token.IsCancellationRequested)
                    {
                        l.Invoke(new Action(() =>
                        {
                            Current++;
                            l.Text = $"No Task";
                        }));
                        return image;
                    }
                }

                return img;

            });


        }
        public static List<LayerOnRender> GetRenderLayers(LayerTree tree)
        {
            List<LayerOnRender> layers = new List<LayerOnRender>();
            PropertyInfo[] properties = tree.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (property.PropertyType == typeof(LayerOnRender))
                    layers.Add((LayerOnRender)property.GetValue(tree));
            }
            return layers;
        }
        public static Bitmap ResizeImage(Bitmap Image, int Width, int height)
        {


            Bitmap resizedBitmap = new Bitmap(Width, height);

            using (Graphics g = Graphics.FromImage(resizedBitmap))
            {
                g.DrawImage(Image, 0, 0, Width, height);
            }
            return resizedBitmap;

        }
        public static Bitmap ResizeImage(Bitmap Image, float scale) => ResizeImage(Image, (int)(Image.Width * scale), (int)(Image.Height * scale));
    }
    public class Pixel
    {
        public Point PixelIndex { get; set; }
        public Color PixelColor { get; set; }
        public Point SizeOfImage { get; set; }

    }
    public class Layer
    {
        public delegate Pixel LayerOnRender(Pixel In);
        public LayerOnRender Render;
    }

}

