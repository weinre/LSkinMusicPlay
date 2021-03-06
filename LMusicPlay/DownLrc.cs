﻿using System;
using System.ComponentModel;
using System.Net;

namespace MusicPlay
{
    class DownLrc
    {    
      
   
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

            webClient.DownloadFileAsync(new Uri(url), PATH);
            return null;
        }

        private void DownLoadListener(object sender, DownloadProgressChangedEventArgs e)
        {
            long max = e.TotalBytesToReceive;
            long value = e.BytesReceived;
        }
        private void DownOKorErr(object sender, AsyncCompletedEventArgs e)
        {

            if (e.Cancelled)
            {

                //err

            }
            
            else
            {
           

            }

        }

    }
}
