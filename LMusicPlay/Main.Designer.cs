using ListGroup;

namespace MusicPlay
{
  
    partial class MainWindow
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Search_view = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.search_back = new System.Windows.Forms.Panel();
            this.btn_find = new System.Windows.Forms.PictureBox();
            this.txt_Songname = new System.Windows.Forms.TextBox();
            this.Songlist = new LSkin.ScrollPanel();
            this.LrcView = new System.Windows.Forms.Panel();
            this.DownManager = new System.Windows.Forms.PictureBox();
            this.toast = new System.Windows.Forms.ToolTip(this.components);
            this.small = new System.Windows.Forms.Label();
            this.Closes = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Down = new System.Windows.Forms.ToolStripMenuItem();
            this.lrc = new System.Windows.Forms.Timer(this.components);
            this.bot = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.volume1 = new LSkin.Volume();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Songerimg = new System.Windows.Forms.PictureBox();
            this.btn_play = new System.Windows.Forms.PictureBox();
            this.blue = new System.Windows.Forms.Panel();
            this.btn_up = new System.Windows.Forms.PictureBox();
            this.gray = new System.Windows.Forms.Panel();
            this.btn_next = new System.Windows.Forms.PictureBox();
            this.top = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.listGroup1 = new ListGroup.ListGroup();
            this.Search_view.SuspendLayout();
            this.panel2.SuspendLayout();
            this.search_back.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_find)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownManager)).BeginInit();
            this.Menu.SuspendLayout();
            this.bot.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Songerimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).BeginInit();
            this.top.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // Search_view
            // 
            this.Search_view.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Search_view.BackColor = System.Drawing.Color.DimGray;
            this.Search_view.Controls.Add(this.panel2);
            this.Search_view.Controls.Add(this.Songlist);
            this.Search_view.Location = new System.Drawing.Point(3, 3);
            this.Search_view.Name = "Search_view";
            this.Search_view.Size = new System.Drawing.Size(381, 495);
            this.Search_view.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.search_back);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 39);
            this.panel2.TabIndex = 9;
            // 
            // search_back
            // 
            this.search_back.BackColor = System.Drawing.Color.Transparent;
            this.search_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_back.BackgroundImage")));
            this.search_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search_back.Controls.Add(this.btn_find);
            this.search_back.Controls.Add(this.txt_Songname);
            this.search_back.Location = new System.Drawing.Point(3, 6);
            this.search_back.Name = "search_back";
            this.search_back.Size = new System.Drawing.Size(220, 25);
            this.search_back.TabIndex = 7;
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.Transparent;
            this.btn_find.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_find.Location = new System.Drawing.Point(195, 3);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(22, 20);
            this.btn_find.TabIndex = 2;
            this.btn_find.TabStop = false;
            this.btn_find.Click += new System.EventHandler(this.button1_Click);
            this.btn_find.MouseEnter += new System.EventHandler(this.btn_find_MouseEnter);
            this.btn_find.MouseLeave += new System.EventHandler(this.btn_find_MouseLeave);
            // 
            // txt_Songname
            // 
            this.txt_Songname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Songname.Location = new System.Drawing.Point(12, 5);
            this.txt_Songname.Name = "txt_Songname";
            this.txt_Songname.Size = new System.Drawing.Size(168, 14);
            this.txt_Songname.TabIndex = 4;
            this.txt_Songname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Songlist
            // 
            this.Songlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Songlist.AutoScroll = true;
            this.Songlist.BackColor = System.Drawing.Color.Gainsboro;
            this.Songlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Songlist.Location = new System.Drawing.Point(15, 63);
            this.Songlist.Name = "Songlist";
            this.Songlist.Size = new System.Drawing.Size(344, 411);
            this.Songlist.TabIndex = 8;
            // 
            // LrcView
            // 
            this.LrcView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LrcView.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LrcView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LrcView.Location = new System.Drawing.Point(476, 0);
            this.LrcView.Name = "LrcView";
            this.LrcView.Size = new System.Drawing.Size(306, 498);
            this.LrcView.TabIndex = 10;
            // 
            // DownManager
            // 
            this.DownManager.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DownManager.BackColor = System.Drawing.Color.Transparent;
            this.DownManager.Image = ((System.Drawing.Image)(resources.GetObject("DownManager.Image")));
            this.DownManager.Location = new System.Drawing.Point(961, 3);
            this.DownManager.Name = "DownManager";
            this.DownManager.Size = new System.Drawing.Size(30, 30);
            this.DownManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.DownManager.TabIndex = 8;
            this.DownManager.TabStop = false;
            this.toast.SetToolTip(this.DownManager, "下载管理器");
            this.DownManager.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // small
            // 
            this.small.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.small.BackColor = System.Drawing.Color.Transparent;
            this.small.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.small.ForeColor = System.Drawing.Color.White;
            this.small.Location = new System.Drawing.Point(997, -3);
            this.small.Name = "small";
            this.small.Size = new System.Drawing.Size(30, 30);
            this.small.TabIndex = 4;
            this.small.Text = "_";
            this.small.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toast.SetToolTip(this.small, "最小化");
            this.small.Click += new System.EventHandler(this.small_Click);
            this.small.MouseEnter += new System.EventHandler(this.small_MouseEnter);
            this.small.MouseLeave += new System.EventHandler(this.small_MouseLeave);
            // 
            // Closes
            // 
            this.Closes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Closes.BackColor = System.Drawing.Color.Transparent;
            this.Closes.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Closes.ForeColor = System.Drawing.Color.White;
            this.Closes.Location = new System.Drawing.Point(1034, 0);
            this.Closes.Name = "Closes";
            this.Closes.Size = new System.Drawing.Size(30, 30);
            this.Closes.TabIndex = 5;
            this.Closes.Text = "X";
            this.Closes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toast.SetToolTip(this.Closes, "关闭");
            this.Closes.Click += new System.EventHandler(this.Closes_Click);
            this.Closes.MouseEnter += new System.EventHandler(this.Closes_MouseEnter);
            this.Closes.MouseLeave += new System.EventHandler(this.Closes_MouseLeave);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Down});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(101, 26);
            // 
            // Down
            // 
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(100, 22);
            this.Down.Text = "下载";
            this.Down.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            // 
            // lrc
            // 
            this.lrc.Tick += new System.EventHandler(this.lrc_Tick);
            // 
            // bot
            // 
            this.bot.BackColor = System.Drawing.Color.Black;
            this.bot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bot.Controls.Add(this.panel1);
            this.bot.Controls.Add(this.panel9);
            this.bot.Controls.Add(this.label3);
            this.bot.Controls.Add(this.Songerimg);
            this.bot.Controls.Add(this.btn_play);
            this.bot.Controls.Add(this.blue);
            this.bot.Controls.Add(this.btn_up);
            this.bot.Controls.Add(this.gray);
            this.bot.Controls.Add(this.btn_next);
            this.bot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bot.Location = new System.Drawing.Point(0, 533);
            this.bot.Name = "bot";
            this.bot.Size = new System.Drawing.Size(1076, 87);
            this.bot.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.volume1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(953, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 87);
            this.panel1.TabIndex = 12;
            // 
            // volume1
            // 
            this.volume1.BackColor = System.Drawing.Color.LightSlateGray;
            this.volume1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.volume1.Location = new System.Drawing.Point(85, 16);
            this.volume1.Name = "volume1";
            this.volume1.Size = new System.Drawing.Size(34, 135);
            this.volume1.TabIndex = 0;
            this.volume1.Voulme = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(56, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.label10);
            this.panel9.Location = new System.Drawing.Point(278, 7);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(350, 31);
            this.panel9.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(2, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "Hello World";
            this.label10.TextChanged += new System.EventHandler(this.label10_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(277, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "00:00";
            this.label3.TextChanged += new System.EventHandler(this.label10_TextChanged);
            // 
            // Songerimg
            // 
            this.Songerimg.BackColor = System.Drawing.Color.Transparent;
            this.Songerimg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Songerimg.BackgroundImage")));
            this.Songerimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Songerimg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Songerimg.Location = new System.Drawing.Point(217, 16);
            this.Songerimg.Name = "Songerimg";
            this.Songerimg.Size = new System.Drawing.Size(54, 51);
            this.Songerimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Songerimg.TabIndex = 3;
            this.Songerimg.TabStop = false;
            this.Songerimg.Click += new System.EventHandler(this.pictureBox4_Click);
            this.Songerimg.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter_1);
            this.Songerimg.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave_1);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Transparent;
            this.btn_play.Image = ((System.Drawing.Image)(resources.GetObject("btn_play.Image")));
            this.btn_play.Location = new System.Drawing.Point(93, 18);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(50, 50);
            this.btn_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_play.TabIndex = 3;
            this.btn_play.TabStop = false;
            this.btn_play.Click += new System.EventHandler(this.pictureBox2_Click);
            this.btn_play.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.btn_play.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // blue
            // 
            this.blue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blue.BackColor = System.Drawing.Color.DodgerBlue;
            this.blue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.blue.Location = new System.Drawing.Point(277, 42);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(658, 3);
            this.blue.TabIndex = 6;
            this.blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // btn_up
            // 
            this.btn_up.BackColor = System.Drawing.Color.Transparent;
            this.btn_up.Image = ((System.Drawing.Image)(resources.GetObject("btn_up.Image")));
            this.btn_up.Location = new System.Drawing.Point(31, 22);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(45, 45);
            this.btn_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_up.TabIndex = 2;
            this.btn_up.TabStop = false;
            this.btn_up.Click += new System.EventHandler(this.pictureBox1_Click);
            this.btn_up.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.btn_up.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // gray
            // 
            this.gray.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gray.BackColor = System.Drawing.Color.DimGray;
            this.gray.Location = new System.Drawing.Point(277, 42);
            this.gray.Name = "gray";
            this.gray.Size = new System.Drawing.Size(658, 3);
            this.gray.TabIndex = 5;
            this.gray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.Image")));
            this.btn_next.Location = new System.Drawing.Point(154, 23);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(45, 45);
            this.btn_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_next.TabIndex = 4;
            this.btn_next.TabStop = false;
            this.btn_next.Click += new System.EventHandler(this.pictureBox3_Click);
            this.btn_next.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.btn_next.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            // 
            // top
            // 
            this.top.BackColor = System.Drawing.Color.Black;
            this.top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.top.Controls.Add(this.Closes);
            this.top.Controls.Add(this.DownManager);
            this.top.Controls.Add(this.small);
            this.top.Dock = System.Windows.Forms.DockStyle.Top;
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(1076, 33);
            this.top.TabIndex = 9;
            this.top.Paint += new System.Windows.Forms.PaintEventHandler(this.top_Paint);
            this.top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseDown);
            this.top.MouseEnter += new System.EventHandler(this.top_MouseEnter);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Transparent;
            this.panelRight.Controls.Add(this.LrcView);
            this.panelRight.Controls.Add(this.Search_view);
            this.panelRight.Location = new System.Drawing.Point(282, 33);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(791, 501);
            this.panelRight.TabIndex = 11;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.listGroup1);
            this.panelLeft.Location = new System.Drawing.Point(11, 39);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(260, 488);
            this.panelLeft.TabIndex = 12;
            // 
            // listGroup1
            // 
            this.listGroup1.BackColor = System.Drawing.Color.Transparent;
            this.listGroup1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listGroup1.Location = new System.Drawing.Point(0, 0);
            this.listGroup1.Name = "listGroup1";
            this.listGroup1.Size = new System.Drawing.Size(337, 486);
            this.listGroup1.TabIndex = 0;
            this.listGroup1.TakeDownImage = null;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1076, 620);
            this.Controls.Add(this.top);
            this.Controls.Add(this.bot);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Search_view.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.search_back.ResumeLayout(false);
            this.search_back.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_find)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownManager)).EndInit();
            this.Menu.ResumeLayout(false);
            this.bot.ResumeLayout(false);
            this.bot.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Songerimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).EndInit();
            this.top.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toast;
        private System.Windows.Forms.Panel Search_view;
        private new System.Windows.Forms.ContextMenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Down;
        private System.Windows.Forms.Panel search_back;
        private System.Windows.Forms.TextBox txt_Songname;
        private System.Windows.Forms.PictureBox btn_find;
        public System.Windows.Forms.PictureBox DownManager;
        private System.Windows.Forms.Timer lrc;
        private System.Windows.Forms.Panel LrcView;
        private System.Windows.Forms.Panel bot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Songerimg;
        private System.Windows.Forms.PictureBox btn_play;
        private System.Windows.Forms.Panel blue;
        private System.Windows.Forms.PictureBox btn_up;
        private System.Windows.Forms.Panel gray;
        private System.Windows.Forms.PictureBox btn_next;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Label Closes;
        private System.Windows.Forms.Label small;
        private LSkin.ScrollPanel Songlist;
        private System.Windows.Forms.Panel panel2;
        private LSkin.Volume volume1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private ListGroup.ListGroup listGroup1;
    }
}

