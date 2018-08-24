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
            axPlayer.OnDownloadCodec += new AxAPlayer3Lib._IPlayerEvents_OnDownloadCodecEventHandler(OnDownloadCodecEvent);
        }

        private void OnDownloadCodecEvent(object sender, _IPlayerEvents_OnDownloadCodecEvent e)
        {
            throw new NotImplementedException("缺少解码器:" + e.strCodecPath);
        }

        public void Open(string url)
        {
            axPlayer.Open(url);
        }

        public void Play()
        {
            axPlayer.Play();
        }

        public void Pause()
        {

            axPlayer.Pause();
        }

        public int Volume
        {
            get
            {
                return axPlayer.GetVolume();
            }
            set
            {
                axPlayer.SetVolume(value);
            }
        }
    }
}
