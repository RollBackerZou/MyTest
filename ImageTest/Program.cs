using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace ImageTest
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static string ImageToString(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms,System.Drawing.Imaging.ImageFormat.Gif);
            byte[] array = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(array, 0, array.Length);
            ms.Close();
            return Convert.ToBase64String(array);
        }

        private static Image StringToImage(string str)
        {
            byte[] array = Convert.FromBase64String(str);
            MemoryStream ms = new MemoryStream();
            ms.Write(array,0,array.Length);
            ms.Close();
            Image image = Image.FromStream(ms);
            return image;
        }
    }
}
