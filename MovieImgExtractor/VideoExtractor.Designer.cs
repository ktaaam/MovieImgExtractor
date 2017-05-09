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
            this.label1 = new System.Windows.Forms.Label();
            this.Browse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Longt_txt = new System.Windows.Forms.TextBox();
            this.Lat_txt = new System.Windows.Forms.TextBox();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Longitude";
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(224, 301);
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
            this.label2.Location = new System.Drawing.Point(69, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Latitude";
            // 
            // Longt_txt
            // 
            this.Longt_txt.Location = new System.Drawing.Point(149, 230);
            this.Longt_txt.Name = "Longt_txt";
            this.Longt_txt.Size = new System.Drawing.Size(100, 20);
            this.Longt_txt.TabIndex = 4;
            // 
            // Lat_txt
            // 
            this.Lat_txt.Location = new System.Drawing.Point(149, 263);
            this.Lat_txt.Name = "Lat_txt";
            this.Lat_txt.Size = new System.Drawing.Size(100, 20);
            this.Lat_txt.TabIndex = 5;
            // 
            // FilePath
            // 
            this.FilePath.Location = new System.Drawing.Point(41, 303);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(177, 20);
            this.FilePath.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "File";
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(314, 301);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 8;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // VideoExtractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 361);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.Lat_txt);
            this.Controls.Add(this.Longt_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Longt_txt;
        private System.Windows.Forms.TextBox Lat_txt;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Open;
    }
}

