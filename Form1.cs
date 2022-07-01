using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Task1
{
    
    public partial class Form1 : Form
    {
        string PictureFile;
        public Form1()
        {
            InitializeComponent();
            this.Width = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Width * 0.85);
            this.Height = Convert.ToInt32(Screen.PrimaryScreen.WorkingArea.Height * 0.75);
            pictureBox1.Visible = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.SplitterDistance = this.ClientRectangle.Width/2;
            newToolStripMenuItem.Click += NewToolStripMenuItem_Click;
            openToolStripMenuItem.Click += uploadButton_Click;
            saveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            buttonState(false);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonState(bool state)
        {
            foreach (Button button in groupBox1.Controls)
            {
                button.Enabled = state;
            }
            foreach (Button button in groupBox2.Controls)
            {
                button.Enabled = state;
            }
            revertButton.Enabled = state;
            saveAsToolStripMenuItem.Enabled = state;
            ditheringApplyButton.Enabled = state;
            popalgApplyButton.Enabled = state;
            ditheringK.Enabled = state;
            numberOfColors.Enabled = state;
            greyScaleButton.Enabled = state;
            ycbcrButton.Enabled = state;
            rgbButton.Enabled = false;
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
            saveFileDialog1.Title = "Save an Image File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap pic = new Bitmap(pictureBox2.Image);
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        pic.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                        break;

                    case 2:
                        pic.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
                        break;

                    case 3:
                        pic.Save(saveFileDialog1.FileName, ImageFormat.Gif);
                        break;
                    case 4:
                        pic.Save(saveFileDialog1.FileName, ImageFormat.Png);
                        break;
                }
            }
        }

        public void invertImage()
        {
            Bitmap picture = new Bitmap(pictureBox2.Image);
            for (int y = 0; (y <= (picture.Height - 1)); y++)
            {
                for (int x = 0; (x <= (picture.Width - 1)); x++)
                {
                    Color inverted = picture.GetPixel(x, y);
                    inverted = Color.FromArgb(255, (255 - inverted.R), (255 - inverted.G), (255 - inverted.B));
                    picture.SetPixel(x, y, inverted);
                }
            }
            pictureBox2.Image = picture;
        }

        private Bitmap changeContrast(double value)
        {
            Bitmap picture = new Bitmap(pictureBox2.Image);
            double contrastValue = Math.Pow((100.0 + value) / 100.0, 2);
            for (int y = 0; (y <= (picture.Height - 1)); y++)
            {
                for (int x = 0; (x <= (picture.Width - 1)); x++)
                {
                    Color contrastCol = picture.GetPixel(x, y);

                    double Red = ((((contrastCol.R / 255.0) - 0.5) * contrastValue) + 0.5) * 255.0;
                    if (Red > 255)
                        Red = 255;
                    else if (Red < 0)
                        Red = 0;

                    double Green = (((contrastCol.G / 255.0 - 0.5) * contrastValue) + 0.5) * 255.0;
                    if (Green > 255)
                        Green = 255;
                    else if (Green < 0)
                        Green = 0;

                    double Blue = (((contrastCol.B / 255.0 - 0.5) * contrastValue) + 0.5) * 255.0;
                    if (Blue > 255)
                        Blue = 255;
                    else if (Blue < 0)
                        Blue = 0;

                    contrastCol = Color.FromArgb(255, Convert.ToInt32(Red), Convert.ToInt32(Green), Convert.ToInt32(Blue));
                    picture.SetPixel(x, y, contrastCol);

                }
            }
            return picture;
        }

        public void changeBrightness(double value)
        {
            Bitmap picture = new Bitmap(pictureBox2.Image);
            double brightValue = value / 100.0;
            for (int y = 0; (y <= (picture.Height - 1)); y++)
            {
                for (int x = 0; (x <= (picture.Width - 1)); x++)
                {
                    Color brightCol = picture.GetPixel(x, y);

                    double Red = ((brightCol.R / 255.0) + brightValue) * 255.0;
                    if (Red > 255)
                        Red = 255;
                    else if (Red < 0)
                        Red = 0;

                    double Green = ((brightCol.G / 255.0) + brightValue) * 255.0;
                    if (Green > 255)
                        Green = 255;
                    else if (Green < 0)
                        Green = 0;

                    double Blue = ((brightCol.B / 255.0) + brightValue) * 255.0;
                    if (Blue > 255)
                        Blue = 255;
                    else if (Blue < 0)
                        Blue = 0;

                    brightCol = Color.FromArgb(255, Convert.ToInt32(Red), Convert.ToInt32(Green), Convert.ToInt32(Blue));
                    picture.SetPixel(x, y, brightCol);
                }
            }
            pictureBox2.Image = picture;
         }

        public void changeGamma(double value)
        {
            Bitmap picture = new Bitmap(pictureBox2.Image);
            for (int y = 0; (y <= (picture.Height - 1)); y++)
            {
                for (int x = 0; (x <= (picture.Width - 1)); x++)
                {
                    Color brightCol = picture.GetPixel(x, y);

                    double Red = Math.Pow(brightCol.R / 255.0, value) * 255.0;
                    if (Red > 255)
                        Red = 255;
                    else if (Red < 0)
                        Red = 0;

                    double Green = Math.Pow(brightCol.G / 255.0, value) * 255.0;
                    if (Green > 255)
                        Green = 255;
                    else if (Green < 0)
                        Green = 0;

                    double Blue = Math.Pow(brightCol.B / 255.0, value) * 255.0;
                    if (Blue > 255)
                        Blue = 255;
                    else if (Blue < 0)
                        Blue = 0;

                    brightCol = Color.FromArgb(255, Convert.ToInt32(Red), Convert.ToInt32(Green), Convert.ToInt32(Blue));
                    picture.SetPixel(x, y, brightCol);
                }
            }
            pictureBox2.Image = picture;
        }

        public Bitmap Convolution(Matrix M)
        {
            Bitmap picture = new Bitmap(pictureBox2.Image);
            Bitmap pictureTmp = new Bitmap(pictureBox2.Image);
            for (int y = 1; (y <= (picture.Height - 2)); y++)
            {
                for (int x = 1; (x <= (picture.Width - 2)); x++)
                {
                    Color topLeftCol = pictureTmp.GetPixel(x - 1, y - 1);
                    Color topMidCol = pictureTmp.GetPixel(x, y - 1);
                    Color topRightCol = pictureTmp.GetPixel(x + 1, y - 1);
                    Color midLeftCol = pictureTmp.GetPixel(x - 1, y);
                    Color midCol = pictureTmp.GetPixel(x, y);
                    Color midRightCol = pictureTmp.GetPixel(x + 1, y);
                    Color botLeftCol = pictureTmp.GetPixel(x - 1, y + 1);
                    Color botMidCol = pictureTmp.GetPixel(x, y + 1);
                    Color botRightCol = pictureTmp.GetPixel(x + 1, y + 1);

                    int kernelSum = M.topLeft + M.topMid + M.topRight + M.midLeft + M.mid + M.midRight + M.botLeft + M.botMid + M.botRight;
                    if (kernelSum == 0)
                        kernelSum = 1;

                    double Red = (topLeftCol.R * M.topLeft + topMidCol.R * M.topMid + topRightCol.R * M.topRight + midLeftCol.R * M.midLeft +
                        midCol.R * M.mid + midRightCol.R * M.midRight + botLeftCol.R * M.botLeft + botMidCol.R * M.botMid + botRightCol.R * M.botRight) /
                        kernelSum;
                    if (Red > 255)
                        Red = 255;
                    else if (Red < 0)
                        Red = 0;

                    double Green = (topLeftCol.G * M.topLeft + topMidCol.G * M.topMid + topRightCol.G * M.topRight + midLeftCol.G * M.midLeft +
                        midCol.G * M.mid + midRightCol.G * M.midRight + botLeftCol.G * M.botLeft + botMidCol.G * M.botMid + botRightCol.G * M.botRight) /
                        kernelSum;
                    if (Green > 255)
                        Green = 255;
                    else if (Green < 0)
                        Green = 0;

                    double Blue = (topLeftCol.B * M.topLeft + topMidCol.B * M.topMid + topRightCol.B * M.topRight + midLeftCol.B * M.midLeft +
                        midCol.B * M.mid + midRightCol.B * M.midRight + botLeftCol.B * M.botLeft + botMidCol.B * M.botMid + botRightCol.B * M.botRight) /
                        kernelSum;
                    if (Blue > 255)
                        Blue = 255;
                    else if (Blue < 0)
                        Blue = 0;


                    midCol = Color.FromArgb(255, Convert.ToInt32(Red), Convert.ToInt32(Green), Convert.ToInt32(Blue));
                    picture.SetPixel(x, y, midCol);
                }
            }
            return picture;
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            uploadButton.Visible = true;
            buttonState(false);
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImageDialog = new OpenFileDialog();
            openImageDialog.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                PictureFile = openImageDialog.FileName;
                pictureBox1.Image = new Bitmap(PictureFile);
                pictureBox2.Image = new Bitmap(PictureFile);
                uploadButton.Visible = false;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                buttonState(true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.Show();
            form.Inversion();
        }

        private void contrastButton_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = changeContrast(-10.0);
        }

        private void contrastButton2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = changeContrast(10.0);
        }

        private void brigthnessButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.Show();
            form.Brightness(-10.0);
        }

        private void brigthnessButton2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.Show();
            form.Brightness(10.0);
        }

        private void gammaButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.Show();
            form.Gamma(0.8);
        }

        private void gammaButton2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.Show();
            form.Gamma(1.2);
        }

        private void blurButton_Click(object sender, EventArgs e)
        {
            Matrix M = new Matrix(1, 1, 1, 1, 1, 1, 1, 1, 1);
            pictureBox2.Image = Convolution(M);
        }

        private void sharpenButton_Click(object sender, EventArgs e)
        {
            Matrix M = new Matrix(0, -1, 0, -1, 5, -1, 0, -1, 0);
            pictureBox2.Image = Convolution(M);
        }

        private void gaussButton_Click(object sender, EventArgs e)
        {
            Matrix M = new Matrix(0, 1, 0, 1, 4, 1, 0, 1, 0);
            pictureBox2.Image = Convolution(M);
        }

        private void edgeButton_Click(object sender, EventArgs e)
        {
            Matrix M = new Matrix(-1, 0, 0, 0, 1, 0, 0, 0, 0);
            pictureBox2.Image = Convolution(M);
        }

        private void embossButton_Click(object sender, EventArgs e)
        {
            Matrix M = new Matrix(-1, -1, -1, 0, 1, 0, 1, 1, 1);
            pictureBox2.Image = Convolution(M);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void revertButton_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.Show();
        }

        private void ditheringApplyButton_Click(object sender, EventArgs e)
        {
            //Pre-defined normalized Bayer matrices
            int[,] Matrix2x2 = new int[,]
            {
               {51, 206},
               {153, 102}
            };
            int[,] Matrix3x3 = new int[,]
            {
               {153,204,102 },
               {26,0,77 },
               {128,51,179 }
            };
            int[,] Matrix4x4 = new int[,]
            {
                {15, 195,  60, 240},
                {135,  75, 180, 120},
                {45, 225,  30, 210},
                {165, 105, 150,  90}
            };
            int[,] Matrix6x6 = new int[,]
           {
                {172,227,117,186,241,131},
                {34,7,90,48,21,103},
                {145,62,200,159,76,214},
                {193,248,138,179,234,124},
                {55,28,110,41,14,96},
                {165,83,221,152,69,207}
           };
            int[,] Matix16x16 = new int[,]{
                                              { 0, 191,  48, 239,  12, 203,  60, 251,   3, 194,  51, 242,  15, 206,  63, 254  },
                                              { 127,  64, 175, 112, 139,  76, 187, 124, 130,  67, 178, 115, 142,  79, 190, 127  },
                                              { 32, 223,  16, 207,  44, 235,  28, 219,  35, 226,  19, 210,  47, 238,  31, 222  },
                                              { 159,  96, 143,  80, 171, 108, 155,  92, 162,  99, 146,  83, 174, 111, 158,  95  },
                                              { 8, 199,  56, 247,   4, 195,  52, 243,  11, 202,  59, 250,   7, 198,  55, 246  },
                                              { 135,  72, 183, 120, 131,  68, 179, 116, 138,  75, 186, 123, 134,  71, 182, 119  },
                                              { 40, 231,  24, 215,  36, 227,  20, 211,  43, 234,  27, 218,  39, 230,  23, 214  },
                                              { 167, 104, 151,  88, 163, 100, 147,  84, 170, 107, 154,  91, 166, 103, 150,  87  },
                                              { 2, 193,  50, 241,  14, 205,  62, 253,   1, 192,  49, 240,  13, 204,  61, 252  },
                                              { 129,  66, 177, 114, 141,  78, 189, 126, 128,  65, 176, 113, 140,  77, 188, 125  },
                                              { 34, 225,  18, 209,  46, 237,  30, 221,  33, 224,  17, 208,  45, 236,  29, 220  },
                                              { 161,  98, 145,  82, 173, 110, 157,  94, 160,  97, 144,  81, 172, 109, 156,  93  },
                                              { 10, 201,  58, 249,   6, 197,  54, 245,   9, 200,  57, 248,   5, 196,  53, 244  },
                                              { 137,  74, 185, 122, 133,  70, 181, 118, 136,  73, 184, 121, 132,  69, 180, 117  },
                                              { 42, 233,  26, 217,  38, 229,  22, 213,  41, 232,  25, 216,  37, 228,  21, 212  },
                                              { 169, 106, 153,  90, 165, 102, 149,  86, 168, 105, 152,  89, 164, 101, 148,  85  }
          };


            int[,] M = Matrix2x2;
            int k = Convert.ToInt32(ditheringK.SelectedItem.ToString());

            switch (k){
                case 2:
                    break;
                case 3:
                    M = Matrix3x3;
                    break;
                case 4:
                    M = Matrix4x4;
                    break;
                case 6:
                    M = Matrix6x6;
                    break;
                case 16:
                    M = Matix16x16;
                    break;
                default:
                    return;
            }

            
            Bitmap picture = new Bitmap(pictureBox2.Image);
            ImageConverter converter = new ImageConverter();

            int col = 0;
            int row = 0;

            for (int y = 0; y < picture.Height; y++)
            {
                row = y % k;

                for (int x = 0; x < picture.Width; x++)
                {
                    Color pixel = picture.GetPixel(x, y);
                    int R, G, B;

                    col = x % k;
                    if (pixel.R >= M[col, row])
                        R = 255;
                    else
                        R = 0;

                    if (pixel.G >= M[col, row])
                        G = 255;
                    else
                        G = 0;

                    if (pixel.B >= M[col, row])
                        B = 255;
                    else
                        B = 0;

                    Color color = Color.FromArgb(R, G, B);
                    picture.SetPixel(x, y, color);
                }

            }
            pictureBox2.Image = picture;

        }

        private void greyScaleButton_Click(object sender, EventArgs e)
        {
            Bitmap picture = new Bitmap(pictureBox2.Image);

            for (int y = 0; y < picture.Height; y++)
            {

                for (int x = 0; x < picture.Width; x++)
                {
                    Color col = picture.GetPixel(x, y);
                    int average = (col.R + col.G + col.B) / 3;
                    picture.SetPixel(x, y, Color.FromArgb(col.A, average, average, average));
                }
            }
            pictureBox2.Image = picture;
        }

        private void popalgApplyButton_Click(object sender, EventArgs e)
        {
            Bitmap picture = new Bitmap(pictureBox2.Image);
            Dictionary<Color, int> histogram = new Dictionary<Color, int>();
            int n = (int)numberOfColors.Value;
            int[,,] hist= new int[256, 256, 256];

            for (int y = 0; y < picture.Height; y++)
            {
                for (int x = 0; x < picture.Width; x++)
                {
                    Color col = picture.GetPixel(x, y);

                    //Masking a few of color's bits in order to group similar colors
                    byte mask = (byte)255 << 4 & 0xff;
                    col = Color.FromArgb(col.A, col.R & mask, col.G & mask, col.B & mask);
                    if (histogram.ContainsKey(col))
                        histogram[col]++;
                    else
                        histogram.Add(col, 1);
                    
                    hist[col.R, col.G, col.B]++;
                }
            }

            histogram = histogram.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            unsafe
            {
                BitmapData bData = picture.LockBits(new Rectangle(0, 0, picture.Width, picture.Height), ImageLockMode.ReadWrite, picture.PixelFormat);
                byte bitsPerPixel = (byte)Image.GetPixelFormatSize(picture.PixelFormat);
                byte* scan0 = (byte*)bData.Scan0.ToPointer();

                for (int y = 0; y < picture.Width; y++)
                {
                    for (int x = 0; x < picture.Height; x++)
                    {
                        /*Color col = bData.GetPixel(x, y);
                        picture.SetPixel(x, y, GetClosestColor(histogram, col, n));
                        */
                        byte* data = scan0 + x * bData.Stride + y * bitsPerPixel / 8;
                        Color newCol = GetClosestColor(histogram, Color.FromArgb(data[2], data[1], data[0]), n);
                        data[2] = newCol.R;
                        data[1] = newCol.G;
                        data[0] = newCol.B;
                    }
                }
                picture.UnlockBits(bData);
            }
            pictureBox2.Image = picture;

        }

        private Color GetClosestColor(Dictionary<Color, int> histogram, Color color, int n)
        {
            double distance = 5000;
            Color closestColor = new Color();
            if (n > histogram.Count)
                n = histogram.Count;

            for (int i = 0; i < n; i++)
            {
                double Red = Math.Pow(histogram.ElementAt(i).Key.R - color.R, 2);
                double Green = Math.Pow(histogram.ElementAt(i).Key.G - color.G, 2);
                double Blue = Math.Pow(histogram.ElementAt(i).Key.B - color.B, 2);
                double tempDistance = Math.Sqrt(Red + Green + Blue);

                if (tempDistance == 0)
                {
                    closestColor = histogram.ElementAt(i).Key;
                    break;
                }

                if (tempDistance < distance)
                {
                    distance = tempDistance;
                    closestColor = histogram.ElementAt(i).Key;
                }
            }

            return closestColor;
        }

        private void ycbcrButton_Click(object sender, EventArgs e)
        {
            Bitmap picture = new Bitmap(pictureBox2.Image);

            for (int x = 0; x < picture.Width; x++)
            {
                for (int y = 0; y < picture.Height; y++)
                {
                    Color colRgb = picture.GetPixel(x, y);
                    int fr = colRgb.R;
                    int fg = colRgb.G;
                    int fb = colRgb.B;

                    double Yy = (double)(0.299 * fr + 0.587 * fg + 0.114 * fb);
                    double Cb = (double)(128 -0.168736 * fr - 0.331264 * fg + 0.5 * fb);
                    double Cr = (double)(128 + 0.5 * fr - 0.418688 * fg - 0.081312 * fb);


                    if (Yy < 0) Yy = 0;
                    if (Yy > 255) Yy = 255;
                    if (Cb < 0) Cb = 0;
                    if (Cb > 255) Cb = 255;
                    if (Cr < 0) Cr = 0;
                    if (Cr > 255) Cr = 255;

                    Color colYCbCr = Color.FromArgb(colRgb.A, (int)Yy, (int)Cb, (int)Cr);
                    picture.SetPixel(x, y, colYCbCr);
                }
            }
            pictureBox2.Image = picture;
            ycbcrButton.Enabled = false;
            rgbButton.Enabled = true;
        }

        private void rgbButton_Click(object sender, EventArgs e)
        {
            Bitmap picture = new Bitmap(pictureBox2.Image);

            for (int x = 0; x < picture.Width; x++)
            {
                for (int y = 0; y < picture.Height; y++)
                {
                    Color colYCrCb = picture.GetPixel(x, y);
                    int Yy = colYCrCb.R;
                    int Cb = colYCrCb.G;
                    int Cr = colYCrCb.B;

                    double R = Yy + 1.402 * (Cr - 128);
                    double G = Yy - 0.34414 * (Cb - 128) - 0.71414 * (Cr - 128);
                    double B = Yy + 1.772 * (Cb - 128);

                    if (R < 0) R = 0;
                    if (R > 255) R = 255;
                    if (G < 0) G = 0;
                    if (G > 255) G = 255;
                    if (B < 0) B = 0;
                    if (B > 255) B = 255;

                    Color colYCbCr = Color.FromArgb(colYCrCb.A, (int)R, (int)G, (int)B);
                    picture.SetPixel(x, y, colYCbCr);
                }
            }
            pictureBox2.Image = picture;
            ycbcrButton.Enabled = true;
            rgbButton.Enabled = false;
        }
    }
}
