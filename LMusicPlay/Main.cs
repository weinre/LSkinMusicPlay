using ListGroup;
using LSkin;
using MusciPlay;
using PictureProcessing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Test;


namespace MusicPlay
{
    public partial class MainWindow : Form
    {
        [DllImport("user32.dll")]
        protected static extern bool AnimateWindow(IntPtr hWnd, int dwTime, int dwFlags);
        public const Int32 AW_BLEND = 0x00080000;
        public const Int32 AW_CENTER = 0x00000010;
        public const Int32 AW_ACTIVATE = 0x00020000;
        public const Int32 AW_HIDE = 0x00010000;
        public const Int32 AW_SLIDE = 0x00040000;
        public MainWindow()
        {
            InitializeComponent();
            ////  SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW); //API函数加载，实现窗体边框阴影效果
            //  this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }
        const int CS_DropSHADOW = 0x20000;
        const int GCL_STYLE = (-26);
        //声明Win32 API
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);

        Volume yl = new Volume();
        public string list;
        public DownSong down = new DownSong();
        Music music = new Music();
        List<Song> Songs = null;
        int tag = 0;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        System.Drawing.Image background = Image.FromFile(@"System\Static\default.png");

        string model = "LrcModel";
        Song playnow = null;
        Song selectnow = null;
        kugou k = new kugou();
        http h = new http();
        Color itemColor = Color.Black;
        System.Threading.Timer Play_Listen;
        DownSongerImg downSongerImg = new DownSongerImg();
        ModePlay playMode = new ModePlay();
        DownLoadManage downm = new DownLoadManage();
        //GaussianBlur gs = new GaussianBlur(0);
        Zoom zoom = new Zoom();
        //Timer play_Listen_tick;
        System.Drawing.Image DefaultSonger = Image.FromFile(@"System\Static\DefaultSonger.jpg");
        Image play_hover = System.Drawing.Image.FromFile("System\\Hover\\play.png");
        Image play_static = Image.FromFile("System\\Static\\play.png");
        Image pause_hover = Image.FromFile("System\\Hover\\pause.png");
        Image pause_static = Image.FromFile("System\\Static\\pause.png");
        string rootPath = "Data";
        string audioPath = "Data\\Songs\\";
        string lrcPath = "Data\\Songs\\";
        string SingerPath = "Data\\Songer\\";
        //去除页面闪烁
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }


        LrcPanel lrcPanel = new LrcPanel();


        private void Form1_Load(object sender, EventArgs e)
        {

            if (!Directory.Exists(rootPath)) Directory.CreateDirectory(rootPath);
            if (!Directory.Exists(audioPath)) Directory.CreateDirectory(audioPath);
            if (!Directory.Exists(lrcPath)) Directory.CreateDirectory(lrcPath);
            if (!Directory.Exists(SingerPath)) Directory.CreateDirectory(SingerPath);

            List<UserItem> userData = new List<UserItem>();//创建《我的好友里面的用户数据》



            foreach (Song item in h.LoadSong(audioPath))
            {
                userData.Add(new UserItem(null, item.Filename));
                userData.Add(new UserItem(null, item.Filename));
                userData.Add(new UserItem(null, item.Filename));
                userData.Add(new UserItem(null, item.Filename));
                userData.Add(new UserItem(null, item.Filename));
                userData.Add(new UserItem(null, item.Filename));


            }
            GroupItem pengyous = new GroupItem("我的歌曲", userData);
            listGroup1.AddItem(pengyous);
            listGroup1.AddItem(pengyous);
            listGroup1.AddItem(pengyous);
            listGroup1.AddItem(pengyous);
            listGroup1.AddItem(pengyous);
            listGroup1.AddItem(pengyous);



            lrcPanel.ClickLrcEvent += new EventHandler(changePostion);


            volume1.VolumeChange += new Volume.VolumeChanged(sizeChange);
            Set_volume(50);







            lrcPanel.Dock = DockStyle.Fill;
            lrcPanel.BackColor = Color.Transparent;

            LrcView.Controls.Add(lrcPanel);

            axWindowsMediaPlayer1.uiMode = "None";
            FormFade.FadeIn(this, 1);
            down.Path = audioPath;
            Play_Listen = new System.Threading.Timer(Play_Listen_event, null, 0, 1);

            LrcView.Visible = false;
            LrcView.AutoScroll = true;

            SearchModel();
            Songerimg.Image = null;
            txt_Songname.Text = "抖音";
            try
            {
                //      button1_Click(null, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                this.Close();
            }

        }

