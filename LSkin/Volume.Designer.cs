namespace LSkin
{
    partial class Volume
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
            this.label1 = new System.Windows.Forms.Label();
            this.red = new System.Windows.Forms.Panel();
            this.gray = new System.Windows.Forms.Panel();
            this.red.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "100%";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // red
            // 
            this.red.BackColor = System.Drawing.Color.White;
            this.red.Controls.Add(this.gray);
            this.red.Location = new System.Drawing.Point(15, 28);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(5, 100);
            this.red.TabIndex = 3;
            this.red.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gray_MouseDown);
            // 
            // gray
            // 
            this.gray.BackColor = System.Drawing.Color.Gray;
            this.gray.Dock = System.Windows.Forms.DockStyle.Top;
            this.gray.Location = new System.Drawing.Point(0, 0);
            this.gray.Name = "gray";
            this.gray.Size = new System.Drawing.Size(5, 50);
            this.gray.TabIndex = 1;
            this.gray.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gray_MouseDown);
            // 
            // Volume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(34, 135);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.red);
           
            this.Text = "Volume";
            this.Load += new System.EventHandler(this.YL_Load);
            this.red.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel red;
        private System.Windows.Forms.Panel gray;
    }
}