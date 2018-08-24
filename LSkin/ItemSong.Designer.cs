namespace LSkin
{
    partial class ItemSong
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
            this.components = new System.ComponentModel.Container();
            this.songname = new System.Windows.Forms.Label();
            this.MV = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // songname
            // 
            this.songname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songname.BackColor = System.Drawing.Color.Transparent;
            this.songname.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.songname.Location = new System.Drawing.Point(0, 0);
            this.songname.Name = "songname";
            this.songname.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.songname.Size = new System.Drawing.Size(270, 31);
            this.songname.TabIndex = 0;
            this.songname.Text = "Name";
            this.songname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.songname.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.songname_MouseDoubleClick);
            this.songname.MouseEnter += new System.EventHandler(this.songname_MouseEnter);
            this.songname.MouseLeave += new System.EventHandler(this.songname_MouseLeave);
            this.songname.MouseHover += new System.EventHandler(this.songname_MouseHover);
            // 
            // MV
            // 
            this.MV.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MV.BackColor = System.Drawing.Color.Transparent;
            this.MV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MV.Image = global::LSkin.Properties.Resources.mvicon;
            this.MV.Location = new System.Drawing.Point(276, 0);
            this.MV.Name = "MV";
            this.MV.Size = new System.Drawing.Size(23, 31);
            this.MV.TabIndex = 1;
            this.MV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.MV, "观看MV");
            this.MV.Click += new System.EventHandler(this.MV_Click);
            this.MV.MouseEnter += new System.EventHandler(this.songname_MouseEnter);
            this.MV.MouseLeave += new System.EventHandler(this.songname_MouseLeave);
            // 
            // time
            // 
            this.time.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.Location = new System.Drawing.Point(305, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(56, 31);
            this.time.TabIndex = 2;
            this.time.Text = "00:00";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.time.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.songname_MouseDoubleClick);
            this.time.MouseEnter += new System.EventHandler(this.songname_MouseEnter);
            this.time.MouseLeave += new System.EventHandler(this.songname_MouseLeave);
            this.time.MouseHover += new System.EventHandler(this.songname_MouseHover);
            // 
            // ItemSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.time);
            this.Controls.Add(this.MV);
            this.Controls.Add(this.songname);
            this.DoubleBuffered = true;
            this.Name = "ItemSong";
            this.Size = new System.Drawing.Size(361, 31);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label songname;
        private System.Windows.Forms.Label MV;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
