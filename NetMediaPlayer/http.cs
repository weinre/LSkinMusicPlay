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

        public String getJsonText(String url)
        {
            WebClient wc = new WebClient();
            wc.Credentials = CredentialCache.DefaultCredentials;
            Encoding encoding = Encoding.GetEncoding("UTF-8");
            Byte[] data = wc.DownloadData(url);
            wc.Dispose();
            return encoding.GetString(data);


        }

        public String getUrl(String JsonText)
        {

            try
            {
               
                JsonValue obj = JsonObject.Parse(JsonText);
                String url = obj["url"].ToString();
                url = url.Replace(@"""", "");
                return url;
            }
            catch (Exception)
            {


            }
            return null;

        }

        public List<Song> GetList(String JsonText)
        {
            JsonValue obj = JsonObject.Parse(JsonText);
            int total = obj["data"]["info"].Count;
            List<Song> songs = new List<Song>();
            Song s = null;
            for (int i = 0; i < total; i++)
            {
                string extname = (string)obj["data"]["info"][i]["extname"].ToString();
                string filename = (string)obj["data"]["info"][i]["filename"].ToString();
                string songname = (string)obj["data"]["info"][i]["songname"].ToString();
                string hash = (string)obj["data"]["info"][i]["hash"].ToString();
                string duration = (string)obj["data"]["info"][i]["duration"].ToString();
                string durationStr = (string)obj["data"]["info"][i]["duration"].ToString();
                string singername = (string)obj["data"]["info"][i]["singername"].ToString();
                songname = songname.Replace(@"""", "");
                extname = extname.Replace(@"""", "");
                filename = filename.Replace(@"""", "");
                hash = hash.Replace(@"""", "");
                durationStr = durationStr.Replace(@"""", "");
                singername = singername.Replace(@"""", "");
                s = new Song();
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
        public Lrc getLrc(String LrcJsonText)
        {
            Lrc l = new Lrc();
            try
            {
                JsonValue obj = JsonObject.Parse(LrcJsonText);
                string id = (string)obj["candidates"][0]["id"].ToString();
                string accesskey = (string)obj["candidates"][0]["accesskey"].ToString();
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

        public String Getcontent(String JsonText)
        {
            Lrc l = new Lrc();
            try
            {
                JsonValue obj = JsonObject.Parse(JsonText);
               
                string content = (string)obj["content"].ToString();
               
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
