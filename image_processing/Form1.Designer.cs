namespace image_processing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            FILE_toolStripMenuItem = new ToolStripMenuItem();
            OpenFile_ToolStrip = new ToolStripMenuItem();
            SaveFile_ToolStrip = new ToolStripMenuItem();
            dIPToolStripMenuItem = new ToolStripMenuItem();
            pixelCopyToolStripMenuItem = new ToolStripMenuItem();
            greyscalingToolStripMenuItem = new ToolStripMenuItem();
            inversionToolStripMenuItem = new ToolStripMenuItem();
            mirrorHorizontalToolStripMenuItem = new ToolStripMenuItem();
            mirrorVerticalToolStripMenuItem = new ToolStripMenuItem();
            sepiaToolStripMenuItem = new ToolStripMenuItem();
            histToolStripMenuItem = new ToolStripMenuItem();
            smoothToolStripMenuItem = new ToolStripMenuItem();
            gaussianBlurToolStripMenuItem = new ToolStripMenuItem();
            sharpenToolStripMenuItem = new ToolStripMenuItem();
            meanRemovalToolStripMenuItem = new ToolStripMenuItem();
            embossLaplascianToolStripMenuItem = new ToolStripMenuItem();
            embossHoriVertToolStripMenuItem = new ToolStripMenuItem();
            embossAllDirectionsToolStripMenuItem = new ToolStripMenuItem();
            embossLossyToolStripMenuItem = new ToolStripMenuItem();
            embossHorizontalToolStripMenuItem = new ToolStripMenuItem();
            embossVerticalToolStripMenuItem = new ToolStripMenuItem();
            videoDIPToolStripMenuItem = new ToolStripMenuItem();
            noneToolStripMenuItem1 = new ToolStripMenuItem();
            grayToolStripMenuItem1 = new ToolStripMenuItem();
            inversionToolStripMenuItem2 = new ToolStripMenuItem();
            mirrorHorizontToolStripMenuItem = new ToolStripMenuItem();
            mirrorVerticalToolStripMenuItem2 = new ToolStripMenuItem();
            sepiaToolStripMenuItem2 = new ToolStripMenuItem();
            histToolStripMenuItem2 = new ToolStripMenuItem();
            smoothToolStripMenuItem1 = new ToolStripMenuItem();
            gaussianBlurToolStripMenuItem1 = new ToolStripMenuItem();
            sharpenToolStripMenuItem1 = new ToolStripMenuItem();
            meanRemovalToolStripMenuItem1 = new ToolStripMenuItem();
            embossLaplascianToolStripMenuItem1 = new ToolStripMenuItem();
            embossHoriVertToolStripMenuItem1 = new ToolStripMenuItem();
            embossAllDirectionsToolStripMenuItem1 = new ToolStripMenuItem();
            embossLossyToolStripMenuItem1 = new ToolStripMenuItem();
            embossHorizontalToolStripMenuItem1 = new ToolStripMenuItem();
            embossVerticalToolStripMenuItem1 = new ToolStripMenuItem();
            OpenFileDialog1 = new OpenFileDialog();
            SaveFileDialog1 = new SaveFileDialog();
            leftPictureBox = new PictureBox();
            midPictureBox = new PictureBox();
            trackBar1 = new TrackBar();
            rightPictureBox = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            loadImageBtn = new Button();
            LoadImageFileDialog = new OpenFileDialog();
            LoadBackgroundBtn = new Button();
            subtractBtn = new Button();
            saveImageBtn = new Button();
            LoadBackgroundFileDialog = new OpenFileDialog();
            devicesComboBox = new ComboBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)midPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { FILE_toolStripMenuItem, dIPToolStripMenuItem, videoDIPToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1261, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // FILE_toolStripMenuItem
            // 
            FILE_toolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenFile_ToolStrip, SaveFile_ToolStrip });
            FILE_toolStripMenuItem.Name = "FILE_toolStripMenuItem";
            FILE_toolStripMenuItem.Size = new Size(37, 20);
            FILE_toolStripMenuItem.Text = "File";
            // 
            // OpenFile_ToolStrip
            // 
            OpenFile_ToolStrip.Name = "OpenFile_ToolStrip";
            OpenFile_ToolStrip.Size = new Size(180, 22);
            OpenFile_ToolStrip.Text = "Open";
            OpenFile_ToolStrip.Click += OpenFile_ToolStrip_Click;
            // 
            // SaveFile_ToolStrip
            // 
            SaveFile_ToolStrip.Name = "SaveFile_ToolStrip";
            SaveFile_ToolStrip.Size = new Size(180, 22);
            SaveFile_ToolStrip.Text = "Save";
            SaveFile_ToolStrip.Click += SaveFile_ToolStrip_Click;
            // 
            // dIPToolStripMenuItem
            // 
            dIPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pixelCopyToolStripMenuItem, greyscalingToolStripMenuItem, inversionToolStripMenuItem, mirrorHorizontalToolStripMenuItem, mirrorVerticalToolStripMenuItem, sepiaToolStripMenuItem, histToolStripMenuItem, smoothToolStripMenuItem, gaussianBlurToolStripMenuItem, sharpenToolStripMenuItem, meanRemovalToolStripMenuItem, embossLaplascianToolStripMenuItem, embossHoriVertToolStripMenuItem, embossAllDirectionsToolStripMenuItem, embossLossyToolStripMenuItem, embossHorizontalToolStripMenuItem, embossVerticalToolStripMenuItem });
            dIPToolStripMenuItem.Name = "dIPToolStripMenuItem";
            dIPToolStripMenuItem.Size = new Size(37, 20);
            dIPToolStripMenuItem.Text = "DIP";
            // 
            // pixelCopyToolStripMenuItem
            // 
            pixelCopyToolStripMenuItem.Name = "pixelCopyToolStripMenuItem";
            pixelCopyToolStripMenuItem.Size = new Size(188, 22);
            pixelCopyToolStripMenuItem.Text = "Pixel Copy";
            pixelCopyToolStripMenuItem.Click += pixelCopyToolStripMenuItem_Click;
            // 
            // greyscalingToolStripMenuItem
            // 
            greyscalingToolStripMenuItem.Name = "greyscalingToolStripMenuItem";
            greyscalingToolStripMenuItem.Size = new Size(188, 22);
            greyscalingToolStripMenuItem.Text = "Greyscaling";
            greyscalingToolStripMenuItem.Click += greyscalingToolStripMenuItem_Click;
            // 
            // inversionToolStripMenuItem
            // 
            inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            inversionToolStripMenuItem.Size = new Size(188, 22);
            inversionToolStripMenuItem.Text = "Inversion";
            inversionToolStripMenuItem.Click += inversionToolStripMenuItem_Click;
            // 
            // mirrorHorizontalToolStripMenuItem
            // 
            mirrorHorizontalToolStripMenuItem.Name = "mirrorHorizontalToolStripMenuItem";
            mirrorHorizontalToolStripMenuItem.Size = new Size(188, 22);
            mirrorHorizontalToolStripMenuItem.Text = "Mirror Horizontal";
            mirrorHorizontalToolStripMenuItem.Click += mirrorHorizontalToolStripMenuItem_Click;
            // 
            // mirrorVerticalToolStripMenuItem
            // 
            mirrorVerticalToolStripMenuItem.Name = "mirrorVerticalToolStripMenuItem";
            mirrorVerticalToolStripMenuItem.Size = new Size(188, 22);
            mirrorVerticalToolStripMenuItem.Text = "Mirror Vertical";
            mirrorVerticalToolStripMenuItem.Click += mirrorVerticalToolStripMenuItem_Click;
            // 
            // sepiaToolStripMenuItem
            // 
            sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            sepiaToolStripMenuItem.Size = new Size(188, 22);
            sepiaToolStripMenuItem.Text = "Sepia";
            sepiaToolStripMenuItem.Click += sepiaToolStripMenuItem_Click;
            // 
            // histToolStripMenuItem
            // 
            histToolStripMenuItem.Name = "histToolStripMenuItem";
            histToolStripMenuItem.Size = new Size(188, 22);
            histToolStripMenuItem.Text = "Hist";
            histToolStripMenuItem.Click += histToolStripMenuItem_Click;
            // 
            // smoothToolStripMenuItem
            // 
            smoothToolStripMenuItem.Name = "smoothToolStripMenuItem";
            smoothToolStripMenuItem.Size = new Size(188, 22);
            smoothToolStripMenuItem.Text = "Smooth";
            smoothToolStripMenuItem.Click += smoothToolStripMenuItem_Click;
            // 
            // gaussianBlurToolStripMenuItem
            // 
            gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            gaussianBlurToolStripMenuItem.Size = new Size(188, 22);
            gaussianBlurToolStripMenuItem.Text = "Gaussian Blur";
            // 
            // sharpenToolStripMenuItem
            // 
            sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            sharpenToolStripMenuItem.Size = new Size(188, 22);
            sharpenToolStripMenuItem.Text = "Sharpen";
            sharpenToolStripMenuItem.Click += sharpenToolStripMenuItem_Click;
            // 
            // meanRemovalToolStripMenuItem
            // 
            meanRemovalToolStripMenuItem.Name = "meanRemovalToolStripMenuItem";
            meanRemovalToolStripMenuItem.Size = new Size(188, 22);
            meanRemovalToolStripMenuItem.Text = "Mean Removal";
            meanRemovalToolStripMenuItem.Click += meanRemovalToolStripMenuItem_Click;
            // 
            // embossLaplascianToolStripMenuItem
            // 
            embossLaplascianToolStripMenuItem.Name = "embossLaplascianToolStripMenuItem";
            embossLaplascianToolStripMenuItem.Size = new Size(188, 22);
            embossLaplascianToolStripMenuItem.Text = "Emboss Laplacian";
            embossLaplascianToolStripMenuItem.Click += embossLaplascianToolStripMenuItem_Click;
            // 
            // embossHoriVertToolStripMenuItem
            // 
            embossHoriVertToolStripMenuItem.Name = "embossHoriVertToolStripMenuItem";
            embossHoriVertToolStripMenuItem.Size = new Size(188, 22);
            embossHoriVertToolStripMenuItem.Text = "Emboss Hori/Vert";
            embossHoriVertToolStripMenuItem.Click += embossHoriVertToolStripMenuItem_Click;
            // 
            // embossAllDirectionsToolStripMenuItem
            // 
            embossAllDirectionsToolStripMenuItem.Name = "embossAllDirectionsToolStripMenuItem";
            embossAllDirectionsToolStripMenuItem.Size = new Size(188, 22);
            embossAllDirectionsToolStripMenuItem.Text = "Emboss All Directions";
            embossAllDirectionsToolStripMenuItem.Click += embossAllDirectionsToolStripMenuItem_Click;
            // 
            // embossLossyToolStripMenuItem
            // 
            embossLossyToolStripMenuItem.Name = "embossLossyToolStripMenuItem";
            embossLossyToolStripMenuItem.Size = new Size(188, 22);
            embossLossyToolStripMenuItem.Text = "Emboss Lossy";
            embossLossyToolStripMenuItem.Click += embossLossyToolStripMenuItem_Click;
            // 
            // embossHorizontalToolStripMenuItem
            // 
            embossHorizontalToolStripMenuItem.Name = "embossHorizontalToolStripMenuItem";
            embossHorizontalToolStripMenuItem.Size = new Size(188, 22);
            embossHorizontalToolStripMenuItem.Text = "Emboss Horizontal";
            embossHorizontalToolStripMenuItem.Click += embossHorizontalToolStripMenuItem_Click;
            // 
            // embossVerticalToolStripMenuItem
            // 
            embossVerticalToolStripMenuItem.Name = "embossVerticalToolStripMenuItem";
            embossVerticalToolStripMenuItem.Size = new Size(188, 22);
            embossVerticalToolStripMenuItem.Text = "Emboss Vertical";
            embossVerticalToolStripMenuItem.Click += embossVerticalToolStripMenuItem_Click;
            // 
            // videoDIPToolStripMenuItem
            // 
            videoDIPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { noneToolStripMenuItem1, grayToolStripMenuItem1, inversionToolStripMenuItem2, mirrorHorizontToolStripMenuItem, mirrorVerticalToolStripMenuItem2, sepiaToolStripMenuItem2, histToolStripMenuItem2, smoothToolStripMenuItem1, gaussianBlurToolStripMenuItem1, sharpenToolStripMenuItem1, meanRemovalToolStripMenuItem1, embossLaplascianToolStripMenuItem1, embossHoriVertToolStripMenuItem1, embossAllDirectionsToolStripMenuItem1, embossLossyToolStripMenuItem1, embossHorizontalToolStripMenuItem1, embossVerticalToolStripMenuItem1 });
            videoDIPToolStripMenuItem.Name = "videoDIPToolStripMenuItem";
            videoDIPToolStripMenuItem.Size = new Size(70, 20);
            videoDIPToolStripMenuItem.Text = "Video DIP";
            // 
            // noneToolStripMenuItem1
            // 
            noneToolStripMenuItem1.Name = "noneToolStripMenuItem1";
            noneToolStripMenuItem1.Size = new Size(188, 22);
            noneToolStripMenuItem1.Text = "None";
            // 
            // grayToolStripMenuItem1
            // 
            grayToolStripMenuItem1.Name = "grayToolStripMenuItem1";
            grayToolStripMenuItem1.Size = new Size(188, 22);
            grayToolStripMenuItem1.Text = "Gray";
            grayToolStripMenuItem1.Click += grayToolStripMenuItem1_Click_1;
            // 
            // inversionToolStripMenuItem2
            // 
            inversionToolStripMenuItem2.Name = "inversionToolStripMenuItem2";
            inversionToolStripMenuItem2.Size = new Size(188, 22);
            inversionToolStripMenuItem2.Text = "Inversion";
            inversionToolStripMenuItem2.Click += inversionToolStripMenuItem2_Click;
            // 
            // mirrorHorizontToolStripMenuItem
            // 
            mirrorHorizontToolStripMenuItem.Name = "mirrorHorizontToolStripMenuItem";
            mirrorHorizontToolStripMenuItem.Size = new Size(188, 22);
            mirrorHorizontToolStripMenuItem.Text = "Mirror Horizontal";
            mirrorHorizontToolStripMenuItem.Click += mirrorHorizontToolStripMenuItem_Click;
            // 
            // mirrorVerticalToolStripMenuItem2
            // 
            mirrorVerticalToolStripMenuItem2.Name = "mirrorVerticalToolStripMenuItem2";
            mirrorVerticalToolStripMenuItem2.Size = new Size(188, 22);
            mirrorVerticalToolStripMenuItem2.Text = "Mirror Vertical";
            mirrorVerticalToolStripMenuItem2.Click += mirrorVerticalToolStripMenuItem2_Click;
            // 
            // sepiaToolStripMenuItem2
            // 
            sepiaToolStripMenuItem2.Name = "sepiaToolStripMenuItem2";
            sepiaToolStripMenuItem2.Size = new Size(188, 22);
            sepiaToolStripMenuItem2.Text = "Sepia";
            sepiaToolStripMenuItem2.Click += sepiaToolStripMenuItem2_Click;
            // 
            // histToolStripMenuItem2
            // 
            histToolStripMenuItem2.Name = "histToolStripMenuItem2";
            histToolStripMenuItem2.Size = new Size(188, 22);
            histToolStripMenuItem2.Text = "Hist";
            histToolStripMenuItem2.Click += histToolStripMenuItem2_Click;
            // 
            // smoothToolStripMenuItem1
            // 
            smoothToolStripMenuItem1.Name = "smoothToolStripMenuItem1";
            smoothToolStripMenuItem1.Size = new Size(188, 22);
            smoothToolStripMenuItem1.Text = "Smooth";
            smoothToolStripMenuItem1.Click += smoothToolStripMenuItem1_Click;
            // 
            // gaussianBlurToolStripMenuItem1
            // 
            gaussianBlurToolStripMenuItem1.Name = "gaussianBlurToolStripMenuItem1";
            gaussianBlurToolStripMenuItem1.Size = new Size(188, 22);
            gaussianBlurToolStripMenuItem1.Text = "Gaussian Blur";
            gaussianBlurToolStripMenuItem1.Click += gaussianBlurToolStripMenuItem1_Click;
            // 
            // sharpenToolStripMenuItem1
            // 
            sharpenToolStripMenuItem1.Name = "sharpenToolStripMenuItem1";
            sharpenToolStripMenuItem1.Size = new Size(188, 22);
            sharpenToolStripMenuItem1.Text = "Sharpen";
            sharpenToolStripMenuItem1.Click += sharpenToolStripMenuItem1_Click;
            // 
            // meanRemovalToolStripMenuItem1
            // 
            meanRemovalToolStripMenuItem1.Name = "meanRemovalToolStripMenuItem1";
            meanRemovalToolStripMenuItem1.Size = new Size(188, 22);
            meanRemovalToolStripMenuItem1.Text = "Mean Removal";
            meanRemovalToolStripMenuItem1.Click += meanRemovalToolStripMenuItem1_Click;
            // 
            // embossLaplascianToolStripMenuItem1
            // 
            embossLaplascianToolStripMenuItem1.Name = "embossLaplascianToolStripMenuItem1";
            embossLaplascianToolStripMenuItem1.Size = new Size(188, 22);
            embossLaplascianToolStripMenuItem1.Text = "Emboss Laplacian";
            embossLaplascianToolStripMenuItem1.Click += embossLaplascianToolStripMenuItem1_Click;
            // 
            // embossHoriVertToolStripMenuItem1
            // 
            embossHoriVertToolStripMenuItem1.Name = "embossHoriVertToolStripMenuItem1";
            embossHoriVertToolStripMenuItem1.Size = new Size(188, 22);
            embossHoriVertToolStripMenuItem1.Text = "Emboss Hori/Vert";
            embossHoriVertToolStripMenuItem1.Click += embossHoriVertToolStripMenuItem1_Click;
            // 
            // embossAllDirectionsToolStripMenuItem1
            // 
            embossAllDirectionsToolStripMenuItem1.Name = "embossAllDirectionsToolStripMenuItem1";
            embossAllDirectionsToolStripMenuItem1.Size = new Size(188, 22);
            embossAllDirectionsToolStripMenuItem1.Text = "Emboss All Directions";
            embossAllDirectionsToolStripMenuItem1.Click += embossAllDirectionsToolStripMenuItem1_Click;
            // 
            // embossLossyToolStripMenuItem1
            // 
            embossLossyToolStripMenuItem1.Name = "embossLossyToolStripMenuItem1";
            embossLossyToolStripMenuItem1.Size = new Size(188, 22);
            embossLossyToolStripMenuItem1.Text = "Emboss Lossy";
            embossLossyToolStripMenuItem1.Click += embossLossyToolStripMenuItem1_Click;
            // 
            // embossHorizontalToolStripMenuItem1
            // 
            embossHorizontalToolStripMenuItem1.Name = "embossHorizontalToolStripMenuItem1";
            embossHorizontalToolStripMenuItem1.Size = new Size(188, 22);
            embossHorizontalToolStripMenuItem1.Text = "Emboss Horizontal";
            embossHorizontalToolStripMenuItem1.Click += embossHorizontalToolStripMenuItem1_Click;
            // 
            // embossVerticalToolStripMenuItem1
            // 
            embossVerticalToolStripMenuItem1.Name = "embossVerticalToolStripMenuItem1";
            embossVerticalToolStripMenuItem1.Size = new Size(188, 22);
            embossVerticalToolStripMenuItem1.Text = "Emboss Vertical";
            embossVerticalToolStripMenuItem1.Click += embossVerticalToolStripMenuItem1_Click;
            // 
            // leftPictureBox
            // 
            leftPictureBox.Location = new Point(12, 117);
            leftPictureBox.Name = "leftPictureBox";
            leftPictureBox.Size = new Size(400, 400);
            leftPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            leftPictureBox.TabIndex = 1;
            leftPictureBox.TabStop = false;
            // 
            // midPictureBox
            // 
            midPictureBox.Location = new Point(418, 117);
            midPictureBox.Name = "midPictureBox";
            midPictureBox.Size = new Size(400, 400);
            midPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            midPictureBox.TabIndex = 2;
            midPictureBox.TabStop = false;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(573, 47);
            trackBar1.Maximum = 50;
            trackBar1.Minimum = -50;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(350, 45);
            trackBar1.TabIndex = 3;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // rightPictureBox
            // 
            rightPictureBox.Location = new Point(824, 117);
            rightPictureBox.Name = "rightPictureBox";
            rightPictureBox.Size = new Size(400, 400);
            rightPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            rightPictureBox.TabIndex = 4;
            rightPictureBox.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // loadImageBtn
            // 
            loadImageBtn.Location = new Point(12, 523);
            loadImageBtn.Name = "loadImageBtn";
            loadImageBtn.Size = new Size(113, 30);
            loadImageBtn.TabIndex = 5;
            loadImageBtn.Text = "Load Image";
            loadImageBtn.UseVisualStyleBackColor = true;
            loadImageBtn.Click += LoadImageBtn_Click;
            // 
            // LoadImageFileDialog
            // 
            LoadImageFileDialog.FileName = "openFileDialog2";
            // 
            // LoadBackgroundBtn
            // 
            LoadBackgroundBtn.Location = new Point(418, 523);
            LoadBackgroundBtn.Name = "LoadBackgroundBtn";
            LoadBackgroundBtn.Size = new Size(113, 30);
            LoadBackgroundBtn.TabIndex = 6;
            LoadBackgroundBtn.Text = "Load Background";
            LoadBackgroundBtn.UseVisualStyleBackColor = true;
            LoadBackgroundBtn.Click += LoadBackgroundBtn_Click;
            // 
            // subtractBtn
            // 
            subtractBtn.Location = new Point(824, 523);
            subtractBtn.Name = "subtractBtn";
            subtractBtn.Size = new Size(113, 30);
            subtractBtn.TabIndex = 7;
            subtractBtn.Text = "Subtract";
            subtractBtn.UseVisualStyleBackColor = true;
            subtractBtn.Click += subtractBtn_Click;
            // 
            // saveImageBtn
            // 
            saveImageBtn.Location = new Point(943, 523);
            saveImageBtn.Name = "saveImageBtn";
            saveImageBtn.Size = new Size(113, 30);
            saveImageBtn.TabIndex = 8;
            saveImageBtn.Text = "Save New Image";
            saveImageBtn.UseVisualStyleBackColor = true;
            saveImageBtn.Click += saveImageBtn_Click;
            // 
            // LoadBackgroundFileDialog
            // 
            LoadBackgroundFileDialog.FileName = "openFileDialog3";
            // 
            // devicesComboBox
            // 
            devicesComboBox.FormattingEnabled = true;
            devicesComboBox.Location = new Point(12, 47);
            devicesComboBox.Name = "devicesComboBox";
            devicesComboBox.Size = new Size(121, 23);
            devicesComboBox.TabIndex = 9;
            devicesComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 10;
            label1.Text = "Webcam";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1261, 583);
            Controls.Add(label1);
            Controls.Add(devicesComboBox);
            Controls.Add(saveImageBtn);
            Controls.Add(subtractBtn);
            Controls.Add(LoadBackgroundBtn);
            Controls.Add(loadImageBtn);
            Controls.Add(rightPictureBox);
            Controls.Add(trackBar1);
            Controls.Add(midPictureBox);
            Controls.Add(leftPictureBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)leftPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)midPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rightPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dIPToolStripMenuItem;
        private ToolStripMenuItem pixelCopyToolStripMenuItem;
        private ToolStripMenuItem greyscalingToolStripMenuItem;
        private ToolStripMenuItem inversionToolStripMenuItem;
        private ToolStripMenuItem mirrorHorizontalToolStripMenuItem;
        private ToolStripMenuItem mirrorVerticalToolStripMenuItem;
        private OpenFileDialog OpenFileDialog1;
        private SaveFileDialog SaveFileDialog1;
        private PictureBox leftPictureBox;
        private PictureBox midPictureBox;
        private ToolStripMenuItem histToolStripMenuItem;
        private TrackBar trackBar1;
        private ToolStripMenuItem sepiaToolStripMenuItem;
        private PictureBox rightPictureBox;
        private System.Windows.Forms.Timer timer1;
        private Button loadImageBtn;
        private OpenFileDialog LoadImageFileDialog;
        private Button LoadBackgroundBtn;
        private Button subtractBtn;
        private Button saveImageBtn;
        private OpenFileDialog LoadBackgroundFileDialog;
        private ToolStripMenuItem smoothToolStripMenuItem;
        private ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private ToolStripMenuItem sharpenToolStripMenuItem;
        private ToolStripMenuItem meanRemovalToolStripMenuItem;
        private ToolStripMenuItem embossLaplascianToolStripMenuItem;
        private ToolStripMenuItem embossHoriVertToolStripMenuItem;
        private ToolStripMenuItem embossAllDirectionsToolStripMenuItem;
        private ToolStripMenuItem embossLossyToolStripMenuItem;
        private ToolStripMenuItem embossHorizontalToolStripMenuItem;
        private ToolStripMenuItem embossVerticalToolStripMenuItem;
        private ToolStripMenuItem videoDIPToolStripMenuItem;
        private ToolStripMenuItem noneToolStripMenuItem1;
        private ToolStripMenuItem grayToolStripMenuItem1;
        private ToolStripMenuItem inversionToolStripMenuItem2;
        private ToolStripMenuItem mirrorHorizontToolStripMenuItem;
        private ToolStripMenuItem mirrorVerticalToolStripMenuItem2;
        private ToolStripMenuItem sepiaToolStripMenuItem2;
        private ToolStripMenuItem histToolStripMenuItem2;
        private ComboBox devicesComboBox;
        private ToolStripMenuItem smoothToolStripMenuItem1;
        private ToolStripMenuItem gaussianBlurToolStripMenuItem1;
        private ToolStripMenuItem sharpenToolStripMenuItem1;
        private ToolStripMenuItem meanRemovalToolStripMenuItem1;
        private ToolStripMenuItem embossLaplascianToolStripMenuItem1;
        private ToolStripMenuItem embossHoriVertToolStripMenuItem1;
        private ToolStripMenuItem embossAllDirectionsToolStripMenuItem1;
        private ToolStripMenuItem embossLossyToolStripMenuItem1;
        private ToolStripMenuItem embossHorizontalToolStripMenuItem1;
        private ToolStripMenuItem embossVerticalToolStripMenuItem1;
        private ToolStripMenuItem FILE_toolStripMenuItem;
        private ToolStripMenuItem OpenFile_ToolStrip;
        private ToolStripMenuItem SaveFile_ToolStrip;
        private Label label1;
    }
}
