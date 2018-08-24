using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListGroup
{
    public partial class UserItem : UserControl
    {
        public object Clone()
        {
            return this.MemberwiseClone();

        }

        /// <param name="headImg">头像图片</param>
        /// <param name="title">标题|昵称</param>
        /// <param name="textShow">文字说明</param>
        public Color backgroundColor;
        public Color titleColor;
        public Color showTextColor;

        /// <summary>
        /// 初始化item
        /// </summary>
        /// <param name="headImg"></param>
        /// <param name="title"></param>
        /// <param name="textShow"></param>
        public UserItem(Image headImg, string title)
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
            backgroundColor = this.BackColor;
            titleColor = this.title.BackColor;

            this.DoubleBuffered = true;
            this.pictureBox1.Image = headImg;
            this.title.Text = title;
        }

        public UserItem()
        {
            InitializeComponent();
      
        }

        public delegate void InputDone(string str);



    }
}
