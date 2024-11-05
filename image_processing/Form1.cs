using WebCamLib;
using ImageProcess2;
using System.Diagnostics;

namespace image_processing
{
    public partial class Form1 : Form
    {
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
            Sepia
        }
        filter webcamFilter;
        public Form1()
        {
            InitializeComponent();
            webcamFilter = filter.None;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loaded;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            devices = DeviceManager.GetAllDevices();
        }

        private void obToolStripMenuItem_Click(object sender, EventArgs e)
        {
            devices[0].ShowWindow(pictureBox1);
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
            IDataObject data;
            Image bmap;

            devices[0].Sendmessage();
            data = Clipboard.GetDataObject();
            bmap = (Image)data.GetData("System.Drawing.Bitmap", true);
            if (bmap == null)
                return null;
            return new Bitmap(bmap);
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
    }
}


