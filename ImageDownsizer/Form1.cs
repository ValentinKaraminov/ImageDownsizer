using System.Drawing.Drawing2D;
using System.Numerics;
using System.Windows.Forms;

namespace ImageDownsizer
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;
        private Bitmap downScaledImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        originalImage = new Bitmap(openFileDialog.FileName);
                        originalPictureBox.Image = originalImage;
                    }
                }
            }
        }
        
            

        private Bitmap DownscaleImageSequential(Bitmap originalImage, double downscalingFactor)
        {
            int newWidth = (int)(originalImage.Width * (downscalingFactor / 100));
            int newHeight = (int)(originalImage.Height * (downscalingFactor / 100));

            Bitmap downScaled = new Bitmap(newWidth, newHeight);

            for (int x = 0; x < newWidth; x++)
            {
                for (int y = 0; y < newHeight; y++)
                {
                    int originalX = (int)(x / downscalingFactor);
                    int originalY = (int)(y / downscalingFactor);
                    downScaled.SetPixel(x, y, originalImage.GetPixel(originalX, originalY));
                }
            }
            return downScaled;
        }

        private Bitmap DownscaleImageParallel(Bitmap originalImage, double downscalingFactor)
        {
            int newWidth = (int)(originalImage.Width * (downscalingFactor / 100));
            int newHeight = (int)(originalImage.Height * (downscalingFactor / 100));

            Bitmap downScaled = new Bitmap(newWidth, newHeight);

            Parallel.For(0, newWidth, x =>
            {
                for (int y = 0; y < newHeight; y++)
                {
                    int originalX = (int)(x / downscalingFactor);
                    int originalY = (int)(y / downscalingFactor);
                    downScaled.SetPixel(x, y, originalImage.GetPixel(originalX, originalY));
                }
            });
            return downScaled;
        }

        private void downscaleButton_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("Please select an image first.");
                return;
            }

            if (!double.TryParse(factorTextBox.Text, out double downscaleFactor))
            {
                MessageBox.Show("Invalid downscaling factor.");
                return;
            }

            bool isParallel = parallelRadioButton.Checked;

            if (isParallel)
            {
                downScaledImage = DownscaleImageParallel(originalImage, downscaleFactor);
            }
            else
            {
                downScaledImage = DownscaleImageSequential(originalImage, downscaleFactor);
            }

            originalPictureBox.Image = downScaledImage;
        }
    }
}