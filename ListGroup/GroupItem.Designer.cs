
namespace ListGroup
{
    partial class GroupItem
    {

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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GroupItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GroupName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupItems
            // 
            this.GroupItems.AutoSize = true;
            this.GroupItems.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GroupItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.GroupItems.Location = new System.Drawing.Point(4, 25);
            this.GroupItems.Name = "GroupItems";
            this.GroupItems.Size = new System.Drawing.Size(0, 0);
            this.GroupItems.TabIndex = 2;
            this.GroupItems.WrapContents = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::ListGroup.Properties.Resources.OpenItem;
            this.pictureBox.Location = new System.Drawing.Point(5, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(17, 17);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelToolStripMenuItem,
            this.DelToolStripMenuItem,
            this.MoveToToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(101, 70);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.cancelToolStripMenuItem.Text = "取消";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // DelToolStripMenuItem
            // 
            this.DelToolStripMenuItem.Name = "DelToolStripMenuItem";
            this.DelToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.DelToolStripMenuItem.Text = "删除";
            this.DelToolStripMenuItem.Click += new System.EventHandler(this.DelToolStripMenuItem_Click);
            // 
            // MoveToToolStripMenuItem
            // 
            this.MoveToToolStripMenuItem.Name = "MoveToToolStripMenuItem";
            this.MoveToToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.MoveToToolStripMenuItem.Text = "移动";
            this.MoveToToolStripMenuItem.Click += new System.EventHandler(this.MoveToToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            // 
            // GroupName
            // 
            this.GroupName.BackColor = System.Drawing.SystemColors.Control;
            this.GroupName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupName.Enabled = false;
            this.GroupName.Location = new System.Drawing.Point(0, 0);
            this.GroupName.Name = "GroupName";
            this.GroupName.Size = new System.Drawing.Size(192, 21);
            this.GroupName.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GroupName);
            this.panel1.Location = new System.Drawing.Point(28, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 21);
            this.panel1.TabIndex = 4;
            // 
            // GroupItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GroupItems);
            this.Controls.Add(this.pictureBox);
            this.Name = "GroupItem";
            this.Size = new System.Drawing.Size(224, 66);
            this.Load += new System.EventHandler(this.GroupItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel GroupItems;
        public System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        public System.Windows.Forms.ToolStripMenuItem DelToolStripMenuItem;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem MoveToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        public System.Windows.Forms.TextBox GroupName;
        private System.Windows.Forms.Panel panel1;
    }
}
