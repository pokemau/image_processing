using WebCamLib;
using ImageProcess2;
using System.Diagnostics;
using AForge.Video;
using AForge.Video.DirectShow;

namespace image_processing
{
    public partial class Form1 : Form
    {
        enum Filter
        {
            None,
            Gray,
            Inversion,
            MirrorHorizontal,
            MirrorVertical,
            Histogram,
            Sepia,
            Smooth,
            GaussianBlur,
            Sharpen,
            MeanRemoval,
            EmbossLaplascian,
            EmbossHoriVert,
            EmbossAllDirections,
            EmbossLossy,
            EmbossHorizontal,
            EmbossVertical,
        }
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        Bitmap loaded, processed;
        Device[] devices;
        Bitmap b;
        Filter webcamFilter;

        public Form1()
        {
            InitializeComponent();
            webcamFilter = Filter.None;
        }

        /********************
         * HELPER FUNCTIONS *
         *******************/
        private Bitmap getBmap()
        {
            //IDataObject data;
            //Image bmap;

            //devices[0].Sendmessage();
            //data = Clipboard.GetDataObject();
            //bmap = (Image)data.GetData("System.Drawing.Bitmap", true);
            //if (bmap == null)
            //    return null;
            //return new Bitmap(bmap);

            if (leftPictureBox.Image == null)
            {
                return null;
            }
            return new Bitmap(leftPictureBox.Image);
        }
        private void turnOffCamera()
        {
            if (timer1.Enabled)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }
        private void DetectWebcamDevices()
        {
            // AForge
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
                MessageBox.Show("No video devices found.");
            else
            {
                Debug.WriteLine("DEVICES:  ");
                foreach (FilterInfo device in videoDevices)
                    devicesComboBox.Items.Add(device.Name);
            }
        }
        private void turnOnAForgeDevice(int deviceId)
        {
            if (videoDevices.Count >= deviceId + 1)
            {
                var filterInfo = videoDevices[deviceId];
                Debug.WriteLine($"Connecting to [{filterInfo.Name}]...");
                videoSource = new VideoCaptureDevice(filterInfo.MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(Video_NewFrame);
                videoSource.Start();
            }
        }
        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            leftPictureBox.Image = frame; // Display the frame in pictureBox1
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            devices = DeviceManager.GetAllDevices();
            DetectWebcamDevices();
        }
        private void Form1_Closing(object sender, EventArgs e)
        {
            turnOffCamera();
        }
        private void OpenFile_ToolStrip_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loaded = new Bitmap(OpenFileDialog1.FileName);
                leftPictureBox.Image = loaded;
                if (timer1.Enabled)
                    turnOffCamera();
            }
        }
        private void SaveFile_ToolStrip_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                processed.Save(SaveFileDialog1.FileName);
            }
        }
        private void saveImageBtn_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rightPictureBox.Image.Save(SaveFileDialog1.FileName);
            }
        }
        private void LoadImageBtn_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loaded = new Bitmap(OpenFileDialog1.FileName);
                leftPictureBox.Image = loaded;
                if (timer1.Enabled)
                    turnOffCamera();
            }
        }
        private void LoadBackgroundBtn_Click(object sender, EventArgs e)
        {
            if (LoadBackgroundFileDialog.ShowDialog() == DialogResult.OK)
            {
                loaded = new Bitmap(LoadBackgroundFileDialog.FileName);
                midPictureBox.Image = loaded;
            }
        }
        private void subtractBtn_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(leftPictureBox.Image);
            Bitmap background = new Bitmap(midPictureBox.Image);
            Bitmap result = new Bitmap(background.Width, background.Height);
            Color green = Color.FromArgb(0, 255, 0);
            int greygreen = (green.R + green.G + green.B) / 3;
            int threshold = 5;
            for (int x = 0; x < Math.Min(image.Width, background.Width); x++)
            {
                for (int y = 0; y < Math.Min(image.Height, background.Height); y++)
                {
                    Color pixel = image.GetPixel(x, y);
                    Color backpixel = background.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractValue = Math.Abs(grey - greygreen);

                    if (subtractValue > threshold)
                        result.SetPixel(x, y, pixel);
                    else
                        result.SetPixel(x, y, backpixel);
                }
            }
            rightPictureBox.Image = result;
        }
        private void pixelCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DIP.PixelCopy(loaded, ref processed);
            midPictureBox.Image = processed;
        }
        private void greyscalingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DIP.GrayScale(loaded, ref processed);
            midPictureBox.Image = processed;
        }
        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DIP.Inversion(loaded, ref processed);
            midPictureBox.Image = processed;
        }
        private void mirrorHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DIP.MirrorHorizontal(loaded, ref processed);
            midPictureBox.Image = processed;
        }
        private void mirrorVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DIP.MirrorVertical(loaded, ref processed);
            midPictureBox.Image = processed;
        }
        private void histToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DIP.Hist(loaded, ref processed);
            midPictureBox.Image = processed;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            DIP.Brightness(ref loaded, ref processed, trackBar1.Value);
            midPictureBox.Image = processed;
        }
        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DIP.Sepia(loaded, ref processed);
            midPictureBox.Image = processed;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            b = getBmap();

            switch (webcamFilter)
            {
                case Filter.Gray:
                    BitmapFilter.GrayScale(b);
                    midPictureBox.Image = b;
                    return;
                case Filter.Inversion:
                    BitmapFilter.Invert(b);
                    midPictureBox.Image = b;
                    return;
                case Filter.Histogram:
                    DIP.Hist(b, ref processed);
                    midPictureBox.Image = processed;
                    break;
                case Filter.Sepia:
                    DIP.Sepia(b, ref processed);
                    midPictureBox.Image = processed;
                    break;
                case Filter.MirrorVertical:
                    DIP.MirrorVertical(b, ref processed);
                    midPictureBox.Image = processed;
                    break;
                case Filter.MirrorHorizontal:
                    DIP.MirrorHorizontal(b, ref processed);
                    midPictureBox.Image = processed;
                    break;

                /*****************************
                 * CONVOLUTION MATRIX PROCESS
                 ****************************/
                case Filter.Smooth:
                    DIP.Smoothing(b, ref processed);
                    midPictureBox.Image = processed;
                    break;
                case Filter.GaussianBlur:
                    DIP.GaussianBlur(b, ref processed);
                    midPictureBox.Image = processed;
                    break;
                case Filter.Sharpen:
                    DIP.Sharpen(b, ref processed);
                    midPictureBox.Image = processed;
                    break;
                case Filter.MeanRemoval:
                    DIP.MeanRemoval(b, ref processed);
                    midPictureBox.Image = processed;
                    break;
                case Filter.EmbossLaplascian:
                    DIP.EmbossLaplacian(b, ref processed);
                    midPictureBox.Image = processed;
                    break;
                case Filter.EmbossHoriVert:
                    DIP.EmbossHoriVerti(b, ref processed);
                    midPictureBox.Image = processed;
                    break;
                case Filter.EmbossAllDirections:
                    DIP.EmbossAllDirections(b, ref processed);
                    midPictureBox.Image = processed;
                    break;
                case Filter.EmbossLossy:
                    DIP.EmbossLossy(b, ref processed);
                    midPictureBox.Image = processed;
                    break;
                case Filter.EmbossHorizontal:
                    DIP.EmbossHorizontal(b, ref processed);
                    midPictureBox.Image = processed;
                    break;
                case Filter.EmbossVertical:
                    DIP.EmbossVertical(b, ref processed);
                    midPictureBox.Image = processed;
                    break;
            }
        }
        private void smoothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DIP.Smoothing(loaded, ref processed);
            midPictureBox.Image = processed;
        }
        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DIP.Sharpen(loaded, ref processed);
            midPictureBox.Image = processed;
        }
        private void meanRemovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DIP.MeanRemoval(loaded, ref processed);
            midPictureBox.Image = processed;
        }
        private void embossLaplascianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DIP.EmbossLaplacian(loaded, ref processed);
            midPictureBox.Image = processed;
        }
        private void embossHoriVertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DIP.EmbossHoriVerti(loaded, ref processed);
            midPictureBox.Image = processed;
        }
        private void embossAllDirectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DIP.EmbossAllDirections(loaded, ref processed);
            midPictureBox.Image = processed;
        }
        private void embossLossyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DIP.EmbossLossy(loaded, ref processed);
            midPictureBox.Image = processed;
        }
        private void embossHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DIP.EmbossHorizontal(loaded, ref processed);
            midPictureBox.Image = processed;
        }
        private void embossVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DIP.EmbossVertical(loaded, ref processed);
            midPictureBox.Image = processed;
        }
        private void grayToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            webcamFilter = Filter.Gray;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            turnOnAForgeDevice(devicesComboBox.SelectedIndex);
        }
        private void sepiaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            webcamFilter = Filter.Sepia;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }
        private void inversionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            webcamFilter = Filter.Inversion;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }
        private void mirrorHorizontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webcamFilter = Filter.MirrorHorizontal;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }
        private void mirrorVerticalToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            webcamFilter = Filter.MirrorVertical;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }
        private void histToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            webcamFilter = Filter.Histogram;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }
        private void smoothToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webcamFilter = Filter.Smooth;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }
        private void gaussianBlurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webcamFilter = Filter.GaussianBlur;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }
        private void sharpenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webcamFilter = Filter.Sharpen;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }
        private void meanRemovalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webcamFilter = Filter.MeanRemoval;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }
        private void embossLaplascianToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webcamFilter = Filter.EmbossLaplascian;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }
        private void embossHoriVertToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webcamFilter = Filter.EmbossHoriVert;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }
        private void embossAllDirectionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webcamFilter = Filter.EmbossAllDirections;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }
        private void embossLossyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webcamFilter = Filter.EmbossLossy;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }
        private void embossHorizontalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webcamFilter = Filter.EmbossHorizontal;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }
        private void embossVerticalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webcamFilter = Filter.EmbossVertical;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }
    }
}


