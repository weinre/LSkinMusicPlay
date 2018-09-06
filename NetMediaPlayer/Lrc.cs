using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlay
{
   public class Lrc
    {
        //private String songname;
        //private string songername;
        //private String length;
        private String accesskey;
        private string key;
        private int ScrollValue;

        public int ScrollValue1
        {
            get { return ScrollValue; }
            set { ScrollValue = value; }
        }
        public string Key
        {
            get { return key; }
            set { key = value; }
        }
        private string value;

        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        public String Accesskey
        {
            get { return accesskey; }
            set { accesskey = value; }
        }
        private String id;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
