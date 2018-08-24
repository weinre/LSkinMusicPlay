using AxWMPLib;
using System;
using System.Collections.Generic;
using System.IO;
using WMPLib;

namespace Test
{
    internal class Music
    {
        public string State(ref AxWindowsMediaPlayer Player)
        {
            string result = "";
            try
            {
                if (Player.playState == WMPPlayState.wmppsPlaying)
                {  
                    result = "play";
                }
                else if (Player.playState == WMPPlayState.wmppsBuffering)
                {
                    result = "load";
                }
                else if (Player.playState == WMPPlayState.wmppsReady)
                {
                    result = "ready";
                }
                else if (Player.playState == WMPPlayState.wmppsPaused)
                {
                    result = "pause";
                }
                else if (Player.playState == WMPPlayState.wmppsStopped)
                {
                    result = "stop";
                }
                else
                {
                    result = "未知";
                }
            }
            catch (Exception)
            {

            }

            return result;
        }

        public void play(ref AxWindowsMediaPlayer Player)
        {
            Player.Ctlcontrols.play();
        }

        public void pause(ref AxWindowsMediaPlayer Player)
        {
            Player.Ctlcontrols.pause();
        }

        public void stop(ref AxWindowsMediaPlayer Player)
        {
            Player.Ctlcontrols.stop();
        }

        public double now(ref AxWindowsMediaPlayer Player)
        {
            return Player.Ctlcontrols.currentPosition;
        }

        public double Length(ref AxWindowsMediaPlayer Player)
        {
            return Player.currentMedia.duration;
        }


    }
}
