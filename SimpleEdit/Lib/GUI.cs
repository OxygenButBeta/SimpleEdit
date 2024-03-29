using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEdit.Lib
{
    public static class GUI
    {
        public static DialogResult PickColor(out Color c)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    c = cd.Color;
                    return DialogResult.OK;
                }
                else
                {
                    c = Color.Empty;
                    return DialogResult.None;
                }
            }
        }

    }
}
