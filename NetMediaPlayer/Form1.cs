using MusciPlay;
using MusicPlay;
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace loveTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //this.Location = new Point(-10000, -10000);
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, Application.ProductName, out flag);
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
        public static extern int SystemParametersInfo(
           int uAction,
           int uParam,
           string lpvParam,
           int fuWinIni
           );
        string roomid = "6121065";
        string temstr = "";
        System.Speech.Synthesis.SpeechSynthesizer speech;
        bool flag;

        private void Form1_Load(object sender, EventArgs e)
        {
            speak("欢迎使用，么么哒");
            //axPlayer1.Controls.Add(panel3);
        }
        private void mbox(string str)
        {
            MessageBox.Show(str);
        }
        static List<string> GetDanMu(string room)
        {
            string danmu = Post(room);
            //string danm = Regex.Unescape(danmu.Substring(7, danmu.Length - 8));
            //MessageBox.Show(danm);
            List<string> list = new List<string>();
            //正则匹配
            foreach (Match item in Regex.Matches(danmu, "text\":\".*?\""))
            {
                //截取字符串，将unicode码转换为中文
                list.Add(Regex.Unescape(item.Value.Substring(7, item.Value.Length - 8)));
            }
            return list;
        }
        static string Post(string room)
        {
            try
            {
                string postString = "roomid=" + room + "&token=&csrf_token=123456";//要发送的数据
                byte[] postData = Encoding.UTF8.GetBytes(postString);//编码，尤其是汉字，事先要看下抓取网页的编码方式  
                string url = @"http://api.live.bilibili.com/ajax/msg";//地址  
                WebClient webClient = new WebClient();
                webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/61.0.3163.100 Safari/537.36");
                webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");//采取POST方式必须加的header，如果改为GET方式的话就去掉这句话即可  
                webClient.Headers.Add("Cookie",
                    "123456"
                    );
                byte[] responseData = webClient.UploadData(url, "POST", postData);//得到返回字符流  
                string srcString = Encoding.UTF8.GetString(responseData);//解码  
                return srcString;
            }
            catch (Exception)
            {
                return "";
            }
        }


        private void speak(object text)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(anycSpeak), text);
        }


        private void anycSpeak(object text)
        {

            try
            {
                speech = new System.Speech.Synthesis.SpeechSynthesizer();
                speech.Volume = 100;
                speech.Rate = 1;
                speech.Speak(text.ToString());
            }
            catch (Exception)
            {


            }
        }
        List<Song> Songs;
        http h = new http();
        kugou k = new kugou();
        private void playmusic(string str)
        {
            if (str == "")
            {
                //musicplay.URL = @"";
            }
            else
            {
                Songs = new List<Song>();
                Songs = h.GetList(h.getJsonText(k.list(str)));

                if (Songs.Count > 0)
                {
                    Song s = Songs[0];
                    String url = k.getinfo(s.Hash);
                    String JsonText = h.getJsonText(url);
                    String src = h.getUrl(JsonText);
                    axPlayer1.Open(src);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.Hide();
            List<string> list = GetDanMu(roomid);
            if (list.Count == 0) return;
            string code = list[list.Count - 1];
            if (temstr != code)
            {
                temstr = code;
                Console.WriteLine(code);
                if (code.Contains("mbox#"))
                {
                    mbox(code.Substring(code.IndexOf("#") + 1, code.Length - code.IndexOf("#") - 1));
                }
                if (code.Contains("music#"))
                {
                    playmusic(code.Substring(code.IndexOf("#") + 1, code.Length - code.IndexOf("#") - 1));
                }
                if (code.Contains("say#"))
                {
                    speak(code.Substring(code.IndexOf("#") + 1, code.Length - code.IndexOf("#") - 1));
                }

                if (code.Contains("dur#"))
                {
                    changeDur(code.Substring(code.IndexOf("#") + 1, code.Length - code.IndexOf("#") - 1));
                }


            }
        }

        private void changeDur(string str)
        {
            try
            {
                axPlayer1.Position = Convert.ToInt32(str) * 1000;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("原理：借助B站弹幕执行命令\r\n作者：林火影\r\nQQ：1512637782");
        }





        private String CastToFen(String Duration)
        {
            int miao = Convert.ToInt32(Duration);
            String fen = miao / 60 + "";
            String miaox = miao % 60 + "";
            if (fen.Length < 2)
            {
                fen = "0" + fen;
            }
            if (miaox.Length < 2)
            {
                miaox = "0" + miaox;
            }
            return fen + ":" + miaox;
        }

        private void GetNetData(object sender)
        {

            float postion = (axPlayer1.Position); //视频当前进度 /秒
            float duration = (axPlayer1.Duration);//视频总长度 /秒
            try
            {
                label1.Text = CastToFen((int)(postion / 1000) + "");
                label2.Text = CastToFen((int)(duration / 1000) + "");
            }
            catch (Exception ex)
            {
                //   Console.WriteLine(ex.Message);
            }
            try
            {

                //进度条的长度
                float totalW = panel1.Width;
                double panel2W = totalW / duration * postion;
                this.Text = panel2W + "";
                panel2.Width = Convert.ToInt32(panel2W);


            }
            catch (Exception ex)
            {
                //     Console.WriteLine(ex.Message);
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(GetNetData), "");

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            float duration = axPlayer1.Duration;//视频总长度 /秒
            panel2.Width = e.Location.X;
            float totalW = panel1.Width;
            double num = duration / totalW * panel2.Width;
            axPlayer1.Position = Convert.ToInt32(num);
        }

        private void 打开本地视频ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (DialogResult.OK == file.ShowDialog())
            {
                axPlayer1.Open(file.FileName);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void 全屏ToolStripMenuItem_Click(object sender, EventArgs e)
        {


            menuStrip1.Hide();
            panel3.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }

        private void 退出全屏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void 全屏ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            menuStrip1.Hide();
            panel3.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

        }



        private void 取消全屏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string filePath = ((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            MessageBox.Show(filePath);
        }

        private void r(object sender, EventArgs e)
        {

        }

        private void panel4_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void r(object sender, PaintEventArgs e)
        {

        }
    }
}
