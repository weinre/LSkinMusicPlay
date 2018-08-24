using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MusicPlay
{
    class DownSongerImg
    {
        public PictureBox pb;
        public Image DefaultSonger;
        //public MainWindow main;
        public string path;
        public String Down(String url, String PATH)
        {
            WebClient webClient = new WebClient();
            url = url.Replace(@"\", @"");
            if (webClient.IsBusy)
            {
                webClient.CancelAsync();
            }
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownLoadListener);
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownOKorErr);

            webClient.DownloadFileAsync(new Uri(url), path);
            return null;
        }

        private void DownLoadListener(object sender, DownloadProgressChangedEventArgs e)
        {

           






        }
        private void DownOKorErr(object sender, AsyncCompletedEventArgs e)
        {

            if (e.Cancelled)
            {

                //err

            }

            else
            {
                if (File.Exists(path))
                {
                    pb.BackgroundImage = Image.FromFile(path);
                //    main.tomp.Image = Image.FromFile(path);
                }
                else
                {
                    pb.BackgroundImage = DefaultSonger;


                }

            }

        }

    }
}
