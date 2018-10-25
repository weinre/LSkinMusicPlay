using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetWorkTest
{
    public partial class BottomControl : Form
    {

        public AxPlayer3.AxPlayer axPlayer1;
        public BottomControl()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            float postion = (axPlayer1.Position); //视频当前进度 /秒
            float duration = (axPlayer1.Duration);//视频总长度 /秒
            try
            {
                label1.Text = axPlayer1.PositionString;
                label2.Text = axPlayer1.DurationString;
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            float duration = axPlayer1.Duration;//视频总长度 /秒
            panel2.Width = e.Location.X;
            float totalW = panel1.Width;
            double num = duration / totalW * panel2.Width;
            axPlayer1.Position = Convert.ToInt32(num);
        }
    }
}
