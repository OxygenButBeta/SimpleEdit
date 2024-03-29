using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEdit.Lib
{
    public class IO
    {
        public string LastFilePath;
        public DialogResult ReadBitmap(out Bitmap b)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    LastFilePath = ofd.FileName;
                    b = InternalReadBitmap(ofd.FileName);
                    return DialogResult.OK;
                }
                else
                {
                    b = null;
                    return DialogResult.None;
                }
            }
        }
        public Bitmap ReadLast() => InternalReadBitmap(LastFilePath);
        private Bitmap InternalReadBitmap(string path) => new Bitmap(path);
        public Bitmap DirectRead(string path)
        {
            LastFilePath = path;
            return InternalReadBitmap(path);
        }
        public void SaveAs(Bitmap image)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    image.Save(sfd.FileName);
                }
            }
        }
        public void Save(Bitmap image, string path)
        {
            image.Save(path);
            LastFilePath = path;

        }

    }
}
