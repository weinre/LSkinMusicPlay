using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlay
{
    class DownLoad 
    {
         
        public Song s;
        public Panel blue;
        public Panel gray;
        public DownSong d;   
        public PictureBox px; 
        int maxvalue;
        string filename;
        public Label lb;
        public String Down(String url, String PATH)
        {
            WebClient webClient = new WebClient();
            url = url.Replace(@"\", @"");
            filename = PATH;
            if (webClient.IsBusy)
            {
                webClient.CancelAsync();
            }
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownLoadListener);
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownOKorErr);
            blue.Width = 0;
            webClient.DownloadFileAsync(new Uri(url), PATH);
            return null;
        }

        int i = 0;
        string[] imgs = new string[] { @"System\Static\don\1.png", @"System\Static\don\2.png", @"System\Static\don\3.png", @"System\Static\don\4.png" };
        private void DownLoadListener(object sender, DownloadProgressChangedEventArgs e)
        {
            if (2 == i)
            {
                i = 0;
            }
            //px.Image = Image.FromFile(imgs[i]);
            i++;
            long max = e.TotalBytesToReceive;
            maxvalue = (int)max;
            long value = e.BytesReceived;
            try
            {
                blue.Width = (int)((double)(gray.Width * value) * 1.0 / (double)max);

            //    
       
                if (blue.Width != 0)
                {
                    Double a = (Double)blue.Width;
                    Double b = (Double)gray.Width;
                    string str = (int)(a / b * 100) + "%";

                    lb.Text = str;
              
                }
            }
            catch (Exception)
            {

                throw;
            }





        }
        private void DownOKorErr(object sender, AsyncCompletedEventArgs e)
        {

            if (e.Cancelled)
            {

                //err
                lb.Text = "下载失败";
                gray.BackColor = Color.Red;
            }

            else
            {
                //ok
             //   MessageBox.Show("下载完成！");
                lb.Text = "下载完成!";

                MessageBox.Show("下载成功\n\r" + filename);
                System.Diagnostics.Process.Start("Explorer.exe",Application.StartupPath+ "\\Songs\\Audio" );
            }
         //px.Visible = false;
        }
    }
}
