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
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Thumbnail_Box
            // 
            this.Thumbnail_Box.Location = new System.Drawing.Point(12, 12);
            this.Thumbnail_Box.Name = "Thumbnail_Box";
            this.Thumbnail_Box.Size = new System.Drawing.Size(377, 140);
            this.Thumbnail_Box.TabIndex = 0;
            this.Thumbnail_Box.TabStop = false;
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(234, 259);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 2;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time";
            // 
            // timeInVideo
            // 
            this.timeInVideo.Location = new System.Drawing.Point(82, 235);
            this.timeInVideo.Name = "timeInVideo";
            this.timeInVideo.Size = new System.Drawing.Size(146, 20);
            this.timeInVideo.TabIndex = 5;
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(82, 261);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(146, 20);
            this.FilePath.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "File";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(315, 258);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 8;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Image Name";
            // 
            // imagePath
            // 
            this.imagePath.Location = new System.Drawing.Point(82, 291);
            this.imagePath.Name = "imagePath";
            this.imagePath.Size = new System.Drawing.Size(146, 20);
            this.imagePath.TabIndex = 10;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(234, 289);
            this.saveButton.Name = "saveButton";
            this.saveButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // VideoExtractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 361);
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
            this.Name = "VideoExtractor";
            this.Text = "Video Extractor";
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail_Box)).EndInit();
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
    }
}

