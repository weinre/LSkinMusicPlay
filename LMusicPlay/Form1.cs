
using Shell32;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LMusicPlay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //this.Controls.Add(a);

            string strMp3 = @"D:\CloudMusic\任金勇 - 任金勇 - 苏喂苏喂苏喂（Remix）.mp3";
            axPlayer1.Open(@"D:\CloudMusic\任金勇 - 任金勇 - 苏喂苏喂苏喂（Remix）.mp3");
            axPlayer1.Play();

         //
            string mp3InfoInterHtml = "";

         //   ID3Info info = new ID3Info(strMp3, true);
            //Image image = System.Drawing.Image.FromStream();


            //Folder dir = sh.NameSpace(Path.GetDirectoryName(strMp3));
            //FolderItem item = dir.ParseName(Path.GetFileName(strMp3));

      //      Image image = System.Drawing.Image.FromStream(info.ID3v2Info.AttachedPictureFrames.Items[0].Data);

            //         this.BackgroundImage = image;
            //ShellClass 
            //ShellClass sh = new ShellClass();
            //Folder dir = sh.NameSpace(Path.GetDirectoryName(Server.MapPath(strMp3)));
            //FolderItem item = dir.ParseName(Path.GetFileName(Server.MapPath(strMp3)));
            //mp3InfoInterHtml += "文件名：" + dir.GetDetailsOf(item, 0) + "<br>";
            //mp3InfoInterHtml += "文件大小：" + dir.GetDetailsOf(item, 1) + "<br>";
            //mp3InfoInterHtml += "歌曲名：" + dir.GetDetailsOf(item, 21) + "<br>";
            //mp3InfoInterHtml += "歌手：" + dir.GetDetailsOf(item, 13) + "<br>";
            //mp3InfoInterHtml += "专辑：" + dir.GetDetailsOf(item, 14) + "<br>";
            //mp3InfoInterHtml += "时长：" + dir.GetDetailsOf(item, 27) + "<br>";


            Console.WriteLine(mp3InfoInterHtml);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string strMp3 = @"D:\CloudMusic\任金勇 - 任金勇 - 苏喂苏喂苏喂（Remix）.mp3";


            //ID3Info info = new ID3Info(strMp3, true);
            //Image image = System.Drawing.Image.FromStream(info.ID3v2Info.AttachedPictureFrames.Items[0].Data);

            //Console.WriteLine(info.ID3v2Info.ToString()); 

            //this.BackgroundImage = image;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
