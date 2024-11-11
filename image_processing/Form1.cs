using WebCamLib;
using ImageProcess2;
using System.Diagnostics;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Runtime.InteropServices.ObjectiveC;

namespace image_processing
{
    public partial class Form1 : Form
    {
        //AForge
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        int deviceIndex;

        Bitmap loaded, processed;
        Device[] devices;
        Bitmap b;
        enum filter
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

        filter webcamFilter;
        public Form1()
        {
            InitializeComponent();
            webcamFilter = filter.None;
            deviceIndex = 0;
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
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loaded;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (timer1.Enabled)
                turnOffCamera();
        }
        private void pixelCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.PixelCopy(loaded, ref processed);
            pictureBox2.Image = processed;
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                processed.Save(saveFileDialog1.FileName);
            }
        }
        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            processed.Save(saveFileDialog1.FileName);
        }
        private void greyscalingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.GrayScale(loaded, ref processed);
            pictureBox2.Image = processed;
        }
        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.Inversion(loaded, ref processed);
            pictureBox2.Image = processed;
        }
        private void mirrorHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.MirrorHorizontal(loaded, ref processed);
            pictureBox2.Image = processed;
        }
        private void mirrorVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.MirrorVertical(loaded, ref processed);
            pictureBox2.Image = processed;
        }
        private void histToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.Hist(loaded, ref processed);
            pictureBox2.Image = processed;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            BasicDIP.Brightness(ref loaded, ref processed, trackBar1.Value);
            pictureBox2.Image = processed;
        }
        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.Sepia(loaded, ref processed);
            pictureBox2.Image = processed;
        }
        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            devices[0].Stop();
        }
        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
                timer1.Enabled = true;
            webcamFilter = filter.Gray;
        }
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

            if (pictureBox1.Image == null)
            {
                return null;
            }
            return new Bitmap(pictureBox1.Image);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            b = getBmap();

            switch (webcamFilter)
            {
                case filter.Gray:
                    BitmapFilter.GrayScale(b);
                    pictureBox2.Image = b;
                    return;
                case filter.Inversion:
                    BitmapFilter.Invert(b);
                    pictureBox2.Image = b;
                    return;
                case filter.Histogram:
                    BasicDIP.Hist(b, ref processed);
                    pictureBox2.Image = processed;
                    break;
                case filter.Sepia:
                    BasicDIP.Sepia(b, ref processed);
                    pictureBox2.Image = processed;
                    break;
                case filter.MirrorVertical:
                    BasicDIP.MirrorVertical(b, ref processed);
                    pictureBox2.Image = processed;
                    break;
                case filter.MirrorHorizontal:
                    BasicDIP.MirrorHorizontal(b, ref processed);
                    pictureBox2.Image = processed;
                    break;
                case filter.Smooth:
                    BasicDIP.Smoothing(b, ref processed);
                    pictureBox2.Image = processed;
                    break;
                case filter.GaussianBlur:
                    BasicDIP.GaussianBlur(b, ref processed);
                    pictureBox2.Image = processed;
                    break;
                case filter.Sharpen:
                    BasicDIP.Sharpen(b, ref processed);
                    pictureBox2.Image = processed;
                    break;
                case filter.MeanRemoval:
                    BasicDIP.MeanRemoval(b, ref processed);
                    pictureBox2.Image = processed;
                    break;
                case filter.EmbossLaplascian:
                    BasicDIP.EmbossLaplascian(b, ref processed);
                    pictureBox2.Image = processed;
                    break;
                case filter.EmbossHoriVert:
                    BasicDIP.EmbossHoriVerti(b, ref processed);
                    pictureBox2.Image = processed;
                    break;
                case filter.EmbossAllDirections:
                    BasicDIP.EmbossAllDirections(b, ref processed);
                    pictureBox2.Image = processed;
                    break;
                case filter.EmbossLossy:
                    BasicDIP.EmbossLossy(b, ref processed);
                    pictureBox2.Image = processed;
                    break;
                case filter.EmbossHorizontal:
                    BasicDIP.EmbossHorizontal(b, ref processed);
                    pictureBox2.Image = processed;
                    break;
                case filter.EmbossVertical:
                    BasicDIP.EmbossVertical(b, ref processed);
                    pictureBox2.Image = processed;
                    break;
            }
        }

        private void turnOffCamera()
        {
            if (timer1.Enabled)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }
        private void inversionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webcamFilter = filter.Inversion;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }
        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webcamFilter = filter.None;
            timer1.Enabled = false;
        }
        private void mirrorHorizontalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
                timer1.Enabled = true;
            webcamFilter = filter.MirrorHorizontal;
        }
        private void mirrorVerticalToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
                timer1.Enabled = true;
            webcamFilter = filter.MirrorVertical;
        }
        private void sepiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
                timer1.Enabled = true;
            webcamFilter = filter.Sepia;
        }
        private void histToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
                timer1.Enabled = true;
            webcamFilter = filter.Histogram;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                loaded = new Bitmap(openFileDialog2.FileName);
                pictureBox1.Image = loaded;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                loaded = new Bitmap(openFileDialog3.FileName);
                pictureBox2.Image = loaded;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(pictureBox1.Image);
            Bitmap background = new Bitmap(pictureBox2.Image);
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
            pictureBox3.Image = result;
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
                    comboBox1.Items.Add(device.Name);
            }
        }

        private void smoothToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.Smoothing(loaded, ref processed);
            pictureBox2.Image = processed;
        }
        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.GaussianBlur(loaded, ref processed);
            pictureBox2.Image = processed;
        }
        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.Sharpen(loaded, ref processed);
            pictureBox2.Image = processed;
        }
        private void meanRemovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.MeanRemoval(loaded, ref processed);
            pictureBox2.Image = processed;
        }
        private void embossLaplascianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.EmbossLaplascian(loaded, ref processed);
            pictureBox2.Image = processed;
        }
        private void embossHoriVertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.EmbossHoriVerti(loaded, ref processed);
            pictureBox2.Image = processed;
        }

        private void embossAllDirectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.EmbossAllDirections(loaded, ref processed);
            pictureBox2.Image = processed;
        }
        private void embossLossyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.EmbossLossy(loaded, ref processed);
            pictureBox2.Image = processed;
        }
        private void embossHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.EmbossHorizontal(loaded, ref processed);
            pictureBox2.Image = processed;
        }
        private void embossVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.EmbossVertical(loaded, ref processed);
            pictureBox2.Image = processed;
        }
        //AForge camera
        private void turnOnAForgeDevice(int deviceId)
        {
            if (videoDevices.Count >= deviceId + 1)
            {
                //first device
                var filterInfo = videoDevices[deviceId];
                Debug.WriteLine($"Connecting to [{filterInfo.Name}]...");
                videoSource = new VideoCaptureDevice(filterInfo.MonikerString);

                videoSource.NewFrame += new NewFrameEventHandler(Video_NewFrame);
                videoSource.Start();
            }
            else
            {
                Debug.WriteLine("No video device found.");
            }
        }
        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = frame; // Display the frame in pictureBox1
        }
        private void grayToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            webcamFilter = filter.Gray;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            turnOnAForgeDevice(comboBox1.SelectedIndex);
        }
        private void sepiaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            webcamFilter = filter.Sepia;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }
        private void inversionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            webcamFilter = filter.Inversion;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }
        private void mirrorHorizontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webcamFilter = filter.MirrorHorizontal;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }
        private void mirrorVerticalToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            webcamFilter = filter.MirrorVertical;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }
        private void histToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            webcamFilter = filter.Histogram;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }

        private void smoothToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webcamFilter = filter.Smooth;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }

        private void gaussianBlurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webcamFilter = filter.GaussianBlur;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }

        private void sharpenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webcamFilter = filter.Sharpen;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }

        private void meanRemovalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webcamFilter = filter.MeanRemoval;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }

        private void embossLaplascianToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webcamFilter = filter.EmbossLaplascian;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }

        private void embossHoriVertToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webcamFilter = filter.EmbossHoriVert;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }

        private void embossAllDirectionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webcamFilter = filter.EmbossAllDirections;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }

        private void embossLossyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webcamFilter = filter.EmbossLossy;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }

        private void embossHorizontalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webcamFilter = filter.EmbossHorizontal;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }

        private void embossVerticalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webcamFilter = filter.EmbossVertical;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }
    }
}


