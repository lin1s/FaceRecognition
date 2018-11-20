﻿namespace Ncvt.FaceRecognitionWithOpenCvSharp
{
    partial class FrmMain
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVideoCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFaceLibrary = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddFaceFromVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddFaceFromPhoto = new System.Windows.Forms.ToolStripMenuItem();
            this.picVideoImage = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVideoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tsmiVideoCapture,
            this.tsmiFaceLibrary});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msMain.Size = new System.Drawing.Size(1169, 28);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.fileToolStripMenuItem.Text = "文件";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openToolStripMenuItem.Text = "打开视频文件";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.closeToolStripMenuItem.Text = "关闭视频文件";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "退出";
            // 
            // tsmiVideoCapture
            // 
            this.tsmiVideoCapture.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStart,
            this.tsmiStop,
            this.toolStripMenuItem1});
            this.tsmiVideoCapture.Name = "tsmiVideoCapture";
            this.tsmiVideoCapture.Size = new System.Drawing.Size(66, 24);
            this.tsmiVideoCapture.Text = "摄像头";
            // 
            // tsmiStart
            // 
            this.tsmiStart.Name = "tsmiStart";
            this.tsmiStart.Size = new System.Drawing.Size(216, 26);
            this.tsmiStart.Text = "开始";
            this.tsmiStart.Click += new System.EventHandler(this.tsmiStart_Click);
            // 
            // tsmiStop
            // 
            this.tsmiStop.Name = "tsmiStop";
            this.tsmiStop.Size = new System.Drawing.Size(216, 26);
            this.tsmiStop.Text = "停止";
            this.tsmiStop.Click += new System.EventHandler(this.tsmiStop_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 6);
            // 
            // tsmiFaceLibrary
            // 
            this.tsmiFaceLibrary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddFaceFromVideo,
            this.tsmiAddFaceFromPhoto});
            this.tsmiFaceLibrary.Name = "tsmiFaceLibrary";
            this.tsmiFaceLibrary.Size = new System.Drawing.Size(66, 24);
            this.tsmiFaceLibrary.Text = "人脸库";
            // 
            // tsmiAddFaceFromVideo
            // 
            this.tsmiAddFaceFromVideo.Name = "tsmiAddFaceFromVideo";
            this.tsmiAddFaceFromVideo.Size = new System.Drawing.Size(216, 26);
            this.tsmiAddFaceFromVideo.Text = "从摄像头添加";
            this.tsmiAddFaceFromVideo.Click += new System.EventHandler(this.tsmiAddFaceFromVideo_Click);
            // 
            // tsmiAddFaceFromPhoto
            // 
            this.tsmiAddFaceFromPhoto.Name = "tsmiAddFaceFromPhoto";
            this.tsmiAddFaceFromPhoto.Size = new System.Drawing.Size(216, 26);
            this.tsmiAddFaceFromPhoto.Text = "从图片添加";
            this.tsmiAddFaceFromPhoto.Click += new System.EventHandler(this.tsmiAddFaceFromPhoto_Click);
            // 
            // picVideoImage
            // 
            this.picVideoImage.Location = new System.Drawing.Point(16, 35);
            this.picVideoImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picVideoImage.Name = "picVideoImage";
            this.picVideoImage.Size = new System.Drawing.Size(789, 552);
            this.picVideoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVideoImage.TabIndex = 2;
            this.picVideoImage.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 597);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1169, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 619);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.picVideoImage);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人脸识别";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVideoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiVideoCapture;
        private System.Windows.Forms.ToolStripMenuItem tsmiFaceLibrary;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddFaceFromVideo;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddFaceFromPhoto;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiStart;
        private System.Windows.Forms.ToolStripMenuItem tsmiStop;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.PictureBox picVideoImage;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

