namespace MusicPlay
{
    partial class DownSong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Closes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 262);
            this.panel1.TabIndex = 2;
            // 
            // Closes
            // 
            this.Closes.BackColor = System.Drawing.Color.Transparent;
            this.Closes.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Closes.ForeColor = System.Drawing.Color.White;
            this.Closes.Location = new System.Drawing.Point(512, 1);
            this.Closes.Name = "Closes";
            this.Closes.Size = new System.Drawing.Size(30, 30);
            this.Closes.TabIndex = 6;
            this.Closes.Text = "X";
            this.Closes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Closes.Click += new System.EventHandler(this.button2_Click);
            // 
            // DownSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(548, 312);
            this.Controls.Add(this.Closes);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DownSong";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "下载..";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DownLoadWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DownSong_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Closes;
    }
}