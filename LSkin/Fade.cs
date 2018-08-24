using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LSkin
{
    public static class FormFade
    {
        public delegate void CallBack();
        static public event CallBack FadeDone;
        static private Form form;
        static Timer fadeTimer;
        public static void FadeIn(Form winform, int ms)
        {
            form = winform;
            form.Opacity = 0;
            fadeTimer = new Timer();
            fadeTimer.Interval = ms;
            fadeTimer.Tick += new EventHandler(FadeInTick);
            fadeTimer.Start();
        }

        public static void FadeOut(Form winform, int ms)
        {
            form = winform;
            form.Opacity = 1;
            fadeTimer = new Timer();
            fadeTimer.Interval = ms;
            fadeTimer.Tick += new EventHandler(FadeOutTick);
            fadeTimer.Start();
        }

        private static void FadeInTick(object sender, EventArgs e)
        {
            form.Opacity += 0.1;
            if (form.Opacity == 1)
            {
                fadeTimer.Stop();
                if (FadeDone != null) FadeDone();
                return;
            }
        }
        private static void FadeOutTick(object sender, EventArgs e)
        {
            form.Opacity -= 0.1;
            if (form.Opacity == 0)
            {
                fadeTimer.Stop();
                if (FadeDone != null) FadeDone();
                return;
            }
        }

    }




    public static class ToolTime
    {
        public delegate void CallBack();
        public static event CallBack FadeDone;
        static Timer fadeTimer;

        public static void TimeOut(int ms)
        {
            fadeTimer = new Timer();
            fadeTimer.Interval = ms;
            fadeTimer.Tick += new EventHandler(FadeToMinTick);
            fadeTimer.Start();
        }

        private static void FadeToMinTick(object sender, EventArgs e)
        {
            if (FadeDone != null) FadeDone();
        }
    }

}
