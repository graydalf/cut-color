namespace CutColor
{
    partial class MainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbMouseColor = new System.Windows.Forms.TextBox();
            this.tbColorsHistory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbMouseColor
            // 
            this.tbMouseColor.Location = new System.Drawing.Point(12, 147);
            this.tbMouseColor.Name = "tbMouseColor";
            this.tbMouseColor.Size = new System.Drawing.Size(128, 21);
            this.tbMouseColor.TabIndex = 1;
            // 
            // tbColorsHistory
            // 
            this.tbColorsHistory.Location = new System.Drawing.Point(147, 13);
            this.tbColorsHistory.Multiline = true;
            this.tbColorsHistory.Name = "tbColorsHistory";
            this.tbColorsHistory.Size = new System.Drawing.Size(128, 155);
            this.tbColorsHistory.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 182);
            this.Controls.Add(this.tbColorsHistory);
            this.Controls.Add(this.tbMouseColor);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "CutColor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbMouseColor;
        private System.Windows.Forms.TextBox tbColorsHistory;
    }
}

