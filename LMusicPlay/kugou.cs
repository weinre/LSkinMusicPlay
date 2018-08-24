using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusciPlay
{
    class kugou
    {
        string Songlrc = "http://lyrics.kugou.com/search?ver=1&man=yes&client=pc&keyword={songname}&duration={duration}";
        string LrcText = "http://lyrics.kugou.com/download?ver=1&client=pc&id={id}&accesskey={accesskey}&fmt=lrc&charset=utf8";

        string SingerPhoto = "http://artistpicserver.kuwo.cn/pic.web?type=big_artist_pic&pictype=url&content=list&&id=0&name={SingerName}&from=pc&json=1&width=1920&height=1080";

        //根据关键字获取歌曲集合和（hash）
        // string songlist = "http://mobilecdn.kugou.com/api/v3/search/song?format=json&keyword={songname}&page=1&pagesize=1000";
        string songlist = " http://songsearch.kugou.com/song_search_v2?keyword={songname}&page=1&pagesize=50&platform=WebFilter";

        string mvUrl = "http://m.kugou.com/app/i/mv.php?cmd=100&hash={hash}&ismp3=1&ext=mp4";


        string SongInfoApi = "http://wwwapi.kugou.com/yy/index.php?r=play/getdata&hash={hash}";

        //根据hash获取歌曲url
        string songinfo = "http://m.kugou.com/app/i/getSongInfo.php?hash={hash}&cmd=playInfo";

        string songerimg = "http://mobilecdn.kugou.com/new/app/i/yueku.php?cmd=104&size=120&singer={songer}&type=softhead";
        string str = "";
        public string list(string songname)
        {
            str = songlist;
            str = str.Replace("{songname}", songname);
            return str;
          
        }
        public string ReplaceSingerUrl(string singeName) {
            str = SingerPhoto;
            str = str.Replace("{SingerName}", singeName);
            return str;
        }

        public string ReplaceMVUrl(string hash)
        {
            str = mvUrl;
            str = str.Replace("{hash}", hash);
            return str;
        }

        public string ReplaceSongInfoUrl(string hash)
        {
            str = SongInfoApi;
            str = str.Replace("{hash}", hash);
            return str;
        }





        public string getinfo(string hash)
        {
            str = songinfo;
            str = str.Replace("{hash}", hash);
            return str;
        }

        public string getimg(string songer)
        {
            str = songerimg;
            str = str.Replace("{songer}", songer);
            return str;
        }

        public string getLrcLst(string songname, string duration)
        {
            str = Songlrc;
            str = str.Replace("{songname}", songname);
            str = str.Replace("{duration}", (Convert.ToInt32(duration) * 1000) + "");
            return str;



        }

        public string getLrcText(string id, string accesskey)
        {
            str = LrcText;
            str = str.Replace("{id}", id);
            str = str.Replace("{accesskey}", accesskey);
            return str;
        }
    }
}
