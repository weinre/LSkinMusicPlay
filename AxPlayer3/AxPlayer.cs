using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AxAPlayer3Lib;

namespace AxPlayer3
{
    public partial class AxPlayer : UserControl
    {


        public AxPlayer()
        {
            InitializeComponent();
            axPlayer1.Dock = DockStyle.Fill;

            axPlayer1.OnDownloadCodec += new AxAPlayer3Lib._IPlayerEvents_OnDownloadCodecEventHandler(OnDownloadCodecEvent);
        }

        private void OnDownloadCodecEvent(object sender, _IPlayerEvents_OnDownloadCodecEvent e)
        {
            Console.WriteLine(e.strCodecPath);
            throw new NotImplementedException("缺少解码器:" + e.strCodecPath);
        }

        public void Open(string url)
        {
            axPlayer1.Open(url);
        }


        public void Play()
        {
            axPlayer1.Play();
        }

        public void Pause()
        {
            axPlayer1.Pause();
        }


        /// <summary>
        /// 播放音量 0-1000
        /// </summary>
        public int Volume
        {
            get
            {
                return axPlayer1.GetVolume();
            }
            set
            {
                axPlayer1.SetVolume(value);
            }
        }

        /// <summary>
        /// 视频&音乐总长度 ms
        /// </summary>
        public int Duration
        {
            get
            {
                return axPlayer1.GetDuration();
            }
            set
            {
                axPlayer1.SetPosition(value);
            }
        }
        /// <summary>
        /// 当前播放进度 ms
        /// </summary>
        public int Position
        {
            get
            {
                return axPlayer1.GetPosition();
            }
            set
            {
                axPlayer1.SetPosition(value);
            }
        }

        /// <summary>
        /// 获取进度string [00:00]
        /// </summary>
        public string PositionString
        {
            get
            {
                return CastToFen((int)(Position / 1000) + "");

            }
        }

        /// <summary>
        /// 获取播放进度string [00:00]
        /// </summary>
        public string DurationString
        {
            get
            {
                return CastToFen((int)(Duration / 1000) + "");
            }
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

        public enum PLAY_STATE
        {
            PS_READY = 0,  // 准备就绪
            PS_OPENING = 1,  // 正在打开
            PS_PAUSING = 2,  // 正在暂停
            PS_PAUSED = 3,  // 暂停中
            PS_PLAYING = 4,  // 正在开始播放
            PS_PLAY = 5,  // 播放中
            PS_CLOSING = 6,  // 正在开始关闭
        };


        public PLAY_STATE State
        {
            get
            {
                return (PLAY_STATE)axPlayer1.GetState();
            }
        }


    }
}