        private void changePostion(object sender, EventArgs e)
        {
            this.axWindowsMediaPlayer1.Ctlcontrols.currentPosition = (lrcPanel.MouseOnLrc.PostionDouble / 1000);
        }

        private void SearchModel()
        {
            Songerimg.Image = Image.FromFile(@"System\Hover\down.png");
            Color df = Color.FromArgb(20, 155, 118);
            model = "SearchModel";
            Search_view.Visible = true;

            LrcView.Visible = false;
            Search_view.Width = panelRight.Width;
            Search_view.Anchor = (AnchorStyles)(AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom);
            top.BackgroundImage = null;
            bot.BackgroundImage = null;
            top.BackColor = df;
            bot.BackColor = df;
            Search_view.BackColor = Color.FromArgb(75, 196, 162);
            blue.BackColor = Color.FromArgb(114, 246, 236);
            gray.BackColor = Color.FromArgb(128, 163, 202);
            Songlist.BackColor = Color.FromArgb(255, 255, 255);
            playMode = ModePlay.search;
        }
        public void Set_volume(int size)
        {
            if (size < 1)
            {
                pictureBox1.Image = Image.FromFile(@"System\Static\none.png");
            }
            if (size >= 1 && size <= 60)
            {
                pictureBox1.Image = Image.FromFile(@"System\Static\min.png");
            }
            if (size > 60)
            {
                pictureBox1.Image = Image.FromFile(@"System\Static\big.png");
            }
            axWindowsMediaPlayer1.settings.volume = size;
        }
        private void Search(string songname)
        {
            Songs = new List<Song>();
            Songs = h.GetList(h.getJsonText(k.list(songname.Trim())));

            LabelLayout(Songs);
        }

        public void Play(Song s)
        {
            playnow = s;
            string tmppath = audioPath + s.Filename + "." + s.Extname;
            if (File.Exists(tmppath))
            {
                axWindowsMediaPlayer1.URL = tmppath;
            }
            else
            {
                h.GetSong(s.Hash, s);//获取播放信息
                axWindowsMediaPlayer1.URL = s.play_url;//播放

                LoadLrc(s);
                changeImg(s);
            }

            if (s.MvHash == "")
            {
                LrcModel();

            };
        }

        private void LoadLrc(Song s)
        {
            string lrcFileName = lrcPath + s.Filename + ".lrc";



            //本地文件查找歌词
            if (File.Exists(lrcFileName))
            {
                lrcPanel.LoadLrc(lrcFileName);
                return;
            }

            //从歌曲对象信息里面获取歌词
            if (s.lyrics != null)
            {
                string content = s.lyrics;
                StreamWriter sw = new StreamWriter(lrcFileName, false, Encoding.UTF8);
                sw.Write(content);
                sw.Close();
                lrcPanel.LoadLrc(lrcFileName);



                return;

            }

            //联网查找歌词信息
            try
            {
                Lrc l = new Lrc();
                l = h.getLrc(h.getJsonText(k.getLrcLst(s.songname, s.Duration)));
                string content = h.Getcontent(h.getJsonText(k.getLrcText(l.Id, l.Accesskey)));
                content = content.Replace("\\", "");
                string orgStr = Encoding.UTF8.GetString(Convert.FromBase64String(content));
                StreamWriter sw = new StreamWriter(lrcPath + s.Filename + ".lrc", false, Encoding.UTF8);
                sw.Write(orgStr);
                sw.Close();
                lrcPanel.LoadLrc(lrcPath + s.Filename + ".lrc");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                lrcPanel.Clear();
            }
        }


