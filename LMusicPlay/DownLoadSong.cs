using MusciPlay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlay
{
    public partial class DownSong : Form
    {
        public DownSong()
        {
            InitializeComponent();
        }
        //public MainWindow main;
        public Song s;
        //public PictureBox px;
        public String Path;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        private void DownLoadWindow_Load(object sender, EventArgs e)
        {

        }
        int x = 0;
        int y = 32;
        int width = 400;
        int heitht = 30;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();



        }
        int i = 0;
        public void add(Song s)
        {
            //仅显示7个已经下载歌曲
            if (i > 7)
            {
                i = 0;
                panel1.Controls.Clear();
            }
            //px.Visible = true;
            panel1.AutoScroll = false;

            Label l = new Label();
            l.Location = new Point(0, 0);
            l.Size = new System.Drawing.Size(width, heitht);
            l.Tag = s;
            l.TextAlign = ContentAlignment.MiddleLeft;
            l.ForeColor = Color.White;
            l.DoubleClick += new EventHandler(label_Clsick);
            l.Text = s.Filename;



            Panel p1 = new Panel();
            p1.BackColor = Color.FromArgb(119, 203, 63);
            p1.Location = new Point(x, i * y);
            p1.Size = new System.Drawing.Size(0, heitht);
            p1.Controls.Add(l);
            panel1.Controls.Add(p1);
            Panel p2 = new Panel();
            p2.BackColor = Color.White;
            p2.Location = new Point(x, i * y);
            p2.Size = new System.Drawing.Size(width, heitht);



            Label bfb = new Label();
            bfb.Location = new Point(width + 1, i * y);
            bfb.Size = new System.Drawing.Size(68, heitht);
            bfb.TextAlign = ContentAlignment.MiddleLeft;
            bfb.ForeColor = Color.White;
            bfb.BackColor = Color.Transparent;
            bfb.Text = "100%";
            panel1.Controls.Add(bfb);

            panel1.Controls.Add(p2);
            DownLoad d = new DownLoad();
            d.d = this;
            d.blue = p1;
            d.gray = p2;
            // d.btn = this.button2;
            d.s = s;

            kugou k = new kugou();
            http h = new http();
            String url = k.getinfo(s.Hash);
            String JsonText = h.getJsonText(url);
            String src = h.getUrl(JsonText);
            panel1.AutoScroll = true;
            //d.px = px;
            d.lb = bfb;
            d.Down(src, Path + s.Filename + "." + s.Extname);
            i++;
        }

        private void DownSong_MouseDown(object sender, MouseEventArgs e)
        {
            //MainWindow.ReleaseCapture();
            //MainWindow.SendMessage(base.Handle, 274, 61458, 0);
        }
        private void label_Clsick(object sender, EventArgs e)
        {

            Label l = (Label)sender;

            //main.Play((Song)l.Tag);
        }

    }
}
