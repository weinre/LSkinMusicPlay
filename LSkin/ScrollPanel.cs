﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LSkin
{
    public partial class ScrollPanel : UserControl
    {
        public ScrollPanel()
        {
            InitializeComponent();
            //if (FlowLayoutPanel.VerticalScroll.Visible)
            //{
            //    FlowLayoutPanel.Width = this.panel1.Width + 20;
            //}
            //else
            //{
            //    FlowLayoutPanel.Width = this.panel1.Width+5;
            //}
            FlowLayoutPanel.Anchor = (AnchorStyles)(AnchorStyles.Right| AnchorStyles.Left| AnchorStyles.Top| AnchorStyles.Bottom);
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
        private void ScrollPanel_Paint(object sender, PaintEventArgs e)
        {
            //if (FlowLayoutPanel.VerticalScroll.Visible)
            //{
            //    FlowLayoutPanel.Width = this.panel1.Width + 20;
            //}
            //else
            //{
            //    FlowLayoutPanel.Width = this.panel1.Width+5;
            //}

            //FlowLayoutPanel.Width = this.panel1.Width + 5;

            FlowLayoutPanel.Anchor = (AnchorStyles)(AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom);
        }

        int pointY = 0;
        private void FlowLayoutPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            Control ct = e.Control;
            ct.Location = new Point(0,pointY);
            pointY += ct.Height;
            Console.WriteLine("添加");

        }

        private void FlowLayoutPanel_ControlRemoved(object sender, ControlEventArgs e)
        {

            pointY -= e.Control.Height;
            Console.WriteLine("删除");

            if (this.Controls.Count <=0) pointY = 0;

        }
    }
}
