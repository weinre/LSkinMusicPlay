using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicPlay
{
  public  class Song
    {
        public string songname { get; set; }
        /// <summary>
        /// 歌曲名称
        /// </summary>
        private string filename;

        private string hash;
        private string extname;
        public string Extname
        {
            get { return extname; }
            set { extname = value; }
        }
        public string Hash
        {
            get { return hash; }
            set { hash = value; }
        }
        public string Filename
        {
            get { return filename; }
            set { filename = value; }
        }
        private string durationStr;

        private string duration;

        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public string DurationStr
        {
            get { return durationStr; }
            set { durationStr = value; }
        }
        private string singername;
        public string Singername
        {
            get { return singername; }
            set { singername = value; }
        }





    }
}
