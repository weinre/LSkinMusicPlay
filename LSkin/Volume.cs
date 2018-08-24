using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSkin
{
    public partial class Volume : UserControl
    {
        public Volume()
        {
            InitializeComponent();
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

        public int Voulme
        {
            get
            {
                return voulme;
            }
            set
            {
                voulme = value;
            }
        }

        public delegate void VolumeChanged(int size);
        public event VolumeChanged VolumeChange;

        private int voulme;
        private void gray_MouseDown(object sender, MouseEventArgs e)
        {
            gray.Height = e.Y;
            Voulme = 100 - e.Y;
            //触发事件
            changeSize();
        }
        private void YL_Load(object sender, EventArgs e)
        {
            label1.Text = Voulme + "%";
            gray.Height = 100 - Voulme;
            this.MouseWheel += new MouseEventHandler(mousewheel);
        }
        private void mousewheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                Voulme += 2;
            }
            else
            {
                Voulme -= 2;
            }
            if (Voulme > 100) Voulme = 100;
            if (Voulme < 0) Voulme = 0;
            gray.Height = 100 - Voulme;
            changeSize();

        }

        private void changeSize()
        {
            label1.Text = Voulme + "%";
            if (VolumeChange != null) VolumeChange(Voulme);
        }
    }
}
