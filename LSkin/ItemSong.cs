using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LSkin
{
    public partial class ItemSong : UserControl
    {

        public delegate void Callback(object data);
        public event Callback MvIconClick;

        public ItemSong(string songname, string time, string mv)
        {
            InitializeComponent();
            this.songname.ForeColor = Color.FromArgb(58, 65, 74);
            this.songname.Text = songname;
            this.time.Text = time;
            this.MV.Visible = mv == "" ? false : true;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        private void MV_Click(object sender, EventArgs e)
        {
           
            if (MvIconClick != null) MvIconClick(this.Tag);
        }

  
        private void songname_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            base.OnDoubleClick(e);
        }

        private void songname_MouseEnter(object sender, EventArgs e)
        {
            base.OnMouseEnter(e);
        }

        private void songname_MouseLeave(object sender, EventArgs e)
        {
            base.OnMouseLeave(e);

        }

        private void songname_MouseHover(object sender, EventArgs e)
        {
            base.OnMouseHover(e);
        }
    }
}
