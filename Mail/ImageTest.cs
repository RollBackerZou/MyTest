using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mail
{
    public partial class ImageTest : Form
    {
        public ImageTest()
        {
            InitializeComponent();
        }
        System.Drawing.Image img = Image.FromFile(@"D:\textImg\Capture.JPG");
        private void ImageTest_Load(object sender, EventArgs e)
        {            
            //pictureBox1.Image = img;
            MemoryStream stream = Image2Stream();
            var png = Image.FromStream(stream);
            
            pictureBox1.Image = png;
            
        }

        public MemoryStream Image2Stream()
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
            return ms;
        }
        private byte[] Image2Byte()
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
            return ms.GetBuffer();
        }
    }
}
