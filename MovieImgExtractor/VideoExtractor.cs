/*
 * uses https://www.nrecosite.com/video_converter_net.aspx 
 * to get video thumbnails from MOV and mp4 files
 */

using AxWMPLib;
using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

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
                    mediaPlayer.URL = FilePath.Text.ToString();
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
            //set the picturebox to the thumbnail image
            Thumbnail_Box.SizeMode = PictureBoxSizeMode.StretchImage;
            Thumbnail_Box.Image = new Bitmap(@"thumbnails/" + imagePath.Text + ".jpg");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(imagePath.Text, "^[a-zA-Z]"))
            {

                //get thumbnail from video and save it as a jpg
                string path = FilePath.Text.ToString();
                MediaFile inputFile = new MediaFile { Filename = path };
                MediaFile outputFile = new MediaFile { Filename = @"thumbnails/" + imagePath.Text + ".jpg" };
                timeInVideo.Text =  mediaPlayer.Ctlcontrols.currentPositionString;
                String[] split = timeInVideo.Text.Split(':');
                float time = float.Parse(split[0]) * 60 + float.Parse(split[1]);
                //float time = float.Parse(timeInVideo.Text, CultureInfo.InvariantCulture.NumberFormat);
                using (var engine = new Engine())
                {
                    engine.GetMetadata(inputFile);

                    // Saves the frame located on the 15th second of the video.
                    var options = new ConversionOptions { Seek = TimeSpan.FromSeconds(time) };
                    engine.GetThumbnail(inputFile, outputFile, options);
                }
            }
            else
            {
                MessageBox.Show("Error image name has not been entered", "Error Image name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }


        private void Player_MediaError(object sender, _WMPOCXEvents_MediaErrorEvent e)
        {
            try
            // If the Player encounters a corrupt or missing file, 
            // show the hexadecimal error code and URL.
            {
                IWMPMedia2 errSource = e.pMediaObject as IWMPMedia2;
                IWMPErrorItem errorItem = errSource.Error;
                MessageBox.Show("Error " + errorItem.errorCode.ToString("X")
                                + " in " + errSource.sourceURL);
            }
            catch (InvalidCastException)
            // In case pMediaObject is not an IWMPMedia item.
            {
                MessageBox.Show("Error.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer wmp = new WindowsMediaPlayerClass();
            IWMPMedia mediainfo = wmp.newMedia(FilePath.Text);

            // ...Add code to ensure that the text box contains a valid value.
            // Set the current position of the media item to the position entered by the user.
            if (mediaPlayer.Ctlcontrols.currentPosition < mediainfo.duration)
            {
                mediaPlayer.Ctlcontrols.currentPosition = mediaPlayer.Ctlcontrols.currentPosition + 0.05;
                mediaPlayer.Ctlcontrols.play();
                mediaPlayer.Ctlcontrols.pause();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ...Add code to ensure that the text box contains a valid value.
            // Set the current position of the media item to the position entered by the user.
            if(mediaPlayer.Ctlcontrols.currentPosition > 0.05)
            {
                mediaPlayer.Ctlcontrols.currentPosition = mediaPlayer.Ctlcontrols.currentPosition - 0.05;
                mediaPlayer.Ctlcontrols.play();
                mediaPlayer.Ctlcontrols.pause();
            }
            
        }
    }
}
