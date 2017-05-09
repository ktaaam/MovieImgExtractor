/*
 * uses https://www.nrecosite.com/video_converter_net.aspx 
 * to get video thumbnails from MOV and mp4 files
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NReco.VideoConverter;

namespace MovieImgExtractor
{
    public partial class VideoExtractor : Form
    {
        public VideoExtractor()
        {
            InitializeComponent();
        }

        /*
         * Listener for the Browse button
         * Used to get the file path of a video file
         */
        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Video Files (*.mov, *.mp4)|*.mov;*.mp4"; //filter out non movie files
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName; // get name of file
                using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding()))
                {
                    FilePath.Text = path; 
                }
            }
        }

        /*
         * Listener for the Open button
         * Used to get a frame from the video in the given in FilePath
         * and set it as the thumbnail on the form
         */ 
        private void Open_Click(object sender, EventArgs e)
        {
            //get thumbnail from video and save it as a jpg
            string path = FilePath.Text.ToString();
            var ffMpeg = new NReco.VideoConverter.FFMpegConverter();
            ffMpeg.GetVideoThumbnail(path, "thumbnails/thumbnail.jpg", 1);

            //set the picturebox to the thumbnail image
            Thumbnail_Box.SizeMode = PictureBoxSizeMode.StretchImage;
            Thumbnail_Box.Image = new Bitmap("thumbnails/thumbnail.jpg");
        }
    }
}