        private void changeImg(Song s)
        {
            SetSingerBackground(null);
            SetSingerHead(null);


            string SingerBackground = SingerPath + "\\" + s.Singername + "_Photo.jpg";
            if (File.Exists(SingerBackground))
            {
                SetSingerBackground(Image.FromFile(SingerBackground));
            }
            else
            {
                List<string> photoList = h.GetSingerPhoto(s.Singername);
                if (photoList.Count > 0)
                {
                    downm = new DownLoadManage();
                    downm.DownLoad(photoList[0], SingerBackground, null, DownBackGroundDone);
                }
            }


            string PhotoPath = SingerPath + s.Singername + ".jpg";
            if (File.Exists(PhotoPath))
            {
                SetSingerHead(Image.FromFile(PhotoPath));
            }
            else
            {
                downm = new DownLoadManage();
                string url = h.getUrl(h.getJsonText(k.getimg(s.Singername)));
                downm.DownLoad(url, PhotoPath, null, DownSingerHeadDone);
            }
        }

        private void DownBackGroundDone(DownLoadManage sender)
        {

            Console.WriteLine(sender.state);
            if (sender.state == "Success")
            {
                SetSingerBackground(Image.FromFile(sender.fileName));
            }
            else
            {
                SetSingerBackground(null);
            }
        }

        private void DownSingerHeadDone(DownLoadManage sender)
        {
            if (sender.state == "Success")
            {
                SetSingerHead(Image.FromFile(sender.fileName));
            }
            else
            {
                SetSingerHead(DefaultSonger);
            }
        }



        private void SetSingerBackground(Image img)
        {
            if (img != null)
            {
                this.BackgroundImage = zoom.ZoomProportional(this.Size, img);

            }
            else
            {
                this.BackgroundImage = img;
            }

            //高斯处理
            //   this.BackgroundImage = gs.ProcessImage(img as Bitmap);

        }

        private void SetSingerHead(Image img)
        {
            Songerimg.BackgroundImage = img;
        }


