using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MusicPlay
{
    public partial class Test2 : Form
    {
        public Test2()
        {
            InitializeComponent();
        }

        private void Test2_Load(object sender, EventArgs e)
        {

     //   this.BackgroundImage=  
           
        }
        public Image tests(Size size, Image image)
        {
           int sHeight = image.Height;
            int sWidth= image.Width;
            int destHeight = size.Height;
            int destWidth = size.Width;
            if (image != null)
            {
                Image imgSource = image;
                int sW = 0, sH = 0;
                if ((sWidth * destHeight) > (sHeight * destWidth))
                {
                    sH = destHeight;
                    sW = (sWidth * destHeight) / sHeight;
                }
                else
                {
                    sW = destWidth;
                    sH = (destWidth * sHeight) / sWidth;
                }
                //创建新图位图
                Bitmap bitmap = new Bitmap(destWidth, destHeight);
                //创建作图区域
                Graphics graphic = Graphics.FromImage(bitmap);
                graphic.DrawImage(imgSource, new Rectangle((destWidth - sW) / 2, (destHeight - sH) / 2, sW, sH), 0, 0, imgSource.Width, imgSource.Height, GraphicsUnit.Pixel);
                Image newImage = Image.FromHbitmap(bitmap.GetHbitmap());
                return newImage as Bitmap;
            }
            else
            {
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = tests(this.Size, Image.FromFile(@"C:\Users\User\Desktop\MusicPlay-Online8月22日\MusicPlay\bin\Debug\Songs\Songer\Christine Welch_Photo.jpg"));
            //this.Refresh();
        }
    }
}
