using MusicPlay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Json;


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
            int j = 0;
            List<Song> list = new List<Song>();
            string[] files = Directory.GetFiles(path);
            for (int i = 0; i < files.Length; i++)
            {
                string text = files[i].ToLower();
                if (text.Substring(files[i].Length - 3, 3).Equals("mp3") || text.Substring(files[i].Length - 3, 3).Equals("mp4"))
                {
                    Song s = new Song();
                    s.Hash = null;
                    j++;
                    s.Extname = text.Substring(files[i].Length - 3, 3);
                    s.play_url = text;

                    string text2 = text.Substring(3, 3);
                    string text1 = text.Substring(text.LastIndexOf("\\") + 1);
                    s.Filename = text1.Substring(0, text1.Length - 4);
                    s.songname = s.Filename;
                    if (s.Filename.Length > 20)
                    {
                        s.Filename = s.Filename.Substring(0, 20) + "...";
                    }
                    list.Add(s);
                }
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

            s.play_url = data["play_url"].ToString();
            s.singerHeadimg = data["img"].ToString();
            s.lyrics = data["lyrics"].ToString();
            s.play_url = data["play_url"].ToString().Replace(@"""", "");

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
