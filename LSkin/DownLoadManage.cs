using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace LSkin
{
    public class DownLoadManage
    {
        public string url;
        public string fileName;
        public string state;
        public delegate void CallBack(DownLoadManage sender);
        public event CallBack CallBackDone;
        public DownloadProgressChangedEventHandler DownLoadListener;

        public void DownLoad(string url, string fileName, DownloadProgressChangedEventHandler DownLoadListener, CallBack DwonDone)
        {
            this.url = url;
            this.fileName = fileName;

            WebClient webClient = new WebClient();

            if (url == null) {
                if (DwonDone != null) {
                    this.state = "Final";
                    DwonDone(this);
                }
                return;
            }

            url = url.Replace(@"\", @"");
            //if (webClient.IsBusy)
            //{
            //    webClient.CancelAsync();
            //}
            if (DownLoadListener != null) this.DownLoadListener = DownLoadListener;
            if (DwonDone != null) this.CallBackDone = DwonDone;

            //用于记录
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownOKorErr);
            webClient.DownloadFileAsync(new Uri(url), fileName);
        }


        private void DownOKorErr(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                this.state = "Cancelled";
            }
            else
            {
                if (File.Exists(this.fileName))
                {
                    this.state = "Success";
                }
                else
                {
                    this.state = "Fail";
                }
            }
            if (this.CallBackDone != null) this.CallBackDone(this);
        }
    }


}
