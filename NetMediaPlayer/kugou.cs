using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusciPlay
{
    class kugou
    {
        String Songlrc = "http://lyrics.kugou.com/search?ver=1&man=yes&client=pc&keyword={songname}&duration={duration}";
        String LrcText = "http://lyrics.kugou.com/download?ver=1&client=pc&id={id}&accesskey={accesskey}&fmt=lrc&charset=utf8";
        //根据关键字获取歌曲集合和（hash）
        String songlist = "http://mobilecdn.kugou.com/api/v3/search/song?format=json&keyword={songname}&page=1&pagesize=1000";
        //根据hash获取歌曲url
        String songinfo = "http://m.kugou.com/app/i/getSongInfo.php?hash={hash}&cmd=playInfo";
   
        String songerimg = "http://mobilecdn.kugou.com/new/app/i/yueku.php?cmd=104&size=120&singer={songer}&type=softhead";
        string str = "";
        public String list(String songname)
        {
            str = songlist;
            str = str.Replace("{songname}", songname);

            return str;
        }

        public String getinfo(String hash)
        {
            str = songinfo;
            str = str.Replace("{hash}", hash);
            return str;
        }

        public String getimg(String songer)
        {
            str = songerimg;
            str = str.Replace("{songer}", songer);
            return str;
        }

        public String getLrcLst(String songname, String duration)
        {
            str = Songlrc;

            str = str.Replace("{songname}", songname);
            str = str.Replace("{duration}", (Convert.ToInt32(duration) * 1000).ToString());
            return str;

        }

        public String getLrcText(String id, String accesskey)
        {
            str = LrcText;
            str = str.Replace("{id}", id);
            str = str.Replace("{accesskey}", accesskey);
            return str;
        }
    }
}
