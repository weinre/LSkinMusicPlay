namespace AxPlayer3
{
    partial class AxPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AxPlayer));
            this.axPlayer = new AxAPlayer3Lib.AxPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // axPlayer
            // 
            this.axPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axPlayer.Enabled = true;
            this.axPlayer.Location = new System.Drawing.Point(0, 0);
            this.axPlayer.Name = "axPlayer";
            this.axPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPlayer.OcxState")));
            this.axPlayer.Size = new System.Drawing.Size(386, 199);
            this.axPlayer.TabIndex = 0;
            // 
            // AxPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.axPlayer);
            this.Name = "AxPlayer";
            this.Size = new System.Drawing.Size(386, 199);
            ((System.ComponentModel.ISupportInitialize)(this.axPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAPlayer3Lib.AxPlayer axPlayer;
    }
}