        private string CastToFen(string Duration)
        {
            int miao = Convert.ToInt32(Duration);
            string fen = miao / 60 + "";
            string miaox = miao % 60 + "";
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
        private void LabelLayout(List<Song> LstSong)
        {
            if (LstSong.Count < 1)
            {
                this.Songlist.FlowLayoutPanel.Controls.Clear();
                Label label = new Label();
                label.Location = new Point(0, 0);
                label.Text = " 没有找到相关歌曲";
                label.ForeColor = itemColor;
                label.FlatStyle = FlatStyle.Flat;
                label.AutoSize = false;
                label.Size = new Size(Songlist.Width - 20, 31);
                label.TextAlign = ContentAlignment.MiddleCenter;
                this.Songlist.FlowLayoutPanel.Controls.Add(label);
                return;
            }
            this.Songlist.FlowLayoutPanel.Controls.Clear();
            foreach (Song song in LstSong)
            {
                ItemSong item = new ItemSong(song.Filename, CastToFen(song.DurationStr), song.MvHash);
                item.Size = new Size(Songlist.Width - 20, 31);
                //item.BackColor = Color.Beige;
                item.DoubleClick += new EventHandler(this.ItemSongDoublick);
                item.MvIconClick += new ItemSong.Callback(MvIconClick);
                item.Tag = song;
                item.ContextMenuStrip = Menu;
                item.MouseLeave += new EventHandler(this.label1_MouseLeave);
                item.MouseEnter += new EventHandler(this.label1_MouseHover);
                Songlist.FlowLayoutPanel.Controls.Add(item);
            }
            Songlist.Refresh();
        }



        private void MvIconClick(object data)
        {

            Song s = data as Song;
            Dictionary<string, string> list = h.GetMvList(h.getJsonText(k.ReplaceMVUrl(s.MvHash)));
            string type = "rq";
            try
            {
                type = list["le"];
            }
            catch (Exception)
            {

            }

            try
            {
                type = list["sq"];
            }
            catch (Exception)
            {

            }

            try
            {
                type = list["rq"];
            }
            catch (Exception)
            {

            }



            Play(s);

            axWindowsMediaPlayer1.URL = type.Replace("\\", "").Replace("\"", "");

            MVmode();
        }





        private void ItemSongDoublick(object sender, EventArgs e)
        {
            //Console.WriteLine((Song)((ItemSong)sender).Tag);
            Play((Song)((ItemSong)sender).Tag);
        }
        private void label1_MouseHover(object sender, EventArgs e)
        {
            ItemSong label = (ItemSong)sender;
            Song a = new Song();
            a = (Song)label.Tag;

            selectnow = a;
            toast.SetToolTip(label, "歌曲名称: " + a.Filename + "\n歌手: " + a.Singername + "\n时长: " + CastToFen(a.DurationStr));
            label.BackgroundImage = Image.FromFile("System\\Static\\long.png");
        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            ItemSong label = (ItemSong)sender;

            Song s = (Song)label.Tag;

            if (selectnow != null)
            {
                //if (!s.Hash.Equals(selectnow.Hash))
                //{

                //}
            }
            label.BackgroundImage = null;


        }
        int i = 0;
        private void Play_Listen_event(object sender)
        {

            i++;

            lrcPanel.ChangePostion((this.axWindowsMediaPlayer1.Ctlcontrols.currentPosition));

            label10.Text = i + "";

            if (this.music.State(ref this.axWindowsMediaPlayer1).Equals("stop"))
            {
                this.Next();
            }
            if (this.music.State(ref axWindowsMediaPlayer1).Equals("pause") && this.tag == 1)
            {
                this.btn_play.Image = play_hover;
            }
            if (this.music.State(ref axWindowsMediaPlayer1).Equals("pause") && this.tag == 0)
            {
                this.btn_play.Image = play_static;
            }
            if (this.music.State(ref axWindowsMediaPlayer1).Equals("play") && this.tag == 1)
            {
                this.btn_play.Image = pause_hover;
            }
            if (this.music.State(ref axWindowsMediaPlayer1).Equals("play") && this.tag == 0)
            {
                this.btn_play.Image = pause_static;
            }


            if (this.music.State(ref this.axWindowsMediaPlayer1).Equals("play") || this.music.State(ref this.axWindowsMediaPlayer1).Equals("pause"))
            {

                int num = (int)this.music.Length(ref this.axWindowsMediaPlayer1);
                int num2 = (int)this.music.now(ref this.axWindowsMediaPlayer1);
                this.blue.Width = (int)((double)(this.gray.Width * num2) * 1.0 / (double)num);
                this.label3.Text = this.axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                this.label4.Text = "/ " + this.axWindowsMediaPlayer1.currentMedia.durationString;
                label10.Text = playnow.Filename;
            }
        }
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {


            if (this.music.State(ref this.axWindowsMediaPlayer1).Equals("pause") || this.music.State(ref this.axWindowsMediaPlayer1).Equals("play"))
            {
                this.axWindowsMediaPlayer1.Ctlcontrols.currentPosition = this.music.Length(ref this.axWindowsMediaPlayer1) / (double)this.gray.Width * (double)e.X;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.music.State(ref this.axWindowsMediaPlayer1).Equals("stop") || this.music.State(ref this.axWindowsMediaPlayer1).Equals("ready") || this.music.State(ref this.axWindowsMediaPlayer1).Equals("未知"))
            {

                if (Songs.Count > 0)
                {
                    Play(Songs[0]);
                }
                else
                {
                    MessageBox.Show("没有可播放的歌曲!");
                }

            }
            else
            {
                this.Up();
            }

        }
        private void Up()
        {
            bool exist = false;
            for (int i = 0; i < this.Songs.Count; i++)
            {

                if (Songs[i].Hash.Equals(playnow.Hash))
                {
                    exist = true;
                    if (i == 0)
                    {



                        Play(Songs[this.Songs.Count - 1]);
                    }

                    else
                    {
                        Play(Songs[i - 1]);
                    }



                    break;
                }
            }
            if (!exist)
            {

                if (Songs.Count > 0)
                {
                    Play(Songs[0]);
                }
                else
                {
                    MessageBox.Show("没有可播放的歌曲!");
                }
            }

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.music.State(ref this.axWindowsMediaPlayer1).Equals("stop") || this.music.State(ref this.axWindowsMediaPlayer1).Equals("ready") || this.music.State(ref this.axWindowsMediaPlayer1).Equals("未知"))
            {

                if (Songs.Count > 0)
                {
                    Play(Songs[0]);
                }
                else
                {
                    MessageBox.Show("没有可播放的歌曲!");
                }
            }
            else
            {
                this.Next();
            }



        }
        private void Next()
        {
            bool exist = false;
            for (int i = 0; i < this.Songs.Count; i++)
            {
                string value = this.Songs[i].Hash.Trim();
                if (playnow.Hash.Equals(value))
                {
                    exist = true;
                    if (i + 1 >= this.Songs.Count)
                    {

                        Play(Songs[0]);
                    }

                    else
                    {


                        Play(Songs[i + 1]);
                    }

                    break;
                }
            }
            if (!exist)
            {
                if (Songs.Count > 0)
                {
                    Play(Songs[0]);
                }
                else
                {
                    MessageBox.Show("没有可播放的歌曲!");
                }

            }

        }
        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            this.btn_next.Image = Image.FromFile("System\\Hover\\next.png");
        }
        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            this.btn_next.Image = Image.FromFile("System\\Static\\next.png");
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.btn_up.Image = Image.FromFile("System\\Hover\\up.png");
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.btn_up.Image = Image.FromFile("System\\Static\\up.png");
        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.tag = 1;
        }
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.tag = 0;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.music.State(ref this.axWindowsMediaPlayer1).Equals("stop") || this.music.State(ref this.axWindowsMediaPlayer1).Equals("ready") || this.music.State(ref this.axWindowsMediaPlayer1).Equals("未知"))
            {

                if (Songs.Count > 0)
                {
                    Play(Songs[0]);
                }
                else
                {
                    MessageBox.Show("没有可播放的歌曲!");
                }


            }
            else if (this.music.State(ref this.axWindowsMediaPlayer1).Equals("pause"))
            {
                this.axWindowsMediaPlayer1.Ctlcontrols.play();

            }
            else
            {
                this.axWindowsMediaPlayer1.Ctlcontrols.pause();

            }

        }
        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {

            MainWindow.ReleaseCapture();
            MainWindow.SendMessage(base.Handle, 274, 61458, 0);

        }

        private void Closes_Click(object sender, EventArgs e)
        {

            FormFade.FadeOut(this, 1);
            FormFade.FadeDone += close;
        }

        private void close()
        {
            this.Close();
        }

        private void small_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }
        private void pictureBox4_MouseEnter_1(object sender, EventArgs e)
        {
            if (!model.Equals("LrcModel"))
            {
                Songerimg.Image = Image.FromFile(@"System\Hover\down.png");
            }
            else
            {
                Songerimg.Image = Image.FromFile(@"System\Hover\Open.png");
            }

        }
        private void pictureBox4_MouseLeave_1(object sender, EventArgs e)
        {
            Songerimg.Image = null;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (model.Equals("SearchModel"))
            {

                if (playMode == ModePlay.mv)
                {
                    MVmode();
                }
                else
                {
                    LrcModel();
                }



            }
            else if (model.Equals("LrcModel"))
            {


                SearchModel();

            }




        }
        public enum ModePlay
        {
            search,
            lrc,
            mv
        }
        private void MVmode()
        {
            LrcModel();
            lrcPanel.Hide();
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
            axWindowsMediaPlayer1.Visible = true;
            LrcView.Controls.Add(axWindowsMediaPlayer1);
            playMode = ModePlay.mv;
        }
        private void LrcModel()
        {

            Songerimg.Image = Image.FromFile(@"System\Hover\Open.png");
            model = "LrcModel";
            Search_view.Visible = false;
            LrcView.Visible = true;
            LrcView.BackColor = Color.Transparent;
            Image backimg = null;
            if (File.Exists(@"System\Static\backimgx.png"))
            {
                backimg = System.Drawing.Image.FromFile(@"System\Static\backimgx.png");
            }
            top.BackgroundImage = backimg;
            bot.BackgroundImage = backimg;
            top.BackColor = Color.Transparent;
            bot.BackColor = Color.Transparent;

            LrcView.Anchor = (AnchorStyles)(AnchorStyles.Top | AnchorStyles.Bottom);
            LrcView.Width = panelRight.Width;
            LrcView.Location = new Point(0, LrcView.Location.Y);

            LrcView.BackgroundImage = backimg;
            lrcPanel.Visible = true;
            axWindowsMediaPlayer1.Visible = false;
            playMode = ModePlay.lrc;

        }


        private void label10_TextChanged(object sender, EventArgs e)
        {

            //lrcPanel.ChangePostion((int)this.axWindowsMediaPlayer1.Ctlcontrols.currentPosition);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            string key = e.KeyCode.ToString();

            if (key.Equals("Space") && music.State(ref axWindowsMediaPlayer1).Equals("play"))
            {
                music.pause(ref axWindowsMediaPlayer1);
            }
            else if (key.Equals("Space"))
            {
                music.play(ref axWindowsMediaPlayer1);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Search(txt_Songname.Text.Trim());
            Songlist.Refresh();

        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }
        private void Closes_MouseEnter(object sender, EventArgs e)
        {
            Closes.BackColor = Color.Red;
        }
        private void Closes_MouseLeave(object sender, EventArgs e)
        {
            Closes.BackColor = Color.Transparent;
        }
        private void small_MouseEnter(object sender, EventArgs e)
        {
            small.BackColor = Color.Red;
        }
        private void small_MouseLeave(object sender, EventArgs e)
        {
            small.BackColor = Color.Transparent;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Down_Click(object sender, EventArgs e)
        {
            ItemSong l = Menu.SourceControl as ItemSong;
            Song s = new Song();
            //s = (Song)l.Tag;

            //if (File.Exists(audioPath + s.Filename + "." + s.Extname))
            //{
            //    MessageBox.Show("已存在的歌曲，点击查看。");
            //    System.Diagnostics.Process.Start("Explorer.exe", Application.StartupPath + "\\Songs\\Audio");
            //    return;

            //}

            //string url = k.getinfo(s.Hash);
            //string JsonText = h.getJsonText(url);
            //string src = h.getUrl(JsonText);
            //if (src != null)
            //{

            //    down.main = this;
            //    down.s = s;
            //    //down.px = DownManager;
            //    l.ForeColor = Color.Gray;

            //    if (File.Exists(audioPath + s.Filename + "." + s.Extname))
            //    {
            //        MessageBox.Show("已存在的歌曲，点击查看。");

            //        System.Diagnostics.Process.Start("Explorer.exe", Application.StartupPath + "\\Songs\\Audio");
            //        // down.Hide();
            //    }
            //    else
            //    {

            //        down.add(s);
            //        //    down.Show();


            //    }

            //}
            //else
            //{
            //    MessageBox.Show("该歌曲收到限制！");
            //}
        }

        private void btn_find_MouseEnter(object sender, EventArgs e)
        {
            search_back.BackgroundImage = Image.FromFile(@"System\Hover\search.png");
        }

        private void btn_find_MouseLeave(object sender, EventArgs e)
        {
            search_back.BackgroundImage = Image.FromFile(@"System\Static\search.png");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            MessageBox.Show("功能还没做!");
            return;
            if (down.Visible)
            {
                down.Hide();
            }
            else
            {
                down.Show();
            }
        }
        private void closeYl()
        {
            if (yl.Enabled)
            {
                //yl.Close();
            }
        }
        private void pictureBox1_MouseEnter_1(object sender, EventArgs e)
        {



            //yl.Location = new System.Drawing.Point(MousePosition.X, MousePosition.Y - yl.Height);

        }

        private void sizeChange(int size)
        {
            Set_volume(size);
        }

        private void top_MouseEnter(object sender, EventArgs e)
        {
            closeYl();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (playnow == null)
            {
                MessageBox.Show("无法下载当前播放歌曲,\n因为当前没有播放音乐!");
                return;
            }

            //down.main = this;
            down.s = playnow;
            //down.px = DownManager;


            if (File.Exists(audioPath + playnow.Filename + "." + playnow.Extname))
            {
                MessageBox.Show("已存在的歌曲!");
                return;
                // down.Hide();
            }
            else
            {
                down.add(playnow);



            }
        }
        Label l1 = new Label();


        int point = 20;
        int sudu = 100;

        private void lrc_Tick(object sender, EventArgs e)
        {
            sudu++;
            if (sudu > 40)
            {
                sudu = 0;
                lrc.Stop();
            }
            point += 2;
            LrcView.VerticalScroll.Value = point;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void axWindowsMediaPlayer1_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e)
        {
            //Console.WriteLine(e.newPosition);
        }

        private void axWindowsMediaPlayer1_CurrentPlaylistChange(object sender, AxWMPLib._WMPOCXEvents_CurrentPlaylistChangeEvent e)
        {
            Console.WriteLine(0);
        }

        private void top_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
