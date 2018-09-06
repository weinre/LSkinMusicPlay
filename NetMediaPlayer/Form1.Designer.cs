namespace loveTest
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开本地视频ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.网络地址ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.全屏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出全屏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开视频ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.本地视频ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.网络地址ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改房间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.全屏ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.取消全屏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.axPlayer1 = new AxPlayer3.AxPlayer();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.设置ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开本地视频ToolStripMenuItem,
            this.网络地址ToolStripMenuItem1});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开本地视频ToolStripMenuItem
            // 
            this.打开本地视频ToolStripMenuItem.Name = "打开本地视频ToolStripMenuItem";
            this.打开本地视频ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.打开本地视频ToolStripMenuItem.Text = "打开本地视频";
            this.打开本地视频ToolStripMenuItem.Click += new System.EventHandler(this.打开本地视频ToolStripMenuItem_Click);
            // 
            // 网络地址ToolStripMenuItem1
            // 
            this.网络地址ToolStripMenuItem1.Name = "网络地址ToolStripMenuItem1";
            this.网络地址ToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.网络地址ToolStripMenuItem1.Text = "网络地址";
            // 
            // 设置ToolStripMenuItem1
            // 
            this.设置ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全屏ToolStripMenuItem,
            this.退出全屏ToolStripMenuItem});
            this.设置ToolStripMenuItem1.Name = "设置ToolStripMenuItem1";
            this.设置ToolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem1.Text = "设置";
            // 
            // 全屏ToolStripMenuItem
            // 
            this.全屏ToolStripMenuItem.Name = "全屏ToolStripMenuItem";
            this.全屏ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.全屏ToolStripMenuItem.Text = "全屏";
            this.全屏ToolStripMenuItem.Click += new System.EventHandler(this.全屏ToolStripMenuItem_Click);
            // 
            // 退出全屏ToolStripMenuItem
            // 
            this.退出全屏ToolStripMenuItem.Name = "退出全屏ToolStripMenuItem";
            this.退出全屏ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出全屏ToolStripMenuItem.Text = "退出全屏";
            this.退出全屏ToolStripMenuItem.Click += new System.EventHandler(this.退出全屏ToolStripMenuItem_Click);
            // 
            // 打开视频ToolStripMenuItem
            // 
            this.打开视频ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.本地视频ToolStripMenuItem,
            this.网络地址ToolStripMenuItem});
            this.打开视频ToolStripMenuItem.Name = "打开视频ToolStripMenuItem";
            this.打开视频ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.打开视频ToolStripMenuItem.Text = "打开视频";
            // 
            // 本地视频ToolStripMenuItem
            // 
            this.本地视频ToolStripMenuItem.Name = "本地视频ToolStripMenuItem";
            this.本地视频ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            // 
            // 网络地址ToolStripMenuItem
            // 
            this.网络地址ToolStripMenuItem.Name = "网络地址ToolStripMenuItem";
            this.网络地址ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.网络地址ToolStripMenuItem.Text = "网络地址";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更改房间ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 更改房间ToolStripMenuItem
            // 
            this.更改房间ToolStripMenuItem.Name = "更改房间ToolStripMenuItem";
            this.更改房间ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.更改房间ToolStripMenuItem.Text = "更改房间";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全屏ToolStripMenuItem1,
            this.退出ToolStripMenuItem,
            this.rToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            // 
            // 全屏ToolStripMenuItem1
            // 
            this.全屏ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.取消全屏ToolStripMenuItem});
            this.全屏ToolStripMenuItem1.Name = "全屏ToolStripMenuItem1";
            this.全屏ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.全屏ToolStripMenuItem1.Text = "全屏";
            this.全屏ToolStripMenuItem1.Click += new System.EventHandler(this.全屏ToolStripMenuItem1_Click);
            // 
            // 取消全屏ToolStripMenuItem
            // 
            this.取消全屏ToolStripMenuItem.Name = "取消全屏ToolStripMenuItem";
            this.取消全屏ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.取消全屏ToolStripMenuItem.Text = "取消全屏";
            this.取消全屏ToolStripMenuItem.Click += new System.EventHandler(this.取消全屏ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // rToolStripMenuItem
            // 
            this.rToolStripMenuItem.Name = "rToolStripMenuItem";
            this.rToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.rToolStripMenuItem.Text = "r";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(44, 323);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 48);
            this.panel3.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Image = global::NetWorkTest.Properties.Resources.音量;
            this.pictureBox2.Location = new System.Drawing.Point(753, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NetWorkTest.Properties.Resources.播放;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(691, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(63, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 10);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(34, 8);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // axPlayer1
            // 
            this.axPlayer1.Duration = 0;
            this.axPlayer1.Location = new System.Drawing.Point(128, 33);
            this.axPlayer1.Name = "axPlayer1";
            this.axPlayer1.Position = 0;
            this.axPlayer1.Size = new System.Drawing.Size(598, 253);
            this.axPlayer1.TabIndex = 7;
            this.axPlayer1.Volume = 80;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 406);
            this.Controls.Add(this.axPlayer1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel4_DragEnter);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.r);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打开视频ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更改房间ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 本地视频ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 网络地址ToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开本地视频ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 网络地址ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 全屏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出全屏ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 全屏ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 取消全屏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem;
        private AxPlayer3.AxPlayer axPlayer1;
    }
}

