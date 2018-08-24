namespace LSkin
{
    partial class ScrollPanel
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.scrollBar1 = new LSkin.ScrollBar();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.FlowLayoutPanel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 321);
            this.panel1.TabIndex = 1;
            // 
            // FlowLayoutPanel
            // 
            this.FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanel.Name = "FlowLayoutPanel";
            this.FlowLayoutPanel.Size = new System.Drawing.Size(477, 321);
            this.FlowLayoutPanel.TabIndex = 0;
            // 
            // scrollBar1
            // 
            this.scrollBar1.Active = true;
            this.scrollBar1.ActiveColor = System.Drawing.SystemColors.ControlDarkDark;
            this.scrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrollBar1.BackColor = System.Drawing.SystemColors.Control;
            this.scrollBar1.HoverColor = System.Drawing.SystemColors.ControlDark;
            this.scrollBar1.Location = new System.Drawing.Point(482, 0);
            this.scrollBar1.MinSlideBarLenght = 30;
            this.scrollBar1.Name = "scrollBar1";
            this.scrollBar1.NeedSleep = false;
            this.scrollBar1.NormalColor = System.Drawing.SystemColors.ButtonShadow;
            this.scrollBar1.RelaPanel = this.FlowLayoutPanel;
            this.scrollBar1.Size = new System.Drawing.Size(10, 321);
            this.scrollBar1.TabIndex = 2;
            // 
            // ScrollPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scrollBar1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "ScrollPanel";
            this.Size = new System.Drawing.Size(493, 321);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ScrollPanel_Paint);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ScrollBar scrollBar1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel;
    }
}
