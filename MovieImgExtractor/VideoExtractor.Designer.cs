namespace MovieImgExtractor
{
    partial class VideoExtractor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoExtractor));
            this.Thumbnail_Box = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Browse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timeInVideo = new System.Windows.Forms.TextBox();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.imagePath = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // Thumbnail_Box
            // 
            this.Thumbnail_Box.Location = new System.Drawing.Point(17, 753);
            this.Thumbnail_Box.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Thumbnail_Box.Name = "Thumbnail_Box";
            this.Thumbnail_Box.Size = new System.Drawing.Size(1005, 334);
            this.Thumbnail_Box.TabIndex = 0;
            this.Thumbnail_Box.TabStop = false;
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(611, 1182);
            this.Browse.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(200, 55);
            this.Browse.TabIndex = 2;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 1141);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time";
            // 
            // timeInVideo
            // 
            this.timeInVideo.Location = new System.Drawing.Point(206, 1124);
            this.timeInVideo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.timeInVideo.Name = "timeInVideo";
            this.timeInVideo.Size = new System.Drawing.Size(383, 38);
            this.timeInVideo.TabIndex = 5;
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(206, 1186);
            this.FilePath.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(383, 38);
            this.FilePath.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 1203);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "File";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(827, 1179);
            this.Open.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(200, 55);
            this.Open.TabIndex = 8;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 1265);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Image Name";
            // 
            // imagePath
            // 
            this.imagePath.Location = new System.Drawing.Point(206, 1258);
            this.imagePath.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.imagePath.Name = "imagePath";
            this.imagePath.Size = new System.Drawing.Size(383, 38);
            this.imagePath.TabIndex = 10;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(611, 1253);
            this.saveButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.saveButton.Name = "saveButton";
            this.saveButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.saveButton.Size = new System.Drawing.Size(200, 55);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(17, 12);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(927, 418);
            this.mediaPlayer.TabIndex = 12;
            // 
            // VideoExtractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1887, 1329);
            this.Controls.Add(this.mediaPlayer);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.imagePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.timeInVideo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.Thumbnail_Box);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "VideoExtractor";
            this.Text = "Video Extractor";
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Thumbnail_Box;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeInVideo;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox imagePath;
        private System.Windows.Forms.Button saveButton;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
    }
}

