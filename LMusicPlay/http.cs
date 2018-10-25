using MusicPlay;
using System;
using System.Collections.Generic;
using System.IO;
using System.Json;
using System.Linq;
using System.Net;
using System.Text;



namespace MusciPlay
{
    class http
    {

        /// <summary>
        /// 从本地获取数据
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public List<Song> LoadSong(string path)
        {
            List<Song> list = new List<Song>();

            foreach (string file in Directory.GetFiles(path))
            {
                int index = file.LastIndexOf(".");
                string extname = file.Substring(index, file.Length - index);


                if (extname != ".mp3" && extname != ".mp4") continue;

                Song s = new Song();
                s.Hash = null;
                s.Extname = extname;
                s.play_url = file;
                s.Filename = file.Substring(file.LastIndexOf(@"\") + 1, file.Length - file.LastIndexOf(@"\") - extname.Length - 1);

                if (extname == ".mp4") s.MvHash = "local";
                if (s.Filename.Contains("-"))
                {
                    s.Singername = s.Filename.Substring(0, s.Filename.IndexOf("-") - 1);
                }
                else
                {
                    s.Singername = "网络歌手";
                }

                list.Add(s);
            }
            return list;
        }

        kugou kugouApi = new kugou();
        public string getJsonText(string url)
        {
            WebClient wc = new WebClient();
            wc.Credentials = CredentialCache.DefaultCredentials;
            Encoding encoding = Encoding.GetEncoding("UTF-8");
            Byte[] data = wc.DownloadData(url);
            wc.Dispose();
            string finalStr = encoding.GetString(data);
            return finalStr;
        }

        public string getUrl(string JsonText)
        {

            try
            {

                JsonValue obj = JsonObject.Parse(JsonText);
                string url = obj["url"].ToString();
                url = url.Replace(@"""", "");
                return url;
            }
            catch (Exception)
            {


            }
            return null;

        }


        public Dictionary<string, string> GetMvList(string JsonText)
        {



            JsonValue obj = JsonObject.Parse(JsonText);
            JsonValue data = obj["mvdata"];

            Dictionary<string, string> list = new Dictionary<string, string>();

            string[] type = { "le", "rq", "sq" };

            foreach (string item in type)
            {
                try
                {
                    list.Add(item, data[item]["downurl"].ToString());
                }
                catch (Exception)
                {

                }
            }
            return list;
        }


        public Song GetSong(string hash, Song s)
        {

            JsonValue data = JsonObject.Parse(getJsonText(kugouApi.ReplaceSongInfoUrl(hash)))["data"];

            s.singerHeadimg = data["img"].ToString();
            s.lyrics = data["lyrics"].ToString();

            s.play_url = data["play_url"].ToString().Replace(@"""", "").Replace(@"\", "") ;

            s.lyrics = s.lyrics.Replace(@"\u000d\u000a", "\r\n");
            s.lyrics = s.lyrics.Replace(@"""", "");
            s.lyrics = s.lyrics.Replace(@"\", "");
            s.lyrics = s.lyrics.Replace("\"", "");

            return s;

        }

        public List<string> GetSingerPhoto(string singerName)
        {
            List<string> photoList = new List<string>();
            try
            {
                JsonValue obj = JsonObject.Parse(getJsonText(kugouApi.ReplaceSingerUrl(singerName)));
                foreach (var item in obj["array"])
                {
                    if (item.Value.ContainsKey("wpurl"))
                    {
                        photoList.Add(item.Value["wpurl"].ToString().Replace("\\", "").Replace(@"""", ""));
                    }
                }
            }
            catch (Exception ex) { }

            return photoList;
        }

        public List<Song> GetList(string JsonText)
        {

            if (JsonText.Contains("jQuery"))
            {

                int startIndex = JsonText.IndexOf("(");
                int length = JsonText.Length;
                JsonText = JsonText.Substring(startIndex + 1, length - (startIndex + 1 + 2));
                JsonText = JsonText.Replace("<em>", "");
                JsonText = JsonText.Replace("<\\/em>", "");
                JsonText = JsonText.Replace("<\\/em>", "");



            }

            JsonValue obj = JsonObject.Parse(JsonText);
            int total = obj["data"]["lists"].Count;
            JsonValue data = obj["data"]["lists"];

            List<Song> songs = new List<Song>();
            Song s = null;
            for (int i = 0; i < total; i++)
            {

                string extname = data[i]["ExtName"].ToString();
                string filename = data[i]["FileName"].ToString();
                string songname = data[i]["SongName"].ToString();
                string hash = data[i]["FileHash"].ToString();
                string duration = data[i]["Duration"].ToString();
                string durationStr = data[i]["Duration"].ToString();
                string singername = data[i]["SingerName"].ToString();
                string MvHash = data[i]["MvHash"].ToString();

                songname = songname.Replace(@"""", "");

                filename = filename.Replace(@"\", "");
                filename = filename.Replace(@"/", "");

                extname = extname.Replace(@"""", "");
                filename = filename.Replace(@"""", "");
                hash = hash.Replace(@"""", "");
                durationStr = durationStr.Replace(@"""", "");
                singername = singername.Replace(@"""", "");
                MvHash = MvHash.Replace(@"""", "");

                s = new Song();
                s.MvHash = MvHash;
                s.Filename = filename;
                s.Duration = duration;
                s.DurationStr = durationStr;
                s.Singername = singername;
                s.Hash = hash;
                s.Extname = extname;
                s.songname = songname;
                songs.Add(s);
            }

            return songs;

        }
        public Lrc getLrc(string LrcJsonText)
        {
            Lrc l = new Lrc();
            try
            {
                JsonValue obj = JsonObject.Parse(LrcJsonText);
                string id = obj["candidates"][0]["id"].ToString();
                string accesskey = obj["candidates"][0]["accesskey"].ToString();
                id = id.Replace(@"""", "");
                accesskey = accesskey.Replace(@"""", "");
                l.Accesskey = accesskey;
                l.Id = id;
                return l;
            }
            catch (Exception)
            {


            }
            return null;




        }

        public string Getcontent(string JsonText)
        {
            Lrc l = new Lrc();
            try
            {
                JsonValue obj = JsonObject.Parse(JsonText);

                string content = obj["content"].ToString();

                content = content.Replace(@"""", "");

                return content;
            }
            catch (Exception)
            {


            }
            return null;




        }
    }
}
