using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEdit.Lib
{
    public class LayerTree
    {
        public Layer.LayerOnRender Replace { get; set; }
        public Layer.LayerOnRender Saturation { get; set; }
        public Layer.LayerOnRender Invert { get; set; }
        public Layer.LayerOnRender Brightness { get; set; }
        public Layer.LayerOnRender Contrast { get; set; }
        public Layer.LayerOnRender Hue { get; set; }
        public Layer.LayerOnRender ColorBalance { get; set; }
        public Layer.LayerOnRender Exposure { get; set; }
        public Layer.LayerOnRender Gamma { get; set; }
        public Layer.LayerOnRender Mirror { get; set; }
        public Layer.LayerOnRender FlipVertically { get; set; }
        public Layer.LayerOnRender GrayScale { get; set; }


    }
}
